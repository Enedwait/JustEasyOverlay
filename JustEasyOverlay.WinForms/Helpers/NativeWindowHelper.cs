namespace JustEasyOverlay.WinForms.Helpers
{
    public static class NativeWindowHelper
    {
        public const int WS_EX_TOOLWINDOW = 0x00000080;
        public const int WS_EX_NOACTIVATE = 0x08000000;

        public static readonly IntPtr HWND_BOTTOM = new IntPtr(1);
        public static readonly IntPtr HWND_TOPMOST = new IntPtr(-1);

        public const uint SWP_NOMOVE = 0x0002;
        public const uint SWP_NOSIZE = 0x0001;
        public const uint SWP_NOACTIVATE = 0x0010;

        public const int WM_MOUSEACTIVATE = 0x0021;
        public const int MA_NOACTIVATEANDEAT = 0x0004;
    }
}
