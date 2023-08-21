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
    public partial class frmBooking : Form
    {
        BookRepository bookRepo = new BookRepository();
        CarRepository carRepo = new CarRepository();
        public frmBooking()
        {
            InitializeComponent();
        }

        private void frmBooking_Load(object sender, EventArgs e)
        {
            panel1.Enabled = false;
            LoadBookingList();
        }

        private void LoadBookingList()
        {
            try
            {
                var list = bookRepo.GetAll();
                dgvBooking.ClearSelection();
                dgvBooking.DataSource = null;
                dgvBooking.DataSource = list;
                dgvBooking.Update();
                dgvBooking.Refresh();
                if (list.Count() == 0)
                {
                    ClearText();
                    pnButton.Enabled = false;
                }
                else
                {
                    pnButton.Enabled = true;
                    dgvBooking.Rows[0].Selected = true;
                    ShowBookingDetail(list.ElementAt(0));
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        //Showing booking detail to textbox
        private void ShowBookingDetail(Book book)
        {
            var cars = carRepo.GetAll();
            txtID.Text = book.BookId.ToString();
            txtSlot.Text = book.SlotxeId.ToString();
            txtCar.Text = cars.SingleOrDefault(x => x.CarId == book.CarId).Bsx;
            dtpBook.Value = (DateTime)book.BookingTime;
            dtpStart.Value = (DateTime)book.StartTime;
            dtpEnd.Value = (DateTime)book.EndTime;
        }


        //Clear all textbox
        private void ClearText()
        {
            txtID.Clear();
            txtSlot.Clear();
            txtCar.Clear();
            dtpBook.Value = DateTime.Now;
            dtpStart.Value = DateTime.Now;
            dtpEnd.Value = DateTime.Now;
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            string searchString = txtSearch.Text;
            List<Book> list = new List<Book>();
            switch (cbxSearchBy.Text)
            {
                case "Booking ID":
                    {
                        list.Add(bookRepo.GetAll().SingleOrDefault(x => x.BookId == int.Parse(searchString)));
                    }
                    break;
                case "Slot ID":
                    {
                        var bookings = bookRepo.GetAll().Where(x => x.SlotxeId == int.Parse(searchString));
                        foreach (var book in bookings)
                        {
                            list.Add((Book)book);
                        }
                    }
                    break;
                case "Car number":
                    {
                        var car = carRepo.GetAll().Where(x => x.Bsx.Trim().ToLower().Equals(searchString.Trim().ToLower()));
                        var bookings = bookRepo.GetAll();
                        foreach (var book in bookings)
                        {
                            if (book.CarId == car.First().CarId) list.Add((Book)book);
                        }
                    }
                    break;
            }
            ClearText();
            dgvBooking.DataSource = list;
            sender = list;
            dgvBooking.Update();
            dgvBooking.Refresh();
        }

        //Status == 0 => Waiting
        //Status == 1 => Approved
        //Status == 2 => Rejected
        private void btnApprove_Click(object sender, EventArgs e)
        {
            Book booking = bookRepo.GetAll().ToList().Find(x => x.BookId == int.Parse(txtID.Text));
            if (booking.Status != 1) { booking.Status = 1; }
            bookRepo.Update(booking);
            MessageBox.Show("This booking has been approved!", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void btnReject_Click(object sender, EventArgs e)
        {
            Book booking = bookRepo.GetAll().ToList().Find(x => x.BookId == int.Parse(txtID.Text));
            if (booking.Status != 2) { booking.Status = 2; }
            bookRepo.Update(booking);
            MessageBox.Show("This booking has been rejected!", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void dgvBooking_MouseClick(object sender, MouseEventArgs e)
        {

        }

        private void dgvBooking_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            Book booking = dgvBooking.CurrentRow.DataBoundItem as Book;
            ShowBookingDetail(booking);
            if (booking.Status == 0)
            {
                pnButton.Enabled = true;
            }
            else
            {
                pnButton.Enabled = false;
            }
        }
    }
}
