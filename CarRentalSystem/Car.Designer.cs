namespace CarRentalSystem
{
    partial class Car
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
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            this.btnRefresh = new System.Windows.Forms.Button();
            this.cbAvailability = new System.Windows.Forms.ComboBox();
            this.btnReset = new System.Windows.Forms.Button();
            this.btnEdit = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnAdd = new System.Windows.Forms.Button();
            this.txtPrice = new System.Windows.Forms.TextBox();
            this.lblPrice = new System.Windows.Forms.Label();
            this.lblBrand = new System.Windows.Forms.Label();
            this.CarDGV = new System.Windows.Forms.DataGridView();
            this.numberPlateDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.brandDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.modelDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ratePerDayDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.carStatusDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.carsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.carRentalDataSet = new CarRentalSystem.CarRentalDataSet();
            this.label3 = new System.Windows.Forms.Label();
            this.txtBrand = new System.Windows.Forms.TextBox();
            this.txtNumPlate = new System.Windows.Forms.TextBox();
            this.lblNumPlate = new System.Windows.Forms.Label();
            this.TopPanel = new System.Windows.Forms.Panel();
            this.lblExit = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.lblTitle = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.txtSearchByNum = new System.Windows.Forms.TextBox();
            this.lblModel = new System.Windows.Forms.Label();
            this.txtModel = new System.Windows.Forms.TextBox();
            this.lblStatus = new System.Windows.Forms.Label();
            this.cbStatus = new System.Windows.Forms.ComboBox();
            this.carsTableAdapter = new CarRentalSystem.CarRentalDataSetTableAdapters.CarsTableAdapter();
            this.label2 = new System.Windows.Forms.Label();
            this.BottomPanel = new System.Windows.Forms.Panel();
            this.menu1 = new CarRentalSystem.Menu();
            ((System.ComponentModel.ISupportInitialize)(this.CarDGV)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.carsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.carRentalDataSet)).BeginInit();
            this.TopPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // btnRefresh
            // 
            this.btnRefresh.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(53)))), ((int)(((byte)(49)))), ((int)(((byte)(96)))));
            this.btnRefresh.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRefresh.Font = new System.Drawing.Font("Perpetua Titling MT", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRefresh.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.btnRefresh.Location = new System.Drawing.Point(1581, 893);
            this.btnRefresh.Name = "btnRefresh";
            this.btnRefresh.Size = new System.Drawing.Size(313, 47);
            this.btnRefresh.TabIndex = 70;
            this.btnRefresh.Text = "refresh table";
            this.btnRefresh.UseVisualStyleBackColor = false;
            this.btnRefresh.Click += new System.EventHandler(this.btnRefresh_Click);
            // 
            // cbAvailability
            // 
            this.cbAvailability.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.cbAvailability.FormattingEnabled = true;
            this.cbAvailability.Items.AddRange(new object[] {
            "Available cars",
            "Damaged cars",
            "Rented cars"});
            this.cbAvailability.Location = new System.Drawing.Point(1012, 196);
            this.cbAvailability.Name = "cbAvailability";
            this.cbAvailability.Size = new System.Drawing.Size(316, 37);
            this.cbAvailability.TabIndex = 69;
            this.cbAvailability.SelectionChangeCommitted += new System.EventHandler(this.cbAvailability_SelectionChangeCommitted);
            // 
            // btnReset
            // 
            this.btnReset.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(53)))), ((int)(((byte)(49)))), ((int)(((byte)(96)))));
            this.btnReset.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnReset.Font = new System.Drawing.Font("Perpetua Titling MT", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnReset.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.btnReset.Location = new System.Drawing.Point(528, 914);
            this.btnReset.Name = "btnReset";
            this.btnReset.Size = new System.Drawing.Size(123, 47);
            this.btnReset.TabIndex = 66;
            this.btnReset.Text = "reset";
            this.btnReset.UseVisualStyleBackColor = false;
            this.btnReset.Click += new System.EventHandler(this.btnReset_Click);
            // 
            // btnEdit
            // 
            this.btnEdit.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(53)))), ((int)(((byte)(49)))), ((int)(((byte)(96)))));
            this.btnEdit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEdit.Font = new System.Drawing.Font("Perpetua Titling MT", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEdit.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.btnEdit.Location = new System.Drawing.Point(399, 753);
            this.btnEdit.Name = "btnEdit";
            this.btnEdit.Size = new System.Drawing.Size(391, 47);
            this.btnEdit.TabIndex = 64;
            this.btnEdit.Text = "EDIT CAR DETAILS";
            this.btnEdit.UseVisualStyleBackColor = false;
            this.btnEdit.Click += new System.EventHandler(this.btnEdit_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(53)))), ((int)(((byte)(49)))), ((int)(((byte)(96)))));
            this.btnDelete.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDelete.Font = new System.Drawing.Font("Perpetua Titling MT", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDelete.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.btnDelete.Location = new System.Drawing.Point(399, 826);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(391, 47);
            this.btnDelete.TabIndex = 63;
            this.btnDelete.Text = "DELETE CAR";
            this.btnDelete.UseVisualStyleBackColor = false;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnAdd
            // 
            this.btnAdd.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(53)))), ((int)(((byte)(49)))), ((int)(((byte)(96)))));
            this.btnAdd.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAdd.Font = new System.Drawing.Font("Perpetua Titling MT", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAdd.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.btnAdd.Location = new System.Drawing.Point(399, 680);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(391, 47);
            this.btnAdd.TabIndex = 62;
            this.btnAdd.Text = "ADD CAR";
            this.btnAdd.UseVisualStyleBackColor = false;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // txtPrice
            // 
            this.txtPrice.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPrice.Location = new System.Drawing.Point(579, 496);
            this.txtPrice.MaxLength = 30;
            this.txtPrice.Name = "txtPrice";
            this.txtPrice.Size = new System.Drawing.Size(261, 35);
            this.txtPrice.TabIndex = 61;
            // 
            // lblPrice
            // 
            this.lblPrice.AutoSize = true;
            this.lblPrice.Font = new System.Drawing.Font("Copperplate Gothic Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPrice.ForeColor = System.Drawing.Color.Black;
            this.lblPrice.Location = new System.Drawing.Point(335, 505);
            this.lblPrice.Name = "lblPrice";
            this.lblPrice.Size = new System.Drawing.Size(194, 26);
            this.lblPrice.TabIndex = 60;
            this.lblPrice.Text = "Rate per Day:";
            this.lblPrice.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblBrand
            // 
            this.lblBrand.AutoSize = true;
            this.lblBrand.Font = new System.Drawing.Font("Copperplate Gothic Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBrand.ForeColor = System.Drawing.Color.Black;
            this.lblBrand.Location = new System.Drawing.Point(336, 360);
            this.lblBrand.Name = "lblBrand";
            this.lblBrand.Size = new System.Drawing.Size(106, 26);
            this.lblBrand.TabIndex = 59;
            this.lblBrand.Text = "Brand:";
            this.lblBrand.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // CarDGV
            // 
            this.CarDGV.AllowUserToAddRows = false;
            this.CarDGV.AllowUserToDeleteRows = false;
            this.CarDGV.AllowUserToResizeColumns = false;
            this.CarDGV.AllowUserToResizeRows = false;
            this.CarDGV.AutoGenerateColumns = false;
            this.CarDGV.BackgroundColor = System.Drawing.Color.WhiteSmoke;
            this.CarDGV.BorderStyle = System.Windows.Forms.BorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.TopCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.Indigo;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F);
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.WhiteSmoke;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.CarDGV.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.CarDGV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.CarDGV.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.numberPlateDataGridViewTextBoxColumn,
            this.brandDataGridViewTextBoxColumn,
            this.modelDataGridViewTextBoxColumn,
            this.ratePerDayDataGridViewTextBoxColumn,
            this.carStatusDataGridViewTextBoxColumn});
            this.CarDGV.DataSource = this.carsBindingSource;
            this.CarDGV.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(53)))), ((int)(((byte)(49)))), ((int)(((byte)(96)))));
            this.CarDGV.Location = new System.Drawing.Point(898, 279);
            this.CarDGV.Margin = new System.Windows.Forms.Padding(0);
            this.CarDGV.MultiSelect = false;
            this.CarDGV.Name = "CarDGV";
            this.CarDGV.ReadOnly = true;
            this.CarDGV.RowHeadersWidth = 35;
            this.CarDGV.RowTemplate.Height = 28;
            this.CarDGV.Size = new System.Drawing.Size(996, 574);
            this.CarDGV.TabIndex = 58;
            this.CarDGV.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.CarDGV_CellClick);
            // 
            // numberPlateDataGridViewTextBoxColumn
            // 
            this.numberPlateDataGridViewTextBoxColumn.DataPropertyName = "NumberPlate";
            this.numberPlateDataGridViewTextBoxColumn.HeaderText = "NUMBER PLATE";
            this.numberPlateDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.numberPlateDataGridViewTextBoxColumn.Name = "numberPlateDataGridViewTextBoxColumn";
            this.numberPlateDataGridViewTextBoxColumn.ReadOnly = true;
            this.numberPlateDataGridViewTextBoxColumn.Width = 125;
            // 
            // brandDataGridViewTextBoxColumn
            // 
            this.brandDataGridViewTextBoxColumn.DataPropertyName = "Brand";
            this.brandDataGridViewTextBoxColumn.HeaderText = "BRAND";
            this.brandDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.brandDataGridViewTextBoxColumn.Name = "brandDataGridViewTextBoxColumn";
            this.brandDataGridViewTextBoxColumn.ReadOnly = true;
            this.brandDataGridViewTextBoxColumn.Width = 125;
            // 
            // modelDataGridViewTextBoxColumn
            // 
            this.modelDataGridViewTextBoxColumn.DataPropertyName = "Model";
            this.modelDataGridViewTextBoxColumn.HeaderText = "MODEL";
            this.modelDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.modelDataGridViewTextBoxColumn.Name = "modelDataGridViewTextBoxColumn";
            this.modelDataGridViewTextBoxColumn.ReadOnly = true;
            this.modelDataGridViewTextBoxColumn.Width = 125;
            // 
            // ratePerDayDataGridViewTextBoxColumn
            // 
            this.ratePerDayDataGridViewTextBoxColumn.DataPropertyName = "RatePerDay";
            this.ratePerDayDataGridViewTextBoxColumn.HeaderText = "RATE/DAY";
            this.ratePerDayDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.ratePerDayDataGridViewTextBoxColumn.Name = "ratePerDayDataGridViewTextBoxColumn";
            this.ratePerDayDataGridViewTextBoxColumn.ReadOnly = true;
            this.ratePerDayDataGridViewTextBoxColumn.Width = 125;
            // 
            // carStatusDataGridViewTextBoxColumn
            // 
            this.carStatusDataGridViewTextBoxColumn.DataPropertyName = "CarStatus";
            this.carStatusDataGridViewTextBoxColumn.HeaderText = "STATUS";
            this.carStatusDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.carStatusDataGridViewTextBoxColumn.Name = "carStatusDataGridViewTextBoxColumn";
            this.carStatusDataGridViewTextBoxColumn.ReadOnly = true;
            this.carStatusDataGridViewTextBoxColumn.Width = 125;
            // 
            // carsBindingSource
            // 
            this.carsBindingSource.DataMember = "Cars";
            this.carsBindingSource.DataSource = this.carRentalDataSet;
            // 
            // carRentalDataSet
            // 
            this.carRentalDataSet.DataSetName = "CarRentalDataSet";
            this.carRentalDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Copperplate Gothic Bold", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(53)))), ((int)(((byte)(49)))), ((int)(((byte)(96)))));
            this.label3.Location = new System.Drawing.Point(1303, 135);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(235, 35);
            this.label3.TabIndex = 57;
            this.label3.Text = "List of Cars";
            // 
            // txtBrand
            // 
            this.txtBrand.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBrand.Location = new System.Drawing.Point(580, 351);
            this.txtBrand.MaxLength = 30;
            this.txtBrand.Name = "txtBrand";
            this.txtBrand.Size = new System.Drawing.Size(261, 35);
            this.txtBrand.TabIndex = 56;
            // 
            // txtNumPlate
            // 
            this.txtNumPlate.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNumPlate.Location = new System.Drawing.Point(580, 285);
            this.txtNumPlate.MaxLength = 30;
            this.txtNumPlate.Name = "txtNumPlate";
            this.txtNumPlate.Size = new System.Drawing.Size(261, 35);
            this.txtNumPlate.TabIndex = 55;
            // 
            // lblNumPlate
            // 
            this.lblNumPlate.AutoSize = true;
            this.lblNumPlate.Font = new System.Drawing.Font("Copperplate Gothic Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNumPlate.ForeColor = System.Drawing.Color.Black;
            this.lblNumPlate.Location = new System.Drawing.Point(335, 285);
            this.lblNumPlate.Name = "lblNumPlate";
            this.lblNumPlate.Size = new System.Drawing.Size(208, 26);
            this.lblNumPlate.TabIndex = 54;
            this.lblNumPlate.Text = "Number Plate:";
            this.lblNumPlate.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
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
            this.TopPanel.Size = new System.Drawing.Size(1924, 108);
            this.TopPanel.TabIndex = 71;
            // 
            // lblExit
            // 
            this.lblExit.AutoSize = true;
            this.lblExit.Dock = System.Windows.Forms.DockStyle.Right;
            this.lblExit.Font = new System.Drawing.Font("Microsoft Sans Serif", 22F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblExit.ForeColor = System.Drawing.Color.White;
            this.lblExit.Location = new System.Drawing.Point(1875, 0);
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
            this.label1.Location = new System.Drawing.Point(892, 53);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(257, 35);
            this.label1.TabIndex = 73;
            this.label1.Text = "Manage Cars";
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
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
            // 
            // txtSearchByNum
            // 
            this.txtSearchByNum.Font = new System.Drawing.Font("Segoe UI", 11F);
            this.txtSearchByNum.ForeColor = System.Drawing.Color.Silver;
            this.txtSearchByNum.Location = new System.Drawing.Point(1388, 196);
            this.txtSearchByNum.MaxLength = 30;
            this.txtSearchByNum.Name = "txtSearchByNum";
            this.txtSearchByNum.Size = new System.Drawing.Size(425, 37);
            this.txtSearchByNum.TabIndex = 74;
            this.txtSearchByNum.Text = " Search for car by number plate";
            this.txtSearchByNum.TextChanged += new System.EventHandler(this.txtSearchByNum_TextChanged);
            this.txtSearchByNum.Enter += new System.EventHandler(this.txtSearchByNum_Enter);
            this.txtSearchByNum.Leave += new System.EventHandler(this.txtSearchByNum_Leave);
            // 
            // lblModel
            // 
            this.lblModel.AutoSize = true;
            this.lblModel.Font = new System.Drawing.Font("Copperplate Gothic Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblModel.ForeColor = System.Drawing.Color.Black;
            this.lblModel.Location = new System.Drawing.Point(344, 434);
            this.lblModel.Name = "lblModel";
            this.lblModel.Size = new System.Drawing.Size(105, 26);
            this.lblModel.TabIndex = 76;
            this.lblModel.Text = "Model:";
            this.lblModel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txtModel
            // 
            this.txtModel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtModel.Location = new System.Drawing.Point(579, 425);
            this.txtModel.MaxLength = 30;
            this.txtModel.Name = "txtModel";
            this.txtModel.Size = new System.Drawing.Size(261, 35);
            this.txtModel.TabIndex = 75;
            // 
            // lblStatus
            // 
            this.lblStatus.AutoSize = true;
            this.lblStatus.Font = new System.Drawing.Font("Copperplate Gothic Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblStatus.ForeColor = System.Drawing.Color.Black;
            this.lblStatus.Location = new System.Drawing.Point(336, 578);
            this.lblStatus.Name = "lblStatus";
            this.lblStatus.Size = new System.Drawing.Size(113, 26);
            this.lblStatus.TabIndex = 78;
            this.lblStatus.Text = "Status:";
            this.lblStatus.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // cbStatus
            // 
            this.cbStatus.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.cbStatus.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(53)))), ((int)(((byte)(49)))), ((int)(((byte)(96)))));
            this.cbStatus.FormattingEnabled = true;
            this.cbStatus.Items.AddRange(new object[] {
            "AVAILABLE",
            "RENTED",
            "IN REPAIR"});
            this.cbStatus.Location = new System.Drawing.Point(579, 575);
            this.cbStatus.MaxDropDownItems = 3;
            this.cbStatus.Name = "cbStatus";
            this.cbStatus.Size = new System.Drawing.Size(261, 37);
            this.cbStatus.TabIndex = 79;
            // 
            // carsTableAdapter
            // 
            this.carsTableAdapter.ClearBeforeFill = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Copperplate Gothic Light", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(53)))), ((int)(((byte)(49)))), ((int)(((byte)(96)))));
            this.label2.Location = new System.Drawing.Point(475, 167);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(281, 38);
            this.label2.TabIndex = 80;
            this.label2.Text = "Car     Details";
            // 
            // BottomPanel
            // 
            this.BottomPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(53)))), ((int)(((byte)(49)))), ((int)(((byte)(96)))));
            this.BottomPanel.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.BottomPanel.Location = new System.Drawing.Point(0, 1000);
            this.BottomPanel.Name = "BottomPanel";
            this.BottomPanel.Size = new System.Drawing.Size(1924, 39);
            this.BottomPanel.TabIndex = 81;
            // 
            // menu1
            // 
            this.menu1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(53)))), ((int)(((byte)(49)))), ((int)(((byte)(96)))));
            this.menu1.Dock = System.Windows.Forms.DockStyle.Left;
            this.menu1.Location = new System.Drawing.Point(0, 108);
            this.menu1.Name = "menu1";
            this.menu1.Size = new System.Drawing.Size(264, 892);
            this.menu1.TabIndex = 82;
            // 
            // Car
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(144F, 144F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(1924, 1039);
            this.Controls.Add(this.menu1);
            this.Controls.Add(this.BottomPanel);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.cbStatus);
            this.Controls.Add(this.lblStatus);
            this.Controls.Add(this.lblModel);
            this.Controls.Add(this.txtModel);
            this.Controls.Add(this.txtSearchByNum);
            this.Controls.Add(this.TopPanel);
            this.Controls.Add(this.btnRefresh);
            this.Controls.Add(this.cbAvailability);
            this.Controls.Add(this.btnReset);
            this.Controls.Add(this.btnEdit);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.txtPrice);
            this.Controls.Add(this.lblPrice);
            this.Controls.Add(this.lblBrand);
            this.Controls.Add(this.CarDGV);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtBrand);
            this.Controls.Add(this.txtNumPlate);
            this.Controls.Add(this.lblNumPlate);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Car";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Cars";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.Cars_Load);
            ((System.ComponentModel.ISupportInitialize)(this.CarDGV)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.carsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.carRentalDataSet)).EndInit();
            this.TopPanel.ResumeLayout(false);
            this.TopPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnRefresh;
        private System.Windows.Forms.ComboBox cbAvailability;
        private System.Windows.Forms.Button btnReset;
        private System.Windows.Forms.Button btnEdit;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.TextBox txtPrice;
        private System.Windows.Forms.Label lblPrice;
        private System.Windows.Forms.Label lblBrand;
        private System.Windows.Forms.DataGridView CarDGV;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtBrand;
        private System.Windows.Forms.TextBox txtNumPlate;
        private System.Windows.Forms.Label lblNumPlate;
        private System.Windows.Forms.Panel TopPanel;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.TextBox txtSearchByNum;
        private System.Windows.Forms.Label lblExit;
        private System.Windows.Forms.Label lblModel;
        private System.Windows.Forms.TextBox txtModel;
        private System.Windows.Forms.Label lblStatus;
        private System.Windows.Forms.ComboBox cbStatus;
        private CarRentalDataSet carRentalDataSet;
        private System.Windows.Forms.BindingSource carsBindingSource;
        private CarRentalDataSetTableAdapters.CarsTableAdapter carsTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn numberPlateDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn brandDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn modelDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn ratePerDayDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn carStatusDataGridViewTextBoxColumn;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel BottomPanel;
        private Menu menu1;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}