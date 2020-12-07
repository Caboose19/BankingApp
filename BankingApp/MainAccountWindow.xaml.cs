using System;
using System.Collections.Generic;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;

namespace BankingApp
{
    /// <summary>
    /// Interaction logic for MainAccountWindow.xaml
    /// </summary>
    public partial class MainAccountWindow : Window
    {

        Random random = new Random();

        public MainAccountWindow()
        {
            InitializeComponent();
            txtCheckingBalanceAmount.Text = "$"+random.Next(500).ToString();
            txtSavingsBalanceAmount.Text = "$"+random.Next(500).ToString();
        } 

        private void TextBox_TextChanged(object sender, TextChangedEventArgs e)
        {
            
        }

        private void btnMakeDeposit_Click(object sender, RoutedEventArgs e)
        {
            MakeDepositWindow depositWindow = new MakeDepositWindow();

            depositWindow.Show();
        }

        private void btnMakeWithdrawl_Click(object sender, RoutedEventArgs e)
        {
            WithdrawalWindow withdrawal = new WithdrawalWindow();
            withdrawal.Show();
        }

        private void btnTransferFunds_Click(object sender, RoutedEventArgs e)
        {
            TransferFundsWindow transfer = new TransferFundsWindow();
            transfer.Show();
        }

        private void btnMakePurchase_Click(object sender, RoutedEventArgs e)
        {
            MakePurchaseWindow purchase = new MakePurchaseWindow();
            purchase.Show();
        }

        private void btnViewTransactionHistory_Click(object sender, RoutedEventArgs e)
        {
            TransactionHistoryWindow main = new TransactionHistoryWindow();
            main.Show();
        }

        private void btnLogout_Click(object sender, RoutedEventArgs e)
        {
            MainWindow main = new MainWindow();
            main.Show();
            this.Close();
        }
    }
}
