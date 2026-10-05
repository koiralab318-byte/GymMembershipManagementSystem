using System;
using System.Windows.Forms;

namespace GymMembershipManagementSystem
{
    public partial class AddMemberForm : Form
    {
        public AddMemberForm()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {
        }

        private void dtpJoinDate_ValueChanged(object sender, EventArgs e)
        {
        }

        private DateTime CalculateExpiryDate()
        {
            DateTime startDate = dtpStartDate.Value.Date;

            switch (cboMembershipType.Text)
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

        private void UpdateExpiryDate()
        {
            DateTime expiryDate = CalculateExpiryDate();

            lblExpiryDate.Text =
                expiryDate.ToString("dd/MM/yyyy");
        }

        private void cboMembershipType_SelectedIndexChanged(object sender, EventArgs e)
        {
            UpdateExpiryDate();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtName.Text))
            {
                MessageBox.Show(
                    "Please enter the member name.",
                    "Validation",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);

                txtName.Focus();
                return;
            }

            if (cboMembershipType.SelectedIndex == -1)
            {
                MessageBox.Show(
                    "Please select a membership plan.",
                    "Validation",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);

                return;
            }

            if (cboPaymentStatus.SelectedIndex == -1)
            {
                MessageBox.Show(
                    "Please select payment status.",
                    "Validation",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);

                return;
            }

            DateTime expiryDate = CalculateExpiryDate();

            Member member = new Member()
            {
                Name = txtName.Text.Trim(),
                Phone = txtPhone.Text.Trim(),
                Email = txtEmail.Text.Trim(),
                JoinDate = dtpJoinDate.Value.Date
            };

            Membership membership = new Membership()
            {
                MembershipType = cboMembershipType.Text,
                StartDate = dtpStartDate.Value.Date,
                ExpiryDate = expiryDate,
                Fee = numFee.Value,
                PaymentStatus = cboPaymentStatus.Text,

                MembershipStatus =
                    expiryDate.Date >= DateTime.Today
                    ? "Active"
                    : "Expired"
            };

            try
            {
                DatabaseHelper.AddMember(member, membership);

                MessageBox.Show(
                    "Member saved successfully!",
                    "Success",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Information);

                ClearForm();
            }
            catch (Exception ex)
            {
                MessageBox.Show(
                    "Error saving member: " + ex.Message);
            }
        }
        private void ClearForm()
        {
            txtName.Clear();
            txtPhone.Clear();
            txtEmail.Clear();

            dtpJoinDate.Value = DateTime.Today;
            dtpStartDate.Value = DateTime.Today;

            cboMembershipType.SelectedIndex = -1;
            cboPaymentStatus.SelectedIndex = -1;

            numFee.Value = 0;

            lblExpiryDate.Text = "-";

            txtName.Focus();
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            ClearForm();
        }
    }
}