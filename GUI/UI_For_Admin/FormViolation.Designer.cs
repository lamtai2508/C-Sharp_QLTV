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
            lblTitle = new Label();
            dataGridView1 = new DataGridView();
            panelSearch = new Panel();
            txtSearch = new TextBox();
            btnSearch = new Button();
            picSearchIcon = new PictureBox();
            panelInput = new Panel();
            tbViolationId = new TextBox();
            tbMemberId = new TextBox();
            tbViolationDate = new TextBox();
            tbViolationType = new TextBox();
            tbPenalty = new TextBox();
            cbStatus = new ComboBox();
            lblViolationId = new Label();
            lblMemberId = new Label();
            lblViolationDate = new Label();
            lblViolationType = new Label();
            lblPenalty = new Label();
            lblStatus = new Label();
            flowLayoutPanelButtons = new FlowLayoutPanel();
            btnAdd = new Button();
            btnUpdate = new Button();
            btnDelete = new Button();
            btnLoadData = new Button();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            panelSearch.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)picSearchIcon).BeginInit();
            panelInput.SuspendLayout();
            flowLayoutPanelButtons.SuspendLayout();
            SuspendLayout();
            // 
            // lblTitle
            // 
            lblTitle.AutoSize = true;
            lblTitle.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblTitle.Location = new Point(20, 20);
            lblTitle.Name = "lblTitle";
            lblTitle.Size = new Size(528, 41);
            lblTitle.TabIndex = 0;
            lblTitle.Text = "DANH SÁCH THÀNH VIÊN VI PHẠM";
            // 
            // dataGridView1
            // 
            dataGridView1.AllowUserToResizeColumns = false;
            dataGridView1.AllowUserToResizeRows = false;
            dataGridView1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridView1.BackgroundColor = Color.White;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(20, 350);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.Size = new Size(1080, 350);
            dataGridView1.TabIndex = 1;
            dataGridView1.CellClick += dataGridView1_CellClick;
            // 
            // panelSearch
            // 
            panelSearch.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            panelSearch.Controls.Add(txtSearch);
            panelSearch.Controls.Add(btnSearch);
            panelSearch.Controls.Add(picSearchIcon);
            panelSearch.Location = new Point(20, 300);
            panelSearch.Name = "panelSearch";
            panelSearch.Size = new Size(1080, 30);
            panelSearch.TabIndex = 2;
            // 
            // txtSearch
            // 
            txtSearch.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            txtSearch.Font = new Font("Segoe UI", 10F);
            txtSearch.Location = new Point(0, 0);
            txtSearch.Name = "txtSearch";
            txtSearch.PlaceholderText = "Nhập từ khóa tìm kiếm...";
            txtSearch.Size = new Size(900, 30);
            txtSearch.TabIndex = 0;
            // 
            // btnSearch
            // 
            btnSearch.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnSearch.BackColor = Color.FromArgb(49, 176, 182);
            btnSearch.Font = new Font("Segoe UI", 10F);
            btnSearch.ForeColor = Color.White;
            btnSearch.Location = new Point(930, 0);
            btnSearch.Name = "btnSearch";
            btnSearch.Size = new Size(100, 30);
            btnSearch.TabIndex = 1;
            btnSearch.Text = "Tìm kiếm";
            btnSearch.UseVisualStyleBackColor = false;
            btnSearch.Click += btnSearch_Click;
            // 
            // picSearchIcon
            // 
            picSearchIcon.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            picSearchIcon.Location = new Point(905, 5);
            picSearchIcon.Name = "picSearchIcon";
            picSearchIcon.Size = new Size(20, 20);
            picSearchIcon.SizeMode = PictureBoxSizeMode.StretchImage;
            picSearchIcon.TabIndex = 2;
            picSearchIcon.TabStop = false;
            // 
            // panelInput
            // 
            panelInput.AutoSize = true;
            panelInput.Controls.Add(tbViolationId);
            panelInput.Controls.Add(tbMemberId);
            panelInput.Controls.Add(tbViolationDate);
            panelInput.Controls.Add(tbViolationType);
            panelInput.Controls.Add(tbPenalty);
            panelInput.Controls.Add(cbStatus);
            panelInput.Controls.Add(lblViolationId);
            panelInput.Controls.Add(lblMemberId);
            panelInput.Controls.Add(lblViolationDate);
            panelInput.Controls.Add(lblViolationType);
            panelInput.Controls.Add(lblPenalty);
            panelInput.Controls.Add(lblStatus);
            panelInput.Dock = DockStyle.Top;
            panelInput.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            panelInput.Location = new Point(0, 0);
            panelInput.Name = "panelInput";
            panelInput.Padding = new Padding(50, 0, 0, 0);
            panelInput.Size = new Size(1120, 220);
            panelInput.TabIndex = 3;
            // 
            // tbViolationId
            // 
            tbViolationId.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left;
            tbViolationId.Location = new Point(241, 36);
            tbViolationId.Name = "tbViolationId";
            tbViolationId.ReadOnly = true;
            tbViolationId.Size = new Size(370, 34);
            tbViolationId.TabIndex = 4;
            // 
            // tbMemberId
            // 
            tbMemberId.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left;
            tbMemberId.Location = new Point(241, 96);
            tbMemberId.Name = "tbMemberId";
            tbMemberId.Size = new Size(370, 34);
            tbMemberId.TabIndex = 5;
            // 
            // tbViolationDate
            // 
            tbViolationDate.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left;
            tbViolationDate.Location = new Point(241, 156);
            tbViolationDate.Name = "tbViolationDate";
            tbViolationDate.Size = new Size(370, 34);
            tbViolationDate.TabIndex = 6;
            // 
            // tbViolationType
            // 
            tbViolationType.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left;
            tbViolationType.Location = new Point(778, 36);
            tbViolationType.Name = "tbViolationType";
            tbViolationType.Size = new Size(370, 34);
            tbViolationType.TabIndex = 7;
            // 
            // tbPenalty
            // 
            tbPenalty.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left;
            tbPenalty.Location = new Point(778, 96);
            tbPenalty.Name = "tbPenalty";
            tbPenalty.Size = new Size(370, 34);
            tbPenalty.TabIndex = 8;
            // 
            // cbStatus
            // 
            cbStatus.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left;
            cbStatus.DropDownStyle = ComboBoxStyle.DropDownList;
            cbStatus.Items.AddRange(new object[] { "Cánh cáo", "Phạt đền bù", "Khóa tạm thời", "Khóa vĩnh viễn" });
            cbStatus.Location = new Point(778, 156);
            cbStatus.Name = "cbStatus";
            cbStatus.Size = new Size(370, 36);
            cbStatus.TabIndex = 9;
            // 
            // lblViolationId
            // 
            lblViolationId.AutoSize = true;
            lblViolationId.Font = new Font("Segoe UI", 12F, FontStyle.Bold | FontStyle.Underline, GraphicsUnit.Point, 0);
            lblViolationId.Location = new Point(81, 36);
            lblViolationId.Name = "lblViolationId";
            lblViolationId.Size = new Size(124, 28);
            lblViolationId.TabIndex = 0;
            lblViolationId.Text = "Mã vi phạm";
            // 
            // lblMemberId
            // 
            lblMemberId.AutoSize = true;
            lblMemberId.Font = new Font("Segoe UI", 12F, FontStyle.Bold | FontStyle.Underline, GraphicsUnit.Point, 0);
            lblMemberId.Location = new Point(81, 96);
            lblMemberId.Name = "lblMemberId";
            lblMemberId.Size = new Size(149, 28);
            lblMemberId.TabIndex = 1;
            lblMemberId.Text = "Mã thành viên";
            // 
            // lblViolationDate
            // 
            lblViolationDate.AutoSize = true;
            lblViolationDate.Font = new Font("Segoe UI", 12F, FontStyle.Bold | FontStyle.Underline, GraphicsUnit.Point, 0);
            lblViolationDate.Location = new Point(81, 156);
            lblViolationDate.Name = "lblViolationDate";
            lblViolationDate.Size = new Size(144, 28);
            lblViolationDate.TabIndex = 2;
            lblViolationDate.Text = "Ngày vi phạm";
            // 
            // lblViolationType
            // 
            lblViolationType.AutoSize = true;
            lblViolationType.Font = new Font("Segoe UI", 12F, FontStyle.Bold | FontStyle.Underline, GraphicsUnit.Point, 0);
            lblViolationType.Location = new Point(634, 36);
            lblViolationType.Name = "lblViolationType";
            lblViolationType.Size = new Size(68, 28);
            lblViolationType.TabIndex = 3;
            lblViolationType.Text = "Mô tả";
            // 
            // lblPenalty
            // 
            lblPenalty.AutoSize = true;
            lblPenalty.Font = new Font("Segoe UI", 12F, FontStyle.Bold | FontStyle.Underline, GraphicsUnit.Point, 0);
            lblPenalty.Location = new Point(634, 96);
            lblPenalty.Name = "lblPenalty";
            lblPenalty.Size = new Size(87, 28);
            lblPenalty.TabIndex = 4;
            lblPenalty.Text = "Xử phạt";
            // 
            // lblStatus
            // 
            lblStatus.AutoSize = true;
            lblStatus.Font = new Font("Segoe UI", 12F, FontStyle.Bold | FontStyle.Underline, GraphicsUnit.Point, 0);
            lblStatus.Location = new Point(634, 156);
            lblStatus.Name = "lblStatus";
            lblStatus.Size = new Size(108, 28);
            lblStatus.TabIndex = 5;
            lblStatus.Text = "Trạng thái";
            // 
            // flowLayoutPanelButtons
            // 
            flowLayoutPanelButtons.AutoSize = true;
            flowLayoutPanelButtons.Controls.Add(btnAdd);
            flowLayoutPanelButtons.Controls.Add(btnUpdate);
            flowLayoutPanelButtons.Controls.Add(btnDelete);
            flowLayoutPanelButtons.Controls.Add(btnLoadData);
            flowLayoutPanelButtons.Location = new Point(20, 240);
            flowLayoutPanelButtons.Name = "flowLayoutPanelButtons";
            flowLayoutPanelButtons.Size = new Size(929, 47);
            flowLayoutPanelButtons.TabIndex = 4;
            // 
            // btnAdd
            // 
            btnAdd.AutoSize = true;
            btnAdd.BackColor = Color.FromArgb(49, 176, 182);
            btnAdd.Cursor = Cursors.Hand;
            btnAdd.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnAdd.ForeColor = Color.White;
            btnAdd.Location = new Point(200, 3);
            btnAdd.Margin = new Padding(200, 3, 30, 3);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(150, 41);
            btnAdd.TabIndex = 0;
            btnAdd.Text = "Thêm";
            btnAdd.UseVisualStyleBackColor = false;
            btnAdd.Click += btnAdd_Click;
            // 
            // btnUpdate
            // 
            btnUpdate.AutoSize = true;
            btnUpdate.BackColor = Color.FromArgb(49, 176, 182);
            btnUpdate.Cursor = Cursors.Hand;
            btnUpdate.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnUpdate.ForeColor = Color.White;
            btnUpdate.Location = new Point(383, 3);
            btnUpdate.Name = "btnUpdate";
            btnUpdate.Size = new Size(150, 41);
            btnUpdate.TabIndex = 1;
            btnUpdate.Text = "Sửa";
            btnUpdate.UseVisualStyleBackColor = false;
            btnUpdate.Click += btnUpdate_Click;
            // 
            // btnDelete
            // 
            btnDelete.AutoSize = true;
            btnDelete.BackColor = Color.FromArgb(49, 176, 182);
            btnDelete.Cursor = Cursors.Hand;
            btnDelete.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnDelete.ForeColor = Color.White;
            btnDelete.Location = new Point(566, 3);
            btnDelete.Margin = new Padding(30, 3, 3, 3);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(150, 41);
            btnDelete.TabIndex = 2;
            btnDelete.Text = "Xóa";
            btnDelete.UseVisualStyleBackColor = false;
            btnDelete.Click += btnDelete_Click;
            // 
            // btnLoadData
            // 
            btnLoadData.AutoSize = true;
            btnLoadData.BackColor = Color.FromArgb(49, 176, 182);
            btnLoadData.Cursor = Cursors.Hand;
            btnLoadData.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnLoadData.ForeColor = Color.White;
            btnLoadData.Location = new Point(749, 3);
            btnLoadData.Margin = new Padding(30, 3, 30, 3);
            btnLoadData.Name = "btnLoadData";
            btnLoadData.Size = new Size(150, 41);
            btnLoadData.TabIndex = 3;
            btnLoadData.Text = "Làm mới";
            btnLoadData.UseVisualStyleBackColor = false;
            btnLoadData.Click += btnLoadData_Click;
            // 
            // FormViolation
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1120, 720);
            Controls.Add(flowLayoutPanelButtons);
            Controls.Add(panelInput);
            Controls.Add(panelSearch);
            Controls.Add(dataGridView1);
            Controls.Add(lblTitle);
            Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Name = "FormViolation";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Danh sách vi phạm";
            Load += FormViolation_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            panelSearch.ResumeLayout(false);
            panelSearch.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)picSearchIcon).EndInit();
            panelInput.ResumeLayout(false);
            panelInput.PerformLayout();
            flowLayoutPanelButtons.ResumeLayout(false);
            flowLayoutPanelButtons.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Panel panelSearch;
        private System.Windows.Forms.TextBox txtSearch;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.PictureBox picSearchIcon;
        private System.Windows.Forms.Panel panelInput;
        private System.Windows.Forms.TextBox tbViolationId;
        private System.Windows.Forms.TextBox tbMemberId;
        private System.Windows.Forms.TextBox tbViolationDate;
        private System.Windows.Forms.TextBox tbViolationType;
        private System.Windows.Forms.TextBox tbPenalty;
        private System.Windows.Forms.ComboBox cbStatus;
        private System.Windows.Forms.Label lblViolationId;
        private System.Windows.Forms.Label lblMemberId;
        private System.Windows.Forms.Label lblViolationDate;
        private System.Windows.Forms.Label lblViolationType;
        private System.Windows.Forms.Label lblPenalty;
        private System.Windows.Forms.Label lblStatus;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanelButtons;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnLoadData;
    }
}