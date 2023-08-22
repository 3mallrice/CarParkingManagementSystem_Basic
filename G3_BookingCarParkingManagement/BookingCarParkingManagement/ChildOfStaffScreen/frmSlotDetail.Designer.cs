namespace BookingCarParkingManagement.ChildOfStaffScreen
{
    partial class frmSlotDetail
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
            tableLayoutPanel1 = new TableLayoutPanel();
            dtpEnd = new DateTimePicker();
            dtpStart = new DateTimePicker();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            label7 = new Label();
            label8 = new Label();
            txtParking = new TextBox();
            dtpBook = new DateTimePicker();
            txtStatus = new TextBox();
            txtSlot = new TextBox();
            cbxCar = new ComboBox();
            lbTitle = new Label();
            pnButton = new Panel();
            btnCancel = new Button();
            btnCheck = new Button();
            tableLayoutPanel1.SuspendLayout();
            pnButton.SuspendLayout();
            SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.ColumnCount = 2;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 40.16854F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 59.83146F));
            tableLayoutPanel1.Controls.Add(dtpEnd, 1, 5);
            tableLayoutPanel1.Controls.Add(dtpStart, 1, 4);
            tableLayoutPanel1.Controls.Add(label2, 0, 0);
            tableLayoutPanel1.Controls.Add(label3, 0, 1);
            tableLayoutPanel1.Controls.Add(label4, 0, 2);
            tableLayoutPanel1.Controls.Add(label5, 0, 3);
            tableLayoutPanel1.Controls.Add(label6, 0, 4);
            tableLayoutPanel1.Controls.Add(label7, 0, 5);
            tableLayoutPanel1.Controls.Add(label8, 0, 6);
            tableLayoutPanel1.Controls.Add(txtParking, 1, 0);
            tableLayoutPanel1.Controls.Add(dtpBook, 1, 3);
            tableLayoutPanel1.Controls.Add(txtStatus, 1, 6);
            tableLayoutPanel1.Controls.Add(txtSlot, 1, 1);
            tableLayoutPanel1.Controls.Add(cbxCar, 1, 2);
            tableLayoutPanel1.Location = new Point(12, 42);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 7;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 51.6666679F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 48.3333321F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 33F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 32F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 33F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 31F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 31F));
            tableLayoutPanel1.Size = new Size(356, 226);
            tableLayoutPanel1.TabIndex = 0;
            // 
            // dtpEnd
            // 
            dtpEnd.Location = new Point(146, 166);
            dtpEnd.Name = "dtpEnd";
            dtpEnd.Size = new Size(207, 23);
            dtpEnd.TabIndex = 12;
            // 
            // dtpStart
            // 
            dtpStart.Location = new Point(146, 133);
            dtpStart.Name = "dtpStart";
            dtpStart.Size = new Size(207, 23);
            dtpStart.TabIndex = 11;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label2.Location = new Point(3, 0);
            label2.Name = "label2";
            label2.Size = new Size(69, 21);
            label2.TabIndex = 0;
            label2.Text = "Parking";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label3.Location = new Point(3, 34);
            label3.Name = "label3";
            label3.Size = new Size(40, 21);
            label3.TabIndex = 1;
            label3.Text = "Slot";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label4.Location = new Point(3, 65);
            label4.Name = "label4";
            label4.Size = new Size(99, 21);
            label4.TabIndex = 2;
            label4.Text = "Car number";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label5.Location = new Point(3, 98);
            label5.Name = "label5";
            label5.Size = new Size(113, 21);
            label5.TabIndex = 3;
            label5.Text = "Booking time";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label6.Location = new Point(3, 130);
            label6.Name = "label6";
            label6.Size = new Size(85, 21);
            label6.TabIndex = 4;
            label6.Text = "Start time";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label7.Location = new Point(3, 163);
            label7.Name = "label7";
            label7.Size = new Size(78, 21);
            label7.TabIndex = 5;
            label7.Text = "End time";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label8.Location = new Point(3, 194);
            label8.Name = "label8";
            label8.Size = new Size(57, 21);
            label8.TabIndex = 6;
            label8.Text = "Status";
            // 
            // txtParking
            // 
            txtParking.Location = new Point(146, 3);
            txtParking.Name = "txtParking";
            txtParking.Size = new Size(207, 23);
            txtParking.TabIndex = 7;
            // 
            // dtpBook
            // 
            dtpBook.Location = new Point(146, 101);
            dtpBook.Name = "dtpBook";
            dtpBook.Size = new Size(207, 23);
            dtpBook.TabIndex = 10;
            // 
            // txtStatus
            // 
            txtStatus.Location = new Point(146, 197);
            txtStatus.Name = "txtStatus";
            txtStatus.Size = new Size(207, 23);
            txtStatus.TabIndex = 13;
            // 
            // txtSlot
            // 
            txtSlot.Location = new Point(146, 37);
            txtSlot.Name = "txtSlot";
            txtSlot.Size = new Size(207, 23);
            txtSlot.TabIndex = 14;
            // 
            // cbxCar
            // 
            cbxCar.FormattingEnabled = true;
            cbxCar.Location = new Point(146, 68);
            cbxCar.Name = "cbxCar";
            cbxCar.Size = new Size(207, 23);
            cbxCar.TabIndex = 15;
            // 
            // lbTitle
            // 
            lbTitle.AutoSize = true;
            lbTitle.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point);
            lbTitle.Location = new Point(158, 9);
            lbTitle.Name = "lbTitle";
            lbTitle.Size = new Size(56, 30);
            lbTitle.TabIndex = 0;
            lbTitle.Text = "Title";
            // 
            // pnButton
            // 
            pnButton.Controls.Add(btnCancel);
            pnButton.Controls.Add(btnCheck);
            pnButton.Location = new Point(16, 284);
            pnButton.Name = "pnButton";
            pnButton.Size = new Size(346, 48);
            pnButton.TabIndex = 1;
            // 
            // btnCancel
            // 
            btnCancel.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            btnCancel.Location = new Point(180, 3);
            btnCancel.Name = "btnCancel";
            btnCancel.Size = new Size(97, 40);
            btnCancel.TabIndex = 1;
            btnCancel.Text = "Cancel";
            btnCancel.UseVisualStyleBackColor = true;
            btnCancel.Click += btnCancel_Click;
            // 
            // btnCheck
            // 
            btnCheck.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            btnCheck.Location = new Point(40, 3);
            btnCheck.Name = "btnCheck";
            btnCheck.Size = new Size(97, 40);
            btnCheck.TabIndex = 0;
            btnCheck.Text = "Check In";
            btnCheck.UseVisualStyleBackColor = true;
            btnCheck.Click += btnCheck_Click;
            // 
            // frmSlotDetail
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(379, 341);
            Controls.Add(pnButton);
            Controls.Add(lbTitle);
            Controls.Add(tableLayoutPanel1);
            Name = "frmSlotDetail";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "frmSlotDetail";
            FormClosed += frmSlotDetail_FormClosed;
            Load += frmSlotDetail_Load;
            tableLayoutPanel1.ResumeLayout(false);
            tableLayoutPanel1.PerformLayout();
            pnButton.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TableLayoutPanel tableLayoutPanel1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
        private Label label7;
        private Label label8;
        private Label lbTitle;
        private Panel pnButton;
        private Button btnCancel;
        private Button btnCheck;
        private TextBox txtParking;
        private DateTimePicker dtpEnd;
        private DateTimePicker dtpStart;
        private DateTimePicker dtpBook;
        private TextBox txtStatus;
        private TextBox txtSlot;
        private ComboBox cbxCar;
    }
}