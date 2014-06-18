namespace Autobots
{
    partial class Form1
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
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.trmnl = new System.Windows.Forms.RichTextBox();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.label10 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.lb_highV = new System.Windows.Forms.Label();
            this.lb_highS = new System.Windows.Forms.Label();
            this.lb_highH = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.H_V = new System.Windows.Forms.TrackBar();
            this.H_S = new System.Windows.Forms.TrackBar();
            this.H_H = new System.Windows.Forms.TrackBar();
            this.label8 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.lb_lowV = new System.Windows.Forms.Label();
            this.lb_lowS = new System.Windows.Forms.Label();
            this.lb_lowH = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.L_V = new System.Windows.Forms.TrackBar();
            this.L_S = new System.Windows.Forms.TrackBar();
            this.L_H = new System.Windows.Forms.TrackBar();
            this.nm_dilate = new System.Windows.Forms.NumericUpDown();
            this.nm_erode = new System.Windows.Forms.NumericUpDown();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.label17 = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.nm_TL = new System.Windows.Forms.NumericUpDown();
            this.nm_TS = new System.Windows.Forms.NumericUpDown();
            this.label15 = new System.Windows.Forms.Label();
            this.nm_minsize = new System.Windows.Forms.NumericUpDown();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.label13 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.nm_topmrgn = new System.Windows.Forms.NumericUpDown();
            this.nm_btmmrgn = new System.Windows.Forms.NumericUpDown();
            this.label12 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.nm_leftrMrgn = new System.Windows.Forms.NumericUpDown();
            this.nm_righrMrgn = new System.Windows.Forms.NumericUpDown();
            this.label9 = new System.Windows.Forms.Label();
            this.cb_toogleFrmt = new System.Windows.Forms.CheckBox();
            this.videoSourcePlayer1 = new AForge.Controls.VideoSourcePlayer();
            this.rcvr = new System.Windows.Forms.RichTextBox();
            this.sv_conf = new System.Windows.Forms.Button();
            this.ld_cnf = new System.Windows.Forms.Button();
            this.newTxt = new System.Windows.Forms.TextBox();
            this.cmdConf = new System.Windows.Forms.ComboBox();
            this.label18 = new System.Windows.Forms.Label();
            this.label19 = new System.Windows.Forms.Label();
            this.cmd = new System.Windows.Forms.TextBox();
            this.button2 = new System.Windows.Forms.Button();
            this.tmt_siz = new System.Windows.Forms.Label();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.button3 = new System.Windows.Forms.Button();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.H_V)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.H_S)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.H_H)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.L_V)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.L_S)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.L_H)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nm_dilate)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nm_erode)).BeginInit();
            this.tabPage2.SuspendLayout();
            this.groupBox4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nm_TL)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nm_TS)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nm_minsize)).BeginInit();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nm_topmrgn)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nm_btmmrgn)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nm_leftrMrgn)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nm_righrMrgn)).BeginInit();
            this.tabPage3.SuspendLayout();
            this.SuspendLayout();
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Interval = 80;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pictureBox1.Location = new System.Drawing.Point(533, 61);
            this.pictureBox1.MaximumSize = new System.Drawing.Size(640, 480);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(408, 347);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // comboBox1
            // 
            this.comboBox1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4",
            "5",
            "6",
            "7",
            "8",
            "9"});
            this.comboBox1.Location = new System.Drawing.Point(86, 12);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(200, 21);
            this.comboBox1.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(16, 17);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(64, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "COM PORT";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(292, 12);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 4;
            this.button1.Text = "Connect";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // trmnl
            // 
            this.trmnl.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.trmnl.Location = new System.Drawing.Point(15, 29);
            this.trmnl.Name = "trmnl";
            this.trmnl.Size = new System.Drawing.Size(223, 400);
            this.trmnl.TabIndex = 6;
            this.trmnl.Text = "";
            // 
            // tabControl1
            // 
            this.tabControl1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Controls.Add(this.tabPage3);
            this.tabControl1.Location = new System.Drawing.Point(13, 39);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(518, 487);
            this.tabControl1.TabIndex = 7;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.label10);
            this.tabPage1.Controls.Add(this.groupBox2);
            this.tabPage1.Controls.Add(this.label8);
            this.tabPage1.Controls.Add(this.groupBox1);
            this.tabPage1.Controls.Add(this.nm_dilate);
            this.tabPage1.Controls.Add(this.nm_erode);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(510, 382);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Image Processing Control";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // label10
            // 
            this.label10.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(284, 359);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(34, 13);
            this.label10.TabIndex = 13;
            this.label10.Text = "Dilate";
            // 
            // groupBox2
            // 
            this.groupBox2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.groupBox2.Controls.Add(this.lb_highV);
            this.groupBox2.Controls.Add(this.lb_highS);
            this.groupBox2.Controls.Add(this.lb_highH);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Controls.Add(this.label7);
            this.groupBox2.Controls.Add(this.H_V);
            this.groupBox2.Controls.Add(this.H_S);
            this.groupBox2.Controls.Add(this.H_H);
            this.groupBox2.Location = new System.Drawing.Point(6, 181);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(497, 168);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Upper Range";
            // 
            // lb_highV
            // 
            this.lb_highV.AutoSize = true;
            this.lb_highV.Location = new System.Drawing.Point(302, 17);
            this.lb_highV.Name = "lb_highV";
            this.lb_highV.Size = new System.Drawing.Size(13, 13);
            this.lb_highV.TabIndex = 11;
            this.lb_highV.Text = "0";
            // 
            // lb_highS
            // 
            this.lb_highS.AutoSize = true;
            this.lb_highS.Location = new System.Drawing.Point(239, 17);
            this.lb_highS.Name = "lb_highS";
            this.lb_highS.Size = new System.Drawing.Size(13, 13);
            this.lb_highS.TabIndex = 10;
            this.lb_highS.Text = "0";
            // 
            // lb_highH
            // 
            this.lb_highH.AutoSize = true;
            this.lb_highH.Location = new System.Drawing.Point(181, 17);
            this.lb_highH.Name = "lb_highH";
            this.lb_highH.Size = new System.Drawing.Size(13, 13);
            this.lb_highH.TabIndex = 9;
            this.lb_highH.Text = "0";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(10, 119);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(14, 13);
            this.label5.TabIndex = 8;
            this.label5.Text = "V";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(10, 76);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(14, 13);
            this.label6.TabIndex = 7;
            this.label6.Text = "S";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(10, 36);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(15, 13);
            this.label7.TabIndex = 6;
            this.label7.Text = "H";
            // 
            // H_V
            // 
            this.H_V.BackColor = System.Drawing.Color.White;
            this.H_V.Location = new System.Drawing.Point(32, 119);
            this.H_V.Maximum = 255;
            this.H_V.Name = "H_V";
            this.H_V.Size = new System.Drawing.Size(454, 45);
            this.H_V.TabIndex = 5;
            this.H_V.Value = 100;
            this.H_V.Scroll += new System.EventHandler(this.H_V_Scroll);
            // 
            // H_S
            // 
            this.H_S.BackColor = System.Drawing.Color.White;
            this.H_S.Location = new System.Drawing.Point(30, 74);
            this.H_S.Maximum = 255;
            this.H_S.Name = "H_S";
            this.H_S.Size = new System.Drawing.Size(454, 45);
            this.H_S.TabIndex = 4;
            this.H_S.Scroll += new System.EventHandler(this.H_S_Scroll);
            // 
            // H_H
            // 
            this.H_H.BackColor = System.Drawing.Color.White;
            this.H_H.Location = new System.Drawing.Point(31, 31);
            this.H_H.Maximum = 255;
            this.H_H.Name = "H_H";
            this.H_H.Size = new System.Drawing.Size(454, 45);
            this.H_H.TabIndex = 3;
            this.H_H.Scroll += new System.EventHandler(this.H_H_Scroll);
            // 
            // label8
            // 
            this.label8.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(25, 359);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(79, 13);
            this.label8.TabIndex = 12;
            this.label8.Text = "Noise Removal";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.lb_lowV);
            this.groupBox1.Controls.Add(this.lb_lowS);
            this.groupBox1.Controls.Add(this.lb_lowH);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.L_V);
            this.groupBox1.Controls.Add(this.L_S);
            this.groupBox1.Controls.Add(this.L_H);
            this.groupBox1.Location = new System.Drawing.Point(6, 0);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(497, 168);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Lower Range";
            // 
            // lb_lowV
            // 
            this.lb_lowV.AutoSize = true;
            this.lb_lowV.Location = new System.Drawing.Point(300, 16);
            this.lb_lowV.Name = "lb_lowV";
            this.lb_lowV.Size = new System.Drawing.Size(13, 13);
            this.lb_lowV.TabIndex = 8;
            this.lb_lowV.Text = "0";
            // 
            // lb_lowS
            // 
            this.lb_lowS.AutoSize = true;
            this.lb_lowS.Location = new System.Drawing.Point(237, 16);
            this.lb_lowS.Name = "lb_lowS";
            this.lb_lowS.Size = new System.Drawing.Size(13, 13);
            this.lb_lowS.TabIndex = 7;
            this.lb_lowS.Text = "0";
            // 
            // lb_lowH
            // 
            this.lb_lowH.AutoSize = true;
            this.lb_lowH.Location = new System.Drawing.Point(179, 16);
            this.lb_lowH.Name = "lb_lowH";
            this.lb_lowH.Size = new System.Drawing.Size(13, 13);
            this.lb_lowH.TabIndex = 6;
            this.lb_lowH.Text = "0";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(10, 113);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(14, 13);
            this.label4.TabIndex = 5;
            this.label4.Text = "V";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(10, 70);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(14, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "S";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(10, 30);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(15, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "H";
            // 
            // L_V
            // 
            this.L_V.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.L_V.BackColor = System.Drawing.Color.White;
            this.L_V.Location = new System.Drawing.Point(29, 118);
            this.L_V.Maximum = 255;
            this.L_V.Name = "L_V";
            this.L_V.Size = new System.Drawing.Size(454, 45);
            this.L_V.TabIndex = 2;
            this.L_V.Scroll += new System.EventHandler(this.L_V_Scroll);
            // 
            // L_S
            // 
            this.L_S.BackColor = System.Drawing.Color.White;
            this.L_S.Location = new System.Drawing.Point(30, 73);
            this.L_S.Maximum = 255;
            this.L_S.Name = "L_S";
            this.L_S.Size = new System.Drawing.Size(454, 45);
            this.L_S.TabIndex = 1;
            this.L_S.Scroll += new System.EventHandler(this.L_S_Scroll);
            // 
            // L_H
            // 
            this.L_H.BackColor = System.Drawing.Color.White;
            this.L_H.Location = new System.Drawing.Point(31, 33);
            this.L_H.Maximum = 255;
            this.L_H.Name = "L_H";
            this.L_H.Size = new System.Drawing.Size(454, 45);
            this.L_H.TabIndex = 0;
            this.L_H.Scroll += new System.EventHandler(this.L_H_Scroll);
            // 
            // nm_dilate
            // 
            this.nm_dilate.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.nm_dilate.Location = new System.Drawing.Point(347, 356);
            this.nm_dilate.Name = "nm_dilate";
            this.nm_dilate.Size = new System.Drawing.Size(120, 20);
            this.nm_dilate.TabIndex = 11;
            this.nm_dilate.Value = new decimal(new int[] {
            2,
            0,
            0,
            0});
            // 
            // nm_erode
            // 
            this.nm_erode.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.nm_erode.Location = new System.Drawing.Point(119, 356);
            this.nm_erode.Name = "nm_erode";
            this.nm_erode.Size = new System.Drawing.Size(120, 20);
            this.nm_erode.TabIndex = 10;
            this.nm_erode.Value = new decimal(new int[] {
            2,
            0,
            0,
            0});
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.groupBox4);
            this.tabPage2.Controls.Add(this.groupBox3);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(510, 546);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Target Detection";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.label17);
            this.groupBox4.Controls.Add(this.label16);
            this.groupBox4.Controls.Add(this.nm_TL);
            this.groupBox4.Controls.Add(this.nm_TS);
            this.groupBox4.Controls.Add(this.label15);
            this.groupBox4.Controls.Add(this.nm_minsize);
            this.groupBox4.Location = new System.Drawing.Point(28, 179);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(418, 160);
            this.groupBox4.TabIndex = 2;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Target Property";
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Location = new System.Drawing.Point(0, 61);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(71, 13);
            this.label17.TabIndex = 5;
            this.label17.Text = "Small Tomato";
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(6, 102);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(61, 13);
            this.label16.TabIndex = 4;
            this.label16.Text = "Big Tomato";
            // 
            // nm_TL
            // 
            this.nm_TL.Location = new System.Drawing.Point(75, 100);
            this.nm_TL.Maximum = new decimal(new int[] {
            500000,
            0,
            0,
            0});
            this.nm_TL.Name = "nm_TL";
            this.nm_TL.Size = new System.Drawing.Size(120, 20);
            this.nm_TL.TabIndex = 3;
            this.nm_TL.Value = new decimal(new int[] {
            50000,
            0,
            0,
            0});
            // 
            // nm_TS
            // 
            this.nm_TS.Location = new System.Drawing.Point(75, 58);
            this.nm_TS.Maximum = new decimal(new int[] {
            500000,
            0,
            0,
            0});
            this.nm_TS.Name = "nm_TS";
            this.nm_TS.Size = new System.Drawing.Size(120, 20);
            this.nm_TS.TabIndex = 2;
            this.nm_TS.Value = new decimal(new int[] {
            16000,
            0,
            0,
            0});
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(22, 22);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(47, 13);
            this.label15.TabIndex = 1;
            this.label15.Text = "Min Size";
            // 
            // nm_minsize
            // 
            this.nm_minsize.Location = new System.Drawing.Point(75, 20);
            this.nm_minsize.Maximum = new decimal(new int[] {
            500000,
            0,
            0,
            0});
            this.nm_minsize.Minimum = new decimal(new int[] {
            800,
            0,
            0,
            0});
            this.nm_minsize.Name = "nm_minsize";
            this.nm_minsize.Size = new System.Drawing.Size(120, 20);
            this.nm_minsize.TabIndex = 0;
            this.nm_minsize.Value = new decimal(new int[] {
            7500,
            0,
            0,
            0});
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.label13);
            this.groupBox3.Controls.Add(this.label14);
            this.groupBox3.Controls.Add(this.nm_topmrgn);
            this.groupBox3.Controls.Add(this.nm_btmmrgn);
            this.groupBox3.Controls.Add(this.label12);
            this.groupBox3.Controls.Add(this.label11);
            this.groupBox3.Controls.Add(this.nm_leftrMrgn);
            this.groupBox3.Controls.Add(this.nm_righrMrgn);
            this.groupBox3.Location = new System.Drawing.Point(28, 28);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(418, 144);
            this.groupBox3.TabIndex = 1;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Target Window";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(207, 93);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(75, 13);
            this.label13.TabIndex = 7;
            this.label13.Text = "Bottom Margin";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(9, 93);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(61, 13);
            this.label14.TabIndex = 6;
            this.label14.Text = "Top Margin";
            // 
            // nm_topmrgn
            // 
            this.nm_topmrgn.Location = new System.Drawing.Point(75, 90);
            this.nm_topmrgn.Maximum = new decimal(new int[] {
            480,
            0,
            0,
            0});
            this.nm_topmrgn.Name = "nm_topmrgn";
            this.nm_topmrgn.Size = new System.Drawing.Size(120, 20);
            this.nm_topmrgn.TabIndex = 5;
            this.nm_topmrgn.Value = new decimal(new int[] {
            250,
            0,
            0,
            0});
            // 
            // nm_btmmrgn
            // 
            this.nm_btmmrgn.Location = new System.Drawing.Point(286, 90);
            this.nm_btmmrgn.Maximum = new decimal(new int[] {
            480,
            0,
            0,
            0});
            this.nm_btmmrgn.Name = "nm_btmmrgn";
            this.nm_btmmrgn.Size = new System.Drawing.Size(120, 20);
            this.nm_btmmrgn.TabIndex = 4;
            this.nm_btmmrgn.Value = new decimal(new int[] {
            400,
            0,
            0,
            0});
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(213, 42);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(67, 13);
            this.label12.TabIndex = 3;
            this.label12.Text = "Right Margin";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(9, 42);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(60, 13);
            this.label11.TabIndex = 2;
            this.label11.Text = "Left Margin";
            // 
            // nm_leftrMrgn
            // 
            this.nm_leftrMrgn.Location = new System.Drawing.Point(75, 39);
            this.nm_leftrMrgn.Maximum = new decimal(new int[] {
            640,
            0,
            0,
            0});
            this.nm_leftrMrgn.Name = "nm_leftrMrgn";
            this.nm_leftrMrgn.Size = new System.Drawing.Size(120, 20);
            this.nm_leftrMrgn.TabIndex = 1;
            this.nm_leftrMrgn.Value = new decimal(new int[] {
            250,
            0,
            0,
            0});
            // 
            // nm_righrMrgn
            // 
            this.nm_righrMrgn.Location = new System.Drawing.Point(286, 39);
            this.nm_righrMrgn.Maximum = new decimal(new int[] {
            640,
            0,
            0,
            0});
            this.nm_righrMrgn.Name = "nm_righrMrgn";
            this.nm_righrMrgn.Size = new System.Drawing.Size(120, 20);
            this.nm_righrMrgn.TabIndex = 0;
            this.nm_righrMrgn.Value = new decimal(new int[] {
            400,
            0,
            0,
            0});
            // 
            // label9
            // 
            this.label9.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(531, 477);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(73, 13);
            this.label9.TabIndex = 8;
            this.label9.Text = "Chat With Bot";
            // 
            // cb_toogleFrmt
            // 
            this.cb_toogleFrmt.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.cb_toogleFrmt.AutoSize = true;
            this.cb_toogleFrmt.Checked = true;
            this.cb_toogleFrmt.CheckState = System.Windows.Forms.CheckState.Checked;
            this.cb_toogleFrmt.Location = new System.Drawing.Point(853, 414);
            this.cb_toogleFrmt.Name = "cb_toogleFrmt";
            this.cb_toogleFrmt.Size = new System.Drawing.Size(88, 17);
            this.cb_toogleFrmt.TabIndex = 9;
            this.cb_toogleFrmt.Text = "Show Output";
            this.cb_toogleFrmt.UseVisualStyleBackColor = true;
            // 
            // videoSourcePlayer1
            // 
            this.videoSourcePlayer1.Location = new System.Drawing.Point(213, 17);
            this.videoSourcePlayer1.Name = "videoSourcePlayer1";
            this.videoSourcePlayer1.Size = new System.Drawing.Size(40, 10);
            this.videoSourcePlayer1.TabIndex = 10;
            this.videoSourcePlayer1.Text = "videoSourcePlayer1";
            this.videoSourcePlayer1.VideoSource = null;
            this.videoSourcePlayer1.Visible = false;
            this.videoSourcePlayer1.NewFrame += new AForge.Controls.VideoSourcePlayer.NewFrameHandler(this.videoSourcePlayer1_NewFrame);
            this.videoSourcePlayer1.Click += new System.EventHandler(this.videoSourcePlayer1_Click);
            // 
            // rcvr
            // 
            this.rcvr.Location = new System.Drawing.Point(252, 29);
            this.rcvr.Name = "rcvr";
            this.rcvr.Size = new System.Drawing.Size(241, 400);
            this.rcvr.TabIndex = 11;
            this.rcvr.Text = "";
            // 
            // sv_conf
            // 
            this.sv_conf.Location = new System.Drawing.Point(796, 34);
            this.sv_conf.Name = "sv_conf";
            this.sv_conf.Size = new System.Drawing.Size(75, 23);
            this.sv_conf.TabIndex = 12;
            this.sv_conf.Text = "Save";
            this.sv_conf.UseVisualStyleBackColor = true;
            this.sv_conf.Click += new System.EventHandler(this.sv_conf_Click);
            // 
            // ld_cnf
            // 
            this.ld_cnf.Location = new System.Drawing.Point(796, 5);
            this.ld_cnf.Name = "ld_cnf";
            this.ld_cnf.Size = new System.Drawing.Size(75, 23);
            this.ld_cnf.TabIndex = 13;
            this.ld_cnf.Text = "Load";
            this.ld_cnf.UseVisualStyleBackColor = true;
            this.ld_cnf.Click += new System.EventHandler(this.ld_cnf_Click);
            // 
            // newTxt
            // 
            this.newTxt.Location = new System.Drawing.Point(548, 36);
            this.newTxt.Name = "newTxt";
            this.newTxt.Size = new System.Drawing.Size(228, 20);
            this.newTxt.TabIndex = 14;
            // 
            // cmdConf
            // 
            this.cmdConf.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmdConf.FormattingEnabled = true;
            this.cmdConf.Location = new System.Drawing.Point(548, 7);
            this.cmdConf.Name = "cmdConf";
            this.cmdConf.Size = new System.Drawing.Size(228, 21);
            this.cmdConf.TabIndex = 15;
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Location = new System.Drawing.Point(12, 13);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(51, 13);
            this.label18.TabIndex = 16;
            this.label18.Text = "sent data";
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Location = new System.Drawing.Point(249, 13);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(42, 13);
            this.label19.TabIndex = 17;
            this.label19.Text = "recived";
            // 
            // cmd
            // 
            this.cmd.Location = new System.Drawing.Point(533, 506);
            this.cmd.Name = "cmd";
            this.cmd.Size = new System.Drawing.Size(281, 20);
            this.cmd.TabIndex = 18;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(831, 504);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(91, 23);
            this.button2.TabIndex = 19;
            this.button2.Text = "Send ";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click_1);
            // 
            // tmt_siz
            // 
            this.tmt_siz.AutoSize = true;
            this.tmt_siz.Location = new System.Drawing.Point(548, 415);
            this.tmt_siz.Name = "tmt_siz";
            this.tmt_siz.Size = new System.Drawing.Size(68, 13);
            this.tmt_siz.TabIndex = 20;
            this.tmt_siz.Text = "TOmato Size";
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Location = new System.Drawing.Point(387, 13);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(79, 17);
            this.checkBox1.TabIndex = 21;
            this.checkBox1.Text = "Camera On";
            this.checkBox1.UseVisualStyleBackColor = true;
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(877, 5);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(75, 23);
            this.button3.TabIndex = 3;
            this.button3.Text = "button3";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // tabPage3
            // 
            this.tabPage3.Controls.Add(this.trmnl);
            this.tabPage3.Controls.Add(this.rcvr);
            this.tabPage3.Controls.Add(this.label18);
            this.tabPage3.Controls.Add(this.label19);
            this.tabPage3.Location = new System.Drawing.Point(4, 22);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Size = new System.Drawing.Size(510, 461);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "Signals";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(950, 550);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.checkBox1);
            this.Controls.Add(this.tmt_siz);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.cmd);
            this.Controls.Add(this.cmdConf);
            this.Controls.Add(this.newTxt);
            this.Controls.Add(this.ld_cnf);
            this.Controls.Add(this.sv_conf);
            this.Controls.Add(this.cb_toogleFrmt);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.videoSourcePlayer1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.MaximumSize = new System.Drawing.Size(966, 584);
            this.MinimumSize = new System.Drawing.Size(966, 584);
            this.Name = "Form1";
            this.Text = "Harvesing COntrol Panal";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Form1_FormClosed);
            this.Load += new System.EventHandler(this.Form1_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Form1_KeyDown);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.H_V)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.H_S)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.H_H)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.L_V)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.L_S)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.L_H)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nm_dilate)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nm_erode)).EndInit();
            this.tabPage2.ResumeLayout(false);
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nm_TL)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nm_TS)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nm_minsize)).EndInit();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nm_topmrgn)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nm_btmmrgn)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nm_leftrMrgn)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nm_righrMrgn)).EndInit();
            this.tabPage3.ResumeLayout(false);
            this.tabPage3.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.RichTextBox trmnl;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TrackBar H_V;
        private System.Windows.Forms.TrackBar H_S;
        private System.Windows.Forms.TrackBar H_H;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TrackBar L_V;
        private System.Windows.Forms.TrackBar L_S;
        private System.Windows.Forms.TrackBar L_H;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lb_highV;
        private System.Windows.Forms.Label lb_highS;
        private System.Windows.Forms.Label lb_highH;
        private System.Windows.Forms.Label lb_lowV;
        private System.Windows.Forms.Label lb_lowS;
        private System.Windows.Forms.Label lb_lowH;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.CheckBox cb_toogleFrmt;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.NumericUpDown nm_dilate;
        private System.Windows.Forms.NumericUpDown nm_erode;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.NumericUpDown nm_leftrMrgn;
        private System.Windows.Forms.NumericUpDown nm_righrMrgn;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.NumericUpDown nm_topmrgn;
        private System.Windows.Forms.NumericUpDown nm_btmmrgn;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.NumericUpDown nm_minsize;
        private AForge.Controls.VideoSourcePlayer videoSourcePlayer1;
        private System.Windows.Forms.RichTextBox rcvr;
        private System.Windows.Forms.Button sv_conf;
        private System.Windows.Forms.Button ld_cnf;
        private System.Windows.Forms.TextBox newTxt;
        private System.Windows.Forms.ComboBox cmdConf;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.NumericUpDown nm_TL;
        private System.Windows.Forms.NumericUpDown nm_TS;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.TextBox cmd;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label tmt_siz;
        private System.Windows.Forms.CheckBox checkBox1;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.TabPage tabPage3;
    }
}

