using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MinefieldV2
{
    public partial class Instructions : Form
    {
        public Instructions()
        {
            InitializeComponent();

            //Show video tutorial from Youtube using a webBrowser and adding html code into it
            string html = "<html><head>";
            html += "<meta content='IE=Edge' http-equiv='X-UA-Compatible'/>";
            html += "<iframe id='video' src= 'https://www.youtube.com/embed/6_8uF0JAvlA?controls=0' width='560' height='315' frameborder='0' allow='autoplay' allowfullscreen ></iframe>";
            html += "<body style='background-color: #eeeeee' />";
            html += "</body></html>";
            this.webBrowser1.DocumentText = string.Format(html);
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
