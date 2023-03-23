namespace Karsidan_karsiya_Form
{
    partial class FrmGame
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmGame));
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.btnSheep = new DevExpress.XtraEditors.SimpleButton();
            this.btnWolf = new DevExpress.XtraEditors.SimpleButton();
            this.btnStack = new DevExpress.XtraEditors.SimpleButton();
            this.lblHalfTime = new DevExpress.XtraEditors.LabelControl();
            this.lbl = new DevExpress.XtraEditors.LabelControl();
            this.panelSag = new System.Windows.Forms.Panel();
            this.btnHuman = new DevExpress.XtraEditors.SimpleButton();
            this.panelSol = new System.Windows.Forms.Panel();
            this.btnSound = new DevExpress.XtraEditors.CheckButton();
            this.pictureEdit1 = new DevExpress.XtraEditors.PictureEdit();
            this.panelSag.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureEdit1.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // timer1
            // 
            this.timer1.Interval = 1000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick_1);
            // 
            // btnSheep
            // 
            this.btnSheep.ImageOptions.Location = DevExpress.XtraEditors.ImageLocation.MiddleCenter;
            this.btnSheep.ImageOptions.SvgImage = global::Karsidan_karsiya_Form.Properties.Resources.Sheep;
            this.btnSheep.ImageOptions.SvgImageSize = new System.Drawing.Size(72, 72);
            this.btnSheep.Location = new System.Drawing.Point(100, 129);
            this.btnSheep.Name = "btnSheep";
            this.btnSheep.PaintStyle = DevExpress.XtraEditors.Controls.PaintStyles.Light;
            this.btnSheep.Size = new System.Drawing.Size(120, 120);
            this.btnSheep.TabIndex = 0;
            this.btnSheep.Text = "Kuzu";
            this.btnSheep.Click += new System.EventHandler(this.btnSheep_Click);
            // 
            // btnWolf
            // 
            this.btnWolf.ImageOptions.Location = DevExpress.XtraEditors.ImageLocation.MiddleCenter;
            this.btnWolf.ImageOptions.SvgImage = global::Karsidan_karsiya_Form.Properties.Resources.Wolf;
            this.btnWolf.ImageOptions.SvgImageSize = new System.Drawing.Size(72, 72);
            this.btnWolf.Location = new System.Drawing.Point(100, 3);
            this.btnWolf.Name = "btnWolf";
            this.btnWolf.PaintStyle = DevExpress.XtraEditors.Controls.PaintStyles.Light;
            this.btnWolf.Size = new System.Drawing.Size(120, 120);
            this.btnWolf.TabIndex = 3;
            this.btnWolf.Text = "Kurt";
            this.btnWolf.Click += new System.EventHandler(this.btnWolf_Click);
            // 
            // btnStack
            // 
            this.btnStack.ImageOptions.Location = DevExpress.XtraEditors.ImageLocation.MiddleCenter;
            this.btnStack.ImageOptions.SvgImage = global::Karsidan_karsiya_Form.Properties.Resources.HayStack;
            this.btnStack.ImageOptions.SvgImageSize = new System.Drawing.Size(72, 72);
            this.btnStack.Location = new System.Drawing.Point(103, 255);
            this.btnStack.Name = "btnStack";
            this.btnStack.PaintStyle = DevExpress.XtraEditors.Controls.PaintStyles.Light;
            this.btnStack.Size = new System.Drawing.Size(120, 120);
            this.btnStack.TabIndex = 2;
            this.btnStack.Text = "Ot";
            this.btnStack.Click += new System.EventHandler(this.btnStack_Click);
            // 
            // lblHalfTime
            // 
            this.lblHalfTime.Appearance.Font = new System.Drawing.Font("Tahoma", 11F);
            this.lblHalfTime.Appearance.Options.UseFont = true;
            this.lblHalfTime.Location = new System.Drawing.Point(741, 12);
            this.lblHalfTime.Name = "lblHalfTime";
            this.lblHalfTime.Size = new System.Drawing.Size(20, 22);
            this.lblHalfTime.TabIndex = 3;
            this.lblHalfTime.Text = "00";
            // 
            // lbl
            // 
            this.lbl.Appearance.Font = new System.Drawing.Font("Tahoma", 11F);
            this.lbl.Appearance.Options.UseFont = true;
            this.lbl.Location = new System.Drawing.Point(636, 12);
            this.lbl.Name = "lbl";
            this.lbl.Size = new System.Drawing.Size(89, 22);
            this.lbl.TabIndex = 4;
            this.lbl.Text = "Geçen Süre";
            // 
            // panelSag
            // 
            this.panelSag.BackgroundImage = global::Karsidan_karsiya_Form.Properties.Resources.Ekran_görüntüsü_2023_03_22_101708;
            this.panelSag.Controls.Add(this.btnHuman);
            this.panelSag.Controls.Add(this.btnSheep);
            this.panelSag.Controls.Add(this.btnStack);
            this.panelSag.Controls.Add(this.btnWolf);
            this.panelSag.Location = new System.Drawing.Point(502, 53);
            this.panelSag.Name = "panelSag";
            this.panelSag.Size = new System.Drawing.Size(240, 451);
            this.panelSag.TabIndex = 5;
            // 
            // btnHuman
            // 
            this.btnHuman.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnHuman.ImageOptions.Location = DevExpress.XtraEditors.ImageLocation.MiddleCenter;
            this.btnHuman.ImageOptions.SvgImage = global::Karsidan_karsiya_Form.Properties.Resources.User;
            this.btnHuman.ImageOptions.SvgImageSize = new System.Drawing.Size(72, 72);
            this.btnHuman.Location = new System.Drawing.Point(3, 324);
            this.btnHuman.Name = "btnHuman";
            this.btnHuman.PaintStyle = DevExpress.XtraEditors.Controls.PaintStyles.Light;
            this.btnHuman.Size = new System.Drawing.Size(94, 96);
            this.btnHuman.TabIndex = 8;
            this.btnHuman.Click += new System.EventHandler(this.btnHuman_Click);
            // 
            // panelSol
            // 
            this.panelSol.BackgroundImage = global::Karsidan_karsiya_Form.Properties.Resources.Ekran_görüntüsü_2023_03_22_101708;
            this.panelSol.Location = new System.Drawing.Point(33, 53);
            this.panelSol.Name = "panelSol";
            this.panelSol.Size = new System.Drawing.Size(243, 441);
            this.panelSol.TabIndex = 6;
            // 
            // btnSound
            // 
            this.btnSound.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnSound.ImageOptions.Image")));
            this.btnSound.ImageOptions.Location = DevExpress.XtraEditors.ImageLocation.MiddleCenter;
            this.btnSound.ImageOptions.SvgImageSize = new System.Drawing.Size(35, 35);
            this.btnSound.Location = new System.Drawing.Point(12, -1);
            this.btnSound.Name = "btnSound";
            this.btnSound.PaintStyle = DevExpress.XtraEditors.Controls.PaintStyles.Light;
            this.btnSound.Size = new System.Drawing.Size(94, 52);
            this.btnSound.TabIndex = 8;
            // 
            // pictureEdit1
            // 
            this.pictureEdit1.EditValue = global::Karsidan_karsiya_Form.Properties.Resources.test;
            this.pictureEdit1.Enabled = false;
            this.pictureEdit1.Location = new System.Drawing.Point(392, 198);
            this.pictureEdit1.Name = "pictureEdit1";
            this.pictureEdit1.Properties.Appearance.BackColor = System.Drawing.Color.Transparent;
            this.pictureEdit1.Properties.Appearance.Options.UseBackColor = true;
            this.pictureEdit1.Properties.ShowCameraMenuItem = DevExpress.XtraEditors.Controls.CameraMenuItemVisibility.Auto;
            this.pictureEdit1.Properties.SizeMode = DevExpress.XtraEditors.Controls.PictureSizeMode.Stretch;
            this.pictureEdit1.Size = new System.Drawing.Size(104, 104);
            this.pictureEdit1.TabIndex = 9;
            this.pictureEdit1.Click += new System.EventHandler(this.pictureEdit1_Click);
            // 
            // FrmGame
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImageLayoutStore = System.Windows.Forms.ImageLayout.Tile;
            this.BackgroundImageStore = global::Karsidan_karsiya_Form.Properties.Resources.Map_011;
            this.ClientSize = new System.Drawing.Size(798, 560);
            this.Controls.Add(this.pictureEdit1);
            this.Controls.Add(this.btnSound);
            this.Controls.Add(this.panelSol);
            this.Controls.Add(this.lbl);
            this.Controls.Add(this.lblHalfTime);
            this.Controls.Add(this.panelSag);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "FrmGame";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Oyun Ekranı";
            this.Load += new System.EventHandler(this.FrmGame_Load);
            this.panelSag.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureEdit1.Properties)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Timer timer1;
        private DevExpress.XtraEditors.LabelControl lbl;
        internal DevExpress.XtraEditors.LabelControl lblHalfTime;
        internal DevExpress.XtraEditors.SimpleButton btnSheep;
        internal DevExpress.XtraEditors.SimpleButton btnWolf;
        internal DevExpress.XtraEditors.SimpleButton btnStack;
        private System.Windows.Forms.Panel panelSag;
        private System.Windows.Forms.Panel panelSol;
        private DevExpress.XtraEditors.SimpleButton btnHuman;
        private DevExpress.XtraEditors.CheckButton btnSound;
        private DevExpress.XtraEditors.PictureEdit pictureEdit1;
    }
}