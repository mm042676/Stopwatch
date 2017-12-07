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

        public StopwatchView()
        {
            InitializeComponent();
        }
        protected override void OnSizeAllocated(double width, double height)
        {
            base.OnSizeAllocated(width, height); //must be called
            Resources["StopwatchFontSize"] = width / 12;
            Resources["TimerFontSize"] = width / 12;
        }
    }
}