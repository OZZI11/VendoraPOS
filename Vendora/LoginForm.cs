

namespace Vendora
{
    public partial class LoginForm : Form
    {
        public LoginForm()
        {
            InitializeComponent();

        }

        private void Form1_Load(object sender, EventArgs e)
        {


        }

        private void materialButton1_Click(object sender, EventArgs e)
        {
            AdminForm Admin = new AdminForm();
            this.Hide();
            Admin.Show();
        }

        private void materialButton1_Click_1(object sender, EventArgs e)
        {
            AdminForm adminForm = new AdminForm();
            adminForm.Show();
        }
    }
}
