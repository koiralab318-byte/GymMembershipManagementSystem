namespace GymMembershipManagementSystem
{
    partial class lblPlanCaption
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
            lblNameCaption = new Label();
            lblPhoneCaption = new Label();
            lblEmailCaption = new Label();
            dtpJoinDate = new Label();
            cboMembershipType = new Label();
            dtpStartDate = new Label();
            lblExpiryDate = new Label();
            numFee = new Label();
            lblPaymentCaption = new Label();
            btnUpdate = new Button();
            btnCancel = new Button();
            txtUpdateName = new TextBox();
            txtUpdatePhone = new TextBox();
            txtUpdateEmail = new TextBox();
            dtpEditJoinDate = new DateTimePicker();
            cboUpdateMembershipType = new ComboBox();
            dtpEditStartDate = new DateTimePicker();
            lblUpdateExpiryDate = new Label();
            numUpdateFee = new NumericUpDown();
            cboUpdatePaymentStatus = new ComboBox();
            ((System.ComponentModel.ISupportInitialize)numUpdateFee).BeginInit();
            SuspendLayout();
            // 
            // lblNameCaption
            // 
            lblNameCaption.AutoSize = true;
            lblNameCaption.Location = new Point(93, 56);
            lblNameCaption.Name = "lblNameCaption";
            lblNameCaption.Size = new Size(109, 20);
            lblNameCaption.TabIndex = 0;
            lblNameCaption.Text = "Member Name";
            // 
            // lblPhoneCaption
            // 
            lblPhoneCaption.AutoSize = true;
            lblPhoneCaption.Location = new Point(99, 95);
            lblPhoneCaption.Name = "lblPhoneCaption";
            lblPhoneCaption.Size = new Size(50, 20);
            lblPhoneCaption.TabIndex = 1;
            lblPhoneCaption.Text = "Phone";
            // 
            // lblEmailCaption
            // 
            lblEmailCaption.AutoSize = true;
            lblEmailCaption.Location = new Point(99, 128);
            lblEmailCaption.Name = "lblEmailCaption";
            lblEmailCaption.Size = new Size(46, 20);
            lblEmailCaption.TabIndex = 2;
            lblEmailCaption.Text = "Email";
            // 
            // dtpJoinDate
            // 
            dtpJoinDate.AutoSize = true;
            dtpJoinDate.Location = new Point(99, 170);
            dtpJoinDate.Name = "dtpJoinDate";
            dtpJoinDate.Size = new Size(71, 20);
            dtpJoinDate.TabIndex = 3;
            dtpJoinDate.Text = "Join Date";
            // 
            // cboMembershipType
            // 
            cboMembershipType.AutoSize = true;
            cboMembershipType.Location = new Point(99, 213);
            cboMembershipType.Name = "cboMembershipType";
            cboMembershipType.Size = new Size(128, 20);
            cboMembershipType.TabIndex = 4;
            cboMembershipType.Text = "Membership Plan ";
            // 
            // dtpStartDate
            // 
            dtpStartDate.AutoSize = true;
            dtpStartDate.Location = new Point(99, 251);
            dtpStartDate.Name = "dtpStartDate";
            dtpStartDate.Size = new Size(76, 20);
            dtpStartDate.TabIndex = 5;
            dtpStartDate.Text = "Start Date";
            // 
            // lblExpiryDate
            // 
            lblExpiryDate.AutoSize = true;
            lblExpiryDate.Location = new Point(99, 288);
            lblExpiryDate.Name = "lblExpiryDate";
            lblExpiryDate.Size = new Size(85, 20);
            lblExpiryDate.TabIndex = 6;
            lblExpiryDate.Text = "Expiry Date";
            // 
            // numFee
            // 
            numFee.AutoSize = true;
            numFee.Location = new Point(99, 319);
            numFee.Name = "numFee";
            numFee.Size = new Size(123, 20);
            numFee.TabIndex = 7;
            numFee.Text = "Membership Fee ";
            // 
            // lblPaymentCaption
            // 
            lblPaymentCaption.AutoSize = true;
            lblPaymentCaption.Location = new Point(99, 359);
            lblPaymentCaption.Name = "lblPaymentCaption";
            lblPaymentCaption.Size = new Size(109, 20);
            lblPaymentCaption.TabIndex = 8;
            lblPaymentCaption.Text = "Payment Status";
            // 
            // btnUpdate
            // 
            btnUpdate.Location = new Point(133, 413);
            btnUpdate.Name = "btnUpdate";
            btnUpdate.Size = new Size(94, 29);
            btnUpdate.TabIndex = 9;
            btnUpdate.Text = "Update ";
            btnUpdate.UseVisualStyleBackColor = true;
            btnUpdate.Click += btnUpdate_Click;
            // 
            // btnCancel
            // 
            btnCancel.Location = new Point(271, 413);
            btnCancel.Name = "btnCancel";
            btnCancel.Size = new Size(94, 29);
            btnCancel.TabIndex = 10;
            btnCancel.Text = "Cancel";
            btnCancel.UseVisualStyleBackColor = true;
            // 
            // txtUpdateName
            // 
            txtUpdateName.Location = new Point(240, 53);
            txtUpdateName.Name = "txtUpdateName";
            txtUpdateName.Size = new Size(125, 27);
            txtUpdateName.TabIndex = 11;
            // 
            // txtUpdatePhone
            // 
            txtUpdatePhone.Location = new Point(240, 92);
            txtUpdatePhone.Name = "txtUpdatePhone";
            txtUpdatePhone.Size = new Size(125, 27);
            txtUpdatePhone.TabIndex = 12;
            // 
            // txtUpdateEmail
            // 
            txtUpdateEmail.Location = new Point(240, 128);
            txtUpdateEmail.Name = "txtUpdateEmail";
            txtUpdateEmail.Size = new Size(125, 27);
            txtUpdateEmail.TabIndex = 13;
            // 
            // dtpEditJoinDate
            // 
            dtpEditJoinDate.Location = new Point(240, 165);
            dtpEditJoinDate.Name = "dtpEditJoinDate";
            dtpEditJoinDate.Size = new Size(250, 27);
            dtpEditJoinDate.TabIndex = 14;
            // 
            // cboUpdateMembershipType
            // 
            cboUpdateMembershipType.FormattingEnabled = true;
            cboUpdateMembershipType.Items.AddRange(new object[] { "Monthly Membership", "Three-Month Membership", "Six-Month Membership", "Annual Membership" });
            cboUpdateMembershipType.Location = new Point(240, 213);
            cboUpdateMembershipType.Name = "cboUpdateMembershipType";
            cboUpdateMembershipType.Size = new Size(151, 28);
            cboUpdateMembershipType.TabIndex = 15;
            // 
            // dtpEditStartDate
            // 
            dtpEditStartDate.Location = new Point(240, 251);
            dtpEditStartDate.Name = "dtpEditStartDate";
            dtpEditStartDate.Size = new Size(250, 27);
            dtpEditStartDate.TabIndex = 16;
            // 
            // lblUpdateExpiryDate
            // 
            lblUpdateExpiryDate.AutoSize = true;
            lblUpdateExpiryDate.Location = new Point(254, 288);
            lblUpdateExpiryDate.Name = "lblUpdateExpiryDate";
            lblUpdateExpiryDate.Size = new Size(15, 20);
            lblUpdateExpiryDate.TabIndex = 17;
            lblUpdateExpiryDate.Text = "-";
            // 
            // numUpdateFee
            // 
            numUpdateFee.Location = new Point(241, 317);
            numUpdateFee.Name = "numUpdateFee";
            numUpdateFee.Size = new Size(150, 27);
            numUpdateFee.TabIndex = 18;
            // 
            // cboUpdatePaymentStatus
            // 
            cboUpdatePaymentStatus.FormattingEnabled = true;
            cboUpdatePaymentStatus.Items.AddRange(new object[] { "Paid", "Partially Paid", "Unpaid" });
            cboUpdatePaymentStatus.Location = new Point(240, 356);
            cboUpdatePaymentStatus.Name = "cboUpdatePaymentStatus";
            cboUpdatePaymentStatus.Size = new Size(151, 28);
            cboUpdatePaymentStatus.TabIndex = 19;
            // 
            // lblPlanCaption
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(825, 480);
            Controls.Add(cboUpdatePaymentStatus);
            Controls.Add(numUpdateFee);
            Controls.Add(lblUpdateExpiryDate);
            Controls.Add(dtpEditStartDate);
            Controls.Add(cboUpdateMembershipType);
            Controls.Add(dtpEditJoinDate);
            Controls.Add(txtUpdateEmail);
            Controls.Add(txtUpdatePhone);
            Controls.Add(txtUpdateName);
            Controls.Add(btnCancel);
            Controls.Add(btnUpdate);
            Controls.Add(lblPaymentCaption);
            Controls.Add(numFee);
            Controls.Add(lblExpiryDate);
            Controls.Add(dtpStartDate);
            Controls.Add(cboMembershipType);
            Controls.Add(dtpJoinDate);
            Controls.Add(lblEmailCaption);
            Controls.Add(lblPhoneCaption);
            Controls.Add(lblNameCaption);
            Name = "lblPlanCaption";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Membership Plan";
            Load += UpdateMemberForm_Load;
            ((System.ComponentModel.ISupportInitialize)numUpdateFee).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblNameCaption;
        private Label lblPhoneCaption;
        private Label lblEmailCaption;
        private Label dtpJoinDate;
        private Label cboMembershipType;
        private Label dtpStartDate;
        private Label lblExpiryDate;
        private Label numFee;
        private Label lblPaymentCaption;
        private Button btnUpdate;
        private Button btnCancel;
        private TextBox txtUpdateName;
        private TextBox txtUpdatePhone;
        private TextBox txtUpdateEmail;
        private DateTimePicker dtpEditJoinDate;
        private ComboBox cboUpdateMembershipType;
        private DateTimePicker dtpEditStartDate;
        private Label lblUpdateExpiryDate;
        private NumericUpDown numUpdateFee;
        private ComboBox cboUpdatePaymentStatus;
    }
}