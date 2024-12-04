using PaletteGenerator.Core;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PaletteGenerator
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            
        }

        private void Form1_Load(object sender, EventArgs e)
        {
        }

        private void button1_Click(object sender, EventArgs e)
        {
            FullColor low = new FullColor();
            FullColor mid = new FullColor();
            FullColor top = new FullColor();

            Algorithms.Temp.TestRandom(low, mid, top);

            panel1.BackColor = Color.FromArgb(low.RGB.R, low.RGB.G, low.RGB.B);
            panel2.BackColor = Color.FromArgb(mid.RGB.R, mid.RGB.G, mid.RGB.B);
            panel3.BackColor = Color.FromArgb(top.RGB.R, top.RGB.G, top.RGB.B);

            label1.Text = Core.Utility.VisualLuminance.Contrast(mid, low).ToString("F2");
            label2.Text = Core.Utility.VisualLuminance.Contrast(top, low).ToString("F2");
            label3.Text = Core.Utility.VisualLuminance.Contrast(top, mid).ToString("F2");
        }
    }
}
