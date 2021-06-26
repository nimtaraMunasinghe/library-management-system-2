
namespace libraryManagementSystem
{
    partial class frmHome
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
            this.lblDateHome = new System.Windows.Forms.Label();
            this.lblUserHome = new System.Windows.Forms.Label();
            this.btnExit = new System.Windows.Forms.Button();
            this.btnUser = new System.Windows.Forms.Button();
            this.btnReturn = new System.Windows.Forms.Button();
            this.btnIssue = new System.Windows.Forms.Button();
            this.btnBook = new System.Windows.Forms.Button();
            this.btnMember = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.lblUserTypeHome = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblDateHome
            // 
            this.lblDateHome.AutoSize = true;
            this.lblDateHome.Location = new System.Drawing.Point(605, 37);
            this.lblDateHome.Name = "lblDateHome";
            this.lblDateHome.Size = new System.Drawing.Size(38, 17);
            this.lblDateHome.TabIndex = 17;
            this.lblDateHome.Text = "Date";
            // 
            // lblUserHome
            // 
            this.lblUserHome.AutoSize = true;
            this.lblUserHome.Location = new System.Drawing.Point(46, 37);
            this.lblUserHome.Name = "lblUserHome";
            this.lblUserHome.Size = new System.Drawing.Size(38, 17);
            this.lblUserHome.TabIndex = 16;
            this.lblUserHome.Text = "User";
            // 
            // btnExit
            // 
            this.btnExit.Location = new System.Drawing.Point(417, 357);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(187, 23);
            this.btnExit.TabIndex = 15;
            this.btnExit.Text = "Exit";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // btnUser
            // 
            this.btnUser.Location = new System.Drawing.Point(151, 357);
            this.btnUser.Name = "btnUser";
            this.btnUser.Size = new System.Drawing.Size(187, 23);
            this.btnUser.TabIndex = 14;
            this.btnUser.Text = "User Management";
            this.btnUser.UseVisualStyleBackColor = true;
            this.btnUser.Click += new System.EventHandler(this.btnUser_Click);
            // 
            // btnReturn
            // 
            this.btnReturn.Location = new System.Drawing.Point(417, 284);
            this.btnReturn.Name = "btnReturn";
            this.btnReturn.Size = new System.Drawing.Size(187, 23);
            this.btnReturn.TabIndex = 13;
            this.btnReturn.Text = "Book Return";
            this.btnReturn.UseVisualStyleBackColor = true;
            this.btnReturn.Click += new System.EventHandler(this.btnReturn_Click);
            // 
            // btnIssue
            // 
            this.btnIssue.Location = new System.Drawing.Point(151, 284);
            this.btnIssue.Name = "btnIssue";
            this.btnIssue.Size = new System.Drawing.Size(187, 23);
            this.btnIssue.TabIndex = 12;
            this.btnIssue.Text = "Book Issue";
            this.btnIssue.UseVisualStyleBackColor = true;
            this.btnIssue.Click += new System.EventHandler(this.btnIssue_Click);
            // 
            // btnBook
            // 
            this.btnBook.Location = new System.Drawing.Point(417, 215);
            this.btnBook.Name = "btnBook";
            this.btnBook.Size = new System.Drawing.Size(187, 23);
            this.btnBook.TabIndex = 11;
            this.btnBook.Text = "Book Management";
            this.btnBook.UseVisualStyleBackColor = true;
            this.btnBook.Click += new System.EventHandler(this.btnBook_Click);
            // 
            // btnMember
            // 
            this.btnMember.Location = new System.Drawing.Point(151, 215);
            this.btnMember.Name = "btnMember";
            this.btnMember.Size = new System.Drawing.Size(187, 23);
            this.btnMember.TabIndex = 10;
            this.btnMember.Text = "Member Management";
            this.btnMember.UseVisualStyleBackColor = true;
            this.btnMember.Click += new System.EventHandler(this.btnMember_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(350, 115);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(45, 17);
            this.label1.TabIndex = 9;
            this.label1.Text = "Home";
            // 
            // lblUserTypeHome
            // 
            this.lblUserTypeHome.AutoSize = true;
            this.lblUserTypeHome.Location = new System.Drawing.Point(46, 67);
            this.lblUserTypeHome.Name = "lblUserTypeHome";
            this.lblUserTypeHome.Size = new System.Drawing.Size(74, 17);
            this.lblUserTypeHome.TabIndex = 18;
            this.lblUserTypeHome.Text = "User Type";
            // 
            // frmHome
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(774, 439);
            this.Controls.Add(this.lblUserTypeHome);
            this.Controls.Add(this.lblDateHome);
            this.Controls.Add(this.lblUserHome);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.btnUser);
            this.Controls.Add(this.btnReturn);
            this.Controls.Add(this.btnIssue);
            this.Controls.Add(this.btnBook);
            this.Controls.Add(this.btnMember);
            this.Controls.Add(this.label1);
            this.Name = "frmHome";
            this.Text = "Home";
            this.Load += new System.EventHandler(this.frmHome_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public System.Windows.Forms.Label lblDateHome;
        public System.Windows.Forms.Label lblUserHome;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Button btnUser;
        private System.Windows.Forms.Button btnReturn;
        private System.Windows.Forms.Button btnIssue;
        private System.Windows.Forms.Button btnBook;
        private System.Windows.Forms.Button btnMember;
        private System.Windows.Forms.Label label1;
        public System.Windows.Forms.Label lblUserTypeHome;
    }
}