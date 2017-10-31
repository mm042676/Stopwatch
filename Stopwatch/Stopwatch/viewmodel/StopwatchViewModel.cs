using System;
using System.ComponentModel;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace Stopwatch
{
    public class StopwatchViewModel : INotifyPropertyChanged
    {
        string TimerTime = "0:00";

        public event PropertyChangedEventHandler PropertyChanged;

        void OnStartButtonClicked(object sender, EventArgs args)
        {
            TimerTime = "1:00";
        }
    }
}
