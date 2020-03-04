namespace HotelApplication
{
    partial class Home
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.RecervationgroupBox = new System.Windows.Forms.GroupBox();
            this.DateMsgLabel = new System.Windows.Forms.Label();
            this.CheckReservationBtn = new System.Windows.Forms.Button();
            this.EndDatelabel = new System.Windows.Forms.Label();
            this.StartDatelabel = new System.Windows.Forms.Label();
            this.NumOfBedlabel = new System.Windows.Forms.Label();
            this.Categorylabel = new System.Windows.Forms.Label();
            this.EndDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.StartDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.NumOfBedlistBox = new System.Windows.Forms.ListBox();
            this.CategorylistBox = new System.Windows.Forms.ListBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.RoomReservationBtn = new System.Windows.Forms.Button();
            this.RoomNumberlabel = new System.Windows.Forms.Label();
            this.RoomslistBox = new System.Windows.Forms.ListBox();
            this.RoomNumtextBox = new System.Windows.Forms.TextBox();
            this.NationalIDtextBox = new System.Windows.Forms.TextBox();
            this.NationalIDlabel = new System.Windows.Forms.Label();
            this.RecervationgroupBox.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // RecervationgroupBox
            // 
            this.RecervationgroupBox.Controls.Add(this.NationalIDlabel);
            this.RecervationgroupBox.Controls.Add(this.NationalIDtextBox);
            this.RecervationgroupBox.Controls.Add(this.DateMsgLabel);
            this.RecervationgroupBox.Controls.Add(this.CheckReservationBtn);
            this.RecervationgroupBox.Controls.Add(this.EndDatelabel);
            this.RecervationgroupBox.Controls.Add(this.StartDatelabel);
            this.RecervationgroupBox.Controls.Add(this.NumOfBedlabel);
            this.RecervationgroupBox.Controls.Add(this.Categorylabel);
            this.RecervationgroupBox.Controls.Add(this.EndDateTimePicker);
            this.RecervationgroupBox.Controls.Add(this.StartDateTimePicker);
            this.RecervationgroupBox.Controls.Add(this.NumOfBedlistBox);
            this.RecervationgroupBox.Controls.Add(this.CategorylistBox);
            this.RecervationgroupBox.Location = new System.Drawing.Point(465, 45);
            this.RecervationgroupBox.Name = "RecervationgroupBox";
            this.RecervationgroupBox.Size = new System.Drawing.Size(688, 473);
            this.RecervationgroupBox.TabIndex = 0;
            this.RecervationgroupBox.TabStop = false;
            this.RecervationgroupBox.Text = "New Recervation";
            // 
            // DateMsgLabel
            // 
            this.DateMsgLabel.AutoSize = true;
            this.DateMsgLabel.ForeColor = System.Drawing.Color.Red;
            this.DateMsgLabel.Location = new System.Drawing.Point(289, 209);
            this.DateMsgLabel.Name = "DateMsgLabel";
            this.DateMsgLabel.Size = new System.Drawing.Size(0, 13);
            this.DateMsgLabel.TabIndex = 9;
            // 
            // CheckReservationBtn
            // 
            this.CheckReservationBtn.Location = new System.Drawing.Point(207, 397);
            this.CheckReservationBtn.Name = "CheckReservationBtn";
            this.CheckReservationBtn.Size = new System.Drawing.Size(276, 39);
            this.CheckReservationBtn.TabIndex = 8;
            this.CheckReservationBtn.Text = "CheckReservation";
            this.CheckReservationBtn.UseVisualStyleBackColor = true;
            this.CheckReservationBtn.Click += new System.EventHandler(this.CheckReservationBtn_Click);
            // 
            // EndDatelabel
            // 
            this.EndDatelabel.AutoSize = true;
            this.EndDatelabel.Location = new System.Drawing.Point(434, 235);
            this.EndDatelabel.Name = "EndDatelabel";
            this.EndDatelabel.Size = new System.Drawing.Size(49, 13);
            this.EndDatelabel.TabIndex = 7;
            this.EndDatelabel.Text = "EndDate";
            // 
            // StartDatelabel
            // 
            this.StartDatelabel.AutoSize = true;
            this.StartDatelabel.Location = new System.Drawing.Point(95, 235);
            this.StartDatelabel.Name = "StartDatelabel";
            this.StartDatelabel.Size = new System.Drawing.Size(52, 13);
            this.StartDatelabel.TabIndex = 6;
            this.StartDatelabel.Text = "StartDate";
            // 
            // NumOfBedlabel
            // 
            this.NumOfBedlabel.AutoSize = true;
            this.NumOfBedlabel.Location = new System.Drawing.Point(422, 43);
            this.NumOfBedlabel.Name = "NumOfBedlabel";
            this.NumOfBedlabel.Size = new System.Drawing.Size(74, 13);
            this.NumOfBedlabel.TabIndex = 5;
            this.NumOfBedlabel.Text = "NumberOfBed";
            // 
            // Categorylabel
            // 
            this.Categorylabel.AutoSize = true;
            this.Categorylabel.Location = new System.Drawing.Point(80, 43);
            this.Categorylabel.Name = "Categorylabel";
            this.Categorylabel.Size = new System.Drawing.Size(49, 13);
            this.Categorylabel.TabIndex = 4;
            this.Categorylabel.Text = "Category";
            // 
            // EndDateTimePicker
            // 
            this.EndDateTimePicker.Location = new System.Drawing.Point(425, 260);
            this.EndDateTimePicker.Name = "EndDateTimePicker";
            this.EndDateTimePicker.Size = new System.Drawing.Size(147, 20);
            this.EndDateTimePicker.TabIndex = 3;
            // 
            // StartDateTimePicker
            // 
            this.StartDateTimePicker.Location = new System.Drawing.Point(83, 260);
            this.StartDateTimePicker.Name = "StartDateTimePicker";
            this.StartDateTimePicker.Size = new System.Drawing.Size(160, 20);
            this.StartDateTimePicker.TabIndex = 2;
            this.StartDateTimePicker.Value = new System.DateTime(2020, 3, 4, 0, 0, 0, 0);
            // 
            // NumOfBedlistBox
            // 
            this.NumOfBedlistBox.FormattingEnabled = true;
            this.NumOfBedlistBox.Location = new System.Drawing.Point(425, 72);
            this.NumOfBedlistBox.Name = "NumOfBedlistBox";
            this.NumOfBedlistBox.Size = new System.Drawing.Size(147, 121);
            this.NumOfBedlistBox.TabIndex = 1;
            // 
            // CategorylistBox
            // 
            this.CategorylistBox.FormattingEnabled = true;
            this.CategorylistBox.Location = new System.Drawing.Point(83, 72);
            this.CategorylistBox.Name = "CategorylistBox";
            this.CategorylistBox.Size = new System.Drawing.Size(160, 121);
            this.CategorylistBox.TabIndex = 0;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.RoomReservationBtn);
            this.groupBox1.Controls.Add(this.RoomNumberlabel);
            this.groupBox1.Controls.Add(this.RoomslistBox);
            this.groupBox1.Controls.Add(this.RoomNumtextBox);
            this.groupBox1.Location = new System.Drawing.Point(12, 45);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(412, 473);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Rooms";
            // 
            // RoomReservationBtn
            // 
            this.RoomReservationBtn.Location = new System.Drawing.Point(43, 339);
            this.RoomReservationBtn.Name = "RoomReservationBtn";
            this.RoomReservationBtn.Size = new System.Drawing.Size(276, 39);
            this.RoomReservationBtn.TabIndex = 9;
            this.RoomReservationBtn.Text = "RoomReservation";
            this.RoomReservationBtn.UseVisualStyleBackColor = true;
            this.RoomReservationBtn.Click += new System.EventHandler(this.RoomReservationBtn_Click);
            // 
            // RoomNumberlabel
            // 
            this.RoomNumberlabel.AutoSize = true;
            this.RoomNumberlabel.Location = new System.Drawing.Point(81, 53);
            this.RoomNumberlabel.Name = "RoomNumberlabel";
            this.RoomNumberlabel.Size = new System.Drawing.Size(72, 13);
            this.RoomNumberlabel.TabIndex = 5;
            this.RoomNumberlabel.Text = "RoomNumber";
            // 
            // RoomslistBox
            // 
            this.RoomslistBox.FormattingEnabled = true;
            this.RoomslistBox.Location = new System.Drawing.Point(81, 103);
            this.RoomslistBox.Name = "RoomslistBox";
            this.RoomslistBox.Size = new System.Drawing.Size(181, 173);
            this.RoomslistBox.TabIndex = 1;
            // 
            // RoomNumtextBox
            // 
            this.RoomNumtextBox.Location = new System.Drawing.Point(81, 72);
            this.RoomNumtextBox.Name = "RoomNumtextBox";
            this.RoomNumtextBox.Size = new System.Drawing.Size(181, 20);
            this.RoomNumtextBox.TabIndex = 0;
            this.RoomNumtextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.RoomNumtextBox_KeyPress);
            // 
            // NationalIDtextBox
            // 
            this.NationalIDtextBox.Location = new System.Drawing.Point(231, 339);
            this.NationalIDtextBox.Name = "NationalIDtextBox";
            this.NationalIDtextBox.Size = new System.Drawing.Size(226, 20);
            this.NationalIDtextBox.TabIndex = 10;
            // 
            // NationalIDlabel
            // 
            this.NationalIDlabel.AutoSize = true;
            this.NationalIDlabel.Location = new System.Drawing.Point(232, 314);
            this.NationalIDlabel.Name = "NationalIDlabel";
            this.NationalIDlabel.Size = new System.Drawing.Size(57, 13);
            this.NationalIDlabel.TabIndex = 11;
            this.NationalIDlabel.Text = "NationalID";
            // 
            // Home
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1269, 570);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.RecervationgroupBox);
            this.Name = "Home";
            this.Text = "Home";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Home_FormClosing);
            this.Load += new System.EventHandler(this.Home_Load);
            this.RecervationgroupBox.ResumeLayout(false);
            this.RecervationgroupBox.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox RecervationgroupBox;
        private System.Windows.Forms.ListBox NumOfBedlistBox;
        private System.Windows.Forms.ListBox CategorylistBox;
        private System.Windows.Forms.Button CheckReservationBtn;
        private System.Windows.Forms.Label EndDatelabel;
        private System.Windows.Forms.Label StartDatelabel;
        private System.Windows.Forms.Label NumOfBedlabel;
        private System.Windows.Forms.Label Categorylabel;
        private System.Windows.Forms.DateTimePicker EndDateTimePicker;
        private System.Windows.Forms.DateTimePicker StartDateTimePicker;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ListBox RoomslistBox;
        private System.Windows.Forms.TextBox RoomNumtextBox;
        private System.Windows.Forms.Label RoomNumberlabel;
        private System.Windows.Forms.Button RoomReservationBtn;
        private System.Windows.Forms.Label DateMsgLabel;
        private System.Windows.Forms.Label NationalIDlabel;
        private System.Windows.Forms.TextBox NationalIDtextBox;
    }
}