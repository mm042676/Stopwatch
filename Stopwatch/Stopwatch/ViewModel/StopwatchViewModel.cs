using System;
using System.ComponentModel;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace Stopwatch.ViewModel
{
    using Model;
    using View;

    class StopwatchViewModel : INotifyPropertyChanged
    {
        public string TimerTime { get; }

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
        }

        public void Reset()
        {
            _StopwatchInstance.Reset();
        }
    }
}
