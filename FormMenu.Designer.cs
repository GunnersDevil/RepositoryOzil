namespace Ozil_Cafe
{
    partial class FormMenu
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormMenu));
            this.visualStyler1 = new SkinSoft.VisualStyler.VisualStyler(this.components);
            this.pboWelcome = new System.Windows.Forms.PictureBox();
            this.linkCostumer = new System.Windows.Forms.LinkLabel();
            this.linkHelp = new System.Windows.Forms.LinkLabel();
            ((System.ComponentModel.ISupportInitialize)(this.visualStyler1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pboWelcome)).BeginInit();
            this.SuspendLayout();
            // 
            // visualStyler1
            // 
            this.visualStyler1.HostForm = this;
            this.visualStyler1.License = ((SkinSoft.VisualStyler.Licensing.VisualStylerLicense)(resources.GetObject("visualStyler1.License")));
            this.visualStyler1.LoadVisualStyle(null, "OSX (iTunes).vssf");
            // 
            // pboWelcome
            // 
            this.pboWelcome.BackgroundImage = global::Ozil_Cafe.Properties.Resources.Welcome;
            this.pboWelcome.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pboWelcome.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pboWelcome.Location = new System.Drawing.Point(-4, 0);
            this.pboWelcome.Name = "pboWelcome";
            this.pboWelcome.Size = new System.Drawing.Size(500, 505);
            this.pboWelcome.TabIndex = 106;
            this.pboWelcome.TabStop = false;
            // 
            // linkCostumer
            // 
            this.linkCostumer.ActiveLinkColor = System.Drawing.Color.Black;
            this.linkCostumer.BackColor = System.Drawing.Color.Transparent;
            this.linkCostumer.Font = new System.Drawing.Font("SF Cartoonist Hand", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.linkCostumer.LinkBehavior = System.Windows.Forms.LinkBehavior.NeverUnderline;
            this.linkCostumer.LinkColor = System.Drawing.Color.Black;
            this.linkCostumer.Location = new System.Drawing.Point(288, 166);
            this.linkCostumer.Name = "linkCostumer";
            this.linkCostumer.Size = new System.Drawing.Size(131, 44);
            this.linkCostumer.TabIndex = 107;
            this.linkCostumer.TabStop = true;
            this.linkCostumer.Text = "Go To Menu";
            this.linkCostumer.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.linkCostumer.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkMenu_LinkClicked);
            // 
            // linkHelp
            // 
            this.linkHelp.ActiveLinkColor = System.Drawing.Color.Black;
            this.linkHelp.BackColor = System.Drawing.Color.Transparent;
            this.linkHelp.Font = new System.Drawing.Font("SF Cartoonist Hand", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.linkHelp.LinkBehavior = System.Windows.Forms.LinkBehavior.NeverUnderline;
            this.linkHelp.LinkColor = System.Drawing.Color.Black;
            this.linkHelp.Location = new System.Drawing.Point(291, 249);
            this.linkHelp.Name = "linkHelp";
            this.linkHelp.Size = new System.Drawing.Size(131, 44);
            this.linkHelp.TabIndex = 108;
            this.linkHelp.TabStop = true;
            this.linkHelp.Text = "Help";
            this.linkHelp.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.linkHelp.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkHelp_LinkClicked);
            // 
            // FormMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(494, 502);
            this.Controls.Add(this.linkHelp);
            this.Controls.Add(this.linkCostumer);
            this.Controls.Add(this.pboWelcome);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FormMenu";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Özil Cafe";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.visualStyler1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pboWelcome)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private SkinSoft.VisualStyler.VisualStyler visualStyler1;
        private System.Windows.Forms.PictureBox pboWelcome;
        private System.Windows.Forms.LinkLabel linkCostumer;
        private System.Windows.Forms.LinkLabel linkHelp;
    }
}

