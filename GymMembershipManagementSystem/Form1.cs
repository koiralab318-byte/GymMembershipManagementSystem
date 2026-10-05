namespace GymMembershipManagementSystem
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnAddMember_Click(object sender, EventArgs e)
        {
            using AddMemberForm form = new AddMemberForm();
            form.ShowDialog();
        }

        private void btnViewMembers_Click(object sender, EventArgs e)
        {
            using ViewMembersForm form = new ViewMembersForm();
            form.ShowDialog();
        }
    }
}
