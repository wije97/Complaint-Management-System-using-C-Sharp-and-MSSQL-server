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

namespace Complain_Management_System
{
    public partial class Form12 : Form
    {
        public Form12()
        {
            InitializeComponent();
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            Form7 frm1 = new Form7();
            frm1.lblID.Text = lblID.Text;
            frm1.Show();
            this.Hide();
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            if (txtxSearchActID.Text == "")
            {
                MessageBox.Show("Please insert Action ID!");
            }
            else
            {
                SqlConnection connection = new SqlConnection("Data Source=localhost;Initial Catalog=DBComplainSys;Integrated Security=True");
                connection.Open();

                SqlCommand command = new SqlCommand("getAction_SP", connection);

                command.CommandType = CommandType.StoredProcedure;
                command.Parameters.AddWithValue("@Act_ID", txtxSearchActID.Text);


                SqlDataReader reader = command.ExecuteReader();
                if (reader.Read())
                {
                    txtCompID.Text = reader["Complaint_Id"].ToString();
                    txtDetails.Text = reader["Details_Action"].ToString();
                    dtpDate.Text = reader["Date_Action"].ToString();
                }
                else
                {
                    MessageBox.Show("No data for this Action ID!");
                }
                connection.Close();
            }
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            if (txtCompID.Text == "" ||  txtDetails.Text == "")
            {
                MessageBox.Show("Please fill all fields!");
            }
            else
            {
                SqlConnection connection = new SqlConnection("Data Source=localhost;Initial Catalog=DBComplainSys;Integrated Security=True");
                connection.Open();
                SqlCommand command = new SqlCommand("Update  dbo.[ACTION] set Details_Action='" + txtDetails.Text + "', Date_Action='" + dtpDate.Text + "' WHERE Action_Id='" + txtxSearchActID.Text + "';", connection);

                if (command.ExecuteNonQuery() != 0)
                {
                    txtCompID.ResetText();
                    txtDetails.ResetText();
                    txtxSearchActID.ResetText();
                    dtpDate.ResetText();

                    MessageBox.Show("Done!");

                }
                else
                {
                    MessageBox.Show("Error!");
                }
                connection.Close();
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (txtCompID.Text == "" || txtDetails.Text == "")
            {
                MessageBox.Show("Please fill all fields!");
            }
            else
            {
                SqlConnection connection = new SqlConnection("Data Source=localhost;Initial Catalog=DBComplainSys;Integrated Security=True");
                connection.Open();

                SqlCommand command = new SqlCommand("Delete  dbo.[ACTION] where Action_Id='" + txtxSearchActID.Text + "';", connection);

                if (command.ExecuteNonQuery() != 0)
                {
                    txtCompID.ResetText();
                    txtDetails.ResetText();
                    txtxSearchActID.ResetText();
                    dtpDate.ResetText();

                    MessageBox.Show("Deleted!");

                }
                else
                {
                    MessageBox.Show("Delete Error!");
                }
                connection.Close();
            }
        }
    }
}
