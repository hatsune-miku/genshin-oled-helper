using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GenshinOledHelper
{
    internal static class SynchronizationUtils
    {
        public static void RunOnUiThreadWhenReady(Action callback)
        {
            SynchronizationManager.Default.Subscribe(context =>
            {
                context.Post((_) =>
                {
                    callback();
                }, null);
            });
        }
    }
}
