using SQLite;
namespace NPC_Manager_Management
{
    public partial class UserLogin : Form
    {
        public UserLogin()
        {
            InitializeComponent();
        }

        private void buttonSubmit_Click(object sender, EventArgs e)
        {
            string adminUsername = "Saxton";
            string adminPassword = "12345678";

            string username = LoginUsername.Text;
            string password = LoginPassword.Text;

            if (string.IsNullOrWhiteSpace(username)
                || string.IsNullOrWhiteSpace(password))
            {
                MessageBox.Show("Error!", "Incorrect Input"
                    , MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                if (username == adminUsername && password == adminPassword)
                {
                    MessageBox.Show("Login!", "Successfully",
                        MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                UserHome userhome = new UserHome();
                userhome.ShowDialog();
            }
        }

        private void UserLogin_Load(object sender, EventArgs e)
        {

        }
    }
}
