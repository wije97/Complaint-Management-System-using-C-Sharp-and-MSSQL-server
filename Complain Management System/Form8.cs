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
    public partial class Form8 : Form
    {
        public Form8()
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

        private void btnADD_Click(object sender, EventArgs e)
        {
            if(txtAddress.Text =="" || txtAge.Text=="" ||  txtCusID.Text=="" ||  txtEmail.Text=="" || txtfName.Text=="" || txtMobile.Text=="" || txtNIC.Text == "" || cmbGender.Text=="")
            {

                MessageBox.Show("Please fill all fields!");
            }
            else
            {
                SqlConnection connection = new SqlConnection("Data Source=localhost;Initial Catalog=DBComplainSys;Integrated Security=True");
                connection.Open();
                SqlCommand command = new SqlCommand("Insert into  dbo.[USER](NIC, Full_Name, Address, Gender) values ('" + txtNIC.Text + "','" + txtfName.Text + "','" + txtAddress.Text + "','" + cmbGender.Text + "')", connection);
                SqlCommand command2 = new SqlCommand("Insert into  dbo.[CUSTOMER](Customer_Id, NIC, Employee_ID,  Email, Age) values ('" + txtCusID.Text + "','" + txtNIC.Text + "','" + lblID.Text + "','" + txtEmail.Text + "','" + txtAge.Text +  "')", connection);
                SqlCommand command3 = new SqlCommand("Insert into  dbo.[USERPHONE](NIC, Phone) values ('" + txtNIC.Text + "','" + txtMobile.Text + "')", connection);

                if (command.ExecuteNonQuery() != 0 && command2.ExecuteNonQuery() != 0 && command3.ExecuteNonQuery() != 0)
                {
                    MessageBox.Show("Add Complain!");

                    groupBox1.Enabled = true;
                }
                else
                {
                    MessageBox.Show("Error!");
                }
                connection.Close();

            }
        }

        private void btnSubmit_Click(object sender, EventArgs e)
        {
            if (txtComplainID.Text == "" || txtDetails.Text == ""  || cmbType.Text=="" || dtpDate.Text=="")
            {
                MessageBox.Show("Please fill all fields!");
            }
            else
            {
                SqlConnection connection = new SqlConnection("Data Source=localhost;Initial Catalog=DBComplainSys;Integrated Security=True");
                connection.Open();
                SqlCommand command = new SqlCommand("Insert into  dbo.[COMPLAIN](Complaint_Id, Employee_ID, Customer_Id, Type, Date, Details) values ('" + txtComplainID.Text + "','" + lblID.Text + "','" + txtCusID.Text + "','" + cmbType.Text + "','" + dtpDate.Text + "','" + txtDetails.Text + "')", connection);
               
                if (command.ExecuteNonQuery() != 0 )
                {
                    txtAge.ResetText();
                    txtAddress.ResetText();
                    txtComplainID.ResetText();
                    txtCusID.ResetText();
                    txtDetails.ResetText();
                    txtEmail.ResetText();
                    txtfName.ResetText();
                    txtMobile.ResetText();
                    txtNIC.ResetText();
                    dtpDate.ResetText();
                    cmbGender.ResetText();
                    cmbType.ResetText();

                    MessageBox.Show("Done!");

                }
                else
                {
                    MessageBox.Show("Error!");
                }
                connection.Close();

            }
        }
    }
}
