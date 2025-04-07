namespace qltv.GUI.UI_For_Admin
{
    partial class FormBorrowedDevices
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
            textBox1 = new TextBox();
            table_BDL = new DataGridView();
            ((System.ComponentModel.ISupportInitialize)table_BDL).BeginInit();
            SuspendLayout();
            // 
            // textBox1
            // 
            textBox1.BackColor = Color.White;
            textBox1.Font = new Font("Segoe UI", 24F, FontStyle.Bold, GraphicsUnit.Point, 0);
            textBox1.Location = new Point(12, 12);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(466, 61);
            textBox1.TabIndex = 0;
            textBox1.Text = " Xử lý mượn thiết bị";
            // 
            // table_BDL
            // 
            table_BDL.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            table_BDL.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            table_BDL.BackgroundColor = Color.White;
            table_BDL.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            table_BDL.Location = new Point(12, 117);
            table_BDL.Name = "table_BDL";
            table_BDL.RowHeadersWidth = 51;
            table_BDL.Size = new Size(981, 457);
            table_BDL.TabIndex = 1;
            // 
            // FormBorrewedDevices
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(1005, 600);
            Controls.Add(table_BDL);
            Controls.Add(textBox1);
            Name = "FormBorrewedDevices";
            Text = "BorrewedDevices";
            Load += FormBorrewedDevices_Load;
            ((System.ComponentModel.ISupportInitialize)table_BDL).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox textBox1;
        private DataGridView table_BDL;
    }
}