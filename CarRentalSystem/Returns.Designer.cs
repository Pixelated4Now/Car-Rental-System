namespace  CarRentalSystem
{
    partial class Returns
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
            this.button1 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.car_id = new System.Windows.Forms.TextBox();
            this.button2 = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.date = new System.Windows.Forms.DateTimePicker();
            this.fines = new System.Windows.Forms.TextBox();
            this.days_elapsed = new System.Windows.Forms.TextBox();
            this.cus_id = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label8 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(53)))), ((int)(((byte)(50)))), ((int)(((byte)(97)))));
            this.button1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.button1.Font = new System.Drawing.Font("Copperplate Gothic Bold", 8.25F);
            this.button1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.button1.Location = new System.Drawing.Point(306, 332);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(133, 37);
            this.button1.TabIndex = 0;
            this.button1.Text = "Ok";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(81, 77);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(60, 15);
            this.label1.TabIndex = 2;
            this.label1.Text = "Car ID";
            
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(81, 107);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(107, 15);
            this.label2.TabIndex = 3;
            this.label2.Text = "Customer ID";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(81, 145);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(46, 15);
            this.label3.TabIndex = 4;
            this.label3.Text = "Date";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(81, 183);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(116, 15);
            this.label5.TabIndex = 6;
            this.label5.Text = "Days Elapsed";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(81, 216);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(117, 15);
            this.label6.TabIndex = 7;
            this.label6.Text = "Pending Fines";
            // 
            // car_id
            // 
            this.car_id.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.car_id.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.car_id.Location = new System.Drawing.Point(306, 69);
            this.car_id.Multiline = true;
            this.car_id.Name = "car_id";
            this.car_id.Size = new System.Drawing.Size(368, 23);
            this.car_id.TabIndex = 8;
            
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(53)))), ((int)(((byte)(50)))), ((int)(((byte)(97)))));
            this.button2.Font = new System.Drawing.Font("Copperplate Gothic Bold", 8.25F);
            this.button2.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.button2.Location = new System.Drawing.Point(481, 332);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(133, 37);
            this.button2.TabIndex = 14;
            this.button2.Text = "Cancel";
            this.button2.UseVisualStyleBackColor = false;
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.groupBox1.Controls.Add(this.date);
            this.groupBox1.Controls.Add(this.fines);
            this.groupBox1.Controls.Add(this.days_elapsed);
            this.groupBox1.Controls.Add(this.cus_id);
            this.groupBox1.Controls.Add(this.button2);
            this.groupBox1.Controls.Add(this.button1);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.car_id);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Font = new System.Drawing.Font("Copperplate Gothic Bold", 8.25F);
            this.groupBox1.Location = new System.Drawing.Point(256, 134);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(762, 386);
            this.groupBox1.TabIndex = 15;
            this.groupBox1.TabStop = false;
            
            // 
            // date
            // 
            this.date.AccessibleRole = System.Windows.Forms.AccessibleRole.ButtonMenu;
            this.date.CalendarMonthBackground = System.Drawing.SystemColors.InactiveBorder;
            this.date.Location = new System.Drawing.Point(306, 149);
            this.date.Name = "date";
            this.date.Size = new System.Drawing.Size(368, 23);
            this.date.TabIndex = 20;
            
            // 
            // fines
            // 
            this.fines.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.fines.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.fines.Location = new System.Drawing.Point(306, 216);
            this.fines.Multiline = true;
            this.fines.Name = "fines";
            this.fines.Size = new System.Drawing.Size(368, 23);
            this.fines.TabIndex = 19;
            
            // 
            // days_elapsed
            // 
            this.days_elapsed.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.days_elapsed.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.days_elapsed.Location = new System.Drawing.Point(306, 183);
            this.days_elapsed.Multiline = true;
            this.days_elapsed.Name = "days_elapsed";
            this.days_elapsed.Size = new System.Drawing.Size(368, 23);
            this.days_elapsed.TabIndex = 18;
            // 
            // cus_id
            // 
            this.cus_id.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.cus_id.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.cus_id.Location = new System.Drawing.Point(306, 107);
            this.cus_id.Multiline = true;
            this.cus_id.Name = "cus_id";
            this.cus_id.Size = new System.Drawing.Size(368, 23);
            this.cus_id.TabIndex = 15;
            // 
            // label7
            // 
            this.label7.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(53)))), ((int)(((byte)(50)))), ((int)(((byte)(97)))));
            this.label7.Font = new System.Drawing.Font("Copperplate Gothic Bold", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.SystemColors.Control;
            this.label7.Location = new System.Drawing.Point(276, 16);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(264, 68);
            this.label7.TabIndex = 16;
            this.label7.Text = "Rent Your Car\r\n\r\n";
            this.label7.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(53)))), ((int)(((byte)(97)))));
            this.panel1.Controls.Add(this.label8);
            this.panel1.Controls.Add(this.label7);
            this.panel1.Font = new System.Drawing.Font("Copperplate Gothic Bold", 8.25F);
            this.panel1.Location = new System.Drawing.Point(256, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(762, 98);
            this.panel1.TabIndex = 18;
            // 
            // label8
            // 
            this.label8.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label8.AutoSize = true;
            this.label8.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label8.Location = new System.Drawing.Point(281, 51);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(253, 15);
            this.label8.TabIndex = 17;
            this.label8.Text = "For an unforgettable journey";
            
            // 
            // Returns
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(1213, 613);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.groupBox1);
            this.Name = "Returns";
            this.Text = "Return";
            
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox car_id;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox fines;
        private System.Windows.Forms.TextBox days_elapsed;
        private System.Windows.Forms.TextBox cus_id;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.DateTimePicker date;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label8;
    }
}

