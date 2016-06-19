namespace Ozil_Cafe
{
    partial class FormCashier
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormCashier));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.tmrJam = new System.Windows.Forms.Timer(this.components);
            this.visualStyler1 = new SkinSoft.VisualStyler.VisualStyler(this.components);
            this.pboBackground = new System.Windows.Forms.PictureBox();
            this.pboHeader = new System.Windows.Forms.PictureBox();
            this.grbCari = new System.Windows.Forms.GroupBox();
            this.btnEnter = new System.Windows.Forms.Button();
            this.cmbNoMeja = new System.Windows.Forms.ComboBox();
            this.label13 = new System.Windows.Forms.Label();
            this.grbKasir = new System.Windows.Forms.GroupBox();
            this.lblNama = new System.Windows.Forms.Label();
            this.lblKode = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.pboKasir = new System.Windows.Forms.PictureBox();
            this.grbHeader = new System.Windows.Forms.GroupBox();
            this.lblTanggal = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.lblDetik = new System.Windows.Forms.Label();
            this.lblMenit = new System.Windows.Forms.Label();
            this.lblJam = new System.Windows.Forms.Label();
            this.label19 = new System.Windows.Forms.Label();
            this.label18 = new System.Windows.Forms.Label();
            this.grbTabel = new System.Windows.Forms.GroupBox();
            this.dtgOrder = new System.Windows.Forms.DataGridView();
            this.grbTombol = new System.Windows.Forms.GroupBox();
            this.btnCount = new System.Windows.Forms.Button();
            this.btnC = new System.Windows.Forms.Button();
            this.btnCE = new System.Windows.Forms.Button();
            this.btn0 = new System.Windows.Forms.Button();
            this.btn9 = new System.Windows.Forms.Button();
            this.btn8 = new System.Windows.Forms.Button();
            this.btn7 = new System.Windows.Forms.Button();
            this.btn5 = new System.Windows.Forms.Button();
            this.btn6 = new System.Windows.Forms.Button();
            this.btn4 = new System.Windows.Forms.Button();
            this.btn3 = new System.Windows.Forms.Button();
            this.btn2 = new System.Windows.Forms.Button();
            this.btn1 = new System.Windows.Forms.Button();
            this.grbTransaksi = new System.Windows.Forms.GroupBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.txtBayar = new System.Windows.Forms.TextBox();
            this.txtKembali = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtTotal = new System.Windows.Forms.TextBox();
            this.txtItem = new System.Windows.Forms.TextBox();
            this.grbProses = new System.Windows.Forms.GroupBox();
            this.btnAdd = new System.Windows.Forms.Button();
            this.btnPrint = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.errorPayment = new System.Windows.Forms.ErrorProvider(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.visualStyler1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pboBackground)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pboHeader)).BeginInit();
            this.grbCari.SuspendLayout();
            this.grbKasir.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pboKasir)).BeginInit();
            this.grbHeader.SuspendLayout();
            this.panel1.SuspendLayout();
            this.grbTabel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgOrder)).BeginInit();
            this.grbTombol.SuspendLayout();
            this.grbTransaksi.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.grbProses.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorPayment)).BeginInit();
            this.SuspendLayout();
            // 
            // tmrJam
            // 
            this.tmrJam.Tick += new System.EventHandler(this.tmrJam_Tick);
            // 
            // visualStyler1
            // 
            this.visualStyler1.HostForm = this;
            this.visualStyler1.License = ((SkinSoft.VisualStyler.Licensing.VisualStylerLicense)(resources.GetObject("visualStyler1.License")));
            this.visualStyler1.LoadVisualStyle(null, "OSX (iTunes).vssf");
            // 
            // pboBackground
            // 
            this.pboBackground.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pboBackground.Image = global::Ozil_Cafe.Properties.Resources.Background;
            this.pboBackground.Location = new System.Drawing.Point(-3, -1);
            this.pboBackground.Name = "pboBackground";
            this.pboBackground.Size = new System.Drawing.Size(771, 627);
            this.pboBackground.TabIndex = 105;
            this.pboBackground.TabStop = false;
            // 
            // pboHeader
            // 
            this.pboHeader.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pboHeader.BackgroundImage")));
            this.pboHeader.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pboHeader.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pboHeader.Location = new System.Drawing.Point(11, 13);
            this.pboHeader.Name = "pboHeader";
            this.pboHeader.Size = new System.Drawing.Size(743, 118);
            this.pboHeader.TabIndex = 106;
            this.pboHeader.TabStop = false;
            // 
            // grbCari
            // 
            this.grbCari.BackColor = System.Drawing.Color.Transparent;
            this.grbCari.Controls.Add(this.btnEnter);
            this.grbCari.Controls.Add(this.cmbNoMeja);
            this.grbCari.Controls.Add(this.label13);
            this.grbCari.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.grbCari.Location = new System.Drawing.Point(13, 137);
            this.grbCari.Name = "grbCari";
            this.grbCari.Size = new System.Drawing.Size(329, 58);
            this.grbCari.TabIndex = 108;
            this.grbCari.TabStop = false;
            // 
            // btnEnter
            // 
            this.btnEnter.AutoSize = true;
            this.btnEnter.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.btnEnter.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnEnter.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEnter.Font = new System.Drawing.Font("SF Cartoonist Hand", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEnter.Location = new System.Drawing.Point(249, 14);
            this.btnEnter.Name = "btnEnter";
            this.btnEnter.Size = new System.Drawing.Size(70, 35);
            this.btnEnter.TabIndex = 95;
            this.btnEnter.Text = "ENTER";
            this.btnEnter.UseVisualStyleBackColor = true;
            this.btnEnter.Click += new System.EventHandler(this.btnEnter_Click);
            // 
            // cmbNoMeja
            // 
            this.cmbNoMeja.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbNoMeja.Font = new System.Drawing.Font("SF Cartoonist Hand", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbNoMeja.FormattingEnabled = true;
            this.cmbNoMeja.Location = new System.Drawing.Point(130, 14);
            this.cmbNoMeja.Name = "cmbNoMeja";
            this.cmbNoMeja.Size = new System.Drawing.Size(113, 33);
            this.cmbNoMeja.TabIndex = 94;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("SF Cartoonist Hand SC", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.ForeColor = System.Drawing.Color.White;
            this.label13.Location = new System.Drawing.Point(8, 19);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(117, 22);
            this.label13.TabIndex = 40;
            this.label13.Text = "Nomor Meja :";
            this.label13.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // grbKasir
            // 
            this.grbKasir.BackColor = System.Drawing.Color.Transparent;
            this.grbKasir.Controls.Add(this.lblNama);
            this.grbKasir.Controls.Add(this.lblKode);
            this.grbKasir.Controls.Add(this.label3);
            this.grbKasir.Controls.Add(this.label2);
            this.grbKasir.Controls.Add(this.label1);
            this.grbKasir.Controls.Add(this.pboKasir);
            this.grbKasir.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.grbKasir.Location = new System.Drawing.Point(356, 201);
            this.grbKasir.Name = "grbKasir";
            this.grbKasir.Size = new System.Drawing.Size(398, 100);
            this.grbKasir.TabIndex = 112;
            this.grbKasir.TabStop = false;
            // 
            // lblNama
            // 
            this.lblNama.AutoSize = true;
            this.lblNama.Font = new System.Drawing.Font("SF Cartoonist Hand SC", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNama.ForeColor = System.Drawing.Color.White;
            this.lblNama.Location = new System.Drawing.Point(139, 69);
            this.lblNama.Name = "lblNama";
            this.lblNama.Size = new System.Drawing.Size(43, 19);
            this.lblNama.TabIndex = 109;
            this.lblNama.Text = "Nama";
            this.lblNama.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblKode
            // 
            this.lblKode.AutoSize = true;
            this.lblKode.Font = new System.Drawing.Font("SF Cartoonist Hand SC", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblKode.ForeColor = System.Drawing.Color.White;
            this.lblKode.Location = new System.Drawing.Point(139, 47);
            this.lblKode.Name = "lblKode";
            this.lblKode.Size = new System.Drawing.Size(43, 19);
            this.lblKode.TabIndex = 108;
            this.lblKode.Text = "Kode";
            this.lblKode.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("SF Cartoonist Hand", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(91, 69);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(48, 20);
            this.label3.TabIndex = 107;
            this.label3.Text = "Nama :";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("SF Cartoonist Hand", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(91, 47);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(48, 20);
            this.label2.TabIndex = 106;
            this.label2.Text = "Kode  :";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("SF Cartoonist Hand SC", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(91, 14);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(129, 22);
            this.label1.TabIndex = 95;
            this.label1.Text = "Administrator";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // pboKasir
            // 
            this.pboKasir.BackgroundImage = global::Ozil_Cafe.Properties.Resources.Ozil;
            this.pboKasir.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pboKasir.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pboKasir.Location = new System.Drawing.Point(10, 14);
            this.pboKasir.Name = "pboKasir";
            this.pboKasir.Size = new System.Drawing.Size(75, 75);
            this.pboKasir.TabIndex = 0;
            this.pboKasir.TabStop = false;
            // 
            // grbHeader
            // 
            this.grbHeader.BackColor = System.Drawing.Color.Transparent;
            this.grbHeader.Controls.Add(this.lblTanggal);
            this.grbHeader.Controls.Add(this.panel1);
            this.grbHeader.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.grbHeader.Location = new System.Drawing.Point(356, 137);
            this.grbHeader.Name = "grbHeader";
            this.grbHeader.Size = new System.Drawing.Size(398, 58);
            this.grbHeader.TabIndex = 110;
            this.grbHeader.TabStop = false;
            // 
            // lblTanggal
            // 
            this.lblTanggal.AutoSize = true;
            this.lblTanggal.Font = new System.Drawing.Font("SF Cartoonist Hand", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTanggal.ForeColor = System.Drawing.Color.White;
            this.lblTanggal.Location = new System.Drawing.Point(6, 20);
            this.lblTanggal.Name = "lblTanggal";
            this.lblTanggal.Size = new System.Drawing.Size(54, 20);
            this.lblTanggal.TabIndex = 105;
            this.lblTanggal.Text = "Tanggal";
            this.lblTanggal.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Transparent;
            this.panel1.Controls.Add(this.lblDetik);
            this.panel1.Controls.Add(this.lblMenit);
            this.panel1.Controls.Add(this.lblJam);
            this.panel1.Controls.Add(this.label19);
            this.panel1.Controls.Add(this.label18);
            this.panel1.Location = new System.Drawing.Point(283, 20);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(108, 26);
            this.panel1.TabIndex = 104;
            // 
            // lblDetik
            // 
            this.lblDetik.AutoSize = true;
            this.lblDetik.Font = new System.Drawing.Font("SF Cartoonist Hand", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDetik.ForeColor = System.Drawing.Color.White;
            this.lblDetik.Location = new System.Drawing.Point(73, 2);
            this.lblDetik.Name = "lblDetik";
            this.lblDetik.Size = new System.Drawing.Size(29, 20);
            this.lblDetik.TabIndex = 80;
            this.lblDetik.Text = "00";
            this.lblDetik.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblMenit
            // 
            this.lblMenit.AutoSize = true;
            this.lblMenit.Font = new System.Drawing.Font("SF Cartoonist Hand", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMenit.ForeColor = System.Drawing.Color.White;
            this.lblMenit.Location = new System.Drawing.Point(38, 2);
            this.lblMenit.Name = "lblMenit";
            this.lblMenit.Size = new System.Drawing.Size(29, 20);
            this.lblMenit.TabIndex = 79;
            this.lblMenit.Text = "00";
            this.lblMenit.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblJam
            // 
            this.lblJam.AutoSize = true;
            this.lblJam.Font = new System.Drawing.Font("SF Cartoonist Hand", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblJam.ForeColor = System.Drawing.Color.White;
            this.lblJam.Location = new System.Drawing.Point(1, 2);
            this.lblJam.Name = "lblJam";
            this.lblJam.Size = new System.Drawing.Size(29, 20);
            this.lblJam.TabIndex = 78;
            this.lblJam.Text = "00";
            this.lblJam.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Font = new System.Drawing.Font("SF Cartoonist Hand", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label19.ForeColor = System.Drawing.Color.White;
            this.label19.Location = new System.Drawing.Point(62, 2);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(13, 20);
            this.label19.TabIndex = 82;
            this.label19.Text = ":";
            this.label19.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Font = new System.Drawing.Font("SF Cartoonist Hand", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label18.ForeColor = System.Drawing.Color.White;
            this.label18.Location = new System.Drawing.Point(26, 2);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(13, 20);
            this.label18.TabIndex = 81;
            this.label18.Text = ":";
            this.label18.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // grbTabel
            // 
            this.grbTabel.BackColor = System.Drawing.Color.Transparent;
            this.grbTabel.Controls.Add(this.dtgOrder);
            this.grbTabel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.grbTabel.Location = new System.Drawing.Point(11, 201);
            this.grbTabel.Name = "grbTabel";
            this.grbTabel.Size = new System.Drawing.Size(329, 237);
            this.grbTabel.TabIndex = 111;
            this.grbTabel.TabStop = false;
            // 
            // dtgOrder
            // 
            this.dtgOrder.AllowUserToResizeColumns = false;
            this.dtgOrder.AllowUserToResizeRows = false;
            this.dtgOrder.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.dtgOrder.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.RaisedHorizontal;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.Cyan;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("SF Cartoonist Hand", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dtgOrder.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dtgOrder.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("SF Cartoonist Hand", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dtgOrder.DefaultCellStyle = dataGridViewCellStyle2;
            this.dtgOrder.Location = new System.Drawing.Point(9, 14);
            this.dtgOrder.Name = "dtgOrder";
            this.dtgOrder.RowHeadersVisible = false;
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.Black;
            this.dtgOrder.RowsDefaultCellStyle = dataGridViewCellStyle3;
            this.dtgOrder.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.dtgOrder.Size = new System.Drawing.Size(310, 212);
            this.dtgOrder.TabIndex = 103;
            // 
            // grbTombol
            // 
            this.grbTombol.BackColor = System.Drawing.Color.Transparent;
            this.grbTombol.Controls.Add(this.btnCount);
            this.grbTombol.Controls.Add(this.btnC);
            this.grbTombol.Controls.Add(this.btnCE);
            this.grbTombol.Controls.Add(this.btn0);
            this.grbTombol.Controls.Add(this.btn9);
            this.grbTombol.Controls.Add(this.btn8);
            this.grbTombol.Controls.Add(this.btn7);
            this.grbTombol.Controls.Add(this.btn5);
            this.grbTombol.Controls.Add(this.btn6);
            this.grbTombol.Controls.Add(this.btn4);
            this.grbTombol.Controls.Add(this.btn3);
            this.grbTombol.Controls.Add(this.btn2);
            this.grbTombol.Controls.Add(this.btn1);
            this.grbTombol.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.grbTombol.Location = new System.Drawing.Point(11, 445);
            this.grbTombol.Name = "grbTombol";
            this.grbTombol.Size = new System.Drawing.Size(329, 163);
            this.grbTombol.TabIndex = 114;
            this.grbTombol.TabStop = false;
            // 
            // btnCount
            // 
            this.btnCount.AutoSize = true;
            this.btnCount.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.btnCount.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCount.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCount.Font = new System.Drawing.Font("SF Cartoonist Hand", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCount.Location = new System.Drawing.Point(200, 111);
            this.btnCount.Name = "btnCount";
            this.btnCount.Size = new System.Drawing.Size(108, 41);
            this.btnCount.TabIndex = 92;
            this.btnCount.Text = "COUNT";
            this.btnCount.UseVisualStyleBackColor = true;
            this.btnCount.Click += new System.EventHandler(this.btnTombol_Click);
            // 
            // btnC
            // 
            this.btnC.AutoSize = true;
            this.btnC.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.btnC.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnC.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnC.Font = new System.Drawing.Font("SF Cartoonist Hand", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnC.Location = new System.Drawing.Point(246, 64);
            this.btnC.Name = "btnC";
            this.btnC.Size = new System.Drawing.Size(62, 41);
            this.btnC.TabIndex = 91;
            this.btnC.Text = "C";
            this.btnC.UseVisualStyleBackColor = true;
            this.btnC.Click += new System.EventHandler(this.btnTombol_Click);
            // 
            // btnCE
            // 
            this.btnCE.AutoSize = true;
            this.btnCE.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.btnCE.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCE.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCE.Font = new System.Drawing.Font("SF Cartoonist Hand", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCE.Location = new System.Drawing.Point(246, 17);
            this.btnCE.Name = "btnCE";
            this.btnCE.Size = new System.Drawing.Size(62, 41);
            this.btnCE.TabIndex = 90;
            this.btnCE.Text = "CE";
            this.btnCE.UseVisualStyleBackColor = true;
            this.btnCE.Click += new System.EventHandler(this.btnTombol_Click);
            // 
            // btn0
            // 
            this.btn0.AutoSize = true;
            this.btn0.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.btn0.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn0.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn0.Font = new System.Drawing.Font("SF Cartoonist Hand", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn0.Location = new System.Drawing.Point(200, 64);
            this.btn0.Name = "btn0";
            this.btn0.Size = new System.Drawing.Size(40, 41);
            this.btn0.TabIndex = 89;
            this.btn0.Text = "0";
            this.btn0.UseVisualStyleBackColor = true;
            this.btn0.Click += new System.EventHandler(this.btnTombol_Click);
            // 
            // btn9
            // 
            this.btn9.AutoSize = true;
            this.btn9.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.btn9.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn9.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn9.Font = new System.Drawing.Font("SF Cartoonist Hand", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn9.Location = new System.Drawing.Point(154, 64);
            this.btn9.Name = "btn9";
            this.btn9.Size = new System.Drawing.Size(40, 41);
            this.btn9.TabIndex = 84;
            this.btn9.Text = "9";
            this.btn9.UseVisualStyleBackColor = true;
            this.btn9.Click += new System.EventHandler(this.btnTombol_Click);
            // 
            // btn8
            // 
            this.btn8.AutoSize = true;
            this.btn8.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.btn8.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn8.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn8.Font = new System.Drawing.Font("SF Cartoonist Hand", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn8.Location = new System.Drawing.Point(108, 64);
            this.btn8.Name = "btn8";
            this.btn8.Size = new System.Drawing.Size(40, 41);
            this.btn8.TabIndex = 79;
            this.btn8.Text = "8";
            this.btn8.UseVisualStyleBackColor = true;
            this.btn8.Click += new System.EventHandler(this.btnTombol_Click);
            // 
            // btn7
            // 
            this.btn7.AutoSize = true;
            this.btn7.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.btn7.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn7.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn7.Font = new System.Drawing.Font("SF Cartoonist Hand", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn7.Location = new System.Drawing.Point(62, 64);
            this.btn7.Name = "btn7";
            this.btn7.Size = new System.Drawing.Size(40, 41);
            this.btn7.TabIndex = 73;
            this.btn7.Text = "7";
            this.btn7.UseVisualStyleBackColor = true;
            this.btn7.Click += new System.EventHandler(this.btnTombol_Click);
            // 
            // btn5
            // 
            this.btn5.AutoSize = true;
            this.btn5.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.btn5.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn5.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn5.Font = new System.Drawing.Font("SF Cartoonist Hand", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn5.Location = new System.Drawing.Point(200, 17);
            this.btn5.Name = "btn5";
            this.btn5.Size = new System.Drawing.Size(40, 41);
            this.btn5.TabIndex = 65;
            this.btn5.Text = "5";
            this.btn5.UseVisualStyleBackColor = true;
            this.btn5.Click += new System.EventHandler(this.btnTombol_Click);
            // 
            // btn6
            // 
            this.btn6.AutoSize = true;
            this.btn6.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.btn6.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn6.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn6.Font = new System.Drawing.Font("SF Cartoonist Hand", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn6.Location = new System.Drawing.Point(17, 64);
            this.btn6.Name = "btn6";
            this.btn6.Size = new System.Drawing.Size(40, 41);
            this.btn6.TabIndex = 66;
            this.btn6.Text = "6";
            this.btn6.UseVisualStyleBackColor = true;
            this.btn6.Click += new System.EventHandler(this.btnTombol_Click);
            // 
            // btn4
            // 
            this.btn4.AutoSize = true;
            this.btn4.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.btn4.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn4.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn4.Font = new System.Drawing.Font("SF Cartoonist Hand", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn4.Location = new System.Drawing.Point(154, 17);
            this.btn4.Name = "btn4";
            this.btn4.Size = new System.Drawing.Size(40, 41);
            this.btn4.TabIndex = 56;
            this.btn4.Text = "4";
            this.btn4.UseVisualStyleBackColor = true;
            this.btn4.Click += new System.EventHandler(this.btnTombol_Click);
            // 
            // btn3
            // 
            this.btn3.AutoSize = true;
            this.btn3.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.btn3.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn3.Font = new System.Drawing.Font("SF Cartoonist Hand", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn3.Location = new System.Drawing.Point(108, 17);
            this.btn3.Name = "btn3";
            this.btn3.Size = new System.Drawing.Size(40, 41);
            this.btn3.TabIndex = 46;
            this.btn3.Text = "3";
            this.btn3.UseVisualStyleBackColor = true;
            this.btn3.Click += new System.EventHandler(this.btnTombol_Click);
            // 
            // btn2
            // 
            this.btn2.AutoSize = true;
            this.btn2.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.btn2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn2.Font = new System.Drawing.Font("SF Cartoonist Hand", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn2.Location = new System.Drawing.Point(62, 17);
            this.btn2.Name = "btn2";
            this.btn2.Size = new System.Drawing.Size(40, 41);
            this.btn2.TabIndex = 35;
            this.btn2.Text = "2";
            this.btn2.UseVisualStyleBackColor = true;
            this.btn2.Click += new System.EventHandler(this.btnTombol_Click);
            // 
            // btn1
            // 
            this.btn1.AutoSize = true;
            this.btn1.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.btn1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn1.Font = new System.Drawing.Font("SF Cartoonist Hand", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn1.Location = new System.Drawing.Point(17, 17);
            this.btn1.Name = "btn1";
            this.btn1.Size = new System.Drawing.Size(40, 41);
            this.btn1.TabIndex = 21;
            this.btn1.Text = "1";
            this.btn1.UseVisualStyleBackColor = true;
            this.btn1.Click += new System.EventHandler(this.btnTombol_Click);
            // 
            // grbTransaksi
            // 
            this.grbTransaksi.BackColor = System.Drawing.Color.Transparent;
            this.grbTransaksi.Controls.Add(this.groupBox1);
            this.grbTransaksi.Controls.Add(this.label7);
            this.grbTransaksi.Controls.Add(this.label4);
            this.grbTransaksi.Controls.Add(this.txtTotal);
            this.grbTransaksi.Controls.Add(this.txtItem);
            this.grbTransaksi.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.grbTransaksi.Location = new System.Drawing.Point(356, 307);
            this.grbTransaksi.Name = "grbTransaksi";
            this.grbTransaksi.Size = new System.Drawing.Size(398, 233);
            this.grbTransaksi.TabIndex = 116;
            this.grbTransaksi.TabStop = false;
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.Transparent;
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.txtBayar);
            this.groupBox1.Controls.Add(this.txtKembali);
            this.groupBox1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.groupBox1.Location = new System.Drawing.Point(17, 111);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(357, 94);
            this.groupBox1.TabIndex = 115;
            this.groupBox1.TabStop = false;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("SF Cartoonist Hand", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(12, 23);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(129, 23);
            this.label5.TabIndex = 113;
            this.label5.Text = "Payment (Rp.)   :";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("SF Cartoonist Hand", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.White;
            this.label6.Location = new System.Drawing.Point(12, 55);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(130, 23);
            this.label6.TabIndex = 114;
            this.label6.Text = "Exchange (Rp.)  :";
            this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txtBayar
            // 
            this.txtBayar.Font = new System.Drawing.Font("SF Cartoonist Hand", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBayar.Location = new System.Drawing.Point(157, 20);
            this.txtBayar.Name = "txtBayar";
            this.txtBayar.Size = new System.Drawing.Size(188, 29);
            this.txtBayar.TabIndex = 26;
            // 
            // txtKembali
            // 
            this.txtKembali.Font = new System.Drawing.Font("SF Cartoonist Hand", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtKembali.Location = new System.Drawing.Point(157, 52);
            this.txtKembali.Name = "txtKembali";
            this.txtKembali.Size = new System.Drawing.Size(188, 29);
            this.txtKembali.TabIndex = 27;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("SF Cartoonist Hand", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.White;
            this.label7.Location = new System.Drawing.Point(12, 68);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(125, 29);
            this.label7.TabIndex = 112;
            this.label7.Text = "Total Rp.    :";
            this.label7.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("SF Cartoonist Hand", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(12, 33);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(123, 29);
            this.label4.TabIndex = 110;
            this.label4.Text = "Total Item  :";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txtTotal
            // 
            this.txtTotal.Font = new System.Drawing.Font("SF Cartoonist Hand", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTotal.Location = new System.Drawing.Point(142, 70);
            this.txtTotal.Name = "txtTotal";
            this.txtTotal.Size = new System.Drawing.Size(232, 29);
            this.txtTotal.TabIndex = 25;
            // 
            // txtItem
            // 
            this.txtItem.Font = new System.Drawing.Font("SF Cartoonist Hand", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtItem.Location = new System.Drawing.Point(142, 35);
            this.txtItem.Name = "txtItem";
            this.txtItem.Size = new System.Drawing.Size(232, 29);
            this.txtItem.TabIndex = 24;
            // 
            // grbProses
            // 
            this.grbProses.BackColor = System.Drawing.Color.Transparent;
            this.grbProses.Controls.Add(this.btnAdd);
            this.grbProses.Controls.Add(this.btnPrint);
            this.grbProses.Controls.Add(this.btnExit);
            this.grbProses.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.grbProses.Location = new System.Drawing.Point(356, 546);
            this.grbProses.Name = "grbProses";
            this.grbProses.Size = new System.Drawing.Size(398, 62);
            this.grbProses.TabIndex = 117;
            this.grbProses.TabStop = false;
            // 
            // btnAdd
            // 
            this.btnAdd.AutoSize = true;
            this.btnAdd.Font = new System.Drawing.Font("SF Cartoonist Hand", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAdd.Location = new System.Drawing.Point(87, 13);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(63, 39);
            this.btnAdd.TabIndex = 24;
            this.btnAdd.Text = "ADD";
            this.btnAdd.UseVisualStyleBackColor = true;
            // 
            // btnPrint
            // 
            this.btnPrint.AutoSize = true;
            this.btnPrint.Font = new System.Drawing.Font("SF Cartoonist Hand", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPrint.Location = new System.Drawing.Point(156, 13);
            this.btnPrint.Name = "btnPrint";
            this.btnPrint.Size = new System.Drawing.Size(82, 39);
            this.btnPrint.TabIndex = 25;
            this.btnPrint.Text = "PRINT";
            this.btnPrint.UseVisualStyleBackColor = true;
            // 
            // btnExit
            // 
            this.btnExit.AutoSize = true;
            this.btnExit.Font = new System.Drawing.Font("SF Cartoonist Hand", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExit.Location = new System.Drawing.Point(244, 13);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(67, 39);
            this.btnExit.TabIndex = 26;
            this.btnExit.Text = "EXIT";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // errorPayment
            // 
            this.errorPayment.ContainerControl = this;
            // 
            // FormCashier
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(769, 622);
            this.Controls.Add(this.grbTransaksi);
            this.Controls.Add(this.grbProses);
            this.Controls.Add(this.grbKasir);
            this.Controls.Add(this.grbHeader);
            this.Controls.Add(this.grbTabel);
            this.Controls.Add(this.grbTombol);
            this.Controls.Add(this.grbCari);
            this.Controls.Add(this.pboHeader);
            this.Controls.Add(this.pboBackground);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FormCashier";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Özil Cafe";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.visualStyler1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pboBackground)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pboHeader)).EndInit();
            this.grbCari.ResumeLayout(false);
            this.grbCari.PerformLayout();
            this.grbKasir.ResumeLayout(false);
            this.grbKasir.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pboKasir)).EndInit();
            this.grbHeader.ResumeLayout(false);
            this.grbHeader.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.grbTabel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dtgOrder)).EndInit();
            this.grbTombol.ResumeLayout(false);
            this.grbTombol.PerformLayout();
            this.grbTransaksi.ResumeLayout(false);
            this.grbTransaksi.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.grbProses.ResumeLayout(false);
            this.grbProses.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorPayment)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Timer tmrJam;
        private SkinSoft.VisualStyler.VisualStyler visualStyler1;
        private System.Windows.Forms.PictureBox pboBackground;
        private System.Windows.Forms.PictureBox pboHeader;
        private System.Windows.Forms.GroupBox grbCari;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.ComboBox cmbNoMeja;
        private System.Windows.Forms.GroupBox grbKasir;
        private System.Windows.Forms.Label lblNama;
        private System.Windows.Forms.Label lblKode;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pboKasir;
        private System.Windows.Forms.GroupBox grbHeader;
        private System.Windows.Forms.Label lblTanggal;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lblDetik;
        private System.Windows.Forms.Label lblMenit;
        private System.Windows.Forms.Label lblJam;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.GroupBox grbTabel;
        private System.Windows.Forms.DataGridView dtgOrder;
        private System.Windows.Forms.GroupBox grbTombol;
        private System.Windows.Forms.Button btnCount;
        private System.Windows.Forms.Button btnC;
        private System.Windows.Forms.Button btnCE;
        private System.Windows.Forms.Button btn0;
        private System.Windows.Forms.Button btn9;
        private System.Windows.Forms.Button btn8;
        private System.Windows.Forms.Button btn7;
        private System.Windows.Forms.Button btn5;
        private System.Windows.Forms.Button btn6;
        private System.Windows.Forms.Button btn4;
        private System.Windows.Forms.Button btn3;
        private System.Windows.Forms.Button btn2;
        private System.Windows.Forms.Button btn1;
        private System.Windows.Forms.GroupBox grbTransaksi;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtBayar;
        private System.Windows.Forms.TextBox txtKembali;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtTotal;
        private System.Windows.Forms.TextBox txtItem;
        private System.Windows.Forms.GroupBox grbProses;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btnPrint;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Button btnEnter;
        private System.Windows.Forms.ErrorProvider errorPayment;
    }
}

