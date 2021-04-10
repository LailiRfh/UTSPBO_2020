using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MscStdReservation
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void buttonHome_Click(object sender, EventArgs e)
        {
            Home home = new Home();
            home.Show();
        }

        private void buttonReservation_Click(object sender, EventArgs e)
        {
            Reservation rsvtn = new Reservation();
            rsvtn.Show();
        }

        private void buttonSearch_Click(object sender, EventArgs e)
        {
            SearchReservation searchRsrvtn = new SearchReservation();
            searchRsrvtn.Show();
        }

        private void buttonDelete_Click(object sender, EventArgs e)
        {
            DeleteRes deleteRes = new DeleteRes();
            deleteRes.Show();
        }

        private void buttonLogOut_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Confirm Log Out?", "Log Out", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning) == DialogResult.OK)
            {
                this.Close();
                Login lg = new Login();
                lg.Show();
            }
        }

        private void btnPayment_Click(object sender, EventArgs e)
        {
            Payment payment = new Payment();
            payment.Show();
        }
    }
}
