namespace NASA_Space_Apps_Challenge
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
            this.Air_Quality_Index = new System.Windows.Forms.TrackBar();
            this.lbl_airquality = new System.Windows.Forms.Label();
            this.lbl_indexmagnitute = new System.Windows.Forms.Label();
            this.pb_rgyLung = new System.Windows.Forms.PictureBox();
            this.imageList_LungHealthScale = new System.Windows.Forms.ImageList(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.Air_Quality_Index)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb_rgyLung)).BeginInit();
            this.SuspendLayout();
            // 
            // Air_Quality_Index
            // 
            this.Air_Quality_Index.Location = new System.Drawing.Point(141, 350);
            this.Air_Quality_Index.Maximum = 500;
            this.Air_Quality_Index.Name = "Air_Quality_Index";
            this.Air_Quality_Index.Size = new System.Drawing.Size(647, 69);
            this.Air_Quality_Index.TabIndex = 50;
            this.Air_Quality_Index.Scroll += new System.EventHandler(this.Air_Quality_Index_Scroll);
            // 
            // lbl_airquality
            // 
            this.lbl_airquality.AutoSize = true;
            this.lbl_airquality.Location = new System.Drawing.Point(18, 360);
            this.lbl_airquality.Name = "lbl_airquality";
            this.lbl_airquality.Size = new System.Drawing.Size(127, 20);
            this.lbl_airquality.TabIndex = 1;
            this.lbl_airquality.Text = "Air Quality Index:";
            this.lbl_airquality.Click += new System.EventHandler(this.lbl_airquality_Click);
            // 
            // lbl_indexmagnitute
            // 
            this.lbl_indexmagnitute.AutoSize = true;
            this.lbl_indexmagnitute.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.lbl_indexmagnitute.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lbl_indexmagnitute.Location = new System.Drawing.Point(29, 30);
            this.lbl_indexmagnitute.Name = "lbl_indexmagnitute";
            this.lbl_indexmagnitute.Size = new System.Drawing.Size(18, 20);
            this.lbl_indexmagnitute.TabIndex = 51;
            this.lbl_indexmagnitute.Text = "0";
            // 
            // pb_rgyLung
            // 
            this.pb_rgyLung.Location = new System.Drawing.Point(141, 30);
            this.pb_rgyLung.Name = "pb_rgyLung";
            this.pb_rgyLung.Size = new System.Drawing.Size(474, 301);
            this.pb_rgyLung.TabIndex = 55;
            this.pb_rgyLung.TabStop = false;
            this.pb_rgyLung.Click += new System.EventHandler(this.redLung_Click);
            // 
            // imageList_LungHealthScale
            // 
            this.imageList_LungHealthScale.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageList_LungHealthScale.ImageStream")));
            this.imageList_LungHealthScale.TransparentColor = System.Drawing.Color.Transparent;
            this.imageList_LungHealthScale.Images.SetKeyName(0, "Green Lung.png");
            this.imageList_LungHealthScale.Images.SetKeyName(1, "Yellow Lung.png");
            this.imageList_LungHealthScale.Images.SetKeyName(2, "red lung.png");
            this.imageList_LungHealthScale.Images.SetKeyName(3, "black lung.png");
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.pb_rgyLung);
            this.Controls.Add(this.lbl_indexmagnitute);
            this.Controls.Add(this.lbl_airquality);
            this.Controls.Add(this.Air_Quality_Index);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.Air_Quality_Index)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb_rgyLung)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TrackBar Air_Quality_Index;
        private System.Windows.Forms.Label lbl_airquality;
        private System.Windows.Forms.Label lbl_indexmagnitute;
        private System.Windows.Forms.PictureBox pb_rgyLung;
        private System.Windows.Forms.ImageList imageList_LungHealthScale;
    }
}

