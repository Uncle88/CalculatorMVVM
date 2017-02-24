using CalculatorMVVM.ViewModels;
using Xamarin.Forms;

namespace CalculatorMVVM
{
    public partial class CalculatorView : ContentPage
    {
        public CalculatorView()
        {
            InitializeComponent();
            BindingContext = new CalculatorViewModel();
        }
    }
}
