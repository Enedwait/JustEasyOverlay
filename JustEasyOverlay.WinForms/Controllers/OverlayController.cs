using JustEasyOverlay.WinForms.Forms;

namespace JustEasyOverlay.WinForms.Controllers
{
    internal sealed class OverlayController
    {
        private List<OverlayForm> _forms;

        public bool IsInitialized { get; private set; }
        public bool HasOverlays => IsInitialized && _forms != null && _forms.Count > 0;
        public bool IsOverlayVisible => HasOverlays && _forms.All(f => f.Visible);
        public OverlayForm[] Forms => _forms?.ToArray();
        public OverlayForm First => HasOverlays ? _forms[0] : null;

        public OverlayController()
        {
            _forms = new List<OverlayForm>(16);
        }
        
        public void Init(OverlayFormCreationArgs creationArgs)
        {
            if (IsInitialized) return;

            _forms = Screen.AllScreens
                .Select(s => new OverlayForm(new OverlayFormCreationArgs(s.Bounds, creationArgs.Opacity)))
                .ToList();

            IsInitialized = true;
        }

        public void Recreate(OverlayFormCreationArgs creationArgs)
        {
            Close();
            Init(creationArgs);
        }

        public void ShowOrHide()
        {
            if (IsOverlayVisible) Hide();
            else Show();
        }

        public void Show()
        {
            if (!HasOverlays) return;
            foreach (var form in _forms)
                form.Show();
        }

        public void SendBehind()
        {
            if (!HasOverlays) return;
            foreach (var form in _forms)
                form.SendBehind();
        }

        public void Hide()
        {
            if (!HasOverlays) return;
            foreach (var form in _forms)
                form.Hide();
        }

        public void Close()
        {
            if (!HasOverlays) return;
            foreach (var form in _forms)
                form.Close();

            _forms.Clear();
            IsInitialized = false;
        }
    }
}
