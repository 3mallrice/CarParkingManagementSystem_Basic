using Repository;

namespace BookingCarParkingManagement
{
    public partial class frmUpdateCustomerScreen : Form
    {

        // public IUserRepository UserRepository { get; set; }
        public bool InsertOrUpdate { get; set; }
        public DataObject.Models.User user { get; set; }
        public frmUpdateCustomerScreen()
        {
            InitializeComponent();
        }
        UserRepository userRepository = new UserRepository();

        DataObject.Models.User currentMemberInfo = new DataObject.Models.User();
        public DataObject.Models.User UserLogins { get; set; }

        public int a;
        public void LoadUserInfo()
        {
            currentMemberInfo = userRepository.GetMemberByMemberID(a.ToString());

            txtCusID.Text = currentMemberInfo.UserId.ToString();
            txtCusName.Text = currentMemberInfo.Name;
            txtEmail.Text = currentMemberInfo.Email;
            txtPhoneNum.Text = currentMemberInfo.UserId.ToString();
            txtPassword.Text = currentMemberInfo.Password;
            txtStatus.Text = currentMemberInfo.Status.ToString();
        }


        private void btnUpdateMember_Click_1(object sender, EventArgs e)
        {
            Random rnd = new Random();
            Boolean checkId = true;
            int memID;
            try
            {
                /*do
                {

                    memID = rnd.Next(10, 10000);
                    if (!UserRepository.CheckMemberIdDuplicated(memID))
                    {
                        checkId = false;
                    }


                } while (checkId);*/


                if (txtEmail.Text == "" || txtCusName.Text == "" || txtPassword.Text == "")
                {
                    MessageBox.Show("All fields are required!", "Product Management",
                        MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    if (InsertOrUpdate == true)
                    {
                        var m = new DataObject.Models.User
                        {

                            UserId = int.Parse(txtCusID.Text),
                            Email = txtEmail.Text,
                            Name = txtCusName.Text,
                            Password = txtPassword.Text,
                            Phone = txtPhoneNum.Text,
                            Status = int.Parse(txtStatus.Text),
                            //UserId = user.UserId


                        };
                        userRepository.UpdateMember(m);
                        MessageBox.Show("Update member successfully!");
                    }

                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, InsertOrUpdate == false ? "Add a new Member!" : "Update a Member!");

            }
        }

        private void btnClose_Click_1(object sender, EventArgs e)
        {
            Close();
        }

        private void tabInfo_Click(object sender, EventArgs e)
        {

        }

        private void frmUpdateCustomerScreen_Load_1(object sender, EventArgs e)
        {
            LoadUserInfo();
        }
    }
}
