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
    public partial class frmParkingSlot : Form
    {
        BaixeRepository baixeRepository = new BaixeRepository();
        SlotxeRepository slotxeRepository = new SlotxeRepository();
        public frmParkingSlot()
        {
            InitializeComponent();
        }

        private void frmParkingSlot_Load(object sender, EventArgs e)
        {
            pnParkingSlot.Visible = false;
            var list = baixeRepository.GetBaiXe();
            List<string> parkingNameList = new List<string>();
            foreach (Baixe baixe in list)
            {
                parkingNameList.Add(baixe.BaixeName);
            }
            cbxParking.DataSource = parkingNameList;
        }

        private void cbxParking_SelectedIndexChanged(object sender, EventArgs e)
        {
            var parkingList = baixeRepository.GetBaiXe();
            Baixe parking = new Baixe();
            foreach (Baixe baixe in parkingList)
            {
                if (baixe.BaixeName.Equals(cbxParking.Text))
                {
                    parking = baixe;
                }
            }
            for (int i = 1; i <= parking.TotalSlot; i++)
            {
                
            }
        }
    }
}
