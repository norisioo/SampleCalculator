using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;
using SampleCalculator.ViewModel;

namespace SampleCalculator.View
{
    public partial class CalculatorView : ContentPage
    {
        public CalculatorView()
        {
            this.BindingContext = new SampleCalculator.ViewModel.CalculatorViewModel();
            InitializeComponent();
        }
    }
}
