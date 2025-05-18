using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GenshinOledHelper
{
    internal static class Program
    {
        /// <summary>
        /// 应用程序的主入口点。
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new FormMain());

            // Context 在此时可用
            // https://stackoverflow.com/a/45058021
            if (SynchronizationContext.Current != null)
            {
                SynchronizationManager.Default.NotifyContextReady(SynchronizationContext.Current);
            }
        }
    }
}
