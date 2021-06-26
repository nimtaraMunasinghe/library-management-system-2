
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
            this.button6 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
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
            // button6
            // 
            this.button6.Location = new System.Drawing.Point(417, 357);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(187, 23);
            this.button6.TabIndex = 15;
            this.button6.Text = "Exit";
            this.button6.UseVisualStyleBackColor = true;
            // 
            // button5
            // 
            this.button5.Location = new System.Drawing.Point(151, 357);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(187, 23);
            this.button5.TabIndex = 14;
            this.button5.Text = "User Management";
            this.button5.UseVisualStyleBackColor = true;
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(417, 284);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(187, 23);
            this.button4.TabIndex = 13;
            this.button4.Text = "Book Return";
            this.button4.UseVisualStyleBackColor = true;
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(151, 284);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(187, 23);
            this.button3.TabIndex = 12;
            this.button3.Text = "Book Issue";
            this.button3.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(417, 215);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(187, 23);
            this.button2.TabIndex = 11;
            this.button2.Text = "Book Management";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(151, 215);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(187, 23);
            this.button1.TabIndex = 10;
            this.button1.Text = "Member Management";
            this.button1.UseVisualStyleBackColor = true;
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
            this.Controls.Add(this.button6);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label1);
            this.Name = "frmHome";
            this.Text = "Home";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public System.Windows.Forms.Label lblDateHome;
        public System.Windows.Forms.Label lblUserHome;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label1;
        public System.Windows.Forms.Label lblUserTypeHome;
    }
}