using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using RestSharp;
using Newtonsoft.Json;

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
            Start();
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
            if (NametextBox.Text != null && PhonetextBox.Text != null && NationaltytextBox.Text != null && AddressTextBox.Text != null )
            {
                NewReservation ReservationData = new NewReservation {
                    GuestCode = Data.GuestCode,
                    GuestName = NametextBox.Text,
                    PhoneNumber = PhonetextBox.Text,
                    Nationality = NationaltytextBox.Text,
                    Gender = Gender ,
                    GuestAddress = AddressTextBox.Text, 
                    NationalID = Data.NationalID,
                    StartDate = Data.StartDate, 
                    EndDate = Data.EndDate,
                    TotalPrice = Data.TotalPrice,
                    RoomID = Data.RoomID
                     };
                RestRequest request = new RestRequest("admin/NewReservation", DataFormat.Json);
                request.AddJsonBody(ReservationData);
                var response = Global.client.Post(request);
                int result = JsonConvert.DeserializeObject<int>(response.Content);
                if (result > 0)
                {
                    this.Close();
                }
                else
                { MSGlabel.Text = "Try Again"; };
            }
            else
            { MSGlabel.Text = "Some Data Missing"; };
        }

        private void Start()
        {
            RoomNumlabel.Text = Data.RoomNum.ToString();
            Pricelabel.Text = Data.TotalPrice.ToString();
            NationaltIDLabel.Text = Data.NationalID;
            StartDateLabel.Text = Data.StartDate.ToString();
            EndDateLabel.Text = Data.EndDate.ToString();
            if (Data.GuestCode != 0)
            {
                NametextBox.Text = Data.GuestName;
                PhonetextBox.Text = Data.PhoneNumber;
                NationaltytextBox.Text = Data.Nationality;
                AddressTextBox.Text = Data.GuestAddress;
                if (Data.Gender == "Male")
                {
                    MalecheckBox.Checked = true;
                    Gender = "Male";
                }
                else
                {
                    FemalecheckBox.Checked = true;
                    Gender = "Female";
                }
            }
        }

    }
}
