namespace ViolaJones
{
    partial class DeteksiWajah
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DeteksiWajah));
            this.timer = new System.Windows.Forms.Timer(this.components);
            this.panel1 = new System.Windows.Forms.Panel();
            this.tabC = new Dotnetrix.Controls.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.button3 = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.progressBar = new System.Windows.Forms.ProgressBar();
            this.imageBoxFrameGrabber = new Emgu.CV.UI.ImageBox();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.panel2 = new System.Windows.Forms.Panel();
            this.labelGagal = new System.Windows.Forms.Label();
            this.textNama = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.button5 = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.textPwd = new System.Windows.Forms.TextBox();
            this.BtnMasuk = new System.Windows.Forms.Button();
            this.tableLayout = new System.Windows.Forms.TableLayoutPanel();
            this.Keluar = new System.Windows.Forms.Button();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.pCtrl = new System.Windows.Forms.Panel();
            this.bSwitch = new System.Windows.Forms.Button();
            this.power = new System.Windows.Forms.Button();
            this.keyB = new System.Windows.Forms.Button();
            this.ProsesShell = new System.Diagnostics.Process();
            this.toolTip = new System.Windows.Forms.ToolTip(this.components);
            this.timerSuspenderLUI = new System.Windows.Forms.Timer(this.components);
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.label6 = new System.Windows.Forms.Label();
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            this.label7 = new System.Windows.Forms.Label();
            this.pictureBox5 = new System.Windows.Forms.PictureBox();
            this.panel1.SuspendLayout();
            this.tabC.SuspendLayout();
            this.tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.imageBoxFrameGrabber)).BeginInit();
            this.tabPage2.SuspendLayout();
            this.panel2.SuspendLayout();
            this.tableLayout.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.pCtrl.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).BeginInit();
            this.SuspendLayout();
            // 
            // timer
            // 
            this.timer.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // panel1
            // 
            this.panel1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.panel1.Controls.Add(this.tabC);
            this.panel1.Location = new System.Drawing.Point(189, 68);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(586, 333);
            this.panel1.TabIndex = 16;
            // 
            // tabC
            // 
            this.tabC.Alignment = System.Windows.Forms.TabAlignment.Bottom;
            this.tabC.Appearance = System.Windows.Forms.TabAppearance.Buttons;
            this.tabC.BackColor = System.Drawing.Color.Transparent;
            this.tabC.Controls.Add(this.tabPage1);
            this.tabC.Controls.Add(this.tabPage2);
            this.tabC.Location = new System.Drawing.Point(3, 3);
            this.tabC.Name = "tabC";
            this.tabC.SelectedIndex = 0;
            this.tabC.SelectedTabColor = System.Drawing.Color.Transparent;
            this.tabC.Size = new System.Drawing.Size(580, 358);
            this.tabC.TabColor = System.Drawing.Color.Transparent;
            this.tabC.TabIndex = 25;
            this.tabC.UseBackColorBehindTabs = true;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.label7);
            this.tabPage1.Controls.Add(this.pictureBox5);
            this.tabPage1.Controls.Add(this.label6);
            this.tabPage1.Controls.Add(this.pictureBox4);
            this.tabPage1.Controls.Add(this.label5);
            this.tabPage1.Controls.Add(this.pictureBox3);
            this.tabPage1.Controls.Add(this.label4);
            this.tabPage1.Controls.Add(this.pictureBox2);
            this.tabPage1.Controls.Add(this.button3);
            this.tabPage1.Controls.Add(this.groupBox1);
            this.tabPage1.Controls.Add(this.label1);
            this.tabPage1.Controls.Add(this.progressBar);
            this.tabPage1.Controls.Add(this.imageBoxFrameGrabber);
            this.tabPage1.Location = new System.Drawing.Point(0, 0);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(580, 334);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "tabPage1";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox2.ErrorImage = null;
            this.pictureBox2.Image = global::ViolaJones.Properties.Resources.ip_g;
            this.pictureBox2.InitialImage = null;
            this.pictureBox2.Location = new System.Drawing.Point(109, 42);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(20, 20);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 21;
            this.pictureBox2.TabStop = false;
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.Color.DodgerBlue;
            this.button3.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.button3.FlatAppearance.MouseOverBackColor = System.Drawing.Color.SteelBlue;
            this.button3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button3.Image = global::ViolaJones.Properties.Resources.up;
            this.button3.Location = new System.Drawing.Point(135, 39);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(320, 240);
            this.button3.TabIndex = 1;
            this.button3.TextImageRelation = System.Windows.Forms.TextImageRelation.TextAboveImage;
            this.toolTip.SetToolTip(this.button3, "Aktifkan kamera");
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.pictureBox1);
            this.groupBox1.Location = new System.Drawing.Point(456, 42);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(121, 132);
            this.groupBox1.TabIndex = 18;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Hasil perngenalan";
            this.groupBox1.Visible = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.ErrorImage = null;
            this.pictureBox1.InitialImage = null;
            this.pictureBox1.Location = new System.Drawing.Point(11, 19);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(100, 100);
            this.pictureBox1.TabIndex = 15;
            this.pictureBox1.TabStop = false;
            // 
            // label1
            // 
            this.label1.Location = new System.Drawing.Point(135, 293);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(320, 20);
            this.label1.TabIndex = 20;
            this.label1.Text = "Memuat database";
            this.label1.TextAlign = System.Drawing.ContentAlignment.BottomLeft;
            // 
            // progressBar
            // 
            this.progressBar.Location = new System.Drawing.Point(135, 315);
            this.progressBar.Name = "progressBar";
            this.progressBar.Size = new System.Drawing.Size(320, 10);
            this.progressBar.Step = 1;
            this.progressBar.TabIndex = 19;
            // 
            // imageBoxFrameGrabber
            // 
            this.imageBoxFrameGrabber.BackColor = System.Drawing.Color.Transparent;
            this.imageBoxFrameGrabber.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.imageBoxFrameGrabber.Enabled = false;
            this.imageBoxFrameGrabber.Location = new System.Drawing.Point(135, 39);
            this.imageBoxFrameGrabber.Name = "imageBoxFrameGrabber";
            this.imageBoxFrameGrabber.Size = new System.Drawing.Size(320, 240);
            this.imageBoxFrameGrabber.TabIndex = 17;
            this.imageBoxFrameGrabber.TabStop = false;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.panel2);
            this.tabPage2.Location = new System.Drawing.Point(0, 0);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(580, 334);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "tabPage2";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.LightSlateGray;
            this.panel2.Controls.Add(this.labelGagal);
            this.panel2.Controls.Add(this.textNama);
            this.panel2.Controls.Add(this.label3);
            this.panel2.Controls.Add(this.button5);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Controls.Add(this.textPwd);
            this.panel2.Controls.Add(this.BtnMasuk);
            this.panel2.Location = new System.Drawing.Point(122, 39);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(318, 242);
            this.panel2.TabIndex = 6;
            // 
            // labelGagal
            // 
            this.labelGagal.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelGagal.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.labelGagal.Location = new System.Drawing.Point(42, 159);
            this.labelGagal.Name = "labelGagal";
            this.labelGagal.Size = new System.Drawing.Size(233, 30);
            this.labelGagal.TabIndex = 6;
            this.labelGagal.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // textNama
            // 
            this.textNama.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textNama.Location = new System.Drawing.Point(42, 45);
            this.textNama.Name = "textNama";
            this.textNama.Size = new System.Drawing.Size(233, 29);
            this.textNama.TabIndex = 0;
            this.toolTip.SetToolTip(this.textNama, "Nama akun untuk ViolaJones");
            this.textNama.KeyDown += new System.Windows.Forms.KeyEventHandler(this.EnterKey);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(38, 86);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(84, 20);
            this.label3.TabIndex = 3;
            this.label3.Text = "Kode Kunci";
            // 
            // button5
            // 
            this.button5.FlatAppearance.BorderSize = 0;
            this.button5.FlatAppearance.MouseOverBackColor = System.Drawing.Color.SteelBlue;
            this.button5.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button5.Image = global::ViolaJones.Properties.Resources.eye;
            this.button5.Location = new System.Drawing.Point(276, 106);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(30, 29);
            this.button5.TabIndex = 5;
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(38, 26);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(118, 20);
            this.label2.TabIndex = 2;
            this.label2.Text = "Nama Pengguna";
            // 
            // textPwd
            // 
            this.textPwd.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textPwd.Location = new System.Drawing.Point(42, 106);
            this.textPwd.MaxLength = 60;
            this.textPwd.Name = "textPwd";
            this.textPwd.PasswordChar = '●';
            this.textPwd.Size = new System.Drawing.Size(233, 29);
            this.textPwd.TabIndex = 1;
            this.textPwd.KeyDown += new System.Windows.Forms.KeyEventHandler(this.EnterKey);
            // 
            // BtnMasuk
            // 
            this.BtnMasuk.BackColor = System.Drawing.Color.Silver;
            this.BtnMasuk.FlatAppearance.BorderSize = 0;
            this.BtnMasuk.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.BtnMasuk.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.ActiveCaption;
            this.BtnMasuk.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnMasuk.Location = new System.Drawing.Point(180, 192);
            this.BtnMasuk.Name = "BtnMasuk";
            this.BtnMasuk.Size = new System.Drawing.Size(95, 30);
            this.BtnMasuk.TabIndex = 4;
            this.BtnMasuk.Text = "Masuk";
            this.BtnMasuk.UseVisualStyleBackColor = false;
            this.BtnMasuk.Click += new System.EventHandler(this.button4_Click);
            // 
            // tableLayout
            // 
            this.tableLayout.BackColor = System.Drawing.Color.Transparent;
            this.tableLayout.ColumnCount = 1;
            this.tableLayout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayout.Controls.Add(this.panel1, 0, 1);
            this.tableLayout.Controls.Add(this.Keluar, 0, 0);
            this.tableLayout.Controls.Add(this.tableLayoutPanel1, 0, 2);
            this.tableLayout.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayout.Location = new System.Drawing.Point(0, 0);
            this.tableLayout.Margin = new System.Windows.Forms.Padding(0);
            this.tableLayout.Name = "tableLayout";
            this.tableLayout.RowCount = 3;
            this.tableLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 14.55939F));
            this.tableLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 85.44061F));
            this.tableLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 92F));
            this.tableLayout.Size = new System.Drawing.Size(965, 543);
            this.tableLayout.TabIndex = 17;
            // 
            // Keluar
            // 
            this.Keluar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.Keluar.Enabled = false;
            this.Keluar.FlatAppearance.BorderSize = 0;
            this.Keluar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.Keluar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Keluar.Font = new System.Drawing.Font("Microsoft Sans Serif", 25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Keluar.ForeColor = System.Drawing.SystemColors.Window;
            this.Keluar.Location = new System.Drawing.Point(900, 3);
            this.Keluar.Name = "Keluar";
            this.Keluar.Size = new System.Drawing.Size(62, 58);
            this.Keluar.TabIndex = 17;
            this.Keluar.Text = "X";
            this.Keluar.UseVisualStyleBackColor = true;
            this.Keluar.Visible = false;
            this.Keluar.Click += new System.EventHandler(this.Keluar_Click);
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.BackColor = System.Drawing.Color.Transparent;
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Controls.Add(this.pCtrl, 0, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 450);
            this.tableLayoutPanel1.Margin = new System.Windows.Forms.Padding(0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 1;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(965, 93);
            this.tableLayoutPanel1.TabIndex = 18;
            // 
            // pCtrl
            // 
            this.pCtrl.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.pCtrl.Controls.Add(this.bSwitch);
            this.pCtrl.Controls.Add(this.power);
            this.pCtrl.Controls.Add(this.keyB);
            this.pCtrl.Location = new System.Drawing.Point(794, 0);
            this.pCtrl.Margin = new System.Windows.Forms.Padding(0);
            this.pCtrl.Name = "pCtrl";
            this.pCtrl.Size = new System.Drawing.Size(171, 49);
            this.pCtrl.TabIndex = 22;
            // 
            // bSwitch
            // 
            this.bSwitch.FlatAppearance.BorderSize = 0;
            this.bSwitch.FlatAppearance.MouseOverBackColor = System.Drawing.Color.SteelBlue;
            this.bSwitch.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bSwitch.Image = global::ViolaJones.Properties.Resources.sleft;
            this.bSwitch.Location = new System.Drawing.Point(8, 3);
            this.bSwitch.Name = "bSwitch";
            this.bSwitch.Size = new System.Drawing.Size(43, 43);
            this.bSwitch.TabIndex = 2;
            this.toolTip.SetToolTip(this.bSwitch, "Ganti mode login");
            this.bSwitch.UseVisualStyleBackColor = true;
            this.bSwitch.Click += new System.EventHandler(this.bSwitch_Click);
            // 
            // power
            // 
            this.power.Enabled = false;
            this.power.FlatAppearance.BorderSize = 0;
            this.power.FlatAppearance.MouseOverBackColor = System.Drawing.Color.SteelBlue;
            this.power.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.power.Image = global::ViolaJones.Properties.Resources.power;
            this.power.Location = new System.Drawing.Point(106, 3);
            this.power.Name = "power";
            this.power.Size = new System.Drawing.Size(43, 43);
            this.power.TabIndex = 4;
            this.toolTip.SetToolTip(this.power, "Matikan Komputer");
            this.power.UseVisualStyleBackColor = true;
            // 
            // keyB
            // 
            this.keyB.FlatAppearance.BorderSize = 0;
            this.keyB.FlatAppearance.MouseOverBackColor = System.Drawing.Color.SteelBlue;
            this.keyB.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.keyB.Image = global::ViolaJones.Properties.Resources.keyb;
            this.keyB.Location = new System.Drawing.Point(57, 3);
            this.keyB.Name = "keyB";
            this.keyB.Size = new System.Drawing.Size(43, 43);
            this.keyB.TabIndex = 3;
            this.toolTip.SetToolTip(this.keyB, "Keyboard");
            this.keyB.UseVisualStyleBackColor = true;
            this.keyB.Click += new System.EventHandler(this.keyBClick);
            // 
            // ProsesShell
            // 
            this.ProsesShell.StartInfo.CreateNoWindow = true;
            this.ProsesShell.StartInfo.Domain = "";
            this.ProsesShell.StartInfo.FileName = "CMD.exe";
            this.ProsesShell.StartInfo.LoadUserProfile = false;
            this.ProsesShell.StartInfo.Password = null;
            this.ProsesShell.StartInfo.RedirectStandardOutput = true;
            this.ProsesShell.StartInfo.StandardErrorEncoding = null;
            this.ProsesShell.StartInfo.StandardOutputEncoding = null;
            this.ProsesShell.StartInfo.UserName = "";
            this.ProsesShell.StartInfo.UseShellExecute = false;
            this.ProsesShell.StartInfo.Verb = "runas";
            this.ProsesShell.StartInfo.WindowStyle = System.Diagnostics.ProcessWindowStyle.Hidden;
            this.ProsesShell.SynchronizingObject = this;
            // 
            // toolTip
            // 
            this.toolTip.AutomaticDelay = 50;
            this.toolTip.AutoPopDelay = 5000;
            this.toolTip.BackColor = System.Drawing.SystemColors.Highlight;
            this.toolTip.InitialDelay = 1;
            this.toolTip.ReshowDelay = 1;
            this.toolTip.ToolTipIcon = System.Windows.Forms.ToolTipIcon.Info;
            this.toolTip.ToolTipTitle = "Info";
            this.toolTip.UseFading = false;
            // 
            // timerSuspenderLUI
            // 
            this.timerSuspenderLUI.Tick += new System.EventHandler(this.LUISuspender);
            // 
            // label4
            // 
            this.label4.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.label4.Location = new System.Drawing.Point(6, 42);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(94, 20);
            this.label4.TabIndex = 22;
            this.label4.Text = "Capturing";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label5
            // 
            this.label5.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.label5.Location = new System.Drawing.Point(6, 62);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(94, 20);
            this.label5.TabIndex = 24;
            this.label5.Text = "Grayscalling";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // pictureBox3
            // 
            this.pictureBox3.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox3.ErrorImage = null;
            this.pictureBox3.Image = global::ViolaJones.Properties.Resources.ip_g;
            this.pictureBox3.InitialImage = null;
            this.pictureBox3.Location = new System.Drawing.Point(109, 62);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(20, 20);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox3.TabIndex = 23;
            this.pictureBox3.TabStop = false;
            // 
            // label6
            // 
            this.label6.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.label6.Location = new System.Drawing.Point(6, 82);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(94, 20);
            this.label6.TabIndex = 26;
            this.label6.Text = "HaarCascade";
            this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // pictureBox4
            // 
            this.pictureBox4.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox4.ErrorImage = null;
            this.pictureBox4.Image = global::ViolaJones.Properties.Resources.ip_g;
            this.pictureBox4.InitialImage = null;
            this.pictureBox4.Location = new System.Drawing.Point(109, 82);
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.Size = new System.Drawing.Size(20, 20);
            this.pictureBox4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox4.TabIndex = 25;
            this.pictureBox4.TabStop = false;
            // 
            // label7
            // 
            this.label7.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.label7.Location = new System.Drawing.Point(6, 102);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(94, 20);
            this.label7.TabIndex = 28;
            this.label7.Text = "Recognizing";
            this.label7.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // pictureBox5
            // 
            this.pictureBox5.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox5.ErrorImage = null;
            this.pictureBox5.Image = global::ViolaJones.Properties.Resources.ip_g;
            this.pictureBox5.InitialImage = null;
            this.pictureBox5.Location = new System.Drawing.Point(109, 102);
            this.pictureBox5.Name = "pictureBox5";
            this.pictureBox5.Size = new System.Drawing.Size(20, 20);
            this.pictureBox5.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox5.TabIndex = 27;
            this.pictureBox5.TabStop = false;
            // 
            // DeteksiWajah
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Highlight;
            this.ClientSize = new System.Drawing.Size(965, 543);
            this.Controls.Add(this.tableLayout);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "DeteksiWajah";
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Deteksi wajah (ViolaJones)";
            this.TopMost = true;
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FormMauKlr);
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.FormKeluar);
            this.Load += new System.EventHandler(this.FaceRecognition_Load);
            this.panel1.ResumeLayout(false);
            this.tabC.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.imageBoxFrameGrabber)).EndInit();
            this.tabPage2.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.tableLayout.ResumeLayout(false);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.pCtrl.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

		private System.Windows.Forms.Timer timer;
		private System.Windows.Forms.Panel panel1;
		private System.Windows.Forms.TableLayoutPanel tableLayout;
		public System.Diagnostics.Process ProsesShell;
		private System.Windows.Forms.Button Keluar;
		private System.Windows.Forms.ProgressBar progressBar;
		private System.Windows.Forms.GroupBox groupBox1;
		private System.Windows.Forms.PictureBox pictureBox1;
		private System.Windows.Forms.Label label1;
		private Emgu.CV.UI.ImageBox imageBoxFrameGrabber;
		private System.Windows.Forms.Panel pCtrl;
		private System.Windows.Forms.ToolTip toolTip;
		private System.Windows.Forms.Button keyB;
		private System.Windows.Forms.Button power;
		private System.Windows.Forms.Button bSwitch;
		private Dotnetrix.Controls.TabControl tabC;
		private System.Windows.Forms.TabPage tabPage1;
		private System.Windows.Forms.Button button3;
		private System.Windows.Forms.TabPage tabPage2;
		private System.Windows.Forms.Button button5;
		private System.Windows.Forms.Button BtnMasuk;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.TextBox textPwd;
		private System.Windows.Forms.TextBox textNama;
		private System.Windows.Forms.Panel panel2;
		private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
		private System.Windows.Forms.Label labelGagal;
		private System.Windows.Forms.Timer timerSuspenderLUI;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.PictureBox pictureBox5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.PictureBox pictureBox4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.Label label4;
    }
}