using System;
using Xamarin.Forms;
using System.Threading.Tasks;
using System.Linq;

namespace CalculatorMVVM.ViewModels
{
    public class CalculatorViewModel : ViewModelBase
    {
        const int Persenteg = 17;
        private Command _clickCommand;
        private string _sum;
        private string _amount;
        private string _totalAmount;

        public string Sum
        {
            get { return _sum; }
            set
            {
                _sum = value;
                OnPropertyChanged(nameof(Sum));
            }
        }

        public string Amount
        {
            get { return _amount; }
            set
            {
                _amount = value;
                OnPropertyChanged(nameof(Amount));
            }
        }

        public string TotalAmount
        {
            get { return _totalAmount; }
            set
            {
                _totalAmount = value;
                OnPropertyChanged(nameof(TotalAmount));
            }
        }

        public Command ClickCommand
        {
            get
            {
                return _clickCommand ?? (_clickCommand = new Command((_) =>
                {
                    if (string.IsNullOrEmpty(Sum))
                    {
                        return;
                    }
                    var score = (Convert.ToDouble(Sum));
                    var tip = (score * Persenteg / 100);
                    Amount = tip.ToString();
                    TotalAmount = (score + tip).ToString();

                }));
            }
        }
    }
}
