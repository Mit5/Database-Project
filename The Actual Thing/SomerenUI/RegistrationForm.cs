using SomerenLogic;
using SomerenModel;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SomerenUI
{
    public partial class RegistrationForm : Form
    {
        public RegistrationForm()
        {
            InitializeComponent();
        }

        private void buttonCancel_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void buttonSignUp_Click(object sender, EventArgs e)
        {
            UserService userService = new UserService();
            string username = textBoxUsername.Text;
            string password = textBoxPassword.Text;
            string secretQuestion = textBoxQuestion.Text;
            string secretAnswer = textBoxAnswer.Text;
            string productKey = textBoxProductKey.Text;
            if (!userService.LicenseKeyChecker(productKey))
            {
                MessageBox.Show("The license key you have entered is not correct!","Incorrect product key",MessageBoxButtons.OK,MessageBoxIcon.Error);
                textBoxProductKey.Text = "";
                textBoxPassword.Text = "";
            }
            else
            {
                if (!userService.PasswordIsCorrect(password))
                {
                    MessageBox.Show("Incorrect password! The password should adhere to the following requirements: \n• Minimum length 8 characters\n• Minimum of 1 lowercase letter\n• Minimum of 1 uppercase letter\n• Minimum of 1 number\n• Minimum of 1 special character", "Incorrect password", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    textBoxProductKey.Text = "";
                    textBoxPassword.Text = "";
                }
                else
                {
                    CreateUser(username, password, secretQuestion, secretAnswer);
                }
            }
            
        }

        private void CreateUser(string username, string password, string secretQuestion, string secretAnswer)
        {
            UserService userService = new UserService();
            User user = new User()
            {   Username = username,
                Password = password,
                SecretQuestion = secretQuestion,
                SecretAnswer = secretAnswer
            };
            userService.CreateUser(user);
            MessageBox.Show("User successfully created!");
            Close();
        }
    }
}
