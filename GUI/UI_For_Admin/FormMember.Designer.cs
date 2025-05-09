﻿namespace QLTV
{
    partial class FormMember
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormMember));
            members_table = new DataGridView();
            panel2 = new Panel();
            pictureBox1 = new PictureBox();
            tbSearch = new TextBox();
            label1 = new Label();
            panel8 = new Panel();
            flowLayoutPanel2 = new FlowLayoutPanel();
            btnAdd = new Button();
            btn_update = new Button();
            btn_delete = new Button();
            btn_loaddata = new Button();
            btDeleteMuti = new Button();
            button2 = new Button();
            flowLayoutPanel1 = new FlowLayoutPanel();
            btSearch = new Button();
            panel3 = new Panel();
            tbEmail = new TextBox();
            tbDob = new TextBox();
            tbNumberphone = new TextBox();
            tbGender = new TextBox();
            tbFullname = new TextBox();
            tbMaTV = new TextBox();
            label7 = new Label();
            label6 = new Label();
            label5 = new Label();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            ((System.ComponentModel.ISupportInitialize)members_table).BeginInit();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            panel8.SuspendLayout();
            flowLayoutPanel2.SuspendLayout();
            flowLayoutPanel1.SuspendLayout();
            panel3.SuspendLayout();
            SuspendLayout();
            // 
            // members_table
            // 
            members_table.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            members_table.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            members_table.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
            members_table.BackgroundColor = SystemColors.ButtonHighlight;
            members_table.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.Single;
            members_table.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            members_table.GridColor = Color.LavenderBlush;
            members_table.Location = new Point(12, 318);
            members_table.Name = "members_table";
            members_table.RowHeadersWidthSizeMode = DataGridViewRowHeadersWidthSizeMode.AutoSizeToAllHeaders;
            members_table.Size = new Size(1236, 413);
            members_table.TabIndex = 1;
            members_table.CellClick += members_table_CellClick;
            // 
            // panel2
            // 
            panel2.AutoSize = true;
            panel2.BackColor = SystemColors.ControlDark;
            panel2.BorderStyle = BorderStyle.FixedSingle;
            panel2.Controls.Add(pictureBox1);
            panel2.Controls.Add(tbSearch);
            panel2.Location = new Point(295, 3);
            panel2.Name = "panel2";
            panel2.Size = new Size(540, 32);
            panel2.TabIndex = 1;
            // 
            // pictureBox1
            // 
            pictureBox1.BackColor = Color.White;
            pictureBox1.Dock = DockStyle.Right;
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(508, 0);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(30, 30);
            pictureBox1.TabIndex = 1;
            pictureBox1.TabStop = false;
            // 
            // tbSearch
            // 
            tbSearch.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            tbSearch.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            tbSearch.Location = new Point(0, 0);
            tbSearch.Margin = new Padding(0);
            tbSearch.Name = "tbSearch";
            tbSearch.Size = new Size(538, 30);
            tbSearch.TabIndex = 0;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 15F, FontStyle.Bold);
            label1.Location = new Point(150, 0);
            label1.Margin = new Padding(150, 0, 3, 0);
            label1.Name = "label1";
            label1.Size = new Size(139, 35);
            label1.TabIndex = 0;
            label1.Text = "Tìm kiếm: ";
            // 
            // panel8
            // 
            panel8.Controls.Add(flowLayoutPanel2);
            panel8.Controls.Add(flowLayoutPanel1);
            panel8.Controls.Add(members_table);
            panel8.Controls.Add(panel3);
            panel8.Dock = DockStyle.Fill;
            panel8.Location = new Point(0, 0);
            panel8.Name = "panel8";
            panel8.Size = new Size(1260, 731);
            panel8.TabIndex = 0;
            // 
            // flowLayoutPanel2
            // 
            flowLayoutPanel2.AutoSize = true;
            flowLayoutPanel2.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            flowLayoutPanel2.Controls.Add(btnAdd);
            flowLayoutPanel2.Controls.Add(btn_update);
            flowLayoutPanel2.Controls.Add(btn_delete);
            flowLayoutPanel2.Controls.Add(btn_loaddata);
            flowLayoutPanel2.Controls.Add(btDeleteMuti);
            flowLayoutPanel2.Controls.Add(button2);
            flowLayoutPanel2.Location = new Point(12, 265);
            flowLayoutPanel2.Name = "flowLayoutPanel2";
            flowLayoutPanel2.Size = new Size(1215, 47);
            flowLayoutPanel2.TabIndex = 1;
            // 
            // btnAdd
            // 
            btnAdd.AutoSize = true;
            btnAdd.BackColor = Color.FromArgb(49, 176, 182);
            btnAdd.Cursor = Cursors.Hand;
            btnAdd.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnAdd.ForeColor = Color.White;
            btnAdd.Location = new Point(50, 3);
            btnAdd.Margin = new Padding(50, 3, 30, 3);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(150, 41);
            btnAdd.TabIndex = 0;
            btnAdd.Text = "Thêm";
            btnAdd.UseVisualStyleBackColor = false;
            btnAdd.Click += btnAdd_Click;
            // 
            // btn_update
            // 
            btn_update.AutoSize = true;
            btn_update.BackColor = Color.FromArgb(49, 176, 182);
            btn_update.Cursor = Cursors.Hand;
            btn_update.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btn_update.ForeColor = Color.White;
            btn_update.Location = new Point(233, 3);
            btn_update.Name = "btn_update";
            btn_update.Size = new Size(150, 41);
            btn_update.TabIndex = 1;
            btn_update.Text = "Sửa";
            btn_update.UseVisualStyleBackColor = false;
            btn_update.Click += btn_update_Click;
            // 
            // btn_delete
            // 
            btn_delete.AutoSize = true;
            btn_delete.BackColor = Color.FromArgb(49, 176, 182);
            btn_delete.Cursor = Cursors.Hand;
            btn_delete.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btn_delete.ForeColor = Color.White;
            btn_delete.Location = new Point(416, 3);
            btn_delete.Margin = new Padding(30, 3, 3, 3);
            btn_delete.Name = "btn_delete";
            btn_delete.Size = new Size(150, 41);
            btn_delete.TabIndex = 2;
            btn_delete.Text = "Xóa";
            btn_delete.UseVisualStyleBackColor = false;
            btn_delete.Click += btn_delete_Click;
            // 
            // btn_loaddata
            // 
            btn_loaddata.AutoSize = true;
            btn_loaddata.BackColor = Color.FromArgb(49, 176, 182);
            btn_loaddata.Cursor = Cursors.Hand;
            btn_loaddata.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btn_loaddata.ForeColor = Color.White;
            btn_loaddata.Location = new Point(599, 3);
            btn_loaddata.Margin = new Padding(30, 3, 30, 3);
            btn_loaddata.Name = "btn_loaddata";
            btn_loaddata.Size = new Size(150, 41);
            btn_loaddata.TabIndex = 3;
            btn_loaddata.Text = "Làm mới";
            btn_loaddata.UseVisualStyleBackColor = false;
            btn_loaddata.Click += btn_loaddata_Click;
            // 
            // btDeleteMuti
            // 
            btDeleteMuti.AutoSize = true;
            btDeleteMuti.BackColor = Color.FromArgb(49, 176, 182);
            btDeleteMuti.Cursor = Cursors.Hand;
            btDeleteMuti.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btDeleteMuti.ForeColor = Color.White;
            btDeleteMuti.Location = new Point(809, 3);
            btDeleteMuti.Margin = new Padding(30, 3, 30, 3);
            btDeleteMuti.Name = "btDeleteMuti";
            btDeleteMuti.Size = new Size(166, 41);
            btDeleteMuti.TabIndex = 4;
            btDeleteMuti.Text = "Xóa hàng loạt";
            btDeleteMuti.UseVisualStyleBackColor = false;
            btDeleteMuti.Click += btDeleteMuti_Click;
            // 
            // button2
            // 
            button2.AutoSize = true;
            button2.BackColor = Color.FromArgb(49, 176, 182);
            button2.Cursor = Cursors.Hand;
            button2.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            button2.ForeColor = Color.White;
            button2.Location = new Point(1035, 3);
            button2.Margin = new Padding(30, 3, 30, 3);
            button2.Name = "button2";
            button2.Size = new Size(150, 41);
            button2.TabIndex = 5;
            button2.Text = "Nhập Excel";
            button2.UseVisualStyleBackColor = false;
            button2.Click += button2_Click;
            // 
            // flowLayoutPanel1
            // 
            flowLayoutPanel1.AutoSize = true;
            flowLayoutPanel1.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            flowLayoutPanel1.Controls.Add(label1);
            flowLayoutPanel1.Controls.Add(panel2);
            flowLayoutPanel1.Controls.Add(btSearch);
            flowLayoutPanel1.Dock = DockStyle.Top;
            flowLayoutPanel1.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            flowLayoutPanel1.Location = new Point(0, 220);
            flowLayoutPanel1.Name = "flowLayoutPanel1";
            flowLayoutPanel1.Size = new Size(1260, 39);
            flowLayoutPanel1.TabIndex = 1;
            // 
            // btSearch
            // 
            btSearch.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            btSearch.AutoSize = true;
            btSearch.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btSearch.Location = new Point(841, 3);
            btSearch.Name = "btSearch";
            btSearch.Padding = new Padding(10, 0, 10, 0);
            btSearch.Size = new Size(68, 33);
            btSearch.TabIndex = 3;
            btSearch.Text = "Tìm";
            btSearch.UseVisualStyleBackColor = true;
            btSearch.Click += btSearch_Click;
            // 
            // panel3
            // 
            panel3.AutoSize = true;
            panel3.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            panel3.Controls.Add(tbEmail);
            panel3.Controls.Add(tbDob);
            panel3.Controls.Add(tbNumberphone);
            panel3.Controls.Add(tbGender);
            panel3.Controls.Add(tbFullname);
            panel3.Controls.Add(tbMaTV);
            panel3.Controls.Add(label7);
            panel3.Controls.Add(label6);
            panel3.Controls.Add(label5);
            panel3.Controls.Add(label4);
            panel3.Controls.Add(label3);
            panel3.Controls.Add(label2);
            panel3.Dock = DockStyle.Top;
            panel3.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            panel3.Location = new Point(0, 0);
            panel3.Name = "panel3";
            panel3.Padding = new Padding(50, 0, 0, 0);
            panel3.Size = new Size(1260, 220);
            panel3.TabIndex = 1;
            // 
            // tbEmail
            // 
            tbEmail.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left;
            tbEmail.Location = new Point(778, 156);
            tbEmail.Name = "tbEmail";
            tbEmail.Size = new Size(370, 34);
            tbEmail.TabIndex = 11;
            // 
            // tbDob
            // 
            tbDob.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left;
            tbDob.Location = new Point(778, 96);
            tbDob.Name = "tbDob";
            tbDob.Size = new Size(370, 34);
            tbDob.TabIndex = 10;
            // 
            // tbNumberphone
            // 
            tbNumberphone.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left;
            tbNumberphone.Location = new Point(778, 36);
            tbNumberphone.Name = "tbNumberphone";
            tbNumberphone.Size = new Size(370, 34);
            tbNumberphone.TabIndex = 9;
            // 
            // tbGender
            // 
            tbGender.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left;
            tbGender.Location = new Point(241, 156);
            tbGender.Name = "tbGender";
            tbGender.Size = new Size(370, 34);
            tbGender.TabIndex = 8;
            // 
            // tbFullname
            // 
            tbFullname.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left;
            tbFullname.Location = new Point(241, 96);
            tbFullname.Name = "tbFullname";
            tbFullname.Size = new Size(370, 34);
            tbFullname.TabIndex = 7;
            // 
            // tbMaTV
            // 
            tbMaTV.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left;
            tbMaTV.Location = new Point(241, 36);
            tbMaTV.Name = "tbMaTV";
            tbMaTV.Size = new Size(370, 34);
            tbMaTV.TabIndex = 4;
            // 
            // label7
            // 
            label7.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left;
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI", 12F, FontStyle.Bold | FontStyle.Underline, GraphicsUnit.Point, 0);
            label7.Location = new Point(634, 156);
            label7.Name = "label7";
            label7.Size = new Size(64, 28);
            label7.TabIndex = 5;
            label7.Text = "Email";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 12F, FontStyle.Bold | FontStyle.Underline, GraphicsUnit.Point, 0);
            label6.Location = new Point(634, 42);
            label6.Name = "label6";
            label6.Size = new Size(138, 28);
            label6.TabIndex = 4;
            label6.Text = "Số điện thoại";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 12F, FontStyle.Bold | FontStyle.Underline, GraphicsUnit.Point, 0);
            label5.Location = new Point(634, 96);
            label5.Name = "label5";
            label5.Size = new Size(107, 28);
            label5.TabIndex = 3;
            label5.Text = "Ngày sinh";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 12F, FontStyle.Bold | FontStyle.Underline, GraphicsUnit.Point, 0);
            label4.Location = new Point(81, 162);
            label4.Margin = new Padding(3, 0, 3, 30);
            label4.Name = "label4";
            label4.Size = new Size(95, 28);
            label4.TabIndex = 2;
            label4.Text = "Giới tính";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 12F, FontStyle.Bold | FontStyle.Underline, GraphicsUnit.Point, 0);
            label3.Location = new Point(81, 96);
            label3.Name = "label3";
            label3.Size = new Size(104, 28);
            label3.TabIndex = 1;
            label3.Text = "Họ và tên";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 12F, FontStyle.Bold | FontStyle.Underline, GraphicsUnit.Point, 0);
            label2.Location = new Point(81, 36);
            label2.Name = "label2";
            label2.Size = new Size(149, 28);
            label2.TabIndex = 0;
            label2.Text = "Mã thành viên";
            // 
            // FormMember
            // 
            AutoScaleMode = AutoScaleMode.None;
            ClientSize = new Size(1260, 731);
            Controls.Add(panel8);
            Name = "FormMember";
            ShowIcon = false;
            Text = "Form3";
            Load += MemberList_Load;
            ((System.ComponentModel.ISupportInitialize)members_table).EndInit();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            panel8.ResumeLayout(false);
            panel8.PerformLayout();
            flowLayoutPanel2.ResumeLayout(false);
            flowLayoutPanel2.PerformLayout();
            flowLayoutPanel1.ResumeLayout(false);
            flowLayoutPanel1.PerformLayout();
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            ResumeLayout(false);

        }

        #endregion

        private DataGridView members_table;
        private Panel panel2;
        private PictureBox pictureBox1;
        private TextBox tbSearch;
        private Label label1;
        private Panel panel8;
        private FlowLayoutPanel flowLayoutPanel1;
        private Panel panel3;
        private FlowLayoutPanel flowLayoutPanel2;
        private Button btnAdd;
        private Button btn_update;
        private Button btn_delete;
        private Button btSearch;
        private Label label4;
        private Label label3;
        private Label label2;
        private TextBox tbEmail;
        private TextBox tbDob;
        private TextBox tbNumberphone;
        private TextBox tbGender;
        private TextBox tbFullname;
        private TextBox tbMaTV;
        private Label label7;
        private Label label6;
        private Label label5;
        private Button btn_loaddata;
        private Button btDeleteMuti;
        private Button button2;
    }
}