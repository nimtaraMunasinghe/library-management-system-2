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
    public partial class frmUserManagement : Form
    {
        public frmUserManagement()
        {
            InitializeComponent();
        }

        public void clear()
        {
            txtUserID.Clear();
            txtName.Clear();
            txtPassword.Clear();
            txtUserType.Clear();
            txtAddress.Clear();
            txtContactNumber.Clear();
        }

        SqlConnection con = new SqlConnection(@"Data Source=NIMTARA\SQLEXPRESS;Initial Catalog=library-management-system;Integrated Security=True");

        private void btnAdd_Click(object sender, EventArgs e)
        {
            try
            {
                string query_insert = "insert into tblUser values ('" + txtUserID.Text + "', '" + txtName.Text + "', '" + txtPassword.Text + "', '" + txtUserType.Text + "', '" + txtAddress.Text + "', '" + txtContactNumber.Text + "', '" +lblDateUM.Text+ "', '" +lblUserUM.Text+ "')";
                SqlCommand cmd = new SqlCommand(query_insert, con);
                con.Open();
                cmd.ExecuteNonQuery();
                MessageBox.Show("User added successfully!");
            }
            catch(Exception ex)
            {
                MessageBox.Show("Error while adding user " + ex);
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

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            try
            {
                string query_updte = "update tblUser set user_ID = '" + txtUserID.Text + "', user_name = '" + txtName.Text + "', user_password = '" + txtPassword.Text + "', user_type = '" + txtUserType.Text + "', user_address = '" + txtAddress.Text + "', user_telephone = '" + txtContactNumber.Text + "' where user_ID = '"+txtUserID.Text+"'";
                SqlCommand cmd = new SqlCommand(query_updte, con);
                con.Open();
                cmd.ExecuteNonQuery();
                MessageBox.Show("User updated successfully!");
            }
            catch(Exception ex)
            {
                MessageBox.Show("Error while updating user" + ex);
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
                string query_delete = "delete from tblUser where user_ID = '" + txtUserID.Text + "'";
                SqlCommand cmd = new SqlCommand(query_delete, con);
                con.Open();
                cmd.ExecuteNonQuery();
                MessageBox.Show("User deleted successfully!");
            }
            catch(Exception ex)
            {
                MessageBox.Show("Error while deleting user" + ex);
            }
            finally
            {
                con.Close();
            }

            clear();
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            try
            {
                string query_search = "select * from tblUser where user_ID = '" + txtUserID.Text + "'";
                SqlCommand cmd = new SqlCommand(query_search, con);
                con.Open();
                SqlDataReader r = cmd.ExecuteReader();

                while (r.Read())
                {
                    txtUserID.Text = r[0].ToString();
                    txtName.Text = r[1].ToString();
                    txtPassword.Text = r[2].ToString();
                    txtUserType.Text = r[3].ToString();
                    txtAddress.Text = r[4].ToString();
                    txtContactNumber.Text = r[5].ToString();
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show("Error while searching user " + ex);
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
            home.lblUserHome.Text = lblUserUM.Text;
            home.lblUserTypeHome.Text = lblUserTypeUM.Text;
        }

        private void frmUserManagement_Load(object sender, EventArgs e)
        {
            lblDateUM.Text = DateTime.Now.ToString("dd/MM/yyyy");
        }
    }
}
