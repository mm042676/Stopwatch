using System;
using System.ComponentModel;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace Stopwatch.ViewModel
{
    class StopwatchViewModel : INotifyPropertyChanged
    {
        private string _TimerTime;
        private Stopwatch _StopwatchInstance = new Stopwatch();

        public StopwatchViewModel()
        {
            _TimerTime = "0:00";
        }

        public event PropertyChangedEventHandler PropertyChanged;

        void OnStartButtonClicked(object sender, EventArgs args)
        {
            if (_StopwatchInstance.IsRunning())
        }
    }
}
