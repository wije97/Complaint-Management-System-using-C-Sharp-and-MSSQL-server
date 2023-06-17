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
    public partial class Form7 : Form
    {
        public Form7()
        {
            InitializeComponent();
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            Form1 frm1 = new Form1();
            frm1.Show();
            this.Hide();
        }

        private void btnAddComplain_Click(object sender, EventArgs e)
        {
            Form8 frm2 = new Form8();
            frm2.lblID.Text = lblID.Text;
            frm2.Show();
            this.Hide();
        }

        private void btnViewComplain_Click(object sender, EventArgs e)
        {
            Form9 frm3 = new Form9();
            frm3.lblID.Text = lblID.Text;
            frm3.Show();
            this.Hide();
        }

        private void btnAddAction_Click(object sender, EventArgs e)
        {
            Form11 frm4 = new Form11();
            frm4.lblID.Text = lblID.Text;
            frm4.Show();
            this.Hide();
        }

        private void btnViewAction_Click(object sender, EventArgs e)
        {
            Form12 frm5 = new Form12();
            frm5.lblID.Text = lblID.Text;
            frm5.Show();
            this.Hide();
        }
    }
}
