namespace yenimayin
{
    partial class Form3
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form3));
            this.label1 = new System.Windows.Forms.Label();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.lblskor = new System.Windows.Forms.Label();
            this.txtskor = new System.Windows.Forms.TextBox();
            this.txtsure = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(62, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Kalan Süre:";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.Location = new System.Drawing.Point(12, 74);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(683, 618);
            this.flowLayoutPanel1.TabIndex = 2;
            // 
            // lblskor
            // 
            this.lblskor.AutoSize = true;
            this.lblskor.Location = new System.Drawing.Point(12, 41);
            this.lblskor.Name = "lblskor";
            this.lblskor.Size = new System.Drawing.Size(35, 13);
            this.lblskor.TabIndex = 3;
            this.lblskor.Text = "Skor :";
            // 
            // txtskor
            // 
            this.txtskor.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtskor.ForeColor = System.Drawing.Color.Black;
            this.txtskor.Location = new System.Drawing.Point(86, 34);
            this.txtskor.Name = "txtskor";
            this.txtskor.ReadOnly = true;
            this.txtskor.Size = new System.Drawing.Size(27, 20);
            this.txtskor.TabIndex = 4;
            // 
            // txtsure
            // 
            this.txtsure.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtsure.ForeColor = System.Drawing.Color.Black;
            this.txtsure.Location = new System.Drawing.Point(86, 7);
            this.txtsure.Name = "txtsure";
            this.txtsure.ReadOnly = true;
            this.txtsure.Size = new System.Drawing.Size(27, 20);
            this.txtsure.TabIndex = 4;
            // 
            // Form3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(707, 704);
            this.Controls.Add(this.txtsure);
            this.Controls.Add(this.txtskor);
            this.Controls.Add(this.lblskor);
            this.Controls.Add(this.flowLayoutPanel1);
            this.Controls.Add(this.label1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form3";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Turan ÜNLÜER ";
            this.Load += new System.EventHandler(this.Form3_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        public System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.Label lblskor;
        public System.Windows.Forms.TextBox txtskor;
        public System.Windows.Forms.TextBox txtsure;

    }
}