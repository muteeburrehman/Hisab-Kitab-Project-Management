﻿namespace HisabKitab
{
    partial class frmExpenses
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle9 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle10 = new System.Windows.Forms.DataGridViewCellStyle();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.lbl1073 = new System.Windows.Forms.Label();
            this.txtExpenseID = new System.Windows.Forms.TextBox();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnAlter = new System.Windows.Forms.Button();
            this.btnReset = new System.Windows.Forms.Button();
            this.btnRefresh = new System.Windows.Forms.Button();
            this.btnClose = new System.Windows.Forms.Button();
            this.btnSubmit = new System.Windows.Forms.Button();
            this.btnExpenditure = new System.Windows.Forms.Button();
            this.cmbExpense = new System.Windows.Forms.ComboBox();
            this.lbl1119 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.lbl1120 = new System.Windows.Forms.Label();
            this.dtpPaidDate = new System.Windows.Forms.DateTimePicker();
            this.lbl1115 = new System.Windows.Forms.Label();
            this.txtDescription = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.txtPaidAmount = new System.Windows.Forms.TextBox();
            this.lbl1116 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.lbl1117 = new System.Windows.Forms.Label();
            this.lbl1118 = new System.Windows.Forms.Label();
            this.dateFrom = new System.Windows.Forms.DateTimePicker();
            this.btnSearch = new System.Windows.Forms.Button();
            this.lbl1080 = new System.Windows.Forms.Label();
            this.lbl1081 = new System.Windows.Forms.Label();
            this.dateTo = new System.Windows.Forms.DateTimePicker();
            this.panel7 = new System.Windows.Forms.Panel();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.errorProvider = new System.Windows.Forms.ErrorProvider(this.components);
            this.panel4 = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel7.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider)).BeginInit();
            this.panel4.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(932, 23);
            this.panel1.TabIndex = 8;
            // 
            // panel2
            // 
            this.panel2.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel2.Location = new System.Drawing.Point(0, 23);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(78, 443);
            this.panel2.TabIndex = 9;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::HisabKitab.Properties.Resources.paper_bill;
            this.pictureBox1.Location = new System.Drawing.Point(483, 172);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(24, 24);
            this.pictureBox1.TabIndex = 162;
            this.pictureBox1.TabStop = false;
            // 
            // lbl1073
            // 
            this.lbl1073.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl1073.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.lbl1073.Location = new System.Drawing.Point(408, 176);
            this.lbl1073.Name = "lbl1073";
            this.lbl1073.Size = new System.Drawing.Size(74, 17);
            this.lbl1073.TabIndex = 161;
            this.lbl1073.Text = "CASH";
            // 
            // txtExpenseID
            // 
            this.txtExpenseID.Font = new System.Drawing.Font("Segoe UI", 9.75F);
            this.txtExpenseID.Location = new System.Drawing.Point(355, 140);
            this.txtExpenseID.Name = "txtExpenseID";
            this.txtExpenseID.ReadOnly = true;
            this.txtExpenseID.Size = new System.Drawing.Size(17, 25);
            this.txtExpenseID.TabIndex = 160;
            this.txtExpenseID.Visible = false;
            // 
            // btnDelete
            // 
            this.btnDelete.BackColor = System.Drawing.Color.DodgerBlue;
            this.btnDelete.FlatAppearance.BorderSize = 0;
            this.btnDelete.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDelete.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDelete.ForeColor = System.Drawing.Color.White;
            this.btnDelete.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.btnDelete.Location = new System.Drawing.Point(564, 205);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(86, 32);
            this.btnDelete.TabIndex = 159;
            this.btnDelete.Text = "DELETE";
            this.btnDelete.UseVisualStyleBackColor = false;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnAlter
            // 
            this.btnAlter.BackColor = System.Drawing.Color.DodgerBlue;
            this.btnAlter.FlatAppearance.BorderSize = 0;
            this.btnAlter.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAlter.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAlter.ForeColor = System.Drawing.Color.White;
            this.btnAlter.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.btnAlter.Location = new System.Drawing.Point(653, 205);
            this.btnAlter.Name = "btnAlter";
            this.btnAlter.Size = new System.Drawing.Size(86, 32);
            this.btnAlter.TabIndex = 158;
            this.btnAlter.Text = "ALTER";
            this.btnAlter.UseVisualStyleBackColor = false;
            this.btnAlter.Click += new System.EventHandler(this.btnAlter_Click);
            // 
            // btnReset
            // 
            this.btnReset.BackColor = System.Drawing.Color.DodgerBlue;
            this.btnReset.FlatAppearance.BorderSize = 0;
            this.btnReset.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnReset.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnReset.ForeColor = System.Drawing.Color.White;
            this.btnReset.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.btnReset.Location = new System.Drawing.Point(475, 205);
            this.btnReset.Name = "btnReset";
            this.btnReset.Size = new System.Drawing.Size(86, 32);
            this.btnReset.TabIndex = 157;
            this.btnReset.Text = "RESET";
            this.btnReset.UseVisualStyleBackColor = false;
            this.btnReset.Click += new System.EventHandler(this.btnReset_Click);
            // 
            // btnRefresh
            // 
            this.btnRefresh.BackColor = System.Drawing.Color.DodgerBlue;
            this.btnRefresh.FlatAppearance.BorderSize = 0;
            this.btnRefresh.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRefresh.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRefresh.ForeColor = System.Drawing.Color.White;
            this.btnRefresh.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.btnRefresh.Location = new System.Drawing.Point(386, 205);
            this.btnRefresh.Name = "btnRefresh";
            this.btnRefresh.Size = new System.Drawing.Size(86, 32);
            this.btnRefresh.TabIndex = 156;
            this.btnRefresh.Text = "REFRESH";
            this.btnRefresh.UseVisualStyleBackColor = false;
            this.btnRefresh.Click += new System.EventHandler(this.btnRefresh_Click);
            // 
            // btnClose
            // 
            this.btnClose.BackColor = System.Drawing.Color.DodgerBlue;
            this.btnClose.FlatAppearance.BorderSize = 0;
            this.btnClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClose.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClose.ForeColor = System.Drawing.Color.White;
            this.btnClose.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.btnClose.Location = new System.Drawing.Point(298, 205);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(86, 32);
            this.btnClose.TabIndex = 155;
            this.btnClose.Text = "CLOSE";
            this.btnClose.UseVisualStyleBackColor = false;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // btnSubmit
            // 
            this.btnSubmit.BackColor = System.Drawing.Color.DodgerBlue;
            this.btnSubmit.FlatAppearance.BorderSize = 0;
            this.btnSubmit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSubmit.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSubmit.ForeColor = System.Drawing.Color.White;
            this.btnSubmit.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.btnSubmit.Location = new System.Drawing.Point(742, 205);
            this.btnSubmit.Name = "btnSubmit";
            this.btnSubmit.Size = new System.Drawing.Size(86, 32);
            this.btnSubmit.TabIndex = 154;
            this.btnSubmit.Text = "SAVE";
            this.btnSubmit.UseVisualStyleBackColor = false;
            this.btnSubmit.Click += new System.EventHandler(this.btnSubmit_Click);
            // 
            // btnExpenditure
            // 
            this.btnExpenditure.BackColor = System.Drawing.Color.White;
            this.btnExpenditure.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnExpenditure.FlatAppearance.BorderSize = 0;
            this.btnExpenditure.FlatAppearance.MouseDownBackColor = System.Drawing.Color.White;
            this.btnExpenditure.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Gainsboro;
            this.btnExpenditure.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnExpenditure.Image = global::HisabKitab.Properties.Resources.Circle_Add__04;
            this.btnExpenditure.Location = new System.Drawing.Point(389, 81);
            this.btnExpenditure.Name = "btnExpenditure";
            this.btnExpenditure.Size = new System.Drawing.Size(17, 17);
            this.btnExpenditure.TabIndex = 153;
            this.btnExpenditure.UseVisualStyleBackColor = false;
            this.btnExpenditure.Click += new System.EventHandler(this.btnExpenditure_Click);
            // 
            // cmbExpense
            // 
            this.cmbExpense.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbExpense.FormattingEnabled = true;
            this.cmbExpense.Location = new System.Drawing.Point(374, 78);
            this.cmbExpense.Name = "cmbExpense";
            this.cmbExpense.Size = new System.Drawing.Size(267, 25);
            this.cmbExpense.TabIndex = 150;
            // 
            // lbl1119
            // 
            this.lbl1119.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.lbl1119.Location = new System.Drawing.Point(664, 84);
            this.lbl1119.Name = "lbl1119";
            this.lbl1119.Size = new System.Drawing.Size(168, 17);
            this.lbl1119.TabIndex = 151;
            this.lbl1119.Text = "Expenditure Account";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold);
            this.label14.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.label14.Location = new System.Drawing.Point(646, 82);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(11, 17);
            this.label14.TabIndex = 152;
            this.label14.Text = ":";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold);
            this.label12.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.label12.Location = new System.Drawing.Point(646, 113);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(11, 17);
            this.label12.TabIndex = 149;
            this.label12.Text = ":";
            // 
            // lbl1120
            // 
            this.lbl1120.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.lbl1120.Location = new System.Drawing.Point(663, 115);
            this.lbl1120.Name = "lbl1120";
            this.lbl1120.Size = new System.Drawing.Size(168, 17);
            this.lbl1120.TabIndex = 148;
            this.lbl1120.Text = "Paid Date";
            // 
            // dtpPaidDate
            // 
            this.dtpPaidDate.CustomFormat = "MMM-dd-yyyy";
            this.dtpPaidDate.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpPaidDate.Location = new System.Drawing.Point(511, 109);
            this.dtpPaidDate.Name = "dtpPaidDate";
            this.dtpPaidDate.Size = new System.Drawing.Size(130, 25);
            this.dtpPaidDate.TabIndex = 147;
            // 
            // lbl1115
            // 
            this.lbl1115.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.lbl1115.Location = new System.Drawing.Point(663, 145);
            this.lbl1115.Name = "lbl1115";
            this.lbl1115.Size = new System.Drawing.Size(168, 17);
            this.lbl1115.TabIndex = 136;
            this.lbl1115.Text = "Description";
            // 
            // txtDescription
            // 
            this.txtDescription.Font = new System.Drawing.Font("Segoe UI", 9.75F);
            this.txtDescription.Location = new System.Drawing.Point(374, 140);
            this.txtDescription.Name = "txtDescription";
            this.txtDescription.Size = new System.Drawing.Size(267, 25);
            this.txtDescription.TabIndex = 134;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold);
            this.label7.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.label7.Location = new System.Drawing.Point(646, 143);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(11, 17);
            this.label7.TabIndex = 137;
            this.label7.Text = ":";
            // 
            // txtPaidAmount
            // 
            this.txtPaidAmount.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPaidAmount.Location = new System.Drawing.Point(511, 170);
            this.txtPaidAmount.Name = "txtPaidAmount";
            this.txtPaidAmount.Size = new System.Drawing.Size(130, 25);
            this.txtPaidAmount.TabIndex = 135;
            // 
            // lbl1116
            // 
            this.lbl1116.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.lbl1116.Location = new System.Drawing.Point(663, 176);
            this.lbl1116.Name = "lbl1116";
            this.lbl1116.Size = new System.Drawing.Size(168, 17);
            this.lbl1116.TabIndex = 138;
            this.lbl1116.Text = "Amount";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold);
            this.label10.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.label10.Location = new System.Drawing.Point(646, 174);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(11, 17);
            this.label10.TabIndex = 139;
            this.label10.Text = ":";
            // 
            // lbl1117
            // 
            this.lbl1117.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Bold);
            this.lbl1117.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.lbl1117.Location = new System.Drawing.Point(339, 15);
            this.lbl1117.Name = "lbl1117";
            this.lbl1117.Size = new System.Drawing.Size(506, 30);
            this.lbl1117.TabIndex = 18;
            this.lbl1117.Text = "Expense";
            // 
            // lbl1118
            // 
            this.lbl1118.ForeColor = System.Drawing.Color.DimGray;
            this.lbl1118.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.lbl1118.Location = new System.Drawing.Point(339, 49);
            this.lbl1118.Name = "lbl1118";
            this.lbl1118.Size = new System.Drawing.Size(506, 17);
            this.lbl1118.TabIndex = 19;
            this.lbl1118.Text = "It contains the following fields to maintain Expense\r\n";
            // 
            // dateFrom
            // 
            this.dateFrom.CustomFormat = "MMM-dd-yyyy";
            this.dateFrom.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateFrom.Location = new System.Drawing.Point(597, 249);
            this.dateFrom.Name = "dateFrom";
            this.dateFrom.RightToLeftLayout = true;
            this.dateFrom.Size = new System.Drawing.Size(130, 25);
            this.dateFrom.TabIndex = 153;
            // 
            // btnSearch
            // 
            this.btnSearch.BackColor = System.Drawing.Color.DodgerBlue;
            this.btnSearch.FlatAppearance.BorderSize = 0;
            this.btnSearch.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSearch.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSearch.ForeColor = System.Drawing.Color.White;
            this.btnSearch.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.btnSearch.Location = new System.Drawing.Point(298, 249);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(86, 25);
            this.btnSearch.TabIndex = 153;
            this.btnSearch.Text = "SEARCH";
            this.btnSearch.UseVisualStyleBackColor = false;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // lbl1080
            // 
            this.lbl1080.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.lbl1080.Location = new System.Drawing.Point(727, 253);
            this.lbl1080.Name = "lbl1080";
            this.lbl1080.Size = new System.Drawing.Size(95, 17);
            this.lbl1080.TabIndex = 149;
            this.lbl1080.Text = "From";
            // 
            // lbl1081
            // 
            this.lbl1081.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.lbl1081.Location = new System.Drawing.Point(524, 253);
            this.lbl1081.Name = "lbl1081";
            this.lbl1081.Size = new System.Drawing.Size(67, 17);
            this.lbl1081.TabIndex = 154;
            this.lbl1081.Text = "To";
            // 
            // dateTo
            // 
            this.dateTo.CustomFormat = "MMM-dd-yyyy";
            this.dateTo.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateTo.Location = new System.Drawing.Point(388, 249);
            this.dateTo.Name = "dateTo";
            this.dateTo.RightToLeftLayout = true;
            this.dateTo.Size = new System.Drawing.Size(130, 25);
            this.dateTo.TabIndex = 155;
            // 
            // panel7
            // 
            this.panel7.Controls.Add(this.dataGridView1);
            this.panel7.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel7.Location = new System.Drawing.Point(0, 280);
            this.panel7.Name = "panel7";
            this.panel7.Size = new System.Drawing.Size(851, 163);
            this.panel7.TabIndex = 150;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            dataGridViewCellStyle6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(125)))), ((int)(((byte)(154)))));
            this.dataGridView1.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle6;
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.BackgroundColor = System.Drawing.SystemColors.Control;
            this.dataGridView1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dataGridView1.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle7.Font = new System.Drawing.Font("Segoe UI", 9.75F);
            dataGridViewCellStyle7.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle7;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column3,
            this.Column4,
            this.Column5});
            dataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle8.BackColor = System.Drawing.Color.DarkGray;
            dataGridViewCellStyle8.Font = new System.Drawing.Font("Segoe UI", 9.75F);
            dataGridViewCellStyle8.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle8.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(125)))), ((int)(((byte)(154)))));
            dataGridViewCellStyle8.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle8.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridView1.DefaultCellStyle = dataGridViewCellStyle8;
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView1.GridColor = System.Drawing.SystemColors.Control;
            this.dataGridView1.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.dataGridView1.Location = new System.Drawing.Point(0, 0);
            this.dataGridView1.MultiSelect = false;
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Sunken;
            dataGridViewCellStyle9.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle9.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle9.Font = new System.Drawing.Font("Segoe UI", 9.75F);
            dataGridViewCellStyle9.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle9.SelectionBackColor = System.Drawing.Color.Gainsboro;
            dataGridViewCellStyle9.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle9.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView1.RowHeadersDefaultCellStyle = dataGridViewCellStyle9;
            this.dataGridView1.RowHeadersVisible = false;
            dataGridViewCellStyle10.BackColor = System.Drawing.Color.Gainsboro;
            this.dataGridView1.RowsDefaultCellStyle = dataGridViewCellStyle10;
            this.dataGridView1.RowTemplate.DefaultCellStyle.BackColor = System.Drawing.Color.Gainsboro;
            this.dataGridView1.RowTemplate.DefaultCellStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(125)))), ((int)(((byte)(154)))));
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.ShowEditingIcon = false;
            this.dataGridView1.Size = new System.Drawing.Size(851, 163);
            this.dataGridView1.TabIndex = 108;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // Column1
            // 
            this.Column1.DataPropertyName = "Expense_ID";
            this.Column1.HeaderText = "PAY ID";
            this.Column1.Name = "Column1";
            this.Column1.ReadOnly = true;
            // 
            // Column2
            // 
            this.Column2.DataPropertyName = "ExpenditureAccount";
            this.Column2.HeaderText = "Expenditure";
            this.Column2.Name = "Column2";
            this.Column2.ReadOnly = true;
            // 
            // Column3
            // 
            this.Column3.DataPropertyName = "PaidDate";
            this.Column3.HeaderText = "Paid Date";
            this.Column3.Name = "Column3";
            this.Column3.ReadOnly = true;
            // 
            // Column4
            // 
            this.Column4.DataPropertyName = "Description";
            this.Column4.HeaderText = "Description";
            this.Column4.Name = "Column4";
            this.Column4.ReadOnly = true;
            // 
            // Column5
            // 
            this.Column5.DataPropertyName = "Amount";
            this.Column5.HeaderText = "Amount";
            this.Column5.Name = "Column5";
            this.Column5.ReadOnly = true;
            // 
            // errorProvider
            // 
            this.errorProvider.BlinkStyle = System.Windows.Forms.ErrorBlinkStyle.NeverBlink;
            this.errorProvider.ContainerControl = this;
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.dateFrom);
            this.panel4.Controls.Add(this.btnSearch);
            this.panel4.Controls.Add(this.pictureBox1);
            this.panel4.Controls.Add(this.lbl1080);
            this.panel4.Controls.Add(this.panel7);
            this.panel4.Controls.Add(this.lbl1081);
            this.panel4.Controls.Add(this.lbl1073);
            this.panel4.Controls.Add(this.dateTo);
            this.panel4.Controls.Add(this.txtExpenseID);
            this.panel4.Controls.Add(this.btnDelete);
            this.panel4.Controls.Add(this.btnAlter);
            this.panel4.Controls.Add(this.lbl1118);
            this.panel4.Controls.Add(this.btnReset);
            this.panel4.Controls.Add(this.lbl1117);
            this.panel4.Controls.Add(this.btnRefresh);
            this.panel4.Controls.Add(this.label10);
            this.panel4.Controls.Add(this.btnClose);
            this.panel4.Controls.Add(this.lbl1116);
            this.panel4.Controls.Add(this.btnSubmit);
            this.panel4.Controls.Add(this.txtPaidAmount);
            this.panel4.Controls.Add(this.btnExpenditure);
            this.panel4.Controls.Add(this.label7);
            this.panel4.Controls.Add(this.txtDescription);
            this.panel4.Controls.Add(this.lbl1119);
            this.panel4.Controls.Add(this.lbl1115);
            this.panel4.Controls.Add(this.label14);
            this.panel4.Controls.Add(this.dtpPaidDate);
            this.panel4.Controls.Add(this.label12);
            this.panel4.Controls.Add(this.lbl1120);
            this.panel4.Controls.Add(this.cmbExpense);
            this.panel4.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel4.Location = new System.Drawing.Point(78, 23);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(851, 443);
            this.panel4.TabIndex = 151;
            // 
            // frmExpenses
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(932, 466);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("Segoe UI", 9.75F);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "frmExpenses";
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.RightToLeftLayout = true;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Expenses";
            this.Load += new System.EventHandler(this.frmExpenses_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel7.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider)).EndInit();
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label lbl1117;
        private System.Windows.Forms.Label lbl1118;
        private System.Windows.Forms.Label lbl1115;
        private System.Windows.Forms.TextBox txtDescription;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtPaidAmount;
        private System.Windows.Forms.Label lbl1116;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label lbl1120;
        private System.Windows.Forms.DateTimePicker dtpPaidDate;
        private System.Windows.Forms.ComboBox cmbExpense;
        private System.Windows.Forms.Label lbl1119;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Button btnExpenditure;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnAlter;
        private System.Windows.Forms.Button btnReset;
        private System.Windows.Forms.Button btnRefresh;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.Button btnSubmit;
        private System.Windows.Forms.DateTimePicker dateFrom;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.Label lbl1080;
        private System.Windows.Forms.Label lbl1081;
        private System.Windows.Forms.DateTimePicker dateTo;
        private System.Windows.Forms.Panel panel7;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.ErrorProvider errorProvider;
        private System.Windows.Forms.TextBox txtExpenseID;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label lbl1073;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column5;
        private System.Windows.Forms.Panel panel4;
    }
}