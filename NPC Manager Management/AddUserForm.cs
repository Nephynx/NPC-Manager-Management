using Microsoft.VisualBasic.ApplicationServices;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NPC_Manager_Management
{
    public partial class AddUserForm : Form
    {
        public AddUserForm()
        {
            InitializeComponent();
        }

        private void buttonClear_Click(object sender, EventArgs e)
        {
            string email = txtEmail.Text;
            string username = txtUsername.Text;
            string password = txtPassword.Text;

            if (string.IsNullOrWhiteSpace(email)
                || string.IsNullOrWhiteSpace(username)
                || string.IsNullOrWhiteSpace(password))
            {
                MessageBox.Show("Error!", "Incorrect Input"
                    , MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                User userToSave = new User();
                userToSave.Email = email;
                userToSave.Username = username;
                userToSave.Password = password;
                UserRepository repository = new UserRepository();
                bool isSaved = repository.Add(userToSave);

                if (MessageBox.Show("Create this record!", "Confirm",
                        MessageBoxButtons.YesNo) == DialogResult.No)
                {
                    return;
                }
                txtEmail.Clear();
                txtUsername.Clear();
                txtPassword.Clear();
            }
        }
    }
}
