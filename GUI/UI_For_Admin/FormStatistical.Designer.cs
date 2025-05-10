namespace qltv.GUI.UI_For_Admin
{
    partial class FormStatistical
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            dateTimePickerStart = new DateTimePicker();
            dateTimePickerEnd = new DateTimePicker();
            btn_Filter = new Button();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            table_MemberStats = new DataGridView();
            table_DeviceBorrowing = new DataGridView();
            table_CurrentBorrowed = new DataGridView();
            table_Violations = new DataGridView();
            table_ActiveMembers = new DataGridView();
            lbl_TotalCompensation = new Label();
            ((System.ComponentModel.ISupportInitialize)table_MemberStats).BeginInit();
            ((System.ComponentModel.ISupportInitialize)table_DeviceBorrowing).BeginInit();
            ((System.ComponentModel.ISupportInitialize)table_CurrentBorrowed).BeginInit();
            ((System.ComponentModel.ISupportInitialize)table_Violations).BeginInit();
            ((System.ComponentModel.ISupportInitialize)table_ActiveMembers).BeginInit();
            SuspendLayout();
            // 
            // dateTimePickerStart
            // 
            dateTimePickerStart.Location = new Point(50, 20);
            dateTimePickerStart.Name = "dateTimePickerStart";
            dateTimePickerStart.Size = new Size(200, 27);
            dateTimePickerStart.TabIndex = 0;
            // 
            // dateTimePickerEnd
            // 
            dateTimePickerEnd.Location = new Point(300, 20);
            dateTimePickerEnd.Name = "dateTimePickerEnd";
            dateTimePickerEnd.Size = new Size(200, 27);
            dateTimePickerEnd.TabIndex = 1;
            // 
            // btn_Filter
            // 
            btn_Filter.Location = new Point(550, 20);
            btn_Filter.Name = "btn_Filter";
            btn_Filter.Size = new Size(100, 30);
            btn_Filter.TabIndex = 2;
            btn_Filter.Text = "Lọc";
            btn_Filter.UseVisualStyleBackColor = true;
            btn_Filter.Click += btn_Filter_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            label1.Location = new Point(50, 70);
            label1.Name = "label1";
            label1.Size = new Size(204, 28);
            label1.TabIndex = 3;
            label1.Text = "Số lượng thành viên";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            label2.Location = new Point(50, 290);
            label2.Name = "label2";
            label2.Size = new Size(202, 28);
            label2.TabIndex = 4;
            label2.Text = "Thiết bị được mượn";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            label3.Location = new Point(550, 290);
            label3.Name = "label3";
            label3.Size = new Size(256, 28);
            label3.TabIndex = 5;
            label3.Text = "Thiết bị đang được mượn";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            label4.Location = new Point(50, 522);
            label4.Name = "label4";
            label4.Size = new Size(143, 28);
            label4.TabIndex = 6;
            label4.Text = "Xử lý vi phạm";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 10F);
            label5.Location = new Point(50, 560);
            label5.Name = "label5";
            label5.Size = new Size(177, 23);
            label5.TabIndex = 7;
            label5.Text = "Tổng tiền bồi thường:";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            label6.Location = new Point(550, 70);
            label6.Name = "label6";
            label6.Size = new Size(275, 28);
            label6.TabIndex = 13;
            label6.Text = "Thành viên đang hoạt động";
            // 
            // table_MemberStats
            // 
            table_MemberStats.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.ColumnHeader;
            table_MemberStats.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllHeaders;
            table_MemberStats.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            table_MemberStats.Location = new Point(50, 110);
            table_MemberStats.Name = "table_MemberStats";
            table_MemberStats.RowHeadersWidth = 51;
            table_MemberStats.Size = new Size(450, 120);
            table_MemberStats.TabIndex = 8;
            // 
            // table_DeviceBorrowing
            // 
            table_DeviceBorrowing.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            table_DeviceBorrowing.Location = new Point(50, 338);
            table_DeviceBorrowing.Name = "table_DeviceBorrowing";
            table_DeviceBorrowing.RowHeadersWidth = 51;
            table_DeviceBorrowing.Size = new Size(450, 120);
            table_DeviceBorrowing.TabIndex = 9;
            // 
            // table_CurrentBorrowed
            // 
            table_CurrentBorrowed.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            table_CurrentBorrowed.Location = new Point(550, 338);
            table_CurrentBorrowed.Name = "table_CurrentBorrowed";
            table_CurrentBorrowed.RowHeadersWidth = 51;
            table_CurrentBorrowed.Size = new Size(796, 120);
            table_CurrentBorrowed.TabIndex = 10;
            // 
            // table_Violations
            // 
            table_Violations.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            table_Violations.Location = new Point(50, 597);
            table_Violations.Name = "table_Violations";
            table_Violations.RowHeadersWidth = 51;
            table_Violations.Size = new Size(900, 120);
            table_Violations.TabIndex = 11;
            // 
            // table_ActiveMembers
            // 
            table_ActiveMembers.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            table_ActiveMembers.Location = new Point(550, 110);
            table_ActiveMembers.Name = "table_ActiveMembers";
            table_ActiveMembers.RowHeadersWidth = 51;
            table_ActiveMembers.Size = new Size(450, 120);
            table_ActiveMembers.TabIndex = 14;
            // 
            // lbl_TotalCompensation
            // 
            lbl_TotalCompensation.AutoSize = true;
            lbl_TotalCompensation.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            lbl_TotalCompensation.Location = new Point(245, 560);
            lbl_TotalCompensation.Name = "lbl_TotalCompensation";
            lbl_TotalCompensation.Size = new Size(203, 23);
            lbl_TotalCompensation.TabIndex = 12;
            lbl_TotalCompensation.Text = "Tổng tiền bồi thường: 0";
            // 
            // FormStatistical
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1358, 1000);
            Controls.Add(table_ActiveMembers);
            Controls.Add(lbl_TotalCompensation);
            Controls.Add(table_Violations);
            Controls.Add(table_CurrentBorrowed);
            Controls.Add(table_DeviceBorrowing);
            Controls.Add(table_MemberStats);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(btn_Filter);
            Controls.Add(dateTimePickerEnd);
            Controls.Add(dateTimePickerStart);
            Name = "FormStatistical";
            Text = "Thống kê";
            Load += FormStatistical_Load;
            ((System.ComponentModel.ISupportInitialize)table_MemberStats).EndInit();
            ((System.ComponentModel.ISupportInitialize)table_DeviceBorrowing).EndInit();
            ((System.ComponentModel.ISupportInitialize)table_CurrentBorrowed).EndInit();
            ((System.ComponentModel.ISupportInitialize)table_Violations).EndInit();
            ((System.ComponentModel.ISupportInitialize)table_ActiveMembers).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        private System.Windows.Forms.DateTimePicker dateTimePickerStart;
        private System.Windows.Forms.DateTimePicker dateTimePickerEnd;
        private System.Windows.Forms.Button btn_Filter;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.DataGridView table_MemberStats;
        private System.Windows.Forms.DataGridView table_DeviceBorrowing;
        private System.Windows.Forms.DataGridView table_CurrentBorrowed;
        private System.Windows.Forms.DataGridView table_Violations;
        private System.Windows.Forms.DataGridView table_ActiveMembers;
        private System.Windows.Forms.Label lbl_TotalCompensation;
    }
}