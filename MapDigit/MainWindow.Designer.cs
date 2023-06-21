namespace MapDigit
{
    partial class MainWindow
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainWindow));
            this.btnUp = new System.Windows.Forms.Button();
            this.btnLeft = new System.Windows.Forms.Button();
            this.btnReset = new System.Windows.Forms.Button();
            this.btnRight = new System.Windows.Forms.Button();
            this.btnDown = new System.Windows.Forms.Button();
            this.btnZoomIn = new System.Windows.Forms.Button();
            this.btnZoomOut = new System.Windows.Forms.Button();
            this.btnGo = new System.Windows.Forms.Button();
            this.txtAddress = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txtY2 = new System.Windows.Forms.MaskedTextBox();
            this.txtY1 = new System.Windows.Forms.MaskedTextBox();
            this.txtX2 = new System.Windows.Forms.MaskedTextBox();
            this.txtX1 = new System.Windows.Forms.MaskedTextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.chk22 = new System.Windows.Forms.CheckBox();
            this.chk21 = new System.Windows.Forms.CheckBox();
            this.chk20 = new System.Windows.Forms.CheckBox();
            this.chk19 = new System.Windows.Forms.CheckBox();
            this.chk18 = new System.Windows.Forms.CheckBox();
            this.chk17 = new System.Windows.Forms.CheckBox();
            this.chk16 = new System.Windows.Forms.CheckBox();
            this.chk15 = new System.Windows.Forms.CheckBox();
            this.chk14 = new System.Windows.Forms.CheckBox();
            this.chk13 = new System.Windows.Forms.CheckBox();
            this.chk12 = new System.Windows.Forms.CheckBox();
            this.chk11 = new System.Windows.Forms.CheckBox();
            this.chk10 = new System.Windows.Forms.CheckBox();
            this.chk9 = new System.Windows.Forms.CheckBox();
            this.chk8 = new System.Windows.Forms.CheckBox();
            this.chk7 = new System.Windows.Forms.CheckBox();
            this.chk6 = new System.Windows.Forms.CheckBox();
            this.chk5 = new System.Windows.Forms.CheckBox();
            this.chk4 = new System.Windows.Forms.CheckBox();
            this.chk3 = new System.Windows.Forms.CheckBox();
            this.chk2 = new System.Windows.Forms.CheckBox();
            this.lblMessage = new System.Windows.Forms.Label();
            this.lblMapType = new System.Windows.Forms.Label();
            this.cboMapType = new System.Windows.Forms.ComboBox();
            this.progressDownload = new System.Windows.Forms.ProgressBar();
            this.txtMessage = new System.Windows.Forms.TextBox();
            this.btnStart = new System.Windows.Forms.Button();
            this.btnStop = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.picMapCanvas = new System.Windows.Forms.PictureBox();
            this.lblStatus = new System.Windows.Forms.Label();
            this.btnLoad = new System.Windows.Forms.Button();
            this.btnServer = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picMapCanvas)).BeginInit();
            this.SuspendLayout();
            // 
            // btnUp
            // 
            this.btnUp.Font = new System.Drawing.Font("Tahoma", 10.5F);
            this.btnUp.Location = new System.Drawing.Point(965, 11);
            this.btnUp.Name = "btnUp";
            this.btnUp.Size = new System.Drawing.Size(88, 37);
            this.btnUp.TabIndex = 1;
            this.btnUp.Text = "上移";
            this.btnUp.UseVisualStyleBackColor = true;
            this.btnUp.Click += new System.EventHandler(this.btnUp_Click);
            // 
            // btnLeft
            // 
            this.btnLeft.Font = new System.Drawing.Font("Tahoma", 10.5F);
            this.btnLeft.Location = new System.Drawing.Point(852, 54);
            this.btnLeft.Name = "btnLeft";
            this.btnLeft.Size = new System.Drawing.Size(88, 37);
            this.btnLeft.TabIndex = 2;
            this.btnLeft.Text = "左移";
            this.btnLeft.UseVisualStyleBackColor = true;
            this.btnLeft.Click += new System.EventHandler(this.btnLeft_Click);
            // 
            // btnReset
            // 
            this.btnReset.Font = new System.Drawing.Font("Tahoma", 10.5F);
            this.btnReset.Location = new System.Drawing.Point(965, 54);
            this.btnReset.Name = "btnReset";
            this.btnReset.Size = new System.Drawing.Size(88, 37);
            this.btnReset.TabIndex = 3;
            this.btnReset.Text = "调整";
            this.btnReset.UseVisualStyleBackColor = true;
            this.btnReset.Click += new System.EventHandler(this.btnReset_Click);
            // 
            // btnRight
            // 
            this.btnRight.Font = new System.Drawing.Font("Tahoma", 10.5F);
            this.btnRight.Location = new System.Drawing.Point(1078, 54);
            this.btnRight.Name = "btnRight";
            this.btnRight.Size = new System.Drawing.Size(88, 37);
            this.btnRight.TabIndex = 4;
            this.btnRight.Text = "右移";
            this.btnRight.UseVisualStyleBackColor = true;
            this.btnRight.Click += new System.EventHandler(this.btnRight_Click);
            // 
            // btnDown
            // 
            this.btnDown.Font = new System.Drawing.Font("Tahoma", 10.5F);
            this.btnDown.Location = new System.Drawing.Point(965, 97);
            this.btnDown.Name = "btnDown";
            this.btnDown.Size = new System.Drawing.Size(88, 37);
            this.btnDown.TabIndex = 5;
            this.btnDown.Text = "下移";
            this.btnDown.UseVisualStyleBackColor = true;
            this.btnDown.Click += new System.EventHandler(this.btnDown_Click);
            // 
            // btnZoomIn
            // 
            this.btnZoomIn.Font = new System.Drawing.Font("Tahoma", 10.5F);
            this.btnZoomIn.Location = new System.Drawing.Point(853, 97);
            this.btnZoomIn.Name = "btnZoomIn";
            this.btnZoomIn.Size = new System.Drawing.Size(88, 37);
            this.btnZoomIn.TabIndex = 6;
            this.btnZoomIn.Text = "放大";
            this.btnZoomIn.UseVisualStyleBackColor = true;
            this.btnZoomIn.Click += new System.EventHandler(this.btnZoomIn_Click);
            // 
            // btnZoomOut
            // 
            this.btnZoomOut.Font = new System.Drawing.Font("Tahoma", 10.5F);
            this.btnZoomOut.Location = new System.Drawing.Point(1077, 97);
            this.btnZoomOut.Name = "btnZoomOut";
            this.btnZoomOut.Size = new System.Drawing.Size(88, 37);
            this.btnZoomOut.TabIndex = 7;
            this.btnZoomOut.Text = "缩小";
            this.btnZoomOut.UseVisualStyleBackColor = true;
            this.btnZoomOut.Click += new System.EventHandler(this.btnZoomOut_Click);
            // 
            // btnGo
            // 
            this.btnGo.Font = new System.Drawing.Font("Tahoma", 10.5F);
            this.btnGo.Location = new System.Drawing.Point(1077, 140);
            this.btnGo.Name = "btnGo";
            this.btnGo.Size = new System.Drawing.Size(88, 37);
            this.btnGo.TabIndex = 8;
            this.btnGo.Text = "查找";
            this.btnGo.UseVisualStyleBackColor = true;
            this.btnGo.Click += new System.EventHandler(this.btnGo_Click);
            // 
            // txtAddress
            // 
            this.txtAddress.Font = new System.Drawing.Font("Tahoma", 10.5F);
            this.txtAddress.Location = new System.Drawing.Point(852, 147);
            this.txtAddress.Name = "txtAddress";
            this.txtAddress.Size = new System.Drawing.Size(218, 24);
            this.txtAddress.TabIndex = 9;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txtY2);
            this.groupBox1.Controls.Add(this.txtY1);
            this.groupBox1.Controls.Add(this.txtX2);
            this.groupBox1.Controls.Add(this.txtX1);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Font = new System.Drawing.Font("Tahoma", 12F);
            this.groupBox1.Location = new System.Drawing.Point(852, 183);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(313, 147);
            this.groupBox1.TabIndex = 10;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "选择下载区域";
            // 
            // txtY2
            // 
            this.txtY2.HidePromptOnLeave = true;
            this.txtY2.Location = new System.Drawing.Point(196, 107);
            this.txtY2.Mask = "999999";
            this.txtY2.Name = "txtY2";
            this.txtY2.Size = new System.Drawing.Size(98, 27);
            this.txtY2.TabIndex = 9;
            this.txtY2.TextChanged += new System.EventHandler(this.txtY2_TextChanged);
            // 
            // txtY1
            // 
            this.txtY1.HidePromptOnLeave = true;
            this.txtY1.Location = new System.Drawing.Point(43, 107);
            this.txtY1.Mask = "999999";
            this.txtY1.Name = "txtY1";
            this.txtY1.Size = new System.Drawing.Size(98, 27);
            this.txtY1.TabIndex = 8;
            this.txtY1.TextChanged += new System.EventHandler(this.txtY1_TextChanged);
            // 
            // txtX2
            // 
            this.txtX2.HidePromptOnLeave = true;
            this.txtX2.Location = new System.Drawing.Point(196, 69);
            this.txtX2.Mask = "999999";
            this.txtX2.Name = "txtX2";
            this.txtX2.Size = new System.Drawing.Size(98, 27);
            this.txtX2.TabIndex = 7;
            this.txtX2.TextChanged += new System.EventHandler(this.txtX2_TextChanged);
            // 
            // txtX1
            // 
            this.txtX1.HidePromptOnLeave = true;
            this.txtX1.Location = new System.Drawing.Point(43, 69);
            this.txtX1.Mask = "999999";
            this.txtX1.Name = "txtX1";
            this.txtX1.Size = new System.Drawing.Size(98, 27);
            this.txtX1.TabIndex = 6;
            this.txtX1.TextChanged += new System.EventHandler(this.txtX1_TextChanged);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(158, 107);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(28, 19);
            this.label6.TabIndex = 5;
            this.label6.Text = "Y2";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(158, 72);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(27, 19);
            this.label5.TabIndex = 4;
            this.label5.Text = "X2";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(13, 109);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(28, 19);
            this.label4.TabIndex = 3;
            this.label4.Text = "Y1";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(13, 72);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(27, 19);
            this.label3.TabIndex = 2;
            this.label3.Text = "X1";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(158, 36);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(73, 19);
            this.label2.TabIndex = 1;
            this.label2.Text = "终止序号";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 36);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(73, 19);
            this.label1.TabIndex = 0;
            this.label1.Text = "起始序号";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.chk22);
            this.groupBox2.Controls.Add(this.chk21);
            this.groupBox2.Controls.Add(this.chk20);
            this.groupBox2.Controls.Add(this.chk19);
            this.groupBox2.Controls.Add(this.chk18);
            this.groupBox2.Controls.Add(this.chk17);
            this.groupBox2.Controls.Add(this.chk16);
            this.groupBox2.Controls.Add(this.chk15);
            this.groupBox2.Controls.Add(this.chk14);
            this.groupBox2.Controls.Add(this.chk13);
            this.groupBox2.Controls.Add(this.chk12);
            this.groupBox2.Controls.Add(this.lblMessage);
            this.groupBox2.Controls.Add(this.chk11);
            this.groupBox2.Controls.Add(this.chk10);
            this.groupBox2.Controls.Add(this.chk9);
            this.groupBox2.Controls.Add(this.chk8);
            this.groupBox2.Controls.Add(this.chk7);
            this.groupBox2.Controls.Add(this.chk6);
            this.groupBox2.Controls.Add(this.chk5);
            this.groupBox2.Controls.Add(this.chk4);
            this.groupBox2.Controls.Add(this.chk3);
            this.groupBox2.Controls.Add(this.chk2);
            this.groupBox2.Font = new System.Drawing.Font("Tahoma", 12F);
            this.groupBox2.Location = new System.Drawing.Point(853, 336);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(314, 230);
            this.groupBox2.TabIndex = 11;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "选择地图下载级别";
            // 
            // chk22
            // 
            this.chk22.AutoSize = true;
            this.chk22.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.chk22.Location = new System.Drawing.Point(248, 181);
            this.chk22.Name = "chk22";
            this.chk22.Size = new System.Drawing.Size(46, 23);
            this.chk22.TabIndex = 20;
            this.chk22.Text = "22";
            this.chk22.UseVisualStyleBackColor = true;
            this.chk22.CheckedChanged += new System.EventHandler(this.chk22_CheckedChanged);
            // 
            // chk21
            // 
            this.chk21.AutoSize = true;
            this.chk21.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.chk21.Location = new System.Drawing.Point(171, 181);
            this.chk21.Name = "chk21";
            this.chk21.Size = new System.Drawing.Size(46, 23);
            this.chk21.TabIndex = 19;
            this.chk21.Text = "21";
            this.chk21.UseVisualStyleBackColor = true;
            this.chk21.CheckedChanged += new System.EventHandler(this.chk21_CheckedChanged);
            // 
            // chk20
            // 
            this.chk20.AutoSize = true;
            this.chk20.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.chk20.Location = new System.Drawing.Point(94, 181);
            this.chk20.Name = "chk20";
            this.chk20.Size = new System.Drawing.Size(46, 23);
            this.chk20.TabIndex = 18;
            this.chk20.Text = "20";
            this.chk20.UseVisualStyleBackColor = true;
            this.chk20.CheckedChanged += new System.EventHandler(this.chk20_CheckedChanged);
            // 
            // chk19
            // 
            this.chk19.AutoSize = true;
            this.chk19.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.chk19.Location = new System.Drawing.Point(17, 181);
            this.chk19.Name = "chk19";
            this.chk19.Size = new System.Drawing.Size(46, 23);
            this.chk19.TabIndex = 17;
            this.chk19.Text = "19";
            this.chk19.UseVisualStyleBackColor = true;
            this.chk19.CheckedChanged += new System.EventHandler(this.chk19_CheckedChanged);
            // 
            // chk18
            // 
            this.chk18.AutoSize = true;
            this.chk18.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.chk18.Location = new System.Drawing.Point(17, 151);
            this.chk18.Name = "chk18";
            this.chk18.Size = new System.Drawing.Size(46, 23);
            this.chk18.TabIndex = 16;
            this.chk18.Text = "18";
            this.chk18.UseVisualStyleBackColor = true;
            this.chk18.CheckedChanged += new System.EventHandler(this.chk18_CheckedChanged);
            // 
            // chk17
            // 
            this.chk17.AutoSize = true;
            this.chk17.Location = new System.Drawing.Point(248, 122);
            this.chk17.Name = "chk17";
            this.chk17.Size = new System.Drawing.Size(46, 23);
            this.chk17.TabIndex = 15;
            this.chk17.Text = "17";
            this.chk17.UseVisualStyleBackColor = true;
            this.chk17.CheckedChanged += new System.EventHandler(this.chk17_CheckedChanged);
            // 
            // chk16
            // 
            this.chk16.AutoSize = true;
            this.chk16.Location = new System.Drawing.Point(171, 122);
            this.chk16.Name = "chk16";
            this.chk16.Size = new System.Drawing.Size(46, 23);
            this.chk16.TabIndex = 14;
            this.chk16.Text = "16";
            this.chk16.UseVisualStyleBackColor = true;
            this.chk16.CheckedChanged += new System.EventHandler(this.chk16_CheckedChanged);
            // 
            // chk15
            // 
            this.chk15.AutoSize = true;
            this.chk15.Location = new System.Drawing.Point(94, 122);
            this.chk15.Name = "chk15";
            this.chk15.Size = new System.Drawing.Size(46, 23);
            this.chk15.TabIndex = 13;
            this.chk15.Text = "15";
            this.chk15.UseVisualStyleBackColor = true;
            this.chk15.CheckedChanged += new System.EventHandler(this.chk15_CheckedChanged);
            // 
            // chk14
            // 
            this.chk14.AutoSize = true;
            this.chk14.Location = new System.Drawing.Point(17, 122);
            this.chk14.Name = "chk14";
            this.chk14.Size = new System.Drawing.Size(46, 23);
            this.chk14.TabIndex = 12;
            this.chk14.Text = "14";
            this.chk14.UseVisualStyleBackColor = true;
            this.chk14.CheckedChanged += new System.EventHandler(this.chk14_CheckedChanged);
            // 
            // chk13
            // 
            this.chk13.AutoSize = true;
            this.chk13.Location = new System.Drawing.Point(248, 93);
            this.chk13.Name = "chk13";
            this.chk13.Size = new System.Drawing.Size(46, 23);
            this.chk13.TabIndex = 11;
            this.chk13.Text = "13";
            this.chk13.UseVisualStyleBackColor = true;
            this.chk13.CheckedChanged += new System.EventHandler(this.chk13_CheckedChanged);
            // 
            // chk12
            // 
            this.chk12.AutoSize = true;
            this.chk12.Location = new System.Drawing.Point(171, 93);
            this.chk12.Name = "chk12";
            this.chk12.Size = new System.Drawing.Size(46, 23);
            this.chk12.TabIndex = 10;
            this.chk12.Text = "12";
            this.chk12.UseVisualStyleBackColor = true;
            this.chk12.CheckedChanged += new System.EventHandler(this.chk12_CheckedChanged);
            // 
            // chk11
            // 
            this.chk11.AutoSize = true;
            this.chk11.Location = new System.Drawing.Point(94, 93);
            this.chk11.Name = "chk11";
            this.chk11.Size = new System.Drawing.Size(46, 23);
            this.chk11.TabIndex = 9;
            this.chk11.Text = "11";
            this.chk11.UseVisualStyleBackColor = true;
            this.chk11.CheckedChanged += new System.EventHandler(this.chk11_CheckedChanged);
            // 
            // chk10
            // 
            this.chk10.AutoSize = true;
            this.chk10.Location = new System.Drawing.Point(17, 93);
            this.chk10.Name = "chk10";
            this.chk10.Size = new System.Drawing.Size(46, 23);
            this.chk10.TabIndex = 8;
            this.chk10.Text = "10";
            this.chk10.UseVisualStyleBackColor = true;
            this.chk10.CheckedChanged += new System.EventHandler(this.chk10_CheckedChanged);
            // 
            // chk9
            // 
            this.chk9.AutoSize = true;
            this.chk9.Location = new System.Drawing.Point(248, 64);
            this.chk9.Name = "chk9";
            this.chk9.Size = new System.Drawing.Size(37, 23);
            this.chk9.TabIndex = 7;
            this.chk9.Text = "9";
            this.chk9.UseVisualStyleBackColor = true;
            this.chk9.CheckedChanged += new System.EventHandler(this.chk9_CheckedChanged);
            // 
            // chk8
            // 
            this.chk8.AutoSize = true;
            this.chk8.Location = new System.Drawing.Point(171, 64);
            this.chk8.Name = "chk8";
            this.chk8.Size = new System.Drawing.Size(37, 23);
            this.chk8.TabIndex = 6;
            this.chk8.Text = "8";
            this.chk8.UseVisualStyleBackColor = true;
            this.chk8.CheckedChanged += new System.EventHandler(this.chk8_CheckedChanged);
            // 
            // chk7
            // 
            this.chk7.AutoSize = true;
            this.chk7.Location = new System.Drawing.Point(94, 64);
            this.chk7.Name = "chk7";
            this.chk7.Size = new System.Drawing.Size(37, 23);
            this.chk7.TabIndex = 5;
            this.chk7.Text = "7";
            this.chk7.UseVisualStyleBackColor = true;
            this.chk7.CheckedChanged += new System.EventHandler(this.chk7_CheckedChanged);
            // 
            // chk6
            // 
            this.chk6.AutoSize = true;
            this.chk6.Location = new System.Drawing.Point(17, 64);
            this.chk6.Name = "chk6";
            this.chk6.Size = new System.Drawing.Size(37, 23);
            this.chk6.TabIndex = 4;
            this.chk6.Text = "6";
            this.chk6.UseVisualStyleBackColor = true;
            this.chk6.CheckedChanged += new System.EventHandler(this.chk6_CheckedChanged);
            // 
            // chk5
            // 
            this.chk5.AutoSize = true;
            this.chk5.Location = new System.Drawing.Point(248, 35);
            this.chk5.Name = "chk5";
            this.chk5.Size = new System.Drawing.Size(37, 23);
            this.chk5.TabIndex = 3;
            this.chk5.Text = "5";
            this.chk5.UseVisualStyleBackColor = true;
            this.chk5.CheckedChanged += new System.EventHandler(this.chk5_CheckedChanged);
            // 
            // chk4
            // 
            this.chk4.AutoSize = true;
            this.chk4.Location = new System.Drawing.Point(171, 35);
            this.chk4.Name = "chk4";
            this.chk4.Size = new System.Drawing.Size(37, 23);
            this.chk4.TabIndex = 2;
            this.chk4.Text = "4";
            this.chk4.UseVisualStyleBackColor = true;
            this.chk4.CheckedChanged += new System.EventHandler(this.chk4_CheckedChanged);
            // 
            // chk3
            // 
            this.chk3.AutoSize = true;
            this.chk3.Location = new System.Drawing.Point(94, 35);
            this.chk3.Name = "chk3";
            this.chk3.Size = new System.Drawing.Size(37, 23);
            this.chk3.TabIndex = 1;
            this.chk3.Text = "3";
            this.chk3.UseVisualStyleBackColor = true;
            this.chk3.CheckedChanged += new System.EventHandler(this.chk3_CheckedChanged);
            // 
            // chk2
            // 
            this.chk2.AutoSize = true;
            this.chk2.Location = new System.Drawing.Point(17, 35);
            this.chk2.Name = "chk2";
            this.chk2.Size = new System.Drawing.Size(37, 23);
            this.chk2.TabIndex = 0;
            this.chk2.Text = "2";
            this.chk2.UseVisualStyleBackColor = true;
            this.chk2.CheckedChanged += new System.EventHandler(this.chk2_CheckedChanged);
            // 
            // lblMessage
            // 
            this.lblMessage.AutoSize = true;
            this.lblMessage.Font = new System.Drawing.Font("Tahoma", 10.5F);
            this.lblMessage.ForeColor = System.Drawing.Color.Black;
            this.lblMessage.Location = new System.Drawing.Point(14, 210);
            this.lblMessage.Name = "lblMessage";
            this.lblMessage.Size = new System.Drawing.Size(98, 17);
            this.lblMessage.TabIndex = 12;
            this.lblMessage.Text = "some message";
            // 
            // lblMapType
            // 
            this.lblMapType.AutoSize = true;
            this.lblMapType.Font = new System.Drawing.Font("Tahoma", 10.5F);
            this.lblMapType.Location = new System.Drawing.Point(857, 575);
            this.lblMapType.Name = "lblMapType";
            this.lblMapType.Size = new System.Drawing.Size(64, 17);
            this.lblMapType.TabIndex = 13;
            this.lblMapType.Text = "地图类型";
            // 
            // cboMapType
            // 
            this.cboMapType.Font = new System.Drawing.Font("Tahoma", 10.5F);
            this.cboMapType.FormattingEnabled = true;
            this.cboMapType.Location = new System.Drawing.Point(931, 572);
            this.cboMapType.Name = "cboMapType";
            this.cboMapType.Size = new System.Drawing.Size(234, 25);
            this.cboMapType.TabIndex = 14;
            this.cboMapType.SelectedIndexChanged += new System.EventHandler(this.cboMapType_SelectedIndexChanged);
            // 
            // progressDownload
            // 
            this.progressDownload.Location = new System.Drawing.Point(856, 603);
            this.progressDownload.Name = "progressDownload";
            this.progressDownload.Size = new System.Drawing.Size(309, 29);
            this.progressDownload.TabIndex = 15;
            // 
            // txtMessage
            // 
            this.txtMessage.Font = new System.Drawing.Font("Tahoma", 9F);
            this.txtMessage.Location = new System.Drawing.Point(853, 638);
            this.txtMessage.Multiline = true;
            this.txtMessage.Name = "txtMessage";
            this.txtMessage.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtMessage.Size = new System.Drawing.Size(314, 135);
            this.txtMessage.TabIndex = 16;
            // 
            // btnStart
            // 
            this.btnStart.Font = new System.Drawing.Font("Tahoma", 10.5F);
            this.btnStart.Location = new System.Drawing.Point(852, 779);
            this.btnStart.Name = "btnStart";
            this.btnStart.Size = new System.Drawing.Size(64, 37);
            this.btnStart.TabIndex = 17;
            this.btnStart.Text = "开始";
            this.btnStart.UseVisualStyleBackColor = true;
            this.btnStart.Click += new System.EventHandler(this.btnStart_Click);
            // 
            // btnStop
            // 
            this.btnStop.Enabled = false;
            this.btnStop.Font = new System.Drawing.Font("Tahoma", 10.5F);
            this.btnStop.Location = new System.Drawing.Point(929, 779);
            this.btnStop.Name = "btnStop";
            this.btnStop.Size = new System.Drawing.Size(64, 37);
            this.btnStop.TabIndex = 19;
            this.btnStop.Text = "停止";
            this.btnStop.UseVisualStyleBackColor = true;
            this.btnStop.Click += new System.EventHandler(this.btnStop_Click);
            // 
            // btnExit
            // 
            this.btnExit.Font = new System.Drawing.Font("Tahoma", 10.5F);
            this.btnExit.Location = new System.Drawing.Point(1101, 779);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(64, 37);
            this.btnExit.TabIndex = 20;
            this.btnExit.Text = "退出";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel1.Controls.Add(this.picMapCanvas);
            this.panel1.Location = new System.Drawing.Point(12, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(818, 809);
            this.panel1.TabIndex = 21;
            // 
            // picMapCanvas
            // 
            this.picMapCanvas.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.picMapCanvas.Cursor = System.Windows.Forms.Cursors.Hand;
            this.picMapCanvas.Location = new System.Drawing.Point(3, 3);
            this.picMapCanvas.Name = "picMapCanvas";
            this.picMapCanvas.Size = new System.Drawing.Size(808, 799);
            this.picMapCanvas.TabIndex = 1;
            this.picMapCanvas.TabStop = false;
            this.picMapCanvas.Click += new System.EventHandler(this.picMapCanvas_Click);
            this.picMapCanvas.MouseDown += new System.Windows.Forms.MouseEventHandler(this.picMapCanvas_MouseDown);
            this.picMapCanvas.MouseMove += new System.Windows.Forms.MouseEventHandler(this.picMapCanvas_MouseMove);
            this.picMapCanvas.MouseWheel += new System.Windows.Forms.MouseEventHandler(this.picMapCanvas_MouseWheel);
            // 
            // lblStatus
            // 
            this.lblStatus.AutoSize = true;
            this.lblStatus.Font = new System.Drawing.Font("Tahoma", 10.5F);
            this.lblStatus.ForeColor = System.Drawing.Color.Black;
            this.lblStatus.Location = new System.Drawing.Point(853, 786);
            this.lblStatus.Name = "lblStatus";
            this.lblStatus.Size = new System.Drawing.Size(0, 17);
            this.lblStatus.TabIndex = 22;
            // 
            // btnLoad
            // 
            this.btnLoad.Font = new System.Drawing.Font("Tahoma", 10.5F);
            this.btnLoad.Location = new System.Drawing.Point(852, 11);
            this.btnLoad.Name = "btnLoad";
            this.btnLoad.Size = new System.Drawing.Size(88, 37);
            this.btnLoad.TabIndex = 23;
            this.btnLoad.Text = "加载文件";
            this.btnLoad.UseVisualStyleBackColor = true;
            this.btnLoad.Click += new System.EventHandler(this.btnLoad_Click);
            // 
            // btnServer
            // 
            this.btnServer.Font = new System.Drawing.Font("Tahoma", 10.5F);
            this.btnServer.Location = new System.Drawing.Point(1079, 11);
            this.btnServer.Name = "btnServer";
            this.btnServer.Size = new System.Drawing.Size(88, 37);
            this.btnServer.TabIndex = 24;
            this.btnServer.Text = "服务器";
            this.btnServer.UseVisualStyleBackColor = true;
            this.btnServer.Click += new System.EventHandler(this.btnServer_Click);
            // 
            // MainWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1192, 844);
            this.Controls.Add(this.btnServer);
            this.Controls.Add(this.btnLoad);
            this.Controls.Add(this.lblStatus);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.btnStop);
            this.Controls.Add(this.btnStart);
            this.Controls.Add(this.txtMessage);
            this.Controls.Add(this.progressDownload);
            this.Controls.Add(this.cboMapType);
            this.Controls.Add(this.lblMapType);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.txtAddress);
            this.Controls.Add(this.btnGo);
            this.Controls.Add(this.btnZoomOut);
            this.Controls.Add(this.btnZoomIn);
            this.Controls.Add(this.btnDown);
            this.Controls.Add(this.btnRight);
            this.Controls.Add(this.btnReset);
            this.Controls.Add(this.btnLeft);
            this.Controls.Add(this.btnUp);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "MainWindow";
            this.Text = "MapAbc离线地图工具 https://www.mapabc.com";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.MainWindow_FormClosed);
            this.Load += new System.EventHandler(this.MainWindow_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.picMapCanvas)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnUp;
        private System.Windows.Forms.Button btnLeft;
        private System.Windows.Forms.Button btnReset;
        private System.Windows.Forms.Button btnRight;
        private System.Windows.Forms.Button btnDown;
        private System.Windows.Forms.Button btnZoomIn;
        private System.Windows.Forms.Button btnZoomOut;
        private System.Windows.Forms.Button btnGo;
        private System.Windows.Forms.TextBox txtAddress;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.MaskedTextBox txtY2;
        private System.Windows.Forms.MaskedTextBox txtY1;
        private System.Windows.Forms.MaskedTextBox txtX2;
        private System.Windows.Forms.MaskedTextBox txtX1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.CheckBox chk9;
        private System.Windows.Forms.CheckBox chk8;
        private System.Windows.Forms.CheckBox chk7;
        private System.Windows.Forms.CheckBox chk6;
        private System.Windows.Forms.CheckBox chk5;
        private System.Windows.Forms.CheckBox chk4;
        private System.Windows.Forms.CheckBox chk3;
        private System.Windows.Forms.CheckBox chk2;
        private System.Windows.Forms.CheckBox chk17;
        private System.Windows.Forms.CheckBox chk16;
        private System.Windows.Forms.CheckBox chk15;
        private System.Windows.Forms.CheckBox chk14;
        private System.Windows.Forms.CheckBox chk13;
        private System.Windows.Forms.CheckBox chk12;
        private System.Windows.Forms.CheckBox chk11;
        private System.Windows.Forms.CheckBox chk10;
        private System.Windows.Forms.Label lblMessage;
        private System.Windows.Forms.Label lblMapType;
        private System.Windows.Forms.ComboBox cboMapType;
        private System.Windows.Forms.ProgressBar progressDownload;
        private System.Windows.Forms.TextBox txtMessage;
        private System.Windows.Forms.Button btnStart;
        private System.Windows.Forms.Button btnStop;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox picMapCanvas;
        private System.Windows.Forms.Label lblStatus;
        private System.Windows.Forms.Button btnLoad;
        private System.Windows.Forms.Button btnServer;
        private System.Windows.Forms.CheckBox chk18;
        private System.Windows.Forms.CheckBox chk22;
        private System.Windows.Forms.CheckBox chk21;
        private System.Windows.Forms.CheckBox chk20;
        private System.Windows.Forms.CheckBox chk19;
    }
}