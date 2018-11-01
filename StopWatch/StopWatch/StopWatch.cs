using System;

namespace StopWatch
{
    public class StopWatch
    {
        private DateTime StartTime { get; set; }
        private DateTime EndTime { get; set; }
        private bool _isRunning;

        public void Start()
        {
            if (_isRunning == true)
                throw new InvalidOperationException("Stopwatch in operation");
            else
            {
                StartTime = DateTime.Now;
                _isRunning = true;
            }
        }

        public void Stop()
        {
            if (!_isRunning)
                throw new InvalidOperationException("Stopwatch not running");
            else
            {
                EndTime = DateTime.Now;
                _isRunning = false;
            }
        }

        public TimeSpan Result()
        {
            var timeSpan = EndTime - StartTime;
            return timeSpan;
        }

    }
}
