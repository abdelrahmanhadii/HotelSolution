namespace HotelApplication
{
    partial class ConfirmReservation
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
            this.StartDateLabel = new System.Windows.Forms.Label();
            this.Pricelabel = new System.Windows.Forms.Label();
            this.RoomNumlabel = new System.Windows.Forms.Label();
            this.EndDateLabel = new System.Windows.Forms.Label();
            this.GuestgroupBox = new System.Windows.Forms.GroupBox();
            this.AddressTextBox = new System.Windows.Forms.RichTextBox();
            this.FemalecheckBox = new System.Windows.Forms.CheckBox();
            this.MalecheckBox = new System.Windows.Forms.CheckBox();
            this.CreateBtn = new System.Windows.Forms.Button();
            this.NationaltytextBox = new System.Windows.Forms.TextBox();
            this.PhonetextBox = new System.Windows.Forms.TextBox();
            this.NametextBox = new System.Windows.Forms.TextBox();
            this.Addresslabel = new System.Windows.Forms.Label();
            this.Nationaltylabel = new System.Windows.Forms.Label();
            this.Genderlabel = new System.Windows.Forms.Label();
            this.Phonelabel = new System.Windows.Forms.Label();
            this.Namelabel = new System.Windows.Forms.Label();
            this.NationaltyID = new System.Windows.Forms.Label();
            this.GuestgroupBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // StartDateLabel
            // 
            this.StartDateLabel.AutoSize = true;
            this.StartDateLabel.Location = new System.Drawing.Point(44, 27);
            this.StartDateLabel.Name = "StartDateLabel";
            this.StartDateLabel.Size = new System.Drawing.Size(35, 13);
            this.StartDateLabel.TabIndex = 0;
            this.StartDateLabel.Text = "label1";
            // 
            // Pricelabel
            // 
            this.Pricelabel.AutoSize = true;
            this.Pricelabel.Location = new System.Drawing.Point(44, 128);
            this.Pricelabel.Name = "Pricelabel";
            this.Pricelabel.Size = new System.Drawing.Size(35, 13);
            this.Pricelabel.TabIndex = 1;
            this.Pricelabel.Text = "label2";
            // 
            // RoomNumlabel
            // 
            this.RoomNumlabel.AutoSize = true;
            this.RoomNumlabel.Location = new System.Drawing.Point(44, 93);
            this.RoomNumlabel.Name = "RoomNumlabel";
            this.RoomNumlabel.Size = new System.Drawing.Size(35, 13);
            this.RoomNumlabel.TabIndex = 2;
            this.RoomNumlabel.Text = "label3";
            // 
            // EndDateLabel
            // 
            this.EndDateLabel.AutoSize = true;
            this.EndDateLabel.Location = new System.Drawing.Point(44, 60);
            this.EndDateLabel.Name = "EndDateLabel";
            this.EndDateLabel.Size = new System.Drawing.Size(35, 13);
            this.EndDateLabel.TabIndex = 3;
            this.EndDateLabel.Text = "label4";
            // 
            // GuestgroupBox
            // 
            this.GuestgroupBox.Controls.Add(this.AddressTextBox);
            this.GuestgroupBox.Controls.Add(this.FemalecheckBox);
            this.GuestgroupBox.Controls.Add(this.MalecheckBox);
            this.GuestgroupBox.Controls.Add(this.CreateBtn);
            this.GuestgroupBox.Controls.Add(this.NationaltytextBox);
            this.GuestgroupBox.Controls.Add(this.PhonetextBox);
            this.GuestgroupBox.Controls.Add(this.NametextBox);
            this.GuestgroupBox.Controls.Add(this.Addresslabel);
            this.GuestgroupBox.Controls.Add(this.Nationaltylabel);
            this.GuestgroupBox.Controls.Add(this.Genderlabel);
            this.GuestgroupBox.Controls.Add(this.Phonelabel);
            this.GuestgroupBox.Controls.Add(this.Namelabel);
            this.GuestgroupBox.Enabled = false;
            this.GuestgroupBox.Location = new System.Drawing.Point(347, 27);
            this.GuestgroupBox.Name = "GuestgroupBox";
            this.GuestgroupBox.Size = new System.Drawing.Size(441, 394);
            this.GuestgroupBox.TabIndex = 7;
            this.GuestgroupBox.TabStop = false;
            this.GuestgroupBox.Text = "GuestData";
            // 
            // AddressTextBox
            // 
            this.AddressTextBox.Location = new System.Drawing.Point(107, 209);
            this.AddressTextBox.Name = "AddressTextBox";
            this.AddressTextBox.Size = new System.Drawing.Size(328, 74);
            this.AddressTextBox.TabIndex = 8;
            this.AddressTextBox.Text = "";
            // 
            // FemalecheckBox
            // 
            this.FemalecheckBox.AutoSize = true;
            this.FemalecheckBox.Location = new System.Drawing.Point(291, 138);
            this.FemalecheckBox.Name = "FemalecheckBox";
            this.FemalecheckBox.Size = new System.Drawing.Size(60, 17);
            this.FemalecheckBox.TabIndex = 13;
            this.FemalecheckBox.Text = "Female";
            this.FemalecheckBox.UseVisualStyleBackColor = true;
            this.FemalecheckBox.CheckedChanged += new System.EventHandler(this.FemalecheckBox_CheckedChanged);
            // 
            // MalecheckBox
            // 
            this.MalecheckBox.AutoSize = true;
            this.MalecheckBox.Location = new System.Drawing.Point(143, 138);
            this.MalecheckBox.Name = "MalecheckBox";
            this.MalecheckBox.Size = new System.Drawing.Size(49, 17);
            this.MalecheckBox.TabIndex = 12;
            this.MalecheckBox.Text = "Male";
            this.MalecheckBox.UseVisualStyleBackColor = true;
            this.MalecheckBox.CheckedChanged += new System.EventHandler(this.MalecheckBox_CheckedChanged);
            // 
            // CreateBtn
            // 
            this.CreateBtn.Location = new System.Drawing.Point(133, 302);
            this.CreateBtn.Name = "CreateBtn";
            this.CreateBtn.Size = new System.Drawing.Size(271, 32);
            this.CreateBtn.TabIndex = 11;
            this.CreateBtn.Text = "Reservation";
            this.CreateBtn.UseVisualStyleBackColor = true;
            this.CreateBtn.Click += new System.EventHandler(this.CreateBtn_Click);
            // 
            // NationaltytextBox
            // 
            this.NationaltytextBox.Location = new System.Drawing.Point(107, 173);
            this.NationaltytextBox.Name = "NationaltytextBox";
            this.NationaltytextBox.Size = new System.Drawing.Size(328, 20);
            this.NationaltytextBox.TabIndex = 9;
            // 
            // PhonetextBox
            // 
            this.PhonetextBox.Location = new System.Drawing.Point(107, 101);
            this.PhonetextBox.Name = "PhonetextBox";
            this.PhonetextBox.Size = new System.Drawing.Size(328, 20);
            this.PhonetextBox.TabIndex = 6;
            // 
            // NametextBox
            // 
            this.NametextBox.Location = new System.Drawing.Point(107, 66);
            this.NametextBox.Name = "NametextBox";
            this.NametextBox.Size = new System.Drawing.Size(328, 20);
            this.NametextBox.TabIndex = 5;
            // 
            // Addresslabel
            // 
            this.Addresslabel.AutoSize = true;
            this.Addresslabel.Location = new System.Drawing.Point(29, 209);
            this.Addresslabel.Name = "Addresslabel";
            this.Addresslabel.Size = new System.Drawing.Size(45, 13);
            this.Addresslabel.TabIndex = 4;
            this.Addresslabel.Text = "Address";
            // 
            // Nationaltylabel
            // 
            this.Nationaltylabel.AutoSize = true;
            this.Nationaltylabel.Location = new System.Drawing.Point(29, 173);
            this.Nationaltylabel.Name = "Nationaltylabel";
            this.Nationaltylabel.Size = new System.Drawing.Size(54, 13);
            this.Nationaltylabel.TabIndex = 3;
            this.Nationaltylabel.Text = "Nationalty";
            // 
            // Genderlabel
            // 
            this.Genderlabel.AutoSize = true;
            this.Genderlabel.Location = new System.Drawing.Point(29, 138);
            this.Genderlabel.Name = "Genderlabel";
            this.Genderlabel.Size = new System.Drawing.Size(42, 13);
            this.Genderlabel.TabIndex = 2;
            this.Genderlabel.Text = "Gender";
            // 
            // Phonelabel
            // 
            this.Phonelabel.AutoSize = true;
            this.Phonelabel.Location = new System.Drawing.Point(29, 101);
            this.Phonelabel.Name = "Phonelabel";
            this.Phonelabel.Size = new System.Drawing.Size(38, 13);
            this.Phonelabel.TabIndex = 1;
            this.Phonelabel.Text = "Phone";
            // 
            // Namelabel
            // 
            this.Namelabel.AutoSize = true;
            this.Namelabel.Location = new System.Drawing.Point(29, 69);
            this.Namelabel.Name = "Namelabel";
            this.Namelabel.Size = new System.Drawing.Size(35, 13);
            this.Namelabel.TabIndex = 0;
            this.Namelabel.Text = "Name";
            // 
            // NationaltyID
            // 
            this.NationaltyID.AutoSize = true;
            this.NationaltyID.Location = new System.Drawing.Point(47, 165);
            this.NationaltyID.Name = "NationaltyID";
            this.NationaltyID.Size = new System.Drawing.Size(35, 13);
            this.NationaltyID.TabIndex = 8;
            this.NationaltyID.Text = "label1";
            // 
            // ConfirmReservation
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.NationaltyID);
            this.Controls.Add(this.GuestgroupBox);
            this.Controls.Add(this.EndDateLabel);
            this.Controls.Add(this.RoomNumlabel);
            this.Controls.Add(this.Pricelabel);
            this.Controls.Add(this.StartDateLabel);
            this.Name = "ConfirmReservation";
            this.Text = "ConfirmReservation";
            this.GuestgroupBox.ResumeLayout(false);
            this.GuestgroupBox.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label StartDateLabel;
        private System.Windows.Forms.Label Pricelabel;
        private System.Windows.Forms.Label RoomNumlabel;
        private System.Windows.Forms.Label EndDateLabel;
        private System.Windows.Forms.GroupBox GuestgroupBox;
        private System.Windows.Forms.CheckBox FemalecheckBox;
        private System.Windows.Forms.CheckBox MalecheckBox;
        private System.Windows.Forms.Button CreateBtn;
        private System.Windows.Forms.TextBox NationaltytextBox;
        private System.Windows.Forms.TextBox PhonetextBox;
        private System.Windows.Forms.TextBox NametextBox;
        private System.Windows.Forms.Label Addresslabel;
        private System.Windows.Forms.Label Nationaltylabel;
        private System.Windows.Forms.Label Genderlabel;
        private System.Windows.Forms.Label Phonelabel;
        private System.Windows.Forms.Label Namelabel;
        private System.Windows.Forms.RichTextBox AddressTextBox;
        private System.Windows.Forms.Label NationaltyID;
    }
}