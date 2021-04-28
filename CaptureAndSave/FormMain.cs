using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CaptureAndSave
{

    public partial class FormMain : Form
    {

        [System.Runtime.InteropServices.DllImport("user32.dll")]
        private static extern IntPtr FindWindow(string lpClassName, string lpWindowName);

        [System.Runtime.InteropServices.DllImport("user32.dll")]
        private static extern bool SetForegroundWindow(IntPtr hWnd);

        private int CaptureNum;

        public void SendPrintScreenButtonRight(String WindowName)
        {
            IntPtr hHandle = IntPtr.Zero;

            hHandle = FindWindow(null, WindowName);
            if (hHandle != IntPtr.Zero)
            {
                SetForegroundWindow(hHandle);
                if (checkBoxEnableMouseClick.Checked) 
                    ClickOnPointTool.ClickOnPoint(hHandle, new Point { X = int.Parse(textX.Text), Y = int.Parse(textY.Text) });
                SendKeys.SendWait(textBoxCommands.Text);
                SendKeys.Flush();                
            }
        }
        public FormMain()
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

        private void SendKeysAndCapture()
        {           
            SendPrintScreenButtonRight(cboWindows.Text);
            Thread.Sleep(int.Parse(numericUpDownTimeBeforeCapture.Value.ToString()));
            if (Clipboard.ContainsImage() == true)
            {
                Clipboard.GetImage().Save(textDir.Text + @"\" + textFilename.Text + textNumber.Text.ToString().PadLeft(4, '0') + @".png", System.Drawing.Imaging.ImageFormat.Png);
                textNumber.Text = (int.Parse(textNumber.Text) + 1).ToString();
            }
            CaptureNum = CaptureNum + 1;
            labelCaptures.Text = "Captures: " + CaptureNum.ToString();
            if (CaptureNum == numericUpDown1.Value) buttonStop_Click(null, null);
        }

        private void buttonSendkeys_Click(object sender, EventArgs e)
        {
            IntPtr zero = IntPtr.Zero;
            zero = FindWindow(null, cboWindows.Text);
            if (cboWindows.Text == "" || zero == IntPtr.Zero)
            {
                MessageBox.Show("Window does not exist.");
                return;
            }

            CaptureNum = 0;
            timerCapture.Interval = int.Parse(numericUpDown2.Value.ToString())+int.Parse(numericUpDownTimeBeforeCapture.Value.ToString());
            buttonStop.Enabled = true;
            buttonSendkeys.Enabled = false;
            groupBox1.Enabled = false;

            timerCapture.Start();

        }

        private void buttonRefresh_Click(object sender, EventArgs e)
        {
            cboWindows.Items.Clear();
            GetTaskWindows();
        }

        private void buttonStop_Click(object sender, EventArgs e)
        {
            timerCapture.Stop();
            buttonStop.Enabled = false;
            buttonSendkeys.Enabled = true;
            groupBox1.Enabled = true;
        }

        private void timerCapture_Tick(object sender, EventArgs e)
        {            
            SendKeysAndCapture();
        }
    }
}
