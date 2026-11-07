using JustEasyOverlay.WinForms.Helpers;

namespace JustEasyOverlay.WinForms.Forms
{
    internal sealed partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();

            this.Text = AssemblyHelper.ApplicationTitleWithVersion;
        }

        private void OnShowOverlayButtonClicked(object sender, EventArgs e)
        {
            Program.OverlayController.Show();
        }

        private void OnSendOverlayBehindButtonClicked(object sender, EventArgs e)
        {
            Program.OverlayController.SendBehind();
        }

        private void OnHideOverlayButtonClicked(object sender, EventArgs e)
        {
            Program.OverlayController.Hide();
        }

        private void OnFormClosed(object sender, FormClosedEventArgs e)
        { }

        private void OnGitHubLinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            e.OnLinkClicked(sender);
        }

        private void OnCloudTipsLinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            e.OnLinkClicked(sender);
        }

        private void OnVKLinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            e.OnLinkClicked(sender);
        }
    }
}
