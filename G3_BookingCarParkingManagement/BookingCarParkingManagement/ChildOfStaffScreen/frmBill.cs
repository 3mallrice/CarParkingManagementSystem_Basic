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
using System.Globalization;

namespace BookingCarParkingManagement.ChildOfStaffScreen
{
    public partial class frmBill : Form
    {
        CarRepository carRepository = new CarRepository();
        Book book;
        CultureInfo culture = new CultureInfo("en-US");
        public frmBill(Book book)
        {
            InitializeComponent();
            this.book = book;
        }

        private void frmBill_Load(object sender, EventArgs e)
        {
            Car car = carRepository.GetAll().Single(x => x.CarId == book.CarId);
            lbCar.Text = car.Bsx;
            DateTime endTime = (DateTime)book.EndTime;
            DateTime startTime = (DateTime)book.StartTime;
            TimeSpan time = endTime.Subtract(startTime);
            lbHour.Text = time.Hours.ToString() + "Hour "+time.Minutes.ToString()+"Minutes";
            lbPrice.Text = "40.000/Hour";
            lbTotal.Text = string.Format(culture, "{0:N0}", decimal.Parse((40000 * Math.Round(time.TotalHours,2)).ToString(), NumberStyles.AllowThousands));
        }

        private void btnOK_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
