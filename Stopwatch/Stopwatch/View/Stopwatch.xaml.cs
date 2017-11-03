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
    public partial class Stopwatch : ContentPage
    {
        ViewModel.StopwatchViewModel _viewModel;

        public Stopwatch()
        {
 //           InitializeComponent();
            _viewModel = new ViewModel.StopwatchViewModel();


        }
    }
}