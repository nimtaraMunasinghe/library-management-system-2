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
    public partial class frmIssue : Form
    {
        public frmIssue()
        {
            InitializeComponent();
        }

        public void clearBook()
        {
            txtBookID.Clear();
            lblBookTitle.Text = "";
            lblAuthor.Text = "";
            lblPublisher.Text = "";
        }

        public void clearMember()
        {
            txtMemberID.Clear();
            lblName.Text = "";
            lblTelephone.Text = "";
            lblAddress.Text = "";
        }

        public void clearIssue()
        {
            txtIssueID.Clear();
            lblIssueDate.Text = "";
            lblReturnDate.Text = "";
        }

        SqlConnection con = new SqlConnection(@"Data Source=NIMTARA\SQLEXPRESS;Initial Catalog=library-management-system;Integrated Security=True");

        int issuedBooks = 0, bookLimit = 0;
        bool isAvailable = true;
        private void btnSearchBookID_Click(object sender, EventArgs e)
        {
            String availability = "", isRemoved = "";
            try
            {
                string query_searchBookID1 = "select * from tblBookInfo where book_ISBN = (select book_ISBN from tblBook where book_ID = '" + txtBookID.Text + "')";
                SqlCommand cmd = new SqlCommand(query_searchBookID1, con);
                con.Open();
                SqlDataReader r = cmd.ExecuteReader();

                if(r.HasRows)
                {
                    while(r.Read())
                    {
                        lblBookTitle.Text = r[1].ToString();
                        lblAuthor.Text = r[2].ToString();
                        lblPublisher.Text = r[3].ToString();
                    }
                }
                else
                {
                    MessageBox.Show("No such book");
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

            try
            {
                string query_searchBookID2 = "select * from tblBook where book_ID = '" + txtBookID.Text + "'";
                SqlCommand cmd = new SqlCommand(query_searchBookID2, con);
                con.Open();
                SqlDataReader r = cmd.ExecuteReader();

                if(r.HasRows)
                {
                    while (r.Read())
                    {
                        availability = r[5].ToString();
                        isRemoved = r[7].ToString();
                    }
                    if(availability == "False")
                    {
                        if(isRemoved == "True")
                        {
                            MessageBox.Show("This book is removed from library");
                            clearBook();
                        }
                        else
                        {
                            MessageBox.Show("This book has been borrowd and not returned yet");
                            clearBook();
                        }
                    }
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

        private void btnSearchMemberID_Click(object sender, EventArgs e)
        {
            string issued_books = "", book_Limit = "", status = "";
            try
            {
                string query_searchMember = "select * from tblMember where mem_ID = '" + txtMemberID.Text + "'";
                SqlCommand cmd = new SqlCommand(query_searchMember, con);
                con.Open();
                SqlDataReader r = cmd.ExecuteReader();

                if (r.HasRows)
                {
                    while (r.Read())
                    {
                        lblName.Text = r[1].ToString();
                        lblAddress.Text = r[3].ToString();
                        lblTelephone.Text = r[4].ToString();
                        issued_books = r[8].ToString();
                        book_Limit = r[10].ToString();
                        status = r[9].ToString();
                    }
                    int ib = Int16.Parse(issued_books);
                    int bl = Int16.Parse(book_Limit);
                    issuedBooks = ib;
                    bookLimit = bl;
                    if (status == "active")
                    {
                        if (ib > bl)
                        {
                            MessageBox.Show("Member has reached the book limit");
                            clearMember();
                        }
                    }
                    else
                    {
                        MessageBox.Show("Inactive Member");
                        clearMember();
                    }
                }
                else
                {
                    MessageBox.Show("No such member");
                    clearMember();
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

        private void btnSearchIssueID_Click(object sender, EventArgs e)
        {

        }

        private void btnIssue_Click(object sender, EventArgs e)
        {
            try
            {
                string query_insert = "insert into tblIssue (issue_ID, book_ID, mem_ID, issue_date, issue_user) values ('" + txtIssueID.Text + "', '" + txtBookID.Text + "', '" + txtMemberID.Text + "', '" + lblDateBI.Text + "', '" + lblUserBI.Text + "')";
                SqlCommand cmd = new SqlCommand(query_insert, con);
                con.Open();
                cmd.ExecuteNonQuery();
                MessageBox.Show("Book issued successfully");
                issuedBooks = issuedBooks + 1;
                /*if(issuedBooks > bookLimit)
                {
                    MessageBox.Show("This member has reached the book limit. Cannot borrow anymore books.");
                    clearMember();
                }*/
                isAvailable = false;
            }
            catch(Exception ex)
            {
                MessageBox.Show("Error while issuing book" + ex);
            }
            finally
            {
                con.Close();
            }

            //update member table issued books
            try
            {
                string query_update = "update tblMember set issued_books = '" + issuedBooks + "' where mem_ID = '" + txtMemberID.Text + "'";
                SqlCommand cmd = new SqlCommand(query_update, con);
                con.Open();
                cmd.ExecuteNonQuery();
            }
            catch(Exception ex)
            {
                MessageBox.Show("Error while updating " + ex);
            }
            finally
            {
                con.Close();
            }

            //update book table book availability
            try
            {
                string query_update = "update tblBook set book_availability = '" + isAvailable + "' where book_ID = '" + txtBookID.Text + "'";
                SqlCommand cmd = new SqlCommand(query_update, con);
                con.Open();
                cmd.ExecuteNonQuery();
            }
            catch(Exception ex)
            {
                MessageBox.Show("Error while updating " + ex);
            }
            finally
            {
                con.Close();
            }
            clearBook();
            clearIssue();
            clearMember();
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            /*try
            {
                string query_update = "update tblIssue set issue_ID = '" + txtIssueID.Text + "', book_ID = '" + txtBookID.Text + "', mem_ID = '" + txtMemberID.Text + "' where issue_ID = '" + txtIssueID.Text + "'";
                SqlCommand cmd = new SqlCommand(query_update, con);
                con.Open();
                cmd.ExecuteNonQuery();
            }
            catch(Exception ex)
            {
                MessageBox.Show("Error while updating " + ex);
            }
            finally
            {
                con.Close();
            }*/
        }
    }
}
