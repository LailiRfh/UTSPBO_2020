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
    public partial class Payment : Form
    {
        public Payment()
        {
            InitializeComponent();
        }

        private void buttonCheckTotalCost_Click(object sender, EventArgs e)
        {
            cPayment iPayment = new cPayment();

            iPayment.theRoomType = txtRoomType.Text;
            string aa = ("Acoustic");
            string bb = ("Band");
            string cc = ("Custom");
            string dd = ("Deluxe");


            iPayment.theRentTime = (int)Double.Parse(txtRentTime.Text);
            int A = 10000;
            int B = 15000;
            int C = 17000;
            int D = 20000;

            if (iPayment.theRoomType == aa)
            {
                String a = String.Format("Rp{0}", A * iPayment.theRentTime);
                txtTotalCost.Text = a;
            }

            else if (iPayment.theRoomType == bb)
            {
                String b = String.Format("Rp{0}", B * iPayment.theRentTime);
                txtTotalCost.Text = b;
            }

            else if (iPayment.theRoomType == cc)
            {
                String c = String.Format("Rp{0}", C * iPayment.theRentTime);
                txtTotalCost.Text = c;
            }

            else if (iPayment.theRoomType == dd)
            {
                String d = String.Format("Rp{0}", D * iPayment.theRentTime);
                txtTotalCost.Text = d;
            }

            else
            {
                MessageBox.Show("Please Enter a Correct Room Type (Acoustic, Band, Custom, Deluxe)", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
    }
}
