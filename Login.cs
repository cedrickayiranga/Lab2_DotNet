namespace Lab2
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        private void btnLogin_Click(object? sender, EventArgs e)
        {
            string username = txtUsername.Text.Trim();
            string password = txtPassword.Text.Trim();

            if (username == "" || password == "")
            {
                MessageBox.Show("Username and Password cannot be empty.", "Login");
            }
            else
            {
                ChooseForm chooseForm = new ChooseForm();
                chooseForm.Show();
                this.Hide();
            }
        }

        private void Login_FormClosed(object? sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }
    }
}
