namespace GymMembershipManagementSystem
{
    partial class ViewMembersForm
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
            txtSearch = new TextBox();
            btnSearch = new Button();
            btnRefresh = new Button();
            dgvMembers = new DataGridView();
            btnClose = new Button();
            btnUpdate = new Button();
            btnDelete = new Button();
            ((System.ComponentModel.ISupportInitialize)dgvMembers).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.Location = new Point(134, 49);
            label1.Name = "label1";
            label1.Size = new Size(158, 28);
            label1.TabIndex = 0;
            label1.Text = "Search Member :";
            // 
            // txtSearch
            // 
            txtSearch.Location = new Point(330, 50);
            txtSearch.Name = "txtSearch";
            txtSearch.Size = new Size(179, 27);
            txtSearch.TabIndex = 1;
            // 
            // btnSearch
            // 
            btnSearch.Location = new Point(540, 52);
            btnSearch.Name = "btnSearch";
            btnSearch.Size = new Size(94, 29);
            btnSearch.TabIndex = 2;
            btnSearch.Text = "Search";
            btnSearch.UseVisualStyleBackColor = true;
            btnSearch.Click += btnSearch_Click;
            // 
            // btnRefresh
            // 
            btnRefresh.Location = new Point(654, 52);
            btnRefresh.Name = "btnRefresh";
            btnRefresh.Size = new Size(94, 29);
            btnRefresh.TabIndex = 3;
            btnRefresh.Text = "Refresh";
            btnRefresh.UseVisualStyleBackColor = true;
            btnRefresh.Click += btnRefresh_Click;
            // 
            // dgvMembers
            // 
            dgvMembers.AllowUserToAddRows = false;
            dgvMembers.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvMembers.BackgroundColor = SystemColors.ButtonHighlight;
            dgvMembers.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvMembers.Location = new Point(38, 107);
            dgvMembers.Name = "dgvMembers";
            dgvMembers.ReadOnly = true;
            dgvMembers.RowHeadersWidth = 51;
            dgvMembers.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvMembers.Size = new Size(1119, 223);
            dgvMembers.TabIndex = 4;
            // 
            // btnClose
            // 
            btnClose.AccessibleRole = AccessibleRole.SplitButton;
            btnClose.Location = new Point(699, 370);
            btnClose.Name = "btnClose";
            btnClose.Size = new Size(105, 31);
            btnClose.TabIndex = 5;
            btnClose.Text = "Close";
            btnClose.UseVisualStyleBackColor = true;
            btnClose.Click += btnClose_Click;
            // 
            // btnUpdate
            // 
            btnUpdate.Location = new Point(243, 364);
            btnUpdate.Name = "btnUpdate";
            btnUpdate.Size = new Size(173, 42);
            btnUpdate.TabIndex = 6;
            btnUpdate.Text = "Update Member";
            btnUpdate.UseVisualStyleBackColor = true;
            btnUpdate.Click += btnUpdate_Click;
            // 
            // btnDelete
            // 
            btnDelete.Location = new Point(483, 364);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(151, 42);
            btnDelete.TabIndex = 7;
            btnDelete.Text = "Delete Member";
            btnDelete.UseVisualStyleBackColor = true;
            btnDelete.Click += btnDelete_Click;
            // 
            // ViewMembersForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1169, 450);
            Controls.Add(btnDelete);
            Controls.Add(btnUpdate);
            Controls.Add(btnClose);
            Controls.Add(dgvMembers);
            Controls.Add(btnRefresh);
            Controls.Add(btnSearch);
            Controls.Add(txtSearch);
            Controls.Add(label1);
            Name = "ViewMembersForm";
            Text = "ViewMembersForm";
            ((System.ComponentModel.ISupportInitialize)dgvMembers).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox txtSearch;
        private Button btnSearch;
        private Button btnRefresh;
        private DataGridView dgvMembers;
        private Button btnClose;
        private Button btnUpdate;
        private Button btnDelete;
    }
}