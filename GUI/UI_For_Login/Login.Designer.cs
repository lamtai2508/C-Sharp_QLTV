namespace qltv.GUI.UI_For_Login
{
    partial class Login
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Login));
            panel1 = new Panel();
            flowLayoutPanel1 = new FlowLayoutPanel();
            pictureBox1 = new PictureBox();
            tb_user = new TextBox();
            label4 = new Label();
            flowLayoutPanel2 = new FlowLayoutPanel();
            pictureBox2 = new PictureBox();
            tb_password = new TextBox();
            bt_Login = new Button();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            panel1.SuspendLayout();
            flowLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            flowLayoutPanel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = SystemColors.MenuBar;
            panel1.Controls.Add(flowLayoutPanel1);
            panel1.Controls.Add(label4);
            panel1.Controls.Add(flowLayoutPanel2);
            panel1.Controls.Add(bt_Login);
            panel1.Controls.Add(label3);
            panel1.Controls.Add(label2);
            panel1.Controls.Add(label1);
            panel1.Dock = DockStyle.Fill;
            panel1.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            panel1.Location = new Point(0, 0);
            panel1.Margin = new Padding(0);
            panel1.Name = "panel1";
            panel1.Size = new Size(582, 483);
            panel1.TabIndex = 0;
            // 
            // flowLayoutPanel1
            // 
            flowLayoutPanel1.AutoSize = true;
            flowLayoutPanel1.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            flowLayoutPanel1.BackColor = Color.White;
            flowLayoutPanel1.BorderStyle = BorderStyle.FixedSingle;
            flowLayoutPanel1.Controls.Add(pictureBox1);
            flowLayoutPanel1.Controls.Add(tb_user);
            flowLayoutPanel1.Location = new Point(45, 120);
            flowLayoutPanel1.Name = "flowLayoutPanel1";
            flowLayoutPanel1.Size = new Size(493, 45);
            flowLayoutPanel1.TabIndex = 8;
            // 
            // pictureBox1
            // 
            pictureBox1.BackColor = Color.White;
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(5, 5);
            pictureBox1.Margin = new Padding(5);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(32, 33);
            pictureBox1.TabIndex = 7;
            pictureBox1.TabStop = false;
            // 
            // tb_user
            // 
            tb_user.BorderStyle = BorderStyle.None;
            tb_user.Cursor = Cursors.IBeam;
            tb_user.ForeColor = Color.Gray;
            tb_user.Location = new Point(47, 5);
            tb_user.Margin = new Padding(5);
            tb_user.Name = "tb_user";
            tb_user.Size = new Size(439, 27);
            tb_user.TabIndex = 3;
            tb_user.Text = "Mã thành viên";
            tb_user.Enter += tb_user_Enter;
            tb_user.Leave += tb_user_Leave;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Cursor = Cursors.Hand;
            label4.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.ForeColor = Color.FromArgb(100, 50, 20);
            label4.Location = new Point(45, 410);
            label4.Margin = new Padding(3, 3, 3, 0);
            label4.Name = "label4";
            label4.Size = new Size(309, 23);
            label4.TabIndex = 6;
            label4.Text = "Bạn chưa có tài khoản? Đăng ký ngay";
            // 
            // flowLayoutPanel2
            // 
            flowLayoutPanel2.AutoSize = true;
            flowLayoutPanel2.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            flowLayoutPanel2.BackColor = Color.White;
            flowLayoutPanel2.BorderStyle = BorderStyle.FixedSingle;
            flowLayoutPanel2.Controls.Add(pictureBox2);
            flowLayoutPanel2.Controls.Add(tb_password);
            flowLayoutPanel2.Location = new Point(45, 245);
            flowLayoutPanel2.Name = "flowLayoutPanel2";
            flowLayoutPanel2.Size = new Size(499, 45);
            flowLayoutPanel2.TabIndex = 9;
            // 
            // pictureBox2
            // 
            pictureBox2.BackColor = Color.White;
            pictureBox2.Image = (Image)resources.GetObject("pictureBox2.Image");
            pictureBox2.Location = new Point(5, 5);
            pictureBox2.Margin = new Padding(5);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(32, 33);
            pictureBox2.TabIndex = 7;
            pictureBox2.TabStop = false;
            // 
            // tb_password
            // 
            tb_password.BorderStyle = BorderStyle.None;
            tb_password.Cursor = Cursors.IBeam;
            tb_password.ForeColor = Color.Gray;
            tb_password.Location = new Point(47, 5);
            tb_password.Margin = new Padding(5);
            tb_password.Name = "tb_password";
            tb_password.Size = new Size(445, 27);
            tb_password.TabIndex = 3;
            tb_password.Text = "Mật khẩu";
            tb_password.Enter += tb_password_Enter;
            tb_password.Leave += tb_password_Leave;
            // 
            // bt_Login
            // 
            bt_Login.BackColor = Color.FromArgb(224, 224, 224);
            bt_Login.Cursor = Cursors.Hand;
            bt_Login.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            bt_Login.ForeColor = Color.Black;
            bt_Login.Location = new Point(45, 330);
            bt_Login.Margin = new Padding(0);
            bt_Login.Name = "bt_Login";
            bt_Login.Padding = new Padding(10);
            bt_Login.Size = new Size(499, 58);
            bt_Login.TabIndex = 5;
            bt_Login.Text = "ĐĂNG NHẬP";
            bt_Login.UseVisualStyleBackColor = false;
            bt_Login.Click += bt_Login_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold | FontStyle.Underline, GraphicsUnit.Point, 0);
            label3.ForeColor = Color.Black;
            label3.Location = new Point(45, 200);
            label3.Name = "label3";
            label3.Size = new Size(116, 31);
            label3.TabIndex = 2;
            label3.Text = "Mật khẩu";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold | FontStyle.Underline, GraphicsUnit.Point, 0);
            label2.ForeColor = Color.Black;
            label2.Location = new Point(45, 75);
            label2.Name = "label2";
            label2.Size = new Size(117, 31);
            label2.TabIndex = 1;
            label2.Text = "Tài khoản";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.Black;
            label1.Location = new Point(206, 20);
            label1.Name = "label1";
            label1.Size = new Size(188, 38);
            label1.TabIndex = 0;
            label1.Text = "ĐĂNG NHẬP";
            label1.TextAlign = ContentAlignment.TopCenter;
            // 
            // Login
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(582, 483);
            Controls.Add(panel1);
            MaximumSize = new Size(600, 530);
            Name = "Login";
            Text = "Login";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            flowLayoutPanel1.ResumeLayout(false);
            flowLayoutPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            flowLayoutPanel2.ResumeLayout(false);
            flowLayoutPanel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Label label1;
        private TextBox tb_user;
        private Label label3;
        private Label label2;
        private Button bt_Login;
        private Label label4;
        private PictureBox pictureBox1;
        private FlowLayoutPanel flowLayoutPanel1;
        private FlowLayoutPanel flowLayoutPanel2;
        private PictureBox pictureBox2;
        private TextBox tb_password;
    }
}