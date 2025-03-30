namespace QLTV
{
    partial class FormAdminDashboard
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
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormAdminDashboard));
            panel1 = new Panel();
            bt_logout = new Label();
            label2 = new Label();
            bt_menu = new PictureBox();
            label1 = new Label();
            sidebar = new FlowLayoutPanel();
            panel2 = new Panel();
            bt_home = new Button();
            memberContainer = new FlowLayoutPanel();
            panel3 = new Panel();
            bt_member = new Button();
            MemberList = new Panel();
            btn_member = new Button();
            deviceContainer = new FlowLayoutPanel();
            panel7 = new Panel();
            bt_device_transition = new Button();
            panel9 = new Panel();
            bt_deviceList = new Button();
            panel10 = new Panel();
            button8 = new Button();
            violationContainer = new FlowLayoutPanel();
            panel6 = new Panel();
            bt_violation = new Button();
            panel12 = new Panel();
            button10 = new Button();
            flowLayoutPanel1 = new FlowLayoutPanel();
            panel5 = new Panel();
            button1 = new Button();
            panel13 = new Panel();
            button5 = new Button();
            statisticsContainer = new FlowLayoutPanel();
            panel14 = new Panel();
            bt_statistics = new Button();
            memberTransition = new System.Windows.Forms.Timer(components);
            menuTransition = new System.Windows.Forms.Timer(components);
            contentContainer = new Panel();
            deviceTransition = new System.Windows.Forms.Timer(components);
            violationTransition = new System.Windows.Forms.Timer(components);
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)bt_menu).BeginInit();
            sidebar.SuspendLayout();
            panel2.SuspendLayout();
            memberContainer.SuspendLayout();
            panel3.SuspendLayout();
            MemberList.SuspendLayout();
            deviceContainer.SuspendLayout();
            panel7.SuspendLayout();
            panel9.SuspendLayout();
            panel10.SuspendLayout();
            violationContainer.SuspendLayout();
            panel6.SuspendLayout();
            panel12.SuspendLayout();
            flowLayoutPanel1.SuspendLayout();
            panel5.SuspendLayout();
            panel13.SuspendLayout();
            statisticsContainer.SuspendLayout();
            panel14.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.White;
            panel1.Controls.Add(bt_logout);
            panel1.Controls.Add(label2);
            panel1.Controls.Add(bt_menu);
            panel1.Controls.Add(label1);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Margin = new Padding(3, 4, 3, 4);
            panel1.Name = "panel1";
            panel1.Size = new Size(1500, 64);
            panel1.TabIndex = 0;
            // 
            // bt_logout
            // 
            bt_logout.Cursor = Cursors.Hand;
            bt_logout.Dock = DockStyle.Right;
            bt_logout.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            bt_logout.Image = (Image)resources.GetObject("bt_logout.Image");
            bt_logout.ImageAlign = ContentAlignment.MiddleRight;
            bt_logout.Location = new Point(1355, 0);
            bt_logout.Name = "bt_logout";
            bt_logout.Size = new Size(145, 64);
            bt_logout.TabIndex = 5;
            bt_logout.Text = "Đăng xuất";
            bt_logout.TextAlign = ContentAlignment.MiddleLeft;
            bt_logout.Click += bt_logout_Click;
            // 
            // label2
            // 
            label2.Anchor = AnchorStyles.Top | AnchorStyles.Bottom;
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(661, 11);
            label2.Name = "label2";
            label2.Size = new Size(392, 38);
            label2.TabIndex = 3;
            label2.Text = "Phần mềm quản lý thư quán";
            label2.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // bt_menu
            // 
            bt_menu.Cursor = Cursors.Hand;
            bt_menu.Image = (Image)resources.GetObject("bt_menu.Image");
            bt_menu.Location = new Point(45, 16);
            bt_menu.Margin = new Padding(3, 4, 3, 4);
            bt_menu.Name = "bt_menu";
            bt_menu.Size = new Size(31, 34);
            bt_menu.SizeMode = PictureBoxSizeMode.CenterImage;
            bt_menu.TabIndex = 1;
            bt_menu.TabStop = false;
            bt_menu.Click += bt_menu_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(92, 19);
            label1.Name = "label1";
            label1.Size = new Size(99, 31);
            label1.TabIndex = 0;
            label1.Text = "Mục lục";
            // 
            // sidebar
            // 
            sidebar.AutoScroll = true;
            sidebar.BackColor = Color.FromArgb(18, 17, 22);
            sidebar.Controls.Add(panel2);
            sidebar.Controls.Add(memberContainer);
            sidebar.Controls.Add(deviceContainer);
            sidebar.Controls.Add(violationContainer);
            sidebar.Controls.Add(statisticsContainer);
            sidebar.Dock = DockStyle.Left;
            sidebar.Location = new Point(0, 64);
            sidebar.Margin = new Padding(0);
            sidebar.Name = "sidebar";
            sidebar.Size = new Size(356, 831);
            sidebar.TabIndex = 1;
            // 
            // panel2
            // 
            panel2.Controls.Add(bt_home);
            panel2.Cursor = Cursors.Hand;
            panel2.Location = new Point(0, 0);
            panel2.Margin = new Padding(0);
            panel2.Name = "panel2";
            panel2.Size = new Size(356, 98);
            panel2.TabIndex = 2;
            // 
            // bt_home
            // 
            bt_home.BackColor = Color.FromArgb(18, 17, 22);
            bt_home.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            bt_home.ForeColor = Color.White;
            bt_home.Image = qltv.Properties.Resources.icons8_home_40;
            bt_home.Location = new Point(-54, -50);
            bt_home.Margin = new Padding(0);
            bt_home.Name = "bt_home";
            bt_home.Padding = new Padding(10, 0, 0, 0);
            bt_home.Size = new Size(421, 194);
            bt_home.TabIndex = 4;
            bt_home.Text = "    Trang chủ";
            bt_home.TextAlign = ContentAlignment.MiddleLeft;
            bt_home.TextImageRelation = TextImageRelation.ImageBeforeText;
            bt_home.UseVisualStyleBackColor = false;
            bt_home.Click += bt_home_Click_1;
            // 
            // memberContainer
            // 
            memberContainer.BackColor = Color.FromArgb(255, 192, 128);
            memberContainer.Controls.Add(panel3);
            memberContainer.Controls.Add(MemberList);
            memberContainer.Location = new Point(0, 98);
            memberContainer.Margin = new Padding(0);
            memberContainer.Name = "memberContainer";
            memberContainer.Size = new Size(356, 196);
            memberContainer.TabIndex = 5;
            // 
            // panel3
            // 
            panel3.Anchor = AnchorStyles.Top;
            panel3.Controls.Add(bt_member);
            panel3.Location = new Point(0, 0);
            panel3.Margin = new Padding(0);
            panel3.Name = "panel3";
            panel3.Size = new Size(356, 98);
            panel3.TabIndex = 4;
            // 
            // bt_member
            // 
            bt_member.BackColor = Color.FromArgb(18, 17, 22);
            bt_member.Cursor = Cursors.Hand;
            bt_member.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            bt_member.ForeColor = Color.White;
            bt_member.Image = (Image)resources.GetObject("bt_member.Image");
            bt_member.Location = new Point(-54, -50);
            bt_member.Margin = new Padding(0);
            bt_member.Name = "bt_member";
            bt_member.Padding = new Padding(10, 0, 0, 0);
            bt_member.Size = new Size(421, 194);
            bt_member.TabIndex = 3;
            bt_member.Text = "     Thành viên";
            bt_member.TextAlign = ContentAlignment.MiddleLeft;
            bt_member.TextImageRelation = TextImageRelation.ImageBeforeText;
            bt_member.UseVisualStyleBackColor = false;
            bt_member.Click += bt_member_Click;
            // 
            // MemberList
            // 
            MemberList.CausesValidation = false;
            MemberList.Controls.Add(btn_member);
            MemberList.Location = new Point(0, 98);
            MemberList.Margin = new Padding(0);
            MemberList.Name = "MemberList";
            MemberList.Size = new Size(356, 98);
            MemberList.TabIndex = 5;
            // 
            // btn_member
            // 
            btn_member.BackColor = Color.FromArgb(65, 65, 65);
            btn_member.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btn_member.ForeColor = Color.White;
            btn_member.Image = (Image)resources.GetObject("btn_member.Image");
            btn_member.Location = new Point(-14, -50);
            btn_member.Margin = new Padding(0);
            btn_member.Name = "btn_member";
            btn_member.Padding = new Padding(70, 0, 0, 0);
            btn_member.Size = new Size(378, 194);
            btn_member.TabIndex = 3;
            btn_member.Text = "Danh sách thành viên";
            btn_member.TextImageRelation = TextImageRelation.ImageBeforeText;
            btn_member.UseVisualStyleBackColor = false;
            btn_member.Click += button6_Click;
            // 
            // deviceContainer
            // 
            deviceContainer.BackColor = Color.FromArgb(255, 192, 128);
            deviceContainer.Controls.Add(panel7);
            deviceContainer.Controls.Add(panel9);
            deviceContainer.Controls.Add(panel10);
            deviceContainer.Location = new Point(0, 294);
            deviceContainer.Margin = new Padding(0);
            deviceContainer.Name = "deviceContainer";
            deviceContainer.Size = new Size(356, 294);
            deviceContainer.TabIndex = 7;
            // 
            // panel7
            // 
            panel7.Anchor = AnchorStyles.Top;
            panel7.Controls.Add(bt_device_transition);
            panel7.Location = new Point(0, 0);
            panel7.Margin = new Padding(0);
            panel7.Name = "panel7";
            panel7.Size = new Size(356, 98);
            panel7.TabIndex = 4;
            // 
            // bt_device_transition
            // 
            bt_device_transition.BackColor = Color.FromArgb(18, 17, 22);
            bt_device_transition.Cursor = Cursors.Hand;
            bt_device_transition.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            bt_device_transition.ForeColor = Color.White;
            bt_device_transition.Image = qltv.Properties.Resources.icons8_device_40;
            bt_device_transition.Location = new Point(-54, -50);
            bt_device_transition.Margin = new Padding(0);
            bt_device_transition.Name = "bt_device_transition";
            bt_device_transition.Padding = new Padding(10, 0, 0, 0);
            bt_device_transition.Size = new Size(421, 194);
            bt_device_transition.TabIndex = 3;
            bt_device_transition.Text = "     Thiết bị";
            bt_device_transition.TextAlign = ContentAlignment.MiddleLeft;
            bt_device_transition.TextImageRelation = TextImageRelation.ImageBeforeText;
            bt_device_transition.UseVisualStyleBackColor = false;
            bt_device_transition.Click += bt_device_transition_Click;
            // 
            // panel9
            // 
            panel9.CausesValidation = false;
            panel9.Controls.Add(bt_deviceList);
            panel9.Location = new Point(0, 98);
            panel9.Margin = new Padding(0);
            panel9.Name = "panel9";
            panel9.Size = new Size(356, 98);
            panel9.TabIndex = 5;
            // 
            // bt_deviceList
            // 
            bt_deviceList.BackColor = Color.FromArgb(65, 65, 65);
            bt_deviceList.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            bt_deviceList.ForeColor = Color.White;
            bt_deviceList.Image = (Image)resources.GetObject("bt_deviceList.Image");
            bt_deviceList.Location = new Point(-14, -50);
            bt_deviceList.Margin = new Padding(0);
            bt_deviceList.Name = "bt_deviceList";
            bt_deviceList.Padding = new Padding(45, 0, 0, 0);
            bt_deviceList.Size = new Size(378, 194);
            bt_deviceList.TabIndex = 3;
            bt_deviceList.Text = "Danh sách thiết bị";
            bt_deviceList.TextImageRelation = TextImageRelation.ImageBeforeText;
            bt_deviceList.UseVisualStyleBackColor = false;
            bt_deviceList.Click += bt_deviceList_Click;
            // 
            // panel10
            // 
            panel10.CausesValidation = false;
            panel10.Controls.Add(button8);
            panel10.Location = new Point(0, 196);
            panel10.Margin = new Padding(0);
            panel10.Name = "panel10";
            panel10.Size = new Size(356, 98);
            panel10.TabIndex = 6;
            // 
            // button8
            // 
            button8.BackColor = Color.FromArgb(65, 65, 65);
            button8.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            button8.ForeColor = Color.White;
            button8.Image = (Image)resources.GetObject("button8.Image");
            button8.Location = new Point(-14, -50);
            button8.Margin = new Padding(0);
            button8.Name = "button8";
            button8.Padding = new Padding(55, 0, 0, 0);
            button8.Size = new Size(378, 194);
            button8.TabIndex = 3;
            button8.Text = "Xử lý đặt chỗ thiết bị";
            button8.TextAlign = ContentAlignment.MiddleLeft;
            button8.TextImageRelation = TextImageRelation.ImageBeforeText;
            button8.UseVisualStyleBackColor = false;
            // 
            // violationContainer
            // 
            violationContainer.BackColor = Color.FromArgb(255, 192, 128);
            violationContainer.Controls.Add(panel6);
            violationContainer.Controls.Add(panel12);
            violationContainer.Controls.Add(flowLayoutPanel1);
            violationContainer.Location = new Point(0, 588);
            violationContainer.Margin = new Padding(0);
            violationContainer.Name = "violationContainer";
            violationContainer.Size = new Size(356, 196);
            violationContainer.TabIndex = 8;
            // 
            // panel6
            // 
            panel6.Anchor = AnchorStyles.Top;
            panel6.Controls.Add(bt_violation);
            panel6.Location = new Point(0, 0);
            panel6.Margin = new Padding(0);
            panel6.Name = "panel6";
            panel6.Size = new Size(356, 98);
            panel6.TabIndex = 4;
            // 
            // bt_violation
            // 
            bt_violation.BackColor = Color.FromArgb(18, 17, 22);
            bt_violation.Cursor = Cursors.Hand;
            bt_violation.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            bt_violation.ForeColor = Color.White;
            bt_violation.Image = qltv.Properties.Resources.icons8_important_user_40;
            bt_violation.Location = new Point(-54, -50);
            bt_violation.Margin = new Padding(0);
            bt_violation.Name = "bt_violation";
            bt_violation.Padding = new Padding(10, 0, 0, 0);
            bt_violation.Size = new Size(421, 194);
            bt_violation.TabIndex = 3;
            bt_violation.Text = "     Vi phạm";
            bt_violation.TextAlign = ContentAlignment.MiddleLeft;
            bt_violation.TextImageRelation = TextImageRelation.ImageBeforeText;
            bt_violation.UseVisualStyleBackColor = false;
            bt_violation.Click += bt_violation_Click;
            // 
            // panel12
            // 
            panel12.CausesValidation = false;
            panel12.Controls.Add(button10);
            panel12.Location = new Point(0, 98);
            panel12.Margin = new Padding(0);
            panel12.Name = "panel12";
            panel12.Size = new Size(356, 98);
            panel12.TabIndex = 5;
            // 
            // button10
            // 
            button10.BackColor = Color.FromArgb(65, 65, 65);
            button10.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            button10.ForeColor = Color.White;
            button10.Image = (Image)resources.GetObject("button10.Image");
            button10.Location = new Point(-14, -50);
            button10.Margin = new Padding(0);
            button10.Name = "button10";
            button10.Padding = new Padding(45, 0, 0, 0);
            button10.Size = new Size(378, 194);
            button10.TabIndex = 3;
            button10.Text = "Danh sách vi phạm";
            button10.TextImageRelation = TextImageRelation.ImageBeforeText;
            button10.UseVisualStyleBackColor = false;
            // 
            // flowLayoutPanel1
            // 
            flowLayoutPanel1.BackColor = Color.FromArgb(255, 192, 128);
            flowLayoutPanel1.Controls.Add(panel5);
            flowLayoutPanel1.Controls.Add(panel13);
            flowLayoutPanel1.Location = new Point(0, 196);
            flowLayoutPanel1.Margin = new Padding(0);
            flowLayoutPanel1.Name = "flowLayoutPanel1";
            flowLayoutPanel1.Size = new Size(356, 59);
            flowLayoutPanel1.TabIndex = 9;
            // 
            // panel5
            // 
            panel5.Anchor = AnchorStyles.Top;
            panel5.Controls.Add(button1);
            panel5.Location = new Point(0, 0);
            panel5.Margin = new Padding(0);
            panel5.Name = "panel5";
            panel5.Size = new Size(356, 98);
            panel5.TabIndex = 4;
            // 
            // button1
            // 
            button1.BackColor = Color.FromArgb(18, 17, 22);
            button1.Cursor = Cursors.Hand;
            button1.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            button1.ForeColor = Color.White;
            button1.Image = qltv.Properties.Resources.icons8_important_user_40;
            button1.Location = new Point(-54, -50);
            button1.Margin = new Padding(0);
            button1.Name = "button1";
            button1.Padding = new Padding(10, 0, 0, 0);
            button1.Size = new Size(421, 194);
            button1.TabIndex = 3;
            button1.Text = "     Vi phạm";
            button1.TextAlign = ContentAlignment.MiddleLeft;
            button1.TextImageRelation = TextImageRelation.ImageBeforeText;
            button1.UseVisualStyleBackColor = false;
            // 
            // panel13
            // 
            panel13.CausesValidation = false;
            panel13.Controls.Add(button5);
            panel13.Location = new Point(0, 98);
            panel13.Margin = new Padding(0);
            panel13.Name = "panel13";
            panel13.Size = new Size(356, 98);
            panel13.TabIndex = 5;
            // 
            // button5
            // 
            button5.BackColor = Color.FromArgb(65, 65, 65);
            button5.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            button5.ForeColor = Color.White;
            button5.Image = (Image)resources.GetObject("button5.Image");
            button5.Location = new Point(-14, -50);
            button5.Margin = new Padding(0);
            button5.Name = "button5";
            button5.Padding = new Padding(45, 0, 0, 0);
            button5.Size = new Size(378, 194);
            button5.TabIndex = 3;
            button5.Text = "Danh sách vi phạm";
            button5.TextImageRelation = TextImageRelation.ImageBeforeText;
            button5.UseVisualStyleBackColor = false;
            // 
            // statisticsContainer
            // 
            statisticsContainer.BackColor = Color.FromArgb(255, 192, 128);
            statisticsContainer.Controls.Add(panel14);
            statisticsContainer.Location = new Point(0, 784);
            statisticsContainer.Margin = new Padding(0);
            statisticsContainer.Name = "statisticsContainer";
            statisticsContainer.Size = new Size(356, 98);
            statisticsContainer.TabIndex = 9;
            // 
            // panel14
            // 
            panel14.Anchor = AnchorStyles.Top;
            panel14.Controls.Add(bt_statistics);
            panel14.Location = new Point(0, 0);
            panel14.Margin = new Padding(0);
            panel14.Name = "panel14";
            panel14.Size = new Size(356, 98);
            panel14.TabIndex = 4;
            // 
            // bt_statistics
            // 
            bt_statistics.BackColor = Color.FromArgb(18, 17, 22);
            bt_statistics.Cursor = Cursors.Hand;
            bt_statistics.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            bt_statistics.ForeColor = Color.White;
            bt_statistics.Image = qltv.Properties.Resources.icons8_statistics_40;
            bt_statistics.Location = new Point(-54, -50);
            bt_statistics.Margin = new Padding(0);
            bt_statistics.Name = "bt_statistics";
            bt_statistics.Padding = new Padding(10, 0, 0, 0);
            bt_statistics.Size = new Size(421, 194);
            bt_statistics.TabIndex = 3;
            bt_statistics.Text = "     Thống kê";
            bt_statistics.TextAlign = ContentAlignment.MiddleLeft;
            bt_statistics.TextImageRelation = TextImageRelation.ImageBeforeText;
            bt_statistics.UseVisualStyleBackColor = false;
            // 
            // memberTransition
            // 
            memberTransition.Interval = 10;
            memberTransition.Tick += MemberTransition_Tick;
            // 
            // menuTransition
            // 
            menuTransition.Interval = 10;
            menuTransition.Tick += menuTransition_Tick;
            // 
            // contentContainer
            // 
            contentContainer.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            contentContainer.Dock = DockStyle.Fill;
            contentContainer.Location = new Point(356, 64);
            contentContainer.Margin = new Padding(0);
            contentContainer.Name = "contentContainer";
            contentContainer.Size = new Size(1144, 831);
            contentContainer.TabIndex = 2;
            // 
            // deviceTransition
            // 
            deviceTransition.Interval = 10;
            deviceTransition.Tick += deviceTransition_Tick;
            // 
            // violationTransition
            // 
            violationTransition.Interval = 10;
            violationTransition.Tick += violationTransition_Tick;
            // 
            // FormAdminDashboard
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1500, 895);
            Controls.Add(contentContainer);
            Controls.Add(sidebar);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.None;
            Margin = new Padding(3, 4, 3, 4);
            Name = "FormAdminDashboard";
            Text = "Form1";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)bt_menu).EndInit();
            sidebar.ResumeLayout(false);
            panel2.ResumeLayout(false);
            memberContainer.ResumeLayout(false);
            panel3.ResumeLayout(false);
            MemberList.ResumeLayout(false);
            deviceContainer.ResumeLayout(false);
            panel7.ResumeLayout(false);
            panel9.ResumeLayout(false);
            panel10.ResumeLayout(false);
            violationContainer.ResumeLayout(false);
            panel6.ResumeLayout(false);
            panel12.ResumeLayout(false);
            flowLayoutPanel1.ResumeLayout(false);
            panel5.ResumeLayout(false);
            panel13.ResumeLayout(false);
            statisticsContainer.ResumeLayout(false);
            panel14.ResumeLayout(false);
            ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox bt_menu;
        private System.Windows.Forms.FlowLayoutPanel sidebar;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button bt_member;
        private System.Windows.Forms.Button bt_home;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Timer memberTransition;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.FlowLayoutPanel memberContainer;
        private System.Windows.Forms.Panel MemberList;
        private System.Windows.Forms.Button btn_member;
        private System.Windows.Forms.Timer menuTransition;
        private System.Windows.Forms.Panel contentContainer;
        private FlowLayoutPanel deviceContainer;
        private Panel panel7;
        private Button bt_device_transition;
        private Panel panel9;
        private Button bt_deviceList;
        private Panel panel10;
        private Button button8;
        private System.Windows.Forms.Timer deviceTransition;
        private FlowLayoutPanel violationContainer;
        private Panel panel6;
        private Button bt_violation;
        private Panel panel12;
        private Button button10;
        private System.Windows.Forms.Timer violationTransition;
        private FlowLayoutPanel flowLayoutPanel1;
        private Panel panel5;
        private Button button1;
        private Panel panel13;
        private Button button5;
        private FlowLayoutPanel statisticsContainer;
        private Panel panel14;
        private Button bt_statistics;
        private Label bt_logout;
    }
}

