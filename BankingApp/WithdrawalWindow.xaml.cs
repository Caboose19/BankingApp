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
    /// Interaction logic for WithdrawalWindow.xaml
    /// </summary>
    public partial class WithdrawalWindow : Window
    {
        public int balance { get; set; } = 1000;

        public WithdrawalWindow()
        {
            InitializeComponent();
            Balance.Text = "Current Balance: " + balance.ToString();
        }

        private void WithdrawMoney_Click(object sender, RoutedEventArgs e)
        {
            var withdrawRequest = Convert.ToInt32(this.InputWithdraw.Text);
            if (withdrawRequest > balance && balance != 0) MessageBox.Show("You can't do that, enter a lower amount");
            if (balance == 0) MessageBox.Show("You don't have anymore money. Exit window");

            balance -= withdrawRequest;

            Balance.Text = $"Current Balance: {balance}";
        }

        private void Cancel_Click(object sender, RoutedEventArgs e)
        {
            MainAccountWindow.shutdownWithdrawal();
        }
    }
}
