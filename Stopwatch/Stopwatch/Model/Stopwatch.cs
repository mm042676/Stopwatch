using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Stopwatch.Model
{
    public partial class StopwatchModel
    {
        private DateTime? _started;

        public void Start()
        {
            _started = DateTime.Now;
        }

        public void Stop()
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

        public bool IsRunning()
        {
            if (_started == null)
                return false;
            else
                return true;
        }
    }
}
