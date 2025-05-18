using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GenshinOledHelper
{
    public partial class FormOverlay : Form
    {
        /// <summary>
        /// 写jsx写的
        /// </summary>
        public struct FormOverlayProps
        {
            public int InitialLeft { get; set; }
            public int InitialTop { get; set; }
            public int InitialWidth { get; set; }
            public int InitialHeight { get; set; }
            public string UidField { get; set; }
        }

        private static FormOverlay _instance;

        private FormOverlayProps _props;

        private FormOverlay(FormOverlayProps props)
        {
            InitializeComponent();
            _props = props;
        }

        public static bool TryRetrieveInstance(out FormOverlay form)
        {
            if (_instance == null)
            {
                form = null;
                return false;
            }
            else if (_instance.Disposing || _instance.IsDisposed)
            {
                form = null;
                return false;
            }
            form = _instance;
            return true;
        }


        public static void Create(FormOverlayProps props)
        {
            if (TryRetrieveInstance(out var form))
            {
                try
                {
                    form.ApplyProps(props);
                    form.Show();
                }
                catch
                {
                    // 也许除了 Disposed 还有别的异常状态？
                    form = null;
                    Create(props);
                }
                return;
            }
            _instance = new FormOverlay(props);
            _instance.Show();
            _instance.ApplyProps(props);
        }

        private void ApplyProps(FormOverlayProps props)
        {
            _props = props;
            labelUid.Text = _props.UidField;
            Left = _props.InitialLeft;
            Top = _props.InitialTop;
            Width = _props.InitialWidth;
            Height = _props.InitialHeight;
            BackColor = Color.Black;
            labelUid.ForeColor = Color.FromArgb(unchecked((int) 0xff242424));
            labelUid.Left = 0;
            labelUid.Top = 0;
            labelUid.Height = Height;
            labelUid.Width = Width;
            timerViewSwitcher.Enabled = true;
            timerViewSwitcher.Interval = 10000;
        }

        private void FormOverlay_Load(object sender, EventArgs e)
        {
        }

        private void timerViewSwitcher_Tick(object sender, EventArgs e)
        {
            if (labelUid.Left == 0)
            {
                labelUid.Left = Width / 2;
            }
            else
            {
                labelUid.Left = 0;
            }
        }
    }
}
