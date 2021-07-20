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

        public void clear()
        {
            txtISBN.Clear();
            txtTitle.Clear();
            txtAuthor.Clear();
            txtPublisher.Clear();
            txtPublishDate.Clear();
            txtPrice.Clear();
            txtNoOfPages.Clear();
            txtLanguage.Clear();
            txtBookID.Clear();
            txtProvider.Clear();
            cmbxCategory.SelectedIndex = -1;
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

        private void btnAdd_Click(object sender, EventArgs e)
        {
            bool isRemoved = false;
            bool availability = true;
            string removedDate = "";
            if (flag == false)
            {
                try
                {
                    string query_insert1 = "insert into tblBookInfo values ('"+txtISBN.Text+"', '"+txtTitle.Text+"', '"+txtAuthor.Text+"', '"+txtPublisher.Text+"', '"+txtPublishDate.Text+"', '"+txtPrice.Text+"', '"+txtNoOfPages.Text+"', '"+cmbxCategory.Text+"', '"+txtLanguage.Text+"')";
                    SqlCommand cmd = new SqlCommand(query_insert1, con);
                    con.Open();
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("New book added successfully");
                }
                catch(Exception ex)
                {
                    MessageBox.Show("Error while adding book" + ex);
                }
                finally
                {
                    con.Close();
                }
            }

            try
            {
                string query_insert2 = "insert into tblBook values ('"+txtBookID.Text+"', '"+txtISBN.Text+"', '"+txtProvider.Text+"', '"+lblDateBM.Text+"', '"+lblUserBM.Text+"', '"+ availability + "', '"+removedDate+ "', '" + isRemoved + "')";
                SqlCommand cmd = new SqlCommand(query_insert2, con);
                con.Open();
                cmd.ExecuteNonQuery();
                if(flag == true)
                {
                    MessageBox.Show("Book copy added successfully");
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show("Error while adding book" + ex);
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
    }
}
