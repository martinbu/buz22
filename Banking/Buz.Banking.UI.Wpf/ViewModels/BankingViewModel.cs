using System.Collections.ObjectModel;

namespace Buz.Banking.UI.Wpf.ViewModels
{
    class BankingViewModel : BaseViewModel
    {
        public BankingViewModel()
        {
            BankAccountViewModels = new ObservableCollection<AccountViewModel>();
        }

        public ObservableCollection<AccountViewModel> BankAccountViewModels { get; }


        private AccountViewModel? _SelectedBankAccount = null;
        public AccountViewModel? SelectedBankAccount
        {
            get { return _SelectedBankAccount; }
            set
            {
                _SelectedBankAccount = value;
                NotifyPropertyChanged(nameof(SelectedBankAccount));
            }
        }

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

        private decimal _InitialBalance = 2000;
        public decimal InitialBalance
        {
            get { return _InitialBalance; }
            set
            {
                _InitialBalance = value;
                NotifyPropertyChanged(nameof(InitialBalance));
            }
        }


        public void AddBankAccount()
        {
            var newBankAccount = new BankAccount(Owner, InitialBalance);
            var newBankAccountViewModel = new AccountViewModel(newBankAccount);

            BankAccountViewModels.Add(newBankAccountViewModel);

            SelectedBankAccount = newBankAccountViewModel;

            Owner = "";
            InitialBalance = 2000;
        }
    }
}
