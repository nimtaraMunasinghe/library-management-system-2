
namespace libraryManagementSystem
{
    partial class frmProgress
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
            this.components = new System.ComponentModel.Container();
            this.prbProgBar = new System.Windows.Forms.ProgressBar();
            this.lblDatePB = new System.Windows.Forms.Label();
            this.lblUserPB = new System.Windows.Forms.Label();
            this.tmrProgBar = new System.Windows.Forms.Timer(this.components);
            this.SuspendLayout();
            // 
            // prbProgBar
            // 
            this.prbProgBar.Location = new System.Drawing.Point(76, 170);
            this.prbProgBar.Name = "prbProgBar";
            this.prbProgBar.Size = new System.Drawing.Size(688, 35);
            this.prbProgBar.TabIndex = 5;
            // 
            // lblDatePB
            // 
            this.lblDatePB.AutoSize = true;
            this.lblDatePB.Location = new System.Drawing.Point(760, 37);
            this.lblDatePB.Name = "lblDatePB";
            this.lblDatePB.Size = new System.Drawing.Size(38, 17);
            this.lblDatePB.TabIndex = 4;
            this.lblDatePB.Text = "Date";
            // 
            // lblUserPB
            // 
            this.lblUserPB.AutoSize = true;
            this.lblUserPB.Location = new System.Drawing.Point(43, 37);
            this.lblUserPB.Name = "lblUserPB";
            this.lblUserPB.Size = new System.Drawing.Size(38, 17);
            this.lblUserPB.TabIndex = 3;
            this.lblUserPB.Text = "User";
            // 
            // frmProgress
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(912, 283);
            this.Controls.Add(this.prbProgBar);
            this.Controls.Add(this.lblDatePB);
            this.Controls.Add(this.lblUserPB);
            this.Name = "frmProgress";
            this.Text = "Loading...";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ProgressBar prbProgBar;
        public System.Windows.Forms.Label lblDatePB;
        public System.Windows.Forms.Label lblUserPB;
        private System.Windows.Forms.Timer tmrProgBar;
    }
}