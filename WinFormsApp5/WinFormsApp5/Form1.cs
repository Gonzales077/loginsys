using Guna.UI2.WinForms;

namespace WinFormsApp5
{
    public partial class FormLog : Form
    {
        public FormLog()
        {
            InitializeComponent();
        }

        private void FormLog_Load(object sender, EventArgs e)
        {
            TxtPass.UseSystemPasswordChar = true;
        }

        private void CheckPass_CheckedChanged(object sender, EventArgs e)
        {
            if (CheckPass.Checked)
            {
                TxtPass.UseSystemPasswordChar = false;
                TxtPass.PasswordChar = '\0';
            }
            else
            {
                TxtPass.UseSystemPasswordChar = true;
            }
        }

        private void BtnLogin_Click(object sender, EventArgs e)
        {
            if (TxtUser.Text == "admin" && TxtPass.Text == "0000")
            {
                Home homePage = new Home();
                homePage.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Incorrect username or password.");
            }
        }
    }
}
