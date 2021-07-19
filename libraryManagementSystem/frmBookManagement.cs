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
    public partial class frmBookManagement : Form
    {
        public frmBookManagement()
        {
            InitializeComponent();
        }

        SqlConnection con = new SqlConnection(@"Data Source=NIMTARA\SQLEXPRESS;Initial Catalog=library-management-system;Integrated Security=True");
        bool flag;
        private void btnSearchISBN_Click(object sender, EventArgs e)
        {
            try
            {
                string query_search = "select * from tblBookInfo where book_ISBN = '" + txtISBN.Text + "'";
                SqlCommand cmd = new SqlCommand(query_search, con);
                con.Open();
                SqlDataReader r = cmd.ExecuteReader();

                if (r.HasRows)
                {
                    flag = true;
                    while (r.Read())
                    {
                        txtISBN.Text = r[0].ToString();
                        txtTitle.Text = r[1].ToString();
                        txtAuthor.Text = r[2].ToString();
                        txtPublisher.Text = r[3].ToString();
                        txtPublishDate.Text = r[4].ToString();
                        txtPrice.Text = r[5].ToString();
                        txtNoOfPages.Text = r[6].ToString();
                        cmbxCategory.Text = r[7].ToString();
                        txtLanguage.Text = r[8].ToString();
                    }
                }
                else
                {
                    flag = false;
                    MessageBox.Show("New Book!");
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

        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                string query_search = "select * from tblBookInfo where book_ISBN LIKE %'" +txtTitle.Text+ "'%";
                SqlCommand cmd = new SqlCommand(query_search, con);
                con.Open();
                SqlDataReader r = cmd.ExecuteReader();

                if (r.HasRows)
                {
                    flag = true;
                    while (r.Read())
                    {
                        txtISBN.Text = r[0].ToString();
                        txtTitle.Text = r[1].ToString();
                        txtAuthor.Text = r[2].ToString();
                        txtPublisher.Text = r[3].ToString();
                        txtPublishDate.Text = r[4].ToString();
                        txtPrice.Text = r[5].ToString();
                        txtNoOfPages.Text = r[6].ToString();
                        cmbxCategory.Text = r[7].ToString();
                        txtLanguage.Text = r[8].ToString();
                    }
                }
                else
                {
                    flag = false;
                    MessageBox.Show("New Book!");
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
    }
}
