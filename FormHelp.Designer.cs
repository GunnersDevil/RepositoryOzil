namespace Ozil_Cafe
{
    partial class FormHelp
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormHelp));
            this.tmrJam = new System.Windows.Forms.Timer(this.components);
            this.visualStyler1 = new SkinSoft.VisualStyler.VisualStyler(this.components);
            this.pboBackground = new System.Windows.Forms.PictureBox();
            this.pboHeader = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.grbProses = new System.Windows.Forms.GroupBox();
            this.btnAbout = new System.Windows.Forms.Button();
            this.btnCostumer = new System.Windows.Forms.Button();
            this.btnChoice = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.visualStyler1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pboBackground)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pboHeader)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.grbProses.SuspendLayout();
            this.SuspendLayout();
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
            this.pboBackground.Size = new System.Drawing.Size(771, 628);
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
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImage = global::Ozil_Cafe.Properties.Resources.Help;
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pictureBox1.Location = new System.Drawing.Point(146, 142);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(608, 469);
            this.pictureBox1.TabIndex = 107;
            this.pictureBox1.TabStop = false;
            // 
            // grbProses
            // 
            this.grbProses.BackColor = System.Drawing.Color.Transparent;
            this.grbProses.Controls.Add(this.btnAbout);
            this.grbProses.Controls.Add(this.btnCostumer);
            this.grbProses.Controls.Add(this.btnChoice);
            this.grbProses.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.grbProses.Location = new System.Drawing.Point(11, 137);
            this.grbProses.Name = "grbProses";
            this.grbProses.Size = new System.Drawing.Size(129, 286);
            this.grbProses.TabIndex = 118;
            this.grbProses.TabStop = false;
            // 
            // btnAbout
            // 
            this.btnAbout.AutoSize = true;
            this.btnAbout.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAbout.Font = new System.Drawing.Font("SF Cartoonist Hand", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAbout.Location = new System.Drawing.Point(14, 190);
            this.btnAbout.Name = "btnAbout";
            this.btnAbout.Size = new System.Drawing.Size(100, 80);
            this.btnAbout.TabIndex = 26;
            this.btnAbout.Text = "About\r\nUs";
            this.btnAbout.UseVisualStyleBackColor = true;
            this.btnAbout.Click += new System.EventHandler(this.btnAbout_Click);
            // 
            // btnCostumer
            // 
            this.btnCostumer.AutoSize = true;
            this.btnCostumer.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCostumer.Font = new System.Drawing.Font("SF Cartoonist Hand", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCostumer.Location = new System.Drawing.Point(14, 104);
            this.btnCostumer.Name = "btnCostumer";
            this.btnCostumer.Size = new System.Drawing.Size(101, 80);
            this.btnCostumer.TabIndex = 25;
            this.btnCostumer.Text = "Order\r\nNow\r\n";
            this.btnCostumer.UseVisualStyleBackColor = true;
            this.btnCostumer.Click += new System.EventHandler(this.btnCostumer_Click);
            // 
            // btnChoice
            // 
            this.btnChoice.AutoSize = true;
            this.btnChoice.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnChoice.Font = new System.Drawing.Font("SF Cartoonist Hand", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnChoice.Location = new System.Drawing.Point(15, 18);
            this.btnChoice.Name = "btnChoice";
            this.btnChoice.Size = new System.Drawing.Size(100, 80);
            this.btnChoice.TabIndex = 24;
            this.btnChoice.Text = "Back To\r\nHome";
            this.btnChoice.UseVisualStyleBackColor = true;
            this.btnChoice.Click += new System.EventHandler(this.btnChoice_Click);
            // 
            // FormHelp
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(766, 626);
            this.Controls.Add(this.grbProses);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.pboHeader);
            this.Controls.Add(this.pboBackground);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FormHelp";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Özil Cafe";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.visualStyler1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pboBackground)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pboHeader)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.grbProses.ResumeLayout(false);
            this.grbProses.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Timer tmrJam;
        private SkinSoft.VisualStyler.VisualStyler visualStyler1;
        private System.Windows.Forms.PictureBox pboBackground;
        private System.Windows.Forms.PictureBox pboHeader;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.GroupBox grbProses;
        private System.Windows.Forms.Button btnAbout;
        private System.Windows.Forms.Button btnCostumer;
        private System.Windows.Forms.Button btnChoice;
    }
}

