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
            button4 = new Button();
            menuContainer = new FlowLayoutPanel();
            panel3 = new Panel();
            ThanhVien_bt = new Button();
            MemberList = new Panel();
            btn_member = new Button();
            panel8 = new Panel();
            button2 = new Button();
            panel5 = new Panel();
            button1 = new Button();
            panel4 = new Panel();
            button3 = new Button();
            panel6 = new Panel();
            button5 = new Button();
            menuTransition = new System.Windows.Forms.Timer(components);
            sidebarTransition = new System.Windows.Forms.Timer(components);
            contentContainer = new Panel();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            sidebar.SuspendLayout();
            panel2.SuspendLayout();
            menuContainer.SuspendLayout();
            panel3.SuspendLayout();
            MemberList.SuspendLayout();
            panel8.SuspendLayout();
            panel5.SuspendLayout();
            panel4.SuspendLayout();
            panel6.SuspendLayout();
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
            sidebar.BackColor = Color.FromArgb(18, 17, 22);
            sidebar.Controls.Add(panel2);
            sidebar.Controls.Add(menuContainer);
            sidebar.Controls.Add(panel5);
            sidebar.Controls.Add(panel4);
            sidebar.Controls.Add(panel6);
            sidebar.Dock = DockStyle.Left;
            sidebar.Location = new Point(0, 64);
            sidebar.Margin = new Padding(0);
            sidebar.Name = "sidebar";
            sidebar.Size = new Size(356, 811);
            sidebar.TabIndex = 1;
            // 
            // panel2
            // 
            panel2.Controls.Add(button4);
            panel2.Cursor = Cursors.Hand;
            panel2.Location = new Point(0, 0);
            panel2.Margin = new Padding(0);
            panel2.Name = "panel2";
            panel2.Size = new Size(356, 98);
            panel2.TabIndex = 2;
            // 
            // button4
            // 
            button4.BackColor = Color.FromArgb(18, 17, 22);
            button4.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            button4.ForeColor = Color.White;
            button4.Image = (Image)resources.GetObject("button4.Image");
            button4.Location = new Point(-54, -50);
            button4.Margin = new Padding(0);
            button4.Name = "button4";
            button4.Padding = new Padding(10, 0, 0, 0);
            button4.Size = new Size(421, 194);
            button4.TabIndex = 4;
            button4.Text = "    Trang chủ";
            button4.TextAlign = ContentAlignment.MiddleLeft;
            button4.TextImageRelation = TextImageRelation.ImageBeforeText;
            button4.UseVisualStyleBackColor = false;
            button4.Click += button4_Click_1;
            // 
            // menuContainer
            // 
            menuContainer.BackColor = Color.FromArgb(255, 192, 128);
            menuContainer.Controls.Add(panel3);
            menuContainer.Controls.Add(MemberList);
            menuContainer.Controls.Add(panel8);
            menuContainer.Location = new Point(0, 98);
            menuContainer.Margin = new Padding(0);
            menuContainer.Name = "menuContainer";
            menuContainer.Size = new Size(356, 98);
            menuContainer.TabIndex = 5;
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
            // panel5
            // 
            panel5.Controls.Add(button1);
            panel5.Location = new Point(0, 196);
            panel5.Margin = new Padding(0);
            panel5.Name = "panel5";
            panel5.Size = new Size(356, 98);
            panel5.TabIndex = 3;
            // 
            // button1
            // 
            button1.BackColor = Color.FromArgb(18, 17, 22);
            button1.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            button1.ForeColor = Color.White;
            button1.Image = (Image)resources.GetObject("button1.Image");
            button1.Location = new Point(-54, -50);
            button1.Margin = new Padding(3, 4, 3, 4);
            button1.Name = "button1";
            button1.Padding = new Padding(10, 0, 0, 0);
            button1.Size = new Size(421, 194);
            button1.TabIndex = 3;
            button1.Text = "     Vi phạm";
            button1.TextAlign = ContentAlignment.MiddleLeft;
            button1.TextImageRelation = TextImageRelation.ImageBeforeText;
            button1.UseVisualStyleBackColor = false;
            // 
            // panel4
            // 
            panel4.Controls.Add(button3);
            panel4.Location = new Point(0, 294);
            panel4.Margin = new Padding(0);
            panel4.Name = "panel4";
            panel4.Size = new Size(356, 98);
            panel4.TabIndex = 4;
            // 
            // button3
            // 
            button3.BackColor = Color.FromArgb(18, 17, 22);
            button3.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            button3.ForeColor = Color.White;
            button3.Image = (Image)resources.GetObject("button3.Image");
            button3.Location = new Point(-54, -50);
            button3.Margin = new Padding(3, 4, 3, 4);
            button3.Name = "button3";
            button3.Padding = new Padding(10, 0, 0, 0);
            button3.Size = new Size(421, 194);
            button3.TabIndex = 3;
            button3.Text = "      Thống kê";
            button3.TextAlign = ContentAlignment.MiddleLeft;
            button3.TextImageRelation = TextImageRelation.ImageBeforeText;
            button3.UseVisualStyleBackColor = false;
            // 
            // panel6
            // 
            panel6.Controls.Add(button5);
            panel6.Location = new Point(0, 392);
            panel6.Margin = new Padding(0);
            panel6.Name = "panel6";
            panel6.Size = new Size(356, 98);
            panel6.TabIndex = 4;
            // 
            // button5
            // 
            button5.BackColor = Color.FromArgb(18, 17, 22);
            button5.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            button5.ForeColor = Color.White;
            button5.Image = (Image)resources.GetObject("button5.Image");
            button5.Location = new Point(-54, -50);
            button5.Margin = new Padding(3, 4, 3, 4);
            button5.Name = "button5";
            button5.Padding = new Padding(10, 0, 0, 0);
            button5.Size = new Size(421, 194);
            button5.TabIndex = 5;
            button5.Text = "     Thiết bị";
            button5.TextAlign = ContentAlignment.MiddleLeft;
            button5.TextImageRelation = TextImageRelation.ImageBeforeText;
            button5.UseVisualStyleBackColor = false;
            // 
            // menuTransition
            // 
            menuTransition.Interval = 10;
            menuTransition.Tick += MenuTransition_Tick;
            // 
            // sidebarTransition
            // 
            sidebarTransition.Interval = 10;
            sidebarTransition.Tick += sidebarTransition_Tick;
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
            contentContainer.Resize += contentContainer_Resize;
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
            menuContainer.ResumeLayout(false);
            panel3.ResumeLayout(false);
            MemberList.ResumeLayout(false);
            panel8.ResumeLayout(false);
            panel5.ResumeLayout(false);
            panel4.ResumeLayout(false);
            panel6.ResumeLayout(false);
            ResumeLayout(false);

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

