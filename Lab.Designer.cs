
namespace Project3_Adilbek.Khiiasov58981
{
    partial class Lab
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
            this.button1 = new System.Windows.Forms.Button();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.btnDrawChosenXY = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.rbRight = new System.Windows.Forms.RadioButton();
            this.rbLeft = new System.Windows.Forms.RadioButton();
            this.label6 = new System.Windows.Forms.Label();
            this.btnAddNewFigure = new System.Windows.Forms.Button();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.nudSlopeAngle = new System.Windows.Forms.NumericUpDown();
            this.nudPolygonDegree = new System.Windows.Forms.NumericUpDown();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.tbFigureRadius = new System.Windows.Forms.TrackBar();
            this.tbFigureHeight = new System.Windows.Forms.TrackBar();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.cbFigureType = new System.Windows.Forms.ComboBox();
            this.nudNrOfFigureDelete = new System.Windows.Forms.NumericUpDown();
            this.btnDeleteChosenFigure = new System.Windows.Forms.Button();
            this.btnDeleteLastFigure = new System.Windows.Forms.Button();
            this.btnDeleteFirst = new System.Windows.Forms.Button();
            this.pbRysownica = new System.Windows.Forms.PictureBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.rbPromien = new System.Windows.Forms.RadioButton();
            this.rbObetosc = new System.Windows.Forms.RadioButton();
            this.rbPole = new System.Windows.Forms.RadioButton();
            this.rbWysokosc = new System.Windows.Forms.RadioButton();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnNext = new System.Windows.Forms.Button();
            this.btnPrevious = new System.Windows.Forms.Button();
            this.nudNrOfFigureSlide = new System.Windows.Forms.NumericUpDown();
            this.btnSlideOFF = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.rbManual = new System.Windows.Forms.RadioButton();
            this.rbAuto = new System.Windows.Forms.RadioButton();
            this.btnSlideON = new System.Windows.Forms.Button();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.rysownicaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.groupBox6 = new System.Windows.Forms.GroupBox();
            this.cbLineStyle = new System.Windows.Forms.ComboBox();
            this.label8 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnLineColor = new System.Windows.Forms.Button();
            this.tbTurnSpeed = new System.Windows.Forms.TrackBar();
            this.label13 = new System.Windows.Forms.Label();
            this.tbGruboscLinii = new System.Windows.Forms.TrackBar();
            this.label9 = new System.Windows.Forms.Label();
            this.rbRight2 = new System.Windows.Forms.RadioButton();
            this.rbLeft2 = new System.Windows.Forms.RadioButton();
            this.label12 = new System.Windows.Forms.Label();
            this.turnTimer = new System.Windows.Forms.Timer(this.components);
            this.colorDialog1 = new System.Windows.Forms.ColorDialog();
            this.slideTimer = new System.Windows.Forms.Timer(this.components);
            this.groupBox4.SuspendLayout();
            this.groupBox5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudSlopeAngle)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudPolygonDegree)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbFigureRadius)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbFigureHeight)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudNrOfFigureDelete)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbRysownica)).BeginInit();
            this.groupBox3.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudNrOfFigureSlide)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.groupBox6.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tbTurnSpeed)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbGruboscLinii)).BeginInit();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.button1.Location = new System.Drawing.Point(956, 30);
            this.button1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(158, 25);
            this.button1.TabIndex = 1;
            this.button1.Text = "powrót";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // groupBox4
            // 
            this.groupBox4.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.groupBox4.Controls.Add(this.btnDrawChosenXY);
            this.groupBox4.Controls.Add(this.label7);
            this.groupBox4.Controls.Add(this.rbRight);
            this.groupBox4.Controls.Add(this.rbLeft);
            this.groupBox4.Controls.Add(this.label6);
            this.groupBox4.Controls.Add(this.btnAddNewFigure);
            this.groupBox4.Controls.Add(this.groupBox5);
            this.groupBox4.Controls.Add(this.label1);
            this.groupBox4.Controls.Add(this.cbFigureType);
            this.groupBox4.Font = new System.Drawing.Font("Microsoft Sans Serif", 7F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.groupBox4.Location = new System.Drawing.Point(4, 102);
            this.groupBox4.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox4.Size = new System.Drawing.Size(162, 470);
            this.groupBox4.TabIndex = 14;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Wykreslenie nowej bryly";
            // 
            // btnDrawChosenXY
            // 
            this.btnDrawChosenXY.Location = new System.Drawing.Point(4, 369);
            this.btnDrawChosenXY.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnDrawChosenXY.Name = "btnDrawChosenXY";
            this.btnDrawChosenXY.Size = new System.Drawing.Size(151, 53);
            this.btnDrawChosenXY.TabIndex = 11;
            this.btnDrawChosenXY.Text = "Wykreśl bryłę o wybranych współrzędnych\r\n";
            this.btnDrawChosenXY.UseVisualStyleBackColor = true;
            this.btnDrawChosenXY.Click += new System.EventHandler(this.btnDrawChosenXY_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(6, 424);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(144, 45);
            this.label7.TabIndex = 10;
            this.label7.Text = "Aby wybrać położenie dla\r\n figury, kliknij na pole\r\n rysowania\r\n";
            // 
            // rbRight
            // 
            this.rbRight.AutoSize = true;
            this.rbRight.Location = new System.Drawing.Point(77, 300);
            this.rbRight.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.rbRight.Name = "rbRight";
            this.rbRight.Size = new System.Drawing.Size(76, 19);
            this.rbRight.TabIndex = 9;
            this.rbRight.TabStop = true;
            this.rbRight.Text = "W prawo";
            this.rbRight.UseVisualStyleBackColor = true;
            // 
            // rbLeft
            // 
            this.rbLeft.AutoSize = true;
            this.rbLeft.Location = new System.Drawing.Point(3, 299);
            this.rbLeft.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.rbLeft.Name = "rbLeft";
            this.rbLeft.Size = new System.Drawing.Size(68, 19);
            this.rbLeft.TabIndex = 8;
            this.rbLeft.TabStop = true;
            this.rbLeft.Text = "W lewo";
            this.rbLeft.UseVisualStyleBackColor = true;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(0, 282);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(114, 15);
            this.label6.TabIndex = 7;
            this.label6.Text = "Kirunek obrotu bryły";
            // 
            // btnAddNewFigure
            // 
            this.btnAddNewFigure.Location = new System.Drawing.Point(5, 322);
            this.btnAddNewFigure.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnAddNewFigure.Name = "btnAddNewFigure";
            this.btnAddNewFigure.Size = new System.Drawing.Size(151, 42);
            this.btnAddNewFigure.TabIndex = 6;
            this.btnAddNewFigure.Text = "Wykreśl bryłę o losowych współrzędnych\r\n";
            this.btnAddNewFigure.UseVisualStyleBackColor = true;
            this.btnAddNewFigure.Click += new System.EventHandler(this.btnAddNewFigure_Click);
            // 
            // groupBox5
            // 
            this.groupBox5.BackColor = System.Drawing.Color.LightSkyBlue;
            this.groupBox5.Controls.Add(this.nudSlopeAngle);
            this.groupBox5.Controls.Add(this.nudPolygonDegree);
            this.groupBox5.Controls.Add(this.label5);
            this.groupBox5.Controls.Add(this.label4);
            this.groupBox5.Controls.Add(this.tbFigureRadius);
            this.groupBox5.Controls.Add(this.tbFigureHeight);
            this.groupBox5.Controls.Add(this.label3);
            this.groupBox5.Controls.Add(this.label2);
            this.groupBox5.Location = new System.Drawing.Point(0, 75);
            this.groupBox5.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox5.Size = new System.Drawing.Size(162, 189);
            this.groupBox5.TabIndex = 5;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "Cechy nowej bryly";
            // 
            // nudSlopeAngle
            // 
            this.nudSlopeAngle.Location = new System.Drawing.Point(9, 154);
            this.nudSlopeAngle.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.nudSlopeAngle.Maximum = new decimal(new int[] {
            179,
            0,
            0,
            0});
            this.nudSlopeAngle.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nudSlopeAngle.Name = "nudSlopeAngle";
            this.nudSlopeAngle.Size = new System.Drawing.Size(138, 21);
            this.nudSlopeAngle.TabIndex = 7;
            this.nudSlopeAngle.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.nudSlopeAngle.Value = new decimal(new int[] {
            90,
            0,
            0,
            0});
            // 
            // nudPolygonDegree
            // 
            this.nudPolygonDegree.Location = new System.Drawing.Point(9, 118);
            this.nudPolygonDegree.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.nudPolygonDegree.Minimum = new decimal(new int[] {
            3,
            0,
            0,
            0});
            this.nudPolygonDegree.Name = "nudPolygonDegree";
            this.nudPolygonDegree.Size = new System.Drawing.Size(138, 21);
            this.nudPolygonDegree.TabIndex = 6;
            this.nudPolygonDegree.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.nudPolygonDegree.Value = new decimal(new int[] {
            3,
            0,
            0,
            0});
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(3, 138);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(88, 15);
            this.label5.TabIndex = 5;
            this.label5.Text = "Kąt nachilenia:\r\n";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(3, 101);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(107, 15);
            this.label4.TabIndex = 4;
            this.label4.Text = "Stopień wielokąta:";
            // 
            // tbFigureRadius
            // 
            this.tbFigureRadius.AutoSize = false;
            this.tbFigureRadius.Location = new System.Drawing.Point(6, 81);
            this.tbFigureRadius.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tbFigureRadius.Maximum = 300;
            this.tbFigureRadius.Minimum = 50;
            this.tbFigureRadius.Name = "tbFigureRadius";
            this.tbFigureRadius.Size = new System.Drawing.Size(150, 18);
            this.tbFigureRadius.TabIndex = 3;
            this.tbFigureRadius.Value = 50;
            // 
            // tbFigureHeight
            // 
            this.tbFigureHeight.AutoSize = false;
            this.tbFigureHeight.Location = new System.Drawing.Point(5, 34);
            this.tbFigureHeight.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tbFigureHeight.Maximum = 300;
            this.tbFigureHeight.Minimum = 50;
            this.tbFigureHeight.Name = "tbFigureHeight";
            this.tbFigureHeight.Size = new System.Drawing.Size(150, 18);
            this.tbFigureHeight.TabIndex = 2;
            this.tbFigureHeight.Value = 50;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(3, 55);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(84, 15);
            this.label3.TabIndex = 1;
            this.label3.Text = "Promień bryły:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(5, 18);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(91, 15);
            this.label2.TabIndex = 0;
            this.label2.Text = "Wysokość bryły:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(5, 21);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(120, 17);
            this.label1.TabIndex = 4;
            this.label1.Text = "Wybierz typ bryły:";
            // 
            // cbFigureType
            // 
            this.cbFigureType.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.cbFigureType.FormattingEnabled = true;
            this.cbFigureType.Items.AddRange(new object[] {
            "Walec",
            "Stożek",
            "Stożek pochiliony",
            "Kula",
            "Graniastoslup",
            "Ostoslup",
            "Dwa ostroslupy o wspolnej podstawie",
            "Walec pochiliony",
            "Ostroslup sciety"});
            this.cbFigureType.Location = new System.Drawing.Point(5, 37);
            this.cbFigureType.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cbFigureType.Name = "cbFigureType";
            this.cbFigureType.Size = new System.Drawing.Size(151, 24);
            this.cbFigureType.TabIndex = 3;
            // 
            // nudNrOfFigureDelete
            // 
            this.nudNrOfFigureDelete.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.nudNrOfFigureDelete.Location = new System.Drawing.Point(610, 32);
            this.nudNrOfFigureDelete.Margin = new System.Windows.Forms.Padding(6, 2, 6, 2);
            this.nudNrOfFigureDelete.Name = "nudNrOfFigureDelete";
            this.nudNrOfFigureDelete.ReadOnly = true;
            this.nudNrOfFigureDelete.Size = new System.Drawing.Size(45, 22);
            this.nudNrOfFigureDelete.TabIndex = 12;
            this.nudNrOfFigureDelete.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.nudNrOfFigureDelete.ValueChanged += new System.EventHandler(this.nudNrOfFigureDelete_ValueChanged);
            // 
            // btnDeleteChosenFigure
            // 
            this.btnDeleteChosenFigure.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btnDeleteChosenFigure.Location = new System.Drawing.Point(446, 30);
            this.btnDeleteChosenFigure.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnDeleteChosenFigure.Name = "btnDeleteChosenFigure";
            this.btnDeleteChosenFigure.Size = new System.Drawing.Size(164, 25);
            this.btnDeleteChosenFigure.TabIndex = 13;
            this.btnDeleteChosenFigure.Text = "Usun wybraną brylę";
            this.btnDeleteChosenFigure.UseVisualStyleBackColor = true;
            this.btnDeleteChosenFigure.Click += new System.EventHandler(this.btnDeleteChosenFigure_Click);
            // 
            // btnDeleteLastFigure
            // 
            this.btnDeleteLastFigure.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btnDeleteLastFigure.Location = new System.Drawing.Point(788, 30);
            this.btnDeleteLastFigure.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnDeleteLastFigure.Name = "btnDeleteLastFigure";
            this.btnDeleteLastFigure.Size = new System.Drawing.Size(164, 25);
            this.btnDeleteLastFigure.TabIndex = 11;
            this.btnDeleteLastFigure.Text = "Usun ostatnią brylę";
            this.btnDeleteLastFigure.UseVisualStyleBackColor = true;
            this.btnDeleteLastFigure.Click += new System.EventHandler(this.btnDeleteLastFigure_Click);
            // 
            // btnDeleteFirst
            // 
            this.btnDeleteFirst.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btnDeleteFirst.Location = new System.Drawing.Point(172, 30);
            this.btnDeleteFirst.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnDeleteFirst.Name = "btnDeleteFirst";
            this.btnDeleteFirst.Size = new System.Drawing.Size(164, 25);
            this.btnDeleteFirst.TabIndex = 10;
            this.btnDeleteFirst.Text = "Usun pierwszą brylę";
            this.btnDeleteFirst.UseVisualStyleBackColor = true;
            this.btnDeleteFirst.Click += new System.EventHandler(this.btnDeleteFirst_Click);
            // 
            // pbRysownica
            // 
            this.pbRysownica.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pbRysownica.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pbRysownica.Location = new System.Drawing.Point(172, 61);
            this.pbRysownica.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pbRysownica.Name = "pbRysownica";
            this.pbRysownica.Size = new System.Drawing.Size(780, 472);
            this.pbRysownica.TabIndex = 9;
            this.pbRysownica.TabStop = false;
            this.pbRysownica.Click += new System.EventHandler(this.pbRysownica_Click);
            this.pbRysownica.MouseClick += new System.Windows.Forms.MouseEventHandler(this.pbRysownica_MouseClick);
            // 
            // groupBox3
            // 
            this.groupBox3.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.groupBox3.Controls.Add(this.rbPromien);
            this.groupBox3.Controls.Add(this.rbObetosc);
            this.groupBox3.Controls.Add(this.rbPole);
            this.groupBox3.Controls.Add(this.rbWysokosc);
            this.groupBox3.Font = new System.Drawing.Font("Microsoft Sans Serif", 7F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.groupBox3.Location = new System.Drawing.Point(955, 384);
            this.groupBox3.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox3.Size = new System.Drawing.Size(160, 140);
            this.groupBox3.TabIndex = 16;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Kriteria pokazu bryl";
            // 
            // rbPromien
            // 
            this.rbPromien.AutoSize = true;
            this.rbPromien.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.rbPromien.Location = new System.Drawing.Point(6, 45);
            this.rbPromien.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.rbPromien.Name = "rbPromien";
            this.rbPromien.Size = new System.Drawing.Size(81, 21);
            this.rbPromien.TabIndex = 3;
            this.rbPromien.TabStop = true;
            this.rbPromien.Text = "Promień";
            this.rbPromien.UseVisualStyleBackColor = true;
            this.rbPromien.CheckedChanged += new System.EventHandler(this.rbPromien_CheckedChanged);
            // 
            // rbObetosc
            // 
            this.rbObetosc.AutoSize = true;
            this.rbObetosc.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.rbObetosc.Location = new System.Drawing.Point(6, 69);
            this.rbObetosc.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.rbObetosc.Name = "rbObetosc";
            this.rbObetosc.Size = new System.Drawing.Size(82, 21);
            this.rbObetosc.TabIndex = 2;
            this.rbObetosc.TabStop = true;
            this.rbObetosc.Text = "Obętość";
            this.rbObetosc.UseVisualStyleBackColor = true;
            this.rbObetosc.CheckedChanged += new System.EventHandler(this.rbObetosc_CheckedChanged);
            // 
            // rbPole
            // 
            this.rbPole.AutoSize = true;
            this.rbPole.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.rbPole.Location = new System.Drawing.Point(6, 93);
            this.rbPole.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.rbPole.Name = "rbPole";
            this.rbPole.Size = new System.Drawing.Size(135, 21);
            this.rbPole.TabIndex = 1;
            this.rbPole.TabStop = true;
            this.rbPole.Text = "Pole powierzchni";
            this.rbPole.UseVisualStyleBackColor = true;
            this.rbPole.CheckedChanged += new System.EventHandler(this.rbPole_CheckedChanged);
            // 
            // rbWysokosc
            // 
            this.rbWysokosc.AutoSize = true;
            this.rbWysokosc.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.rbWysokosc.Location = new System.Drawing.Point(6, 21);
            this.rbWysokosc.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.rbWysokosc.Name = "rbWysokosc";
            this.rbWysokosc.Size = new System.Drawing.Size(93, 21);
            this.rbWysokosc.TabIndex = 0;
            this.rbWysokosc.TabStop = true;
            this.rbWysokosc.Text = "Wysokość\r\n";
            this.rbWysokosc.UseVisualStyleBackColor = true;
            this.rbWysokosc.CheckedChanged += new System.EventHandler(this.rbWysokosc_CheckedChanged);
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox1.Controls.Add(this.btnNext);
            this.groupBox1.Controls.Add(this.btnPrevious);
            this.groupBox1.Controls.Add(this.nudNrOfFigureSlide);
            this.groupBox1.Controls.Add(this.btnSlideOFF);
            this.groupBox1.Controls.Add(this.groupBox2);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 7F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.groupBox1.Location = new System.Drawing.Point(955, 61);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox1.Size = new System.Drawing.Size(160, 209);
            this.groupBox1.TabIndex = 15;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Slajder";
            // 
            // btnNext
            // 
            this.btnNext.Location = new System.Drawing.Point(132, 140);
            this.btnNext.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnNext.Name = "btnNext";
            this.btnNext.Size = new System.Drawing.Size(20, 21);
            this.btnNext.TabIndex = 5;
            this.btnNext.Text = ">";
            this.btnNext.UseVisualStyleBackColor = true;
            this.btnNext.Click += new System.EventHandler(this.btnNext_Click);
            // 
            // btnPrevious
            // 
            this.btnPrevious.Location = new System.Drawing.Point(6, 140);
            this.btnPrevious.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnPrevious.Name = "btnPrevious";
            this.btnPrevious.Size = new System.Drawing.Size(20, 22);
            this.btnPrevious.TabIndex = 4;
            this.btnPrevious.Text = "<";
            this.btnPrevious.UseVisualStyleBackColor = true;
            this.btnPrevious.Click += new System.EventHandler(this.btnPrevious_Click);
            // 
            // nudNrOfFigureSlide
            // 
            this.nudNrOfFigureSlide.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.nudNrOfFigureSlide.Location = new System.Drawing.Point(35, 138);
            this.nudNrOfFigureSlide.Margin = new System.Windows.Forms.Padding(6, 2, 6, 2);
            this.nudNrOfFigureSlide.Name = "nudNrOfFigureSlide";
            this.nudNrOfFigureSlide.ReadOnly = true;
            this.nudNrOfFigureSlide.Size = new System.Drawing.Size(106, 23);
            this.nudNrOfFigureSlide.TabIndex = 3;
            this.nudNrOfFigureSlide.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.nudNrOfFigureSlide.ValueChanged += new System.EventHandler(this.nudNrOfFigureSlide_ValueChanged);
            // 
            // btnSlideOFF
            // 
            this.btnSlideOFF.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnSlideOFF.Location = new System.Drawing.Point(6, 166);
            this.btnSlideOFF.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnSlideOFF.Name = "btnSlideOFF";
            this.btnSlideOFF.Size = new System.Drawing.Size(145, 27);
            this.btnSlideOFF.TabIndex = 2;
            this.btnSlideOFF.Text = "Wylącz";
            this.btnSlideOFF.UseVisualStyleBackColor = true;
            this.btnSlideOFF.Click += new System.EventHandler(this.btnSlideOFF_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.rbManual);
            this.groupBox2.Controls.Add(this.rbAuto);
            this.groupBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.groupBox2.Location = new System.Drawing.Point(6, 21);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox2.Size = new System.Drawing.Size(145, 80);
            this.groupBox2.TabIndex = 0;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Tryb pokazu";
            // 
            // rbManual
            // 
            this.rbManual.AutoSize = true;
            this.rbManual.Location = new System.Drawing.Point(6, 46);
            this.rbManual.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.rbManual.Name = "rbManual";
            this.rbManual.Size = new System.Drawing.Size(90, 21);
            this.rbManual.TabIndex = 1;
            this.rbManual.TabStop = true;
            this.rbManual.Text = "Manualny";
            this.rbManual.UseVisualStyleBackColor = true;
            // 
            // rbAuto
            // 
            this.rbAuto.AutoSize = true;
            this.rbAuto.Location = new System.Drawing.Point(6, 21);
            this.rbAuto.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.rbAuto.Name = "rbAuto";
            this.rbAuto.Size = new System.Drawing.Size(117, 21);
            this.rbAuto.TabIndex = 0;
            this.rbAuto.TabStop = true;
            this.rbAuto.Text = "Automatyczny";
            this.rbAuto.UseVisualStyleBackColor = true;
            // 
            // btnSlideON
            // 
            this.btnSlideON.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnSlideON.Location = new System.Drawing.Point(961, 322);
            this.btnSlideON.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnSlideON.Name = "btnSlideON";
            this.btnSlideON.Size = new System.Drawing.Size(145, 28);
            this.btnSlideON.TabIndex = 1;
            this.btnSlideON.Text = "Wlącz";
            this.btnSlideON.UseVisualStyleBackColor = true;
            this.btnSlideON.Click += new System.EventHandler(this.btnSlideON_Click);
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.rysownicaToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Padding = new System.Windows.Forms.Padding(5, 2, 0, 2);
            this.menuStrip1.Size = new System.Drawing.Size(1118, 28);
            this.menuStrip1.TabIndex = 17;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // rysownicaToolStripMenuItem
            // 
            this.rysownicaToolStripMenuItem.Name = "rysownicaToolStripMenuItem";
            this.rysownicaToolStripMenuItem.Size = new System.Drawing.Size(92, 24);
            this.rysownicaToolStripMenuItem.Text = "Rysownica";
            // 
            // groupBox6
            // 
            this.groupBox6.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.groupBox6.Controls.Add(this.cbLineStyle);
            this.groupBox6.Controls.Add(this.label8);
            this.groupBox6.Controls.Add(this.panel1);
            this.groupBox6.Controls.Add(this.btnLineColor);
            this.groupBox6.Controls.Add(this.tbTurnSpeed);
            this.groupBox6.Controls.Add(this.label13);
            this.groupBox6.Location = new System.Drawing.Point(172, 537);
            this.groupBox6.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox6.Name = "groupBox6";
            this.groupBox6.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox6.Size = new System.Drawing.Size(423, 74);
            this.groupBox6.TabIndex = 18;
            this.groupBox6.TabStop = false;
            this.groupBox6.Text = "Zmiana atrybutów graficznych bryły";
            // 
            // cbLineStyle
            // 
            this.cbLineStyle.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.cbLineStyle.FormattingEnabled = true;
            this.cbLineStyle.Items.AddRange(new object[] {
            "Solid",
            "Dash",
            "DashDot",
            "Dot",
            "DashDotDot"});
            this.cbLineStyle.Location = new System.Drawing.Point(6, 38);
            this.cbLineStyle.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cbLineStyle.Name = "cbLineStyle";
            this.cbLineStyle.Size = new System.Drawing.Size(104, 24);
            this.cbLineStyle.TabIndex = 11;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(6, 17);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(51, 16);
            this.label8.TabIndex = 2;
            this.label8.Text = "Styl linii";
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Location = new System.Drawing.Point(100, 19);
            this.panel1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(107, 16);
            this.panel1.TabIndex = 1;
            // 
            // btnLineColor
            // 
            this.btnLineColor.Location = new System.Drawing.Point(151, 33);
            this.btnLineColor.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnLineColor.Name = "btnLineColor";
            this.btnLineColor.Size = new System.Drawing.Size(107, 29);
            this.btnLineColor.TabIndex = 0;
            this.btnLineColor.Text = "Kolor linii";
            this.btnLineColor.UseVisualStyleBackColor = true;
            this.btnLineColor.Click += new System.EventHandler(this.btnLineColor_Click);
            // 
            // tbTurnSpeed
            // 
            this.tbTurnSpeed.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.tbTurnSpeed.AutoSize = false;
            this.tbTurnSpeed.Location = new System.Drawing.Point(268, 41);
            this.tbTurnSpeed.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tbTurnSpeed.Maximum = 30;
            this.tbTurnSpeed.Name = "tbTurnSpeed";
            this.tbTurnSpeed.Size = new System.Drawing.Size(150, 21);
            this.tbTurnSpeed.TabIndex = 8;
            this.tbTurnSpeed.ValueChanged += new System.EventHandler(this.tbTurnSpeed_ValueChanged);
            // 
            // label13
            // 
            this.label13.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(265, 14);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(132, 16);
            this.label13.TabIndex = 19;
            this.label13.Text = "Szybkość obrotu bryl";
            // 
            // tbGruboscLinii
            // 
            this.tbGruboscLinii.AutoSize = false;
            this.tbGruboscLinii.Location = new System.Drawing.Point(817, 575);
            this.tbGruboscLinii.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tbGruboscLinii.Maximum = 30;
            this.tbGruboscLinii.Minimum = 3;
            this.tbGruboscLinii.Name = "tbGruboscLinii";
            this.tbGruboscLinii.Size = new System.Drawing.Size(124, 22);
            this.tbGruboscLinii.TabIndex = 8;
            this.tbGruboscLinii.Value = 30;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(828, 558);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(80, 16);
            this.label9.TabIndex = 12;
            this.label9.Text = "Grubość linii";
            // 
            // rbRight2
            // 
            this.rbRight2.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.rbRight2.AutoSize = true;
            this.rbRight2.Location = new System.Drawing.Point(686, 577);
            this.rbRight2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.rbRight2.Name = "rbRight2";
            this.rbRight2.Size = new System.Drawing.Size(81, 20);
            this.rbRight2.TabIndex = 13;
            this.rbRight2.TabStop = true;
            this.rbRight2.Text = "W prawo";
            this.rbRight2.UseVisualStyleBackColor = true;
            // 
            // rbLeft2
            // 
            this.rbLeft2.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.rbLeft2.AutoSize = true;
            this.rbLeft2.Location = new System.Drawing.Point(601, 577);
            this.rbLeft2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.rbLeft2.Name = "rbLeft2";
            this.rbLeft2.Size = new System.Drawing.Size(72, 20);
            this.rbLeft2.TabIndex = 12;
            this.rbLeft2.TabStop = true;
            this.rbLeft2.Text = "W lewo";
            this.rbLeft2.UseVisualStyleBackColor = true;
            // 
            // label12
            // 
            this.label12.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(602, 558);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(120, 16);
            this.label12.TabIndex = 11;
            this.label12.Text = "Kirunek obrotu brył\r\n";
            // 
            // turnTimer
            // 
            this.turnTimer.Enabled = true;
            this.turnTimer.Tick += new System.EventHandler(this.turnTimer_Tick);
            // 
            // slideTimer
            // 
            this.slideTimer.Interval = 1500;
            this.slideTimer.Tick += new System.EventHandler(this.slideTimer_Tick);
            // 
            // Lab
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1118, 612);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.tbGruboscLinii);
            this.Controls.Add(this.rbRight2);
            this.Controls.Add(this.rbLeft2);
            this.Controls.Add(this.btnSlideON);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.groupBox6);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.nudNrOfFigureDelete);
            this.Controls.Add(this.btnDeleteChosenFigure);
            this.Controls.Add(this.btnDeleteLastFigure);
            this.Controls.Add(this.btnDeleteFirst);
            this.Controls.Add(this.pbRysownica);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "Lab";
            this.Text = "Bryly ";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Lab_FormClosed);
            this.Load += new System.EventHandler(this.Lab_Load);
            this.Resize += new System.EventHandler(this.Lab_Resize);
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.groupBox5.ResumeLayout(false);
            this.groupBox5.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudSlopeAngle)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudPolygonDegree)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbFigureRadius)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbFigureHeight)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudNrOfFigureDelete)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbRysownica)).EndInit();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.nudNrOfFigureSlide)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.groupBox6.ResumeLayout(false);
            this.groupBox6.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tbTurnSpeed)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbGruboscLinii)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.Button btnAddNewFigure;
        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.NumericUpDown nudSlopeAngle;
        private System.Windows.Forms.NumericUpDown nudPolygonDegree;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TrackBar tbFigureRadius;
        private System.Windows.Forms.TrackBar tbFigureHeight;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cbFigureType;
        private System.Windows.Forms.NumericUpDown nudNrOfFigureDelete;
        private System.Windows.Forms.Button btnDeleteChosenFigure;
        private System.Windows.Forms.Button btnDeleteLastFigure;
        private System.Windows.Forms.Button btnDeleteFirst;
        private System.Windows.Forms.PictureBox pbRysownica;
        private System.Windows.Forms.RadioButton rbRight;
        private System.Windows.Forms.RadioButton rbLeft;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.RadioButton rbPromien;
        private System.Windows.Forms.RadioButton rbObetosc;
        private System.Windows.Forms.RadioButton rbPole;
        private System.Windows.Forms.RadioButton rbWysokosc;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnNext;
        private System.Windows.Forms.Button btnPrevious;
        private System.Windows.Forms.NumericUpDown nudNrOfFigureSlide;
        private System.Windows.Forms.Button btnSlideOFF;
        private System.Windows.Forms.Button btnSlideON;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.RadioButton rbManual;
        private System.Windows.Forms.RadioButton rbAuto;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem rysownicaToolStripMenuItem;
        private System.Windows.Forms.GroupBox groupBox6;
        private System.Windows.Forms.RadioButton rbRight2;
        private System.Windows.Forms.RadioButton rbLeft2;
        private System.Windows.Forms.TrackBar tbGruboscLinii;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.ComboBox cbLineStyle;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnLineColor;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.TrackBar tbTurnSpeed;
        private System.Windows.Forms.Timer turnTimer;
        private System.Windows.Forms.Button btnDrawChosenXY;
        private System.Windows.Forms.ColorDialog colorDialog1;
        private System.Windows.Forms.Timer slideTimer;
    }
}