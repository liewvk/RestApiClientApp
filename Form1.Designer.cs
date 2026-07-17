namespace RestApiClientApp
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.lblTitle = new System.Windows.Forms.Label();
            this.lblApiUrl = new System.Windows.Forms.Label();
            this.txtApiUrl = new System.Windows.Forms.TextBox();
            this.lblPostId = new System.Windows.Forms.Label();
            this.txtPostId = new System.Windows.Forms.TextBox();
            this.btnGetPosts = new System.Windows.Forms.Button();
            this.btnGetSinglePost = new System.Windows.Forms.Button();
            this.btnClear = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.dgvPosts = new System.Windows.Forms.DataGridView();
            this.lblRecordCount = new System.Windows.Forms.Label();
            this.lblRawJson = new System.Windows.Forms.Label();
            this.rtbJson = new System.Windows.Forms.RichTextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPosts)).BeginInit();
            this.SuspendLayout();
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new System.Drawing.Font("Segoe UI", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitle.Location = new System.Drawing.Point(321, 20);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(282, 38);
            this.lblTitle.TabIndex = 0;
            this.lblTitle.Text = "REST API Client App";
            // 
            // lblApiUrl
            // 
            this.lblApiUrl.AutoSize = true;
            this.lblApiUrl.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblApiUrl.Location = new System.Drawing.Point(90, 74);
            this.lblApiUrl.Name = "lblApiUrl";
            this.lblApiUrl.Size = new System.Drawing.Size(84, 22);
            this.lblApiUrl.TabIndex = 1;
            this.lblApiUrl.Text = "API URL:";
            // 
            // txtApiUrl
            // 
            this.txtApiUrl.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtApiUrl.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtApiUrl.Location = new System.Drawing.Point(181, 71);
            this.txtApiUrl.Name = "txtApiUrl";
            this.txtApiUrl.Size = new System.Drawing.Size(600, 28);
            this.txtApiUrl.TabIndex = 2;
            this.txtApiUrl.Text = "https://jsonplaceholder.typicode.com/posts";
            // 
            // lblPostId
            // 
            this.lblPostId.AutoSize = true;
            this.lblPostId.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPostId.Location = new System.Drawing.Point(32, 131);
            this.lblPostId.Name = "lblPostId";
            this.lblPostId.Size = new System.Drawing.Size(73, 22);
            this.lblPostId.TabIndex = 1;
            this.lblPostId.Text = "Post ID:";
            // 
            // txtPostId
            // 
            this.txtPostId.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtPostId.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPostId.Location = new System.Drawing.Point(123, 133);
            this.txtPostId.Name = "txtPostId";
            this.txtPostId.Size = new System.Drawing.Size(162, 28);
            this.txtPostId.TabIndex = 3;
            // 
            // btnGetPosts
            // 
            this.btnGetPosts.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGetPosts.Location = new System.Drawing.Point(332, 123);
            this.btnGetPosts.Name = "btnGetPosts";
            this.btnGetPosts.Size = new System.Drawing.Size(131, 39);
            this.btnGetPosts.TabIndex = 4;
            this.btnGetPosts.Text = "Get All Posts";
            this.btnGetPosts.UseVisualStyleBackColor = true;
            this.btnGetPosts.Click += new System.EventHandler(this.btnGetPosts_Click);
            // 
            // btnGetSinglePost
            // 
            this.btnGetSinglePost.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGetSinglePost.Location = new System.Drawing.Point(486, 127);
            this.btnGetSinglePost.Name = "btnGetSinglePost";
            this.btnGetSinglePost.Size = new System.Drawing.Size(153, 34);
            this.btnGetSinglePost.TabIndex = 5;
            this.btnGetSinglePost.Text = "Get Post by ID";
            this.btnGetSinglePost.UseVisualStyleBackColor = true;
            this.btnGetSinglePost.Click += new System.EventHandler(this.btnGetSinglePost_Click);
            // 
            // btnClear
            // 
            this.btnClear.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClear.Location = new System.Drawing.Point(657, 125);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(151, 34);
            this.btnClear.TabIndex = 6;
            this.btnClear.Text = "Clear";
            this.btnClear.UseVisualStyleBackColor = true;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // btnExit
            // 
            this.btnExit.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExit.Location = new System.Drawing.Point(834, 125);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(121, 34);
            this.btnExit.TabIndex = 7;
            this.btnExit.Text = "Exit";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // dgvPosts
            // 
            this.dgvPosts.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvPosts.Location = new System.Drawing.Point(35, 449);
            this.dgvPosts.Name = "dgvPosts";
            this.dgvPosts.RowHeadersWidth = 51;
            this.dgvPosts.RowTemplate.Height = 24;
            this.dgvPosts.Size = new System.Drawing.Size(920, 214);
            this.dgvPosts.TabIndex = 8;
            // 
            // lblRecordCount
            // 
            this.lblRecordCount.AutoSize = true;
            this.lblRecordCount.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRecordCount.Location = new System.Drawing.Point(343, 176);
            this.lblRecordCount.Name = "lblRecordCount";
            this.lblRecordCount.Size = new System.Drawing.Size(97, 22);
            this.lblRecordCount.TabIndex = 9;
            this.lblRecordCount.Text = "Records: 0";
            // 
            // lblRawJson
            // 
            this.lblRawJson.AutoSize = true;
            this.lblRawJson.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRawJson.Location = new System.Drawing.Point(32, 215);
            this.lblRawJson.Name = "lblRawJson";
            this.lblRawJson.Size = new System.Drawing.Size(104, 22);
            this.lblRawJson.TabIndex = 10;
            this.lblRawJson.Text = "Raw JSON:";
            // 
            // rtbJson
            // 
            this.rtbJson.Location = new System.Drawing.Point(35, 240);
            this.rtbJson.Name = "rtbJson";
            this.rtbJson.Size = new System.Drawing.Size(920, 180);
            this.rtbJson.TabIndex = 11;
            this.rtbJson.Text = "";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(982, 700);
            this.Controls.Add(this.rtbJson);
            this.Controls.Add(this.lblRawJson);
            this.Controls.Add(this.lblRecordCount);
            this.Controls.Add(this.dgvPosts);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.btnGetSinglePost);
            this.Controls.Add(this.btnGetPosts);
            this.Controls.Add(this.txtPostId);
            this.Controls.Add(this.txtApiUrl);
            this.Controls.Add(this.lblPostId);
            this.Controls.Add(this.lblApiUrl);
            this.Controls.Add(this.lblTitle);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "REST API Client App";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvPosts)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Label lblApiUrl;
        private System.Windows.Forms.TextBox txtApiUrl;
        private System.Windows.Forms.Label lblPostId;
        private System.Windows.Forms.TextBox txtPostId;
        private System.Windows.Forms.Button btnGetPosts;
        private System.Windows.Forms.Button btnGetSinglePost;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.DataGridView dgvPosts;
        private System.Windows.Forms.Label lblRecordCount;
        private System.Windows.Forms.Label lblRawJson;
        private System.Windows.Forms.RichTextBox rtbJson;
    }
}

