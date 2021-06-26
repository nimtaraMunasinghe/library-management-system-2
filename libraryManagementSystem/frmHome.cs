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
    public partial class frmHome : Form
    {
        public frmHome()
        {
            InitializeComponent();
        }

        private void btnMember_Click(object sender, EventArgs e)
        {
            frmMemberManagement member = new frmMemberManagement();
            member.Visible = true;
            this.Visible = false;
            member.lblUserMM.Text = lblUserHome.Text;
            member.lblUserTypeMM.Text = lblUserTypeHome.Text;
        }

        private void btnBook_Click(object sender, EventArgs e)
        {
            frmBookManagement book = new frmBookManagement();
            book.Visible = true;
            this.Visible = false;
            book.lblUserBM.Text = lblUserHome.Text;
            book.lblUserTypeBM.Text = lblUserTypeHome.Text;
        }

        private void btnIssue_Click(object sender, EventArgs e)
        {
            frmIssue issue = new frmIssue();
            issue.Visible = true;
            this.Visible = false;
            issue.lblUserBI.Text = lblUserHome.Text;
            issue.lblUserTypeBI.Text = lblUserTypeHome.Text;
        }

        private void btnReturn_Click(object sender, EventArgs e)
        {
            frmReturn rtrn = new frmReturn();
            rtrn.Visible = true;
            this.Visible = false;
            rtrn.lblUserBR.Text = lblUserHome.Text;
            rtrn.lblUserTypeBR.Text = lblUserTypeHome.Text;
        }

        private void btnUser_Click(object sender, EventArgs e)
        {
            frmUserManagement user = new frmUserManagement();
            user.Visible = true;
            this.Visible = false;
            user.lblUserUM.Text = lblUserHome.Text;
            user.lblUserTypeUM.Text = lblUserTypeHome.Text;
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void frmHome_Load(object sender, EventArgs e)
        {
            lblDateHome.Text = DateTime.Now.ToString("dd/MM/yyyy");
        }
    }
}
