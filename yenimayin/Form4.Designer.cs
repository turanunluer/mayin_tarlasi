namespace yenimayin
{
    partial class Form4
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form4));
            this.txtskorpencere = new System.Windows.Forms.TextBox();
            this.renk = new System.Windows.Forms.Timer(this.components);
            this.pcbox = new System.Windows.Forms.PictureBox();
            this.skorlar = new System.Windows.Forms.OpenFileDialog();
            ((System.ComponentModel.ISupportInitialize)(this.pcbox)).BeginInit();
            this.SuspendLayout();
            // 
            // txtskorpencere
            // 
            this.txtskorpencere.Location = new System.Drawing.Point(9, 103);
            this.txtskorpencere.Multiline = true;
            this.txtskorpencere.Name = "txtskorpencere";
            this.txtskorpencere.Size = new System.Drawing.Size(635, 556);
            this.txtskorpencere.TabIndex = 0;
            // 
            // renk
            // 
            this.renk.Enabled = true;
            this.renk.Interval = 80;
            this.renk.Tick += new System.EventHandler(this.renk_Tick);
            // 
            // pcbox
            // 
            this.pcbox.BackColor = System.Drawing.Color.Transparent;
            this.pcbox.BackgroundImage = global::yenimayin.Properties.Resources.skor;
            this.pcbox.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.pcbox.Location = new System.Drawing.Point(9, 12);
            this.pcbox.Name = "pcbox";
            this.pcbox.Size = new System.Drawing.Size(635, 85);
            this.pcbox.TabIndex = 1;
            this.pcbox.TabStop = false;
            // 
            // skorlar
            // 
            this.skorlar.FileName = "openFileDialog1";
            // 
            // Form4
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(648, 668);
            this.Controls.Add(this.pcbox);
            this.Controls.Add(this.txtskorpencere);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form4";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Turan ÜNLÜER";
            this.Load += new System.EventHandler(this.Form4_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pcbox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pcbox;
        private System.Windows.Forms.Timer renk;
        public System.Windows.Forms.OpenFileDialog skorlar;
        public System.Windows.Forms.TextBox txtskorpencere;

    }
}