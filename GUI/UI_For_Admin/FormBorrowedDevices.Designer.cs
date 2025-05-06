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
            btnAccept = new Button();
            btnReject = new Button();
            btnRefresh = new Button();
            lblStatus = new Label();
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
            textBox1.Text = " Xử lý đặt chỗ thiết bị";
            textBox1.TextChanged += textBox1_TextChanged;
            // 
            // table_BDL
            // 
            table_BDL.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            table_BDL.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            table_BDL.BackgroundColor = Color.White;
            table_BDL.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            table_BDL.Location = new Point(12, 150);
            table_BDL.Name = "table_BDL";
            table_BDL.RowHeadersWidth = 51;
            table_BDL.Size = new Size(981, 425);
            table_BDL.TabIndex = 1;
            // 
            // btnAccept
            // 
            btnAccept.Location = new Point(0, 0);
            btnAccept.Name = "btnAccept";
            btnAccept.Size = new Size(75, 23);
            btnAccept.TabIndex = 0;
            // 
            // btnReject
            // 
            btnReject.Location = new Point(0, 0);
            btnReject.Name = "btnReject";
            btnReject.Size = new Size(75, 23);
            btnReject.TabIndex = 0;
            // 
            // btnRefresh
            // 
            btnRefresh.Location = new Point(0, 0);
            btnRefresh.Name = "btnRefresh";
            btnRefresh.Size = new Size(75, 23);
            btnRefresh.TabIndex = 0;
            // 
            // lblStatus
            // 
            lblStatus.Location = new Point(0, 0);
            lblStatus.Name = "lblStatus";
            lblStatus.Size = new Size(100, 23);
            lblStatus.TabIndex = 0;
            // 
            // FormBorrowedDevices
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(1005, 600);
            Controls.Add(table_BDL);
            Controls.Add(textBox1);
            Name = "FormBorrowedDevices";
            Text = "BorrewedDevices";
            Load += FormBorrewedDevices_Load;
            ((System.ComponentModel.ISupportInitialize)table_BDL).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox textBox1;
        private DataGridView table_BDL;
        private Button btnAccept;
        private Button btnReject;
        private Button btnRefresh;
        private Label lblStatus;
    }
}