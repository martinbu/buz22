using Buz.Banking.UI.Wpf.ViewModels;
using System.Windows;
using System.Windows.Controls;

namespace Buz.Banking.UI.Wpf.Views
{
    public partial class BankingView : UserControl
    {
        public BankingView()
        {
            InitializeComponent();
            // DataContext = new BankingViewModel();
        }

        private void AddAccount_Click(object sender, RoutedEventArgs e)
        {
            if (DataContext is BankingViewModel viewModel)
            {
                viewModel?.AddBankAccount();
            }   
        }
    }
}
