namespace BunyV2
{
    partial class MyForm
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
            BunifuAnimatorNS.Animation animation2 = new BunifuAnimatorNS.Animation();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MyForm));
            this.hideHeader = new Bunifu.Framework.UI.BunifuElipse(this.components);
            this.dragControl = new Bunifu.Framework.UI.BunifuDragControl(this.components);
            this.pnlHeader = new System.Windows.Forms.Panel();
            this.checkStatus = new Bunifu.Framework.UI.BunifuCheckbox();
            this.bunifuCustomLabel3 = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.btnExit = new Bunifu.Framework.UI.BunifuImageButton();
            this.lblFormname = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.txtPass = new System.Windows.Forms.TextBox();
            this.txtUser = new System.Windows.Forms.TextBox();
            this.txtPort = new System.Windows.Forms.TextBox();
            this.txtBroker = new System.Windows.Forms.TextBox();
            this.bunifuCustomLabel2 = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.bunifuCustomLabel1 = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.lblPort = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.lblBrokername = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.btnLed1 = new Bunifu.Framework.UI.BunifuImageButton();
            this.LED1 = new System.Windows.Forms.PictureBox();
            this.btnConnect = new Bunifu.Framework.UI.BunifuThinButton2();
            this.btnLed2 = new Bunifu.Framework.UI.BunifuImageButton();
            this.btnLed3 = new Bunifu.Framework.UI.BunifuImageButton();
            this.btnLed4 = new Bunifu.Framework.UI.BunifuImageButton();
            this.LED4 = new System.Windows.Forms.PictureBox();
            this.LED3 = new System.Windows.Forms.PictureBox();
            this.LED2 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.pnlLED = new System.Windows.Forms.Panel();
            this.btnLED = new Bunifu.Framework.UI.BunifuThinButton2();
            this.aniLED = new BunifuAnimatorNS.BunifuTransition(this.components);
            this.pnlIntro = new System.Windows.Forms.Panel();
            this.bunifuCustomLabel4 = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.lblIntro = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.lblTemp = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.temperature = new Bunifu.Framework.UI.BunifuCircleProgressbar();
            this.btnSensor = new Bunifu.Framework.UI.BunifuThinButton2();
            this.humidity = new Bunifu.Framework.UI.BunifuCircleProgressbar();
            this.pnlSensor = new System.Windows.Forms.Panel();
            this.lblHumi = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.bunifuCustomLabel5 = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.bunifuCustomLabel6 = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.bunifuCustomLabel7 = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.bunifuCustomLabel8 = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.pnlHeader.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnExit)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnLed1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.LED1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnLed2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnLed3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnLed4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.LED4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.LED3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.LED2)).BeginInit();
            this.pnlLED.SuspendLayout();
            this.pnlIntro.SuspendLayout();
            this.pnlSensor.SuspendLayout();
            this.SuspendLayout();
            // 
            // hideHeader
            // 
            this.hideHeader.ElipseRadius = 5;
            this.hideHeader.TargetControl = this;
            // 
            // dragControl
            // 
            this.dragControl.Fixed = true;
            this.dragControl.Horizontal = true;
            this.dragControl.TargetControl = this.pnlHeader;
            this.dragControl.Vertical = true;
            // 
            // pnlHeader
            // 
            this.pnlHeader.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(102)))), ((int)(((byte)(204)))));
            this.pnlHeader.Controls.Add(this.checkStatus);
            this.pnlHeader.Controls.Add(this.bunifuCustomLabel3);
            this.pnlHeader.Controls.Add(this.btnExit);
            this.pnlHeader.Controls.Add(this.lblFormname);
            this.pnlHeader.Controls.Add(this.pictureBox1);
            this.aniLED.SetDecoration(this.pnlHeader, BunifuAnimatorNS.DecorationType.None);
            this.pnlHeader.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlHeader.Location = new System.Drawing.Point(0, 0);
            this.pnlHeader.Name = "pnlHeader";
            this.pnlHeader.Size = new System.Drawing.Size(623, 55);
            this.pnlHeader.TabIndex = 0;
            // 
            // checkStatus
            // 
            this.checkStatus.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(205)))), ((int)(((byte)(117)))));
            this.checkStatus.ChechedOffColor = System.Drawing.Color.Red;
            this.checkStatus.Checked = true;
            this.checkStatus.CheckedOnColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(205)))), ((int)(((byte)(117)))));
            this.aniLED.SetDecoration(this.checkStatus, BunifuAnimatorNS.DecorationType.None);
            this.checkStatus.ForeColor = System.Drawing.Color.White;
            this.checkStatus.Location = new System.Drawing.Point(429, 18);
            this.checkStatus.Name = "checkStatus";
            this.checkStatus.Size = new System.Drawing.Size(20, 20);
            this.checkStatus.TabIndex = 9;
            // 
            // bunifuCustomLabel3
            // 
            this.bunifuCustomLabel3.AutoSize = true;
            this.aniLED.SetDecoration(this.bunifuCustomLabel3, BunifuAnimatorNS.DecorationType.None);
            this.bunifuCustomLabel3.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuCustomLabel3.ForeColor = System.Drawing.Color.White;
            this.bunifuCustomLabel3.Location = new System.Drawing.Point(330, 17);
            this.bunifuCustomLabel3.Name = "bunifuCustomLabel3";
            this.bunifuCustomLabel3.Size = new System.Drawing.Size(59, 21);
            this.bunifuCustomLabel3.TabIndex = 8;
            this.bunifuCustomLabel3.Text = "Status";
            // 
            // btnExit
            // 
            this.btnExit.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(102)))), ((int)(((byte)(204)))));
            this.aniLED.SetDecoration(this.btnExit, BunifuAnimatorNS.DecorationType.None);
            this.btnExit.Image = ((System.Drawing.Image)(resources.GetObject("btnExit.Image")));
            this.btnExit.ImageActive = null;
            this.btnExit.Location = new System.Drawing.Point(563, 11);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(34, 27);
            this.btnExit.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btnExit.TabIndex = 7;
            this.btnExit.TabStop = false;
            this.btnExit.Zoom = 10;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // lblFormname
            // 
            this.lblFormname.AutoSize = true;
            this.aniLED.SetDecoration(this.lblFormname, BunifuAnimatorNS.DecorationType.None);
            this.lblFormname.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFormname.ForeColor = System.Drawing.Color.White;
            this.lblFormname.Location = new System.Drawing.Point(60, 14);
            this.lblFormname.Name = "lblFormname";
            this.lblFormname.Size = new System.Drawing.Size(186, 24);
            this.lblFormname.TabIndex = 6;
            this.lblFormname.Text = "MQTT Dash Board";
            // 
            // pictureBox1
            // 
            this.aniLED.SetDecoration(this.pictureBox1, BunifuAnimatorNS.DecorationType.None);
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(12, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(26, 26);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 5;
            this.pictureBox1.TabStop = false;
            // 
            // txtPass
            // 
            this.aniLED.SetDecoration(this.txtPass, BunifuAnimatorNS.DecorationType.None);
            this.txtPass.Location = new System.Drawing.Point(419, 111);
            this.txtPass.Name = "txtPass";
            this.txtPass.Size = new System.Drawing.Size(131, 20);
            this.txtPass.TabIndex = 17;
            this.txtPass.UseSystemPasswordChar = true;
            // 
            // txtUser
            // 
            this.aniLED.SetDecoration(this.txtUser, BunifuAnimatorNS.DecorationType.None);
            this.txtUser.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtUser.Location = new System.Drawing.Point(419, 85);
            this.txtUser.Name = "txtUser";
            this.txtUser.Size = new System.Drawing.Size(131, 21);
            this.txtUser.TabIndex = 16;
            // 
            // txtPort
            // 
            this.aniLED.SetDecoration(this.txtPort, BunifuAnimatorNS.DecorationType.None);
            this.txtPort.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPort.Location = new System.Drawing.Point(143, 111);
            this.txtPort.Name = "txtPort";
            this.txtPort.Size = new System.Drawing.Size(137, 21);
            this.txtPort.TabIndex = 15;
            // 
            // txtBroker
            // 
            this.aniLED.SetDecoration(this.txtBroker, BunifuAnimatorNS.DecorationType.None);
            this.txtBroker.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBroker.Location = new System.Drawing.Point(143, 85);
            this.txtBroker.Name = "txtBroker";
            this.txtBroker.Size = new System.Drawing.Size(137, 21);
            this.txtBroker.TabIndex = 14;
            // 
            // bunifuCustomLabel2
            // 
            this.bunifuCustomLabel2.AutoSize = true;
            this.aniLED.SetDecoration(this.bunifuCustomLabel2, BunifuAnimatorNS.DecorationType.None);
            this.bunifuCustomLabel2.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuCustomLabel2.ForeColor = System.Drawing.Color.White;
            this.bunifuCustomLabel2.Location = new System.Drawing.Point(320, 113);
            this.bunifuCustomLabel2.Name = "bunifuCustomLabel2";
            this.bunifuCustomLabel2.Size = new System.Drawing.Size(69, 17);
            this.bunifuCustomLabel2.TabIndex = 13;
            this.bunifuCustomLabel2.Text = "Password";
            // 
            // bunifuCustomLabel1
            // 
            this.bunifuCustomLabel1.AutoSize = true;
            this.aniLED.SetDecoration(this.bunifuCustomLabel1, BunifuAnimatorNS.DecorationType.None);
            this.bunifuCustomLabel1.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuCustomLabel1.ForeColor = System.Drawing.Color.White;
            this.bunifuCustomLabel1.Location = new System.Drawing.Point(320, 85);
            this.bunifuCustomLabel1.Name = "bunifuCustomLabel1";
            this.bunifuCustomLabel1.Size = new System.Drawing.Size(77, 17);
            this.bunifuCustomLabel1.TabIndex = 12;
            this.bunifuCustomLabel1.Text = "User Name";
            // 
            // lblPort
            // 
            this.lblPort.AutoSize = true;
            this.aniLED.SetDecoration(this.lblPort, BunifuAnimatorNS.DecorationType.None);
            this.lblPort.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPort.ForeColor = System.Drawing.Color.White;
            this.lblPort.Location = new System.Drawing.Point(33, 114);
            this.lblPort.Name = "lblPort";
            this.lblPort.Size = new System.Drawing.Size(34, 17);
            this.lblPort.TabIndex = 11;
            this.lblPort.Text = "Port";
            // 
            // lblBrokername
            // 
            this.lblBrokername.AutoSize = true;
            this.aniLED.SetDecoration(this.lblBrokername, BunifuAnimatorNS.DecorationType.None);
            this.lblBrokername.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBrokername.ForeColor = System.Drawing.Color.White;
            this.lblBrokername.Location = new System.Drawing.Point(33, 86);
            this.lblBrokername.Name = "lblBrokername";
            this.lblBrokername.Size = new System.Drawing.Size(91, 17);
            this.lblBrokername.TabIndex = 10;
            this.lblBrokername.Text = "Broker Name";
            // 
            // btnLed1
            // 
            this.btnLed1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(46)))), ((int)(((byte)(59)))));
            this.aniLED.SetDecoration(this.btnLed1, BunifuAnimatorNS.DecorationType.None);
            this.btnLed1.Image = global::BunyV2.Properties.Resources.Remote_Control_48px;
            this.btnLed1.ImageActive = null;
            this.btnLed1.Location = new System.Drawing.Point(13, 6);
            this.btnLed1.Name = "btnLed1";
            this.btnLed1.Size = new System.Drawing.Size(65, 47);
            this.btnLed1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btnLed1.TabIndex = 20;
            this.btnLed1.TabStop = false;
            this.btnLed1.Zoom = 10;
            this.btnLed1.Click += new System.EventHandler(this.btnLed1_Click);
            // 
            // LED1
            // 
            this.aniLED.SetDecoration(this.LED1, BunifuAnimatorNS.DecorationType.None);
            this.LED1.Image = global::BunyV2.Properties.Resources.Light_On_48px;
            this.LED1.Location = new System.Drawing.Point(14, 78);
            this.LED1.Name = "LED1";
            this.LED1.Size = new System.Drawing.Size(64, 51);
            this.LED1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.LED1.TabIndex = 19;
            this.LED1.TabStop = false;
            // 
            // btnConnect
            // 
            this.btnConnect.ActiveBorderThickness = 1;
            this.btnConnect.ActiveCornerRadius = 20;
            this.btnConnect.ActiveFillColor = System.Drawing.Color.SeaGreen;
            this.btnConnect.ActiveForecolor = System.Drawing.Color.White;
            this.btnConnect.ActiveLineColor = System.Drawing.Color.SeaGreen;
            this.btnConnect.AutoSize = true;
            this.btnConnect.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(46)))), ((int)(((byte)(59)))));
            this.btnConnect.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnConnect.BackgroundImage")));
            this.btnConnect.ButtonText = "Connect";
            this.btnConnect.Cursor = System.Windows.Forms.Cursors.Hand;
            this.aniLED.SetDecoration(this.btnConnect, BunifuAnimatorNS.DecorationType.None);
            this.btnConnect.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnConnect.ForeColor = System.Drawing.Color.Lime;
            this.btnConnect.IdleBorderThickness = 1;
            this.btnConnect.IdleCornerRadius = 20;
            this.btnConnect.IdleFillColor = System.Drawing.Color.White;
            this.btnConnect.IdleForecolor = System.Drawing.Color.SeaGreen;
            this.btnConnect.IdleLineColor = System.Drawing.Color.SeaGreen;
            this.btnConnect.Location = new System.Drawing.Point(32, 159);
            this.btnConnect.Margin = new System.Windows.Forms.Padding(4);
            this.btnConnect.Name = "btnConnect";
            this.btnConnect.Size = new System.Drawing.Size(59, 37);
            this.btnConnect.TabIndex = 18;
            this.btnConnect.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnConnect.Click += new System.EventHandler(this.btnConnect_Click);
            // 
            // btnLed2
            // 
            this.btnLed2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(46)))), ((int)(((byte)(59)))));
            this.aniLED.SetDecoration(this.btnLed2, BunifuAnimatorNS.DecorationType.None);
            this.btnLed2.Image = global::BunyV2.Properties.Resources.Remote_Control_48px;
            this.btnLed2.ImageActive = null;
            this.btnLed2.Location = new System.Drawing.Point(123, 6);
            this.btnLed2.Name = "btnLed2";
            this.btnLed2.Size = new System.Drawing.Size(65, 47);
            this.btnLed2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btnLed2.TabIndex = 21;
            this.btnLed2.TabStop = false;
            this.btnLed2.Zoom = 10;
            this.btnLed2.Click += new System.EventHandler(this.btnLed1_Click);
            // 
            // btnLed3
            // 
            this.btnLed3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(46)))), ((int)(((byte)(59)))));
            this.aniLED.SetDecoration(this.btnLed3, BunifuAnimatorNS.DecorationType.None);
            this.btnLed3.Image = global::BunyV2.Properties.Resources.Remote_Control_48px;
            this.btnLed3.ImageActive = null;
            this.btnLed3.Location = new System.Drawing.Point(242, 6);
            this.btnLed3.Name = "btnLed3";
            this.btnLed3.Size = new System.Drawing.Size(65, 47);
            this.btnLed3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btnLed3.TabIndex = 22;
            this.btnLed3.TabStop = false;
            this.btnLed3.Zoom = 10;
            this.btnLed3.Click += new System.EventHandler(this.btnLed1_Click);
            // 
            // btnLed4
            // 
            this.btnLed4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(46)))), ((int)(((byte)(59)))));
            this.aniLED.SetDecoration(this.btnLed4, BunifuAnimatorNS.DecorationType.None);
            this.btnLed4.Image = global::BunyV2.Properties.Resources.Remote_Control_48px;
            this.btnLed4.ImageActive = null;
            this.btnLed4.Location = new System.Drawing.Point(354, 6);
            this.btnLed4.Name = "btnLed4";
            this.btnLed4.Size = new System.Drawing.Size(65, 47);
            this.btnLed4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btnLed4.TabIndex = 23;
            this.btnLed4.TabStop = false;
            this.btnLed4.Zoom = 10;
            this.btnLed4.Click += new System.EventHandler(this.btnLed1_Click);
            // 
            // LED4
            // 
            this.aniLED.SetDecoration(this.LED4, BunifuAnimatorNS.DecorationType.None);
            this.LED4.Image = global::BunyV2.Properties.Resources.Light_On_48px;
            this.LED4.Location = new System.Drawing.Point(355, 78);
            this.LED4.Name = "LED4";
            this.LED4.Size = new System.Drawing.Size(64, 51);
            this.LED4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.LED4.TabIndex = 25;
            this.LED4.TabStop = false;
            // 
            // LED3
            // 
            this.aniLED.SetDecoration(this.LED3, BunifuAnimatorNS.DecorationType.None);
            this.LED3.Image = global::BunyV2.Properties.Resources.Light_On_48px;
            this.LED3.Location = new System.Drawing.Point(243, 78);
            this.LED3.Name = "LED3";
            this.LED3.Size = new System.Drawing.Size(64, 51);
            this.LED3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.LED3.TabIndex = 26;
            this.LED3.TabStop = false;
            // 
            // LED2
            // 
            this.aniLED.SetDecoration(this.LED2, BunifuAnimatorNS.DecorationType.None);
            this.LED2.Image = global::BunyV2.Properties.Resources.Light_On_48px;
            this.LED2.Location = new System.Drawing.Point(123, 78);
            this.LED2.Name = "LED2";
            this.LED2.Size = new System.Drawing.Size(64, 51);
            this.LED2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.LED2.TabIndex = 27;
            this.LED2.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.aniLED.SetDecoration(this.label1, BunifuAnimatorNS.DecorationType.None);
            this.label1.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Lime;
            this.label1.Location = new System.Drawing.Point(23, 144);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(42, 16);
            this.label1.TabIndex = 28;
            this.label1.Text = "Green";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.aniLED.SetDecoration(this.label2, BunifuAnimatorNS.DecorationType.None);
            this.label2.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.label2.Location = new System.Drawing.Point(133, 144);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(50, 16);
            this.label2.TabIndex = 29;
            this.label2.Text = "Orange";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.aniLED.SetDecoration(this.label3, BunifuAnimatorNS.DecorationType.None);
            this.label3.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.label3.Location = new System.Drawing.Point(371, 144);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(30, 16);
            this.label3.TabIndex = 30;
            this.label3.Text = "Blue";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.aniLED.SetDecoration(this.label4, BunifuAnimatorNS.DecorationType.None);
            this.label4.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.Red;
            this.label4.Location = new System.Drawing.Point(257, 144);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(30, 16);
            this.label4.TabIndex = 31;
            this.label4.Text = "Red";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // pnlLED
            // 
            this.pnlLED.Controls.Add(this.label4);
            this.pnlLED.Controls.Add(this.label3);
            this.pnlLED.Controls.Add(this.label2);
            this.pnlLED.Controls.Add(this.label1);
            this.pnlLED.Controls.Add(this.LED2);
            this.pnlLED.Controls.Add(this.LED3);
            this.pnlLED.Controls.Add(this.LED4);
            this.pnlLED.Controls.Add(this.btnLed4);
            this.pnlLED.Controls.Add(this.btnLed3);
            this.pnlLED.Controls.Add(this.btnLed2);
            this.pnlLED.Controls.Add(this.btnLed1);
            this.pnlLED.Controls.Add(this.LED1);
            this.aniLED.SetDecoration(this.pnlLED, BunifuAnimatorNS.DecorationType.None);
            this.pnlLED.Location = new System.Drawing.Point(143, 166);
            this.pnlLED.Name = "pnlLED";
            this.pnlLED.Size = new System.Drawing.Size(438, 174);
            this.pnlLED.TabIndex = 32;
            // 
            // btnLED
            // 
            this.btnLED.ActiveBorderThickness = 1;
            this.btnLED.ActiveCornerRadius = 20;
            this.btnLED.ActiveFillColor = System.Drawing.Color.SeaGreen;
            this.btnLED.ActiveForecolor = System.Drawing.Color.White;
            this.btnLED.ActiveLineColor = System.Drawing.Color.SeaGreen;
            this.btnLED.AutoSize = true;
            this.btnLED.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(46)))), ((int)(((byte)(59)))));
            this.btnLED.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnLED.BackgroundImage")));
            this.btnLED.ButtonText = "LED";
            this.btnLED.Cursor = System.Windows.Forms.Cursors.Hand;
            this.aniLED.SetDecoration(this.btnLED, BunifuAnimatorNS.DecorationType.None);
            this.btnLED.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLED.ForeColor = System.Drawing.Color.Lime;
            this.btnLED.IdleBorderThickness = 1;
            this.btnLED.IdleCornerRadius = 20;
            this.btnLED.IdleFillColor = System.Drawing.Color.White;
            this.btnLED.IdleForecolor = System.Drawing.Color.SeaGreen;
            this.btnLED.IdleLineColor = System.Drawing.Color.SeaGreen;
            this.btnLED.Location = new System.Drawing.Point(32, 204);
            this.btnLED.Margin = new System.Windows.Forms.Padding(4);
            this.btnLED.Name = "btnLED";
            this.btnLED.Size = new System.Drawing.Size(59, 37);
            this.btnLED.TabIndex = 33;
            this.btnLED.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnLED.Click += new System.EventHandler(this.btnLED_Click);
            // 
            // aniLED
            // 
            this.aniLED.AnimationType = BunifuAnimatorNS.AnimationType.ScaleAndRotate;
            this.aniLED.Cursor = null;
            animation2.AnimateOnlyDifferences = true;
            animation2.BlindCoeff = ((System.Drawing.PointF)(resources.GetObject("animation2.BlindCoeff")));
            animation2.LeafCoeff = 0F;
            animation2.MaxTime = 1F;
            animation2.MinTime = 0F;
            animation2.MosaicCoeff = ((System.Drawing.PointF)(resources.GetObject("animation2.MosaicCoeff")));
            animation2.MosaicShift = ((System.Drawing.PointF)(resources.GetObject("animation2.MosaicShift")));
            animation2.MosaicSize = 0;
            animation2.Padding = new System.Windows.Forms.Padding(30);
            animation2.RotateCoeff = 0.5F;
            animation2.RotateLimit = 0.2F;
            animation2.ScaleCoeff = ((System.Drawing.PointF)(resources.GetObject("animation2.ScaleCoeff")));
            animation2.SlideCoeff = ((System.Drawing.PointF)(resources.GetObject("animation2.SlideCoeff")));
            animation2.TimeCoeff = 0F;
            animation2.TransparencyCoeff = 0F;
            this.aniLED.DefaultAnimation = animation2;
            // 
            // pnlIntro
            // 
            this.pnlIntro.Controls.Add(this.bunifuCustomLabel4);
            this.pnlIntro.Controls.Add(this.lblIntro);
            this.aniLED.SetDecoration(this.pnlIntro, BunifuAnimatorNS.DecorationType.None);
            this.pnlIntro.Location = new System.Drawing.Point(139, 169);
            this.pnlIntro.Name = "pnlIntro";
            this.pnlIntro.Size = new System.Drawing.Size(458, 169);
            this.pnlIntro.TabIndex = 34;
            // 
            // bunifuCustomLabel4
            // 
            this.bunifuCustomLabel4.AutoSize = true;
            this.aniLED.SetDecoration(this.bunifuCustomLabel4, BunifuAnimatorNS.DecorationType.None);
            this.bunifuCustomLabel4.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuCustomLabel4.ForeColor = System.Drawing.Color.White;
            this.bunifuCustomLabel4.Location = new System.Drawing.Point(422, 188);
            this.bunifuCustomLabel4.Name = "bunifuCustomLabel4";
            this.bunifuCustomLabel4.Size = new System.Drawing.Size(33, 21);
            this.bunifuCustomLabel4.TabIndex = 37;
            this.bunifuCustomLabel4.Text = "oC";
            // 
            // lblIntro
            // 
            this.lblIntro.AutoSize = true;
            this.aniLED.SetDecoration(this.lblIntro, BunifuAnimatorNS.DecorationType.None);
            this.lblIntro.Font = new System.Drawing.Font("Century Gothic", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblIntro.ForeColor = System.Drawing.Color.White;
            this.lblIntro.Location = new System.Drawing.Point(76, 60);
            this.lblIntro.Name = "lblIntro";
            this.lblIntro.Size = new System.Drawing.Size(331, 33);
            this.lblIntro.TabIndex = 7;
            this.lblIntro.Text = "Designed by Thanh Phat";
            // 
            // lblTemp
            // 
            this.lblTemp.AutoSize = true;
            this.aniLED.SetDecoration(this.lblTemp, BunifuAnimatorNS.DecorationType.None);
            this.lblTemp.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTemp.ForeColor = System.Drawing.Color.White;
            this.lblTemp.Location = new System.Drawing.Point(111, 91);
            this.lblTemp.Name = "lblTemp";
            this.lblTemp.Size = new System.Drawing.Size(22, 21);
            this.lblTemp.TabIndex = 36;
            this.lblTemp.Text = "...";
            // 
            // temperature
            // 
            this.temperature.animated = false;
            this.temperature.animationIterval = 5;
            this.temperature.animationSpeed = 300;
            this.temperature.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(46)))), ((int)(((byte)(59)))));
            this.temperature.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("temperature.BackgroundImage")));
            this.aniLED.SetDecoration(this.temperature, BunifuAnimatorNS.DecorationType.None);
            this.temperature.Font = new System.Drawing.Font("Microsoft Sans Serif", 26.25F);
            this.temperature.ForeColor = System.Drawing.Color.SeaGreen;
            this.temperature.LabelVisible = false;
            this.temperature.LineProgressThickness = 8;
            this.temperature.LineThickness = 5;
            this.temperature.Location = new System.Drawing.Point(67, 50);
            this.temperature.Margin = new System.Windows.Forms.Padding(10, 9, 10, 9);
            this.temperature.MaxValue = 100;
            this.temperature.Name = "temperature";
            this.temperature.ProgressBackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.temperature.ProgressColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.temperature.Size = new System.Drawing.Size(112, 112);
            this.temperature.TabIndex = 35;
            this.temperature.Value = 50;
            // 
            // btnSensor
            // 
            this.btnSensor.ActiveBorderThickness = 1;
            this.btnSensor.ActiveCornerRadius = 20;
            this.btnSensor.ActiveFillColor = System.Drawing.Color.SeaGreen;
            this.btnSensor.ActiveForecolor = System.Drawing.Color.White;
            this.btnSensor.ActiveLineColor = System.Drawing.Color.SeaGreen;
            this.btnSensor.AutoSize = true;
            this.btnSensor.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(46)))), ((int)(((byte)(59)))));
            this.btnSensor.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnSensor.BackgroundImage")));
            this.btnSensor.ButtonText = "Sensor";
            this.btnSensor.Cursor = System.Windows.Forms.Cursors.Hand;
            this.aniLED.SetDecoration(this.btnSensor, BunifuAnimatorNS.DecorationType.None);
            this.btnSensor.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSensor.ForeColor = System.Drawing.Color.Lime;
            this.btnSensor.IdleBorderThickness = 1;
            this.btnSensor.IdleCornerRadius = 20;
            this.btnSensor.IdleFillColor = System.Drawing.Color.White;
            this.btnSensor.IdleForecolor = System.Drawing.Color.SeaGreen;
            this.btnSensor.IdleLineColor = System.Drawing.Color.SeaGreen;
            this.btnSensor.Location = new System.Drawing.Point(32, 249);
            this.btnSensor.Margin = new System.Windows.Forms.Padding(4);
            this.btnSensor.Name = "btnSensor";
            this.btnSensor.Size = new System.Drawing.Size(59, 37);
            this.btnSensor.TabIndex = 35;
            this.btnSensor.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnSensor.Click += new System.EventHandler(this.btnSensor_Click);
            // 
            // humidity
            // 
            this.humidity.animated = false;
            this.humidity.animationIterval = 5;
            this.humidity.animationSpeed = 300;
            this.humidity.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(46)))), ((int)(((byte)(59)))));
            this.humidity.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("humidity.BackgroundImage")));
            this.aniLED.SetDecoration(this.humidity, BunifuAnimatorNS.DecorationType.None);
            this.humidity.Font = new System.Drawing.Font("Microsoft Sans Serif", 26.25F);
            this.humidity.ForeColor = System.Drawing.Color.SeaGreen;
            this.humidity.LabelVisible = false;
            this.humidity.LineProgressThickness = 8;
            this.humidity.LineThickness = 5;
            this.humidity.Location = new System.Drawing.Point(270, 50);
            this.humidity.Margin = new System.Windows.Forms.Padding(10, 9, 10, 9);
            this.humidity.MaxValue = 100;
            this.humidity.Name = "humidity";
            this.humidity.ProgressBackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.humidity.ProgressColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.humidity.Size = new System.Drawing.Size(112, 112);
            this.humidity.TabIndex = 36;
            this.humidity.Value = 50;
            // 
            // pnlSensor
            // 
            this.pnlSensor.Controls.Add(this.bunifuCustomLabel8);
            this.pnlSensor.Controls.Add(this.bunifuCustomLabel7);
            this.pnlSensor.Controls.Add(this.bunifuCustomLabel6);
            this.pnlSensor.Controls.Add(this.bunifuCustomLabel5);
            this.pnlSensor.Controls.Add(this.lblHumi);
            this.pnlSensor.Controls.Add(this.humidity);
            this.pnlSensor.Controls.Add(this.lblTemp);
            this.pnlSensor.Controls.Add(this.temperature);
            this.aniLED.SetDecoration(this.pnlSensor, BunifuAnimatorNS.DecorationType.None);
            this.pnlSensor.Location = new System.Drawing.Point(128, 143);
            this.pnlSensor.Name = "pnlSensor";
            this.pnlSensor.Size = new System.Drawing.Size(495, 197);
            this.pnlSensor.TabIndex = 37;
            // 
            // lblHumi
            // 
            this.lblHumi.AutoSize = true;
            this.aniLED.SetDecoration(this.lblHumi, BunifuAnimatorNS.DecorationType.None);
            this.lblHumi.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHumi.ForeColor = System.Drawing.Color.White;
            this.lblHumi.Location = new System.Drawing.Point(312, 86);
            this.lblHumi.Name = "lblHumi";
            this.lblHumi.Size = new System.Drawing.Size(22, 21);
            this.lblHumi.TabIndex = 37;
            this.lblHumi.Text = "...";
            // 
            // bunifuCustomLabel5
            // 
            this.bunifuCustomLabel5.AutoSize = true;
            this.aniLED.SetDecoration(this.bunifuCustomLabel5, BunifuAnimatorNS.DecorationType.None);
            this.bunifuCustomLabel5.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuCustomLabel5.ForeColor = System.Drawing.Color.White;
            this.bunifuCustomLabel5.Location = new System.Drawing.Point(287, 20);
            this.bunifuCustomLabel5.Name = "bunifuCustomLabel5";
            this.bunifuCustomLabel5.Size = new System.Drawing.Size(78, 21);
            this.bunifuCustomLabel5.TabIndex = 38;
            this.bunifuCustomLabel5.Text = "Humidity";
            // 
            // bunifuCustomLabel6
            // 
            this.bunifuCustomLabel6.AutoSize = true;
            this.aniLED.SetDecoration(this.bunifuCustomLabel6, BunifuAnimatorNS.DecorationType.None);
            this.bunifuCustomLabel6.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuCustomLabel6.ForeColor = System.Drawing.Color.White;
            this.bunifuCustomLabel6.Location = new System.Drawing.Point(67, 20);
            this.bunifuCustomLabel6.Name = "bunifuCustomLabel6";
            this.bunifuCustomLabel6.Size = new System.Drawing.Size(112, 21);
            this.bunifuCustomLabel6.TabIndex = 39;
            this.bunifuCustomLabel6.Text = "Temperature";
            // 
            // bunifuCustomLabel7
            // 
            this.bunifuCustomLabel7.AutoSize = true;
            this.aniLED.SetDecoration(this.bunifuCustomLabel7, BunifuAnimatorNS.DecorationType.None);
            this.bunifuCustomLabel7.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuCustomLabel7.ForeColor = System.Drawing.Color.White;
            this.bunifuCustomLabel7.Location = new System.Drawing.Point(312, 119);
            this.bunifuCustomLabel7.Name = "bunifuCustomLabel7";
            this.bunifuCustomLabel7.Size = new System.Drawing.Size(22, 21);
            this.bunifuCustomLabel7.TabIndex = 40;
            this.bunifuCustomLabel7.Text = "%";
            this.bunifuCustomLabel7.Click += new System.EventHandler(this.bunifuCustomLabel7_Click);
            // 
            // bunifuCustomLabel8
            // 
            this.bunifuCustomLabel8.AutoSize = true;
            this.aniLED.SetDecoration(this.bunifuCustomLabel8, BunifuAnimatorNS.DecorationType.None);
            this.bunifuCustomLabel8.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuCustomLabel8.ForeColor = System.Drawing.Color.White;
            this.bunifuCustomLabel8.Location = new System.Drawing.Point(110, 119);
            this.bunifuCustomLabel8.Name = "bunifuCustomLabel8";
            this.bunifuCustomLabel8.Size = new System.Drawing.Size(33, 21);
            this.bunifuCustomLabel8.TabIndex = 41;
            this.bunifuCustomLabel8.Text = "oC";
            // 
            // MyForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(46)))), ((int)(((byte)(59)))));
            this.ClientSize = new System.Drawing.Size(623, 363);
            this.Controls.Add(this.pnlSensor);
            this.Controls.Add(this.btnSensor);
            this.Controls.Add(this.pnlIntro);
            this.Controls.Add(this.pnlLED);
            this.Controls.Add(this.btnLED);
            this.Controls.Add(this.btnConnect);
            this.Controls.Add(this.txtPass);
            this.Controls.Add(this.txtUser);
            this.Controls.Add(this.txtPort);
            this.Controls.Add(this.txtBroker);
            this.Controls.Add(this.bunifuCustomLabel2);
            this.Controls.Add(this.bunifuCustomLabel1);
            this.Controls.Add(this.lblPort);
            this.Controls.Add(this.lblBrokername);
            this.Controls.Add(this.pnlHeader);
            this.aniLED.SetDecoration(this, BunifuAnimatorNS.DecorationType.None);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "MyForm";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.MyForm_Load);
            this.pnlHeader.ResumeLayout(false);
            this.pnlHeader.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnExit)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnLed1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.LED1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnLed2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnLed3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnLed4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.LED4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.LED3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.LED2)).EndInit();
            this.pnlLED.ResumeLayout(false);
            this.pnlLED.PerformLayout();
            this.pnlIntro.ResumeLayout(false);
            this.pnlIntro.PerformLayout();
            this.pnlSensor.ResumeLayout(false);
            this.pnlSensor.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Bunifu.Framework.UI.BunifuElipse hideHeader;
        private Bunifu.Framework.UI.BunifuDragControl dragControl;
        private System.Windows.Forms.Panel pnlHeader;
        private Bunifu.Framework.UI.BunifuCheckbox checkStatus;
        private Bunifu.Framework.UI.BunifuCustomLabel bunifuCustomLabel3;
        private Bunifu.Framework.UI.BunifuImageButton btnExit;
        private Bunifu.Framework.UI.BunifuCustomLabel lblFormname;
        private System.Windows.Forms.PictureBox pictureBox1;
        private Bunifu.Framework.UI.BunifuThinButton2 btnConnect;
        private System.Windows.Forms.TextBox txtPass;
        private System.Windows.Forms.TextBox txtUser;
        private System.Windows.Forms.TextBox txtPort;
        private System.Windows.Forms.TextBox txtBroker;
        private Bunifu.Framework.UI.BunifuCustomLabel bunifuCustomLabel2;
        private Bunifu.Framework.UI.BunifuCustomLabel bunifuCustomLabel1;
        private Bunifu.Framework.UI.BunifuCustomLabel lblPort;
        private Bunifu.Framework.UI.BunifuCustomLabel lblBrokername;
        private System.Windows.Forms.PictureBox LED1;
        private Bunifu.Framework.UI.BunifuImageButton btnLed1;
        private Bunifu.Framework.UI.BunifuImageButton btnLed4;
        private Bunifu.Framework.UI.BunifuImageButton btnLed3;
        private Bunifu.Framework.UI.BunifuImageButton btnLed2;
        private System.Windows.Forms.PictureBox LED2;
        private System.Windows.Forms.PictureBox LED3;
        private System.Windows.Forms.PictureBox LED4;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private Bunifu.Framework.UI.BunifuThinButton2 btnLED;
        private System.Windows.Forms.Panel pnlLED;
        private BunifuAnimatorNS.BunifuTransition aniLED;
        private System.Windows.Forms.Panel pnlIntro;
        public Bunifu.Framework.UI.BunifuCustomLabel lblIntro;
        private Bunifu.Framework.UI.BunifuCircleProgressbar temperature;
        private Bunifu.Framework.UI.BunifuCustomLabel bunifuCustomLabel4;
        private Bunifu.Framework.UI.BunifuCustomLabel lblTemp;
        private Bunifu.Framework.UI.BunifuThinButton2 btnSensor;
        private Bunifu.Framework.UI.BunifuCircleProgressbar humidity;
        private System.Windows.Forms.Panel pnlSensor;
        private Bunifu.Framework.UI.BunifuCustomLabel lblHumi;
        private Bunifu.Framework.UI.BunifuCustomLabel bunifuCustomLabel8;
        private Bunifu.Framework.UI.BunifuCustomLabel bunifuCustomLabel7;
        private Bunifu.Framework.UI.BunifuCustomLabel bunifuCustomLabel6;
        private Bunifu.Framework.UI.BunifuCustomLabel bunifuCustomLabel5;
    }
}

