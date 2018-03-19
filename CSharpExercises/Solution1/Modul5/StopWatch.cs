using System;

namespace Modul5
{
    public class StopWatch
    {
        DateTime start;
        DateTime stop;

        public StopWatch()
        {
            stop = start = DateTime.Now;
        }

        public void Start()
        {
            start = DateTime.Now;
        }

        public void Stop()
        {
            stop = DateTime.Now;
        }

        public TimeSpan GetElapsedTime()
        {
            return stop - start;
        }
    }
}
