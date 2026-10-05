namespace GymMembershipManagementSystem
{
    partial class AddMemberForm
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
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            label7 = new Label();
            txtName = new TextBox();
            txtEmail = new TextBox();
            txtPhone = new TextBox();
            dtpJoinDate = new DateTimePicker();
            cboMembershipType = new ComboBox();
            dtpStartDate = new DateTimePicker();
            lblExpiryDate = new Label();
            label8 = new Label();
            numFee = new NumericUpDown();
            label9 = new Label();
            cboPaymentStatus = new ComboBox();
            btnSave = new Button();
            btnClear = new Button();
            ((System.ComponentModel.ISupportInitialize)numFee).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(64, 40);
            label1.Name = "label1";
            label1.Size = new Size(109, 20);
            label1.TabIndex = 0;
            label1.Text = "Member Name";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(64, 78);
            label2.Name = "label2";
            label2.Size = new Size(50, 20);
            label2.TabIndex = 1;
            label2.Text = "Phone";
            label2.Click += label2_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(64, 115);
            label3.Name = "label3";
            label3.Size = new Size(46, 20);
            label3.TabIndex = 2;
            label3.Text = "Email";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(64, 158);
            label4.Name = "label4";
            label4.Size = new Size(71, 20);
            label4.TabIndex = 3;
            label4.Text = "Join Date";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(64, 203);
            label5.Name = "label5";
            label5.Size = new Size(124, 20);
            label5.TabIndex = 4;
            label5.Text = "Membership Plan";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(64, 246);
            label6.Name = "label6";
            label6.RightToLeft = RightToLeft.No;
            label6.Size = new Size(76, 20);
            label6.TabIndex = 5;
            label6.Text = "Start Date";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(64, 286);
            label7.Name = "label7";
            label7.Size = new Size(85, 20);
            label7.TabIndex = 6;
            label7.Text = "Expiry Date";
            // 
            // txtName
            // 
            txtName.Location = new Point(255, 37);
            txtName.Name = "txtName";
            txtName.Size = new Size(125, 27);
            txtName.TabIndex = 7;
            // 
            // txtEmail
            // 
            txtEmail.Location = new Point(255, 112);
            txtEmail.Name = "txtEmail";
            txtEmail.Size = new Size(125, 27);
            txtEmail.TabIndex = 8;
            // 
            // txtPhone
            // 
            txtPhone.Location = new Point(255, 79);
            txtPhone.Name = "txtPhone";
            txtPhone.Size = new Size(125, 27);
            txtPhone.TabIndex = 9;
            // 
            // dtpJoinDate
            // 
            dtpJoinDate.Location = new Point(255, 158);
            dtpJoinDate.Name = "dtpJoinDate";
            dtpJoinDate.Size = new Size(250, 27);
            dtpJoinDate.TabIndex = 10;
            dtpJoinDate.ValueChanged += dtpJoinDate_ValueChanged;
            // 
            // cboMembershipType
            // 
            cboMembershipType.DropDownStyle = ComboBoxStyle.DropDownList;
            cboMembershipType.FormattingEnabled = true;
            cboMembershipType.Items.AddRange(new object[] { "Monthly Membership", "Three-Month Membership", "Six-Month Membership", "Annual Membership" });
            cboMembershipType.Location = new Point(255, 203);
            cboMembershipType.Name = "cboMembershipType";
            cboMembershipType.Size = new Size(151, 28);
            cboMembershipType.TabIndex = 11;
            cboMembershipType.SelectedIndexChanged += cboMembershipType_SelectedIndexChanged;
            // 
            // dtpStartDate
            // 
            dtpStartDate.Location = new Point(255, 246);
            dtpStartDate.Name = "dtpStartDate";
            dtpStartDate.Size = new Size(250, 27);
            dtpStartDate.TabIndex = 12;
            // 
            // lblExpiryDate
            // 
            lblExpiryDate.AutoSize = true;
            lblExpiryDate.Location = new Point(269, 297);
            lblExpiryDate.Name = "lblExpiryDate";
            lblExpiryDate.Size = new Size(15, 20);
            lblExpiryDate.TabIndex = 13;
            lblExpiryDate.Text = "-";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(64, 328);
            label8.Name = "label8";
            label8.Size = new Size(119, 20);
            label8.TabIndex = 14;
            label8.Text = "Membership Fee";
            // 
            // numFee
            // 
            numFee.Location = new Point(255, 328);
            numFee.Name = "numFee";
            numFee.Size = new Size(150, 27);
            numFee.TabIndex = 15;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(64, 384);
            label9.Name = "label9";
            label9.Size = new Size(109, 20);
            label9.TabIndex = 16;
            label9.Text = "Payment Status";
            // 
            // cboPaymentStatus
            // 
            cboPaymentStatus.DropDownStyle = ComboBoxStyle.DropDownList;
            cboPaymentStatus.FormattingEnabled = true;
            cboPaymentStatus.Items.AddRange(new object[] { "Paid", "Partially Paid", "Unpaid" });
            cboPaymentStatus.Location = new Point(255, 376);
            cboPaymentStatus.Name = "cboPaymentStatus";
            cboPaymentStatus.Size = new Size(151, 28);
            cboPaymentStatus.TabIndex = 17;
            // 
            // btnSave
            // 
            btnSave.Location = new Point(229, 446);
            btnSave.Name = "btnSave";
            btnSave.Size = new Size(94, 29);
            btnSave.TabIndex = 18;
            btnSave.Text = "Save";
            btnSave.UseVisualStyleBackColor = true;
            btnSave.Click += btnSave_Click;
            // 
            // btnClear
            // 
            btnClear.Location = new Point(378, 446);
            btnClear.Name = "btnClear";
            btnClear.Size = new Size(94, 29);
            btnClear.TabIndex = 19;
            btnClear.Text = "Clear";
            btnClear.UseVisualStyleBackColor = true;
            btnClear.Click += btnClear_Click;
            // 
            // AddMemberForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(862, 523);
            Controls.Add(btnClear);
            Controls.Add(btnSave);
            Controls.Add(cboPaymentStatus);
            Controls.Add(label9);
            Controls.Add(numFee);
            Controls.Add(label8);
            Controls.Add(lblExpiryDate);
            Controls.Add(dtpStartDate);
            Controls.Add(cboMembershipType);
            Controls.Add(dtpJoinDate);
            Controls.Add(txtPhone);
            Controls.Add(txtEmail);
            Controls.Add(txtName);
            Controls.Add(label7);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "AddMemberForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Add New Member";
            ((System.ComponentModel.ISupportInitialize)numFee).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
        private Label label7;
        private TextBox txtName;
        private TextBox txtEmail;
        private TextBox txtPhone;
        private DateTimePicker dtpJoinDate;
        private ComboBox cboMembershipType;
        private DateTimePicker dtpStartDate;
        private Label lblExpiryDate;
        private Label label8;
        private NumericUpDown numFee;
        private Label label9;
        private ComboBox cboPaymentStatus;
        private Button btnSave;
        private Button btnClear;
    }
}