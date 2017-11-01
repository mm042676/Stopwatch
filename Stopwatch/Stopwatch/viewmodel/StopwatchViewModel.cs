using System;
using System.ComponentModel;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace Stopwatch
{
    public partial class StopwatchViewModel : INotifyPropertyChanged
    {
        string TimerTime = "0:00";

        public static void Init() { }

        public event PropertyChangedEventHandler PropertyChanged;

        void OnStartButtonClicked(object sender, EventArgs args)
        {
            TimerTime = "1:00";
        }
    }
}
