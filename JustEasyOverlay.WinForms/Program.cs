using JustEasyOverlay.WinForms.Contexts;
using JustEasyOverlay.WinForms.Controllers;
using JustEasyOverlay.WinForms.Forms;

namespace JustEasyOverlay.WinForms
{
    internal static class Program
    {
        private static OverlayFormCreationArgs _args;
        private static RegisteredWaitHandle _waitHandle;
        private static EventWaitHandle _activateEvent;

        internal static Guid GUID = new Guid(@"5346C3AD-0A16-412E-9B06-7A7229488705");
        internal static TrayContext TrayContext { get; private set; }
        internal static OverlayController OverlayController { get; private set; }

        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            // To customize application configuration such as set high DPI settings or default font,
            // see https://aka.ms/applicationconfiguration.
            ApplicationConfiguration.Initialize();

            _activateEvent = new EventWaitHandle(false, EventResetMode.AutoReset, $"Global/JustEasyOverlay-Activate");
            using Mutex mutex = new Mutex(true, $"Global/JustEasyOverlay-{{{GUID}}}", out bool isCreated);
            if (!isCreated)
            {
                _activateEvent.Set();
                return;
            }

            Application.ApplicationExit += OnApplicationExit;

            OverlayController = new OverlayController();
            OverlayController.Init(_args = new OverlayFormCreationArgs(Rectangle.Empty, 1f));
            OverlayController.Show();

            _waitHandle = ThreadPool.RegisterWaitForSingleObject(
                _activateEvent,
                RegisterWaitHandleCallback,
                null,
                Timeout.Infinite,
                false);

            TrayContext = new TrayContext(OverlayController);
            TrayContext.Init();

            Application.Run(TrayContext);
        }

        private static void RegisterWaitHandleCallback(object? state, bool timedOut)
        {
            if (OverlayController.First != null)
                OverlayController.First.BeginInvoke(OverlayController.Show);
            else
            {
                OverlayController.Recreate(_args);
                OverlayController.Show();
            }
        }

        private static void OnApplicationExit(object? sender, EventArgs e)
        {
            _waitHandle?.Unregister(null);
            _activateEvent?.Dispose();
            OverlayController?.Close();
        }
    }
}