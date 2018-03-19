using System;

namespace S2L15
{
    public class StopWatch
    {
        // 1-
        private DateTime _start;
        private DateTime _stop;
        private TimeSpan _delta;
        public StopWatch()
        {

        }

        public void Start()
        {
            if (_start > _stop)
            {
                throw (new InvalidOperationException("Not able to start twice!"));
            }
            this._start = DateTime.Now;
        }
        public void Stop()
        {
            this._stop = DateTime.Now;
            this._delta = this._stop - this._start;
        }
        public TimeSpan GetTime()
        {
            return this._delta;
        }
    }
}
