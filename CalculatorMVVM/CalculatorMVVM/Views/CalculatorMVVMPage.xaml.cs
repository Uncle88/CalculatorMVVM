using CalculatorMVVM.ViewModels;
using Xamarin.Forms;

namespace CalculatorMVVM
{
    public partial class CalculatorMVVMPage : ContentPage
    {
        public CalculatorMVVMPage()
        {
            InitializeComponent();
            BindingContext = new CalculatorViewModel();
        }
    }
}
