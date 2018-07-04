namespace yenimayin
{
    partial class Form2
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form2));
            this.btnSkor = new System.Windows.Forms.Button();
            this.btnOyunuBaslat = new System.Windows.Forms.Button();
            this.txtSutun = new System.Windows.Forms.TextBox();
            this.txtSatir = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.radioKolay = new System.Windows.Forms.RadioButton();
            this.radioOrta = new System.Windows.Forms.RadioButton();
            this.radioZor = new System.Windows.Forms.RadioButton();
            this.txtisim = new System.Windows.Forms.TextBox();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.label3 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // btnSkor
            // 
            this.btnSkor.Location = new System.Drawing.Point(12, 678);
            this.btnSkor.Name = "btnSkor";
            this.btnSkor.Size = new System.Drawing.Size(152, 54);
            this.btnSkor.TabIndex = 6;
            this.btnSkor.Text = "Skor Tablosu ";
            this.btnSkor.UseVisualStyleBackColor = true;
            this.btnSkor.Click += new System.EventHandler(this.btnSkor_Click);
            // 
            // btnOyunuBaslat
            // 
            this.btnOyunuBaslat.Location = new System.Drawing.Point(577, 678);
            this.btnOyunuBaslat.Name = "btnOyunuBaslat";
            this.btnOyunuBaslat.Size = new System.Drawing.Size(152, 54);
            this.btnOyunuBaslat.TabIndex = 7;
            this.btnOyunuBaslat.Text = "Oyunu Başlat";
            this.btnOyunuBaslat.UseVisualStyleBackColor = true;
            this.btnOyunuBaslat.Click += new System.EventHandler(this.btnOyunuBaslat_Click);
            // 
            // txtSutun
            // 
            this.txtSutun.Location = new System.Drawing.Point(629, 15);
            this.txtSutun.Name = "txtSutun";
            this.txtSutun.Size = new System.Drawing.Size(100, 20);
            this.txtSutun.TabIndex = 1;
            this.txtSutun.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtSutun_KeyPress);
            // 
            // txtSatir
            // 
            this.txtSatir.Location = new System.Drawing.Point(629, 63);
            this.txtSatir.Name = "txtSatir";
            this.txtSatir.Size = new System.Drawing.Size(100, 20);
            this.txtSatir.TabIndex = 2;
            this.txtSatir.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtSatir_KeyPress);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label1.Font = new System.Drawing.Font("Lithos Pro Regular", 9.749999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(563, 17);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(53, 17);
            this.label1.TabIndex = 2;
            this.label1.Text = "Sütun";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label2.Font = new System.Drawing.Font("Lithos Pro Regular", 9.749999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(563, 65);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(47, 17);
            this.label2.TabIndex = 2;
            this.label2.Text = "Satir";
            // 
            // radioKolay
            // 
            this.radioKolay.AutoSize = true;
            this.radioKolay.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.radioKolay.Font = new System.Drawing.Font("Lithos Pro Regular", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radioKolay.ForeColor = System.Drawing.Color.White;
            this.radioKolay.Location = new System.Drawing.Point(21, 24);
            this.radioKolay.Name = "radioKolay";
            this.radioKolay.Size = new System.Drawing.Size(85, 25);
            this.radioKolay.TabIndex = 3;
            this.radioKolay.TabStop = true;
            this.radioKolay.Text = "Kolay";
            this.radioKolay.UseVisualStyleBackColor = false;
            // 
            // radioOrta
            // 
            this.radioOrta.AutoSize = true;
            this.radioOrta.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.radioOrta.Font = new System.Drawing.Font("Lithos Pro Regular", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radioOrta.ForeColor = System.Drawing.Color.White;
            this.radioOrta.Location = new System.Drawing.Point(21, 52);
            this.radioOrta.Name = "radioOrta";
            this.radioOrta.Size = new System.Drawing.Size(74, 25);
            this.radioOrta.TabIndex = 4;
            this.radioOrta.TabStop = true;
            this.radioOrta.Text = "Orta";
            this.radioOrta.UseVisualStyleBackColor = false;
            // 
            // radioZor
            // 
            this.radioZor.AutoSize = true;
            this.radioZor.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.radioZor.Font = new System.Drawing.Font("Lithos Pro Regular", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radioZor.ForeColor = System.Drawing.Color.White;
            this.radioZor.Location = new System.Drawing.Point(21, 80);
            this.radioZor.Name = "radioZor";
            this.radioZor.Size = new System.Drawing.Size(64, 25);
            this.radioZor.TabIndex = 5;
            this.radioZor.TabStop = true;
            this.radioZor.Text = "Zor";
            this.radioZor.UseVisualStyleBackColor = false;
            // 
            // txtisim
            // 
            this.txtisim.Location = new System.Drawing.Point(293, 268);
            this.txtisim.Name = "txtisim";
            this.txtisim.Size = new System.Drawing.Size(231, 20);
            this.txtisim.TabIndex = 0;
            this.txtisim.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox1_KeyPress);
            // 
            // timer1
            // 
            this.timer1.Interval = 1000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label3.Font = new System.Drawing.Font("Lithos Pro Regular", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(228, 268);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(50, 21);
            this.label3.TabIndex = 2;
            this.label3.Text = "İSİM";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pictureBox1.Image = global::yenimayin.Properties.Resources.giphy;
            this.pictureBox1.Location = new System.Drawing.Point(0, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(741, 744);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 5;
            this.pictureBox1.TabStop = false;
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(741, 744);
            this.Controls.Add(this.txtisim);
            this.Controls.Add(this.radioZor);
            this.Controls.Add(this.radioOrta);
            this.Controls.Add(this.radioKolay);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtSatir);
            this.Controls.Add(this.txtSutun);
            this.Controls.Add(this.btnOyunuBaslat);
            this.Controls.Add(this.btnSkor);
            this.Controls.Add(this.pictureBox1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form2";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Turan ÜNLÜER Mine Sweeper";
            this.Load += new System.EventHandler(this.Form2_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnSkor;
        private System.Windows.Forms.Button btnOyunuBaslat;
        private System.Windows.Forms.TextBox txtSutun;
        private System.Windows.Forms.TextBox txtSatir;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        public System.Windows.Forms.RadioButton radioKolay;
        public System.Windows.Forms.RadioButton radioOrta;
        public System.Windows.Forms.RadioButton radioZor;
        private System.Windows.Forms.TextBox txtisim;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}