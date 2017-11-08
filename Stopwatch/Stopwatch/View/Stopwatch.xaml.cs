using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Stopwatch.View
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class StopwatchView : ContentPage
    {
        ViewModel.StopwatchViewModel _viewModel;

        public StopwatchView()
        {
 //           InitializeComponent();
            _viewModel = new ViewModel.StopwatchViewModel();


        }

        void OnStartButtonClicked(object sender, EventArgs args)
        {
            if (_viewModel.IsRunning())
            {
                StartStopButton.Text = "Start";
                _viewModel.Stop();
            }
            else
            {
                StartStopButton.Text = "Stop";
                _viewModel.Start();
            }
        }
        void OnResetButtonClicked(object sender, EventArgs arg)
        {
            _viewModel.Reset();
        }
    }
}