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
            pnTimer = new Panel();
            pnButton = new Panel();
            btnCheckOut = new Button();
            btnCheckIn = new Button();
            pnButton.SuspendLayout();
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
            // pnTimer
            // 
            pnTimer.Location = new Point(522, 6);
            pnTimer.Name = "pnTimer";
            pnTimer.Size = new Size(267, 50);
            pnTimer.TabIndex = 6;
            // 
            // pnButton
            // 
            pnButton.Controls.Add(btnCheckOut);
            pnButton.Controls.Add(btnCheckIn);
            pnButton.Location = new Point(187, 6);
            pnButton.Name = "pnButton";
            pnButton.Size = new Size(267, 50);
            pnButton.TabIndex = 5;
            // 
            // btnCheckOut
            // 
            btnCheckOut.Location = new Point(143, 0);
            btnCheckOut.Name = "btnCheckOut";
            btnCheckOut.Size = new Size(124, 50);
            btnCheckOut.TabIndex = 1;
            btnCheckOut.Text = "CHECK OUT";
            btnCheckOut.UseVisualStyleBackColor = true;
            // 
            // btnCheckIn
            // 
            btnCheckIn.Location = new Point(0, 0);
            btnCheckIn.Name = "btnCheckIn";
            btnCheckIn.Size = new Size(124, 50);
            btnCheckIn.TabIndex = 0;
            btnCheckIn.Text = "CHECK IN";
            btnCheckIn.UseVisualStyleBackColor = true;
            // 
            // frmParkingSlot
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(pnTimer);
            Controls.Add(pnButton);
            Controls.Add(pnParkingSlot);
            Controls.Add(cbxParking);
            Controls.Add(label1);
            Name = "frmParkingSlot";
            Text = "frmParkingSlot";
            Load += frmParkingSlot_Load;
            pnButton.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private ComboBox cbxParking;
        private FlowLayoutPanel pnParkingSlot;
        private Panel pnTimer;
        private Panel pnButton;
        private Button btnCheckOut;
        private Button btnCheckIn;
    }
}