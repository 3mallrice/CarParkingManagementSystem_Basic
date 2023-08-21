namespace BookingCarParkingManagement.ChildOfStaffScreen
{
    partial class frmParkingSlot
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            label1 = new Label();
            cbxParking = new ComboBox();
            pnParkingSlot = new FlowLayoutPanel();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(12, 20);
            label1.Name = "label1";
            label1.Size = new Size(69, 21);
            label1.TabIndex = 0;
            label1.Text = "Parking";
            // 
            // cbxParking
            // 
            cbxParking.FormattingEnabled = true;
            cbxParking.Location = new Point(87, 22);
            cbxParking.Name = "cbxParking";
            cbxParking.Size = new Size(79, 23);
            cbxParking.TabIndex = 1;
            cbxParking.SelectedIndexChanged += cbxParking_SelectedIndexChanged;
            // 
            // pnParkingSlot
            // 
            pnParkingSlot.Location = new Point(8, 62);
            pnParkingSlot.Name = "pnParkingSlot";
            pnParkingSlot.Size = new Size(782, 380);
            pnParkingSlot.TabIndex = 2;
            // 
            // frmParkingSlot
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(pnParkingSlot);
            Controls.Add(cbxParking);
            Controls.Add(label1);
            Name = "frmParkingSlot";
            Text = "frmParkingSlot";
            Load += frmParkingSlot_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private ComboBox cbxParking;
        private FlowLayoutPanel pnParkingSlot;
    }
}