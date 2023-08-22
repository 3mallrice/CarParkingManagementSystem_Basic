namespace BookingCarParkingManagement
{
    partial class frmCustomerScreen
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
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            txtBaixeID = new TextBox();
            txtTenBaiXe = new TextBox();
            txtTongSlot = new TextBox();
            dgvListBaixe = new DataGridView();
            button1 = new Button();
            label5 = new Label();
            label6 = new Label();
            cboSearchFilter = new ComboBox();
            txtSearchBox = new TextBox();
            btnCarRegistration = new Button();
            btnParkingBooking = new Button();
            ((System.ComponentModel.ISupportInitialize)dgvListBaixe).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(12, 9);
            label1.Name = "label1";
            label1.Size = new Size(139, 20);
            label1.TabIndex = 0;
            label1.Text = "frmCustomerScreen";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(37, 57);
            label2.Name = "label2";
            label2.Size = new Size(68, 20);
            label2.TabIndex = 1;
            label2.Text = "ID Bãi xe";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(37, 95);
            label3.Name = "label3";
            label3.Size = new Size(78, 20);
            label3.TabIndex = 2;
            label3.Text = "Tên Bãi Xe";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(42, 137);
            label4.Name = "label4";
            label4.Size = new Size(73, 20);
            label4.TabIndex = 3;
            label4.Text = "Tổng Slot";
            // 
            // txtBaixeID
            // 
            txtBaixeID.Location = new Point(154, 50);
            txtBaixeID.Name = "txtBaixeID";
            txtBaixeID.Size = new Size(174, 27);
            txtBaixeID.TabIndex = 4;
            // 
            // txtTenBaiXe
            // 
            txtTenBaiXe.Location = new Point(154, 92);
            txtTenBaiXe.Name = "txtTenBaiXe";
            txtTenBaiXe.Size = new Size(174, 27);
            txtTenBaiXe.TabIndex = 5;
            // 
            // txtTongSlot
            // 
            txtTongSlot.Location = new Point(154, 134);
            txtTongSlot.Name = "txtTongSlot";
            txtTongSlot.Size = new Size(174, 27);
            txtTongSlot.TabIndex = 6;
            // 
            // dgvListBaixe
            // 
            dgvListBaixe.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvListBaixe.Location = new Point(12, 223);
            dgvListBaixe.Name = "dgvListBaixe";
            dgvListBaixe.RowHeadersWidth = 51;
            dgvListBaixe.RowTemplate.Height = 29;
            dgvListBaixe.Size = new Size(629, 188);
            dgvListBaixe.TabIndex = 7;
            // 
            // button1
            // 
            button1.Location = new Point(412, 80);
            button1.Name = "button1";
            button1.Size = new Size(137, 35);
            button1.TabIndex = 8;
            button1.Text = "Cập nhập hồ sơ";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(55, 186);
            label5.Name = "label5";
            label5.Size = new Size(73, 20);
            label5.TabIndex = 9;
            label5.Text = "Search By";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(381, 186);
            label6.Name = "label6";
            label6.Size = new Size(82, 20);
            label6.TabIndex = 10;
            label6.Text = "Search Box";
            // 
            // cboSearchFilter
            // 
            cboSearchFilter.FormattingEnabled = true;
            cboSearchFilter.Items.AddRange(new object[] { "BaixeID", "BaixeName" });
            cboSearchFilter.Location = new Point(154, 178);
            cboSearchFilter.Name = "cboSearchFilter";
            cboSearchFilter.Size = new Size(174, 28);
            cboSearchFilter.TabIndex = 11;
            cboSearchFilter.SelectedIndexChanged += cboSearchFilter_SelectedIndexChanged_1;
            // 
            // txtSearchBox
            // 
            txtSearchBox.Location = new Point(478, 179);
            txtSearchBox.Name = "txtSearchBox";
            txtSearchBox.Size = new Size(142, 27);
            txtSearchBox.TabIndex = 12;
            txtSearchBox.TextChanged += txtSearchBox_TextChanged_1;
            // 
            // btnCarRegistration
            // 
            btnCarRegistration.Location = new Point(103, 453);
            btnCarRegistration.Name = "btnCarRegistration";
            btnCarRegistration.Size = new Size(125, 29);
            btnCarRegistration.TabIndex = 13;
            btnCarRegistration.Text = "CarRegistration";
            btnCarRegistration.UseVisualStyleBackColor = true;
            btnCarRegistration.Click += btnCarRegistration_Click;
            // 
            // btnParkingBooking
            // 
            btnParkingBooking.Location = new Point(352, 453);
            btnParkingBooking.Name = "btnParkingBooking";
            btnParkingBooking.Size = new Size(145, 29);
            btnParkingBooking.TabIndex = 14;
            btnParkingBooking.Text = "Parking Booking";
            btnParkingBooking.UseVisualStyleBackColor = true;
            btnParkingBooking.Click += btnParkingBooking_Click;
            // 
            // frmCustomerScreen
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(661, 509);
            Controls.Add(btnParkingBooking);
            Controls.Add(btnCarRegistration);
            Controls.Add(txtSearchBox);
            Controls.Add(cboSearchFilter);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(button1);
            Controls.Add(dgvListBaixe);
            Controls.Add(txtTongSlot);
            Controls.Add(txtTenBaiXe);
            Controls.Add(txtBaixeID);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "frmCustomerScreen";
            Text = "frmCustomerScreen";
            Load += frmCustomerScreen_Load;
            ((System.ComponentModel.ISupportInitialize)dgvListBaixe).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private TextBox txtBaixeID;
        private TextBox txtTenBaiXe;
        private TextBox txtTongSlot;
        private DataGridView dgvListBaixe;
        private Button button1;
        private Label label5;
        private Label label6;
        private ComboBox cboSearchFilter;
        private TextBox txtSearchBox;
        private Button btnCarRegistration;
        private Button btnParkingBooking;
    }
}