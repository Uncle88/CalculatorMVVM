using System;
using Xamarin.Forms;

namespace CalculatorMVVM.ViewModels
{
    public class CalculatorViewModel : ViewModelBase
    {
        private const int Persenteg = 17;
        private Command _clickCommand;
        private string _amount;
        private string _totalAmount;
        private string _sum;

        public string Amount
        {
            get { return _amount; }
            set
            {
                if (value != _amount)
                {
                    _amount = value;
                    OnPropertyChanged();
                }
            }
        }

        public string TotalAmount
        {
            get { return _totalAmount; }
            set
            {
                if (value != _totalAmount)
                {
                    _totalAmount = value;
                    OnPropertyChanged();
                }
            }
        }

        public string Sum
        {
            get { return _sum; }
            set
            {
                if (value != _sum)
                {
                    _sum = value;
                    OnPropertyChanged();
                }
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
                    CountAmount(Sum);
                }));
            }
        }

        public void CountAmount(string Sum)
        {
            try
            {
                var score = (Convert.ToDouble(Sum));
                var tip = (score * Persenteg / 100);
                Amount = tip.ToString();
                TotalAmount = (tip + score).ToString();
            }
            catch
            {
                return;
            }

        }
    }
}
