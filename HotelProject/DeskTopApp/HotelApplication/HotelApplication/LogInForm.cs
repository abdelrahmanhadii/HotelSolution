﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using RestSharp;

namespace HotelApplication
{
    public partial class LogInForm : Form
    {
        public LogInForm()
        {
            InitializeComponent();
        }

        private void Loginbutton_Click(object sender, EventArgs e)
        {
            string Email = EmailtextBox.Text;
            string Password = PassWordtextBox.Text;
            if (Email != null && Password != null)
            {

                LogIn Data = new LogIn { Email = Email, PassWord = Password };

                //send to Home/Login(Data) post
                //respond 
                RestRequest request = new RestRequest("Home/login", DataFormat.Json);
                request.AddJsonBody(Data);
                var response = Global.client.Post(request);


              //  JsonConvert.DeserializeObject<>(response.Content);

                Home Homeform = new Home(this);
                Homeform.Show();
                this.Hide();


            }
               
        }
    }
}
