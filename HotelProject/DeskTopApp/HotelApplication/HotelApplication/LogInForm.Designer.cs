namespace HotelApplication
{
    partial class LogInForm
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
            this.Loginbutton = new System.Windows.Forms.Button();
            this.EmailtextBox = new System.Windows.Forms.TextBox();
            this.PassWordtextBox = new System.Windows.Forms.TextBox();
            this.EmailLabel = new System.Windows.Forms.Label();
            this.PassWordLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // Loginbutton
            // 
            this.Loginbutton.Location = new System.Drawing.Point(332, 258);
            this.Loginbutton.Name = "Loginbutton";
            this.Loginbutton.Size = new System.Drawing.Size(187, 23);
            this.Loginbutton.TabIndex = 0;
            this.Loginbutton.Text = "Login";
            this.Loginbutton.UseVisualStyleBackColor = true;
            this.Loginbutton.Click += new System.EventHandler(this.Loginbutton_Click);
            // 
            // EmailtextBox
            // 
            this.EmailtextBox.Location = new System.Drawing.Point(332, 123);
            this.EmailtextBox.Name = "EmailtextBox";
            this.EmailtextBox.Size = new System.Drawing.Size(187, 20);
            this.EmailtextBox.TabIndex = 1;
            // 
            // PassWordtextBox
            // 
            this.PassWordtextBox.Location = new System.Drawing.Point(332, 184);
            this.PassWordtextBox.Name = "PassWordtextBox";
            this.PassWordtextBox.Size = new System.Drawing.Size(187, 20);
            this.PassWordtextBox.TabIndex = 2;
            // 
            // EmailLabel
            // 
            this.EmailLabel.AutoSize = true;
            this.EmailLabel.Location = new System.Drawing.Point(249, 123);
            this.EmailLabel.Name = "EmailLabel";
            this.EmailLabel.Size = new System.Drawing.Size(32, 13);
            this.EmailLabel.TabIndex = 3;
            this.EmailLabel.Text = "Email";
            // 
            // PassWordLabel
            // 
            this.PassWordLabel.AutoSize = true;
            this.PassWordLabel.Location = new System.Drawing.Point(249, 191);
            this.PassWordLabel.Name = "PassWordLabel";
            this.PassWordLabel.Size = new System.Drawing.Size(53, 13);
            this.PassWordLabel.TabIndex = 4;
            this.PassWordLabel.Text = "Password";
            // 
            // LogInForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.PassWordLabel);
            this.Controls.Add(this.EmailLabel);
            this.Controls.Add(this.PassWordtextBox);
            this.Controls.Add(this.EmailtextBox);
            this.Controls.Add(this.Loginbutton);
            this.Name = "LogInForm";
            this.Text = "LogIn";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button Loginbutton;
        private System.Windows.Forms.TextBox EmailtextBox;
        private System.Windows.Forms.TextBox PassWordtextBox;
        private System.Windows.Forms.Label EmailLabel;
        private System.Windows.Forms.Label PassWordLabel;
    }
}

