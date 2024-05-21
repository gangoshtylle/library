using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Diagnostics.Eventing.Reader;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Library
{
    public partial class IssueBooks : Form
    {
        public IssueBooks()
        {
            InitializeComponent();
        }

        private void IssueBooks_Load(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection();
            con.ConnectionString = "Data Source = DESKTOP-C44VEGQ ; Initial Catalog=library; Integrated Security=True";
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = con;
            con.Open();

            cmd = new SqlCommand("select bName from NewBook", con);
            SqlDataReader Sdr = cmd.ExecuteReader();

            while (Sdr.Read())
            {

                for (int i = 0; i < Sdr.FieldCount; i++)
                {
                    comboBox1.Items.Add(Sdr.GetString(i));

                }
            }

            Sdr.Close();
            con.Close();

        }
        int count;
        private void btnSearch_Click(object sender, EventArgs e)
        {
            if (txtEnrollement.Text != "")
            {
                String edi = txtEnrollement.Text;
                SqlConnection con = new SqlConnection();
                con.ConnectionString = "Data Source = DESKTOP-C44VEGQ ; Initial Catalog=library; Integrated Security=True";
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = con;


                cmd.CommandText = "Select * from NewStudent where enroll = '" + edi + "'";
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                DataSet DS = new DataSet();
                da.Fill(DS);

                //---------------------------------------------------------------------------
                cmd.CommandText = "Select count (std_enroll) from IRBook where std_enroll = '" + edi + "' and book_return_date is null";
                SqlDataAdapter da1 = new SqlDataAdapter(cmd);
                DataSet DS1 = new DataSet();
                da.Fill(DS1);

                count = int.Parse(DS1.Tables[0].Rows[0][0].ToString());


                //---------------------------------------------------------------------------


                if (DS.Tables[0].Rows.Count != 0)
                {
                    txtName.Text = DS.Tables[0].Rows[0][1].ToString();
                    txtDep.Text = DS.Tables[0].Rows[0][3].ToString();
                    txtSem.Text = DS.Tables[0].Rows[0][4].ToString();
                    txtContact.Text = DS.Tables[0].Rows[0][5].ToString();
                    txtEmail.Text = DS.Tables[0].Rows[0][6].ToString();

                }
                else
                {
                    txtName.Clear();
                    txtDep.Clear();
                    txtEmail.Clear();
                    txtSem.Clear();
                    txtContact.Clear();
                    MessageBox.Show("Invalid Enrollement NO", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);


                }
            }
        }

        private void btnIssueBook_Click(object sender, EventArgs e)
        {
            if (txtName.Text != "")
            {
                if (comboBox1.SelectedIndex != -1 && count <= 2)
                {
                    String enroll = txtEnrollement.Text;
                    String sname = txtName.Text;
                    String sdep = txtDep.Text;
                    String sem = txtSem.Text;
                    Int64 contact = Int64.Parse(txtContact.Text);
                    String email = txtEmail.Text;
                    String bookname = comboBox1.Text;
                    String bookIssueDate = dateTimePicker1.Text;


                    String edi = txtEnrollement.Text;
                    SqlConnection con = new SqlConnection();
                    con.ConnectionString = "Data Source = DESKTOP-C44VEGQ ; Initial Catalog=library; Integrated Security=True";
                    SqlCommand cmd = new SqlCommand();
                    cmd.Connection = con;
                    con.Open();


                    cmd.CommandText = cmd.CommandText = "insert into IRBook(std_enroll,std_name,std_dep,std_sem,std_contact,std_email,book_name,book_issue_date) values ('" + enroll + "','" + sname + "','" + sdep + "','" + sem + "','" + contact + "','" + email + "','" + bookname + "','" + bookIssueDate + "')";
                    cmd.ExecuteNonQuery();
                    con.Close();

                    MessageBox.Show("Book Issued.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("Select Book. OR Maximum number of Books has been ISSUED", "No Book Selected", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

            }
            else
            {
                MessageBox.Show("Enter Valid Enrollement NO", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
        }


        private void txtEnrollement_TextChanged(object sender, EventArgs e)
        {
            if (txtEnrollement.Text == "")
            {
                txtName.Clear();
                txtDep.Clear();
                txtSem.Clear();
                txtContact.Clear();
                txtEmail.Clear();

            }
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            txtEnrollement.Clear();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void panel3_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
