namespace GymMembershipManagementSystem
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            lblTitle = new Label();
            btnAddMember = new Button();
            btnViewMembers = new Button();
            btnExit = new Button();
            SuspendLayout();
            // 
            // lblTitle
            // 
            lblTitle.AutoSize = true;
            lblTitle.Location = new Point(302, 63);
            lblTitle.Name = "lblTitle";
            lblTitle.Size = new Size(269, 20);
            lblTitle.TabIndex = 0;
            lblTitle.Text = "Gym Membership Management System";
            lblTitle.Click += label1_Click;
            // 
            // btnAddMember
            // 
            btnAddMember.Location = new Point(329, 126);
            btnAddMember.Name = "btnAddMember";
            btnAddMember.Size = new Size(150, 35);
            btnAddMember.TabIndex = 1;
            btnAddMember.Text = "Add Member";
            btnAddMember.UseVisualStyleBackColor = true;
            // 
            // btnViewMembers
            // 
            btnViewMembers.Location = new Point(329, 182);
            btnViewMembers.Name = "btnViewMembers";
            btnViewMembers.Size = new Size(150, 30);
            btnViewMembers.TabIndex = 2;
            btnViewMembers.Text = "View Members";
            btnViewMembers.UseVisualStyleBackColor = true;
            // 
            // btnExit
            // 
            btnExit.Location = new Point(329, 239);
            btnExit.Name = "btnExit";
            btnExit.Size = new Size(150, 32);
            btnExit.TabIndex = 3;
            btnExit.Text = "Exit";
            btnExit.UseVisualStyleBackColor = true;
            btnExit.Click += btnExit_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btnExit);
            Controls.Add(btnViewMembers);
            Controls.Add(btnAddMember);
            Controls.Add(lblTitle);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblTitle;
        private Button btnAddMember;
        private Button btnViewMembers;
        private Button btnExit;
    }
}
