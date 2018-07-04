using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WMPLib;


namespace yenimayin
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }
        Form3 frm3 = new Form3();
        int skor = 0;
        void dosyayaz()
        {
            StreamWriter dosyayaz = File.AppendText(Application.StartupPath + "skorlar.txt");
            dosyayaz.WriteLine(txtisim.Text + "=>" + frm3.txtskor.Text);
            dosyayaz.Close();

        }
        void Doldur(int mayinSayisi, int Satir, int Sutun)
        {

            frm3.flowLayoutPanel1.Height = Convert.ToInt32(txtSutun.Text) * 50;
            frm3.flowLayoutPanel1.Width = Convert.ToInt32(txtSatir.Text) * 50;
            frm3.flowLayoutPanel1.Controls.Clear();
            int[] mayins = new int[mayinSayisi];
            Random rnd = new Random();


            for (int i = 0; i < mayinSayisi; i++)
            {
                int sec = rnd.Next(0, Satir * Sutun);
                if (mayins.Contains(sec))
                {
                    i--;
                    continue;

                }
                mayins[i] = sec;
            }

            for (int i = 0; i < Satir * Sutun; i++)
            {
                Button btn = new Button();
                btn.Height = 50;
                btn.Width = 50;
                btn.Margin = new Padding(0);
                btn.Tag = mayins.Contains(i);
                btn.Click += btn_Click;
                frm3.flowLayoutPanel1.Controls.Add(btn);
            }

        }

        void btn_Click(object sender, EventArgs e)
        {
            WMPLib.WindowsMediaPlayer boom = new WindowsMediaPlayer();
            Button tiklanan = (Button)sender;

            if ((bool)tiklanan.Tag == true)
            {
                tiklanan.BackgroundImage = Image.FromFile("kirmizi.png");
                player.controls.stop();
                boom.URL = "boom.wav";
                boom.controls.play();
                OyunBitir();
            }

            else
            {
                skor++;
                tiklanan.BackColor = Color.Green;
                frm3.txtskor.Text = skor.ToString();
            }
        }
        void OyunBitir()
        {
            foreach (Button item in frm3.flowLayoutPanel1.Controls)
            {
                bool durum = (bool)item.Tag;
                if (durum)
                {
                    item.BackgroundImage = Image.FromFile("kirmizi.png");
                    timer1.Stop();

                }

                else
                {
                    item.BackColor = Color.Green;
                }
            }
            dosyayaz();
            DialogResult result = MessageBox.Show("Oyun Bitti!! \nYeniden Oynamak İstermisiniz!!", "Yeniden Oyna!!", MessageBoxButtons.YesNo);
            if (result == DialogResult.Yes)
            {
                player.controls.play();
                frm3.Hide();
                this.Show();
                zorluk = 0;
                zaman = 0;
                skor = 0;
                frm3.txtskor.Text = "";
            }
            else
            {
                MessageBox.Show("Oyun Kapatılacak!!!");
                frm3.Close();
                this.Close();


            }
        }
        int zorluk = 0;
        int zaman = 0;
        private void btnOyunuBaslat_Click(object sender, EventArgs e)
        {
            if (!radioKolay.Checked && !radioOrta.Checked && !radioZor.Checked)
                MessageBox.Show("Zorluk Seviyesi Seçiniz!!");
            else if (radioKolay.Checked == true)
            {
                zorluk += 5;
                zaman += 60;
                Doldur(zorluk, Convert.ToInt32(txtSatir.Text), Convert.ToInt32(txtSutun.Text));
                this.Hide();
                frm3.Show();
                timer1.Start();
            }
            else if (radioOrta.Checked == true)
            {
                zorluk += 10;
                zaman += 30;
                Doldur(zorluk, Convert.ToInt32(txtSatir.Text), Convert.ToInt32(txtSutun.Text));
                this.Hide();
                frm3.Show();
                timer1.Start();
            }
            else if (radioZor.Checked == true)
            {
                zorluk += 15;
                zaman += 15;
                Doldur(zorluk, Convert.ToInt32(txtSatir.Text), Convert.ToInt32(txtSutun.Text));
                this.Hide();
                frm3.Show();
                timer1.Start();
            }

        }



        private void txtSutun_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
        }

        private void txtSatir_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
        }

        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsLetter(e.KeyChar) && !char.IsControl(e.KeyChar)
                 && !char.IsSeparator(e.KeyChar);
        }



        private void timer1_Tick(object sender, EventArgs e)
        {
            zaman--;
            frm3.txtsure.Text = zaman.ToString();
            if (zaman == 0)
            {
                timer1.Stop();
                DialogResult result = MessageBox.Show("Oyun Bitti!! \nYeniden Oynamak İstermisiniz!!", "Yeniden Oyna!!", MessageBoxButtons.YesNo);
                if (result == DialogResult.Yes)
                {
                    player.controls.play();
                    frm3.Hide();
                    this.Show();
                    zorluk = 0;
                    zaman = 0;
                    skor = 0;
                    frm3.txtskor.Text = "";
                }
                else 
                {
                    MessageBox.Show("Oyun Kapatılacak!!!");
                    frm3.Close();
                    this.Close();

                }
           }
        }

        private void btnSkor_Click(object sender, EventArgs e)
        {
            Form4 frm4 = new Form4();
            frm4.Show();
            StreamReader skor = new StreamReader(Application.StartupPath + "skorlar.txt");
            frm4.txtskorpencere.Text = skor.ReadToEnd();
            skor.Close();

        }
        WMPLib.WindowsMediaPlayer player = new WindowsMediaPlayer();
        public void Form2_Load(object sender, EventArgs e)
        {
            player.URL = "form2.mp3";
            player.controls.play();
        }
    }
}
