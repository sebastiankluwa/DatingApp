using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.OleDb;
using DatingApp.App;
using Local.DTOs;

namespace Local.Forms.Account
{
    public partial class LoginForm : Form
    {
        private readonly IContainer _container;

        public LoginForm(IContainer container)
        {
            InitializeComponent();
            _container = container;
        }

        private async void button1_Click(object sender, EventArgs e)
        {
            var loginDto = new LoginDto
            {
                Username = txtUsername.Text,
                Password = txtpassword.Text
            };

            if(await _container.AccountManager.Login(loginDto))
            {
                this.DialogResult = DialogResult.OK;

            }
            else
            {
                MessageBox.Show("Invalid Username or Password, Please Try Again", "Login Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtUsername.Text = "";
                txtpassword.Text = "";
                txtUsername.Focus();
            }

            //con.Open();
            //string login = "SELECT * FROM tbl_users WHERE username= '" + txtUsername.Text + "' and password= '" + txtpassword.Text + "'";
            //cmd = new OleDbCommand(login,con);
            //OleDbDataReader dr = cmd.ExecuteReader();

            //if (dr.Read() == true)
            //{
            //    new dashboard().Show();
            //    this.Hide();
            //}
            //else
            //{
            //    MessageBox.Show("Invalid Username or Password, Please Try Again", "Login Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
            //    txtUsername.Text = "";
            //    txtpassword.Text = "";
            //    txtUsername.Focus();
            //}
        }

        private void button2_Click(object sender, EventArgs e)
        {
            txtUsername.Text = "";
            txtpassword.Text = "";
            txtUsername.Focus();
        }

        private void checkbxShowPas_CheckedChanged(object sender, EventArgs e)
        {
            if (checkbxShowPas.Checked)
            {
                txtpassword.PasswordChar = '\0';
                
            }
            else
            {
                txtpassword.PasswordChar = '•';
                
            }
        }

        private void label6_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.No;
        }

        private void frmLogin_Load(object sender, EventArgs e)
        {

        }

        private void btnWindowExit_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
        }
    }
}
