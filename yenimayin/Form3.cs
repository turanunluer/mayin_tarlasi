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
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }
        
        private void Form3_Load(object sender, EventArgs e)
        {
            this.Width = flowLayoutPanel1.Width + 30;
            this.Height = flowLayoutPanel1.Height + 120;
        }
       

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
