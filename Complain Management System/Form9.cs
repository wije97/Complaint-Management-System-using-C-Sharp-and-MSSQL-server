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
    public partial class Form9 : Form
    {
        public Form9()
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

        private void btnEditCus_Click(object sender, EventArgs e)
        {
            Form10 frm2 = new Form10();
            frm2.lblID.Text = lblID.Text;
            frm2.Show();
            this.Hide();
        }

        private void btnSearchCompID_Click(object sender, EventArgs e)
        {
            if (txtCusID.Text =="")
            {
                MessageBox.Show("Please insert Complaint ID");
            }
            else
            {
                cmbType.ResetText();

                SqlConnection connection = new SqlConnection("Data Source=localhost;Initial Catalog=DBComplainSys;Integrated Security=True");
                connection.Open();

                SqlCommand command = new SqlCommand("Select * FROM getComplaint_TV(@ComplaintID)", connection);
                command.CommandType = CommandType.Text;
                command.Parameters.AddWithValue("@ComplaintID", txtCusID.Text);

                SqlDataAdapter adapter = new SqlDataAdapter(command);

                dgvPComplain.DataSource = null;
                dgvPComplain.Rows.Clear();

                SqlDataAdapter dAdapter = new SqlDataAdapter(command);
                DataSet ds = new DataSet();
                dAdapter.Fill(ds);
                dgvPComplain.ReadOnly = true;
                dgvPComplain.DataSource = ds.Tables[0];
                connection.Close();
            }
        }

        private void btnSearchType_Click(object sender, EventArgs e)
        {
            if (cmbType.Text =="")
            {
                MessageBox.Show("Please insert Type");
            }
            else
            {
                txtCusID.ResetText();

                SqlConnection connection = new SqlConnection("Data Source=localhost;Initial Catalog=DBComplainSys;Integrated Security=True");
                connection.Open();

                SqlCommand command = new SqlCommand("getComplaint_SP", connection);

                command.CommandType = CommandType.StoredProcedure;
                command.Parameters.AddWithValue("@Type", cmbType.Text);

                dgvPComplain.DataSource = null;
                dgvPComplain.Rows.Clear();

                SqlDataAdapter dAdapter = new SqlDataAdapter(command);
                DataSet ds = new DataSet();
                dAdapter.Fill(ds);
                dgvPComplain.ReadOnly = true;
                dgvPComplain.DataSource = ds.Tables[0];
                connection.Close();
            }
        }

        private void btntake_Click(object sender, EventArgs e)
        {
            if (txtTAcID.Text == "")
            {
                MessageBox.Show("Please select Complaint");
            }
            else
            {
                Form11 frm3 = new Form11();
                frm3.lblID.Text = lblID.Text;
                frm3.txtCompID.Text = txtTAcID.Text;
                frm3.Show();
                this.Hide();
            }
        }

        private void dgvPComplain_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = dgvPComplain.Rows[e.RowIndex];
                txtTAcID.Text = row.Cells[0].Value.ToString();

            }
        }
    }
}
