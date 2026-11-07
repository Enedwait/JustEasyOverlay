using System.Diagnostics;

namespace JustEasyOverlay.WinForms.Helpers
{
    internal static class LinkHelper
    {
        public static void OnLinkClicked(this LinkLabelLinkClickedEventArgs e, object sender)
        {
            if (sender is LinkLabel linkLabel)
            {
                linkLabel.Tag?.ToString().OpenAsURL();
                if (e.Link != null)
                    e.Link.Visited = true;
            }
        }

        public static void OpenAsURL(this string url)
        {
            if (string.IsNullOrWhiteSpace(url)) return;

            try
            {
                ProcessStartInfo processStartInfo = new ProcessStartInfo(url)
                {
                    UseShellExecute = true,
                };
                Process.Start(processStartInfo);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex);
            }
        }
    }
}
