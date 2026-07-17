using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RestApiClientApp
{
    public partial class Form1 : Form
    {
        public class Post
        {
            public int UserId { get; set; }
            public int Id { get; set; }
            public string Title { get; set; } = "";
            public string Body { get; set; } = "";
        }
        private static readonly HttpClient httpClient = new HttpClient();

        private DataTable postsTable = new DataTable();

        private void UpdateRecordCount()
        {
            lblRecordCount.Text = $"Records: {postsTable.Rows.Count}";
        }

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            txtApiUrl.Text = "https://jsonplaceholder.typicode.com/posts";

            postsTable.Columns.Add("User ID", typeof(int));
            postsTable.Columns.Add("Post ID", typeof(int));
            postsTable.Columns.Add("Title", typeof(string));
            postsTable.Columns.Add("Body", typeof(string));

            dgvPosts.DataSource = postsTable;

            lblRecordCount.Text = "Records: 0";

            txtPostId.Focus();

        }

        private async void btnGetPosts_Click(object sender, EventArgs e)
        {
            string apiUrl = txtApiUrl.Text.Trim();

            if (apiUrl == "")
            {
                MessageBox.Show("Please enter the API URL.",
                                "Missing API URL",
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Warning);

                txtApiUrl.Focus();
                return;
            }

            try
            {
                btnGetPosts.Enabled = false;
                btnGetSinglePost.Enabled = false;

                string json = await httpClient.GetStringAsync(apiUrl);

                rtbJson.Text = json;

                JsonSerializerOptions options = new JsonSerializerOptions
                {
                    PropertyNameCaseInsensitive = true
                };

                List<Post> posts = JsonSerializer.Deserialize<List<Post>>(json, options);

                postsTable.Rows.Clear();

                if (posts != null)
                {
                    foreach (Post post in posts)
                    {
                        postsTable.Rows.Add(post.UserId,
                                            post.Id,
                                            post.Title,
                                            post.Body);
                    }
                }

                UpdateRecordCount();

                MessageBox.Show("Posts loaded successfully.",
                                "API Request Complete",
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error loading posts.\n\n" + ex.Message,
                                "API Error",
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Error);
            }
            finally
            {
                btnGetPosts.Enabled = true;
                btnGetSinglePost.Enabled = true;
            }

        }

        private async void btnGetSinglePost_Click(object sender, EventArgs e)
        {
            string apiUrl = txtApiUrl.Text.Trim();

            if (apiUrl == "")
            {
                MessageBox.Show("Please enter the API URL.",
                                "Missing API URL",
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Warning);

                txtApiUrl.Focus();
                return;
            }

            if (!int.TryParse(txtPostId.Text.Trim(), out int postId))
            {
                MessageBox.Show("Please enter a valid Post ID.",
                                "Invalid Post ID",
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Warning);

                txtPostId.Focus();
                return;
            }

            if (postId <= 0)
            {
                MessageBox.Show("Post ID must be greater than zero.",
                                "Invalid Post ID",
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Warning);

                txtPostId.Focus();
                return;
            }

            string singlePostUrl = apiUrl.TrimEnd('/') + "/" + postId;

            try
            {
                btnGetPosts.Enabled = false;
                btnGetSinglePost.Enabled = false;

                string json = await httpClient.GetStringAsync(singlePostUrl);

                rtbJson.Text = json;

                JsonSerializerOptions options = new JsonSerializerOptions
                {
                    PropertyNameCaseInsensitive = true
                };

                Post post = JsonSerializer.Deserialize<Post>(json, options);

                postsTable.Rows.Clear();

                if (post != null && post.Id != 0)
                {
                    postsTable.Rows.Add(post.UserId,
                                        post.Id,
                                        post.Title,
                                        post.Body);
                }
                else
                {
                    MessageBox.Show("No post found for the selected ID.",
                                    "No Record",
                                    MessageBoxButtons.OK,
                                    MessageBoxIcon.Information);
                }

                UpdateRecordCount();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error loading post.\n\n" + ex.Message,
                                "API Error",
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Error);
            }
            finally
            {
                btnGetPosts.Enabled = true;
                btnGetSinglePost.Enabled = true;
            }

        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            postsTable.Rows.Clear();
            rtbJson.Clear();
            txtPostId.Clear();

            UpdateRecordCount();

            txtPostId.Focus();

        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Are you sure you want to exit?",
                                      "Confirm Exit",
                                      MessageBoxButtons.YesNo,
                                      MessageBoxIcon.Question);

            if (result == DialogResult.Yes)
            {
                Application.Exit();
            }

        }
    }
}
