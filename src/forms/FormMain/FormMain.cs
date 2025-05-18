using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GenshinOledHelper
{
    public partial class FormMain : Form
    {
        private static readonly int ReferencedScreenWidth = 3840;
        private static readonly int ReferencedScreenHeight = 2160;
        private static readonly int OverlayWidth = 600;
        private static readonly int OverlayHeight = 64;

        public FormMain()
        {
            InitializeComponent();
            SynchronizationUtils.RunOnUiThreadWhenReady(ViewWillAppear);
            WindowsUtils.OnDuplicatedInstance(() =>
            {
                if (WindowState == FormWindowState.Minimized)
                {
                    Show();
                    WindowState = FormWindowState.Normal;
                }
            });
        }

        private void ViewWillAppear()
        {
            textBoxUid.Focus();
        }

        private void FormMain_Load(object sender, EventArgs e)
        {
            // 《ViewWillAppear》
        }
        private void FormMain_FormClosed(object sender, FormClosedEventArgs e)
        {
            WindowsUtils.ExitApplication();
        }

        private void StartOverlay(string uidField, string screenWidthScale, string screenHeightScale)
        {
            if (!int.TryParse(screenWidthScale, out var widthScale) || !int.TryParse(screenHeightScale, out var heightScale))
            {
                MessageBox.Show("宽度和高度比例应当为大于 0 的数字~", AppDomain.CurrentDomain.FriendlyName,
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            int userScreenWidth = ReferencedScreenWidth * widthScale;
            int userScreenHeight = ReferencedScreenHeight * heightScale;
            int userOverlayWidth = OverlayWidth * widthScale;
            int userOverlayHeight = OverlayHeight * heightScale;
            int userOverlayLeft = userScreenWidth - userOverlayWidth;
            int userOverlayTop = userScreenHeight - userOverlayHeight;

            FormOverlay.Create(new FormOverlay.FormOverlayProps()
            {
                InitialLeft = userOverlayLeft,
                InitialTop = userOverlayTop,
                InitialWidth = userOverlayWidth,
                InitialHeight = userOverlayHeight,
                UidField = uidField,
            });
        }

        private void buttonStartOverlay_Click(object sender, EventArgs e)
        {
            string uid = textBoxUid.Text;
            string screenWidthScale = textBoxScreenWidthScale.Text.Trim();
            string screenHeightScale = textBoxScreenHeightScale.Text.Trim();

            if (uid.Length == 0 || screenWidthScale.Length == 0 || screenHeightScale.Length == 0)
            {
                MessageBox.Show("UID, 宽度和高度比例必填~", AppDomain.CurrentDomain.FriendlyName, 
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            StartOverlay(uid, screenWidthScale, screenHeightScale);
        }
    }
}
