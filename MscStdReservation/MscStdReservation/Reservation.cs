using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MscStdReservation
{
    public partial class Reservation : Form
    {
        public Reservation()
        {
            InitializeComponent();
        }
        private void buttonSv_Click(object sender, EventArgs e)
        {
            string name = txtName.Text;
            string contact = txtContact.Text;
            string roomType = comboBoxRoomType.Text;
            string rentDate = dateTimePickerRD.Text;
            string rentTime = comboBoxRentTime.Text;
            string rtStart = comboBoxRTStart.Text;

            SqlConnection con = new SqlConnection();
            con.ConnectionString = "data source = MSI; database = MscStdReservation; integrated security = True";
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = con;

            cmd.CommandText = "insert into Reservation (Name, Contact, RoomType, RentDate, RentTime, RTStart) values ('" + name + "','" + contact + "','" + roomType + "','" + rentDate + "','" + rentTime + "','" + rtStart + "')";

            SqlDataAdapter DA = new SqlDataAdapter(cmd);
            DataSet DS = new DataSet();
            DA.Fill(DS);
            MessageBox.Show("Data Saved", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
        private void buttonReset_Click(object sender, EventArgs e)
        {
            txtName.Clear();
            txtContact.Clear();
            comboBoxRoomType.ResetText();
            dateTimePickerRD.Value = DateTime.Now;
            comboBoxRentTime.ResetText();
            comboBoxRTStart.ResetText();
        }
    }
}
