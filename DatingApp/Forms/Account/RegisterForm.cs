﻿using System;
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
    public partial class frmRegister : Form
    {
        private readonly IContainer _container;

        public frmRegister(IContainer container)
        {
            InitializeComponent();
            _container = container;
        }

        private async void button1_Click(object sender, EventArgs e)
        {
            var registerDto = new RegisterDto
            {
                Username = txtUsername.Text,
                Password = txtPassword.Text,
                City = txtCity.Text,
                Country = txtCountry.Text,
                DateOfBirth = datePickerDateOfBirth.Value,
                Gender = radioBtnMale.Checked ? "male" : "female",
                KnownAs = txtKnownAs.Text
            };

            if (await _container.AccountManager.Register(registerDto))
            {
                this.DialogResult = DialogResult.OK;
            }
            else
            {
                MessageBox.Show("Invalid Credentials, Please Try Again", "Register Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtUsername.Focus();
            }
            this.DialogResult = DialogResult.OK;
        }

        private void checkbxShowPas_CheckedChanged(object sender, EventArgs e)
        {
            if (checkbxShowPas.Checked)
            {
                txtPassword.PasswordChar = '\0';
                txtComPassword.PasswordChar = '\0';
            }
            else
            {
                txtPassword.PasswordChar = '•';
                txtComPassword.PasswordChar = '•';
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            txtUsername.Text = "";
            txtPassword.Text = "";
            txtComPassword.Text = "";
            txtUsername.Focus();
        }

        private void label6_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.No;
        }

        private void frmRegister_Load(object sender, EventArgs e)
        {
        }

        private void btnWindowExit_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void txtPassword_TextChanged(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void txtComPassword_TextChanged(object sender, EventArgs e)
        {

        }

        private void radioBtnMale_CheckedChanged(object sender, EventArgs e)
        {
            radioBtnFemale.Checked = !radioBtnMale.Checked;
        }

        private void radioBtnFemale_CheckedChanged(object sender, EventArgs e)
        {
            radioBtnMale.Checked = !radioBtnFemale.Checked;
        }
    }
}