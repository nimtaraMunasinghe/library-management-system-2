
namespace libraryManagementSystem
{
    partial class frmMemberManagement
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMemberManagement));
            this.btnHome = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.btnClear = new System.Windows.Forms.Button();
            this.btnAdd = new System.Windows.Forms.Button();
            this.txtMemberID = new System.Windows.Forms.TextBox();
            this.txtGuardianName = new System.Windows.Forms.TextBox();
            this.txtAddress = new System.Windows.Forms.TextBox();
            this.txtContactNumber = new System.Windows.Forms.TextBox();
            this.txtMemberName = new System.Windows.Forms.TextBox();
            this.lblGurdian = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.lblDateMM = new System.Windows.Forms.Label();
            this.lblUserMM = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.lblUserTypeMM = new System.Windows.Forms.Label();
            this.pnlMemberType = new System.Windows.Forms.Panel();
            this.rbtnStudent = new System.Windows.Forms.RadioButton();
            this.rbtnStaff = new System.Windows.Forms.RadioButton();
            this.btnSearchMemberID = new System.Windows.Forms.Button();
            this.btnSearchMemberName = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.pnlMemberType.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnHome
            // 
            this.btnHome.Location = new System.Drawing.Point(330, 566);
            this.btnHome.Name = "btnHome";
            this.btnHome.Size = new System.Drawing.Size(94, 29);
            this.btnHome.TabIndex = 41;
            this.btnHome.Text = "Home";
            this.btnHome.UseVisualStyleBackColor = true;
            this.btnHome.Click += new System.EventHandler(this.btnHome_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(498, 510);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(94, 29);
            this.btnDelete.TabIndex = 40;
            this.btnDelete.Text = "Delete";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnUpdate
            // 
            this.btnUpdate.Location = new System.Drawing.Point(330, 510);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(94, 29);
            this.btnUpdate.TabIndex = 39;
            this.btnUpdate.Text = "Update";
            this.btnUpdate.UseVisualStyleBackColor = true;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // btnClear
            // 
            this.btnClear.Location = new System.Drawing.Point(172, 566);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(94, 29);
            this.btnClear.TabIndex = 37;
            this.btnClear.Text = "Clear";
            this.btnClear.UseVisualStyleBackColor = true;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(172, 510);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(94, 29);
            this.btnAdd.TabIndex = 36;
            this.btnAdd.Text = "Add";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // txtMemberID
            // 
            this.txtMemberID.Location = new System.Drawing.Point(310, 205);
            this.txtMemberID.Name = "txtMemberID";
            this.txtMemberID.Size = new System.Drawing.Size(271, 22);
            this.txtMemberID.TabIndex = 35;
            // 
            // txtGuardianName
            // 
            this.txtGuardianName.Location = new System.Drawing.Point(310, 432);
            this.txtGuardianName.Name = "txtGuardianName";
            this.txtGuardianName.Size = new System.Drawing.Size(271, 22);
            this.txtGuardianName.TabIndex = 34;
            this.txtGuardianName.Visible = false;
            // 
            // txtAddress
            // 
            this.txtAddress.Location = new System.Drawing.Point(310, 334);
            this.txtAddress.Name = "txtAddress";
            this.txtAddress.Size = new System.Drawing.Size(271, 22);
            this.txtAddress.TabIndex = 32;
            // 
            // txtContactNumber
            // 
            this.txtContactNumber.Location = new System.Drawing.Point(310, 290);
            this.txtContactNumber.Name = "txtContactNumber";
            this.txtContactNumber.Size = new System.Drawing.Size(271, 22);
            this.txtContactNumber.TabIndex = 31;
            // 
            // txtMemberName
            // 
            this.txtMemberName.Location = new System.Drawing.Point(310, 248);
            this.txtMemberName.Name = "txtMemberName";
            this.txtMemberName.Size = new System.Drawing.Size(271, 22);
            this.txtMemberName.TabIndex = 30;
            // 
            // lblGurdian
            // 
            this.lblGurdian.AutoSize = true;
            this.lblGurdian.Location = new System.Drawing.Point(114, 437);
            this.lblGurdian.Name = "lblGurdian";
            this.lblGurdian.Size = new System.Drawing.Size(108, 17);
            this.lblGurdian.TabIndex = 29;
            this.lblGurdian.Text = "Guardian Name";
            this.lblGurdian.Visible = false;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(114, 381);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(95, 17);
            this.label6.TabIndex = 28;
            this.label6.Text = "Member Type";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(114, 339);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(60, 17);
            this.label5.TabIndex = 27;
            this.label5.Text = "Address";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(114, 295);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(110, 17);
            this.label4.TabIndex = 26;
            this.label4.Text = "Contact Number";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(114, 253);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(45, 17);
            this.label3.TabIndex = 25;
            this.label3.Text = "Name";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(114, 210);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(76, 17);
            this.label2.TabIndex = 24;
            this.label2.Text = "Member ID";
            // 
            // lblDateMM
            // 
            this.lblDateMM.AutoSize = true;
            this.lblDateMM.Location = new System.Drawing.Point(633, 33);
            this.lblDateMM.Name = "lblDateMM";
            this.lblDateMM.Size = new System.Drawing.Size(38, 17);
            this.lblDateMM.TabIndex = 23;
            this.lblDateMM.Text = "Date";
            // 
            // lblUserMM
            // 
            this.lblUserMM.AutoSize = true;
            this.lblUserMM.Location = new System.Drawing.Point(45, 33);
            this.lblUserMM.Name = "lblUserMM";
            this.lblUserMM.Size = new System.Drawing.Size(38, 17);
            this.lblUserMM.TabIndex = 22;
            this.lblUserMM.Text = "User";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(307, 119);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(145, 17);
            this.label1.TabIndex = 21;
            this.label1.Text = "Member Management";
            // 
            // lblUserTypeMM
            // 
            this.lblUserTypeMM.AutoSize = true;
            this.lblUserTypeMM.Location = new System.Drawing.Point(45, 64);
            this.lblUserTypeMM.Name = "lblUserTypeMM";
            this.lblUserTypeMM.Size = new System.Drawing.Size(74, 17);
            this.lblUserTypeMM.TabIndex = 42;
            this.lblUserTypeMM.Text = "User Type";
            // 
            // pnlMemberType
            // 
            this.pnlMemberType.Controls.Add(this.rbtnStudent);
            this.pnlMemberType.Controls.Add(this.rbtnStaff);
            this.pnlMemberType.Location = new System.Drawing.Point(310, 362);
            this.pnlMemberType.Name = "pnlMemberType";
            this.pnlMemberType.Size = new System.Drawing.Size(271, 52);
            this.pnlMemberType.TabIndex = 45;
            // 
            // rbtnStudent
            // 
            this.rbtnStudent.AutoSize = true;
            this.rbtnStudent.Location = new System.Drawing.Point(20, 15);
            this.rbtnStudent.Name = "rbtnStudent";
            this.rbtnStudent.Size = new System.Drawing.Size(78, 21);
            this.rbtnStudent.TabIndex = 46;
            this.rbtnStudent.TabStop = true;
            this.rbtnStudent.Text = "Student";
            this.rbtnStudent.UseVisualStyleBackColor = true;
            this.rbtnStudent.CheckedChanged += new System.EventHandler(this.rbtnStudent_CheckedChanged);
            // 
            // rbtnStaff
            // 
            this.rbtnStaff.AutoSize = true;
            this.rbtnStaff.Location = new System.Drawing.Point(148, 15);
            this.rbtnStaff.Name = "rbtnStaff";
            this.rbtnStaff.Size = new System.Drawing.Size(58, 21);
            this.rbtnStaff.TabIndex = 47;
            this.rbtnStaff.TabStop = true;
            this.rbtnStaff.Text = "Staff";
            this.rbtnStaff.UseVisualStyleBackColor = true;
            this.rbtnStaff.CheckedChanged += new System.EventHandler(this.rbtnStaff_CheckedChanged);
            // 
            // btnSearchMemberID
            // 
            this.btnSearchMemberID.Image = ((System.Drawing.Image)(resources.GetObject("btnSearchMemberID.Image")));
            this.btnSearchMemberID.Location = new System.Drawing.Point(596, 200);
            this.btnSearchMemberID.Name = "btnSearchMemberID";
            this.btnSearchMemberID.Size = new System.Drawing.Size(37, 30);
            this.btnSearchMemberID.TabIndex = 46;
            this.btnSearchMemberID.UseVisualStyleBackColor = true;
            this.btnSearchMemberID.Click += new System.EventHandler(this.btnSearchMemberID_Click);
            // 
            // btnSearchMemberName
            // 
            this.btnSearchMemberName.Image = ((System.Drawing.Image)(resources.GetObject("btnSearchMemberName.Image")));
            this.btnSearchMemberName.Location = new System.Drawing.Point(596, 248);
            this.btnSearchMemberName.Name = "btnSearchMemberName";
            this.btnSearchMemberName.Size = new System.Drawing.Size(37, 30);
            this.btnSearchMemberName.TabIndex = 48;
            this.btnSearchMemberName.UseVisualStyleBackColor = true;
            this.btnSearchMemberName.Click += new System.EventHandler(this.btnSearchMemberName_Click);
            // 
            // btnExit
            // 
            this.btnExit.Location = new System.Drawing.Point(498, 566);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(94, 29);
            this.btnExit.TabIndex = 49;
            this.btnExit.Text = "Exit";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // frmMemberManagement
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(785, 625);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.btnSearchMemberName);
            this.Controls.Add(this.btnSearchMemberID);
            this.Controls.Add(this.pnlMemberType);
            this.Controls.Add(this.lblUserTypeMM);
            this.Controls.Add(this.btnHome);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnUpdate);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.txtMemberID);
            this.Controls.Add(this.txtGuardianName);
            this.Controls.Add(this.txtAddress);
            this.Controls.Add(this.txtContactNumber);
            this.Controls.Add(this.txtMemberName);
            this.Controls.Add(this.lblGurdian);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lblDateMM);
            this.Controls.Add(this.lblUserMM);
            this.Controls.Add(this.label1);
            this.Name = "frmMemberManagement";
            this.Text = "Member Management";
            this.Load += new System.EventHandler(this.frmMemberManagement_Load);
            this.pnlMemberType.ResumeLayout(false);
            this.pnlMemberType.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnHome;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.TextBox txtMemberID;
        private System.Windows.Forms.TextBox txtGuardianName;
        private System.Windows.Forms.TextBox txtAddress;
        private System.Windows.Forms.TextBox txtContactNumber;
        private System.Windows.Forms.TextBox txtMemberName;
        private System.Windows.Forms.Label lblGurdian;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        public System.Windows.Forms.Label lblDateMM;
        public System.Windows.Forms.Label lblUserMM;
        private System.Windows.Forms.Label label1;
        public System.Windows.Forms.Label lblUserTypeMM;
        private System.Windows.Forms.Panel pnlMemberType;
        private System.Windows.Forms.RadioButton rbtnStudent;
        private System.Windows.Forms.RadioButton rbtnStaff;
        private System.Windows.Forms.Button btnSearchMemberID;
        private System.Windows.Forms.Button btnSearchMemberName;
        private System.Windows.Forms.Button btnExit;
    }
}