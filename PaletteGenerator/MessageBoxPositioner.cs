using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PaletteGenerator
{
    public static class MessageBoxPositioner
    {
        private const int WH_CBT = 5;
        private const int HCBT_ACTIVATE = 5;
        private static HookProc _hookProc;
        private static IntPtr _hHook;

        private delegate IntPtr HookProc(int nCode, IntPtr wParam, IntPtr lParam);

        [DllImport("user32.dll")]
        private static extern IntPtr SetWindowsHookEx(int idHook, HookProc lpfn, IntPtr hMod, uint dwThreadId);

        [DllImport("user32.dll")]
        private static extern bool UnhookWindowsHookEx(IntPtr hhk);

        [DllImport("user32.dll")]
        private static extern IntPtr CallNextHookEx(IntPtr hhk, int nCode, IntPtr wParam, IntPtr lParam);

        [DllImport("user32.dll")]
        private static extern bool SetWindowPos(IntPtr hWnd, IntPtr hWndInsertAfter, int X, int Y, int cx, int cy, uint uFlags);

        private const int SWP_NOZORDER = 0x0004;
        private const int SWP_NOSIZE = 0x0001;

        public static void Show(string message, string caption, int x, int y)
        {
            using (var msgBox = new CustomMessageBox(message, caption))
            {
                msgBox.StartPosition = FormStartPosition.Manual;
                msgBox.Location = new Point(x, y);
                msgBox.ShowDialog();
            }
        }
    }
}
