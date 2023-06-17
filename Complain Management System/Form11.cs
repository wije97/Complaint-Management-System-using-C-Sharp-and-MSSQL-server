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
    public partial class Form11 : Form
    {
        public Form11()
        {
            InitializeComponent();
        }

        private void btnADD_Click(object sender, EventArgs e)
        {
            if(txtCompID.Text=="" || txtxActID.Text=="" || txtDetails.Text == "" )
            {
                MessageBox.Show("Please fill all fields!");
            }
            else
            {
                SqlConnection connection = new SqlConnection("Data Source=localhost;Initial Catalog=DBComplainSys;Integrated Security=True");
                connection.Open();
                SqlCommand command = new SqlCommand("Insert into  dbo.[ACTION](Action_Id, Complaint_Id, Employee_ID, Details_Action, Date_Action) values ('" + txtxActID.Text + "','" + txtCompID.Text + "','" + lblID.Text + "','" + txtDetails.Text + "','" + dtpDate.Text + "')", connection);

                if (command.ExecuteNonQuery() != 0)
                {
                    txtCompID.ResetText();
                    txtDetails.ResetText();
                    txtxActID.ResetText();
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

        private void btnBack_Click(object sender, EventArgs e)
        {
            Form7 frm1 = new Form7();
            frm1.lblID.Text = lblID.Text;
            frm1.Show();
            this.Hide();
        }
    }
}
