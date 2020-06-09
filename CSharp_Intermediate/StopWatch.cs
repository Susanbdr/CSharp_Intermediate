using System;

namespace CSharp_Intermediate
{
    public class StopWatch
    {
        private bool _isStarted = false;

        public DateTime StartTime { get; private set; }
        public DateTime EndTime { get; private set; }

        public DateTime Start()
        {
            if(_isStarted)
                throw new InvalidOperationException();

            StartTime = DateTime.Now;
            _isStarted = true;
            
            return StartTime;
        }

        public DateTime Stop()
        {
            if (!_isStarted)
                throw new InvalidOperationException();

            EndTime = DateTime.Now;
            _isStarted = false;

            return EndTime;
        }

        public TimeSpan GetDuration()
        {
            return EndTime - StartTime;
        }


    }
}