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

namespace yenimayin
{
    public partial class Form4 : Form
    {
        public Form4()
        {
            InitializeComponent();
        }

        Random rnd = new Random();
        private void Form4_Load(object sender, EventArgs e)
        {
           
        }

        private void renk_Tick(object sender, EventArgs e)
        {
            pcbox.BackColor = Color.FromArgb(rnd.Next(0, 255), rnd.Next(0, 255), rnd.Next(0, 255));
        }
       
    }
}
