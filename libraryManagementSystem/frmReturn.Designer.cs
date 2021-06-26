
namespace libraryManagementSystem
{
    partial class frmReturn
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmReturn));
            this.lblBookTitle = new System.Windows.Forms.Label();
            this.lblAuthor = new System.Windows.Forms.Label();
            this.lblPublisher = new System.Windows.Forms.Label();
            this.btnSearchBookID = new System.Windows.Forms.Button();
            this.txtBookID = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.grbBook = new System.Windows.Forms.GroupBox();
            this.label3 = new System.Windows.Forms.Label();
            this.grbMember = new System.Windows.Forms.GroupBox();
            this.lblName = new System.Windows.Forms.Label();
            this.lblTelephone = new System.Windows.Forms.Label();
            this.lblAddress = new System.Windows.Forms.Label();
            this.btnSearchMemberID = new System.Windows.Forms.Button();
            this.txtMemberID = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.btnExit = new System.Windows.Forms.Button();
            this.lblDateBR = new System.Windows.Forms.Label();
            this.lblUserBR = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btnHome = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.btnIssue = new System.Windows.Forms.Button();
            this.txtIssueID = new System.Windows.Forms.TextBox();
            this.grbReturn = new System.Windows.Forms.GroupBox();
            this.lblIssueDate = new System.Windows.Forms.Label();
            this.lblReturnDate = new System.Windows.Forms.Label();
            this.btnSearchIssueID = new System.Windows.Forms.Button();
            this.btnClear = new System.Windows.Forms.Button();
            this.lblUserTypeBR = new System.Windows.Forms.Label();
            this.grbBook.SuspendLayout();
            this.grbMember.SuspendLayout();
            this.grbReturn.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblBookTitle
            // 
            this.lblBookTitle.AutoSize = true;
            this.lblBookTitle.Location = new System.Drawing.Point(103, 88);
            this.lblBookTitle.Name = "lblBookTitle";
            this.lblBookTitle.Size = new System.Drawing.Size(13, 17);
            this.lblBookTitle.TabIndex = 4;
            this.lblBookTitle.Text = "-";
            // 
            // lblAuthor
            // 
            this.lblAuthor.AutoSize = true;
            this.lblAuthor.Location = new System.Drawing.Point(103, 124);
            this.lblAuthor.Name = "lblAuthor";
            this.lblAuthor.Size = new System.Drawing.Size(13, 17);
            this.lblAuthor.TabIndex = 5;
            this.lblAuthor.Text = "-";
            // 
            // lblPublisher
            // 
            this.lblPublisher.AutoSize = true;
            this.lblPublisher.Location = new System.Drawing.Point(103, 159);
            this.lblPublisher.Name = "lblPublisher";
            this.lblPublisher.Size = new System.Drawing.Size(13, 17);
            this.lblPublisher.TabIndex = 6;
            this.lblPublisher.Text = "-";
            // 
            // btnSearchBookID
            // 
            this.btnSearchBookID.Image = ((System.Drawing.Image)(resources.GetObject("btnSearchBookID.Image")));
            this.btnSearchBookID.Location = new System.Drawing.Point(213, 36);
            this.btnSearchBookID.Name = "btnSearchBookID";
            this.btnSearchBookID.Size = new System.Drawing.Size(30, 23);
            this.btnSearchBookID.TabIndex = 5;
            this.btnSearchBookID.UseVisualStyleBackColor = true;
            // 
            // txtBookID
            // 
            this.txtBookID.Location = new System.Drawing.Point(106, 37);
            this.txtBookID.Name = "txtBookID";
            this.txtBookID.Size = new System.Drawing.Size(100, 22);
            this.txtBookID.TabIndex = 4;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(11, 159);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(67, 17);
            this.label5.TabIndex = 3;
            this.label5.Text = "Publisher";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(11, 124);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(50, 17);
            this.label4.TabIndex = 2;
            this.label4.Text = "Author";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(11, 42);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(57, 17);
            this.label2.TabIndex = 0;
            this.label2.Text = "Book ID";
            // 
            // grbBook
            // 
            this.grbBook.Controls.Add(this.lblBookTitle);
            this.grbBook.Controls.Add(this.lblAuthor);
            this.grbBook.Controls.Add(this.lblPublisher);
            this.grbBook.Controls.Add(this.btnSearchBookID);
            this.grbBook.Controls.Add(this.txtBookID);
            this.grbBook.Controls.Add(this.label5);
            this.grbBook.Controls.Add(this.label4);
            this.grbBook.Controls.Add(this.label3);
            this.grbBook.Controls.Add(this.label2);
            this.grbBook.Location = new System.Drawing.Point(76, 185);
            this.grbBook.Name = "grbBook";
            this.grbBook.Size = new System.Drawing.Size(366, 190);
            this.grbBook.TabIndex = 24;
            this.grbBook.TabStop = false;
            this.grbBook.Text = "Book";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(11, 88);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(71, 17);
            this.label3.TabIndex = 1;
            this.label3.Text = "Book Title";
            // 
            // grbMember
            // 
            this.grbMember.Controls.Add(this.lblName);
            this.grbMember.Controls.Add(this.lblTelephone);
            this.grbMember.Controls.Add(this.lblAddress);
            this.grbMember.Controls.Add(this.btnSearchMemberID);
            this.grbMember.Controls.Add(this.txtMemberID);
            this.grbMember.Controls.Add(this.label9);
            this.grbMember.Controls.Add(this.label10);
            this.grbMember.Controls.Add(this.label11);
            this.grbMember.Controls.Add(this.label12);
            this.grbMember.Location = new System.Drawing.Point(76, 427);
            this.grbMember.Name = "grbMember";
            this.grbMember.Size = new System.Drawing.Size(366, 190);
            this.grbMember.TabIndex = 25;
            this.grbMember.TabStop = false;
            this.grbMember.Text = "Member";
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Location = new System.Drawing.Point(103, 88);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(13, 17);
            this.lblName.TabIndex = 4;
            this.lblName.Text = "-";
            // 
            // lblTelephone
            // 
            this.lblTelephone.AutoSize = true;
            this.lblTelephone.Location = new System.Drawing.Point(103, 124);
            this.lblTelephone.Name = "lblTelephone";
            this.lblTelephone.Size = new System.Drawing.Size(13, 17);
            this.lblTelephone.TabIndex = 5;
            this.lblTelephone.Text = "-";
            // 
            // lblAddress
            // 
            this.lblAddress.AutoSize = true;
            this.lblAddress.Location = new System.Drawing.Point(103, 159);
            this.lblAddress.Name = "lblAddress";
            this.lblAddress.Size = new System.Drawing.Size(13, 17);
            this.lblAddress.TabIndex = 6;
            this.lblAddress.Text = "-";
            // 
            // btnSearchMemberID
            // 
            this.btnSearchMemberID.Image = ((System.Drawing.Image)(resources.GetObject("btnSearchMemberID.Image")));
            this.btnSearchMemberID.Location = new System.Drawing.Point(213, 36);
            this.btnSearchMemberID.Name = "btnSearchMemberID";
            this.btnSearchMemberID.Size = new System.Drawing.Size(30, 23);
            this.btnSearchMemberID.TabIndex = 5;
            this.btnSearchMemberID.UseVisualStyleBackColor = true;
            // 
            // txtMemberID
            // 
            this.txtMemberID.Location = new System.Drawing.Point(106, 37);
            this.txtMemberID.Name = "txtMemberID";
            this.txtMemberID.Size = new System.Drawing.Size(100, 22);
            this.txtMemberID.TabIndex = 4;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(11, 159);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(60, 17);
            this.label9.TabIndex = 3;
            this.label9.Text = "Address";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(11, 124);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(76, 17);
            this.label10.TabIndex = 2;
            this.label10.Text = "Telephone";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(11, 88);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(45, 17);
            this.label11.TabIndex = 1;
            this.label11.Text = "Name";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(11, 42);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(76, 17);
            this.label12.TabIndex = 0;
            this.label12.Text = "Member ID";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(11, 144);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(85, 17);
            this.label14.TabIndex = 2;
            this.label14.Text = "Return Date";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(11, 97);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(75, 17);
            this.label15.TabIndex = 1;
            this.label15.Text = "Issue Date";
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(11, 42);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(58, 17);
            this.label16.TabIndex = 0;
            this.label16.Text = "Issue ID";
            // 
            // btnExit
            // 
            this.btnExit.Location = new System.Drawing.Point(721, 563);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(78, 26);
            this.btnExit.TabIndex = 32;
            this.btnExit.Text = "Exit";
            this.btnExit.UseVisualStyleBackColor = true;
            // 
            // lblDateBR
            // 
            this.lblDateBR.AutoSize = true;
            this.lblDateBR.Location = new System.Drawing.Point(753, 38);
            this.lblDateBR.Name = "lblDateBR";
            this.lblDateBR.Size = new System.Drawing.Size(38, 17);
            this.lblDateBR.TabIndex = 23;
            this.lblDateBR.Text = "Date";
            // 
            // lblUserBR
            // 
            this.lblUserBR.AutoSize = true;
            this.lblUserBR.Location = new System.Drawing.Point(37, 38);
            this.lblUserBR.Name = "lblUserBR";
            this.lblUserBR.Size = new System.Drawing.Size(38, 17);
            this.lblUserBR.TabIndex = 22;
            this.lblUserBR.Text = "User";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(420, 85);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(87, 17);
            this.label1.TabIndex = 21;
            this.label1.Text = "Book Return";
            // 
            // btnHome
            // 
            this.btnHome.Location = new System.Drawing.Point(539, 563);
            this.btnHome.Name = "btnHome";
            this.btnHome.Size = new System.Drawing.Size(78, 26);
            this.btnHome.TabIndex = 31;
            this.btnHome.Text = "Home";
            this.btnHome.UseVisualStyleBackColor = true;
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(721, 502);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(78, 26);
            this.btnDelete.TabIndex = 30;
            this.btnDelete.Text = "Delete";
            this.btnDelete.UseVisualStyleBackColor = true;
            // 
            // btnUpdate
            // 
            this.btnUpdate.Location = new System.Drawing.Point(539, 502);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(78, 26);
            this.btnUpdate.TabIndex = 29;
            this.btnUpdate.Text = "Update";
            this.btnUpdate.UseVisualStyleBackColor = true;
            // 
            // btnIssue
            // 
            this.btnIssue.Location = new System.Drawing.Point(539, 438);
            this.btnIssue.Name = "btnIssue";
            this.btnIssue.Size = new System.Drawing.Size(78, 26);
            this.btnIssue.TabIndex = 27;
            this.btnIssue.Text = "Issue";
            this.btnIssue.UseVisualStyleBackColor = true;
            // 
            // txtIssueID
            // 
            this.txtIssueID.Location = new System.Drawing.Point(106, 37);
            this.txtIssueID.Name = "txtIssueID";
            this.txtIssueID.Size = new System.Drawing.Size(100, 22);
            this.txtIssueID.TabIndex = 4;
            // 
            // grbReturn
            // 
            this.grbReturn.Controls.Add(this.lblIssueDate);
            this.grbReturn.Controls.Add(this.lblReturnDate);
            this.grbReturn.Controls.Add(this.btnSearchIssueID);
            this.grbReturn.Controls.Add(this.txtIssueID);
            this.grbReturn.Controls.Add(this.label14);
            this.grbReturn.Controls.Add(this.label15);
            this.grbReturn.Controls.Add(this.label16);
            this.grbReturn.Location = new System.Drawing.Point(475, 185);
            this.grbReturn.Name = "grbReturn";
            this.grbReturn.Size = new System.Drawing.Size(366, 190);
            this.grbReturn.TabIndex = 26;
            this.grbReturn.TabStop = false;
            this.grbReturn.Text = "Return";
            // 
            // lblIssueDate
            // 
            this.lblIssueDate.AutoSize = true;
            this.lblIssueDate.Location = new System.Drawing.Point(103, 97);
            this.lblIssueDate.Name = "lblIssueDate";
            this.lblIssueDate.Size = new System.Drawing.Size(13, 17);
            this.lblIssueDate.TabIndex = 4;
            this.lblIssueDate.Text = "-";
            // 
            // lblReturnDate
            // 
            this.lblReturnDate.AutoSize = true;
            this.lblReturnDate.Location = new System.Drawing.Point(103, 144);
            this.lblReturnDate.Name = "lblReturnDate";
            this.lblReturnDate.Size = new System.Drawing.Size(13, 17);
            this.lblReturnDate.TabIndex = 5;
            this.lblReturnDate.Text = "-";
            // 
            // btnSearchIssueID
            // 
            this.btnSearchIssueID.Image = ((System.Drawing.Image)(resources.GetObject("btnSearchIssueID.Image")));
            this.btnSearchIssueID.Location = new System.Drawing.Point(213, 36);
            this.btnSearchIssueID.Name = "btnSearchIssueID";
            this.btnSearchIssueID.Size = new System.Drawing.Size(30, 23);
            this.btnSearchIssueID.TabIndex = 5;
            this.btnSearchIssueID.UseVisualStyleBackColor = true;
            // 
            // btnClear
            // 
            this.btnClear.Location = new System.Drawing.Point(721, 438);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(78, 26);
            this.btnClear.TabIndex = 28;
            this.btnClear.Text = "Clear";
            this.btnClear.UseVisualStyleBackColor = true;
            // 
            // lblUserTypeBR
            // 
            this.lblUserTypeBR.AutoSize = true;
            this.lblUserTypeBR.Location = new System.Drawing.Point(37, 67);
            this.lblUserTypeBR.Name = "lblUserTypeBR";
            this.lblUserTypeBR.Size = new System.Drawing.Size(74, 17);
            this.lblUserTypeBR.TabIndex = 33;
            this.lblUserTypeBR.Text = "User Type";
            // 
            // frmReturn
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(914, 673);
            this.Controls.Add(this.lblUserTypeBR);
            this.Controls.Add(this.grbBook);
            this.Controls.Add(this.grbMember);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.lblDateBR);
            this.Controls.Add(this.lblUserBR);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnHome);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnUpdate);
            this.Controls.Add(this.btnIssue);
            this.Controls.Add(this.grbReturn);
            this.Controls.Add(this.btnClear);
            this.Name = "frmReturn";
            this.Text = "Book Return";
            this.grbBook.ResumeLayout(false);
            this.grbBook.PerformLayout();
            this.grbMember.ResumeLayout(false);
            this.grbMember.PerformLayout();
            this.grbReturn.ResumeLayout(false);
            this.grbReturn.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblBookTitle;
        private System.Windows.Forms.Label lblAuthor;
        private System.Windows.Forms.Label lblPublisher;
        private System.Windows.Forms.Button btnSearchBookID;
        private System.Windows.Forms.TextBox txtBookID;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.GroupBox grbBook;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.GroupBox grbMember;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.Label lblTelephone;
        private System.Windows.Forms.Label lblAddress;
        private System.Windows.Forms.Button btnSearchMemberID;
        private System.Windows.Forms.TextBox txtMemberID;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Button btnExit;
        public System.Windows.Forms.Label lblDateBR;
        public System.Windows.Forms.Label lblUserBR;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnHome;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.Button btnIssue;
        private System.Windows.Forms.TextBox txtIssueID;
        private System.Windows.Forms.GroupBox grbReturn;
        private System.Windows.Forms.Label lblIssueDate;
        private System.Windows.Forms.Label lblReturnDate;
        private System.Windows.Forms.Button btnSearchIssueID;
        private System.Windows.Forms.Button btnClear;
        public System.Windows.Forms.Label lblUserTypeBR;
    }
}