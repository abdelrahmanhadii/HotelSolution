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
            this.NationaltIDLabel = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.MSGlabel = new System.Windows.Forms.Label();
            this.GuestgroupBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // StartDateLabel
            // 
            this.StartDateLabel.AutoSize = true;
            this.StartDateLabel.Location = new System.Drawing.Point(159, 169);
            this.StartDateLabel.Name = "StartDateLabel";
            this.StartDateLabel.Size = new System.Drawing.Size(0, 13);
            this.StartDateLabel.TabIndex = 0;
            // 
            // Pricelabel
            // 
            this.Pricelabel.AutoSize = true;
            this.Pricelabel.Location = new System.Drawing.Point(159, 135);
            this.Pricelabel.Name = "Pricelabel";
            this.Pricelabel.Size = new System.Drawing.Size(0, 13);
            this.Pricelabel.TabIndex = 1;
            // 
            // RoomNumlabel
            // 
            this.RoomNumlabel.AutoSize = true;
            this.RoomNumlabel.Location = new System.Drawing.Point(159, 100);
            this.RoomNumlabel.Name = "RoomNumlabel";
            this.RoomNumlabel.Size = new System.Drawing.Size(0, 13);
            this.RoomNumlabel.TabIndex = 2;
            // 
            // EndDateLabel
            // 
            this.EndDateLabel.AutoSize = true;
            this.EndDateLabel.Location = new System.Drawing.Point(159, 200);
            this.EndDateLabel.Name = "EndDateLabel";
            this.EndDateLabel.Size = new System.Drawing.Size(0, 13);
            this.EndDateLabel.TabIndex = 3;
            // 
            // GuestgroupBox
            // 
            this.GuestgroupBox.Controls.Add(this.MSGlabel);
            this.GuestgroupBox.Controls.Add(this.label5);
            this.GuestgroupBox.Controls.Add(this.NationaltIDLabel);
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
            this.MalecheckBox.Checked = true;
            this.MalecheckBox.CheckState = System.Windows.Forms.CheckState.Checked;
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
            this.CreateBtn.Location = new System.Drawing.Point(133, 335);
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
            // NationaltIDLabel
            // 
            this.NationaltIDLabel.AutoSize = true;
            this.NationaltIDLabel.Location = new System.Drawing.Point(104, 35);
            this.NationaltIDLabel.Name = "NationaltIDLabel";
            this.NationaltIDLabel.Size = new System.Drawing.Size(0, 13);
            this.NationaltIDLabel.TabIndex = 8;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(31, 100);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(75, 13);
            this.label1.TabIndex = 8;
            this.label1.Text = "Room Number";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(31, 135);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(58, 13);
            this.label2.TabIndex = 9;
            this.label2.Text = "Total Price";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(31, 169);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(30, 13);
            this.label3.TabIndex = 10;
            this.label3.Text = "From";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(31, 200);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(20, 13);
            this.label4.TabIndex = 11;
            this.label4.Text = "To";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(29, 35);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(60, 13);
            this.label5.TabIndex = 12;
            this.label5.Text = "National ID";
            // 
            // MSGlabel
            // 
            this.MSGlabel.AutoSize = true;
            this.MSGlabel.ForeColor = System.Drawing.Color.Red;
            this.MSGlabel.Location = new System.Drawing.Point(107, 290);
            this.MSGlabel.Name = "MSGlabel";
            this.MSGlabel.Size = new System.Drawing.Size(0, 13);
            this.MSGlabel.TabIndex = 14;
            // 
            // ConfirmReservation
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
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
        private System.Windows.Forms.Label NationaltIDLabel;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label MSGlabel;
    }
}