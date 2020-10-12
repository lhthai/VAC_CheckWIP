namespace CheckWIP
{
    partial class FrmMain
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmMain));
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnConfig = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.dtInventoryPeriod = new System.Windows.Forms.DataGridView();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnDeleteInvPeriod = new System.Windows.Forms.Button();
            this.txtInventoryPeriodDesc = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.btnCreatePeriod = new System.Windows.Forms.Button();
            this.dtpkCheckDate = new System.Windows.Forms.DateTimePicker();
            this.label5 = new System.Windows.Forms.Label();
            this.txtPeriodCode = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.progressSystem = new System.Windows.Forms.ProgressBar();
            this.lblTotalSystem = new System.Windows.Forms.Label();
            this.dtPartInSystem = new System.Windows.Forms.DataGridView();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btnDeleteSystem = new System.Windows.Forms.Button();
            this.btnOpenSystem = new System.Windows.Forms.Button();
            this.cbSheetSystem = new System.Windows.Forms.ComboBox();
            this.label8 = new System.Windows.Forms.Label();
            this.cbInventoryPeriodSystem = new System.Windows.Forms.ComboBox();
            this.txtExcelSystem = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.btnImportSystem = new System.Windows.Forms.Button();
            this.label9 = new System.Windows.Forms.Label();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.progressActual = new System.Windows.Forms.ProgressBar();
            this.lblTotalActual = new System.Windows.Forms.Label();
            this.dtPartInActual = new System.Windows.Forms.DataGridView();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.cbSheetActual = new System.Windows.Forms.ComboBox();
            this.btnDeleteActual = new System.Windows.Forms.Button();
            this.label10 = new System.Windows.Forms.Label();
            this.btnOpenActual = new System.Windows.Forms.Button();
            this.cbInventoryPeriodActual = new System.Windows.Forms.ComboBox();
            this.txtExcelActual = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.btnImportActual = new System.Windows.Forms.Button();
            this.label12 = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel2.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtInventoryPeriod)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtPartInSystem)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.tabPage3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtPartInActual)).BeginInit();
            this.groupBox3.SuspendLayout();
            this.panel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.btnConfig);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1226, 82);
            this.panel1.TabIndex = 0;
            // 
            // btnConfig
            // 
            this.btnConfig.BackColor = System.Drawing.Color.Transparent;
            this.btnConfig.FlatAppearance.BorderSize = 0;
            this.btnConfig.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnConfig.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnConfig.ForeColor = System.Drawing.Color.White;
            this.btnConfig.Image = ((System.Drawing.Image)(resources.GetObject("btnConfig.Image")));
            this.btnConfig.Location = new System.Drawing.Point(1172, 26);
            this.btnConfig.Name = "btnConfig";
            this.btnConfig.Size = new System.Drawing.Size(38, 31);
            this.btnConfig.TabIndex = 7;
            this.btnConfig.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnConfig.UseVisualStyleBackColor = false;
            this.btnConfig.Click += new System.EventHandler(this.btnConfig_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Tai Le", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(474, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(290, 48);
            this.label1.TabIndex = 1;
            this.label1.Text = "VAC Check WIP";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::CheckWIP.Properties.Resources.VAC_Logo_NoBG;
            this.pictureBox1.Location = new System.Drawing.Point(19, 14);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(254, 56);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.tabControl1);
            this.panel2.Location = new System.Drawing.Point(0, 82);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1226, 681);
            this.panel2.TabIndex = 1;
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Controls.Add(this.tabPage3);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Top;
            this.tabControl1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabControl1.Location = new System.Drawing.Point(0, 0);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(1226, 692);
            this.tabControl1.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.dtInventoryPeriod);
            this.tabPage1.Controls.Add(this.groupBox1);
            this.tabPage1.Location = new System.Drawing.Point(4, 29);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(1218, 659);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Inventory Period";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // dtInventoryPeriod
            // 
            this.dtInventoryPeriod.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dtInventoryPeriod.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtInventoryPeriod.Location = new System.Drawing.Point(24, 307);
            this.dtInventoryPeriod.Name = "dtInventoryPeriod";
            this.dtInventoryPeriod.Size = new System.Drawing.Size(1170, 307);
            this.dtInventoryPeriod.TabIndex = 1;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnDeleteInvPeriod);
            this.groupBox1.Controls.Add(this.txtInventoryPeriodDesc);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.btnCreatePeriod);
            this.groupBox1.Controls.Add(this.dtpkCheckDate);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.txtPeriodCode);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Location = new System.Drawing.Point(24, 23);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(694, 227);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Create Inventory Period";
            // 
            // btnDeleteInvPeriod
            // 
            this.btnDeleteInvPeriod.BackColor = System.Drawing.Color.Gray;
            this.btnDeleteInvPeriod.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDeleteInvPeriod.ForeColor = System.Drawing.Color.White;
            this.btnDeleteInvPeriod.Location = new System.Drawing.Point(269, 168);
            this.btnDeleteInvPeriod.Name = "btnDeleteInvPeriod";
            this.btnDeleteInvPeriod.Size = new System.Drawing.Size(106, 39);
            this.btnDeleteInvPeriod.TabIndex = 12;
            this.btnDeleteInvPeriod.Text = "Delete";
            this.btnDeleteInvPeriod.UseVisualStyleBackColor = false;
            this.btnDeleteInvPeriod.Click += new System.EventHandler(this.btnDeleteInvPeriod_Click);
            // 
            // txtInventoryPeriodDesc
            // 
            this.txtInventoryPeriodDesc.Location = new System.Drawing.Point(125, 82);
            this.txtInventoryPeriodDesc.Name = "txtInventoryPeriodDesc";
            this.txtInventoryPeriodDesc.Size = new System.Drawing.Size(250, 26);
            this.txtInventoryPeriodDesc.TabIndex = 6;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(7, 85);
            this.label6.Name = "label6";
            this.label6.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.label6.Size = new System.Drawing.Size(93, 20);
            this.label6.TabIndex = 5;
            this.label6.Text = "Description:";
            // 
            // btnCreatePeriod
            // 
            this.btnCreatePeriod.BackColor = System.Drawing.Color.DodgerBlue;
            this.btnCreatePeriod.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCreatePeriod.ForeColor = System.Drawing.Color.White;
            this.btnCreatePeriod.Location = new System.Drawing.Point(125, 168);
            this.btnCreatePeriod.Name = "btnCreatePeriod";
            this.btnCreatePeriod.Size = new System.Drawing.Size(106, 39);
            this.btnCreatePeriod.TabIndex = 4;
            this.btnCreatePeriod.Text = "Create";
            this.btnCreatePeriod.UseVisualStyleBackColor = false;
            this.btnCreatePeriod.Click += new System.EventHandler(this.btnCreatePeriod_Click);
            // 
            // dtpkCheckDate
            // 
            this.dtpkCheckDate.CustomFormat = "dd/MM/yyyy";
            this.dtpkCheckDate.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpkCheckDate.Location = new System.Drawing.Point(125, 124);
            this.dtpkCheckDate.Name = "dtpkCheckDate";
            this.dtpkCheckDate.Size = new System.Drawing.Size(250, 26);
            this.dtpkCheckDate.TabIndex = 3;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(7, 124);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(94, 20);
            this.label5.TabIndex = 2;
            this.label5.Text = "Check date:";
            // 
            // txtPeriodCode
            // 
            this.txtPeriodCode.Location = new System.Drawing.Point(125, 41);
            this.txtPeriodCode.Name = "txtPeriodCode";
            this.txtPeriodCode.Size = new System.Drawing.Size(250, 26);
            this.txtPeriodCode.TabIndex = 1;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(7, 44);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(97, 20);
            this.label4.TabIndex = 0;
            this.label4.Text = "Period code:";
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.progressSystem);
            this.tabPage2.Controls.Add(this.lblTotalSystem);
            this.tabPage2.Controls.Add(this.dtPartInSystem);
            this.tabPage2.Controls.Add(this.groupBox2);
            this.tabPage2.Location = new System.Drawing.Point(4, 29);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(1218, 659);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Parts in System";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // progressSystem
            // 
            this.progressSystem.Location = new System.Drawing.Point(246, 210);
            this.progressSystem.Name = "progressSystem";
            this.progressSystem.Size = new System.Drawing.Size(521, 23);
            this.progressSystem.TabIndex = 12;
            this.progressSystem.Visible = false;
            // 
            // lblTotalSystem
            // 
            this.lblTotalSystem.AutoSize = true;
            this.lblTotalSystem.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotalSystem.Location = new System.Drawing.Point(21, 213);
            this.lblTotalSystem.Name = "lblTotalSystem";
            this.lblTotalSystem.Size = new System.Drawing.Size(54, 20);
            this.lblTotalSystem.TabIndex = 11;
            this.lblTotalSystem.Text = "Total:";
            // 
            // dtPartInSystem
            // 
            this.dtPartInSystem.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dtPartInSystem.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtPartInSystem.Location = new System.Drawing.Point(25, 248);
            this.dtPartInSystem.Name = "dtPartInSystem";
            this.dtPartInSystem.Size = new System.Drawing.Size(1169, 401);
            this.dtPartInSystem.TabIndex = 2;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.btnDeleteSystem);
            this.groupBox2.Controls.Add(this.btnOpenSystem);
            this.groupBox2.Controls.Add(this.cbSheetSystem);
            this.groupBox2.Controls.Add(this.label8);
            this.groupBox2.Controls.Add(this.cbInventoryPeriodSystem);
            this.groupBox2.Controls.Add(this.txtExcelSystem);
            this.groupBox2.Controls.Add(this.label7);
            this.groupBox2.Controls.Add(this.btnImportSystem);
            this.groupBox2.Controls.Add(this.label9);
            this.groupBox2.Location = new System.Drawing.Point(25, 16);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(742, 177);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Import Parts in System";
            // 
            // btnDeleteSystem
            // 
            this.btnDeleteSystem.BackColor = System.Drawing.Color.Gray;
            this.btnDeleteSystem.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDeleteSystem.ForeColor = System.Drawing.Color.White;
            this.btnDeleteSystem.Location = new System.Drawing.Point(239, 122);
            this.btnDeleteSystem.Name = "btnDeleteSystem";
            this.btnDeleteSystem.Size = new System.Drawing.Size(106, 39);
            this.btnDeleteSystem.TabIndex = 11;
            this.btnDeleteSystem.Text = "Delete";
            this.btnDeleteSystem.UseVisualStyleBackColor = false;
            this.btnDeleteSystem.Click += new System.EventHandler(this.btnDeleteSystem_Click);
            // 
            // btnOpenSystem
            // 
            this.btnOpenSystem.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnOpenSystem.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnOpenSystem.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnOpenSystem.ForeColor = System.Drawing.Color.White;
            this.btnOpenSystem.Image = global::CheckWIP.Properties.Resources.excel;
            this.btnOpenSystem.Location = new System.Drawing.Point(681, 25);
            this.btnOpenSystem.Name = "btnOpenSystem";
            this.btnOpenSystem.Size = new System.Drawing.Size(54, 52);
            this.btnOpenSystem.TabIndex = 10;
            this.btnOpenSystem.Text = " ";
            this.btnOpenSystem.UseVisualStyleBackColor = false;
            this.btnOpenSystem.Click += new System.EventHandler(this.btnOpenFileSystem_Click);
            // 
            // cbSheetSystem
            // 
            this.cbSheetSystem.FormattingEnabled = true;
            this.cbSheetSystem.Location = new System.Drawing.Point(96, 79);
            this.cbSheetSystem.Name = "cbSheetSystem";
            this.cbSheetSystem.Size = new System.Drawing.Size(171, 28);
            this.cbSheetSystem.TabIndex = 9;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(7, 82);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(56, 20);
            this.label8.TabIndex = 8;
            this.label8.Text = "Sheet:";
            // 
            // cbInventoryPeriodSystem
            // 
            this.cbInventoryPeriodSystem.FormattingEnabled = true;
            this.cbInventoryPeriodSystem.Location = new System.Drawing.Point(453, 79);
            this.cbInventoryPeriodSystem.Name = "cbInventoryPeriodSystem";
            this.cbInventoryPeriodSystem.Size = new System.Drawing.Size(215, 28);
            this.cbInventoryPeriodSystem.TabIndex = 7;
            this.cbInventoryPeriodSystem.SelectedIndexChanged += new System.EventHandler(this.cbInventoryPeriodSystem_SelectedIndexChanged);
            // 
            // txtExcelSystem
            // 
            this.txtExcelSystem.Location = new System.Drawing.Point(96, 38);
            this.txtExcelSystem.Name = "txtExcelSystem";
            this.txtExcelSystem.Size = new System.Drawing.Size(572, 26);
            this.txtExcelSystem.TabIndex = 6;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(7, 41);
            this.label7.Name = "label7";
            this.label7.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.label7.Size = new System.Drawing.Size(51, 20);
            this.label7.TabIndex = 5;
            this.label7.Text = "Excel:";
            // 
            // btnImportSystem
            // 
            this.btnImportSystem.BackColor = System.Drawing.Color.DodgerBlue;
            this.btnImportSystem.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnImportSystem.ForeColor = System.Drawing.Color.White;
            this.btnImportSystem.Location = new System.Drawing.Point(96, 122);
            this.btnImportSystem.Name = "btnImportSystem";
            this.btnImportSystem.Size = new System.Drawing.Size(106, 39);
            this.btnImportSystem.TabIndex = 4;
            this.btnImportSystem.Text = "Import";
            this.btnImportSystem.UseVisualStyleBackColor = false;
            this.btnImportSystem.Click += new System.EventHandler(this.btnImportSystem_Click);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(317, 82);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(127, 20);
            this.label9.TabIndex = 0;
            this.label9.Text = "Inventory Period:";
            // 
            // tabPage3
            // 
            this.tabPage3.Controls.Add(this.progressActual);
            this.tabPage3.Controls.Add(this.lblTotalActual);
            this.tabPage3.Controls.Add(this.dtPartInActual);
            this.tabPage3.Controls.Add(this.groupBox3);
            this.tabPage3.Location = new System.Drawing.Point(4, 29);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage3.Size = new System.Drawing.Size(1218, 659);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "Parts in Actual";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // progressActual
            // 
            this.progressActual.Location = new System.Drawing.Point(239, 220);
            this.progressActual.Name = "progressActual";
            this.progressActual.Size = new System.Drawing.Size(521, 23);
            this.progressActual.TabIndex = 15;
            this.progressActual.Visible = false;
            // 
            // lblTotalActual
            // 
            this.lblTotalActual.AutoSize = true;
            this.lblTotalActual.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotalActual.Location = new System.Drawing.Point(11, 220);
            this.lblTotalActual.Name = "lblTotalActual";
            this.lblTotalActual.Size = new System.Drawing.Size(54, 20);
            this.lblTotalActual.TabIndex = 14;
            this.lblTotalActual.Text = "Total:";
            // 
            // dtPartInActual
            // 
            this.dtPartInActual.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dtPartInActual.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtPartInActual.Location = new System.Drawing.Point(15, 260);
            this.dtPartInActual.Name = "dtPartInActual";
            this.dtPartInActual.Size = new System.Drawing.Size(1191, 375);
            this.dtPartInActual.TabIndex = 3;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.cbSheetActual);
            this.groupBox3.Controls.Add(this.btnDeleteActual);
            this.groupBox3.Controls.Add(this.label10);
            this.groupBox3.Controls.Add(this.btnOpenActual);
            this.groupBox3.Controls.Add(this.cbInventoryPeriodActual);
            this.groupBox3.Controls.Add(this.txtExcelActual);
            this.groupBox3.Controls.Add(this.label11);
            this.groupBox3.Controls.Add(this.btnImportActual);
            this.groupBox3.Controls.Add(this.label12);
            this.groupBox3.Location = new System.Drawing.Point(18, 15);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(742, 189);
            this.groupBox3.TabIndex = 2;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Import Parts in Actual";
            // 
            // cbSheetActual
            // 
            this.cbSheetActual.FormattingEnabled = true;
            this.cbSheetActual.Location = new System.Drawing.Point(97, 76);
            this.cbSheetActual.Name = "cbSheetActual";
            this.cbSheetActual.Size = new System.Drawing.Size(184, 28);
            this.cbSheetActual.TabIndex = 9;
            // 
            // btnDeleteActual
            // 
            this.btnDeleteActual.BackColor = System.Drawing.Color.Gray;
            this.btnDeleteActual.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDeleteActual.ForeColor = System.Drawing.Color.White;
            this.btnDeleteActual.Location = new System.Drawing.Point(239, 127);
            this.btnDeleteActual.Name = "btnDeleteActual";
            this.btnDeleteActual.Size = new System.Drawing.Size(106, 39);
            this.btnDeleteActual.TabIndex = 13;
            this.btnDeleteActual.Text = "Delete";
            this.btnDeleteActual.UseVisualStyleBackColor = false;
            this.btnDeleteActual.Click += new System.EventHandler(this.btnDeleteActual_Click);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(7, 82);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(56, 20);
            this.label10.TabIndex = 8;
            this.label10.Text = "Sheet:";
            // 
            // btnOpenActual
            // 
            this.btnOpenActual.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnOpenActual.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnOpenActual.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnOpenActual.ForeColor = System.Drawing.Color.White;
            this.btnOpenActual.Image = global::CheckWIP.Properties.Resources.excel;
            this.btnOpenActual.Location = new System.Drawing.Point(681, 19);
            this.btnOpenActual.Name = "btnOpenActual";
            this.btnOpenActual.Size = new System.Drawing.Size(54, 52);
            this.btnOpenActual.TabIndex = 12;
            this.btnOpenActual.Text = " ";
            this.btnOpenActual.UseVisualStyleBackColor = false;
            this.btnOpenActual.Click += new System.EventHandler(this.btnOpenActual_Click);
            // 
            // cbInventoryPeriodActual
            // 
            this.cbInventoryPeriodActual.FormattingEnabled = true;
            this.cbInventoryPeriodActual.Location = new System.Drawing.Point(453, 77);
            this.cbInventoryPeriodActual.Name = "cbInventoryPeriodActual";
            this.cbInventoryPeriodActual.Size = new System.Drawing.Size(215, 28);
            this.cbInventoryPeriodActual.TabIndex = 7;
            this.cbInventoryPeriodActual.SelectedIndexChanged += new System.EventHandler(this.cbInventoryPeriodActual_SelectedIndexChanged);
            // 
            // txtExcelActual
            // 
            this.txtExcelActual.Location = new System.Drawing.Point(97, 32);
            this.txtExcelActual.Name = "txtExcelActual";
            this.txtExcelActual.Size = new System.Drawing.Size(571, 26);
            this.txtExcelActual.TabIndex = 6;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(7, 38);
            this.label11.Name = "label11";
            this.label11.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.label11.Size = new System.Drawing.Size(51, 20);
            this.label11.TabIndex = 5;
            this.label11.Text = "Excel:";
            // 
            // btnImportActual
            // 
            this.btnImportActual.BackColor = System.Drawing.Color.DodgerBlue;
            this.btnImportActual.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnImportActual.ForeColor = System.Drawing.Color.White;
            this.btnImportActual.Location = new System.Drawing.Point(96, 127);
            this.btnImportActual.Name = "btnImportActual";
            this.btnImportActual.Size = new System.Drawing.Size(106, 39);
            this.btnImportActual.TabIndex = 4;
            this.btnImportActual.Text = "Import";
            this.btnImportActual.UseVisualStyleBackColor = false;
            this.btnImportActual.Click += new System.EventHandler(this.btnImportActual_Click);
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(320, 82);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(127, 20);
            this.label12.TabIndex = 0;
            this.label12.Text = "Inventory Period:";
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.label3);
            this.panel3.Controls.Add(this.label2);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel3.Location = new System.Drawing.Point(0, 769);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(1226, 61);
            this.panel3.TabIndex = 2;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(510, 34);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(212, 20);
            this.label3.TabIndex = 1;
            this.label3.Text = "Developed by IT Department";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(446, 8);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(375, 20);
            this.label2.TabIndex = 0;
            this.label2.Text = "Copyright @ Action Composites Hightech Industries";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // FrmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1226, 830);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.MaximizeBox = false;
            this.Name = "FrmMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "VAC Check WIP";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel2.ResumeLayout(false);
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dtInventoryPeriod)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtPartInSystem)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.tabPage3.ResumeLayout(false);
            this.tabPage3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtPartInActual)).EndInit();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DataGridView dtInventoryPeriod;
        private System.Windows.Forms.DateTimePicker dtpkCheckDate;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtPeriodCode;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btnCreatePeriod;
        private System.Windows.Forms.Button btnConfig;
        private System.Windows.Forms.TextBox txtInventoryPeriodDesc;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.DataGridView dtPartInSystem;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox txtExcelSystem;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button btnImportSystem;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.ComboBox cbInventoryPeriodSystem;
        private System.Windows.Forms.ComboBox cbSheetSystem;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button btnOpenSystem;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.ComboBox cbSheetActual;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.ComboBox cbInventoryPeriodActual;
        private System.Windows.Forms.TextBox txtExcelActual;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Button btnImportActual;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.DataGridView dtPartInActual;
        private System.Windows.Forms.Label lblTotalSystem;
        private System.Windows.Forms.Button btnDeleteSystem;
        private System.Windows.Forms.Button btnDeleteInvPeriod;
        private System.Windows.Forms.ProgressBar progressSystem;
        private System.Windows.Forms.ProgressBar progressActual;
        private System.Windows.Forms.Label lblTotalActual;
        private System.Windows.Forms.Button btnDeleteActual;
        private System.Windows.Forms.Button btnOpenActual;
    }
}