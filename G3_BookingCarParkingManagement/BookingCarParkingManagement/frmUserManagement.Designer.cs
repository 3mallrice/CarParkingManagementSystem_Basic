﻿namespace BookingCarParkingManagement
{
    partial class frmUserManagement
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
            btnLoad = new Button();
            btnSearch = new Button();
            txtSearch = new TextBox();
            btnDelete = new Button();
            btnClose = new Button();
            txtStatus = new TextBox();
            label7 = new Label();
            label6 = new Label();
            txtRole = new TextBox();
            txtPhone = new TextBox();
            label5 = new Label();
            txtPassword = new TextBox();
            txtEmail = new TextBox();
            txtName = new TextBox();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            txtUserID = new TextBox();
            label1 = new Label();
            dgvUserManagement = new DataGridView();
            btnCreate = new Button();
            btnUpdate = new Button();
            ((System.ComponentModel.ISupportInitialize)dgvUserManagement).BeginInit();
            SuspendLayout();
            // 
            // btnLoad
            // 
            btnLoad.Location = new Point(12, 456);
            btnLoad.Name = "btnLoad";
            btnLoad.Size = new Size(94, 29);
            btnLoad.TabIndex = 41;
            btnLoad.Text = "Load";
            btnLoad.UseVisualStyleBackColor = true;
            btnLoad.Click += btnLoad_Click_1;
            // 
            // btnSearch
            // 
            btnSearch.Location = new Point(365, 405);
            btnSearch.Name = "btnSearch";
            btnSearch.Size = new Size(94, 29);
            btnSearch.TabIndex = 40;
            btnSearch.Text = "Search";
            btnSearch.UseVisualStyleBackColor = true;
            btnSearch.Click += btnSearch_Click;
            // 
            // txtSearch
            // 
            txtSearch.Location = new Point(465, 406);
            txtSearch.Name = "txtSearch";
            txtSearch.PlaceholderText = "Enter the user name...";
            txtSearch.Size = new Size(194, 27);
            txtSearch.TabIndex = 39;
            // 
            // btnDelete
            // 
            btnDelete.Location = new Point(150, 456);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(94, 29);
            btnDelete.TabIndex = 38;
            btnDelete.Text = "Delete";
            btnDelete.UseVisualStyleBackColor = true;
            btnDelete.Click += btnDelete_Click_1;
            // 
            // btnClose
            // 
            btnClose.Location = new Point(294, 456);
            btnClose.Name = "btnClose";
            btnClose.Size = new Size(94, 29);
            btnClose.TabIndex = 37;
            btnClose.Text = "Close";
            btnClose.UseVisualStyleBackColor = true;
            btnClose.Click += btnClose_Click_1;
            // 
            // txtStatus
            // 
            txtStatus.Location = new Point(441, 367);
            txtStatus.Name = "txtStatus";
            txtStatus.Size = new Size(218, 27);
            txtStatus.TabIndex = 35;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(365, 370);
            label7.Name = "label7";
            label7.Size = new Size(49, 20);
            label7.TabIndex = 34;
            label7.Text = "Status";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(365, 330);
            label6.Name = "label6";
            label6.Size = new Size(39, 20);
            label6.TabIndex = 33;
            label6.Text = "Role";
            // 
            // txtRole
            // 
            txtRole.Location = new Point(441, 327);
            txtRole.Name = "txtRole";
            txtRole.Size = new Size(218, 27);
            txtRole.TabIndex = 32;
            // 
            // txtPhone
            // 
            txtPhone.Location = new Point(441, 286);
            txtPhone.Name = "txtPhone";
            txtPhone.Size = new Size(218, 27);
            txtPhone.TabIndex = 31;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(365, 289);
            label5.Name = "label5";
            label5.Size = new Size(50, 20);
            label5.TabIndex = 30;
            label5.Text = "Phone";
            // 
            // txtPassword
            // 
            txtPassword.Location = new Point(95, 406);
            txtPassword.Name = "txtPassword";
            txtPassword.Size = new Size(218, 27);
            txtPassword.TabIndex = 29;
            // 
            // txtEmail
            // 
            txtEmail.Location = new Point(95, 367);
            txtEmail.Name = "txtEmail";
            txtEmail.Size = new Size(218, 27);
            txtEmail.TabIndex = 28;
            // 
            // txtName
            // 
            txtName.Location = new Point(95, 327);
            txtName.Name = "txtName";
            txtName.Size = new Size(218, 27);
            txtName.TabIndex = 27;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(12, 409);
            label4.Name = "label4";
            label4.Size = new Size(70, 20);
            label4.TabIndex = 26;
            label4.Text = "Password";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(12, 370);
            label3.Name = "label3";
            label3.Size = new Size(46, 20);
            label3.TabIndex = 25;
            label3.Text = "Email";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(12, 330);
            label2.Name = "label2";
            label2.Size = new Size(49, 20);
            label2.TabIndex = 24;
            label2.Text = "Name";
            // 
            // txtUserID
            // 
            txtUserID.Location = new Point(95, 286);
            txtUserID.Name = "txtUserID";
            txtUserID.Size = new Size(218, 27);
            txtUserID.TabIndex = 23;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(12, 289);
            label1.Name = "label1";
            label1.Size = new Size(53, 20);
            label1.TabIndex = 22;
            label1.Text = "UserID";
            // 
            // dgvUserManagement
            // 
            dgvUserManagement.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvUserManagement.Location = new Point(12, 12);
            dgvUserManagement.Name = "dgvUserManagement";
            dgvUserManagement.RowHeadersWidth = 51;
            dgvUserManagement.RowTemplate.Height = 29;
            dgvUserManagement.Size = new Size(647, 251);
            dgvUserManagement.TabIndex = 21;
            dgvUserManagement.CellContentClick += dgvUserManagement_CellClick;
            // 
            // btnCreate
            // 
            btnCreate.Location = new Point(12, 501);
            btnCreate.Name = "btnCreate";
            btnCreate.Size = new Size(94, 29);
            btnCreate.TabIndex = 42;
            btnCreate.Text = "Create";
            btnCreate.UseVisualStyleBackColor = true;
            btnCreate.Click += btnCreate_Click;
            // 
            // btnUpdate
            // 
            btnUpdate.Location = new Point(150, 501);
            btnUpdate.Name = "btnUpdate";
            btnUpdate.Size = new Size(94, 29);
            btnUpdate.TabIndex = 43;
            btnUpdate.Text = "Update";
            btnUpdate.UseVisualStyleBackColor = true;
            btnUpdate.Click += btnUpdate_Click;
            // 
            // frmUserManagement
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(671, 542);
            Controls.Add(btnUpdate);
            Controls.Add(btnCreate);
            Controls.Add(btnLoad);
            Controls.Add(btnSearch);
            Controls.Add(txtSearch);
            Controls.Add(btnDelete);
            Controls.Add(btnClose);
            Controls.Add(txtStatus);
            Controls.Add(label7);
            Controls.Add(label6);
            Controls.Add(txtRole);
            Controls.Add(txtPhone);
            Controls.Add(label5);
            Controls.Add(txtPassword);
            Controls.Add(txtEmail);
            Controls.Add(txtName);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(txtUserID);
            Controls.Add(label1);
            Controls.Add(dgvUserManagement);
            Name = "frmUserManagement";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "frmUserManagement";
            Load += frmUserManagement_Load;
            ((System.ComponentModel.ISupportInitialize)dgvUserManagement).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnLoad;
        private Button btnSearch;
        private TextBox txtSearch;
        private Button btnDelete;
        private Button btnClose;
        private TextBox txtStatus;
        private Label label7;
        private Label label6;
        private TextBox txtRole;
        private TextBox txtPhone;
        private Label label5;
        private TextBox txtPassword;
        private TextBox txtEmail;
        private TextBox txtName;
        private Label label4;
        private Label label3;
        private Label label2;
        private TextBox txtUserID;
        private Label label1;
        private DataGridView dgvUserManagement;
        private Button btnCreate;
        private Button btnUpdate;
    }
}