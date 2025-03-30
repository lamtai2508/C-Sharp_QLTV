namespace qltv.GUI.UI_For_User
{
    partial class FormUserDashboard
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormUserDashboard));
            memberTransition = new System.Windows.Forms.Timer(components);
            menuTransition = new System.Windows.Forms.Timer(components);
            deviceTransition = new System.Windows.Forms.Timer(components);
            statisticsTransition = new System.Windows.Forms.Timer(components);
            historyTransition = new System.Windows.Forms.Timer(components);
            panel1 = new Panel();
            bt_logout = new Label();
            label2 = new Label();
            pictureBox1 = new PictureBox();
            label1 = new Label();
            sidebar = new FlowLayoutPanel();
            memberContainer = new FlowLayoutPanel();
            panel3 = new Panel();
            ThanhVien_bt = new Button();
            deviceContainer = new FlowLayoutPanel();
            panel7 = new Panel();
            button6 = new Button();
            panel9 = new Panel();
            button7 = new Button();
            panel10 = new Panel();
            button8 = new Button();
            panel11 = new Panel();
            button9 = new Button();
            historyContainer = new FlowLayoutPanel();
            panel6 = new Panel();
            bt_violation = new Button();
            panel12 = new Panel();
            button10 = new Button();
            panel2 = new Panel();
            button1 = new Button();
            contentContainer = new Panel();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            sidebar.SuspendLayout();
            memberContainer.SuspendLayout();
            panel3.SuspendLayout();
            deviceContainer.SuspendLayout();
            panel7.SuspendLayout();
            panel9.SuspendLayout();
            panel10.SuspendLayout();
            panel11.SuspendLayout();
            historyContainer.SuspendLayout();
            panel6.SuspendLayout();
            panel12.SuspendLayout();
            panel2.SuspendLayout();
            SuspendLayout();
            // 
            // menuTransition
            // 
            menuTransition.Interval = 10;
            menuTransition.Tick += menuTransition_Tick_1;
            // 
            // deviceTransition
            // 
            deviceTransition.Interval = 10;
            // 
            // statisticsTransition
            // 
            statisticsTransition.Interval = 10;
            // 
            // historyTransition
            // 
            historyTransition.Interval = 10;
            historyTransition.Tick += historyTransition_Tick;
            // 
            // panel1
            // 
            panel1.AutoSize = true;
            panel1.BackColor = Color.White;
            panel1.Controls.Add(bt_logout);
            panel1.Controls.Add(label2);
            panel1.Controls.Add(pictureBox1);
            panel1.Controls.Add(label1);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Margin = new Padding(3, 4, 3, 4);
            panel1.Name = "panel1";
            panel1.Size = new Size(1465, 64);
            panel1.TabIndex = 1;
            // 
            // bt_logout
            // 
            bt_logout.Cursor = Cursors.Hand;
            bt_logout.Dock = DockStyle.Right;
            bt_logout.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            bt_logout.Image = (Image)resources.GetObject("bt_logout.Image");
            bt_logout.ImageAlign = ContentAlignment.MiddleRight;
            bt_logout.Location = new Point(1299, 0);
            bt_logout.Name = "bt_logout";
            bt_logout.Size = new Size(166, 64);
            bt_logout.TabIndex = 4;
            bt_logout.Text = "Đăng xuất";
            bt_logout.TextAlign = ContentAlignment.MiddleLeft;
            bt_logout.Click += bt_logout_Click;
            // 
            // label2
            // 
            label2.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            label2.Font = new Font("Segoe UI", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(661, 11);
            label2.Name = "label2";
            label2.Size = new Size(575, 37);
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
            pictureBox1.Size = new Size(31, 35);
            pictureBox1.SizeMode = PictureBoxSizeMode.CenterImage;
            pictureBox1.TabIndex = 1;
            pictureBox1.TabStop = false;
            pictureBox1.Click += pictureBox1_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(91, 19);
            label1.Name = "label1";
            label1.Size = new Size(99, 31);
            label1.TabIndex = 0;
            label1.Text = "Mục lục";
            // 
            // sidebar
            // 
            sidebar.AutoScroll = true;
            sidebar.BackColor = Color.FromArgb(18, 17, 22);
            sidebar.Controls.Add(memberContainer);
            sidebar.Controls.Add(deviceContainer);
            sidebar.Controls.Add(historyContainer);
            sidebar.Dock = DockStyle.Left;
            sidebar.Location = new Point(0, 64);
            sidebar.Margin = new Padding(0);
            sidebar.Name = "sidebar";
            sidebar.Size = new Size(407, 793);
            sidebar.TabIndex = 2;
            // 
            // memberContainer
            // 
            memberContainer.BackColor = Color.FromArgb(255, 192, 128);
            memberContainer.Controls.Add(panel3);
            memberContainer.Location = new Point(0, 0);
            memberContainer.Margin = new Padding(0);
            memberContainer.Name = "memberContainer";
            memberContainer.Size = new Size(357, 99);
            memberContainer.TabIndex = 5;
            // 
            // panel3
            // 
            panel3.Anchor = AnchorStyles.Top;
            panel3.Controls.Add(ThanhVien_bt);
            panel3.Location = new Point(0, 0);
            panel3.Margin = new Padding(0);
            panel3.Name = "panel3";
            panel3.Size = new Size(357, 99);
            panel3.TabIndex = 4;
            // 
            // ThanhVien_bt
            // 
            ThanhVien_bt.BackColor = Color.FromArgb(18, 17, 22);
            ThanhVien_bt.Cursor = Cursors.Hand;
            ThanhVien_bt.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            ThanhVien_bt.ForeColor = Color.White;
            ThanhVien_bt.Image = (Image)resources.GetObject("ThanhVien_bt.Image");
            ThanhVien_bt.Location = new Point(-54, -51);
            ThanhVien_bt.Margin = new Padding(0);
            ThanhVien_bt.Name = "ThanhVien_bt";
            ThanhVien_bt.Padding = new Padding(11, 0, 0, 0);
            ThanhVien_bt.Size = new Size(481, 259);
            ThanhVien_bt.TabIndex = 3;
            ThanhVien_bt.Text = "     Thông tin thành viên";
            ThanhVien_bt.TextAlign = ContentAlignment.MiddleLeft;
            ThanhVien_bt.TextImageRelation = TextImageRelation.ImageBeforeText;
            ThanhVien_bt.UseVisualStyleBackColor = false;
            ThanhVien_bt.Click += ThanhVien_bt_Click;
            // 
            // deviceContainer
            // 
            deviceContainer.BackColor = Color.FromArgb(255, 192, 128);
            deviceContainer.Controls.Add(panel7);
            deviceContainer.Controls.Add(panel9);
            deviceContainer.Controls.Add(panel10);
            deviceContainer.Controls.Add(panel11);
            deviceContainer.Location = new Point(0, 99);
            deviceContainer.Margin = new Padding(0);
            deviceContainer.Name = "deviceContainer";
            deviceContainer.Size = new Size(357, 99);
            deviceContainer.TabIndex = 7;
            // 
            // panel7
            // 
            panel7.Anchor = AnchorStyles.Top;
            panel7.Controls.Add(button6);
            panel7.Location = new Point(0, 0);
            panel7.Margin = new Padding(0);
            panel7.Name = "panel7";
            panel7.Size = new Size(357, 99);
            panel7.TabIndex = 4;
            // 
            // button6
            // 
            button6.BackColor = Color.FromArgb(18, 17, 22);
            button6.Cursor = Cursors.Hand;
            button6.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            button6.ForeColor = Color.White;
            button6.Image = Properties.Resources.icons8_device_40;
            button6.Location = new Point(-54, -51);
            button6.Margin = new Padding(0);
            button6.Name = "button6";
            button6.Padding = new Padding(25, 0, 0, 0);
            button6.Size = new Size(421, 195);
            button6.TabIndex = 3;
            button6.Text = "     Đặt chỗ thiết bị";
            button6.TextAlign = ContentAlignment.MiddleLeft;
            button6.TextImageRelation = TextImageRelation.ImageBeforeText;
            button6.UseVisualStyleBackColor = false;
            button6.Click += button6_Click;
            // 
            // panel9
            // 
            panel9.CausesValidation = false;
            panel9.Controls.Add(button7);
            panel9.Location = new Point(0, 99);
            panel9.Margin = new Padding(0);
            panel9.Name = "panel9";
            panel9.Size = new Size(357, 99);
            panel9.TabIndex = 5;
            // 
            // button7
            // 
            button7.BackColor = Color.FromArgb(65, 65, 65);
            button7.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            button7.ForeColor = Color.White;
            button7.Image = (Image)resources.GetObject("button7.Image");
            button7.Location = new Point(-14, -51);
            button7.Margin = new Padding(0);
            button7.Name = "button7";
            button7.Padding = new Padding(45, 0, 0, 0);
            button7.Size = new Size(378, 195);
            button7.TabIndex = 3;
            button7.Text = "Danh sách thiết bị";
            button7.TextImageRelation = TextImageRelation.ImageBeforeText;
            button7.UseVisualStyleBackColor = false;
            // 
            // panel10
            // 
            panel10.CausesValidation = false;
            panel10.Controls.Add(button8);
            panel10.Location = new Point(0, 198);
            panel10.Margin = new Padding(0);
            panel10.Name = "panel10";
            panel10.Size = new Size(357, 99);
            panel10.TabIndex = 6;
            // 
            // button8
            // 
            button8.BackColor = Color.FromArgb(65, 65, 65);
            button8.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            button8.ForeColor = Color.White;
            button8.Image = (Image)resources.GetObject("button8.Image");
            button8.Location = new Point(-14, -51);
            button8.Margin = new Padding(0);
            button8.Name = "button8";
            button8.Padding = new Padding(55, 0, 0, 0);
            button8.Size = new Size(378, 195);
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
            panel11.Location = new Point(0, 297);
            panel11.Margin = new Padding(0);
            panel11.Name = "panel11";
            panel11.Size = new Size(357, 99);
            panel11.TabIndex = 7;
            // 
            // button9
            // 
            button9.BackColor = Color.FromArgb(65, 65, 65);
            button9.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            button9.ForeColor = Color.White;
            button9.Image = (Image)resources.GetObject("button9.Image");
            button9.Location = new Point(-14, -51);
            button9.Margin = new Padding(0);
            button9.Name = "button9";
            button9.Padding = new Padding(45, 0, 0, 0);
            button9.Size = new Size(378, 195);
            button9.TabIndex = 3;
            button9.Text = "Xem lịch sử mượn";
            button9.TextAlign = ContentAlignment.MiddleLeft;
            button9.TextImageRelation = TextImageRelation.ImageBeforeText;
            button9.UseVisualStyleBackColor = false;
            // 
            // historyContainer
            // 
            historyContainer.BackColor = Color.FromArgb(255, 192, 128);
            historyContainer.Controls.Add(panel6);
            historyContainer.Controls.Add(panel12);
            historyContainer.Controls.Add(panel2);
            historyContainer.Location = new Point(0, 198);
            historyContainer.Margin = new Padding(0);
            historyContainer.Name = "historyContainer";
            historyContainer.Size = new Size(357, 99);
            historyContainer.TabIndex = 8;
            // 
            // panel6
            // 
            panel6.Anchor = AnchorStyles.Top;
            panel6.Controls.Add(bt_violation);
            panel6.Location = new Point(0, 0);
            panel6.Margin = new Padding(0);
            panel6.Name = "panel6";
            panel6.Size = new Size(357, 99);
            panel6.TabIndex = 4;
            // 
            // bt_violation
            // 
            bt_violation.BackColor = Color.FromArgb(18, 17, 22);
            bt_violation.Cursor = Cursors.Hand;
            bt_violation.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            bt_violation.ForeColor = Color.White;
            bt_violation.Image = Properties.Resources.icons8_important_user_40;
            bt_violation.Location = new Point(-54, -51);
            bt_violation.Margin = new Padding(0);
            bt_violation.Name = "bt_violation";
            bt_violation.Padding = new Padding(11, 0, 0, 0);
            bt_violation.Size = new Size(421, 195);
            bt_violation.TabIndex = 3;
            bt_violation.Text = "     Xem lịch sử";
            bt_violation.TextAlign = ContentAlignment.MiddleLeft;
            bt_violation.TextImageRelation = TextImageRelation.ImageBeforeText;
            bt_violation.UseVisualStyleBackColor = false;
            bt_violation.Click += bt_violation_Click;
            // 
            // panel12
            // 
            panel12.CausesValidation = false;
            panel12.Controls.Add(button10);
            panel12.Location = new Point(0, 99);
            panel12.Margin = new Padding(0);
            panel12.Name = "panel12";
            panel12.Size = new Size(357, 99);
            panel12.TabIndex = 5;
            // 
            // button10
            // 
            button10.BackColor = Color.FromArgb(65, 65, 65);
            button10.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            button10.ForeColor = Color.White;
            button10.Image = (Image)resources.GetObject("button10.Image");
            button10.Location = new Point(-14, -51);
            button10.Margin = new Padding(0);
            button10.Name = "button10";
            button10.Padding = new Padding(45, 0, 0, 0);
            button10.Size = new Size(378, 195);
            button10.TabIndex = 3;
            button10.Text = "Lịch sử mượn thiết bị";
            button10.TextImageRelation = TextImageRelation.ImageBeforeText;
            button10.UseVisualStyleBackColor = false;
            // 
            // panel2
            // 
            panel2.CausesValidation = false;
            panel2.Controls.Add(button1);
            panel2.Location = new Point(0, 198);
            panel2.Margin = new Padding(0);
            panel2.Name = "panel2";
            panel2.Size = new Size(357, 99);
            panel2.TabIndex = 6;
            // 
            // button1
            // 
            button1.BackColor = Color.FromArgb(65, 65, 65);
            button1.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            button1.ForeColor = Color.White;
            button1.Image = (Image)resources.GetObject("button1.Image");
            button1.Location = new Point(-14, -51);
            button1.Margin = new Padding(0);
            button1.Name = "button1";
            button1.Padding = new Padding(30, 0, 0, 0);
            button1.Size = new Size(378, 195);
            button1.TabIndex = 3;
            button1.Text = "Lịch sử vi phạm";
            button1.TextImageRelation = TextImageRelation.ImageBeforeText;
            button1.UseVisualStyleBackColor = false;
            // 
            // contentContainer
            // 
            contentContainer.AutoSize = true;
            contentContainer.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            contentContainer.Dock = DockStyle.Fill;
            contentContainer.Location = new Point(407, 64);
            contentContainer.Margin = new Padding(0);
            contentContainer.Name = "contentContainer";
            contentContainer.Size = new Size(1058, 793);
            contentContainer.TabIndex = 3;
            contentContainer.Paint += contentContainer_Paint;
            // 
            // FormUser
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoSize = true;
            ClientSize = new Size(1465, 857);
            Controls.Add(contentContainer);
            Controls.Add(sidebar);
            Controls.Add(panel1);
            Name = "FormUser";
            Text = "FormUser";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            sidebar.ResumeLayout(false);
            memberContainer.ResumeLayout(false);
            panel3.ResumeLayout(false);
            deviceContainer.ResumeLayout(false);
            panel7.ResumeLayout(false);
            panel9.ResumeLayout(false);
            panel10.ResumeLayout(false);
            panel11.ResumeLayout(false);
            historyContainer.ResumeLayout(false);
            panel6.ResumeLayout(false);
            panel12.ResumeLayout(false);
            panel2.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private System.Windows.Forms.Timer memberTransition;
        private System.Windows.Forms.Timer menuTransition;
        private System.Windows.Forms.Timer deviceTransition;
        private System.Windows.Forms.Timer statisticsTransition;
        private System.Windows.Forms.Timer historyTransition;
        private Panel panel1;
        private Label label2;
        private PictureBox pictureBox1;
        private Label label1;
        private FlowLayoutPanel sidebar;
        private FlowLayoutPanel memberContainer;
        private Panel panel3;
        private Button ThanhVien_bt;
        private FlowLayoutPanel deviceContainer;
        private Panel panel7;
        private Button button6;
        private Panel panel9;
        private Button button7;
        private Panel panel10;
        private Button button8;
        private Panel panel11;
        private Button button9;
        private FlowLayoutPanel historyContainer;
        private Panel panel6;
        private Button bt_violation;
        private Panel panel12;
        private Button button10;
        private Panel contentContainer;
        private Panel panel2;
        private Button button1;
        private Label label3;
        private Label bt_logout;
    }
}