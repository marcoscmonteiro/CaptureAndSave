using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CaptureAndSave
{

    public partial class Form1 : Form
    {

        [System.Runtime.InteropServices.DllImport("user32.dll")]
        private static extern IntPtr FindWindow(string lpClassName, string lpWindowName);

        [System.Runtime.InteropServices.DllImport("user32.dll")]
        private static extern bool SetForegroundWindow(IntPtr hWnd);

        private bool boolStop = false;

        public void SendPrintScreenButtonRight(String WindowName)
        {
            IntPtr zero = IntPtr.Zero;

            zero = FindWindow(null, WindowName);
            if (zero != IntPtr.Zero)
            {
                SetForegroundWindow(zero);
                SendKeys.SendWait(textBoxCommands.Text);
                SendKeys.Flush();
            }
        }
        public Form1()
        {
            InitializeComponent();
            GetTaskWindows();
            textDir.Text = Environment.GetFolderPath(Environment.SpecialFolder.UserProfile) + "\\Downloads";
        }

        private void GetTaskWindows()
        {
            // Get the desktopwindow handle
            int nDeshWndHandle = NativeWin32.GetDesktopWindow();
            // Get the first child window
            int nChildHandle = NativeWin32.GetWindow(nDeshWndHandle, NativeWin32.GW_CHILD);

            while (nChildHandle != 0)
            {
                //If the child window is this (SendKeys) application then ignore it.
                if (nChildHandle == this.Handle.ToInt32())
                {
                    nChildHandle = NativeWin32.GetWindow(nChildHandle, NativeWin32.GW_HWNDNEXT);
                }

                // Get only visible windows
                if (NativeWin32.IsWindowVisible(nChildHandle) != 0)
                {
                    StringBuilder sbTitle = new StringBuilder(1024);
                    // Read the Title bar text on the windows to put in combobox
                    NativeWin32.GetWindowText(nChildHandle, sbTitle, sbTitle.Capacity);
                    String sWinTitle = sbTitle.ToString();
                    {
                        if (sWinTitle.Length > 0)
                        {
                            cboWindows.Items.Add(sWinTitle);
                        }
                    }
                }
                // Look for the next child.
                nChildHandle = NativeWin32.GetWindow(nChildHandle, NativeWin32.GW_HWNDNEXT);
            }
        }

        private void buttonSendkeys_Click(object sender, EventArgs e)
        {
            if (cboWindows.Text == "") return;
            IntPtr zero = IntPtr.Zero;            
            zero = FindWindow(null, cboWindows.Text);
            if (zero == IntPtr.Zero) return;

            buttonStop.Enabled = true;
            buttonSendkeys.Enabled = false;
            boolStop = false;
            for (int i = 1; i<= numericUpDown1.Value; i++)
            {
                SendPrintScreenButtonRight(cboWindows.Text);
                if (Clipboard.ContainsImage() == true)
                {
                    Clipboard.GetImage().Save(textDir.Text + @"\" + textFilename.Text + textNumber.Text.ToString().PadLeft(4, '0') + @".png", System.Drawing.Imaging.ImageFormat.Png);
                    textNumber.Text = (int.Parse(textNumber.Text) + 1).ToString();
                }
                Thread.Sleep(int.Parse(numericUpDown2.Value.ToString()));
                Application.DoEvents();
                if (boolStop) break;
            }
            buttonStop.Enabled = false;
            buttonSendkeys.Enabled = true;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            cboWindows.Items.Clear();
            GetTaskWindows();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void buttonStop_Click(object sender, EventArgs e)
        {
            boolStop = true;
        }
    }
}
