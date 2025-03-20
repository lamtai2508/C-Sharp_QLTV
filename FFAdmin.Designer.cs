namespace QLTV
{
    partial class FFAdmin
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FFAdmin));
            this.panel1 = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.sidebar = new System.Windows.Forms.FlowLayoutPanel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.menuContainer = new System.Windows.Forms.FlowLayoutPanel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.MemberList = new System.Windows.Forms.Panel();
            this.panel8 = new System.Windows.Forms.Panel();
            this.panel5 = new System.Windows.Forms.Panel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.panel6 = new System.Windows.Forms.Panel();
            this.menuTransition = new System.Windows.Forms.Timer(this.components);
            this.sidebarTransition = new System.Windows.Forms.Timer(this.components);
            this.contentContainer = new System.Windows.Forms.Panel();
            this.button4 = new System.Windows.Forms.Button();
            this.ThanhVien_bt = new System.Windows.Forms.Button();
            this.btn_member = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel1.SuspendLayout();
            this.sidebar.SuspendLayout();
            this.panel2.SuspendLayout();
            this.menuContainer.SuspendLayout();
            this.panel3.SuspendLayout();
            this.MemberList.SuspendLayout();
            this.panel8.SuspendLayout();
            this.panel5.SuspendLayout();
            this.panel4.SuspendLayout();
            this.panel6.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1500, 51);
            this.panel1.TabIndex = 0;
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(661, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(392, 38);
            this.label2.TabIndex = 3;
            this.label2.Text = "Phần mềm quản lý thư quán";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(98, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(76, 31);
            this.label1.TabIndex = 0;
            this.label1.Text = "Menu";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // sidebar
            // 
            this.sidebar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(17)))), ((int)(((byte)(22)))));
            this.sidebar.Controls.Add(this.panel2);
            this.sidebar.Controls.Add(this.menuContainer);
            this.sidebar.Controls.Add(this.panel5);
            this.sidebar.Controls.Add(this.panel4);
            this.sidebar.Controls.Add(this.panel6);
            this.sidebar.Dock = System.Windows.Forms.DockStyle.Left;
            this.sidebar.Location = new System.Drawing.Point(0, 51);
            this.sidebar.Margin = new System.Windows.Forms.Padding(0);
            this.sidebar.Name = "sidebar";
            this.sidebar.Size = new System.Drawing.Size(356, 649);
            this.sidebar.TabIndex = 1;
            this.sidebar.Paint += new System.Windows.Forms.PaintEventHandler(this.flowLayoutPanel1_Paint);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.button4);
            this.panel2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Margin = new System.Windows.Forms.Padding(0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(356, 78);
            this.panel2.TabIndex = 2;
            // 
            // menuContainer
            // 
            this.menuContainer.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.menuContainer.Controls.Add(this.panel3);
            this.menuContainer.Controls.Add(this.MemberList);
            this.menuContainer.Controls.Add(this.panel8);
            this.menuContainer.Location = new System.Drawing.Point(0, 78);
            this.menuContainer.Margin = new System.Windows.Forms.Padding(0);
            this.menuContainer.Name = "menuContainer";
            this.menuContainer.Size = new System.Drawing.Size(356, 78);
            this.menuContainer.TabIndex = 5;
            // 
            // panel3
            // 
            this.panel3.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.panel3.Controls.Add(this.ThanhVien_bt);
            this.panel3.Location = new System.Drawing.Point(0, 0);
            this.panel3.Margin = new System.Windows.Forms.Padding(0);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(356, 78);
            this.panel3.TabIndex = 4;
            // 
            // MemberList
            // 
            this.MemberList.CausesValidation = false;
            this.MemberList.Controls.Add(this.btn_member);
            this.MemberList.Location = new System.Drawing.Point(0, 78);
            this.MemberList.Margin = new System.Windows.Forms.Padding(0);
            this.MemberList.Name = "MemberList";
            this.MemberList.Size = new System.Drawing.Size(356, 78);
            this.MemberList.TabIndex = 5;
            // 
            // panel8
            // 
            this.panel8.CausesValidation = false;
            this.panel8.Controls.Add(this.button2);
            this.panel8.Location = new System.Drawing.Point(0, 156);
            this.panel8.Margin = new System.Windows.Forms.Padding(0);
            this.panel8.Name = "panel8";
            this.panel8.Size = new System.Drawing.Size(356, 78);
            this.panel8.TabIndex = 6;
            // 
            // panel5
            // 
            this.panel5.Controls.Add(this.button1);
            this.panel5.Location = new System.Drawing.Point(0, 156);
            this.panel5.Margin = new System.Windows.Forms.Padding(0);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(356, 78);
            this.panel5.TabIndex = 3;
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.button3);
            this.panel4.Location = new System.Drawing.Point(0, 234);
            this.panel4.Margin = new System.Windows.Forms.Padding(0);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(356, 78);
            this.panel4.TabIndex = 4;
            // 
            // panel6
            // 
            this.panel6.Controls.Add(this.button5);
            this.panel6.Location = new System.Drawing.Point(0, 312);
            this.panel6.Margin = new System.Windows.Forms.Padding(0);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(356, 78);
            this.panel6.TabIndex = 4;
            // 
            // menuTransition
            // 
            this.menuTransition.Interval = 10;
            this.menuTransition.Tick += new System.EventHandler(this.MenuTransition_Tick);
            // 
            // sidebarTransition
            // 
            this.sidebarTransition.Interval = 10;
            this.sidebarTransition.Tick += new System.EventHandler(this.sidebarTransition_Tick);
            // 
            // contentContainer
            // 
            this.contentContainer.AutoSize = true;
            this.contentContainer.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.contentContainer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.contentContainer.Location = new System.Drawing.Point(356, 51);
            this.contentContainer.Name = "contentContainer";
            this.contentContainer.Size = new System.Drawing.Size(1144, 649);
            this.contentContainer.TabIndex = 2;
            this.contentContainer.Resize += new System.EventHandler(this.contentContainer_Resize);
            // 
            // button4
            // 
            this.button4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(17)))), ((int)(((byte)(22)))));
            this.button4.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button4.ForeColor = System.Drawing.Color.White;
            this.button4.Image = ((System.Drawing.Image)(resources.GetObject("button4.Image")));
            this.button4.Location = new System.Drawing.Point(-54, -40);
            this.button4.Margin = new System.Windows.Forms.Padding(0);
            this.button4.Name = "button4";
            this.button4.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.button4.Size = new System.Drawing.Size(421, 155);
            this.button4.TabIndex = 4;
            this.button4.Text = "    Trang chủ";
            this.button4.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button4.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.button4.UseVisualStyleBackColor = false;
            this.button4.Click += new System.EventHandler(this.button4_Click_1);
            // 
            // ThanhVien_bt
            // 
            this.ThanhVien_bt.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(17)))), ((int)(((byte)(22)))));
            this.ThanhVien_bt.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ThanhVien_bt.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ThanhVien_bt.ForeColor = System.Drawing.Color.White;
            this.ThanhVien_bt.Image = ((System.Drawing.Image)(resources.GetObject("ThanhVien_bt.Image")));
            this.ThanhVien_bt.Location = new System.Drawing.Point(-54, -40);
            this.ThanhVien_bt.Margin = new System.Windows.Forms.Padding(0);
            this.ThanhVien_bt.Name = "ThanhVien_bt";
            this.ThanhVien_bt.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.ThanhVien_bt.Size = new System.Drawing.Size(421, 155);
            this.ThanhVien_bt.TabIndex = 3;
            this.ThanhVien_bt.Text = "     Thành viên";
            this.ThanhVien_bt.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.ThanhVien_bt.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.ThanhVien_bt.UseVisualStyleBackColor = false;
            this.ThanhVien_bt.Click += new System.EventHandler(this.button2_Click);
            // 
            // btn_member
            // 
            this.btn_member.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(65)))), ((int)(((byte)(65)))), ((int)(((byte)(65)))));
            this.btn_member.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_member.ForeColor = System.Drawing.Color.White;
            this.btn_member.Image = ((System.Drawing.Image)(resources.GetObject("btn_member.Image")));
            this.btn_member.Location = new System.Drawing.Point(-14, -40);
            this.btn_member.Margin = new System.Windows.Forms.Padding(0);
            this.btn_member.Name = "btn_member";
            this.btn_member.Padding = new System.Windows.Forms.Padding(70, 0, 0, 0);
            this.btn_member.Size = new System.Drawing.Size(378, 155);
            this.btn_member.TabIndex = 3;
            this.btn_member.Text = "Danh sách thành viên";
            this.btn_member.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btn_member.UseVisualStyleBackColor = false;
            this.btn_member.Click += new System.EventHandler(this.button6_Click);
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(65)))), ((int)(((byte)(65)))), ((int)(((byte)(65)))));
            this.button2.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.ForeColor = System.Drawing.Color.White;
            this.button2.Image = ((System.Drawing.Image)(resources.GetObject("button2.Image")));
            this.button2.Location = new System.Drawing.Point(-11, -44);
            this.button2.Margin = new System.Windows.Forms.Padding(0);
            this.button2.Name = "button2";
            this.button2.Padding = new System.Windows.Forms.Padding(55, 0, 0, 0);
            this.button2.Size = new System.Drawing.Size(378, 155);
            this.button2.TabIndex = 3;
            this.button2.Text = "Xem lịch sử mượn";
            this.button2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button2.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.button2.UseVisualStyleBackColor = false;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(17)))), ((int)(((byte)(22)))));
            this.button1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.Color.White;
            this.button1.Image = ((System.Drawing.Image)(resources.GetObject("button1.Image")));
            this.button1.Location = new System.Drawing.Point(-54, -40);
            this.button1.Name = "button1";
            this.button1.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.button1.Size = new System.Drawing.Size(421, 155);
            this.button1.TabIndex = 3;
            this.button1.Text = "     Vi phạm";
            this.button1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button1.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(17)))), ((int)(((byte)(22)))));
            this.button3.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button3.ForeColor = System.Drawing.Color.White;
            this.button3.Image = ((System.Drawing.Image)(resources.GetObject("button3.Image")));
            this.button3.Location = new System.Drawing.Point(-54, -40);
            this.button3.Name = "button3";
            this.button3.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.button3.Size = new System.Drawing.Size(421, 155);
            this.button3.TabIndex = 3;
            this.button3.Text = "      Thống kê";
            this.button3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button3.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.button3.UseVisualStyleBackColor = false;
            // 
            // button5
            // 
            this.button5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(17)))), ((int)(((byte)(22)))));
            this.button5.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button5.ForeColor = System.Drawing.Color.White;
            this.button5.Image = ((System.Drawing.Image)(resources.GetObject("button5.Image")));
            this.button5.Location = new System.Drawing.Point(-54, -40);
            this.button5.Name = "button5";
            this.button5.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.button5.Size = new System.Drawing.Size(421, 155);
            this.button5.TabIndex = 5;
            this.button5.Text = "     Thiết bị";
            this.button5.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button5.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.button5.UseVisualStyleBackColor = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(45, 13);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(31, 27);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1500, 700);
            this.Controls.Add(this.contentContainer);
            this.Controls.Add(this.sidebar);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.sidebar.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.menuContainer.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.MemberList.ResumeLayout(false);
            this.panel8.ResumeLayout(false);
            this.panel5.ResumeLayout(false);
            this.panel4.ResumeLayout(false);
            this.panel6.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.FlowLayoutPanel sidebar;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button ThanhVien_bt;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Timer menuTransition;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.FlowLayoutPanel menuContainer;
        private System.Windows.Forms.Panel MemberList;
        private System.Windows.Forms.Button btn_member;
        private System.Windows.Forms.Panel panel8;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Timer sidebarTransition;
        private System.Windows.Forms.Panel contentContainer;
    }
}

