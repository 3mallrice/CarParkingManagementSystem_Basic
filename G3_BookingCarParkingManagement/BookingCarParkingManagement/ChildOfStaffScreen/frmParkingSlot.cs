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
        IBaixeRepository baixeRepository = new BaixeRepository();
        SlotxeRepository slotxeRepository = new SlotxeRepository();
        public frmParkingSlot()
        {
            InitializeComponent();
        }

        private void frmParkingSlot_Load(object sender, EventArgs e)
        {
            pnParkingSlot.Visible = true;
            var parkingList = baixeRepository.GetBaiXe();
            List<string> parkingNameList = new List<string>();
            foreach (Baixe baixe in parkingList)
            {
                parkingNameList.Add(baixe.BaixeName);
            }
            cbxParking.DataSource = parkingNameList;
        }

        private void cbxParking_SelectedIndexChanged(object sender, EventArgs e)
        {
            this.pnParkingSlot.Controls.Clear();
            var parkingList = baixeRepository.GetBaiXe();
            var slots = slotxeRepository.GetAll();
            Baixe parking = new Baixe();
            //Get parking object from cbx
            foreach (Baixe baixe in parkingList)
            {
                if (baixe.BaixeName.Equals(cbxParking.Text))
                {
                    parking = baixe;
                }
            }
            //Generate slots graphic in this parking to panel
            List<Slotxe> list = slots.Where(x => x.BaixeId == parking.BaixeId).ToList();
            for (int i = 1; i <= parking.TotalSlot; i++)
            {
                Button bt = new Button();
                bt.Location = new Point(i * 65 + 3, 3);
                bt.Text = "Slot " + i.ToString();
                bt.Name = i.ToString();
                bt.Size = new Size(59, 110);
                bt.TabIndex = i;
                bt.UseVisualStyleBackColor = true;
                //Check slot status to change back color
                Slotxe slot = (Slotxe)list.ElementAt(i - 1);
                if (slot.Status == 1)
                {
                    bt.BackColor = Color.LightGray;
                }
                this.pnParkingSlot.Controls.Add(bt);
            }
        }
    }
}
