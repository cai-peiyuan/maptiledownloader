﻿namespace MapDigit
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
            resources.ApplyResources(this.btnUp, "btnUp");
            this.btnUp.Name = "btnUp";
            this.btnUp.UseVisualStyleBackColor = true;
            this.btnUp.Click += new System.EventHandler(this.btnUp_Click);
            // 
            // btnLeft
            // 
            resources.ApplyResources(this.btnLeft, "btnLeft");
            this.btnLeft.Name = "btnLeft";
            this.btnLeft.UseVisualStyleBackColor = true;
            this.btnLeft.Click += new System.EventHandler(this.btnLeft_Click);
            // 
            // btnReset
            // 
            resources.ApplyResources(this.btnReset, "btnReset");
            this.btnReset.Name = "btnReset";
            this.btnReset.UseVisualStyleBackColor = true;
            this.btnReset.Click += new System.EventHandler(this.btnReset_Click);
            // 
            // btnRight
            // 
            resources.ApplyResources(this.btnRight, "btnRight");
            this.btnRight.Name = "btnRight";
            this.btnRight.UseVisualStyleBackColor = true;
            this.btnRight.Click += new System.EventHandler(this.btnRight_Click);
            // 
            // btnDown
            // 
            resources.ApplyResources(this.btnDown, "btnDown");
            this.btnDown.Name = "btnDown";
            this.btnDown.UseVisualStyleBackColor = true;
            this.btnDown.Click += new System.EventHandler(this.btnDown_Click);
            // 
            // btnZoomIn
            // 
            resources.ApplyResources(this.btnZoomIn, "btnZoomIn");
            this.btnZoomIn.Name = "btnZoomIn";
            this.btnZoomIn.UseVisualStyleBackColor = true;
            this.btnZoomIn.Click += new System.EventHandler(this.btnZoomIn_Click);
            // 
            // btnZoomOut
            // 
            resources.ApplyResources(this.btnZoomOut, "btnZoomOut");
            this.btnZoomOut.Name = "btnZoomOut";
            this.btnZoomOut.UseVisualStyleBackColor = true;
            this.btnZoomOut.Click += new System.EventHandler(this.btnZoomOut_Click);
            // 
            // btnGo
            // 
            resources.ApplyResources(this.btnGo, "btnGo");
            this.btnGo.Name = "btnGo";
            this.btnGo.UseVisualStyleBackColor = true;
            this.btnGo.Click += new System.EventHandler(this.btnGo_Click);
            // 
            // txtAddress
            // 
            resources.ApplyResources(this.txtAddress, "txtAddress");
            this.txtAddress.Name = "txtAddress";
            // 
            // groupBox1
            // 
            resources.ApplyResources(this.groupBox1, "groupBox1");
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
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.TabStop = false;
            // 
            // txtY2
            // 
            resources.ApplyResources(this.txtY2, "txtY2");
            this.txtY2.HidePromptOnLeave = true;
            this.txtY2.Name = "txtY2";
            this.txtY2.TextChanged += new System.EventHandler(this.txtY2_TextChanged);
            // 
            // txtY1
            // 
            resources.ApplyResources(this.txtY1, "txtY1");
            this.txtY1.HidePromptOnLeave = true;
            this.txtY1.Name = "txtY1";
            this.txtY1.TextChanged += new System.EventHandler(this.txtY1_TextChanged);
            // 
            // txtX2
            // 
            resources.ApplyResources(this.txtX2, "txtX2");
            this.txtX2.HidePromptOnLeave = true;
            this.txtX2.Name = "txtX2";
            this.txtX2.TextChanged += new System.EventHandler(this.txtX2_TextChanged);
            // 
            // txtX1
            // 
            resources.ApplyResources(this.txtX1, "txtX1");
            this.txtX1.HidePromptOnLeave = true;
            this.txtX1.Name = "txtX1";
            this.txtX1.TextChanged += new System.EventHandler(this.txtX1_TextChanged);
            // 
            // label6
            // 
            resources.ApplyResources(this.label6, "label6");
            this.label6.Name = "label6";
            // 
            // label5
            // 
            resources.ApplyResources(this.label5, "label5");
            this.label5.Name = "label5";
            // 
            // label4
            // 
            resources.ApplyResources(this.label4, "label4");
            this.label4.Name = "label4";
            // 
            // label3
            // 
            resources.ApplyResources(this.label3, "label3");
            this.label3.Name = "label3";
            // 
            // label2
            // 
            resources.ApplyResources(this.label2, "label2");
            this.label2.Name = "label2";
            // 
            // label1
            // 
            resources.ApplyResources(this.label1, "label1");
            this.label1.Name = "label1";
            // 
            // groupBox2
            // 
            resources.ApplyResources(this.groupBox2, "groupBox2");
            this.groupBox2.Controls.Add(this.chk17);
            this.groupBox2.Controls.Add(this.chk16);
            this.groupBox2.Controls.Add(this.chk15);
            this.groupBox2.Controls.Add(this.chk14);
            this.groupBox2.Controls.Add(this.chk13);
            this.groupBox2.Controls.Add(this.chk12);
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
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.TabStop = false;
            // 
            // chk17
            // 
            resources.ApplyResources(this.chk17, "chk17");
            this.chk17.Name = "chk17";
            this.chk17.UseVisualStyleBackColor = true;
            this.chk17.CheckedChanged += new System.EventHandler(this.chk17_CheckedChanged);
            // 
            // chk16
            // 
            resources.ApplyResources(this.chk16, "chk16");
            this.chk16.Name = "chk16";
            this.chk16.UseVisualStyleBackColor = true;
            this.chk16.CheckedChanged += new System.EventHandler(this.chk16_CheckedChanged);
            // 
            // chk15
            // 
            resources.ApplyResources(this.chk15, "chk15");
            this.chk15.Name = "chk15";
            this.chk15.UseVisualStyleBackColor = true;
            this.chk15.CheckedChanged += new System.EventHandler(this.chk15_CheckedChanged);
            // 
            // chk14
            // 
            resources.ApplyResources(this.chk14, "chk14");
            this.chk14.Name = "chk14";
            this.chk14.UseVisualStyleBackColor = true;
            this.chk14.CheckedChanged += new System.EventHandler(this.chk14_CheckedChanged);
            // 
            // chk13
            // 
            resources.ApplyResources(this.chk13, "chk13");
            this.chk13.Name = "chk13";
            this.chk13.UseVisualStyleBackColor = true;
            this.chk13.CheckedChanged += new System.EventHandler(this.chk13_CheckedChanged);
            // 
            // chk12
            // 
            resources.ApplyResources(this.chk12, "chk12");
            this.chk12.Name = "chk12";
            this.chk12.UseVisualStyleBackColor = true;
            this.chk12.CheckedChanged += new System.EventHandler(this.chk12_CheckedChanged);
            // 
            // chk11
            // 
            resources.ApplyResources(this.chk11, "chk11");
            this.chk11.Name = "chk11";
            this.chk11.UseVisualStyleBackColor = true;
            this.chk11.CheckedChanged += new System.EventHandler(this.chk11_CheckedChanged);
            // 
            // chk10
            // 
            resources.ApplyResources(this.chk10, "chk10");
            this.chk10.Name = "chk10";
            this.chk10.UseVisualStyleBackColor = true;
            this.chk10.CheckedChanged += new System.EventHandler(this.chk10_CheckedChanged);
            // 
            // chk9
            // 
            resources.ApplyResources(this.chk9, "chk9");
            this.chk9.Name = "chk9";
            this.chk9.UseVisualStyleBackColor = true;
            this.chk9.CheckedChanged += new System.EventHandler(this.chk9_CheckedChanged);
            // 
            // chk8
            // 
            resources.ApplyResources(this.chk8, "chk8");
            this.chk8.Name = "chk8";
            this.chk8.UseVisualStyleBackColor = true;
            this.chk8.CheckedChanged += new System.EventHandler(this.chk8_CheckedChanged);
            // 
            // chk7
            // 
            resources.ApplyResources(this.chk7, "chk7");
            this.chk7.Name = "chk7";
            this.chk7.UseVisualStyleBackColor = true;
            this.chk7.CheckedChanged += new System.EventHandler(this.chk7_CheckedChanged);
            // 
            // chk6
            // 
            resources.ApplyResources(this.chk6, "chk6");
            this.chk6.Name = "chk6";
            this.chk6.UseVisualStyleBackColor = true;
            this.chk6.CheckedChanged += new System.EventHandler(this.chk6_CheckedChanged);
            // 
            // chk5
            // 
            resources.ApplyResources(this.chk5, "chk5");
            this.chk5.Name = "chk5";
            this.chk5.UseVisualStyleBackColor = true;
            this.chk5.CheckedChanged += new System.EventHandler(this.chk5_CheckedChanged);
            // 
            // chk4
            // 
            resources.ApplyResources(this.chk4, "chk4");
            this.chk4.Name = "chk4";
            this.chk4.UseVisualStyleBackColor = true;
            this.chk4.CheckedChanged += new System.EventHandler(this.chk4_CheckedChanged);
            // 
            // chk3
            // 
            resources.ApplyResources(this.chk3, "chk3");
            this.chk3.Name = "chk3";
            this.chk3.UseVisualStyleBackColor = true;
            this.chk3.CheckedChanged += new System.EventHandler(this.chk3_CheckedChanged);
            // 
            // chk2
            // 
            resources.ApplyResources(this.chk2, "chk2");
            this.chk2.Name = "chk2";
            this.chk2.UseVisualStyleBackColor = true;
            this.chk2.CheckedChanged += new System.EventHandler(this.chk2_CheckedChanged);
            // 
            // lblMessage
            // 
            resources.ApplyResources(this.lblMessage, "lblMessage");
            this.lblMessage.ForeColor = System.Drawing.Color.Black;
            this.lblMessage.Name = "lblMessage";
            // 
            // lblMapType
            // 
            resources.ApplyResources(this.lblMapType, "lblMapType");
            this.lblMapType.Name = "lblMapType";
            // 
            // cboMapType
            // 
            resources.ApplyResources(this.cboMapType, "cboMapType");
            this.cboMapType.FormattingEnabled = true;
            this.cboMapType.Name = "cboMapType";
            this.cboMapType.SelectedIndexChanged += new System.EventHandler(this.cboMapType_SelectedIndexChanged);
            // 
            // progressDownload
            // 
            resources.ApplyResources(this.progressDownload, "progressDownload");
            this.progressDownload.Name = "progressDownload";
            // 
            // txtMessage
            // 
            resources.ApplyResources(this.txtMessage, "txtMessage");
            this.txtMessage.Name = "txtMessage";
            // 
            // btnStart
            // 
            resources.ApplyResources(this.btnStart, "btnStart");
            this.btnStart.Name = "btnStart";
            this.btnStart.UseVisualStyleBackColor = true;
            this.btnStart.Click += new System.EventHandler(this.btnStart_Click);
            // 
            // btnStop
            // 
            resources.ApplyResources(this.btnStop, "btnStop");
            this.btnStop.Name = "btnStop";
            this.btnStop.UseVisualStyleBackColor = true;
            this.btnStop.Click += new System.EventHandler(this.btnStop_Click);
            // 
            // btnExit
            // 
            resources.ApplyResources(this.btnExit, "btnExit");
            this.btnExit.Name = "btnExit";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // panel1
            // 
            resources.ApplyResources(this.panel1, "panel1");
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel1.Controls.Add(this.picMapCanvas);
            this.panel1.Name = "panel1";
            // 
            // picMapCanvas
            // 
            resources.ApplyResources(this.picMapCanvas, "picMapCanvas");
            this.picMapCanvas.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.picMapCanvas.Cursor = System.Windows.Forms.Cursors.Hand;
            this.picMapCanvas.Name = "picMapCanvas";
            this.picMapCanvas.TabStop = false;
            this.picMapCanvas.MouseDown += new System.Windows.Forms.MouseEventHandler(this.picMapCanvas_MouseDown);
            this.picMapCanvas.MouseMove += new System.Windows.Forms.MouseEventHandler(this.picMapCanvas_MouseMove);
            // 
            // lblStatus
            // 
            resources.ApplyResources(this.lblStatus, "lblStatus");
            this.lblStatus.ForeColor = System.Drawing.Color.Black;
            this.lblStatus.Name = "lblStatus";
            // 
            // btnLoad
            // 
            resources.ApplyResources(this.btnLoad, "btnLoad");
            this.btnLoad.Name = "btnLoad";
            this.btnLoad.UseVisualStyleBackColor = true;
            this.btnLoad.Click += new System.EventHandler(this.btnLoad_Click);
            // 
            // btnServer
            // 
            resources.ApplyResources(this.btnServer, "btnServer");
            this.btnServer.Name = "btnServer";
            this.btnServer.UseVisualStyleBackColor = true;
            this.btnServer.Click += new System.EventHandler(this.btnServer_Click);
            // 
            // MainWindow
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
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
            this.Controls.Add(this.lblMessage);
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
            this.MaximizeBox = false;
            this.Name = "MainWindow";
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
    }
}