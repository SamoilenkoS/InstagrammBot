using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using InsagramApiByHands;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;

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
            
            MainForm mainForm = new MainForm(iWebDriver);
            Hide();
            mainForm.ShowDialog();
            Close();
        }

        

        private void HideWebDriverWindow()
        {

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
