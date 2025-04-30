namespace qltv.GUI.UI_For_Admin
{
    partial class FormDevice
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
            lblDeviceId = new Label();
            lblDeviceName = new Label();
            lblDeviceType = new Label();
            lblStatus = new Label();
            txtDeviceId = new TextBox();
            txtDeviceName = new TextBox();
            txtDeviceType = new TextBox();
            cmbStatus = new ComboBox();
            dgvDevices = new DataGridView();
            btnAdd = new Button();
            btnEdit = new Button();
            btnDelete = new Button();
            btnRefresh = new Button();
            lblSearch = new Label();
            txtSearch = new TextBox();
            btnSearch = new Button();
            btnImportExcel = new Button();
            btnBulkDelete = new Button();
            ((System.ComponentModel.ISupportInitialize)dgvDevices).BeginInit();
            SuspendLayout();
            // 
            // lblTitle
            // 
            lblTitle.AutoSize = true;
            lblTitle.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblTitle.Location = new Point(20, 25);
            lblTitle.Name = "lblTitle";
            lblTitle.Size = new Size(278, 41);
            lblTitle.TabIndex = 0;
            lblTitle.Text = "QUẢN LÝ THIẾT BỊ";
            // 
            // lblDeviceId
            // 
            lblDeviceId.AutoSize = true;
            lblDeviceId.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblDeviceId.Location = new Point(20, 100);
            lblDeviceId.Name = "lblDeviceId";
            lblDeviceId.Size = new Size(117, 28);
            lblDeviceId.TabIndex = 1;
            lblDeviceId.Text = "Mã thiết bị";
            // 
            // lblDeviceName
            // 
            lblDeviceName.AutoSize = true;
            lblDeviceName.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblDeviceName.Location = new Point(20, 150);
            lblDeviceName.Name = "lblDeviceName";
            lblDeviceName.Size = new Size(120, 28);
            lblDeviceName.TabIndex = 2;
            lblDeviceName.Text = "Tên thiết bị";
            // 
            // lblDeviceType
            // 
            lblDeviceType.AutoSize = true;
            lblDeviceType.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblDeviceType.Location = new Point(20, 200);
            lblDeviceType.Name = "lblDeviceType";
            lblDeviceType.Size = new Size(126, 28);
            lblDeviceType.TabIndex = 3;
            lblDeviceType.Text = "Loại thiết bị";
            // 
            // lblStatus
            // 
            lblStatus.AutoSize = true;
            lblStatus.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblStatus.Location = new Point(20, 250);
            lblStatus.Name = "lblStatus";
            lblStatus.Size = new Size(108, 28);
            lblStatus.TabIndex = 4;
            lblStatus.Text = "Trạng thái";
            // 
            // txtDeviceId
            // 
            txtDeviceId.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtDeviceId.Location = new Point(160, 100);
            txtDeviceId.Margin = new Padding(3, 4, 3, 4);
            txtDeviceId.Name = "txtDeviceId";
            txtDeviceId.Size = new Size(250, 34);
            txtDeviceId.TabIndex = 5;
            // 
            // txtDeviceName
            // 
            txtDeviceName.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtDeviceName.Location = new Point(160, 150);
            txtDeviceName.Margin = new Padding(3, 4, 3, 4);
            txtDeviceName.Name = "txtDeviceName";
            txtDeviceName.Size = new Size(250, 34);
            txtDeviceName.TabIndex = 6;
            // 
            // txtDeviceType
            // 
            txtDeviceType.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtDeviceType.Location = new Point(160, 200);
            txtDeviceType.Margin = new Padding(3, 4, 3, 4);
            txtDeviceType.Name = "txtDeviceType";
            txtDeviceType.Size = new Size(250, 34);
            txtDeviceType.TabIndex = 7;
            // 
            // cmbStatus
            // 
            cmbStatus.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbStatus.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            cmbStatus.FormattingEnabled = true;
            cmbStatus.Location = new Point(160, 250);
            cmbStatus.Margin = new Padding(3, 4, 3, 4);
            cmbStatus.Name = "cmbStatus";
            cmbStatus.Size = new Size(250, 36);
            cmbStatus.TabIndex = 8;
            // 
            // dgvDevices
            // 
            dgvDevices.AllowUserToAddRows = false;
            dgvDevices.AllowUserToDeleteRows = false;
            dgvDevices.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            dgvDevices.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvDevices.BackgroundColor = SystemColors.ButtonHighlight;
            dgvDevices.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvDevices.Location = new Point(20, 450);
            dgvDevices.Margin = new Padding(3, 4, 3, 4);
            dgvDevices.Name = "dgvDevices";
            dgvDevices.ReadOnly = true;
            dgvDevices.RowHeadersWidth = 51;
            dgvDevices.RowTemplate.Height = 24;
            dgvDevices.Size = new Size(900, 200);
            dgvDevices.TabIndex = 16;
            // 
            // btnAdd
            // 
            btnAdd.BackColor = Color.FromArgb(128, 255, 128);
            btnAdd.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnAdd.Location = new Point(450, 100);
            btnAdd.Margin = new Padding(3, 4, 3, 4);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(150, 50);
            btnAdd.TabIndex = 9;
            btnAdd.Text = "Thêm";
            btnAdd.UseVisualStyleBackColor = false;
            // 
            // btnEdit
            // 
            btnEdit.BackColor = Color.FromArgb(128, 255, 128);
            btnEdit.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnEdit.Location = new Point(450, 162);
            btnEdit.Margin = new Padding(3, 4, 3, 4);
            btnEdit.Name = "btnEdit";
            btnEdit.Size = new Size(150, 50);
            btnEdit.TabIndex = 10;
            btnEdit.Text = "Sửa";
            btnEdit.UseVisualStyleBackColor = false;
            // 
            // btnDelete
            // 
            btnDelete.BackColor = Color.FromArgb(128, 255, 128);
            btnDelete.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnDelete.Location = new Point(450, 225);
            btnDelete.Margin = new Padding(3, 4, 3, 4);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(150, 50);
            btnDelete.TabIndex = 11;
            btnDelete.Text = "Xóa";
            btnDelete.UseVisualStyleBackColor = false;
            // 
            // btnRefresh
            // 
            btnRefresh.BackColor = Color.FromArgb(128, 255, 128);
            btnRefresh.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnRefresh.Location = new Point(610, 225);
            btnRefresh.Margin = new Padding(3, 4, 3, 4);
            btnRefresh.Name = "btnRefresh";
            btnRefresh.Size = new Size(150, 50);
            btnRefresh.TabIndex = 12;
            btnRefresh.Text = "Làm mới";
            btnRefresh.UseVisualStyleBackColor = false;
            // 
            // lblSearch
            // 
            lblSearch.AutoSize = true;
            lblSearch.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblSearch.Location = new Point(20, 380);
            lblSearch.Name = "lblSearch";
            lblSearch.Size = new Size(100, 28);
            lblSearch.TabIndex = 13;
            lblSearch.Text = "Tìm kiếm";
            // 
            // txtSearch
            // 
            txtSearch.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtSearch.Location = new Point(160, 380);
            txtSearch.Margin = new Padding(3, 4, 3, 4);
            txtSearch.Name = "txtSearch";
            txtSearch.Size = new Size(300, 34);
            txtSearch.TabIndex = 14;
            // 
            // btnSearch
            // 
            btnSearch.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnSearch.Location = new Point(470, 380);
            btnSearch.Margin = new Padding(3, 4, 3, 4);
            btnSearch.Name = "btnSearch";
            btnSearch.Size = new Size(100, 42);
            btnSearch.TabIndex = 15;
            btnSearch.Text = "Tìm";
            btnSearch.UseVisualStyleBackColor = true;
            // 
            // btnImportExcel
            // 
            btnImportExcel.BackColor = Color.FromArgb(192, 192, 255);
            btnImportExcel.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnImportExcel.Location = new Point(610, 100);
            btnImportExcel.Margin = new Padding(3, 4, 3, 4);
            btnImportExcel.Name = "btnImportExcel";
            btnImportExcel.Size = new Size(200, 50);
            btnImportExcel.TabIndex = 17;
            btnImportExcel.Text = "Nhập từ Excel";
            btnImportExcel.UseVisualStyleBackColor = false;
            // 
            // btnBulkDelete
            // 
            btnBulkDelete.BackColor = Color.FromArgb(255, 192, 192);
            btnBulkDelete.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnBulkDelete.Location = new Point(610, 162);
            btnBulkDelete.Margin = new Padding(3, 4, 3, 4);
            btnBulkDelete.Name = "btnBulkDelete";
            btnBulkDelete.Size = new Size(200, 50);
            btnBulkDelete.TabIndex = 18;
            btnBulkDelete.Text = "Xóa hàng loạt";
            btnBulkDelete.UseVisualStyleBackColor = false;
            // 
            // FormDevice
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(940, 670);
            Controls.Add(btnBulkDelete);
            Controls.Add(btnImportExcel);
            Controls.Add(dgvDevices);
            Controls.Add(btnSearch);
            Controls.Add(txtSearch);
            Controls.Add(lblSearch);
            Controls.Add(btnRefresh);
            Controls.Add(btnDelete);
            Controls.Add(btnEdit);
            Controls.Add(btnAdd);
            Controls.Add(cmbStatus);
            Controls.Add(txtDeviceType);
            Controls.Add(txtDeviceName);
            Controls.Add(txtDeviceId);
            Controls.Add(lblStatus);
            Controls.Add(lblDeviceType);
            Controls.Add(lblDeviceName);
            Controls.Add(lblDeviceId);
            Controls.Add(lblTitle);
            FormBorderStyle = FormBorderStyle.None;
            Margin = new Padding(3, 4, 3, 4);
            Name = "FormDevice";
            Text = "Quản Lý Thiết Bị";
            ((System.ComponentModel.ISupportInitialize)dgvDevices).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Label lblDeviceId;
        private System.Windows.Forms.Label lblDeviceName;
        private System.Windows.Forms.Label lblDeviceType;
        private System.Windows.Forms.Label lblStatus;
        private System.Windows.Forms.TextBox txtDeviceId;
        private System.Windows.Forms.TextBox txtDeviceName;
        private System.Windows.Forms.TextBox txtDeviceType;
        private System.Windows.Forms.ComboBox cmbStatus;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btnEdit;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnRefresh;
        private System.Windows.Forms.Label lblSearch;
        private System.Windows.Forms.TextBox txtSearch;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.DataGridView dgvDevices;
        private System.Windows.Forms.Button btnImportExcel;
        private System.Windows.Forms.Button btnBulkDelete;
    }
}