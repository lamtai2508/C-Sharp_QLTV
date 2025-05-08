namespace qltv_Winform.GUI.UI_For_Admin
{
    partial class FormLearnSpace
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
            label1 = new Label();
            btCheckin = new Button();
            btCheckout = new Button();
            member_idtb = new TextBox();
            presentmember_table = new DataGridView();
            btCheck = new Button();
            label2 = new Label();
            ((System.ComponentModel.ISupportInitialize)presentmember_table).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(14, 12);
            label1.Name = "label1";
            label1.Size = new Size(186, 41);
            label1.TabIndex = 0;
            label1.Text = "Khu học tập";
            // 
            // btCheckin
            // 
            btCheckin.BackColor = Color.LawnGreen;
            btCheckin.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btCheckin.Location = new Point(728, 97);
            btCheckin.Margin = new Padding(3, 4, 3, 4);
            btCheckin.Name = "btCheckin";
            btCheckin.Size = new Size(181, 97);
            btCheckin.TabIndex = 1;
            btCheckin.Text = "Check in";
            btCheckin.UseVisualStyleBackColor = false;
            btCheckin.Click += btCheckin_Click;
            // 
            // btCheckout
            // 
            btCheckout.BackColor = SystemColors.ActiveCaption;
            btCheckout.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btCheckout.Location = new Point(915, 102);
            btCheckout.Margin = new Padding(3, 4, 3, 4);
            btCheckout.Name = "btCheckout";
            btCheckout.Size = new Size(163, 65);
            btCheckout.TabIndex = 2;
            btCheckout.Text = "Check out";
            btCheckout.UseVisualStyleBackColor = false;
            btCheckout.Click += btCheckout_Click;
            // 
            // member_idtb
            // 
            member_idtb.AcceptsTab = true;
            member_idtb.BorderStyle = BorderStyle.FixedSingle;
            member_idtb.Location = new Point(328, 120);
            member_idtb.Margin = new Padding(3, 4, 3, 4);
            member_idtb.Name = "member_idtb";
            member_idtb.Size = new Size(162, 27);
            member_idtb.TabIndex = 3;
            // 
            // presentmember_table
            // 
            presentmember_table.AllowUserToAddRows = false;
            presentmember_table.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            presentmember_table.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            presentmember_table.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
            presentmember_table.BackgroundColor = SystemColors.Window;
            presentmember_table.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            presentmember_table.Location = new Point(14, 328);
            presentmember_table.Margin = new Padding(3, 4, 3, 4);
            presentmember_table.MultiSelect = false;
            presentmember_table.Name = "presentmember_table";
            presentmember_table.RowHeadersWidth = 51;
            presentmember_table.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            presentmember_table.Size = new Size(1309, 472);
            presentmember_table.TabIndex = 4;
            presentmember_table.SelectionChanged += presentmember_table_SelectionChanged;
            // 
            // btCheck
            // 
            btCheck.Location = new Point(496, 118);
            btCheck.Margin = new Padding(3, 4, 3, 4);
            btCheck.Name = "btCheck";
            btCheck.Size = new Size(159, 39);
            btCheck.TabIndex = 5;
            btCheck.Text = "Kiểm tra";
            btCheck.UseVisualStyleBackColor = true;
            btCheck.Click += btCheck_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BorderStyle = BorderStyle.FixedSingle;
            label2.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(145, 120);
            label2.Name = "label2";
            label2.Size = new Size(177, 30);
            label2.TabIndex = 6;
            label2.Text = "MÃ THÀNH VIÊN";
            // 
            // FormLearnSpace
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1336, 816);
            Controls.Add(label2);
            Controls.Add(btCheck);
            Controls.Add(presentmember_table);
            Controls.Add(member_idtb);
            Controls.Add(btCheckout);
            Controls.Add(btCheckin);
            Controls.Add(label1);
            Margin = new Padding(3, 4, 3, 4);
            Name = "FormLearnSpace";
            Text = "FormLearnSpace";
            Load += FormLearnSpace_Load;
            Click += FormLearnSpace_Click;
            ((System.ComponentModel.ISupportInitialize)presentmember_table).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Button btCheckin;
        private Button btCheckout;
        private TextBox member_idtb;
        private DataGridView presentmember_table;
        private Button btCheck;
        private Label label2;
    }
}