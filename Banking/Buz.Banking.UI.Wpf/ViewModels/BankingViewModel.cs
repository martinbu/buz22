namespace Buz.Banking.UI.Wpf.ViewModels
{
    class BankingViewModel : BaseViewModel
    {
        private string _Owner = "";
        public string Owner
        {
            get { return _Owner; }
            set
            { 
                _Owner = value;
                NotifyPropertyChanged(nameof(Owner));
            }
        }

        private decimal _Amount;
        public decimal Amount
        {
            get { return _Amount; }
            set
            {
                _Amount = value;
                NotifyPropertyChanged(nameof(Amount));
            }
        }

    }
}
