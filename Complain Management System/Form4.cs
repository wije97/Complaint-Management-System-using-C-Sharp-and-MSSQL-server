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
    public partial class Form4 : Form
    {
        public Form4()
        {
            InitializeComponent();
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            Form2 frm1 = new Form2();
            frm1.lblID.Text = lblID.Text;
            frm1.Show();
            this.Hide();
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            if (txtAddress.Text == "" ||   txtfName.Text == "" || txtMobile.Text == "" || txtNIC.Text == "" || txtPword.Text == "" || txtUname.Text == "")
            {
                MessageBox.Show("Please fill all fields!");
            }
            else
            {
                SqlConnection connection = new SqlConnection("Data Source=localhost;Initial Catalog=DBComplainSys;Integrated Security=True");
                connection.Open();
                SqlCommand command = new SqlCommand("Update dbo.[USER] set Full_Name='" + txtfName.Text + "', Address='" + txtAddress.Text + "',  Gender='" + cmbGender.Text + "' WHERE NIC='" + txtNIC.Text + "';", connection);
                SqlCommand command2 = new SqlCommand("Update  dbo.[EMPLOYEE] set Date_of_Birth='" + dtpDOB.Text + "', Username='" + txtUname.Text + "', Password='" + txtPword.Text + "' WHERE NIC='" + txtNIC.Text + "';", connection);
                SqlCommand command3 = new SqlCommand("Update  dbo.[USERPHONE] set Phone='" + txtMobile.Text + "' WHERE NIC='" + txtNIC.Text + "';", connection);

                if (command.ExecuteNonQuery() != 0 && command2.ExecuteNonQuery() != 0 && command3.ExecuteNonQuery() != 0)
                {
                    txtAddress.ResetText();
                    txtfName.ResetText();
                    txtMobile.ResetText();
                    txtNIC.ResetText();
                    txtPword.ResetText();
                    txtSearchEID.ResetText();
                    txtUname.ResetText();
                    cmbGender.ResetText();
                    dtpDOB.ResetText();
                    MessageBox.Show("Updated!");

                }
                else
                {
                    MessageBox.Show("Update Error!");
                }
                connection.Close();
            }
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            if (txtSearchEID.Text=="")
            {
                MessageBox.Show("Please fill Empolee ID!");
            }
            else
            {
                SqlConnection connection = new SqlConnection("Data Source=localhost;Initial Catalog=DBComplainSys;Integrated Security=True");
                connection.Open();

                SqlCommand command = new SqlCommand("SELECT * FROM dbo.[viewEmployee] WHERE Employee_ID='" + txtSearchEID.Text + "';", connection);

                SqlDataReader reader = command.ExecuteReader();
                if(reader.Read()){
                    txtfName.Text = reader["Full_Name"].ToString();
                    txtNIC.Text = reader["NIC"].ToString();
                    dtpDOB.Text = reader["Date_of_Birth"].ToString();
                    txtAddress.Text = reader["Address"].ToString();
                    cmbGender.Text = reader["Gender"].ToString();
                    txtMobile.Text = reader["Phone"].ToString();
                    txtUname.Text = reader["Username"].ToString();
                    txtPword.Text = reader["Password"].ToString();
                }
                else
                {
                    MessageBox.Show("No data for this Empolee ID!");
                }
                connection.Close();

            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (txtAddress.Text == "" || txtfName.Text == "" || txtMobile.Text == "" || txtNIC.Text == "" || txtPword.Text == "" || txtUname.Text == "")
            {
                MessageBox.Show("Please fill all fields!");
            }
            else
            {
                SqlConnection connection = new SqlConnection("Data Source=localhost;Initial Catalog=DBComplainSys;Integrated Security=True");
                connection.Open();

                SqlCommand command = new SqlCommand("Delete  dbo.[EMPLOYEE] where Employee_ID='" + txtSearchEID.Text + "';", connection);

                if (command.ExecuteNonQuery() != 0 )
                {
                    txtAddress.ResetText();
                    txtfName.ResetText();
                    txtMobile.ResetText();
                    txtNIC.ResetText();
                    txtPword.ResetText();
                    txtSearchEID.ResetText();
                    txtUname.ResetText();
                    cmbGender.ResetText();
                    dtpDOB.ResetText();

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
