
using Repository;
using System.Data;
using System.Text.RegularExpressions;

namespace BookingCarParkingManagement
{
    public partial class frmUserManagement : Form
    {
        public UserRepository _user = new UserRepository();
        public frmUserManagement()
        {
            //_user = new UserRepository();
            InitializeComponent();
        }
        private void frmUserManagement_Load(object sender, EventArgs e)
        {
            GetList();
        }
        public void GetList()
        {
            try
            {
                var users = _user.GetAll();
                dgvUserManagement.DataSource = users.Select(p => new
                {
                    p.UserId,
                    p.Name,
                    p.Email,
                    Password = new string('*', p.Password.Length), // Đổi mật khẩu thành chuỗi '*'
                    p.Phone,
                    p.Role,
                    p.Status
                }).ToList();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Load user list");
            }
        }
        private void dgvUserManagemen_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
        }
        private void dgvUserManagement_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && e.RowIndex < dgvUserManagement.Rows.Count)
            {
                var UserIdCell = dgvUserManagement.Rows[e.RowIndex].Cells[0];
                if (UserIdCell.Value != null && int.TryParse(UserIdCell.Value.ToString(), out int userId))
                {
                    var user = _user.GetAll().FirstOrDefault(p => p.UserId == userId);
                    if (user != null)
                    {
                        txtUserID.Text = user.UserId.ToString();
                        txtName.Text = user.Name;
                        txtEmail.Text = user.Email.ToLower();
                        txtPassword.Text = user.Password;
                        txtPhone.Text = user.Phone;
                        txtRole.Text = user.Role.ToString();
                        txtStatus.Text = user.Status.ToString();
                    }
                }
            }
        }

        public void Clear()
        {
            txtUserID.Text = string.Empty;
            txtName.Text = string.Empty;
            txtEmail.Text = string.Empty;
            txtPassword.Text = string.Empty;
            txtPhone.Text = string.Empty;
            txtRole.Text = string.Empty;
            txtStatus.Text = string.Empty;
        }

        private void btnLoad_Click_1(object sender, EventArgs e)
        {
            Clear();
            GetList();
        }

        private void btnDelete_Click_1(object sender, EventArgs e)
        {
            try
            {
                if (int.TryParse(txtUserID.Text, out int userId))
                {
                    var userToDelete = _user.GetAll().FirstOrDefault(p => p.UserId == userId);

                    if (userToDelete == null)
                    {
                        MessageBox.Show("User not found with the provided ID.", "Error", MessageBoxButtons.OK);
                        return;
                    }

                    // Đánh dấu người dùng đã bị xóa bằng cách cập nhật trạng thái
                    userToDelete.Status = 0;

                    _user.Update(userToDelete);
                    GetList(); // Đảm bảo cập nhật danh sách sau khi xóa
                }
                else
                {
                    MessageBox.Show("Invalid UserID format.", "Error", MessageBoxButtons.OK);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Cannot delete", MessageBoxButtons.OK);
            }
        }


        private void btnClose_Click_1(object sender, EventArgs e)
        {
            try
            {
                DialogResult result = MessageBox.Show("Are you sure you want to close the form?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                if (result == DialogResult.Yes)
                {
                    Close();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK);
            }
        }
        private void btnUpdate_Click(object sender, EventArgs e)
        {
            try
            {
                // Lấy thông tin người dùng dựa trên UserID
                var UserOld = _user.GetAll().FirstOrDefault(p => p.UserId == int.Parse(txtUserID.Text));

                if (UserOld == null)
                {
                    MessageBox.Show("User not found with the provided ID.", "Error", MessageBoxButtons.OK);
                    return;
                }

                var email = txtEmail.Text;
                var password = txtPassword.Text;
                var phone = txtPhone.Text;

                var emailRegex = new Regex(@"^[a-zA-Z0-9._%+-]+@[a-zA-Z0-9.-]+\.[a-zA-Z]{2,}$");
                var passwordRegex = new Regex(@"^(?=.*[A-Z])(?=.*\d)(?=.*[@$!%*?&])[A-Za-z\d@$!%*?&]{8,}$");
                var phoneRegex = new Regex(@"^(03\d|05\d|07\d|08\d|09\d)\d{7}$");

                var emailIsValid = emailRegex.IsMatch(email);
                var passwordIsValid = passwordRegex.IsMatch(password);
                var phoneIsValid = phoneRegex.IsMatch(phone);

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

                if (!phoneIsValid)
                {
                    MessageBox.Show("Please enter a valid phone", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                UserOld.Email = email;
                UserOld.Name = txtName.Text;
                UserOld.Password = password;
                UserOld.Status = int.Parse(txtStatus.Text);
                UserOld.Phone = phone;
                UserOld.Role.Equals(int.Parse(txtRole.Text));

                _user.Update(UserOld);
                GetList();
                Clear();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Cannot Update", MessageBoxButtons.OK);
            }
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            try
            {
                var SearchKey = txtSearch.Text;
                var listUser = _user.GetAll()
                                .Where(p => p.Name.Contains(SearchKey)).ToList();
                dgvUserManagement.DataSource = listUser.Select(p => new
                {
                    p.UserId,
                    p.Name,
                    p.Email,
                    p.Password,
                    p.Phone,
                    p.Role,
                    p.Status
                }).ToList();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Load user list");
            }
        }

        private void btnParkingBookingManagement_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmParkingBooking parkingBooking = new frmParkingBooking();
            parkingBooking.ShowDialog();
        }

        private void btnStaffScreen_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmStaffScreen staffScreen = new frmStaffScreen();
            staffScreen.ShowDialog();
        }

        private void btnLogout_Click(object sender, EventArgs e)
        {
            var cfm = MessageBox.Show("Are you sure to Sign Out?", "Question", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
            if (cfm == DialogResult.OK)
            {
                this.Hide();
                frmLogin frmLogin = new frmLogin();
                frmLogin.ShowDialog();
            }
        }

        private void dgvUserManagement_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btnUnBan_Click(object sender, EventArgs e)
        {
            try
            {
                if (int.TryParse(txtUserID.Text, out int userId))
                {
                    var userToDelete = _user.GetAll().FirstOrDefault(p => p.UserId == userId);

                    if (userToDelete == null)
                    {
                        MessageBox.Show("User not found with the provided ID.", "Error", MessageBoxButtons.OK);
                        return;
                    }

                    // Đánh dấu người dùng đã bị xóa bằng cách cập nhật trạng thái
                    userToDelete.Status = 1;

                    _user.Update(userToDelete);
                    GetList(); // Đảm bảo cập nhật danh sách sau khi xóa
                }
                else
                {
                    MessageBox.Show("Invalid UserID format.", "Error", MessageBoxButtons.OK);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Cannot delete", MessageBoxButtons.OK);
            }
        }
    }
}
