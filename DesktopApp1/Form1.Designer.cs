namespace DesktopApp1
{
    partial class FilmSeeker
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FilmSeeker));
            this.button1 = new System.Windows.Forms.Button();
            this.search = new System.Windows.Forms.TextBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.star = new System.Windows.Forms.PictureBox();
            this.valuebox = new System.Windows.Forms.Label();
            this.plotbox = new System.Windows.Forms.Label();
            this.actorsbox = new System.Windows.Forms.Label();
            this.genrebox = new System.Windows.Forms.Label();
            this.runtimebox = new System.Windows.Forms.Label();
            this.yearbox = new System.Windows.Forms.Label();
            this.titlebox = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.star)).BeginInit();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button1.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            resources.ApplyResources(this.button1, "button1");
            this.button1.Name = "button1";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // search
            // 
            resources.ApplyResources(this.search, "search");
            this.search.Name = "search";
            // 
            // pictureBox1
            // 
            resources.ApplyResources(this.pictureBox1, "pictureBox1");
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.TabStop = false;
            // 
            // star
            // 
            this.star.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.star.Image = global::DesktopApp1.Properties.Resources.star;
            resources.ApplyResources(this.star, "star");
            this.star.Name = "star";
            this.star.TabStop = false;
            // 
            // valuebox
            // 
            resources.ApplyResources(this.valuebox, "valuebox");
            this.valuebox.Name = "valuebox";
            // 
            // plotbox
            // 
            resources.ApplyResources(this.plotbox, "plotbox");
            this.plotbox.Name = "plotbox";
            // 
            // actorsbox
            // 
            resources.ApplyResources(this.actorsbox, "actorsbox");
            this.actorsbox.Name = "actorsbox";
            // 
            // genrebox
            // 
            resources.ApplyResources(this.genrebox, "genrebox");
            this.genrebox.Name = "genrebox";
            // 
            // runtimebox
            // 
            resources.ApplyResources(this.runtimebox, "runtimebox");
            this.runtimebox.Name = "runtimebox";
            // 
            // yearbox
            // 
            resources.ApplyResources(this.yearbox, "yearbox");
            this.yearbox.Name = "yearbox";
            // 
            // titlebox
            // 
            resources.ApplyResources(this.titlebox, "titlebox");
            this.titlebox.Name = "titlebox";
            // 
            // FilmSeeker
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoValidate = System.Windows.Forms.AutoValidate.EnableAllowFocusChange;
            this.Controls.Add(this.plotbox);
            this.Controls.Add(this.actorsbox);
            this.Controls.Add(this.genrebox);
            this.Controls.Add(this.runtimebox);
            this.Controls.Add(this.yearbox);
            this.Controls.Add(this.titlebox);
            this.Controls.Add(this.valuebox);
            this.Controls.Add(this.star);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.search);
            this.Controls.Add(this.button1);
            this.ForeColor = System.Drawing.SystemColors.ControlText;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "FilmSeeker";
            this.ShowInTaskbar = false;
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.star)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox search;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox star;
        private System.Windows.Forms.Label valuebox;
        private System.Windows.Forms.Label plotbox;
        private System.Windows.Forms.Label actorsbox;
        private System.Windows.Forms.Label genrebox;
        private System.Windows.Forms.Label runtimebox;
        private System.Windows.Forms.Label yearbox;
        private System.Windows.Forms.Label titlebox;
    }
}

