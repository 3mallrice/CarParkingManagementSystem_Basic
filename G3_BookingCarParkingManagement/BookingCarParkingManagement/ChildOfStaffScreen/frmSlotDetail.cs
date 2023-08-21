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

namespace BookingCarParkingManagement.ChildOfStaffScreen
{
    public partial class frmSlotDetail : Form
    {
        SlotxeRepository slotxeRepo = new SlotxeRepository();
        BaixeRepository baixeRepo = new BaixeRepository();
        BookRepository bookRepo = new BookRepository();
        CarRepository carRepo = new CarRepository();
        Slotxe slotxe;
        Book booking;
        string context;
        public frmSlotDetail(Slotxe slotxe, Book booking, string context)
        {
            InitializeComponent();
            this.slotxe = slotxe;
            this.booking = booking;
            this.context = context;
        }

        private void frmSlotDetail_Load(object sender, EventArgs e)
        {
            txtParking.Enabled = false;
            txtSlot.Enabled = false;
            txtStatus.Enabled = false;
            dtpBook.Enabled = false;
            dtpStart.Enabled = false;

            txtParking.Text = baixeRepo.GetBaiXe().First(x => x.BaixeId == slotxe.BaixeId).BaixeName;
            txtSlot.Text = slotxe.SlotxeId.ToString();
            var cars = carRepo.GetAll();
            List<string> list = new List<string>();
            foreach (var car in cars)
            {
                list.Add(car.Bsx);
            }
            cbxCar.DataSource = list;
            txtStatus.Text = slotxe.Status == 0 ? "Slot Empty" : "Slot har car";
            switch (context)
            {
                case "Checkin":
                    {
                        lbTitle.Text = "Check In";
                        btnCheck.Text = "CHECK IN";
                        btnCheck.BackColor = Color.Green;
                        btnCheck.ForeColor = Color.White;

                        dtpBook.Value = DateTime.Now;
                        dtpStart.Value = DateTime.Now;
                    }
                    break;
                case "Checkout":
                    {
                        lbTitle.Text = "Check Out";
                        btnCheck.Text = "CHECK OUT";
                        btnCheck.BackColor = Color.Red;
                        btnCheck.ForeColor = Color.White;
                        cbxCar.Enabled = false;
                        dtpEnd.Enabled = false;
                    }
                    break;
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            var cfm = MessageBox.Show("Are you sure to cancel?", "Question", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (cfm == DialogResult.Yes)
            {
                this.Close();
            }
        }

        private void btnCheck_Click(object sender, EventArgs e)
        {
            switch (context)
            {
                case "Checkin":
                    {
                        //create and save a booking
                        Book booking = new Book();
                        booking.BookId = 0;
                        booking.SlotxeId = slotxe.SlotxeId;
                        booking.CarId = carRepo.GetAll().First(x => x.Bsx == cbxCar.Text).CarId;
                        booking.BookingTime = DateTime.Now;
                        booking.StartTime = DateTime.Now;
                        booking.EndTime = dtpEnd.Value;
                        booking.Status = 1;
                        bookRepo.Create(booking);
                        MessageBox.Show("Check In successfully!","Information",MessageBoxButtons.OK, MessageBoxIcon.Information);
                        this.Close();
                        frmParkingSlot frmParkingSlot = new frmParkingSlot();
                        frmParkingSlot.Refresh();
                    }
                    break;
                case "Checkout":
                    {
                        frmBill frmBill = new frmBill(booking);
                        this.Hide();
                        frmBill.ShowDialog();
                    }
                    break;
            }
        }
    }
}
