using System;
using System.Windows.Forms;
using PaletteGenerator.Core.Palettes;
using PaletteGenerator.Core.Colors;

namespace PaletteGenerator
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

        }

        private void Form_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                this.Capture = false; // Отключаем захват мыши
                Message m = Message.Create(this.Handle, 0xA1, new IntPtr(0x2), IntPtr.Zero); // Симулируем перетаскивание
                this.WndProc(ref m); // Передаём сообщение системе
            }
        }


        private void CloseButton_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void MinimizeButton_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Minimized;
        }

        private void TriadPaletteButton_Click(object sender, EventArgs e)
        {
            BasePalette triad = new ContrastTriadPalette();
            TriadPalettePanelDark.BackColor = ClassConverter.FullColorToColor(triad[0]);
            TriadPalettePanelMid.BackColor = ClassConverter.FullColorToColor(triad[1]);
            TriadPalettePanelLight.BackColor = ClassConverter.FullColorToColor(triad[2]);

            TriadPaletteView1.BackColor = ClassConverter.FullColorToColor(triad[0]);
            TriadPaletteView2.BackColor = ClassConverter.FullColorToColor(triad[1]);
            TriadPaletteView3.BackColor = ClassConverter.FullColorToColor(triad[2]);

            TriadLightOnMid.ForeColor = ClassConverter.FullColorToColor(triad[0]);
            TriadLightOnDark.ForeColor = ClassConverter.FullColorToColor(triad[0]);

            TriadMidOnLight.ForeColor = ClassConverter.FullColorToColor(triad[1]);
            TriadMidOnDark.ForeColor = ClassConverter.FullColorToColor(triad[1]);

            TriadDarkOnLight.ForeColor = ClassConverter.FullColorToColor(triad[2]);
            TriadDarkOnMid.ForeColor = ClassConverter.FullColorToColor(triad[2]);
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }
    }
}
