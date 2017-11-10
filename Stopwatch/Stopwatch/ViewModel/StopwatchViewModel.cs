using System;
using System.ComponentModel;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

using Xamarin.Forms;

namespace Stopwatch.ViewModel
{
    using Model;

    class StopwatchViewModel : INotifyPropertyChanged
    {
        public string TimerTime { get; private set; }
   
        private StopwatchModel _StopwatchInstance = new StopwatchModel();

        public StopwatchViewModel()
        {
            TimerTime = "0:00";
        }

        public event PropertyChangedEventHandler PropertyChanged;

        public bool IsRunning()
        {
            return _StopwatchInstance.IsRunning();
        }
        
        public void Stop()
        {
            _StopwatchInstance.Stop();
        }

        public void Start()
        {
            _StopwatchInstance.Start();
            Device.StartTimer(TimeSpan.FromMilliseconds(50), _timerTick);
        }

        public void Reset()
        {
            _StopwatchInstance.Reset();
        }

        private bool _timerTick()
        {
            // System.TimeSpan? elapsed = DateTime.Now.Subtract((_StopwatchInstance.Started);

            TimeSpan? elapsed = DateTime.Now - _StopwatchInstance.Started;
            TimerTime = elapsed.ToString();
            if (_StopwatchInstance.Started == null)
                return false;
            else
                return true;
        }
    }
}
