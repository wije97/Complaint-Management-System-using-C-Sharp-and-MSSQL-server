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
    public partial class Form5 : Form
    {
        public Form5()
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

        private void Form5_Load(object sender, EventArgs e)
        {
            SqlConnection connection = new SqlConnection("Data Source=localhost;Initial Catalog=DBComplainSys;Integrated Security=True");
            connection.Open();
            
           
            SqlCommand command = new SqlCommand("Select * from dbo.[viewCustomerDetails]", connection);

            dgvCus.DataSource = null;
            dgvCus.Rows.Clear();

            SqlDataAdapter dAdapter = new SqlDataAdapter(command);
            DataSet ds = new DataSet();
            dAdapter.Fill(ds);

            dgvCus.ReadOnly = true;
            dgvCus.DataSource = ds.Tables[0];
            
            connection.Close();
        }
    }
}
