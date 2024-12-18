using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Net.Mime.MediaTypeNames;
using System.Windows.Forms;

namespace PaletteGenerator
{
    public class CustomMessageBox : Form
    {
        public CustomMessageBox(string message, string caption)
        {
            Text = caption;
            Size = new Size(250, 190);
            FormBorderStyle = FormBorderStyle.FixedDialog;
            StartPosition = FormStartPosition.Manual;
            MaximizeBox = false;
            MinimizeBox = false;

            BackColor = Color.White;
            Font = new Font("Roboto", 10);

            var label = new Label
            {
                Text = message,
                Dock = DockStyle.Top,
                TextAlign = ContentAlignment.MiddleCenter,
                Padding = new Padding(10),
                Font = new Font("Roboto", 12, FontStyle.Regular),
                Height = 100
            };

            var buttonOk = new Button
            {
                Text = "OK",
                DialogResult = DialogResult.OK,
                Size = new Size(100, 40),
                BackColor = Color.LightGreen,
                FlatStyle = FlatStyle.Flat,
                Font = new Font("Roboto", 10, FontStyle.Bold),
                Anchor = AnchorStyles.None,
                Location = new Point((250 - 110) / 2, 100)
            };

            Controls.Add(label);
            Controls.Add(buttonOk);

            AcceptButton = buttonOk;
        }
    }
}
