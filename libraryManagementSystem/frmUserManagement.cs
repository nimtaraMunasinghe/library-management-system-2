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
    }
}
