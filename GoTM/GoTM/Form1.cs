using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GoTM
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            webBrowser1.Url = new System.Uri("https://translate.google.com.ar/") ;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (this.TopMost == true)
            {
                button1.BackgroundImage = Resource1.icons8_pin_filled_50;
                this.TopMost = false;
            }else
	        {
                button1.BackgroundImage = Resource1.icons8_pin_filled_50__1_;
                this.TopMost = true;
            }
            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            AcercaDe ventanaAcerca = new AcercaDe();
            ventanaAcerca.Show();
        }
    }
}
