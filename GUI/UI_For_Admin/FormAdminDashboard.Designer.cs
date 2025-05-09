﻿namespace QLTV
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
            label2 = new Label();
            bt_menu = new PictureBox();
            label1 = new Label();
            sidebar = new FlowLayoutPanel();
            panel2 = new Panel();
            bt_home = new Button();
            memberContainer = new FlowLayoutPanel();
            panel3 = new Panel();
            bt_member = new Button();
            panel4 = new Panel();
            bt_memberlist = new Button();
            panel5 = new Panel();
            bt_learnspace = new Button();
            deviceContainer = new FlowLayoutPanel();
            panel7 = new Panel();
            bt_device_transition = new Button();
            panel9 = new Panel();
            bt_deviceList = new Button();
            panel10 = new Panel();
            bt_borrweddevice = new Button();
            violationContainer = new FlowLayoutPanel();
            panel6 = new Panel();
            bt_violationList = new Button();
            statisticsContainer = new FlowLayoutPanel();
            panel14 = new Panel();
            bt_statistics = new Button();
            menuTransition = new System.Windows.Forms.Timer(components);
            contentContainer = new Panel();
            deviceTransition = new System.Windows.Forms.Timer(components);
            memberTransition = new System.Windows.Forms.Timer(components);
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)bt_menu).BeginInit();
            sidebar.SuspendLayout();
            panel2.SuspendLayout();
            memberContainer.SuspendLayout();
            panel3.SuspendLayout();
            panel4.SuspendLayout();
            panel5.SuspendLayout();
            deviceContainer.SuspendLayout();
            panel7.SuspendLayout();
            panel9.SuspendLayout();
            panel10.SuspendLayout();
            violationContainer.SuspendLayout();
            panel6.SuspendLayout();
            statisticsContainer.SuspendLayout();
            panel14.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.White;
            panel1.Controls.Add(label2);
            panel1.Controls.Add(bt_menu);
            panel1.Controls.Add(label1);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(1312, 48);
            panel1.TabIndex = 0;
            // 
            // label2
            // 
            label2.Anchor = AnchorStyles.Top | AnchorStyles.Bottom;
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(578, 8);
            label2.Name = "label2";
            label2.Size = new Size(306, 30);
            label2.TabIndex = 3;
            label2.Text = "Phần mềm quản lý thư quán";
            label2.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // bt_menu
            // 
            bt_menu.Cursor = Cursors.Hand;
            bt_menu.Image = (Image)resources.GetObject("bt_menu.Image");
            bt_menu.Location = new Point(39, 12);
            bt_menu.Name = "bt_menu";
            bt_menu.Size = new Size(27, 26);
            bt_menu.SizeMode = PictureBoxSizeMode.CenterImage;
            bt_menu.TabIndex = 1;
            bt_menu.TabStop = false;
            bt_menu.Click += bt_menu_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(80, 14);
            label1.Name = "label1";
            label1.Size = new Size(82, 25);
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
            sidebar.Location = new Point(0, 48);
            sidebar.Margin = new Padding(0);
            sidebar.Name = "sidebar";
            sidebar.Size = new Size(312, 623);
            sidebar.TabIndex = 1;
            // 
            // panel2
            // 
            panel2.Controls.Add(bt_home);
            panel2.Cursor = Cursors.Hand;
            panel2.Location = new Point(0, 0);
            panel2.Margin = new Padding(0);
            panel2.Name = "panel2";
            panel2.Size = new Size(312, 74);
            panel2.TabIndex = 2;
            // 
            // bt_home
            // 
            bt_home.BackColor = Color.FromArgb(18, 17, 22);
            bt_home.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            bt_home.ForeColor = Color.White;
            bt_home.Image = qltv_Winform.Properties.Resources.icons8_home_40;
            bt_home.Location = new Point(-47, -38);
            bt_home.Margin = new Padding(0);
            bt_home.Name = "bt_home";
            bt_home.Padding = new Padding(13, 0, 0, 0);
            bt_home.Size = new Size(368, 146);
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
            memberContainer.Controls.Add(panel4);
            memberContainer.Controls.Add(panel5);
            memberContainer.Location = new Point(0, 74);
            memberContainer.Margin = new Padding(0);
            memberContainer.Name = "memberContainer";
            memberContainer.Size = new Size(312, 71);
            memberContainer.TabIndex = 5;
            // 
            // panel3
            // 
            panel3.Anchor = AnchorStyles.Top;
            panel3.Controls.Add(bt_member);
            panel3.Location = new Point(0, 0);
            panel3.Margin = new Padding(0);
            panel3.Name = "panel3";
            panel3.Size = new Size(312, 74);
            panel3.TabIndex = 4;
            // 
            // bt_member
            // 
            bt_member.BackColor = Color.FromArgb(18, 17, 22);
            bt_member.Cursor = Cursors.Hand;
            bt_member.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            bt_member.ForeColor = Color.White;
            bt_member.Image = (Image)resources.GetObject("bt_member.Image");
            bt_member.Location = new Point(-47, -38);
            bt_member.Margin = new Padding(0);
            bt_member.Name = "bt_member";
            bt_member.Padding = new Padding(44, 0, 0, 0);
            bt_member.Size = new Size(368, 146);
            bt_member.TabIndex = 3;
            bt_member.Text = "     Danh sách thành viên";
            bt_member.TextAlign = ContentAlignment.MiddleLeft;
            bt_member.TextImageRelation = TextImageRelation.ImageBeforeText;
            bt_member.UseVisualStyleBackColor = false;
            bt_member.Click += bt_member_click;
            // 
            // panel4
            // 
            panel4.CausesValidation = false;
            panel4.Controls.Add(bt_memberlist);
            panel4.Location = new Point(0, 74);
            panel4.Margin = new Padding(0);
            panel4.Name = "panel4";
            panel4.Size = new Size(312, 74);
            panel4.TabIndex = 6;
            // 
            // bt_memberlist
            // 
            bt_memberlist.BackColor = Color.FromArgb(65, 65, 65);
            bt_memberlist.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            bt_memberlist.ForeColor = Color.White;
            bt_memberlist.Image = (Image)resources.GetObject("bt_memberlist.Image");
            bt_memberlist.Location = new Point(-12, -38);
            bt_memberlist.Margin = new Padding(0);
            bt_memberlist.Name = "bt_memberlist";
            bt_memberlist.Padding = new Padding(39, 0, 0, 0);
            bt_memberlist.Size = new Size(331, 146);
            bt_memberlist.TabIndex = 3;
            bt_memberlist.Text = "Danh sách thành viên";
            bt_memberlist.TextImageRelation = TextImageRelation.ImageBeforeText;
            bt_memberlist.UseVisualStyleBackColor = false;
            bt_memberlist.Click += bt_memberlist_Click;
            // 
            // panel5
            // 
            panel5.CausesValidation = false;
            panel5.Controls.Add(bt_learnspace);
            panel5.Location = new Point(0, 148);
            panel5.Margin = new Padding(0);
            panel5.Name = "panel5";
            panel5.Size = new Size(312, 74);
            panel5.TabIndex = 7;
            // 
            // bt_learnspace
            // 
            bt_learnspace.BackColor = Color.FromArgb(65, 65, 65);
            bt_learnspace.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            bt_learnspace.ForeColor = Color.White;
            bt_learnspace.Image = (Image)resources.GetObject("bt_learnspace.Image");
            bt_learnspace.Location = new Point(-12, -38);
            bt_learnspace.Margin = new Padding(0);
            bt_learnspace.Name = "bt_learnspace";
            bt_learnspace.Padding = new Padding(39, 0, 0, 0);
            bt_learnspace.Size = new Size(331, 146);
            bt_learnspace.TabIndex = 3;
            bt_learnspace.Text = "Khu học tập";
            bt_learnspace.TextImageRelation = TextImageRelation.ImageBeforeText;
            bt_learnspace.UseVisualStyleBackColor = false;
            bt_learnspace.Click += bt_learnspace_Click;
            // 
            // deviceContainer
            // 
            deviceContainer.BackColor = Color.FromArgb(255, 192, 128);
            deviceContainer.Controls.Add(panel7);
            deviceContainer.Controls.Add(panel9);
            deviceContainer.Controls.Add(panel10);
            deviceContainer.Location = new Point(0, 145);
            deviceContainer.Margin = new Padding(0);
            deviceContainer.Name = "deviceContainer";
            deviceContainer.Size = new Size(312, 74);
            deviceContainer.TabIndex = 7;
            // 
            // panel7
            // 
            panel7.Anchor = AnchorStyles.Top;
            panel7.Controls.Add(bt_device_transition);
            panel7.Location = new Point(0, 0);
            panel7.Margin = new Padding(0);
            panel7.Name = "panel7";
            panel7.Size = new Size(312, 74);
            panel7.TabIndex = 4;
            // 
            // bt_device_transition
            // 
            bt_device_transition.BackColor = Color.FromArgb(18, 17, 22);
            bt_device_transition.Cursor = Cursors.Hand;
            bt_device_transition.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            bt_device_transition.ForeColor = Color.White;
            bt_device_transition.Image = qltv_Winform.Properties.Resources.icons8_device_40;
            bt_device_transition.Location = new Point(-47, -38);
            bt_device_transition.Margin = new Padding(0);
            bt_device_transition.Name = "bt_device_transition";
            bt_device_transition.Padding = new Padding(9, 0, 0, 0);
            bt_device_transition.Size = new Size(368, 146);
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
            panel9.Location = new Point(0, 74);
            panel9.Margin = new Padding(0);
            panel9.Name = "panel9";
            panel9.Size = new Size(312, 74);
            panel9.TabIndex = 5;
            // 
            // bt_deviceList
            // 
            bt_deviceList.BackColor = Color.FromArgb(65, 65, 65);
            bt_deviceList.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            bt_deviceList.ForeColor = Color.White;
            bt_deviceList.Image = (Image)resources.GetObject("bt_deviceList.Image");
            bt_deviceList.Location = new Point(-12, -38);
            bt_deviceList.Margin = new Padding(0);
            bt_deviceList.Name = "bt_deviceList";
            bt_deviceList.Padding = new Padding(39, 0, 0, 0);
            bt_deviceList.Size = new Size(331, 146);
            bt_deviceList.TabIndex = 3;
            bt_deviceList.Text = "Danh sách thiết bị";
            bt_deviceList.TextImageRelation = TextImageRelation.ImageBeforeText;
            bt_deviceList.UseVisualStyleBackColor = false;
            bt_deviceList.Click += bt_deviceList_Click;
            // 
            // panel10
            // 
            panel10.CausesValidation = false;
            panel10.Controls.Add(bt_borrweddevice);
            panel10.Location = new Point(0, 148);
            panel10.Margin = new Padding(0);
            panel10.Name = "panel10";
            panel10.Size = new Size(312, 74);
            panel10.TabIndex = 6;
            // 
            // bt_borrweddevice
            // 
            bt_borrweddevice.BackColor = Color.FromArgb(65, 65, 65);
            bt_borrweddevice.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            bt_borrweddevice.ForeColor = Color.White;
            bt_borrweddevice.Image = (Image)resources.GetObject("bt_borrweddevice.Image");
            bt_borrweddevice.Location = new Point(-12, -38);
            bt_borrweddevice.Margin = new Padding(0);
            bt_borrweddevice.Name = "bt_borrweddevice";
            bt_borrweddevice.Padding = new Padding(48, 0, 0, 0);
            bt_borrweddevice.Size = new Size(331, 146);
            bt_borrweddevice.TabIndex = 3;
            bt_borrweddevice.Text = "Xử lý đặt chỗ thiết bị";
            bt_borrweddevice.TextAlign = ContentAlignment.MiddleLeft;
            bt_borrweddevice.TextImageRelation = TextImageRelation.ImageBeforeText;
            bt_borrweddevice.UseVisualStyleBackColor = false;
            bt_borrweddevice.Click += bt_borrweddevice_Click;
            // 
            // violationContainer
            // 
            violationContainer.BackColor = Color.FromArgb(255, 192, 128);
            violationContainer.Controls.Add(panel6);
            violationContainer.Location = new Point(0, 219);
            violationContainer.Margin = new Padding(0);
            violationContainer.Name = "violationContainer";
            violationContainer.Size = new Size(312, 74);
            violationContainer.TabIndex = 8;
            // 
            // panel6
            // 
            panel6.Anchor = AnchorStyles.Top;
            panel6.Controls.Add(bt_violationList);
            panel6.Location = new Point(0, 0);
            panel6.Margin = new Padding(0);
            panel6.Name = "panel6";
            panel6.Size = new Size(312, 74);
            panel6.TabIndex = 4;
            // 
            // bt_violationList
            // 
            bt_violationList.BackColor = Color.FromArgb(18, 17, 22);
            bt_violationList.Cursor = Cursors.Hand;
            bt_violationList.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            bt_violationList.ForeColor = Color.White;
            bt_violationList.Image = qltv_Winform.Properties.Resources.icons8_important_user_40;
            bt_violationList.Location = new Point(-47, -38);
            bt_violationList.Margin = new Padding(0);
            bt_violationList.Name = "bt_violationList";
            bt_violationList.Padding = new Padding(9, 0, 0, 0);
            bt_violationList.Size = new Size(368, 146);
            bt_violationList.TabIndex = 3;
            bt_violationList.Text = "     Vi phạm";
            bt_violationList.TextAlign = ContentAlignment.MiddleLeft;
            bt_violationList.TextImageRelation = TextImageRelation.ImageBeforeText;
            bt_violationList.UseVisualStyleBackColor = false;
            bt_violationList.Click += bt_violationList_Click;
            // 
            // statisticsContainer
            // 
            statisticsContainer.BackColor = Color.FromArgb(255, 192, 128);
            statisticsContainer.Controls.Add(panel14);
            statisticsContainer.Location = new Point(0, 293);
            statisticsContainer.Margin = new Padding(0);
            statisticsContainer.Name = "statisticsContainer";
            statisticsContainer.Size = new Size(312, 74);
            statisticsContainer.TabIndex = 9;
            // 
            // panel14
            // 
            panel14.Anchor = AnchorStyles.Top;
            panel14.Controls.Add(bt_statistics);
            panel14.Location = new Point(0, 0);
            panel14.Margin = new Padding(0);
            panel14.Name = "panel14";
            panel14.Size = new Size(312, 74);
            panel14.TabIndex = 4;
            // 
            // bt_statistics
            // 
            bt_statistics.BackColor = Color.FromArgb(18, 17, 22);
            bt_statistics.Cursor = Cursors.Hand;
            bt_statistics.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            bt_statistics.ForeColor = Color.White;
            bt_statistics.Image = qltv_Winform.Properties.Resources.icons8_statistics_40;
            bt_statistics.Location = new Point(-47, -38);
            bt_statistics.Margin = new Padding(0);
            bt_statistics.Name = "bt_statistics";
            bt_statistics.Padding = new Padding(9, 0, 0, 0);
            bt_statistics.Size = new Size(368, 146);
            bt_statistics.TabIndex = 3;
            bt_statistics.Text = "     Thống kê";
            bt_statistics.TextAlign = ContentAlignment.MiddleLeft;
            bt_statistics.TextImageRelation = TextImageRelation.ImageBeforeText;
            bt_statistics.UseVisualStyleBackColor = false;
            bt_statistics.Click += bt_statistics_Click;
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
            contentContainer.Location = new Point(312, 48);
            contentContainer.Margin = new Padding(0);
            contentContainer.Name = "contentContainer";
            contentContainer.Size = new Size(1000, 623);
            contentContainer.TabIndex = 2;
            // 
            // deviceTransition
            // 
            deviceTransition.Interval = 10;
            deviceTransition.Tick += deviceTransition_Tick;
            // 
            // memberTransition
            // 
            memberTransition.Interval = 10;
            memberTransition.Tick += memberTransition_Tick;
            // 
            // FormAdminDashboard
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1312, 671);
            Controls.Add(contentContainer);
            Controls.Add(sidebar);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "FormAdminDashboard";
            Text = "Form1";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)bt_menu).EndInit();
            sidebar.ResumeLayout(false);
            panel2.ResumeLayout(false);
            memberContainer.ResumeLayout(false);
            panel3.ResumeLayout(false);
            panel4.ResumeLayout(false);
            panel5.ResumeLayout(false);
            deviceContainer.ResumeLayout(false);
            panel7.ResumeLayout(false);
            panel9.ResumeLayout(false);
            panel10.ResumeLayout(false);
            violationContainer.ResumeLayout(false);
            panel6.ResumeLayout(false);
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
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.FlowLayoutPanel memberContainer;
        private System.Windows.Forms.Timer menuTransition;
        private System.Windows.Forms.Panel contentContainer;
        private FlowLayoutPanel deviceContainer;
        private Panel panel7;
        private Button bt_device_transition;
        private Panel panel9;
        private Button bt_deviceList;
        private Panel panel10;
        private Button bt_borrweddevice;
        private System.Windows.Forms.Timer deviceTransition;
        private FlowLayoutPanel violationContainer;
        private Panel panel6;
        private Button bt_violationList;
        private FlowLayoutPanel statisticsContainer;
        private Panel panel14;
        private Button bt_statistics;
        private Panel panel4;
        private Button bt_memberlist;
        private Panel panel5;
        private Button bt_learnspace;
        private System.Windows.Forms.Timer memberTransition;
    }
}