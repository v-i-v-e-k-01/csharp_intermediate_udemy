using System;

namespace Exercise1
{
    public class StopWatch
    {
        private DateTime _startTime;
        private bool _isStarted;

        public void Start()
        {
            _isStarted = true;
            _startTime = DateTime.Now;
        }

        public string Stop()
        {
            try
            {
                if (!_isStarted)
                {
                    throw new InvalidOperationException("Invalid Operation. Stopwatch isnt started.");
                }
                _isStarted = false;
                TimeSpan timeSpent = (DateTime.Now - _startTime);
                return timeSpent.ToString();

            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                return null;
            }

        }

        public void Reset()
        {
            _isStarted = false;
        }
    }
}
