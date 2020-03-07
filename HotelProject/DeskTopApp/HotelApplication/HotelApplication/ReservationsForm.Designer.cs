namespace HotelApplication
{
    partial class ReservationsForm
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
            this.RoomNumlabel = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.NewBtn = new System.Windows.Forms.Button();
            this.StratDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.EndDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.NationalIDtextBox = new System.Windows.Forms.TextBox();
            this.DatagroupBox = new System.Windows.Forms.GroupBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.DeleteBtn = new System.Windows.Forms.Button();
            this.ReservationlistView = new System.Windows.Forms.ListView();
            this.IDHeader = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.StartDate = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.EndDate = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.ReservationgroupBox = new System.Windows.Forms.GroupBox();
            this.DatagroupBox.SuspendLayout();
            this.ReservationgroupBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // RoomNumlabel
            // 
            this.RoomNumlabel.AutoSize = true;
            this.RoomNumlabel.Location = new System.Drawing.Point(138, 20);
            this.RoomNumlabel.Name = "RoomNumlabel";
            this.RoomNumlabel.Size = new System.Drawing.Size(0, 13);
            this.RoomNumlabel.TabIndex = 0;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(43, 20);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(75, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Room Number";
            // 
            // NewBtn
            // 
            this.NewBtn.Location = new System.Drawing.Point(121, 226);
            this.NewBtn.Name = "NewBtn";
            this.NewBtn.Size = new System.Drawing.Size(134, 33);
            this.NewBtn.TabIndex = 2;
            this.NewBtn.Text = "NewReservation";
            this.NewBtn.UseVisualStyleBackColor = true;
            this.NewBtn.Click += new System.EventHandler(this.NewBtn_Click);
            // 
            // StratDateTimePicker
            // 
            this.StratDateTimePicker.Location = new System.Drawing.Point(112, 42);
            this.StratDateTimePicker.Name = "StratDateTimePicker";
            this.StratDateTimePicker.Size = new System.Drawing.Size(200, 20);
            this.StratDateTimePicker.TabIndex = 3;
            // 
            // EndDateTimePicker
            // 
            this.EndDateTimePicker.Location = new System.Drawing.Point(112, 104);
            this.EndDateTimePicker.Name = "EndDateTimePicker";
            this.EndDateTimePicker.Size = new System.Drawing.Size(200, 20);
            this.EndDateTimePicker.TabIndex = 4;
            // 
            // NationalIDtextBox
            // 
            this.NationalIDtextBox.Location = new System.Drawing.Point(112, 170);
            this.NationalIDtextBox.Name = "NationalIDtextBox";
            this.NationalIDtextBox.Size = new System.Drawing.Size(200, 20);
            this.NationalIDtextBox.TabIndex = 5;
            // 
            // DatagroupBox
            // 
            this.DatagroupBox.Controls.Add(this.label5);
            this.DatagroupBox.Controls.Add(this.label4);
            this.DatagroupBox.Controls.Add(this.label3);
            this.DatagroupBox.Controls.Add(this.NewBtn);
            this.DatagroupBox.Controls.Add(this.StratDateTimePicker);
            this.DatagroupBox.Controls.Add(this.NationalIDtextBox);
            this.DatagroupBox.Controls.Add(this.EndDateTimePicker);
            this.DatagroupBox.Location = new System.Drawing.Point(524, 58);
            this.DatagroupBox.Name = "DatagroupBox";
            this.DatagroupBox.Size = new System.Drawing.Size(335, 280);
            this.DatagroupBox.TabIndex = 6;
            this.DatagroupBox.TabStop = false;
            this.DatagroupBox.Text = "NewReservation";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(27, 177);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(57, 13);
            this.label5.TabIndex = 8;
            this.label5.Text = "NationalID";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(27, 110);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(49, 13);
            this.label4.TabIndex = 7;
            this.label4.Text = "EndDate";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(27, 48);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(52, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "StratDate";
            // 
            // DeleteBtn
            // 
            this.DeleteBtn.Location = new System.Drawing.Point(85, 290);
            this.DeleteBtn.Name = "DeleteBtn";
            this.DeleteBtn.Size = new System.Drawing.Size(134, 33);
            this.DeleteBtn.TabIndex = 7;
            this.DeleteBtn.Text = "DeleteReservation";
            this.DeleteBtn.UseVisualStyleBackColor = true;
            this.DeleteBtn.Click += new System.EventHandler(this.DeleteBtn_Click);
            // 
            // ReservationlistView
            // 
            this.ReservationlistView.CheckBoxes = true;
            this.ReservationlistView.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.IDHeader,
            this.StartDate,
            this.EndDate});
            this.ReservationlistView.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.Nonclickable;
            this.ReservationlistView.HideSelection = false;
            this.ReservationlistView.Location = new System.Drawing.Point(17, 19);
            this.ReservationlistView.MultiSelect = false;
            this.ReservationlistView.Name = "ReservationlistView";
            this.ReservationlistView.Size = new System.Drawing.Size(304, 246);
            this.ReservationlistView.TabIndex = 9;
            this.ReservationlistView.UseCompatibleStateImageBehavior = false;
            this.ReservationlistView.View = System.Windows.Forms.View.Details;
            // 
            // IDHeader
            // 
            this.IDHeader.Text = "ID";
            // 
            // StartDate
            // 
            this.StartDate.Text = "StartDate";
            this.StartDate.Width = 120;
            // 
            // EndDate
            // 
            this.EndDate.Text = "EndDate";
            this.EndDate.Width = 120;
            // 
            // ReservationgroupBox
            // 
            this.ReservationgroupBox.Controls.Add(this.DeleteBtn);
            this.ReservationgroupBox.Controls.Add(this.ReservationlistView);
            this.ReservationgroupBox.Location = new System.Drawing.Point(29, 58);
            this.ReservationgroupBox.Name = "ReservationgroupBox";
            this.ReservationgroupBox.Size = new System.Drawing.Size(361, 358);
            this.ReservationgroupBox.TabIndex = 10;
            this.ReservationgroupBox.TabStop = false;
            this.ReservationgroupBox.Text = "Reservation";
            // 
            // ReservationsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(891, 450);
            this.Controls.Add(this.ReservationgroupBox);
            this.Controls.Add(this.DatagroupBox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.RoomNumlabel);
            this.Name = "ReservationsForm";
            this.Text = "Reservations";
            this.DatagroupBox.ResumeLayout(false);
            this.DatagroupBox.PerformLayout();
            this.ReservationgroupBox.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label RoomNumlabel;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button NewBtn;
        private System.Windows.Forms.DateTimePicker StratDateTimePicker;
        private System.Windows.Forms.DateTimePicker EndDateTimePicker;
        private System.Windows.Forms.TextBox NationalIDtextBox;
        private System.Windows.Forms.GroupBox DatagroupBox;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button DeleteBtn;
        private System.Windows.Forms.ListView ReservationlistView;
        private System.Windows.Forms.GroupBox ReservationgroupBox;
        private System.Windows.Forms.ColumnHeader IDHeader;
        private System.Windows.Forms.ColumnHeader StartDate;
        private System.Windows.Forms.ColumnHeader EndDate;
    }
}