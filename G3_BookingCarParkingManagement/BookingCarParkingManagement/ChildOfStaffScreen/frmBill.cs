using DataObject.Models;
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
    public partial class frmBill : Form
    {
        Book book;
        public frmBill(Book book)
        {
            InitializeComponent();
            this.book = book;
        }
    }
}
