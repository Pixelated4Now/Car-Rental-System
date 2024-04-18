namespace CarRentalSystem
{
    partial class Form2
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.butLogout = new System.Windows.Forms.Button();
            this.butDamages = new System.Windows.Forms.Button();
            this.butReturns = new System.Windows.Forms.Button();
            this.butBookings = new System.Windows.Forms.Button();
            this.butCars = new System.Windows.Forms.Button();
            this.butCustomers = new System.Windows.Forms.Button();
            this.lblDashboard = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.lblTotalnumberofcars = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.lblthenumberofrentedcars = new System.Windows.Forms.Label();
            this.panel4 = new System.Windows.Forms.Panel();
            this.lblNumberofcustomers = new System.Windows.Forms.Label();
            this.panel5 = new System.Windows.Forms.Panel();
            this.lblNumberofdamagecars = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel4.SuspendLayout();
            this.panel5.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(53)))), ((int)(((byte)(49)))), ((int)(((byte)(96)))));
            this.panel1.Controls.Add(this.butLogout);
            this.panel1.Controls.Add(this.butDamages);
            this.panel1.Controls.Add(this.butReturns);
            this.panel1.Controls.Add(this.butBookings);
            this.panel1.Controls.Add(this.butCars);
            this.panel1.Controls.Add(this.butCustomers);
            this.panel1.Location = new System.Drawing.Point(1, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(172, 454);
            this.panel1.TabIndex = 0;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // butLogout
            // 
            this.butLogout.Location = new System.Drawing.Point(44, 385);
            this.butLogout.Name = "butLogout";
            this.butLogout.Size = new System.Drawing.Size(85, 39);
            this.butLogout.TabIndex = 1;
            this.butLogout.Text = "Log out";
            this.butLogout.UseVisualStyleBackColor = true;
            this.butLogout.Click += new System.EventHandler(this.butLogout_Click);
            // 
            // butDamages
            // 
            this.butDamages.Location = new System.Drawing.Point(44, 300);
            this.butDamages.Name = "butDamages";
            this.butDamages.Size = new System.Drawing.Size(85, 39);
            this.butDamages.TabIndex = 1;
            this.butDamages.Text = "Damages";
            this.butDamages.UseVisualStyleBackColor = true;
            this.butDamages.Click += new System.EventHandler(this.butDamages_Click);
            // 
            // butReturns
            // 
            this.butReturns.Location = new System.Drawing.Point(44, 244);
            this.butReturns.Name = "butReturns";
            this.butReturns.Size = new System.Drawing.Size(85, 39);
            this.butReturns.TabIndex = 1;
            this.butReturns.Text = "Returns";
            this.butReturns.UseVisualStyleBackColor = true;
            this.butReturns.Click += new System.EventHandler(this.butReturns_Click);
            // 
            // butBookings
            // 
            this.butBookings.Location = new System.Drawing.Point(44, 188);
            this.butBookings.Name = "butBookings";
            this.butBookings.Size = new System.Drawing.Size(85, 39);
            this.butBookings.TabIndex = 1;
            this.butBookings.Text = "Bookings";
            this.butBookings.UseVisualStyleBackColor = true;
            this.butBookings.Click += new System.EventHandler(this.butBookings_Click);
            // 
            // butCars
            // 
            this.butCars.Location = new System.Drawing.Point(44, 130);
            this.butCars.Name = "butCars";
            this.butCars.Size = new System.Drawing.Size(85, 39);
            this.butCars.TabIndex = 1;
            this.butCars.Text = "Cars";
            this.butCars.UseVisualStyleBackColor = true;
            this.butCars.Click += new System.EventHandler(this.butCars_Click);
            // 
            // butCustomers
            // 
            this.butCustomers.Location = new System.Drawing.Point(44, 59);
            this.butCustomers.Name = "butCustomers";
            this.butCustomers.Size = new System.Drawing.Size(85, 39);
            this.butCustomers.TabIndex = 1;
            this.butCustomers.Text = "Customers";
            this.butCustomers.UseMnemonic = false;
            this.butCustomers.UseVisualStyleBackColor = true;
            this.butCustomers.Click += new System.EventHandler(this.butCustomers_Click);
            // 
            // lblDashboard
            // 
            this.lblDashboard.AutoSize = true;
            this.lblDashboard.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDashboard.Location = new System.Drawing.Point(205, 45);
            this.lblDashboard.Name = "lblDashboard";
            this.lblDashboard.Size = new System.Drawing.Size(102, 20);
            this.lblDashboard.TabIndex = 1;
            this.lblDashboard.Text = "Dash board";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(132)))), ((int)(((byte)(28)))), ((int)(((byte)(237)))));
            this.panel2.Controls.Add(this.lblTotalnumberofcars);
            this.panel2.Location = new System.Drawing.Point(234, 127);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(200, 100);
            this.panel2.TabIndex = 2;
            this.panel2.Paint += new System.Windows.Forms.PaintEventHandler(this.panel2_Paint);
            // 
            // lblTotalnumberofcars
            // 
            this.lblTotalnumberofcars.AutoSize = true;
            this.lblTotalnumberofcars.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotalnumberofcars.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblTotalnumberofcars.Location = new System.Drawing.Point(3, 14);
            this.lblTotalnumberofcars.Name = "lblTotalnumberofcars";
            this.lblTotalnumberofcars.Size = new System.Drawing.Size(153, 16);
            this.lblTotalnumberofcars.TabIndex = 0;
            this.lblTotalnumberofcars.Text = " Total number of cars";
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(132)))), ((int)(((byte)(28)))), ((int)(((byte)(237)))));
            this.panel3.Controls.Add(this.lblthenumberofrentedcars);
            this.panel3.Location = new System.Drawing.Point(539, 127);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(200, 100);
            this.panel3.TabIndex = 3;
            // 
            // lblthenumberofrentedcars
            // 
            this.lblthenumberofrentedcars.AutoSize = true;
            this.lblthenumberofrentedcars.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblthenumberofrentedcars.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.lblthenumberofrentedcars.Location = new System.Drawing.Point(9, 14);
            this.lblthenumberofrentedcars.Name = "lblthenumberofrentedcars";
            this.lblthenumberofrentedcars.Size = new System.Drawing.Size(188, 16);
            this.lblthenumberofrentedcars.TabIndex = 0;
            this.lblthenumberofrentedcars.Text = "The number of rented cars";
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(132)))), ((int)(((byte)(28)))), ((int)(((byte)(237)))));
            this.panel4.Controls.Add(this.lblNumberofcustomers);
            this.panel4.Location = new System.Drawing.Point(234, 282);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(200, 100);
            this.panel4.TabIndex = 4;
            // 
            // lblNumberofcustomers
            // 
            this.lblNumberofcustomers.AutoSize = true;
            this.lblNumberofcustomers.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNumberofcustomers.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.lblNumberofcustomers.Location = new System.Drawing.Point(22, 18);
            this.lblNumberofcustomers.Name = "lblNumberofcustomers";
            this.lblNumberofcustomers.Size = new System.Drawing.Size(153, 16);
            this.lblNumberofcustomers.TabIndex = 0;
            this.lblNumberofcustomers.Text = "Number of customers";
            // 
            // panel5
            // 
            this.panel5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(132)))), ((int)(((byte)(28)))), ((int)(((byte)(237)))));
            this.panel5.Controls.Add(this.lblNumberofdamagecars);
            this.panel5.Location = new System.Drawing.Point(539, 282);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(200, 100);
            this.panel5.TabIndex = 5;
            // 
            // lblNumberofdamagecars
            // 
            this.lblNumberofdamagecars.AutoSize = true;
            this.lblNumberofdamagecars.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNumberofdamagecars.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.lblNumberofdamagecars.Location = new System.Drawing.Point(9, 18);
            this.lblNumberofdamagecars.Name = "lblNumberofdamagecars";
            this.lblNumberofdamagecars.Size = new System.Drawing.Size(173, 16);
            this.lblNumberofdamagecars.TabIndex = 0;
            this.lblNumberofdamagecars.Text = "Number of damage cars";
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.panel5);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.lblDashboard);
            this.Controls.Add(this.panel1);
            this.Name = "Form2";
            this.Text = "Form2";
            this.Load += new System.EventHandler(this.Form2_Load);
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            this.panel5.ResumeLayout(false);
            this.panel5.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button butLogout;
        private System.Windows.Forms.Button butDamages;
        private System.Windows.Forms.Button butReturns;
        private System.Windows.Forms.Button butBookings;
        private System.Windows.Forms.Button butCars;
        private System.Windows.Forms.Button butCustomers;
        private System.Windows.Forms.Label lblDashboard;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Label lblTotalnumberofcars;
        private System.Windows.Forms.Label lblthenumberofrentedcars;
        private System.Windows.Forms.Label lblNumberofcustomers;
        private System.Windows.Forms.Label lblNumberofdamagecars;
    }
}