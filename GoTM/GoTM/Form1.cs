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
        System.Uri Uri = new System.Uri("https://translate.google.com.ar/");
        public Form1()
        {
            InitializeComponent();
            webBrowser1.Url = this.Uri ;
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

        private void btn_cambiarTraductor_Click(object sender, EventArgs e)
        {
            
            if ( this.Uri.Host == "translate.google.com.ar")
            {
                this.webBrowser1.Navigate("https://www.bing.com/translator",
                          null,
                          null,
                          "User-Agent:Mozilla/5.0 (Linux; Android 4.2.1; en-us; Nexus 5 Build/JOP40D) AppleWebKit/535.19 (KHTML, like Gecko; googleweblight) Chrome/38.0.1025.166 Mobile Safari/535.19");
                this.Uri = new System.Uri("https://www.bing.com/translator");
                btn_cambiarTraductor.Text = "Cambiar a Google Translate";
            }
            else
            {
                this.Uri = new System.Uri("https://translate.google.com.ar/");
                btn_cambiarTraductor.Text = "Cambiar a Bing Translate";
            }
            webBrowser1.Url = this.Uri;
            
        }
    }
}
