namespace BookingCarParkingManagement.ChildOfStaffScreen
{
    partial class frmBill
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
            label12 = new Label();
            label5 = new Label();
            lbHour = new Label();
            label3 = new Label();
            label1 = new Label();
            lbPrice = new Label();
            lbTotal = new Label();
            lbCar = new Label();
            btnOK = new Button();
            tableLayoutPanel1.SuspendLayout();
            SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.ColumnCount = 2;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 45.9064331F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 54.0935669F));
            tableLayoutPanel1.Controls.Add(label12, 0, 3);
            tableLayoutPanel1.Controls.Add(label5, 0, 2);
            tableLayoutPanel1.Controls.Add(lbHour, 1, 1);
            tableLayoutPanel1.Controls.Add(label3, 0, 1);
            tableLayoutPanel1.Controls.Add(label1, 0, 0);
            tableLayoutPanel1.Controls.Add(lbCar, 1, 0);
            tableLayoutPanel1.Controls.Add(lbPrice, 1, 2);
            tableLayoutPanel1.Controls.Add(lbTotal, 1, 3);
            tableLayoutPanel1.Location = new Point(8, 31);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 4;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 52F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 37F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            tableLayoutPanel1.Size = new Size(342, 196);
            tableLayoutPanel1.TabIndex = 0;
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label12.Location = new Point(3, 158);
            label12.Name = "label12";
            label12.Size = new Size(56, 21);
            label12.TabIndex = 11;
            label12.Text = "TOTAL";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label5.Location = new Point(3, 106);
            label5.Name = "label5";
            label5.Size = new Size(70, 21);
            label5.TabIndex = 4;
            label5.Text = "Unit Fee";
            // 
            // lbHour
            // 
            lbHour.AutoSize = true;
            lbHour.Font = new Font("Segoe UI Semibold", 14.25F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            lbHour.Location = new Point(160, 53);
            lbHour.Name = "lbHour";
            lbHour.Size = new Size(71, 25);
            lbHour.TabIndex = 3;
            lbHour.Text = "lbHour";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label3.Location = new Point(3, 53);
            label3.Name = "label3";
            label3.Size = new Size(46, 21);
            label3.TabIndex = 2;
            label3.Text = "Time";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(3, 0);
            label1.Name = "label1";
            label1.Size = new Size(34, 21);
            label1.TabIndex = 0;
            label1.Text = "Car";
            // 
            // lbPrice
            // 
            lbPrice.AutoSize = true;
            lbPrice.Font = new Font("Segoe UI Semibold", 14.25F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            lbPrice.Location = new Point(160, 106);
            lbPrice.Name = "lbPrice";
            lbPrice.Size = new Size(106, 25);
            lbPrice.TabIndex = 8;
            lbPrice.Text = "lbUnitPrice";
            // 
            // lbTotal
            // 
            lbTotal.AutoSize = true;
            lbTotal.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point);
            lbTotal.ForeColor = Color.Red;
            lbTotal.Location = new Point(160, 158);
            lbTotal.Name = "lbTotal";
            lbTotal.Size = new Size(80, 30);
            lbTotal.TabIndex = 9;
            lbTotal.Text = "lbTotal";
            // 
            // lbCar
            // 
            lbCar.AutoSize = true;
            lbCar.Font = new Font("Segoe UI Semibold", 14.25F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            lbCar.Location = new Point(160, 0);
            lbCar.Name = "lbCar";
            lbCar.Size = new Size(58, 25);
            lbCar.TabIndex = 1;
            lbCar.Text = "lbCar";
            // 
            // btnOK
            // 
            btnOK.Location = new Point(141, 245);
            btnOK.Name = "btnOK";
            btnOK.Size = new Size(84, 36);
            btnOK.TabIndex = 1;
            btnOK.Text = "OK";
            btnOK.UseVisualStyleBackColor = true;
            btnOK.Click += btnOK_Click;
            // 
            // frmBill
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(362, 293);
            Controls.Add(btnOK);
            Controls.Add(tableLayoutPanel1);
            Name = "frmBill";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "frmBill";
            Load += frmBill_Load;
            tableLayoutPanel1.ResumeLayout(false);
            tableLayoutPanel1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private TableLayoutPanel tableLayoutPanel1;
        private Label label12;
        private Label label5;
        private Label lbHour;
        private Label label3;
        private Label lbCar;
        private Label label1;
        private Label lbPrice;
        private Label lbTotal;
        private Button btnOK;
    }
}