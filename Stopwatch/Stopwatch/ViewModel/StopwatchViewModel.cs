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
        string TimerTime;

        public StopwatchViewModel()
        {
            this.TimerTime = "0:00";
        }

        public event PropertyChangedEventHandler PropertyChanged;

        void OnStartButtonClicked(object sender, EventArgs args)
        {
            TimerTime = "1:00";
        }
    }
}
