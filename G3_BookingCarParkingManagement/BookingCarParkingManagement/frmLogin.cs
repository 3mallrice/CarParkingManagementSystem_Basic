using Repository;
using System.Text.RegularExpressions;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace BookingCarParkingManagement
{
    public partial class frmLogin : Form
    {
        public UserRepository _user { get; set; }
        public frmLogin()
        {
            _user = new UserRepository();
            InitializeComponent();
        }
        private void btnLogin_Click(object sender, EventArgs e)
        {
            var email = txtEmail.Text.ToLower();
            var password = txtPassword.Text;

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
            /*var user = _user.GetMembers().Where(p => p.Email.Equals(email)
                            && p.Password.Equals(password))
                    .FirstOrDefault();*/
            var user = _user.CheckLogin(email, password);

            if (user != null)
            {
                switch (user.Role)
                {
                    case 1: // customer
                        frmCustomerScreen customerScreen = new frmCustomerScreen
                        {
                            UserLogin = user,
                        };
                        this.Hide();
                        customerScreen.ShowDialog();
                        break;
                    case 2: // staff
                        frmStaffScreen staffScreen = new frmStaffScreen();
                        this.Hide();
                        staffScreen.ShowDialog();
                        break;
                    case 3: // admin
                        frmUserManagement userManagement = new frmUserManagement();
                        this.Hide();
                        userManagement.ShowDialog();
                        break;
                    default:
                        MessageBox.Show("You are not allowed to access this function!", "Error", MessageBoxButtons.OK);
                        break;
                }
                this.Close();
            }
            else
            {
                MessageBox.Show("Invalid username or password!", "Error", MessageBoxButtons.OK);
                txtEmail.Focus(); //đưa con trỏ chuột về lại 
                return;
            }
        }

        private void txtRegister_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.Hide();
            frmRegister register = new frmRegister();
            register.ShowDialog();
            this.Show();
        }

        private void btnCancel_Click(object sender, EventArgs e) => this.Close();
    }
}