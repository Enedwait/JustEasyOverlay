using JustEasyOverlay.WinForms.Controllers;
using JustEasyOverlay.WinForms.Forms;
using JustEasyOverlay.WinForms.Helpers;

namespace JustEasyOverlay.WinForms.Contexts
{
    internal sealed class TrayContext : ApplicationContext
    {
        private OverlayController _overlayController;
        private ContextMenuStrip _menu;
        private NotifyIcon _notifyIcon;
        private MainForm _mainForm;

        public bool IsInitialized { get; private set; }
        public NotifyIcon NotifyIcon => _notifyIcon;

        public TrayContext(OverlayController overlayController)
        {
            this._overlayController = overlayController;
        }

        public void Init()
        {
            if (IsInitialized) return;

            ToolStripMenuItem toggleItem = new ToolStripMenuItem();
            toggleItem.Text = "Show / Hide Overlay";
            toggleItem.Click += OnToggleClicked;

            ToolStripMenuItem aboutItem = new ToolStripMenuItem();
            aboutItem.Text = "About";
            aboutItem.Click += OnAboutClicked;

            ToolStripMenuItem exitItem = new ToolStripMenuItem();
            exitItem.Text = "Exit";
            exitItem.Click += OnExitClicked;

            _menu = new ContextMenuStrip();
            _menu.Items.Add(toggleItem);
            _menu.Items.Add(aboutItem);
            _menu.Items.Add(exitItem);

            _notifyIcon = new NotifyIcon
            {
                Icon = Properties.Resources.JustEasyOverlayIcon, //SystemIcons.Application,
                Text = AssemblyHelper.ApplicationTitleWithVersion,
                ContextMenuStrip = _menu,
                Visible = true,
            };

            _notifyIcon.DoubleClick += OnNotifyIconDoubleClicked;

            IsInitialized = true;
        }

        private void OnToggleClicked(object? sender, EventArgs e)
        {
            _overlayController.ShowOrHide();
        }

        private void OnAboutClicked(object? sender, EventArgs e)
        {
            if (_mainForm == null)
            {
                _mainForm = new MainForm();
                _mainForm.FormClosed += OnMainFormClosed;
            }
            
            _mainForm.Show();
        }

        private void OnMainFormClosed(object? sender, FormClosedEventArgs e)
        {
            _mainForm = null;
        }

        private void OnExitClicked(object? sender, EventArgs e)
        {
            Application.Exit();
        }

        private void OnNotifyIconDoubleClicked(object? sender, EventArgs e)
        {
            _overlayController.ShowOrHide();
        }

        protected override void ExitThreadCore()
        {
            _notifyIcon.Visible = false;
            _notifyIcon.Dispose();
            _menu.Dispose();
            base.ExitThreadCore();
        }

        protected override void OnMainFormClosed(object? sender, EventArgs e)
        {
            base.OnMainFormClosed(sender, e);
        }
    }
}
