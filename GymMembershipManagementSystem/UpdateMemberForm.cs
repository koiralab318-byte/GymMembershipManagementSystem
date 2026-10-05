using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using Microsoft.Data.Sqlite;



namespace GymMembershipManagementSystem
{
    public partial class lblPlanCaption : Form
    {
        private int memberID;

        public lblPlanCaption(int memberID)
        {
            InitializeComponent();

            this.memberID = memberID;

            LoadMemberDetails();
        }

        private void LoadMemberDetails()
        {
            DataRow? row = DatabaseHelper.GetMemberById(memberID);

            if (row == null)
            {
                MessageBox.Show("Member not found.");
                Close();
                return;
            }

            txtUpdateName.Text = row["Name"].ToString();
            txtUpdatePhone.Text = row["Phone"].ToString();
            txtUpdateEmail.Text = row["Email"].ToString();

            if (DateTime.TryParse(
                row["JoinDate"].ToString(),
                out DateTime joinDate))
            {
                dtpEditJoinDate.Value = joinDate;
            }

            cboUpdateMembershipType.Text =
                row["MembershipType"].ToString();

            if (DateTime.TryParse(
                row["StartDate"].ToString(),
                out DateTime startDate))
            {
                dtpEditStartDate.Value = startDate;
            }

            if (DateTime.TryParse(
                row["ExpiryDate"].ToString(),
                out DateTime expiryDate))
            {
                lblUpdateExpiryDate.Text =
                    expiryDate.ToString("dd/MM/yyyy");
            }

            if (decimal.TryParse(
                row["Fee"].ToString(),
                out decimal fee))
            {
                numUpdateFee.Value = fee;
            }

            cboUpdatePaymentStatus.Text =
                row["PaymentStatus"].ToString();
        }

        private void UpdateMemberForm_Load(
            object sender,
            EventArgs e)
        {
        }
        private DateTime CalculateExpiryDate()
        {
            DateTime startDate = dtpEditStartDate.Value.Date;

            switch (cboUpdateMembershipType.Text)
            {
                case "Monthly Membership":
                    return startDate.AddMonths(1);

                case "Three-Month Membership":
                    return startDate.AddMonths(3);

                case "Six-Month Membership":
                    return startDate.AddMonths(6);

                case "Annual Membership":
                    return startDate.AddYears(1);

                default:
                    return startDate;
            }
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtUpdateName.Text))
            {
                MessageBox.Show("Please enter the member name.");
                return;
            }

            if (cboUpdateMembershipType.SelectedIndex == -1)
            {
                MessageBox.Show("Please select a membership plan.");
                return;
            }

            if (cboUpdatePaymentStatus.SelectedIndex == -1)
            {
                MessageBox.Show("Please select payment status.");
                return;
            }

            DateTime expiryDate = CalculateExpiryDate();

            Member member = new Member()
            {
                Name = txtUpdateName.Text.Trim(),
                Phone = txtUpdatePhone.Text.Trim(),
                Email = txtUpdateEmail.Text.Trim(),
                JoinDate = dtpEditJoinDate.Value.Date
            };

            Membership membership = new Membership()
            {
                MembershipType = cboUpdateMembershipType.Text,
                StartDate = dtpEditStartDate.Value.Date,
                ExpiryDate = expiryDate,
                Fee = numUpdateFee.Value,
                PaymentStatus = cboUpdatePaymentStatus.Text,
                MembershipStatus =
                    expiryDate >= DateTime.Today
                    ? "Active"
                    : "Expired"
            };

            try
            {
                DatabaseHelper.UpdateMember(
                    memberID,
                    member,
                    membership);

                MessageBox.Show(
                    "Member updated successfully!",
                    "Success",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Information);

                Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(
                    "Error updating member: " + ex.Message);
            }
        }

      
        
    }
}