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
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FFAdmin));
            panel1 = new Panel();
            label2 = new Label();
            pictureBox1 = new PictureBox();
            label1 = new Label();
            sidebar = new FlowLayoutPanel();
            panel2 = new Panel();
            bt_home = new Button();
            memberContainer = new FlowLayoutPanel();
            panel3 = new Panel();
            ThanhVien_bt = new Button();
            MemberList = new Panel();
            btn_member = new Button();
            panel8 = new Panel();
            button2 = new Button();
            deviceContainer = new FlowLayoutPanel();
            panel7 = new Panel();
            button6 = new Button();
            panel9 = new Panel();
            button7 = new Button();
            panel10 = new Panel();
            button8 = new Button();
            panel11 = new Panel();
            button9 = new Button();
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
            panel15 = new Panel();
            button12 = new Button();
            flowLayoutPanel3 = new FlowLayoutPanel();
            panel16 = new Panel();
            button13 = new Button();
            panel17 = new Panel();
            button14 = new Button();
            memberTransition = new System.Windows.Forms.Timer(components);
            menuTransition = new System.Windows.Forms.Timer(components);
            contentContainer = new Panel();
            deviceTransition = new System.Windows.Forms.Timer(components);
            violationTransition = new System.Windows.Forms.Timer(components);
            statisticsTransition = new System.Windows.Forms.Timer(components);
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            sidebar.SuspendLayout();
            panel2.SuspendLayout();
            memberContainer.SuspendLayout();
            panel3.SuspendLayout();
            MemberList.SuspendLayout();
            panel8.SuspendLayout();
            deviceContainer.SuspendLayout();
            panel7.SuspendLayout();
            panel9.SuspendLayout();
            panel10.SuspendLayout();
            panel11.SuspendLayout();
            violationContainer.SuspendLayout();
            panel6.SuspendLayout();
            panel12.SuspendLayout();
            flowLayoutPanel1.SuspendLayout();
            panel5.SuspendLayout();
            panel13.SuspendLayout();
            statisticsContainer.SuspendLayout();
            panel14.SuspendLayout();
            panel15.SuspendLayout();
            flowLayoutPanel3.SuspendLayout();
            panel16.SuspendLayout();
            panel17.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.White;
            panel1.Controls.Add(label2);
            panel1.Controls.Add(pictureBox1);
            panel1.Controls.Add(label1);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Margin = new Padding(3, 4, 3, 4);
            panel1.Name = "panel1";
            panel1.Size = new Size(1500, 64);
            panel1.TabIndex = 0;
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
            // pictureBox1
            // 
            pictureBox1.Cursor = Cursors.Hand;
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(45, 16);
            pictureBox1.Margin = new Padding(3, 4, 3, 4);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(31, 34);
            pictureBox1.SizeMode = PictureBoxSizeMode.CenterImage;
            pictureBox1.TabIndex = 1;
            pictureBox1.TabStop = false;
            pictureBox1.Click += pictureBox1_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(98, 11);
            label1.Name = "label1";
            label1.Size = new Size(76, 31);
            label1.TabIndex = 0;
            label1.Text = "Menu";
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
            sidebar.Size = new Size(356, 811);
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
            bt_home.Click += button4_Click_1;
            // 
            // memberContainer
            // 
            memberContainer.BackColor = Color.FromArgb(255, 192, 128);
            memberContainer.Controls.Add(panel3);
            memberContainer.Controls.Add(MemberList);
            memberContainer.Controls.Add(panel8);
            memberContainer.Location = new Point(0, 98);
            memberContainer.Margin = new Padding(0);
            memberContainer.Name = "memberContainer";
            memberContainer.Size = new Size(356, 98);
            memberContainer.TabIndex = 5;
            // 
            // panel3
            // 
            panel3.Anchor = AnchorStyles.Top;
            panel3.Controls.Add(ThanhVien_bt);
            panel3.Location = new Point(0, 0);
            panel3.Margin = new Padding(0);
            panel3.Name = "panel3";
            panel3.Size = new Size(356, 98);
            panel3.TabIndex = 4;
            // 
            // ThanhVien_bt
            // 
            ThanhVien_bt.BackColor = Color.FromArgb(18, 17, 22);
            ThanhVien_bt.Cursor = Cursors.Hand;
            ThanhVien_bt.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            ThanhVien_bt.ForeColor = Color.White;
            ThanhVien_bt.Image = (Image)resources.GetObject("ThanhVien_bt.Image");
            ThanhVien_bt.Location = new Point(-54, -50);
            ThanhVien_bt.Margin = new Padding(0);
            ThanhVien_bt.Name = "ThanhVien_bt";
            ThanhVien_bt.Padding = new Padding(10, 0, 0, 0);
            ThanhVien_bt.Size = new Size(421, 194);
            ThanhVien_bt.TabIndex = 3;
            ThanhVien_bt.Text = "     Thành viên";
            ThanhVien_bt.TextAlign = ContentAlignment.MiddleLeft;
            ThanhVien_bt.TextImageRelation = TextImageRelation.ImageBeforeText;
            ThanhVien_bt.UseVisualStyleBackColor = false;
            ThanhVien_bt.Click += button2_Click;
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
            // panel8
            // 
            panel8.CausesValidation = false;
            panel8.Controls.Add(button2);
            panel8.Location = new Point(0, 196);
            panel8.Margin = new Padding(0);
            panel8.Name = "panel8";
            panel8.Size = new Size(356, 98);
            panel8.TabIndex = 6;
            // 
            // button2
            // 
            button2.BackColor = Color.FromArgb(65, 65, 65);
            button2.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            button2.ForeColor = Color.White;
            button2.Image = (Image)resources.GetObject("button2.Image");
            button2.Location = new Point(-11, -55);
            button2.Margin = new Padding(0);
            button2.Name = "button2";
            button2.Padding = new Padding(55, 0, 0, 0);
            button2.Size = new Size(378, 194);
            button2.TabIndex = 3;
            button2.Text = "Xem lịch sử mượn";
            button2.TextAlign = ContentAlignment.MiddleLeft;
            button2.TextImageRelation = TextImageRelation.ImageBeforeText;
            button2.UseVisualStyleBackColor = false;
            // 
            // deviceContainer
            // 
            deviceContainer.BackColor = Color.FromArgb(255, 192, 128);
            deviceContainer.Controls.Add(panel7);
            deviceContainer.Controls.Add(panel9);
            deviceContainer.Controls.Add(panel10);
            deviceContainer.Controls.Add(panel11);
            deviceContainer.Location = new Point(0, 196);
            deviceContainer.Margin = new Padding(0);
            deviceContainer.Name = "deviceContainer";
            deviceContainer.Size = new Size(356, 98);
            deviceContainer.TabIndex = 7;
            // 
            // panel7
            // 
            panel7.Anchor = AnchorStyles.Top;
            panel7.Controls.Add(button6);
            panel7.Location = new Point(0, 0);
            panel7.Margin = new Padding(0);
            panel7.Name = "panel7";
            panel7.Size = new Size(356, 98);
            panel7.TabIndex = 4;
            // 
            // button6
            // 
            button6.BackColor = Color.FromArgb(18, 17, 22);
            button6.Cursor = Cursors.Hand;
            button6.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            button6.ForeColor = Color.White;
            button6.Image = qltv.Properties.Resources.icons8_device_40;
            button6.Location = new Point(-54, -50);
            button6.Margin = new Padding(0);
            button6.Name = "button6";
            button6.Padding = new Padding(10, 0, 0, 0);
            button6.Size = new Size(421, 194);
            button6.TabIndex = 3;
            button6.Text = "     Thiết bị";
            button6.TextAlign = ContentAlignment.MiddleLeft;
            button6.TextImageRelation = TextImageRelation.ImageBeforeText;
            button6.UseVisualStyleBackColor = false;
            button6.Click += button6_Click_1;
            // 
            // panel9
            // 
            panel9.CausesValidation = false;
            panel9.Controls.Add(button7);
            panel9.Location = new Point(0, 98);
            panel9.Margin = new Padding(0);
            panel9.Name = "panel9";
            panel9.Size = new Size(356, 98);
            panel9.TabIndex = 5;
            // 
            // button7
            // 
            button7.BackColor = Color.FromArgb(65, 65, 65);
            button7.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            button7.ForeColor = Color.White;
            button7.Image = (Image)resources.GetObject("button7.Image");
            button7.Location = new Point(-14, -50);
            button7.Margin = new Padding(0);
            button7.Name = "button7";
            button7.Padding = new Padding(45, 0, 0, 0);
            button7.Size = new Size(378, 194);
            button7.TabIndex = 3;
            button7.Text = "Danh sách thiết bị";
            button7.TextImageRelation = TextImageRelation.ImageBeforeText;
            button7.UseVisualStyleBackColor = false;
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
            // panel11
            // 
            panel11.CausesValidation = false;
            panel11.Controls.Add(button9);
            panel11.Location = new Point(0, 294);
            panel11.Margin = new Padding(0);
            panel11.Name = "panel11";
            panel11.Size = new Size(356, 98);
            panel11.TabIndex = 7;
            // 
            // button9
            // 
            button9.BackColor = Color.FromArgb(65, 65, 65);
            button9.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            button9.ForeColor = Color.White;
            button9.Image = (Image)resources.GetObject("button9.Image");
            button9.Location = new Point(-14, -50);
            button9.Margin = new Padding(0);
            button9.Name = "button9";
            button9.Padding = new Padding(45, 0, 0, 0);
            button9.Size = new Size(378, 194);
            button9.TabIndex = 3;
            button9.Text = "Xem lịch sử mượn";
            button9.TextAlign = ContentAlignment.MiddleLeft;
            button9.TextImageRelation = TextImageRelation.ImageBeforeText;
            button9.UseVisualStyleBackColor = false;
            // 
            // violationContainer
            // 
            violationContainer.BackColor = Color.FromArgb(255, 192, 128);
            violationContainer.Controls.Add(panel6);
            violationContainer.Controls.Add(panel12);
            violationContainer.Controls.Add(flowLayoutPanel1);
            violationContainer.Location = new Point(0, 294);
            violationContainer.Margin = new Padding(0);
            violationContainer.Name = "violationContainer";
            violationContainer.Size = new Size(356, 98);
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
            statisticsContainer.Controls.Add(panel15);
            statisticsContainer.Controls.Add(flowLayoutPanel3);
            statisticsContainer.Location = new Point(0, 392);
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
            bt_statistics.Click += bt_statistics_Click;
            // 
            // panel15
            // 
            panel15.CausesValidation = false;
            panel15.Controls.Add(button12);
            panel15.Location = new Point(0, 98);
            panel15.Margin = new Padding(0);
            panel15.Name = "panel15";
            panel15.Size = new Size(356, 98);
            panel15.TabIndex = 5;
            // 
            // button12
            // 
            button12.BackColor = Color.FromArgb(65, 65, 65);
            button12.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            button12.ForeColor = Color.White;
            button12.Image = (Image)resources.GetObject("button12.Image");
            button12.Location = new Point(-14, -50);
            button12.Margin = new Padding(0);
            button12.Name = "button12";
            button12.Padding = new Padding(45, 0, 0, 0);
            button12.Size = new Size(378, 194);
            button12.TabIndex = 3;
            button12.Text = "Danh sách vi phạm";
            button12.TextImageRelation = TextImageRelation.ImageBeforeText;
            button12.UseVisualStyleBackColor = false;
            // 
            // flowLayoutPanel3
            // 
            flowLayoutPanel3.BackColor = Color.FromArgb(255, 192, 128);
            flowLayoutPanel3.Controls.Add(panel16);
            flowLayoutPanel3.Controls.Add(panel17);
            flowLayoutPanel3.Location = new Point(0, 196);
            flowLayoutPanel3.Margin = new Padding(0);
            flowLayoutPanel3.Name = "flowLayoutPanel3";
            flowLayoutPanel3.Size = new Size(356, 59);
            flowLayoutPanel3.TabIndex = 9;
            // 
            // panel16
            // 
            panel16.Anchor = AnchorStyles.Top;
            panel16.Controls.Add(button13);
            panel16.Location = new Point(0, 0);
            panel16.Margin = new Padding(0);
            panel16.Name = "panel16";
            panel16.Size = new Size(356, 98);
            panel16.TabIndex = 4;
            // 
            // button13
            // 
            button13.BackColor = Color.FromArgb(18, 17, 22);
            button13.Cursor = Cursors.Hand;
            button13.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            button13.ForeColor = Color.White;
            button13.Image = qltv.Properties.Resources.icons8_important_user_40;
            button13.Location = new Point(-54, -50);
            button13.Margin = new Padding(0);
            button13.Name = "button13";
            button13.Padding = new Padding(10, 0, 0, 0);
            button13.Size = new Size(421, 194);
            button13.TabIndex = 3;
            button13.Text = "     Vi phạm";
            button13.TextAlign = ContentAlignment.MiddleLeft;
            button13.TextImageRelation = TextImageRelation.ImageBeforeText;
            button13.UseVisualStyleBackColor = false;
            // 
            // panel17
            // 
            panel17.CausesValidation = false;
            panel17.Controls.Add(button14);
            panel17.Location = new Point(0, 98);
            panel17.Margin = new Padding(0);
            panel17.Name = "panel17";
            panel17.Size = new Size(356, 98);
            panel17.TabIndex = 5;
            // 
            // button14
            // 
            button14.BackColor = Color.FromArgb(65, 65, 65);
            button14.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            button14.ForeColor = Color.White;
            button14.Image = (Image)resources.GetObject("button14.Image");
            button14.Location = new Point(-14, -50);
            button14.Margin = new Padding(0);
            button14.Name = "button14";
            button14.Padding = new Padding(45, 0, 0, 0);
            button14.Size = new Size(378, 194);
            button14.TabIndex = 3;
            button14.Text = "Danh sách vi phạm";
            button14.TextImageRelation = TextImageRelation.ImageBeforeText;
            button14.UseVisualStyleBackColor = false;
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
            contentContainer.Size = new Size(1144, 811);
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
            // statisticsTransition
            // 
            statisticsTransition.Interval = 10;
            statisticsTransition.Tick += statisticsTransiton_Tick;
            // 
            // FFAdmin
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1500, 875);
            Controls.Add(contentContainer);
            Controls.Add(sidebar);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.None;
            Margin = new Padding(3, 4, 3, 4);
            Name = "FFAdmin";
            Text = "Form1";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            sidebar.ResumeLayout(false);
            panel2.ResumeLayout(false);
            memberContainer.ResumeLayout(false);
            panel3.ResumeLayout(false);
            MemberList.ResumeLayout(false);
            panel8.ResumeLayout(false);
            deviceContainer.ResumeLayout(false);
            panel7.ResumeLayout(false);
            panel9.ResumeLayout(false);
            panel10.ResumeLayout(false);
            panel11.ResumeLayout(false);
            violationContainer.ResumeLayout(false);
            panel6.ResumeLayout(false);
            panel12.ResumeLayout(false);
            flowLayoutPanel1.ResumeLayout(false);
            panel5.ResumeLayout(false);
            panel13.ResumeLayout(false);
            statisticsContainer.ResumeLayout(false);
            panel14.ResumeLayout(false);
            panel15.ResumeLayout(false);
            flowLayoutPanel3.ResumeLayout(false);
            panel16.ResumeLayout(false);
            panel17.ResumeLayout(false);
            ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.FlowLayoutPanel sidebar;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button ThanhVien_bt;
        private System.Windows.Forms.Button bt_home;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Timer memberTransition;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.FlowLayoutPanel memberContainer;
        private System.Windows.Forms.Panel MemberList;
        private System.Windows.Forms.Button btn_member;
        private System.Windows.Forms.Panel panel8;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Timer menuTransition;
        private System.Windows.Forms.Panel contentContainer;
        private FlowLayoutPanel deviceContainer;
        private Panel panel7;
        private Button button6;
        private Panel panel9;
        private Button button7;
        private Panel panel10;
        private Button button8;
        private Panel panel11;
        private Button button9;
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
        private Panel panel15;
        private Button button12;
        private FlowLayoutPanel flowLayoutPanel3;
        private Panel panel16;
        private Button button13;
        private Panel panel17;
        private Button button14;
        private System.Windows.Forms.Timer statisticsTransition;
    }
}

