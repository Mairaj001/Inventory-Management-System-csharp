﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Runtime.InteropServices;
using System.Windows.Forms;

namespace Inventory_Management_System
{
    public static class MdiProperties
    {
        [DllImport("user32.dll")]
        private static extern int GetWindowLong(IntPtr hWnd, int nIndex);

        [DllImport("user32.dll")]
        private static extern int SetWindowLong(IntPtr hWnd, int nIndex, int dwNewLong);

        [DllImport("user32.dll")]
        private static extern int SetWindowPos(IntPtr hWnd, IntPtr hWndInsertAfter, int X, int Y, int cx, int cy, uint uFlags);

        private const int GWL_EXSTYLE = -20;
        private const int WS_EX_CLIENTEDGE = 0x200;
        private const uint SWP_NOSIZE = 0x0001;
        private const uint SWO_NOACTIVATE = 0x0010;
        private const uint SWP_FRAMECHANGED = 0x20;
        private const uint SWP_NOZORDER = 0x0004;
        private const uint SWP_NOMOVE = 0x0002;
        private const uint SWP_NOOWNERZORDER = 0x0200;

        public static bool SetBevel(this Form form, bool show)
        {
            foreach (Control c in form.Controls)
            {
                MdiClient client = c as MdiClient;
                if (client != null)
                {
                    IntPtr hWnd = client.Handle;
                    if (hWnd != IntPtr.Zero)
                    {
                        int windowLong = GetWindowLong(hWnd, GWL_EXSTYLE);

                        if (show)
                        {
                            windowLong |= WS_EX_CLIENTEDGE; // Add the WS_EX_CLIENTEDGE style
                        }
                        else
                        {
                            windowLong &= ~WS_EX_CLIENTEDGE; // Remove the WS_EX_CLIENTEDGE style
                        }

                        SetWindowLong(hWnd, GWL_EXSTYLE, windowLong);
                        SetWindowPos(hWnd, IntPtr.Zero, 0, 0, 0, 0, SWO_NOACTIVATE | SWP_NOMOVE | SWP_NOSIZE | SWP_NOZORDER | SWP_NOOWNERZORDER | SWP_FRAMECHANGED);

                        return true;
                    }
                }
            }
            return false;
        }
    }
}