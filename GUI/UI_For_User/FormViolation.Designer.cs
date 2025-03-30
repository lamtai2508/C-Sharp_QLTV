namespace qltv.GUI.UI_For_User
{
    partial class FormViolation
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormViolation));
            this.lblTitle = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.panelSearch = new System.Windows.Forms.Panel();
            this.txtSearch = new System.Windows.Forms.TextBox();
            this.btnSearch = new System.Windows.Forms.Button();
            this.picSearchIcon = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.panelSearch.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picSearchIcon)).BeginInit();
            this.SuspendLayout();
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitle.Location = new System.Drawing.Point(20, 20);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(340, 32);
            this.lblTitle.TabIndex = 0;
            this.lblTitle.Text = "DANH SÁCH THÀNH VIÊN VI PHẠM";
            // 
            // dataGridView1
            // 
            this.dataGridView1.Anchor = (System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right));
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(20, 100);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(1080, 600);
            this.dataGridView1.TabIndex = 1;
            // 
            // panelSearch
            // 
            this.panelSearch.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panelSearch.Controls.Add(this.txtSearch);
            this.panelSearch.Controls.Add(this.btnSearch);
            this.panelSearch.Controls.Add(this.picSearchIcon);
            this.panelSearch.Location = new System.Drawing.Point(20, 60);
            this.panelSearch.Name = "panelSearch";
            this.panelSearch.Size = new System.Drawing.Size(1080, 30);
            this.panelSearch.TabIndex = 2;
            // 
            // txtSearch
            // 
            this.txtSearch.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtSearch.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.txtSearch.Location = new System.Drawing.Point(0, 0);
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.Size = new System.Drawing.Size(900, 25);
            this.txtSearch.TabIndex = 0;
            this.txtSearch.PlaceholderText = "Nhập từ khóa tìm kiếm...";
            // 
            // btnSearch
            // 
            this.btnSearch.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSearch.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.btnSearch.Location = new System.Drawing.Point(930, 0);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(100, 25);
            this.btnSearch.TabIndex = 1;
            this.btnSearch.Text = "Tìm kiếm";
            this.btnSearch.UseVisualStyleBackColor = true;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // picSearchIcon
            // 
            this.picSearchIcon.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.picSearchIcon.Image = ((System.Drawing.Image)(resources.GetObject("picSearchIcon.Image")));
            this.picSearchIcon.Location = new System.Drawing.Point(905, 5);
            this.picSearchIcon.Name = "picSearchIcon";
            this.picSearchIcon.Size = new System.Drawing.Size(20, 20);
            this.picSearchIcon.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picSearchIcon.TabIndex = 2;
            this.picSearchIcon.TabStop = false;
            // 
            // FormViolation
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1120, 720);
            this.Controls.Add(this.panelSearch);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.lblTitle);
            this.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Name = "FormViolation";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Danh sách vi phạm";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.panelSearch.ResumeLayout(false);
            this.panelSearch.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picSearchIcon)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        #endregion

        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Panel panelSearch;
        private System.Windows.Forms.TextBox txtSearch;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.PictureBox picSearchIcon;
    }
}