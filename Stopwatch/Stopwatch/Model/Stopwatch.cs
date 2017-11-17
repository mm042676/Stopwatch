using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Stopwatch.Model
{
    public partial class StopwatchModel
    {
        public DateTime? Started { get; private set; }
        public TimeSpan? SavedTime { get; private set; }

        public void Start()
        {
            Started = DateTime.Now;
        }

        public void Stop()
        {
            // need to fix this - SavedTime is null so the below calculation fails
            SavedTime += DateTime.Now - Started;
            Started = null;
        }

        public void Reset()
        {
            Started = null;
            SavedTime = null;
        }

        public StopwatchModel()
        {
            Reset();
        }

        public bool IsRunning()
        {
            if (Started == null)
                return false;
            else
                return true;
        }
        
    }
}
