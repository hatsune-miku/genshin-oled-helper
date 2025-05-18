using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace GenshinOledHelper
{
    /// <summary>
    /// 大概主线程 UI 是这么拿的吧
    /// </summary>
    internal class SynchronizationManager
    {
        private List<OnContextReady> _delegates = new List<OnContextReady>();

        private static SynchronizationManager _instance;

        public delegate void OnContextReady(SynchronizationContext context);
        public static SynchronizationManager Default
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new SynchronizationManager();
                }
                return _instance;
            }
        }

        private SynchronizationManager() { }

        public void Subscribe(OnContextReady contextReady)
        {
            if (TryRetrieveContext(out var context))
            {
                contextReady(context);
                return;
            }
            _delegates.Add(contextReady);
        }

        public void Unsubscribe(OnContextReady contextReady)
        {
            _delegates.Remove(contextReady);
        }

        public bool TryRetrieveContext(out SynchronizationContext context)
        {
            if (SynchronizationContext.Current == null)
            {
                context = null;
                return false;
            }
            context = SynchronizationContext.Current;
            return true;
        }

        public void NotifyContextReady(SynchronizationContext context)
        {
            for (int i = 0; i < _delegates.Count; i++)
            {
                _delegates[i](context);
            }
        }
    }
}
