using System;
using System.Windows.Forms;
using InsagramApiByHands;

namespace InstagramBot
{
    public partial class LoginForm : Form
    {
        Instagram instagram;
        public LoginForm()
        {
            InitializeComponent();
            instagram = new Instagram();
        }

        private void LoginButton_Click(object sender, EventArgs e)
        {
            instagram.LoginAndDisableNotifications(LoginTextBox.Text, PasswordTextBox.Text);
            
            MainForm mainForm = new MainForm(instagram);
            Hide();
            mainForm.ShowDialog();
            Close();
        }

        private void PasswordTextBox_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == System.Windows.Forms.Keys.Enter)
            {
                LoginButton_Click(sender, e);
            }
        }
    }
}
