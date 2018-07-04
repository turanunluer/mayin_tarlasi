using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace yenimayin
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            progressBar1.Increment(4);

            if (progressBar1.Value == 100)
            {
                load.Stop();
                this.Close();
                Form1 frm2 = new Form1();
                frm2.Show();
            }
        }
    }
}
