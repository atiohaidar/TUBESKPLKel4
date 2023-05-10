using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TUBESKPLKel4.Services;

namespace TUBESKPLKel4.Views
{
    public partial class Login : Form
    {
        private LoginService loginService;
        public Login()
        {
            this.loginService = new LoginService(new Repositories.UserRepository());
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                if (this.loginService.IsValidUser(formUsername.Text, formPassword.Text)) {
                    MessageBox.Show("Berhasil login", "informasi");
                    new HalamanDepan().Show();
                    this.Hide();
                }
            } catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "error");
            }
        }

        private void formPassword_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
