using System;
using System.Collections.Generic;
using System.IO;
using System.IO.Pipes;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GenshinOledHelper
{
    internal static class WindowsUtils
    {
        private static bool ShowExitApplication = false;
        private static string PipeName = AppDomain.CurrentDomain.FriendlyName;

        public static void ExitApplication()
        {
            InterruptWaitForConnection();
            Application.Exit();
        }

        private static void InterruptWaitForConnection()
        {
            ShowExitApplication = true;
            using (var fakeClient = new NamedPipeClientStream(PipeName))
            {
                fakeClient.Connect();
            }
        }

        public static void OnDuplicatedInstance(Action callback)
        {
            var client = new NamedPipeClientStream(
                ".", PipeName, PipeDirection.InOut, PipeOptions.Asynchronous);

            // pipe client 若立刻连上了代表有 server 在，意味着重复运行，立刻退出
            // 没连上则没问题~
            try
            {
                client.Connect(1);
                if (client.IsConnected)
                {
                    client.Dispose();
                    client.Close();
                    Environment.Exit(0);
                    return;
                }
            }
            catch (TimeoutException)
            {
                new Thread(() =>
                {
                    // 启动pipe server，遇到任何连接则代表发生了重复运行
                    // 身为现有实例，应当拉起自己~
                    while (!ShowExitApplication)
                    {
                        try
                        {
                            var server = new NamedPipeServerStream(
                                PipeName, PipeDirection.InOut, 1);
                            while (!ShowExitApplication)
                            {
                                server.WaitForConnection();
                                callback();
                            }
                            server.Dispose();
                            server.Close();
                        }
                        catch (Exception)
                        {
                            continue;
                        }
                    }
                }).Start();
            }
        }
    }
}
