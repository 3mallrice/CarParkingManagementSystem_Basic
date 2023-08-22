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
        BookRepository bookRepository = new BookRepository();
        SlotxeRepository slotxeRepository = new SlotxeRepository();
        int slotID;
        public frmParkingSlot()
        {
            InitializeComponent();
        }

        private void frmParkingSlot_Load(object sender, EventArgs e)
        {
            List<Book> bookingList = bookRepository.GetAll().Where(x => x.Status == 1 && DateTime.Now.CompareTo(x.StartTime) >= 0 && DateTime.Now.CompareTo(x.EndTime) <= 0).ToList();
            List<Slotxe> slotxeList = slotxeRepository.GetAll().ToList();
            ChangeSlotStatus(bookingList,slotxeList);
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
            List<Book> bookingList = bookRepository.GetAll().Where(x => x.Status == 1 && DateTime.Now.CompareTo(x.StartTime) >= 0 && DateTime.Now.CompareTo(x.EndTime) <= 0).ToList();
            List<Slotxe> slotxeList = slotxeRepository.GetAll().ToList();
            ChangeSlotStatus(bookingList, slotxeList);
            this.pnParkingSlot.Controls.Clear();
            var parkingList = baixeRepository.GetBaiXe();
            //Get parking object from cbx
            Baixe parking = parkingList.SingleOrDefault(x => x.BaixeName.Equals(cbxParking.SelectedItem));
            
            //Generate slots graphic in this parking to panel
            List<Slotxe> list = slotxeList.Where(x => x.BaixeId == parking.BaixeId).ToList();
            for (int i = 0; i < parking.TotalSlot; i++)
            {
                Slotxe slot = (Slotxe)list.ElementAt(i);
                Button bt = new Button();
                bt.Location = new Point(i * 65 + 3, 3);
                bt.Text = ("Slot " + (i+1)).ToString();
                bt.Name = slot.SlotxeId.ToString();
                bt.Size = new Size(59, 110);
                bt.TabIndex = i;
                bt.UseVisualStyleBackColor = true;
                //Check slot status to change back color
                if (slot.Status == 1)
                {
                    bt.BackColor = Color.LightGray;
                }

                bt.Click += new EventHandler(this.bt_DoubleClick);
                this.pnParkingSlot.Controls.Add(bt);
            }
        }

        private void bt_DoubleClick(object sender, EventArgs e)
        {
            Button btn = sender as Button;
            Slotxe slotxe = slotxeRepository.GetAll().First(x => x.SlotxeId == Int32.Parse(btn.Name));
            Book book = bookRepository.GetAll().FirstOrDefault(x => x.SlotxeId == slotxe.SlotxeId && x.Status == 1 && DateTime.Now.CompareTo(x.StartTime) >= 0 && DateTime.Now.CompareTo(x.EndTime) <= 0);
            if (slotxe.Status == 0)
            {
                frmSlotDetail frmSlotDetail = new frmSlotDetail(slotxe, book, "Checkin");
                frmSlotDetail.ShowDialog(this);
            }
            else
            {
                frmSlotDetail frmSlotDetail = new frmSlotDetail(slotxe, book, "Checkout");
                frmSlotDetail.ShowDialog(this);
            }
        }

        private void ChangeSlotStatus(List<Book> bookingList, List<Slotxe> slotxeList)
        {
            
            foreach (var s in slotxeList)
            {
                foreach (var b in bookingList)
                {
                    if (s.SlotxeId == b.SlotxeId && s.Status == 0) s.Status = 1;
                    slotxeRepository.Update(s);
                }                
            }
        }
    }
}
