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
    public partial class ReservationsForm : Form
    {
        List<ManageReservation> Reservations;
        Room Room;
        public ReservationsForm(List<ManageReservation> _Reservations, Room _Room)
        {
            InitializeComponent();
            Reservations=_Reservations;
            Room = _Room;
            Start();
        }

       

        private void Start()
        {
            StratDateTimePicker.MinDate = DateTime.Now;
            EndDateTimePicker.MinDate = DateTime.Now;
            RoomNumlabel.Text = Room.RoomNum.ToString();
            if (Reservations == null)
            {
                ReservationgroupBox.Enabled = false;
            }
            else {

               
                foreach (var item in Reservations)
                {

                    ListViewItem NewItem = new ListViewItem();
                    NewItem.Text = item.ReservationId.ToString();
                    ListViewItem.ListViewSubItem[] SubItems;

                    SubItems = new ListViewItem.ListViewSubItem[]
                        {new ListViewItem.ListViewSubItem(NewItem,item.StartDate.ToString()),
                        new  ListViewItem.ListViewSubItem(NewItem,item.StartDate.ToString())
                        };
                    NewItem.SubItems.AddRange(SubItems);

                    ReservationlistView.Items.Add(NewItem);
                    

                }
              


            }
            

        }

        private void NewBtn_Click(object sender, EventArgs e)
        {
            if (StratDateTimePicker.Value < EndDateTimePicker.Value && NationalIDtextBox != null)
            {
                NewRoomReservation NewReservationData = new NewRoomReservation
                {
                    StartDate = StratDateTimePicker.Value,
                    EndDate = EndDateTimePicker.Value,
                    RoomId = Room.RoomId,
                    NationalId = NationalIDtextBox.Text
                };

                RestRequest request = new RestRequest("admin/RoomNewReservation", DataFormat.Json);
                request.AddJsonBody(NewReservationData);
                var response = Global.client.Post(request);


              ConfirmReservationData Data = JsonConvert.DeserializeObject<ConfirmReservationData>(response.Content);
               

                if (Data.Room.RoomId != 0)
                {
                    ReservationForm reservationFormData = new ReservationForm
                    {

                        NationalID = NationalIDtextBox.Text,
                        StartDate = StratDateTimePicker.Value,
                        EndDate = EndDateTimePicker.Value,
                        RoomID = Data.Room.RoomId,
                        TotalPrice = Data.TotalPrice,
                        RoomNum = Data.Room.RoomNum

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
                    this.Close();


                }   }
        }

        private void DeleteBtn_Click(object sender, EventArgs e)
        {


            if (ReservationlistView.CheckedItems != null)

            {
                int Id = int.Parse(ReservationlistView.CheckedItems[0].Text);
                RestRequest request = new RestRequest("admin/DeleteReservation/" +Id+ "", DataFormat.Json);

                var response = Global.client.Post(request);
                int Data = JsonConvert.DeserializeObject<int>(response.Content);
                if (Data > 0)
                {
                    ReservationlistView.Items.Remove(ReservationlistView.CheckedItems[0]);
                }
            }


        }
    }
}
