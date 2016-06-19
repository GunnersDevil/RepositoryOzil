namespace Ozil_Cafe
{
    partial class FormChoice
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormChoice));
            this.tmrJam = new System.Windows.Forms.Timer(this.components);
            this.visualStyler1 = new SkinSoft.VisualStyler.VisualStyler(this.components);
            this.pboBackground = new System.Windows.Forms.PictureBox();
            this.pboHeader = new System.Windows.Forms.PictureBox();
            this.grbHeader = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.lblTanggal = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.lblDetik = new System.Windows.Forms.Label();
            this.lblMenit = new System.Windows.Forms.Label();
            this.lblJam = new System.Windows.Forms.Label();
            this.label19 = new System.Windows.Forms.Label();
            this.label18 = new System.Windows.Forms.Label();
            this.grbProses = new System.Windows.Forms.GroupBox();
            this.btnCostumer = new System.Windows.Forms.Button();
            this.shapeContainer1 = new Microsoft.VisualBasic.PowerPacks.ShapeContainer();
            this.rectangleShape1 = new Microsoft.VisualBasic.PowerPacks.RectangleShape();
            this.btnCashier = new System.Windows.Forms.Button();
            this.rectangleShape2 = new Microsoft.VisualBasic.PowerPacks.RectangleShape();
            ((System.ComponentModel.ISupportInitialize)(this.visualStyler1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pboBackground)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pboHeader)).BeginInit();
            this.grbHeader.SuspendLayout();
            this.panel1.SuspendLayout();
            this.grbProses.SuspendLayout();
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
            this.pboBackground.Size = new System.Drawing.Size(771, 383);
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
            // grbHeader
            // 
            this.grbHeader.BackColor = System.Drawing.Color.Transparent;
            this.grbHeader.Controls.Add(this.label1);
            this.grbHeader.Controls.Add(this.lblTanggal);
            this.grbHeader.Controls.Add(this.panel1);
            this.grbHeader.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.grbHeader.Location = new System.Drawing.Point(12, 137);
            this.grbHeader.Name = "grbHeader";
            this.grbHeader.Size = new System.Drawing.Size(742, 58);
            this.grbHeader.TabIndex = 110;
            this.grbHeader.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("SF Cartoonist Hand", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(293, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(156, 29);
            this.label1.TabIndex = 113;
            this.label1.Text = "SELECT CHOICE";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
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
            this.panel1.Location = new System.Drawing.Point(620, 20);
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
            // grbProses
            // 
            this.grbProses.BackColor = System.Drawing.Color.Transparent;
            this.grbProses.Controls.Add(this.btnCashier);
            this.grbProses.Controls.Add(this.btnCostumer);
            this.grbProses.Controls.Add(this.shapeContainer1);
            this.grbProses.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.grbProses.Location = new System.Drawing.Point(11, 204);
            this.grbProses.Name = "grbProses";
            this.grbProses.Size = new System.Drawing.Size(743, 161);
            this.grbProses.TabIndex = 116;
            this.grbProses.TabStop = false;
            // 
            // btnCostumer
            // 
            this.btnCostumer.AutoSize = true;
            this.btnCostumer.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.btnCostumer.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCostumer.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCostumer.Font = new System.Drawing.Font("SF Cartoonist Hand", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCostumer.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnCostumer.Location = new System.Drawing.Point(176, 56);
            this.btnCostumer.Name = "btnCostumer";
            this.btnCostumer.Size = new System.Drawing.Size(158, 56);
            this.btnCostumer.TabIndex = 94;
            this.btnCostumer.Text = "Costumer";
            this.btnCostumer.UseVisualStyleBackColor = true;
            this.btnCostumer.Click += new System.EventHandler(this.btnCostumer_Click);
            // 
            // shapeContainer1
            // 
            this.shapeContainer1.Location = new System.Drawing.Point(3, 16);
            this.shapeContainer1.Margin = new System.Windows.Forms.Padding(0);
            this.shapeContainer1.Name = "shapeContainer1";
            this.shapeContainer1.Shapes.AddRange(new Microsoft.VisualBasic.PowerPacks.Shape[] {
            this.rectangleShape2,
            this.rectangleShape1});
            this.shapeContainer1.Size = new System.Drawing.Size(737, 142);
            this.shapeContainer1.TabIndex = 95;
            this.shapeContainer1.TabStop = false;
            // 
            // rectangleShape1
            // 
            this.rectangleShape1.BorderColor = System.Drawing.Color.White;
            this.rectangleShape1.BorderWidth = 2;
            this.rectangleShape1.Location = new System.Drawing.Point(159, 27);
            this.rectangleShape1.Name = "rectangleShape1";
            this.rectangleShape1.Size = new System.Drawing.Size(186, 80);
            // 
            // btnCashier
            // 
            this.btnCashier.AutoSize = true;
            this.btnCashier.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.btnCashier.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCashier.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCashier.Font = new System.Drawing.Font("SF Cartoonist Hand", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCashier.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnCashier.Location = new System.Drawing.Point(411, 56);
            this.btnCashier.Name = "btnCashier";
            this.btnCashier.Size = new System.Drawing.Size(158, 56);
            this.btnCashier.TabIndex = 96;
            this.btnCashier.Text = "Cashier";
            this.btnCashier.UseVisualStyleBackColor = true;
            this.btnCashier.Click += new System.EventHandler(this.btnCashier_Click);
            // 
            // rectangleShape2
            // 
            this.rectangleShape2.BorderColor = System.Drawing.Color.White;
            this.rectangleShape2.BorderWidth = 2;
            this.rectangleShape2.Location = new System.Drawing.Point(392, 27);
            this.rectangleShape2.Name = "rectangleShape2";
            this.rectangleShape2.Size = new System.Drawing.Size(186, 80);
            // 
            // FormChoice
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(768, 380);
            this.Controls.Add(this.grbProses);
            this.Controls.Add(this.grbHeader);
            this.Controls.Add(this.pboHeader);
            this.Controls.Add(this.pboBackground);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FormChoice";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Özil Cafe";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.visualStyler1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pboBackground)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pboHeader)).EndInit();
            this.grbHeader.ResumeLayout(false);
            this.grbHeader.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.grbProses.ResumeLayout(false);
            this.grbProses.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Timer tmrJam;
        private SkinSoft.VisualStyler.VisualStyler visualStyler1;
        private System.Windows.Forms.PictureBox pboBackground;
        private System.Windows.Forms.PictureBox pboHeader;
        private System.Windows.Forms.GroupBox grbHeader;
        private System.Windows.Forms.Label lblTanggal;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lblDetik;
        private System.Windows.Forms.Label lblMenit;
        private System.Windows.Forms.Label lblJam;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.GroupBox grbProses;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnCostumer;
        private Microsoft.VisualBasic.PowerPacks.ShapeContainer shapeContainer1;
        private Microsoft.VisualBasic.PowerPacks.RectangleShape rectangleShape1;
        private System.Windows.Forms.Button btnCashier;
        private Microsoft.VisualBasic.PowerPacks.RectangleShape rectangleShape2;
    }
}

