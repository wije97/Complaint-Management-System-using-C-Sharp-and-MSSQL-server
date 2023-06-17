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
    public partial class Form3 : Form
    {
        public string adminID;

        public Form3()
        {
            InitializeComponent();
        }

        private void btnSubmit_Click(object sender, EventArgs e)
        {
            if(txtAddress.Text == "" || txtEID.Text=="" || txtEmail.Text=="" || txtfName.Text=="" || txtMobile.Text=="" || txtNIC.Text=="" || txtPword.Text==""|| txtUname.Text =="")
            {
                MessageBox.Show("Please fill all fields!");
            }
            else
            {
                SqlConnection connection = new SqlConnection("Data Source=localhost;Initial Catalog=DBComplainSys;Integrated Security=True");
                connection.Open();
                SqlCommand command = new SqlCommand("Insert into  dbo.[USER](NIC, Full_Name, Address, Gender) values ('" + txtNIC.Text + "','" + txtfName.Text + "','" + txtAddress.Text + "','" + cmbGender.Text + "')", connection);
                SqlCommand command2 = new SqlCommand("Insert into  dbo.[EMPLOYEE](Employee_ID, Admin_Id, NIC, Date_of_Birth,Username,Password) values ('" + txtEID.Text + "','" + lblID.Text + "','" + txtNIC.Text + "','" + dtpDOB.Text + "','" + txtUname.Text + "','" + txtPword.Text + "')", connection);
                SqlCommand command3 = new SqlCommand("Insert into  dbo.[USERPHONE](NIC, Phone) values ('" + txtNIC.Text + "','" + txtMobile.Text + "')", connection);

                if(command.ExecuteNonQuery()!=0 && command2.ExecuteNonQuery() != 0 && command3.ExecuteNonQuery() != 0)
                {
                    txtAddress.ResetText();
                    txtEID.ResetText();
                    txtEmail.ResetText();
                    txtfName.ResetText();
                    txtMobile.ResetText();
                    txtNIC.ResetText();
                    txtPword.ResetText();
                    txtUname.ResetText();
                    dtpDOB.ResetText();
                    cmbGender.ResetText();

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
            Form2 frm1 = new Form2();
            frm1.lblID.Text = lblID.Text;
            frm1.Show();
            this.Hide();
        }
    }
}
