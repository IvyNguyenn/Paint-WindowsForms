namespace Paint3
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.colorDialog1 = new System.Windows.Forms.ColorDialog();
            this.numericUpDown1 = new System.Windows.Forms.NumericUpDown();
            this.btnColorPen = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btnXoaHet = new System.Windows.Forms.Button();
            this.btnConTro = new System.Windows.Forms.Button();
            this.btnXoaHinhCuoi = new System.Windows.Forms.Button();
            this.btnBezier = new System.Windows.Forms.Button();
            this.btnFillSqua = new System.Windows.Forms.Button();
            this.btnHinhVuong = new System.Windows.Forms.Button();
            this.btnFillHinhTron = new System.Windows.Forms.Button();
            this.btnHinhTron = new System.Windows.Forms.Button();
            this.btnFillEllipse = new System.Windows.Forms.Button();
            this.btnElip = new System.Windows.Forms.Button();
            this.btnFillHinhChuNhat = new System.Windows.Forms.Button();
            this.btnHCN = new System.Windows.Forms.Button();
            this.btnSizeMove = new System.Windows.Forms.Button();
            this.btnDuongThang = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.lblcurpen = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.button24 = new System.Windows.Forms.Button();
            this.button29 = new System.Windows.Forms.Button();
            this.button8 = new System.Windows.Forms.Button();
            this.button23 = new System.Windows.Forms.Button();
            this.button17 = new System.Windows.Forms.Button();
            this.button28 = new System.Windows.Forms.Button();
            this.button25 = new System.Windows.Forms.Button();
            this.button22 = new System.Windows.Forms.Button();
            this.button21 = new System.Windows.Forms.Button();
            this.button27 = new System.Windows.Forms.Button();
            this.button26 = new System.Windows.Forms.Button();
            this.button12 = new System.Windows.Forms.Button();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.lblPosition = new System.Windows.Forms.Label();
            this.btnFillHinhVuong = new System.Windows.Forms.PictureBox();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).BeginInit();
            this.panel2.SuspendLayout();
            this.panel1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnFillHinhVuong)).BeginInit();
            this.SuspendLayout();
            // 
            // numericUpDown1
            // 
            this.numericUpDown1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.numericUpDown1.Location = new System.Drawing.Point(188, 3);
            this.numericUpDown1.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numericUpDown1.Name = "numericUpDown1";
            this.numericUpDown1.Size = new System.Drawing.Size(80, 38);
            this.numericUpDown1.TabIndex = 33;
            this.toolTip1.SetToolTip(this.numericUpDown1, "Size");
            this.numericUpDown1.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numericUpDown1.ValueChanged += new System.EventHandler(this.numericUpDown1_ValueChanged);
            // 
            // btnColorPen
            // 
            this.btnColorPen.BackColor = System.Drawing.Color.White;
            this.btnColorPen.Image = ((System.Drawing.Image)(resources.GetObject("btnColorPen.Image")));
            this.btnColorPen.Location = new System.Drawing.Point(188, 56);
            this.btnColorPen.Name = "btnColorPen";
            this.btnColorPen.Size = new System.Drawing.Size(67, 59);
            this.btnColorPen.TabIndex = 35;
            this.toolTip1.SetToolTip(this.btnColorPen, "Choose Color");
            this.btnColorPen.UseVisualStyleBackColor = false;
            this.btnColorPen.Click += new System.EventHandler(this.btnColorPen_Click);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.btnXoaHet);
            this.panel2.Controls.Add(this.btnConTro);
            this.panel2.Controls.Add(this.btnXoaHinhCuoi);
            this.panel2.Controls.Add(this.btnBezier);
            this.panel2.Controls.Add(this.btnFillSqua);
            this.panel2.Controls.Add(this.btnHinhVuong);
            this.panel2.Controls.Add(this.btnFillHinhTron);
            this.panel2.Controls.Add(this.btnHinhTron);
            this.panel2.Controls.Add(this.btnFillEllipse);
            this.panel2.Controls.Add(this.btnElip);
            this.panel2.Controls.Add(this.btnFillHinhChuNhat);
            this.panel2.Controls.Add(this.btnHCN);
            this.panel2.Controls.Add(this.btnSizeMove);
            this.panel2.Controls.Add(this.btnDuongThang);
            this.panel2.Controls.Add(this.panel1);
            this.panel2.Controls.Add(this.lblPosition);
            this.panel2.Location = new System.Drawing.Point(6, 12);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1906, 127);
            this.panel2.TabIndex = 5;
            // 
            // btnXoaHet
            // 
            this.btnXoaHet.BackColor = System.Drawing.Color.White;
            this.btnXoaHet.Image = ((System.Drawing.Image)(resources.GetObject("btnXoaHet.Image")));
            this.btnXoaHet.Location = new System.Drawing.Point(9, 3);
            this.btnXoaHet.Name = "btnXoaHet";
            this.btnXoaHet.Size = new System.Drawing.Size(104, 70);
            this.btnXoaHet.TabIndex = 72;
            this.toolTip1.SetToolTip(this.btnXoaHet, "Clear All");
            this.btnXoaHet.UseVisualStyleBackColor = false;
            this.btnXoaHet.Click += new System.EventHandler(this.btnXoaHet_Click);
            // 
            // btnConTro
            // 
            this.btnConTro.Location = new System.Drawing.Point(30, 12);
            this.btnConTro.Name = "btnConTro";
            this.btnConTro.Size = new System.Drawing.Size(64, 41);
            this.btnConTro.TabIndex = 8;
            this.btnConTro.Text = "mouse";
            this.btnConTro.UseVisualStyleBackColor = true;
            // 
            // btnXoaHinhCuoi
            // 
            this.btnXoaHinhCuoi.BackColor = System.Drawing.Color.White;
            this.btnXoaHinhCuoi.Image = ((System.Drawing.Image)(resources.GetObject("btnXoaHinhCuoi.Image")));
            this.btnXoaHinhCuoi.Location = new System.Drawing.Point(119, 3);
            this.btnXoaHinhCuoi.Name = "btnXoaHinhCuoi";
            this.btnXoaHinhCuoi.Size = new System.Drawing.Size(104, 70);
            this.btnXoaHinhCuoi.TabIndex = 70;
            this.toolTip1.SetToolTip(this.btnXoaHinhCuoi, "Clear Last");
            this.btnXoaHinhCuoi.UseVisualStyleBackColor = false;
            this.btnXoaHinhCuoi.Click += new System.EventHandler(this.btnXoaHinhCuoi_Click);
            // 
            // btnBezier
            // 
            this.btnBezier.BackColor = System.Drawing.Color.White;
            this.btnBezier.Image = ((System.Drawing.Image)(resources.GetObject("btnBezier.Image")));
            this.btnBezier.Location = new System.Drawing.Point(1089, 3);
            this.btnBezier.Name = "btnBezier";
            this.btnBezier.Size = new System.Drawing.Size(80, 70);
            this.btnBezier.TabIndex = 69;
            this.btnBezier.Tag = "10";
            this.toolTip1.SetToolTip(this.btnBezier, "Bezier");
            this.btnBezier.UseVisualStyleBackColor = false;
            this.btnBezier.Click += new System.EventHandler(this.btnCircle_Click);
            // 
            // btnFillSqua
            // 
            this.btnFillSqua.BackColor = System.Drawing.Color.White;
            this.btnFillSqua.Image = ((System.Drawing.Image)(resources.GetObject("btnFillSqua.Image")));
            this.btnFillSqua.Location = new System.Drawing.Point(1003, 3);
            this.btnFillSqua.Name = "btnFillSqua";
            this.btnFillSqua.Size = new System.Drawing.Size(80, 70);
            this.btnFillSqua.TabIndex = 68;
            this.btnFillSqua.Tag = "9";
            this.toolTip1.SetToolTip(this.btnFillSqua, "Fill Square");
            this.btnFillSqua.UseVisualStyleBackColor = false;
            this.btnFillSqua.Click += new System.EventHandler(this.btnCircle_Click);
            // 
            // btnHinhVuong
            // 
            this.btnHinhVuong.BackColor = System.Drawing.Color.White;
            this.btnHinhVuong.Image = ((System.Drawing.Image)(resources.GetObject("btnHinhVuong.Image")));
            this.btnHinhVuong.Location = new System.Drawing.Point(659, 3);
            this.btnHinhVuong.Name = "btnHinhVuong";
            this.btnHinhVuong.Size = new System.Drawing.Size(80, 70);
            this.btnHinhVuong.TabIndex = 67;
            this.btnHinhVuong.Tag = "5";
            this.toolTip1.SetToolTip(this.btnHinhVuong, "Square");
            this.btnHinhVuong.UseVisualStyleBackColor = false;
            this.btnHinhVuong.Click += new System.EventHandler(this.btnCircle_Click);
            // 
            // btnFillHinhTron
            // 
            this.btnFillHinhTron.BackColor = System.Drawing.Color.White;
            this.btnFillHinhTron.Image = ((System.Drawing.Image)(resources.GetObject("btnFillHinhTron.Image")));
            this.btnFillHinhTron.Location = new System.Drawing.Point(917, 3);
            this.btnFillHinhTron.Name = "btnFillHinhTron";
            this.btnFillHinhTron.Size = new System.Drawing.Size(80, 70);
            this.btnFillHinhTron.TabIndex = 66;
            this.btnFillHinhTron.Tag = "8";
            this.toolTip1.SetToolTip(this.btnFillHinhTron, "Fill Circle");
            this.btnFillHinhTron.UseVisualStyleBackColor = false;
            this.btnFillHinhTron.Click += new System.EventHandler(this.btnCircle_Click);
            // 
            // btnHinhTron
            // 
            this.btnHinhTron.BackColor = System.Drawing.Color.White;
            this.btnHinhTron.Image = ((System.Drawing.Image)(resources.GetObject("btnHinhTron.Image")));
            this.btnHinhTron.Location = new System.Drawing.Point(573, 3);
            this.btnHinhTron.Name = "btnHinhTron";
            this.btnHinhTron.Size = new System.Drawing.Size(80, 70);
            this.btnHinhTron.TabIndex = 65;
            this.btnHinhTron.Tag = "4";
            this.toolTip1.SetToolTip(this.btnHinhTron, "Circle");
            this.btnHinhTron.UseVisualStyleBackColor = false;
            this.btnHinhTron.Click += new System.EventHandler(this.btnCircle_Click);
            // 
            // btnFillEllipse
            // 
            this.btnFillEllipse.BackColor = System.Drawing.Color.White;
            this.btnFillEllipse.Image = ((System.Drawing.Image)(resources.GetObject("btnFillEllipse.Image")));
            this.btnFillEllipse.Location = new System.Drawing.Point(745, 3);
            this.btnFillEllipse.Name = "btnFillEllipse";
            this.btnFillEllipse.Size = new System.Drawing.Size(80, 70);
            this.btnFillEllipse.TabIndex = 64;
            this.btnFillEllipse.Tag = "6";
            this.toolTip1.SetToolTip(this.btnFillEllipse, "Fill Ellipse");
            this.btnFillEllipse.UseVisualStyleBackColor = false;
            this.btnFillEllipse.Click += new System.EventHandler(this.btnCircle_Click);
            // 
            // btnElip
            // 
            this.btnElip.BackColor = System.Drawing.Color.White;
            this.btnElip.Image = ((System.Drawing.Image)(resources.GetObject("btnElip.Image")));
            this.btnElip.Location = new System.Drawing.Point(487, 3);
            this.btnElip.Name = "btnElip";
            this.btnElip.Size = new System.Drawing.Size(80, 70);
            this.btnElip.TabIndex = 63;
            this.btnElip.Tag = "1";
            this.toolTip1.SetToolTip(this.btnElip, "Ellipse");
            this.btnElip.UseVisualStyleBackColor = false;
            this.btnElip.Click += new System.EventHandler(this.btnCircle_Click);
            // 
            // btnFillHinhChuNhat
            // 
            this.btnFillHinhChuNhat.BackColor = System.Drawing.Color.White;
            this.btnFillHinhChuNhat.Image = ((System.Drawing.Image)(resources.GetObject("btnFillHinhChuNhat.Image")));
            this.btnFillHinhChuNhat.Location = new System.Drawing.Point(831, 3);
            this.btnFillHinhChuNhat.Name = "btnFillHinhChuNhat";
            this.btnFillHinhChuNhat.Size = new System.Drawing.Size(80, 70);
            this.btnFillHinhChuNhat.TabIndex = 62;
            this.btnFillHinhChuNhat.Tag = "7";
            this.toolTip1.SetToolTip(this.btnFillHinhChuNhat, "Fill Rectangle");
            this.btnFillHinhChuNhat.UseVisualStyleBackColor = false;
            this.btnFillHinhChuNhat.Click += new System.EventHandler(this.btnCircle_Click);
            // 
            // btnHCN
            // 
            this.btnHCN.BackColor = System.Drawing.Color.White;
            this.btnHCN.Image = ((System.Drawing.Image)(resources.GetObject("btnHCN.Image")));
            this.btnHCN.Location = new System.Drawing.Point(401, 3);
            this.btnHCN.Name = "btnHCN";
            this.btnHCN.Size = new System.Drawing.Size(80, 70);
            this.btnHCN.TabIndex = 61;
            this.btnHCN.Tag = "2";
            this.toolTip1.SetToolTip(this.btnHCN, "Rectangle");
            this.btnHCN.UseVisualStyleBackColor = false;
            this.btnHCN.Click += new System.EventHandler(this.btnCircle_Click);
            // 
            // btnSizeMove
            // 
            this.btnSizeMove.BackColor = System.Drawing.Color.White;
            this.btnSizeMove.Image = ((System.Drawing.Image)(resources.GetObject("btnSizeMove.Image")));
            this.btnSizeMove.Location = new System.Drawing.Point(229, 3);
            this.btnSizeMove.Name = "btnSizeMove";
            this.btnSizeMove.Size = new System.Drawing.Size(80, 70);
            this.btnSizeMove.TabIndex = 60;
            this.btnSizeMove.Tag = "-1";
            this.toolTip1.SetToolTip(this.btnSizeMove, "Move");
            this.btnSizeMove.UseVisualStyleBackColor = false;
            this.btnSizeMove.Click += new System.EventHandler(this.btnMove_Click);
            // 
            // btnDuongThang
            // 
            this.btnDuongThang.BackColor = System.Drawing.Color.White;
            this.btnDuongThang.Image = ((System.Drawing.Image)(resources.GetObject("btnDuongThang.Image")));
            this.btnDuongThang.Location = new System.Drawing.Point(315, 3);
            this.btnDuongThang.Name = "btnDuongThang";
            this.btnDuongThang.Size = new System.Drawing.Size(80, 70);
            this.btnDuongThang.TabIndex = 59;
            this.btnDuongThang.Tag = "3";
            this.toolTip1.SetToolTip(this.btnDuongThang, "Line");
            this.btnDuongThang.UseVisualStyleBackColor = false;
            this.btnDuongThang.Click += new System.EventHandler(this.btnCircle_Click);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.lblcurpen);
            this.panel1.Controls.Add(this.groupBox1);
            this.panel1.Controls.Add(this.comboBox1);
            this.panel1.Controls.Add(this.numericUpDown1);
            this.panel1.Controls.Add(this.btnColorPen);
            this.panel1.Location = new System.Drawing.Point(1175, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(357, 124);
            this.panel1.TabIndex = 50;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(274, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(60, 29);
            this.label1.TabIndex = 54;
            this.label1.Text = "Size";
            // 
            // lblcurpen
            // 
            this.lblcurpen.BackColor = System.Drawing.Color.Black;
            this.lblcurpen.Location = new System.Drawing.Point(261, 58);
            this.lblcurpen.Name = "lblcurpen";
            this.lblcurpen.Size = new System.Drawing.Size(67, 57);
            this.lblcurpen.TabIndex = 53;
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.SystemColors.Control;
            this.groupBox1.Controls.Add(this.button24);
            this.groupBox1.Controls.Add(this.button29);
            this.groupBox1.Controls.Add(this.button8);
            this.groupBox1.Controls.Add(this.button23);
            this.groupBox1.Controls.Add(this.button17);
            this.groupBox1.Controls.Add(this.button28);
            this.groupBox1.Controls.Add(this.button25);
            this.groupBox1.Controls.Add(this.button22);
            this.groupBox1.Controls.Add(this.button21);
            this.groupBox1.Controls.Add(this.button27);
            this.groupBox1.Controls.Add(this.button26);
            this.groupBox1.Controls.Add(this.button12);
            this.groupBox1.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.groupBox1.Location = new System.Drawing.Point(3, 46);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.groupBox1.Size = new System.Drawing.Size(179, 75);
            this.groupBox1.TabIndex = 51;
            this.groupBox1.TabStop = false;
            this.toolTip1.SetToolTip(this.groupBox1, "Color Board");
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // button24
            // 
            this.button24.BackColor = System.Drawing.Color.Blue;
            this.button24.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button24.FlatAppearance.BorderColor = System.Drawing.Color.PaleTurquoise;
            this.button24.FlatAppearance.BorderSize = 5;
            this.button24.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.button24.Location = new System.Drawing.Point(121, 10);
            this.button24.Name = "button24";
            this.button24.Padding = new System.Windows.Forms.Padding(1);
            this.button24.Size = new System.Drawing.Size(30, 30);
            this.button24.TabIndex = 7;
            this.button24.UseVisualStyleBackColor = false;
            this.button24.Click += new System.EventHandler(this.buttonColor_Click);
            // 
            // button29
            // 
            this.button29.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.button29.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button29.FlatAppearance.BorderColor = System.Drawing.Color.PaleTurquoise;
            this.button29.FlatAppearance.BorderSize = 5;
            this.button29.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.button29.Location = new System.Drawing.Point(149, 39);
            this.button29.Name = "button29";
            this.button29.Size = new System.Drawing.Size(30, 30);
            this.button29.TabIndex = 7;
            this.button29.UseVisualStyleBackColor = false;
            this.button29.Click += new System.EventHandler(this.buttonColor_Click);
            // 
            // button8
            // 
            this.button8.BackColor = System.Drawing.Color.Red;
            this.button8.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button8.FlatAppearance.BorderColor = System.Drawing.Color.PaleTurquoise;
            this.button8.FlatAppearance.BorderSize = 5;
            this.button8.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.button8.Location = new System.Drawing.Point(64, 10);
            this.button8.Name = "button8";
            this.button8.Size = new System.Drawing.Size(30, 30);
            this.button8.TabIndex = 7;
            this.button8.UseVisualStyleBackColor = false;
            this.button8.Click += new System.EventHandler(this.buttonColor_Click);
            // 
            // button23
            // 
            this.button23.BackColor = System.Drawing.Color.Yellow;
            this.button23.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button23.FlatAppearance.BorderColor = System.Drawing.Color.PaleTurquoise;
            this.button23.FlatAppearance.BorderSize = 5;
            this.button23.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.button23.Location = new System.Drawing.Point(92, 39);
            this.button23.Name = "button23";
            this.button23.Size = new System.Drawing.Size(30, 30);
            this.button23.TabIndex = 7;
            this.button23.UseVisualStyleBackColor = false;
            this.button23.Click += new System.EventHandler(this.buttonColor_Click);
            // 
            // button17
            // 
            this.button17.BackColor = System.Drawing.Color.White;
            this.button17.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button17.FlatAppearance.BorderColor = System.Drawing.Color.PaleTurquoise;
            this.button17.FlatAppearance.BorderSize = 5;
            this.button17.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.button17.Location = new System.Drawing.Point(6, 39);
            this.button17.Name = "button17";
            this.button17.Size = new System.Drawing.Size(30, 30);
            this.button17.TabIndex = 7;
            this.button17.UseVisualStyleBackColor = false;
            this.button17.Click += new System.EventHandler(this.buttonColor_Click);
            // 
            // button28
            // 
            this.button28.BackColor = System.Drawing.Color.Purple;
            this.button28.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button28.FlatAppearance.BorderColor = System.Drawing.Color.PaleTurquoise;
            this.button28.FlatAppearance.BorderSize = 5;
            this.button28.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.button28.Location = new System.Drawing.Point(35, 10);
            this.button28.Name = "button28";
            this.button28.Size = new System.Drawing.Size(30, 30);
            this.button28.TabIndex = 7;
            this.button28.UseVisualStyleBackColor = false;
            this.button28.Click += new System.EventHandler(this.buttonColor_Click);
            // 
            // button25
            // 
            this.button25.BackColor = System.Drawing.Color.Black;
            this.button25.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button25.FlatAppearance.BorderColor = System.Drawing.Color.PaleTurquoise;
            this.button25.FlatAppearance.BorderSize = 5;
            this.button25.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.button25.Location = new System.Drawing.Point(6, 10);
            this.button25.Name = "button25";
            this.button25.Size = new System.Drawing.Size(30, 30);
            this.button25.TabIndex = 7;
            this.button25.UseVisualStyleBackColor = false;
            this.button25.Click += new System.EventHandler(this.buttonColor_Click);
            // 
            // button22
            // 
            this.button22.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.button22.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button22.FlatAppearance.BorderColor = System.Drawing.Color.PaleTurquoise;
            this.button22.FlatAppearance.BorderSize = 5;
            this.button22.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.button22.Location = new System.Drawing.Point(35, 39);
            this.button22.Name = "button22";
            this.button22.Size = new System.Drawing.Size(30, 30);
            this.button22.TabIndex = 7;
            this.button22.UseVisualStyleBackColor = false;
            this.button22.Click += new System.EventHandler(this.buttonColor_Click);
            // 
            // button21
            // 
            this.button21.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.button21.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button21.FlatAppearance.BorderColor = System.Drawing.Color.PaleTurquoise;
            this.button21.FlatAppearance.BorderSize = 5;
            this.button21.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.button21.Location = new System.Drawing.Point(92, 10);
            this.button21.Name = "button21";
            this.button21.Size = new System.Drawing.Size(30, 30);
            this.button21.TabIndex = 7;
            this.button21.UseVisualStyleBackColor = false;
            this.button21.Click += new System.EventHandler(this.buttonColor_Click);
            // 
            // button27
            // 
            this.button27.BackColor = System.Drawing.Color.Aqua;
            this.button27.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button27.FlatAppearance.BorderColor = System.Drawing.Color.PaleTurquoise;
            this.button27.FlatAppearance.BorderSize = 5;
            this.button27.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.button27.Location = new System.Drawing.Point(121, 39);
            this.button27.Name = "button27";
            this.button27.Size = new System.Drawing.Size(30, 30);
            this.button27.TabIndex = 7;
            this.button27.UseVisualStyleBackColor = false;
            this.button27.Click += new System.EventHandler(this.buttonColor_Click);
            // 
            // button26
            // 
            this.button26.BackColor = System.Drawing.Color.Green;
            this.button26.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button26.FlatAppearance.BorderColor = System.Drawing.Color.PaleTurquoise;
            this.button26.FlatAppearance.BorderSize = 5;
            this.button26.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.button26.Location = new System.Drawing.Point(149, 10);
            this.button26.Name = "button26";
            this.button26.Size = new System.Drawing.Size(30, 30);
            this.button26.TabIndex = 7;
            this.button26.UseVisualStyleBackColor = false;
            this.button26.Click += new System.EventHandler(this.buttonColor_Click);
            // 
            // button12
            // 
            this.button12.BackColor = System.Drawing.Color.LightPink;
            this.button12.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button12.FlatAppearance.BorderColor = System.Drawing.Color.PaleTurquoise;
            this.button12.FlatAppearance.BorderSize = 5;
            this.button12.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.button12.Location = new System.Drawing.Point(64, 39);
            this.button12.Name = "button12";
            this.button12.Size = new System.Drawing.Size(30, 30);
            this.button12.TabIndex = 7;
            this.button12.UseVisualStyleBackColor = false;
            this.button12.Click += new System.EventHandler(this.buttonColor_Click);
            // 
            // comboBox1
            // 
            this.comboBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBox1.Items.AddRange(new object[] {
            "Solid",
            "Dash",
            "Dot",
            "DashDot",
            "DashDotDot"});
            this.comboBox1.Location = new System.Drawing.Point(3, 3);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(179, 37);
            this.comboBox1.TabIndex = 0;
            this.comboBox1.Text = "Solid";
            this.toolTip1.SetToolTip(this.comboBox1, "Style");
            this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // lblPosition
            // 
            this.lblPosition.AutoSize = true;
            this.lblPosition.Location = new System.Drawing.Point(6, 92);
            this.lblPosition.Name = "lblPosition";
            this.lblPosition.Size = new System.Drawing.Size(107, 17);
            this.lblPosition.TabIndex = 49;
            this.lblPosition.Text = "Mouse location:";
            // 
            // btnFillHinhVuong
            // 
            this.btnFillHinhVuong.BackColor = System.Drawing.Color.White;
            this.btnFillHinhVuong.Location = new System.Drawing.Point(6, 146);
            this.btnFillHinhVuong.Margin = new System.Windows.Forms.Padding(4);
            this.btnFillHinhVuong.Name = "btnFillHinhVuong";
            this.btnFillHinhVuong.Size = new System.Drawing.Size(2040, 825);
            this.btnFillHinhVuong.TabIndex = 6;
            this.btnFillHinhVuong.TabStop = false;
            this.btnFillHinhVuong.Click += new System.EventHandler(this.pictureBox_Click);
            this.btnFillHinhVuong.Paint += new System.Windows.Forms.PaintEventHandler(this.pictureBox_Paint);
            this.btnFillHinhVuong.MouseDown += new System.Windows.Forms.MouseEventHandler(this.pictureBox_MouseDown);
            this.btnFillHinhVuong.MouseMove += new System.Windows.Forms.MouseEventHandler(this.pictureBox_MouseMove);
            this.btnFillHinhVuong.MouseUp += new System.Windows.Forms.MouseEventHandler(this.PictureBox_MouseUp);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.ClientSize = new System.Drawing.Size(1924, 653);
            this.Controls.Add(this.btnFillHinhVuong);
            this.Controls.Add(this.panel2);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.ImeMode = System.Windows.Forms.ImeMode.On;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Form1";
            this.Text = "Vy Paint";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.Form1_Load);
            this.Resize += new System.EventHandler(this.Form1_Resize);
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.btnFillHinhVuong)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        //private DevComponents.DotNetBar.ButtonItem btnx5;
        private System.Windows.Forms.ColorDialog colorDialog1;
        private System.Windows.Forms.NumericUpDown numericUpDown1;
        private System.Windows.Forms.Button btnColorPen;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.PictureBox btnFillHinhVuong;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Label lblPosition;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lblcurpen;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button button24;
        private System.Windows.Forms.Button button29;
        private System.Windows.Forms.Button button8;
        private System.Windows.Forms.Button button23;
        private System.Windows.Forms.Button button17;
        private System.Windows.Forms.Button button28;
        private System.Windows.Forms.Button button25;
        private System.Windows.Forms.Button button22;
        private System.Windows.Forms.Button button21;
        private System.Windows.Forms.Button button27;
        private System.Windows.Forms.Button button26;
        private System.Windows.Forms.Button button12;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.Button btnDuongThang;
        private System.Windows.Forms.Button btnSizeMove;
        private System.Windows.Forms.Button btnBezier;
        private System.Windows.Forms.Button btnFillSqua;
        private System.Windows.Forms.Button btnHinhVuong;
        private System.Windows.Forms.Button btnFillHinhTron;
        private System.Windows.Forms.Button btnHinhTron;
        private System.Windows.Forms.Button btnFillEllipse;
        private System.Windows.Forms.Button btnElip;
        private System.Windows.Forms.Button btnFillHinhChuNhat;
        private System.Windows.Forms.Button btnHCN;
        private System.Windows.Forms.Button btnXoaHinhCuoi;
        private System.Windows.Forms.Button btnXoaHet;
        private System.Windows.Forms.Button btnConTro;
    }
}

