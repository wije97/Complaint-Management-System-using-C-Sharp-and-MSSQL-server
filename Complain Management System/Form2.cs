using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Complain_Management_System
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void btnAddEmp_Click(object sender, EventArgs e)
        {
            Form3 frm1 = new Form3();
            frm1.lblID.Text = lblID.Text;
            frm1.Show();
            this.Hide();
        }

        private void btnViewEmp_Click(object sender, EventArgs e)
        {
            Form4 frm2 = new Form4();
            frm2.lblID.Text = lblID.Text;
            frm2.Show();
            this.Hide();
        }

        private void btnViewCus_Click(object sender, EventArgs e)
        {
            Form5 frm3 = new Form5();
            frm3.lblID.Text = lblID.Text;
            frm3.Show();
            this.Hide();
        }

        private void ViewComAct_Click(object sender, EventArgs e)
        {
            Form6 frm4 = new Form6();
            frm4.lblID.Text = lblID.Text;
            frm4.Show();
            this.Hide();
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            Form1 frm5 = new Form1();
            frm5.Show();
            this.Hide();
        }
    }
}
