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
    public partial class Home : Form
    {
        public LogInForm logInForm;
  
        CheckReservationData ReservationData;
        HomeData homeData;

        public Home(LogInForm _logInForm)
        { 
            logInForm = _logInForm;
            InitializeComponent();
           Start();
           
        }
        
        private void Home_FormClosing(object sender, FormClosingEventArgs e)
        {
            logInForm.Show();
           
        }

        private void CheckReservationBtn_Click(object sender, EventArgs e)
        {
            if (StartDateTimePicker.Value < EndDateTimePicker.Value&&CategorylistBox.SelectedItem!=null&& NumOfBedlistBox.SelectedItem != null&& NationalIDtextBox.Text!=null)
            {
                ReservationData = new CheckReservationData {
                    StartDate = StartDateTimePicker.Value,
                    EndDate= EndDateTimePicker.Value,
                    CategoryID= ((Category)CategorylistBox.SelectedItem).CategoryId,
                    NumOfBedId= ((BedNum)NumOfBedlistBox.SelectedItem).BedsId,
                    NationaltyID= NationalIDtextBox.Text
                };

                RestRequest request = new RestRequest("admin/CheckReservation", DataFormat.Json);            
                request.AddJsonBody(ReservationData);
                var response = Global.client.Post(request);
              
                ConfirmReservationData Data = JsonConvert.DeserializeObject<ConfirmReservationData>(response.Content);

                if (Data.Room.RoomId != 0)
                {
                    ReservationForm reservationFormData = new ReservationForm {

                        NationalID = NationalIDtextBox.Text,
                         StartDate = StartDateTimePicker.Value,
                         EndDate= EndDateTimePicker.Value,
                         RoomID=Data.Room.RoomId,
                         TotalPrice=Data.TotalPrice, 
                         RoomNum=Data.Room.RoomNum
                        
                    };

                    if (Data.GuestCode != 0)
                    {
                        reservationFormData.GuestCode = Data.GuestCode;
                        reservationFormData.GuestAddress = Data.GuestAddress;
                        reservationFormData.GuestName = Data.GuestName;
                        reservationFormData.Nationality = Data.Nationality;
                        reservationFormData.PhoneNumber = Data.PhoneNumber;
                        reservationFormData.Gender = Data.Gender;
                    }
                   
                    ConfirmReservation ReservationForm = new ConfirmReservation(reservationFormData);
                    ReservationForm.Show();
                }
                else
                {
                    DateMsgLabel.Text = "UnAvailable Rooms ";
                }
             
            }
            else
            {
                DateMsgLabel.Text = "Incorrect  Date ";
            }
        }

        private void RoomNumtextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == Convert.ToChar(Keys.Enter))
            {
            Room room= homeData.Rooms.Where(a => a.RoomNum == int.Parse(RoomNumtextBox.Text)).FirstOrDefault();
                RoomslistBox.SelectedIndex = RoomslistBox.Items.IndexOf(room);
            }
        }

        private void RoomReservationBtn_Click(object sender, EventArgs e)
        {
            int RoomId = ((Room)RoomslistBox.SelectedItem).RoomId;

            RestRequest request = new RestRequest("admin/GetRoomReservation/"+RoomId+"", DataFormat.Json);
           
            var response = Global.client.Post(request);
          List<ManageReservation>Reservations = JsonConvert.DeserializeObject<List<ManageReservation>>(response.Content);

            ReservationsForm ReservationForm = new ReservationsForm(Reservations, (Room)RoomslistBox.SelectedItem);
            ReservationForm.Show();

        }

       

        private void Start()
        {

            StartDateTimePicker.MinDate = DateTime.Now;
            EndDateTimePicker.MinDate = DateTime.Now;
            RestRequest request = new RestRequest("admin/index", DataFormat.Json);
            var response = Global.client.Get(request);
            homeData = JsonConvert.DeserializeObject<HomeData>(response.Content);

            if (homeData != null)
            {

                foreach (var item in homeData.Rooms)
                {
                    RoomslistBox.Items.Add(item);
                }
                RoomslistBox.DisplayMember = "RoomNum";
                foreach (var item in homeData.Beds)
                {
                    NumOfBedlistBox.Items.Add(item);
                }
                NumOfBedlistBox.DisplayMember = "BedsNum";
                foreach (var item in homeData.Categories)
                {
                    CategorylistBox.Items.Add(item);
                }
                CategorylistBox.DisplayMember = "CategoryName";
            }
        }
    }
}
