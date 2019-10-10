using System;
using System.Diagnostics;

namespace UtilitiesLib
{
    public class ActionTimer : IDisposable
    {
        private readonly Stopwatch _timer;
        private readonly Action<TimeSpan> _timerFunc;

        public ActionTimer(Action<TimeSpan> timerFunc)
        {
            _timerFunc = timerFunc;
            _timer = new Stopwatch();
            _timer.Start();
        }

        public void Dispose()
        {
            _timerFunc(_timer.Elapsed);
        }
    }
}
