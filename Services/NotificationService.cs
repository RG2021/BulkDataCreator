using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Mockit.Services
{
    public class NotificationService : IDisposable
    {
        private readonly NotifyIcon _notifyIcon;

        public NotificationService(string tooltip = "XrmToolBox Tool Notification")
        {
            _notifyIcon = new NotifyIcon
            {
                Visible = true,
                Icon = SystemIcons.Information,
                Text = tooltip
            };
        }
        public void ShowInfo(string message, string title = "Information", int durationMs = 3000)
            => ShowNotification(title, message, ToolTipIcon.Info, durationMs);

        public void ShowWarning(string message, string title = "Warning", int durationMs = 3000)
            => ShowNotification(title, message, ToolTipIcon.Warning, durationMs);

        public void ShowError(string message, string title = "Error", int durationMs = 4000)
            => ShowNotification(title, message, ToolTipIcon.Error, durationMs);

        public void ShowSuccess(string message, string title = "Success", int durationMs = 3000)
            => ShowNotification(title, message, ToolTipIcon.Info, durationMs);

        public void ShowProgress(string message, string title = "In Progress")
            => ShowNotification(title, message, ToolTipIcon.None, 1000);

        private void ShowNotification(string title, string message, ToolTipIcon icon, int durationMs)
        {
            _notifyIcon.BalloonTipTitle = title;
            _notifyIcon.BalloonTipText = message;
            _notifyIcon.BalloonTipIcon = icon;
            _notifyIcon.ShowBalloonTip(durationMs);
        }

        public void Dispose()
        {
            _notifyIcon.Visible = false;
            _notifyIcon.Dispose();
        }
    }
}
