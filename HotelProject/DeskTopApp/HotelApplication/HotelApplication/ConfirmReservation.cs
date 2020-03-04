using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HotelApplication
{
    public partial class ConfirmReservation : Form
    {
        ReservationForm Data;
        string Gender;
        public ConfirmReservation(ReservationForm _Data)
        {

            InitializeComponent();
            Data = _Data;
        }

       

        private void MalecheckBox_CheckedChanged(object sender, EventArgs e)
        {
            FemalecheckBox.Checked = false;
            Gender = "Male";
        }

        private void FemalecheckBox_CheckedChanged(object sender, EventArgs e)
        {
            MalecheckBox.Checked = false;
            Gender = "Female";
        }

        private void CreateBtn_Click(object sender, EventArgs e)
        {

        }
    }
}
