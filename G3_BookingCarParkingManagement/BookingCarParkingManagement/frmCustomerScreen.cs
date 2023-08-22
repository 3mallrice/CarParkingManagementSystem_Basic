using DataObject.Models;
using Repository;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BookingCarParkingManagement
{
    public partial class frmCustomerScreen : Form
    {
        IBaixeRepository baixeRepository = new BaixeRepository();
        string searchType = "";
        public frmCustomerScreen()
        {
            InitializeComponent();
        }
        bool search = false;
        bool filter = false;
        IEnumerable<Baixe> DataSource;
        IEnumerable<Baixe> searchResult;
        IEnumerable<Baixe> filterResult;
        public User UserLogin { get; set; }
        public void LoadProductList()
        {
            try
            {
                var BaixeList = baixeRepository.GetBaiXe();
                BindingSource source;
                source = new BindingSource();
                source.DataSource = BaixeList;

                txtBaixeID.DataBindings.Clear();
                txtTenBaiXe.DataBindings.Clear();
                txtTongSlot.DataBindings.Clear();


                txtBaixeID.DataBindings.Add("Text", source, "BaixeId");
                txtTenBaiXe.DataBindings.Add("Text", source, "BaixeName");
                txtTongSlot.DataBindings.Add("Text", source, "TotalSlot");


                dgvListBaixe.DataSource = null;
                dgvListBaixe.DataSource = source;

                //ClearSearchSection();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error on load list of Baixe ");
            }
        }
        public void ClearSearchSection()
        {
            txtSearchBox.Clear();
            cboSearchFilter.Text = null;
        }
        public void LoadListSearch(string keyword, string type)
        {
            try
            {

                var productList = baixeRepository.SearchProduct(keyword, type);
                BindingSource source;
                source = new BindingSource();
                source.DataSource = productList;

                txtBaixeID.DataBindings.Clear();
                txtTenBaiXe.DataBindings.Clear();
                txtTongSlot.DataBindings.Clear();


                txtBaixeID.DataBindings.Add("Text", source, "BaixeId");
                txtTenBaiXe.DataBindings.Add("Text", source, "BaixeName");
                txtTongSlot.DataBindings.Add("Text", source, "TotalSlot");


                dgvListBaixe.DataSource = null;
                dgvListBaixe.DataSource = source;

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error on load list search");
            }
        }


        private void frmCustomerScreen_Load(object sender, EventArgs e)
        {
            LoadProductList();
        }

        private void txtSearchBox_TextChanged_1(object sender, EventArgs e)
        {
            LoadListSearch(txtSearchBox.Text, searchType);
        }

        private void cboSearchFilter_SelectedIndexChanged_1(object sender, EventArgs e)
        {
            txtSearchBox.Clear();
            searchType = cboSearchFilter.Text;
        }
        /*private Users GetUserObject()
        {
            Users pro = null;
            try
            {
                pro = new Users
                {
                    ProductId = int.Parse(txtProductID.Text),
                    ProductName = txtProductName.Text,
                    CategoryId = int.Parse(txtCategoryID.Text),
                    UnitPrice = decimal.Parse(txtPrice.Text),
                    UnitsInStock = short.Parse(txtStock.Text),
                    Description = txtWeight.Text,

                };
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Get member");
            }
            return pro;
        }*/

        private void button1_Click(object sender, EventArgs e)
        {
            frmUpdateCustomerScreen frmUpdate = new frmUpdateCustomerScreen
            {
                a = UserLogin.UserId,
                InsertOrUpdate = true

            };
            frmUpdate.ShowDialog();
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
    }
}
