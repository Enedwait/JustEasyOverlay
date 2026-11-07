using System.Runtime.InteropServices;

namespace JustEasyOverlay.WinForms.Helpers
{
    internal static class User32PInvokeHelper
    {
        [DllImport("user32.dll", SetLastError = true)]
        public static extern bool SetWindowPos(IntPtr hWnd, IntPtr hWndInsertAfter, int X, int Y, int cx, int cy, uint uFlags);
    }
}
