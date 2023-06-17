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
    public partial class Form10 : Form
    {
        public Form10()
        {
            InitializeComponent();
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            if(txtCusID.Text=="")
            {
                MessageBox.Show("Please insert Customer ID");
            }
            else
            {
                SqlConnection connection = new SqlConnection("Data Source=localhost;Initial Catalog=DBComplainSys;Integrated Security=True");
                connection.Open();

                SqlCommand command = new SqlCommand("SELECT * FROM dbo.[viewCustomerDetails] WHERE Customer_Id='" + txtCusID.Text + "';", connection);

                SqlDataReader reader = command.ExecuteReader();
                if (reader.Read())
                {
                    txtfName.Text = reader["Full_Name"].ToString();
                    txtNIC.Text = reader["NIC"].ToString();
                    txtAge.Text = reader["Age"].ToString();
                    txtAddress.Text = reader["Address"].ToString();
                    cmbGender.Text = reader["Gender"].ToString();
                    txtMobile.Text = reader["Phone"].ToString();
                    txtEmail.Text = reader["Email"].ToString();
                }
                else
                {
                    MessageBox.Show("No data for this Customer ID!");
                }
                connection.Close();
            }
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            if (txtAddress.Text == "" || txtAge.Text == "" || txtEmail.Text == "" || txtfName.Text == "" || txtMobile.Text == "" || txtNIC.Text == "" || cmbGender.Text == "")
            {

                MessageBox.Show("Please fill all fields!");
            }
            else
            {
                SqlConnection connection = new SqlConnection("Data Source=localhost;Initial Catalog=DBComplainSys;Integrated Security=True");
                connection.Open();
                SqlCommand command = new SqlCommand("Update dbo.[USER] set Full_Name='" + txtfName.Text + "', Address='" + txtAddress.Text + "', Gender='" + cmbGender.Text + "' WHERE NIC='" + txtNIC.Text + "';", connection);
                SqlCommand command2 = new SqlCommand("Update dbo.[CUSTOMER] set Email='" + txtEmail.Text + "', Age='" + txtAge.Text + "' WHERE NIC='" + txtNIC.Text + "';", connection);
                SqlCommand command3 = new SqlCommand("Update dbo.[USERPHONE] set Phone='" + txtMobile.Text + "' WHERE NIC='" + txtNIC.Text + "';", connection);

                if (command.ExecuteNonQuery() != 0 && command2.ExecuteNonQuery() != 0 && command3.ExecuteNonQuery() != 0)
                {
                    txtAddress.ResetText();
                    txtfName.ResetText();
                    txtMobile.ResetText();
                    txtNIC.ResetText();
                    txtAge.ResetText();
                    txtEmail.ResetText();
                    cmbGender.ResetText();
                    txtCusID.ResetText();

                    MessageBox.Show("Updated!");

                }
                else
                {
                    MessageBox.Show("Update Error!");
                }
                connection.Close();
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (txtAddress.Text == "" || txtAge.Text == "" || txtEmail.Text == "" || txtfName.Text == "" || txtMobile.Text == "" || txtNIC.Text == "" || cmbGender.Text == "")
            {

                MessageBox.Show("Please fill all fields!");
            }
            else
            {
                SqlConnection connection = new SqlConnection("Data Source=localhost;Initial Catalog=DBComplainSys;Integrated Security=True");
                connection.Open();

                SqlCommand command = new SqlCommand("Delete  dbo.[CUSTOMER] where Customer_Id='" + txtCusID.Text + "';", connection);

                if (command.ExecuteNonQuery() != 0)
                {
                    txtAddress.ResetText();
                    txtfName.ResetText();
                    txtMobile.ResetText();
                    txtNIC.ResetText();
                    txtAge.ResetText();
                    txtEmail.ResetText();
                    cmbGender.ResetText();
                    txtCusID.ResetText();

                    MessageBox.Show("Deleted!");

                }
                else
                {
                    MessageBox.Show("Delete Error!");
                }
                connection.Close();
            }
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            Form9 frm1 = new Form9();
            frm1.lblID.Text = lblID.Text;
            frm1.Show();
            this.Hide();
        }
    }
}
