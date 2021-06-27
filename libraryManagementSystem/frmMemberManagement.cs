using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace libraryManagementSystem
{
    public partial class frmMemberManagement : Form
    {
        public frmMemberManagement()
        {
            InitializeComponent();
        }

        public void clear()
        {
            txtMemberID.Clear();
            txtMemberName.Clear();
            rbtnStudent.Checked = false;
            rbtnStaff.Checked = false;
            txtAddress.Clear();
            txtContactNumber.Clear();
            txtGuardianName.Clear();
            txtGuardianName.Visible = false;
            lblGurdian.Visible = false;
        }

        public void radioButtonMemberType()
        {

        }
        SqlConnection con = new SqlConnection(@"Data Source=NIMTARA\SQLEXPRESS;Initial Catalog=library-management-system;Integrated Security=True");

        private void btnAdd_Click(object sender, EventArgs e)
        {
            string memberType = "", status = "active";
            int bookLimit = 0, returnDays = 0, issuedBooks = 0;
          
            if(rbtnStudent.Checked == true)
            {
                memberType = "Student";
                bookLimit = 1;
                returnDays = 7;
            }
            else if(rbtnStaff.Checked == true)
            {
                memberType = "Staff";
                bookLimit = 5;
                returnDays = 30;
                txtGuardianName.Text = "";
            }
            if (rbtnStaff.Checked == false && rbtnStudent.Checked == false)
            {
                MessageBox.Show("Please select membertype");
            }
            else
            {
                try
                {
                    string query_insert = "insert into tblMember values ('" + txtMemberID.Text + "', '" + txtMemberName.Text + "', '" + memberType + "', '" + txtAddress.Text + "', '" + txtContactNumber.Text + "', '"+txtGuardianName.Text+"', '" + lblDateMM.Text + "', '" + lblUserMM.Text + "', '" + issuedBooks + "', '" + status + "', '" + bookLimit + "', '" + returnDays + "')";
                    SqlCommand cmd = new SqlCommand(query_insert, con);
                    con.Open();
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Member added successfully");
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error while adding member " + ex);
                }
                finally
                {
                    con.Close();
                }

                clear();
            }
        }

        private void rbtnStudent_CheckedChanged(object sender, EventArgs e)
        {
            if(rbtnStudent.Checked==true)
            {
                lblGurdian.Visible = true;
                txtGuardianName.Visible = true;
            }
        }

        private void rbtnStaff_CheckedChanged(object sender, EventArgs e)
        {
            if(rbtnStaff.Checked==true)
            {
                lblGurdian.Visible = false;
                txtGuardianName.Visible = false;
            }
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            string memberType = "";

            if (rbtnStudent.Checked == true)
            {
                memberType = "Student";
            }
            else if (rbtnStaff.Checked == true)
            {
                memberType = "Staff";
                txtGuardianName.Text = "";
            }
            try
            {
                string query_update = "update tblMember set mem_ID = '"+txtMemberID.Text+"', mem_name = '"+txtMemberName.Text+"', mem_type = '"+memberType+ "', mem_address = '"+txtAddress.Text+"', mem_telephone = '"+txtContactNumber.Text+ "', mem_guardian = '" + txtGuardianName.Text + "' where mem_ID = '" + txtMemberID.Text + "'";
                SqlCommand cmd = new SqlCommand(query_update, con);
                con.Open();
                cmd.ExecuteNonQuery();
                MessageBox.Show("Member updated successfully");
            }
            catch(Exception ex)
            {
                MessageBox.Show("Error while updating member " + ex);
            }
            finally
            {
                con.Close();
            }

            clear();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            try
            {
                string query_delete = "delete from tblMember where mem_ID = '" + txtMemberID.Text + "'";
                SqlCommand cmd = new SqlCommand(query_delete, con);
                con.Open();
                cmd.ExecuteNonQuery();
                MessageBox.Show("Member deleted successfully");
            }
            catch(Exception ex)
            {
                MessageBox.Show("Error while deleting member " + ex);
            }
            finally
            {
                con.Close();
            }

            clear();
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            clear();
        }

        private void btnSearchMemberID_Click(object sender, EventArgs e)
        {
            string memberType = "";
            try
            {
                string query_search = "select * from tblMember where mem_ID = '" + txtMemberID.Text + "'";
                SqlCommand cmd = new SqlCommand(query_search, con);
                con.Open();
                SqlDataReader r = cmd.ExecuteReader();

                while (r.Read())
                {
                    txtMemberID.Text = r[0].ToString();
                    txtMemberName.Text = r[1].ToString();
                    memberType = r[2].ToString();
                    txtAddress.Text = r[3].ToString();
                    txtContactNumber.Text = r[4].ToString();
                    txtGuardianName.Text = r[5].ToString();
                }

                if(memberType == "Student")
                {
                    rbtnStudent.Checked = true;
                }
                else if(memberType == "Staff")
                {
                    rbtnStaff.Checked = true;
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show("Error while searching " + ex);
            }
            finally
            {
                con.Close();
            }
        }

        private void btnSearchMemberName_Click(object sender, EventArgs e)
        {
            string memberType = "";
            try
            {
                string query_search = "select * from tblMember where mem_name LIKE '%" + txtMemberName.Text + "%'";
                SqlCommand cmd = new SqlCommand(query_search, con);
                con.Open();
                SqlDataReader r = cmd.ExecuteReader();

                while (r.Read())
                {
                    txtMemberID.Text = r[0].ToString();
                    txtMemberName.Text = r[1].ToString();
                    memberType = r[2].ToString();
                    txtAddress.Text = r[3].ToString();
                    txtContactNumber.Text = r[4].ToString();
                    txtGuardianName.Text = r[5].ToString();
                }

                if (memberType == "Student")
                {
                    rbtnStudent.Checked = true;
                }
                else if (memberType == "Staff")
                {
                    rbtnStaff.Checked = true;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error while searching " + ex);
            }
            finally
            {
                con.Close();
            }
        }

        private void btnHome_Click(object sender, EventArgs e)
        {
            frmHome home = new frmHome();
            home.Visible = true;
            this.Visible = false;
            home.lblUserHome.Text = lblUserMM.Text;
            home.lblUserTypeHome.Text = lblUserTypeMM.Text;
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void frmMemberManagement_Load(object sender, EventArgs e)
        {
            lblDateMM.Text = DateTime.Now.ToString("dd/MM/yyyy");
        }
    }
}
