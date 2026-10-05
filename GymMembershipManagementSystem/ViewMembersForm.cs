using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace GymMembershipManagementSystem
{
    public partial class ViewMembersForm : Form
    {
        public ViewMembersForm()
        {
            InitializeComponent();
        }
        private void LoadMembers(string search = "")
        {
            try
            {
                dgvMembers.DataSource =
                    DatabaseHelper.GetMembers(search);
            }
            catch (Exception ex)
            {
                MessageBox.Show(
                    "Error loading members: " + ex.Message);
            }
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            LoadMembers(txtSearch.Text.Trim());
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            txtSearch.Clear();
            LoadMembers();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (dgvMembers.SelectedRows.Count == 0)
            {
                MessageBox.Show(
                    "Please select a member to delete.",
                    "Delete Member",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);

                return;
            }

            int memberID =
                Convert.ToInt32(
                    dgvMembers.SelectedRows[0]
                        .Cells["MemberID"].Value);

            string memberName =
                dgvMembers.SelectedRows[0]
                    .Cells["Name"].Value.ToString() ?? "";

            DialogResult result = MessageBox.Show(
                $"Are you sure you want to delete {memberName}?",
                "Confirm Delete",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question);

            if (result == DialogResult.Yes)
            {
                try
                {
                    DatabaseHelper.DeleteMember(memberID);

                    MessageBox.Show(
                        "Member deleted successfully!",
                        "Success",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Information);

                    LoadMembers();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(
                        "Error deleting member: " + ex.Message);
                }
            }
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            if (dgvMembers.SelectedRows.Count == 0)
            {
                MessageBox.Show(
                    "Please select a member to update.",
                    "Update Member",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);

                return;
            }

            int memberID = Convert.ToInt32(
                dgvMembers.SelectedRows[0]
                .Cells["MemberID"].Value);

            using lblPlanCaption form =
                new lblPlanCaption(memberID);

            form.ShowDialog();

            LoadMembers();
        }
    }
}
