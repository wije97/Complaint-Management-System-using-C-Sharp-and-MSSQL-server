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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnLog_Click(object sender, EventArgs e)
        {
            if (txtUname.Text == "" || txtPword.Text == "")
            {
                MessageBox.Show("Please fill all fields!");
            }
            else 
            {
                SqlConnection connection = new SqlConnection("Data Source=localhost;Initial Catalog=DBComplainSys;Integrated Security=True");
                connection.Open();
                SqlCommand command = new SqlCommand("SELECT Username, Password, Employee_ID  FROM dbo.[EMPLOYEE]" + " WHERE  Username='" + txtUname.Text + "' AND Password='" + txtPword.Text + "';", connection);

                SqlDataReader reader = command.ExecuteReader();

                if (reader.Read() == true)
                {
                    lblID.Text = reader["Employee_ID"].ToString();

                    Form7 frm2 = new Form7();
                    frm2.lblID.Text = lblID.Text;
                    frm2.Show();
                    this.Hide();

                    reader.Close();
                    connection.Close();
                }
                else
                {
                    reader.Close();

                    SqlCommand command2 = new SqlCommand("SELECT Username, Password, Admin_Id  FROM dbo.[ADMIN]" + " WHERE  Username='" + txtUname.Text + "' AND Password='" + txtPword.Text + "';", connection);

                    SqlDataReader reader2 = command2.ExecuteReader();

                    if (reader2.Read() == true)
                    {
                        lblID.Text = reader2["Admin_Id"].ToString();

                        Form2 frm1 = new Form2();
                        frm1.lblID.Text = lblID.Text;
                        frm1.Show();
                        this.Hide();

                        reader2.Close();
                        connection.Close();
                    }
                    else
                    {
                        MessageBox.Show("Login Failed!", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);

                        txtUname.ResetText();
                        txtPword.ResetText();

                        reader2.Close();
                        connection.Close();
                    }

                }
            }
              
        }
    }
}
