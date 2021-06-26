using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace libraryManagementSystem
{
    public partial class frmProgress : Form
    {
        public frmProgress()
        {
            InitializeComponent();
        }

        private void tmrProgBar_Tick(object sender, EventArgs e)
        {
            if(prbProgBar.Value < 100)
            {
                prbProgBar.Value = prbProgBar.Value + 1;
            }
            else
            {
                frmHome home = new frmHome();
                home.Visible = true;
                this.Visible = false;
                tmrProgBar.Enabled = false;
                home.lblUserHome.Text = lblUserPB.Text;
                home.lblUserTypeHome.Text = lblUserTypePB.Text;
            }
        }

        private void frmProgress_Load(object sender, EventArgs e)
        {
            lblDatePB.Text = DateTime.Now.ToString("dd/MM/yyyy");
        }
    }
}
