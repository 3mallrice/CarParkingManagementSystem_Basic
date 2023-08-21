using DataObject.Models;
using Repository;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BookingCarParkingManagement
{
    public partial class frmRegister : Form
    {
        public UserRepository _user { get; set; }
        public frmRegister()
        {
            _user = new UserRepository();
            InitializeComponent();
        }
        private void btnRegister_Click(object sender, EventArgs e)
        {
            var email = txtEmail.Text;
            var password = txtPassword.Text;
            var confirm = txtConfirmPass.Text;

            if (string.IsNullOrEmpty(email))
            {
                MessageBox.Show("Please enter your email", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (string.IsNullOrEmpty(password))
            {
                MessageBox.Show("Please enter your password", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            var emailRegex = new Regex(@"^[a-zA-Z0-9._%+-]+@[a-zA-Z0-9.-]+\.[a-zA-Z]{2,}$");
            var passwordRegex = new Regex(@"^(?=.*[A-Z])(?=.*\d)(?=.*[@$!%*?&])[A-Za-z\d@$!%*?&]{8,}$");

            var emailIsValid = emailRegex.IsMatch(email);
            var passwordIsValid = passwordRegex.IsMatch(password);

            if (!emailIsValid)
            {
                MessageBox.Show("Please enter a valid email", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (!passwordIsValid)
            {
                MessageBox.Show("Password must be at least 8 characters long and include a digit, an uppercase letter, and a special character", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (!password.Equals(confirm))
            {
                MessageBox.Show("Password and Confirm Password must be the same", "ERROR", MessageBoxButtons.OK);
                txtPassword.Focus();
                return;
            }

            else
            {
                var NewUser = new User();
                NewUser.Email = email;
                NewUser.Password = password;
                NewUser.Role = 1;

                //_user.Create(NewUser);
                MessageBox.Show("Register successfull", "Success", MessageBoxButtons.OK);
                this.Hide();
                frmLogin login = new frmLogin();
                login.ShowDialog();
                this.Close();
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmLogin login = new frmLogin();
            login.ShowDialog();
        }
    }
}
