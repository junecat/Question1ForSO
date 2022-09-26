using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FullScreenWB
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            Shown += Form1_Shown;
        }


        private void Form1_Shown(object sender, EventArgs e)
        {
            WebBrowser wb = new WebBrowser();
            Controls.Add(wb);
            wb.Dock = DockStyle.Fill;
            wb.Navigate(new Uri("https://junecat.ru/Storage/oth/BackgroundLoad.html"));
        }
    }
}
