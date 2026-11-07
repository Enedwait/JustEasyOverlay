using JustEasyOverlay.WinForms.Helpers;

namespace JustEasyOverlay.WinForms.Forms
{
    internal sealed partial class OverlayForm : Form
    {
        public OverlayForm(OverlayFormCreationArgs creationArgs)
        {
            this.FormBorderStyle = FormBorderStyle.None;
            this.StartPosition = FormStartPosition.Manual;
            this.Bounds = creationArgs.Bounds;
            this.ShowInTaskbar = false;
            this.BackColor = Color.Black;
            this.Opacity = creationArgs.Opacity;
            this.WindowState = FormWindowState.Maximized;
        }

        public void SendBehind()
        {
            User32PInvokeHelper.SetWindowPos(
                Handle, NativeWindowHelper.HWND_BOTTOM,
                0, 0, 0, 0,
                NativeWindowHelper.SWP_NOMOVE | NativeWindowHelper.SWP_NOSIZE | NativeWindowHelper.SWP_NOACTIVATE);
        }

        protected override CreateParams CreateParams
        {
            get
            {
                CreateParams createParams = base.CreateParams;
                createParams.ExStyle |= NativeWindowHelper.WS_EX_TOOLWINDOW | NativeWindowHelper.WS_EX_NOACTIVATE;
                return createParams;
            }
        }

        protected override void WndProc(ref Message m)
        {
            if (m.Msg == NativeWindowHelper.WM_MOUSEACTIVATE)
            {
                m.Result = (IntPtr)NativeWindowHelper.MA_NOACTIVATEANDEAT;
                return;
            }
            base.WndProc(ref m);
        }

        protected override void OnShown(EventArgs e)
        {
            base.OnShown(e);
            SendBehind();
            this.WindowState = FormWindowState.Maximized;
        }
    }

    internal record OverlayFormCreationArgs(Rectangle Bounds, float Opacity);
}
