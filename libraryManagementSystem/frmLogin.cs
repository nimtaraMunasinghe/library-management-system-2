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
    public partial class frmLogin : Form
    {
        public frmLogin()
        {
            InitializeComponent();
        }

        public void clear()
        {
            txtUsername.Clear();
            txtPassword.Clear();
        }

        SqlConnection con = new SqlConnection(@"Data Source=NIMTARA\SQLEXPRESS;Initial Catalog=library-management-system;Integrated Security=True");

        private void btnLogin_Click(object sender, EventArgs e)
        {
            string username = "", password = "", userType = "", userID = "";
            
            try
            {
                string query_search = "select * from tblUser where user_ID = '" + txtUsername.Text + "'";
                SqlCommand cmd = new SqlCommand(query_search, con);
                con.Open();
                SqlDataReader r = cmd.ExecuteReader();

                while(r.Read())
                {
                    userID = r[0].ToString();
                    username = r[1].ToString();
                    password = r[2].ToString();
                    userType = r[3].ToString();
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

            //username or password null
            if(txtUsername.Text == "" || txtPassword.Text == "")
            {
                MessageBox.Show("Username or Password cannot be empty");
                clear();
            }
            else
            {
                if(txtPassword.Text == password)
                {
                    frmProgress prog = new frmProgress();
                    prog.Visible = true;
                    this.Visible = false;
                    prog.lblUserTypePB.Text = userType;
                    prog.lblUserPB.Text = username;
                }
                else
                {
                    MessageBox.Show("Username or Password is incorrect");
                    clear();
                }
            }

        }
    }
}
