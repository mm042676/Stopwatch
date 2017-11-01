using System;
using System.Collections.Generic;
using System.Text;

namespace Stopwatch.model
{
    class StopwatchModel
    {
        private DateTime? _started;

        public void Start ()
        {
            _started = DateTime.Now;
        }

        public void Stop ()
        {
            _started = null;
        }

        public void Reset()
        {
            _started = null;
        }

        public StopwatchModel()
        {
            Reset();
        }
    }
}
