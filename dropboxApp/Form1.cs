using System;
using System.Windows.Forms;

namespace dropboxApp
{
    public partial class Auth : Form
    {
        public Auth()
        {
            InitializeComponent();
        }

        private void connect_button_Click(object sender, EventArgs e)
        {
            MainWindow mw = new MainWindow();
            if (userCheck(this.login_textBox.ToString(), this.password_textBox.ToString())) mw.Show();
        }

        private bool userCheck(string login, string password) {
            if (login.Contains(@"devjatkin.fjodr@gmail.com") && password.Contains(@"agent1815")) return true;
            else { MessageBox.Show("Wrong login or password"); return false; }
        }
    }
}
