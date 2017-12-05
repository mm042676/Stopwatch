using System;
using System.ComponentModel;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Input;

using Xamarin.Forms;

namespace Stopwatch.ViewModel
{
    using Model;

    class StopwatchViewModel : INotifyPropertyChanged
    {
        private string _TimerTime;
        public string TimerTime
        {
            get
            {
                return _TimerTime;
            }
            private set {
                _TimerTime = value;
                NotifyPropertyChanged("TimerTime");
            }
        }
        private string _startStopText;
        public string StartStopText
        {
            get
            {
                return _startStopText;
            }
            private set
            {
                _startStopText = value;
                NotifyPropertyChanged("StartStopText");
            }
        }
        private int _StopwatchFontSize;
        public int StopwatchFontSize
        {
            get
            {
                return _StopwatchFontSize;
            }
            private set
            {
                _StopwatchFontSize = value;
                NotifyPropertyChanged("StopwatchFontSize");
            }
        }
        private int _TimerFontSize;
        public int TimerFontSize
        {
            get
            {
                return _TimerFontSize;
            }
            private set
            {
                _TimerFontSize = value;
                NotifyPropertyChanged("TimerFontSize");
            }
        }
        private StopwatchModel _StopwatchInstance = new StopwatchModel();

        public StopwatchViewModel()
        {
            InitialState();

            ResetCommand = new Command(() =>
            {
                InitialState();
                _StopwatchInstance.Reset();
            });

            StartStopCommand = new Command(() =>
            {
                if (StartStopText == "Start")
                {
                    _StopwatchInstance.Start();
                    Device.StartTimer(TimeSpan.FromMilliseconds(50), _timerTick);
                    StartStopText = "Stop";
                }
                else
                {
                    _StopwatchInstance.Stop();
                    StartStopText = "Start";
                }
            });

        }

        void InitialState()
        {
            TimerTime = "00:00:00.00";
            StartStopText = "Start";
            StopwatchFontSize = 60;
            TimerFontSize = 100;
        }

        public event PropertyChangedEventHandler PropertyChanged;

        public void NotifyPropertyChanged (string propertyName)
        {
            if (PropertyChanged != null)
                PropertyChanged(this, new PropertyChangedEventArgs(propertyName));
        }

        public bool IsRunning()
        {
            return _StopwatchInstance.IsRunning();
        }
        


        private bool _timerTick()
        {

            TimeSpan? elapsed = DateTime.Now - _StopwatchInstance.Started;
            if (_StopwatchInstance.SavedTime != null)
                elapsed += _StopwatchInstance.SavedTime;
            if (_StopwatchInstance.Started == null)
                return false;
            else
            {
                TimerTime = String.Format("{0:00}:{1:00}:{2:00}.{3:00}", elapsed.Value.Hours, elapsed.Value.Minutes, elapsed.Value.Seconds, elapsed.Value.Milliseconds/10);
 //               TimerTime = elapsed.ToString();
                return true;
            }    
        }

        public ICommand ResetCommand { get; set; }
        public ICommand StartStopCommand { get; set; }
    }
}
