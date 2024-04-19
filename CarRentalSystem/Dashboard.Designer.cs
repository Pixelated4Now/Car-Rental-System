namespace CarRentalSystem
{
    partial class Dashboard
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
            this.panel2 = new System.Windows.Forms.Panel();
            this.TopPanel = new System.Windows.Forms.Panel();
            this.lblExit = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.lblTitle = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.BottomPanel = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.label3 = new System.Windows.Forms.Label();
            this.panel4 = new System.Windows.Forms.Panel();
            this.label4 = new System.Windows.Forms.Label();
            this.panel7 = new System.Windows.Forms.Panel();
            this.label5 = new System.Windows.Forms.Label();
            this.panel9 = new System.Windows.Forms.Panel();
            this.label6 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.lblTotalCars = new System.Windows.Forms.Label();
            this.lblAvailableCars = new System.Windows.Forms.Label();
            this.lblRentedCars = new System.Windows.Forms.Label();
            this.lblDamagedCars = new System.Windows.Forms.Label();
            this.lblCustomers = new System.Windows.Forms.Label();
            this.menu1 = new CarRentalSystem.Menu();
            this.panel2.SuspendLayout();
            this.TopPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel3.SuspendLayout();
            this.panel4.SuspendLayout();
            this.panel7.SuspendLayout();
            this.panel9.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(132)))), ((int)(((byte)(28)))), ((int)(((byte)(237)))));
            this.panel2.Controls.Add(this.lblTotalCars);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Location = new System.Drawing.Point(351, 195);
            this.panel2.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(381, 154);
            this.panel2.TabIndex = 2;
            // 
            // TopPanel
            // 
            this.TopPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(53)))), ((int)(((byte)(49)))), ((int)(((byte)(96)))));
            this.TopPanel.Controls.Add(this.lblExit);
            this.TopPanel.Controls.Add(this.label1);
            this.TopPanel.Controls.Add(this.lblTitle);
            this.TopPanel.Controls.Add(this.pictureBox1);
            this.TopPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.TopPanel.Location = new System.Drawing.Point(0, 0);
            this.TopPanel.Name = "TopPanel";
            this.TopPanel.Size = new System.Drawing.Size(1902, 108);
            this.TopPanel.TabIndex = 72;
            // 
            // lblExit
            // 
            this.lblExit.AutoSize = true;
            this.lblExit.Dock = System.Windows.Forms.DockStyle.Right;
            this.lblExit.Font = new System.Drawing.Font("Microsoft Sans Serif", 22F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblExit.ForeColor = System.Drawing.Color.White;
            this.lblExit.Location = new System.Drawing.Point(1853, 0);
            this.lblExit.Name = "lblExit";
            this.lblExit.Size = new System.Drawing.Size(49, 52);
            this.lblExit.TabIndex = 75;
            this.lblExit.Text = "×";
            this.lblExit.Click += new System.EventHandler(this.lblExit_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Copperplate Gothic Bold", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.label1.Location = new System.Drawing.Point(910, 53);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(219, 35);
            this.label1.TabIndex = 73;
            this.label1.Text = "Dashboard";
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new System.Drawing.Font("Copperplate Gothic Bold", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitle.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.lblTitle.Location = new System.Drawing.Point(839, 9);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(347, 44);
            this.lblTitle.TabIndex = 58;
            this.lblTitle.Text = "Rent     a     Car";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::CarRentalSystem.Properties.Resources.Car_2;
            this.pictureBox1.Location = new System.Drawing.Point(22, 15);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(107, 73);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 75;
            this.pictureBox1.TabStop = false;
            // 
            // BottomPanel
            // 
            this.BottomPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(53)))), ((int)(((byte)(49)))), ((int)(((byte)(96)))));
            this.BottomPanel.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.BottomPanel.Location = new System.Drawing.Point(0, 944);
            this.BottomPanel.Name = "BottomPanel";
            this.BottomPanel.Size = new System.Drawing.Size(1902, 39);
            this.BottomPanel.TabIndex = 82;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(132)))), ((int)(((byte)(28)))), ((int)(((byte)(237)))));
            this.panel3.Controls.Add(this.lblAvailableCars);
            this.panel3.Controls.Add(this.label3);
            this.panel3.Location = new System.Drawing.Point(872, 195);
            this.panel3.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(381, 154);
            this.panel3.TabIndex = 84;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Copperplate Gothic Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.label3.Location = new System.Drawing.Point(130, 69);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(222, 26);
            this.label3.TabIndex = 74;
            this.label3.Text = "Available Cars";
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(132)))), ((int)(((byte)(28)))), ((int)(((byte)(237)))));
            this.panel4.Controls.Add(this.lblRentedCars);
            this.panel4.Controls.Add(this.label4);
            this.panel4.Location = new System.Drawing.Point(1432, 186);
            this.panel4.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(381, 154);
            this.panel4.TabIndex = 3;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Copperplate Gothic Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.label4.Location = new System.Drawing.Point(180, 69);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(184, 26);
            this.label4.TabIndex = 74;
            this.label4.Text = "Rented Cars";
            // 
            // panel7
            // 
            this.panel7.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(132)))), ((int)(((byte)(28)))), ((int)(((byte)(237)))));
            this.panel7.Controls.Add(this.lblDamagedCars);
            this.panel7.Controls.Add(this.label5);
            this.panel7.Location = new System.Drawing.Point(569, 395);
            this.panel7.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.panel7.Name = "panel7";
            this.panel7.Size = new System.Drawing.Size(381, 154);
            this.panel7.TabIndex = 85;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Copperplate Gothic Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.label5.Location = new System.Drawing.Point(143, 69);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(209, 26);
            this.label5.TabIndex = 74;
            this.label5.Text = "Damaged Cars";
            // 
            // panel9
            // 
            this.panel9.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(132)))), ((int)(((byte)(28)))), ((int)(((byte)(237)))));
            this.panel9.Controls.Add(this.lblCustomers);
            this.panel9.Controls.Add(this.label6);
            this.panel9.Location = new System.Drawing.Point(1163, 395);
            this.panel9.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.panel9.Name = "panel9";
            this.panel9.Size = new System.Drawing.Size(381, 154);
            this.panel9.TabIndex = 86;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Copperplate Gothic Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.label6.Location = new System.Drawing.Point(201, 69);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(161, 26);
            this.label6.TabIndex = 74;
            this.label6.Text = "Customers";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Copperplate Gothic Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.label2.Location = new System.Drawing.Point(166, 69);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(195, 26);
            this.label2.TabIndex = 75;
            this.label2.Text = "Cars in Total";
            // 
            // lblTotalCars
            // 
            this.lblTotalCars.AutoSize = true;
            this.lblTotalCars.Font = new System.Drawing.Font("Copperplate Gothic Bold", 30F);
            this.lblTotalCars.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.lblTotalCars.Location = new System.Drawing.Point(73, 47);
            this.lblTotalCars.Name = "lblTotalCars";
            this.lblTotalCars.Size = new System.Drawing.Size(72, 67);
            this.lblTotalCars.TabIndex = 76;
            this.lblTotalCars.Text = "0";
            // 
            // lblAvailableCars
            // 
            this.lblAvailableCars.AutoSize = true;
            this.lblAvailableCars.Font = new System.Drawing.Font("Copperplate Gothic Bold", 30F);
            this.lblAvailableCars.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.lblAvailableCars.Location = new System.Drawing.Point(41, 47);
            this.lblAvailableCars.Name = "lblAvailableCars";
            this.lblAvailableCars.Size = new System.Drawing.Size(72, 67);
            this.lblAvailableCars.TabIndex = 77;
            this.lblAvailableCars.Text = "0";
            // 
            // lblRentedCars
            // 
            this.lblRentedCars.AutoSize = true;
            this.lblRentedCars.Font = new System.Drawing.Font("Copperplate Gothic Bold", 30F);
            this.lblRentedCars.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.lblRentedCars.Location = new System.Drawing.Point(70, 37);
            this.lblRentedCars.Name = "lblRentedCars";
            this.lblRentedCars.Size = new System.Drawing.Size(72, 67);
            this.lblRentedCars.TabIndex = 77;
            this.lblRentedCars.Text = "0";
            // 
            // lblDamagedCars
            // 
            this.lblDamagedCars.AutoSize = true;
            this.lblDamagedCars.Font = new System.Drawing.Font("Copperplate Gothic Bold", 30F);
            this.lblDamagedCars.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.lblDamagedCars.Location = new System.Drawing.Point(65, 37);
            this.lblDamagedCars.Name = "lblDamagedCars";
            this.lblDamagedCars.Size = new System.Drawing.Size(72, 67);
            this.lblDamagedCars.TabIndex = 77;
            this.lblDamagedCars.Text = "0";
            // 
            // lblCustomers
            // 
            this.lblCustomers.AutoSize = true;
            this.lblCustomers.Font = new System.Drawing.Font("Copperplate Gothic Bold", 30F);
            this.lblCustomers.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.lblCustomers.Location = new System.Drawing.Point(83, 37);
            this.lblCustomers.Name = "lblCustomers";
            this.lblCustomers.Size = new System.Drawing.Size(72, 67);
            this.lblCustomers.TabIndex = 77;
            this.lblCustomers.Text = "0";
            // 
            // menu1
            // 
            this.menu1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(53)))), ((int)(((byte)(49)))), ((int)(((byte)(96)))));
            this.menu1.Dock = System.Windows.Forms.DockStyle.Left;
            this.menu1.Location = new System.Drawing.Point(0, 108);
            this.menu1.Name = "menu1";
            this.menu1.Size = new System.Drawing.Size(264, 836);
            this.menu1.TabIndex = 83;
            // 
            // Dashboard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1902, 983);
            this.Controls.Add(this.panel9);
            this.Controls.Add(this.panel7);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.menu1);
            this.Controls.Add(this.BottomPanel);
            this.Controls.Add(this.TopPanel);
            this.Controls.Add(this.panel2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "Dashboard";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Dashbaord";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.Dashbaord_Load);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.TopPanel.ResumeLayout(false);
            this.TopPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            this.panel7.ResumeLayout(false);
            this.panel7.PerformLayout();
            this.panel9.ResumeLayout(false);
            this.panel9.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel TopPanel;
        private System.Windows.Forms.Label lblExit;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Panel BottomPanel;
        private Menu menu1;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Panel panel7;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Panel panel9;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lblTotalCars;
        private System.Windows.Forms.Label lblAvailableCars;
        private System.Windows.Forms.Label lblRentedCars;
        private System.Windows.Forms.Label lblDamagedCars;
        private System.Windows.Forms.Label lblCustomers;
    }
}