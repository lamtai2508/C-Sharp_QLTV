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
            this.dateTimePickerStart = new System.Windows.Forms.DateTimePicker();
            this.dateTimePickerEnd = new System.Windows.Forms.DateTimePicker();
            this.btn_Filter = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.table_MemberStats = new System.Windows.Forms.DataGridView();
            this.table_DeviceBorrowing = new System.Windows.Forms.DataGridView();
            this.table_CurrentBorrowed = new System.Windows.Forms.DataGridView();
            this.table_Violations = new System.Windows.Forms.DataGridView();
            this.lbl_TotalCompensation = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.table_MemberStats)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.table_DeviceBorrowing)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.table_CurrentBorrowed)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.table_Violations)).BeginInit();
            this.SuspendLayout();
            // 
            // dateTimePickerStart
            // 
            this.dateTimePickerStart.Location = new System.Drawing.Point(50, 20);
            this.dateTimePickerStart.Name = "dateTimePickerStart";
            this.dateTimePickerStart.Size = new System.Drawing.Size(200, 27);
            this.dateTimePickerStart.TabIndex = 0;
            // 
            // dateTimePickerEnd
            // 
            this.dateTimePickerEnd.Location = new System.Drawing.Point(300, 20);
            this.dateTimePickerEnd.Name = "dateTimePickerEnd";
            this.dateTimePickerEnd.Size = new System.Drawing.Size(200, 27);
            this.dateTimePickerEnd.TabIndex = 1;
            // 
            // btn_Filter
            // 
            this.btn_Filter.Location = new System.Drawing.Point(550, 20);
            this.btn_Filter.Name = "btn_Filter";
            this.btn_Filter.Size = new System.Drawing.Size(100, 30);
            this.btn_Filter.TabIndex = 2;
            this.btn_Filter.Text = "Lọc";
            this.btn_Filter.UseVisualStyleBackColor = true;
            this.btn_Filter.Click += new System.EventHandler(this.btn_Filter_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.label1.Location = new System.Drawing.Point(50, 70);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(250, 28);
            this.label1.TabIndex = 3;
            this.label1.Text = "Số lượng thành viên";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.label2.Location = new System.Drawing.Point(50, 250);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(250, 28);
            this.label2.TabIndex = 4;
            this.label2.Text = "Thiết bị được mượn";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.label3.Location = new System.Drawing.Point(50, 430);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(250, 28);
            this.label3.TabIndex = 5;
            this.label3.Text = "Thiết bị đang được mượn";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.label4.Location = new System.Drawing.Point(50, 610);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(250, 28);
            this.label4.TabIndex = 6;
            this.label4.Text = "Xử lý vi phạm";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular);
            this.label5.Location = new System.Drawing.Point(50, 650);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(150, 23);
            this.label5.TabIndex = 7;
            this.label5.Text = "Tổng tiền bồi thường:";
            // 
            // table_MemberStats
            // 
            this.table_MemberStats.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.table_MemberStats.Location = new System.Drawing.Point(50, 110);
            this.table_MemberStats.Name = "table_MemberStats";
            this.table_MemberStats.Size = new System.Drawing.Size(900, 120);
            this.table_MemberStats.TabIndex = 8;
            // 
            // table_DeviceBorrowing
            // 
            this.table_DeviceBorrowing.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.table_DeviceBorrowing.Location = new System.Drawing.Point(50, 290);
            this.table_DeviceBorrowing.Name = "table_DeviceBorrowing";
            this.table_DeviceBorrowing.Size = new System.Drawing.Size(900, 120);
            this.table_DeviceBorrowing.TabIndex = 9;
            // 
            // table_CurrentBorrowed
            // 
            this.table_CurrentBorrowed.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.table_CurrentBorrowed.Location = new System.Drawing.Point(50, 470);
            this.table_CurrentBorrowed.Name = "table_CurrentBorrowed";
            this.table_CurrentBorrowed.Size = new System.Drawing.Size(900, 120);
            this.table_CurrentBorrowed.TabIndex = 10;
            // 
            // table_Violations
            // 
            this.table_Violations.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.table_Violations.Location = new System.Drawing.Point(50, 680);
            this.table_Violations.Name = "table_Violations";
            this.table_Violations.Size = new System.Drawing.Size(900, 120);
            this.table_Violations.TabIndex = 11;
            // 
            // lbl_TotalCompensation
            // 
            this.lbl_TotalCompensation.AutoSize = true;
            this.lbl_TotalCompensation.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.lbl_TotalCompensation.Location = new System.Drawing.Point(200, 650);
            this.lbl_TotalCompensation.Name = "lbl_TotalCompensation";
            this.lbl_TotalCompensation.Size = new System.Drawing.Size(200, 23);
            this.lbl_TotalCompensation.TabIndex = 12;
            this.lbl_TotalCompensation.Text = "Tổng tiền bồi thường: 0";
            // 
            // FormStatistical
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1000, 850);
            this.Controls.Add(this.lbl_TotalCompensation);
            this.Controls.Add(this.table_Violations);
            this.Controls.Add(this.table_CurrentBorrowed);
            this.Controls.Add(this.table_DeviceBorrowing);
            this.Controls.Add(this.table_MemberStats);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btn_Filter);
            this.Controls.Add(this.dateTimePickerEnd);
            this.Controls.Add(this.dateTimePickerStart);
            this.Name = "FormStatistical";
            this.Text = "Thống kê";
            this.Load += new System.EventHandler(this.FormStatistical_Load);
            ((System.ComponentModel.ISupportInitialize)(this.table_MemberStats)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.table_DeviceBorrowing)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.table_CurrentBorrowed)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.table_Violations)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        private System.Windows.Forms.DateTimePicker dateTimePickerStart;
        private System.Windows.Forms.DateTimePicker dateTimePickerEnd;
        private System.Windows.Forms.Button btn_Filter;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.DataGridView table_MemberStats;
        private System.Windows.Forms.DataGridView table_DeviceBorrowing;
        private System.Windows.Forms.DataGridView table_CurrentBorrowed;
        private System.Windows.Forms.DataGridView table_Violations;
        private System.Windows.Forms.Label lbl_TotalCompensation;
    }
}