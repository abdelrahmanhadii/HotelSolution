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
    public partial class Home : Form
    {
        public LogInForm logInForm;
        HomeData homeData;
        CheckReservationData ReservationData;

        public Home(LogInForm _logInForm)
        { 
            logInForm = _logInForm;
            InitializeComponent();

           
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




                //send ReservationData if ok open new form  and send data else  msg date not avilabel
                // admin/CheckReservation post

                //return

                ConfirmReservationData Data = new ConfirmReservationData();

                if (Data.Room.RoomId != 0)
                {
                    ReservationForm reservationFormData = new ReservationForm {
                        Guest = new Guest { NationalID= NationalIDtextBox.Text },
                        RoomReservation= new RoomReservation {
                            StartDate = StartDateTimePicker.Value,
                            EndDate= EndDateTimePicker.Value,
                            RoomID=Data.Room.RoomId,
                           TotalPrice=Data.TotalPrice
                        },
                        RoomNum=Data.Room.RoomNum
                        
                    };

                    if (Data.GuestCode != 0)
                    {
                        reservationFormData.Guest.GuestCode = Data.GuestCode;
                        reservationFormData.Guest.GuestAddress = Data.GuestAddress;
                        reservationFormData.Guest.GuestName = Data.GuestName;
                        reservationFormData.Guest.Nationality = Data.Nationality;
                        reservationFormData.Guest.PhoneNumber = Data.PhoneNumber;
                        reservationFormData.Guest.Gender = Data.Gender;
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
                
            }
        }

        private void RoomReservationBtn_Click(object sender, EventArgs e)
        {
            int RoomId =((Room)RoomslistBox.SelectedItem).RoomId ;
            //3la 7asb el reuest lo fe room reservation open new form

        }

        private void Home_Load(object sender, EventArgs e)
        {
            //call admin/index get
            //respond 
            homeData = new HomeData();
            if (homeData != null)
            {
                foreach (var item in homeData.Rooms)
                {
                    RoomslistBox.Items.Add(item);
                }
                foreach (var item in homeData.Beds)
                {
                    NumOfBedlistBox.Items.Add(item);
                }
                foreach (var item in homeData.Categories)
                {
                   CategorylistBox.Items.Add(item);
                }
            }
            

        }
    }
}
