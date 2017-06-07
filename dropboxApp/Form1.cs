using System;
using System.Windows.Forms;

namespace dropboxApp
{
    public partial class Auth : Form
    {
        public Auth()
        {
            InitializeComponent();
            login_textBox.Text = @"devjatkin.fjodr@gmail.com";
            password_textBox.Text = @"agent1815";
        }

        internal Dropbox Dropbox
        {
            get => default(Dropbox);
            set
            {
            }
        }

        private void connect_button_Click(object sender, EventArgs e)
        {
            MainWindow mw = new MainWindow();
            if (userCheck(login_textBox.ToString(), password_textBox.ToString())) { mw.Show(); }
        }

        private bool userCheck(string login, string password) {
            if (login.Contains(@"devjatkin.fjodr@gmail.com") && password.Contains(@"agent1815")) return true;
            else { MessageBox.Show("Wrong login or password"); return false; }
        }
    }
}
