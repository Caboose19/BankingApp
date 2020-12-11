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
    /// Interaction logic for TransferFundsWindow.xaml
    /// </summary>
    public partial class TransferFundsWindow : Window
    {
        public TransferFundsWindow()
        {
            InitializeComponent();
        }

        private void Transfer_Click(object sender, RoutedEventArgs e)
        {
            if ((checking1.IsChecked == true && checking2.IsChecked == true) || (savings1.IsChecked == true && savings2.IsChecked == true)) MessageBox.Show("You can't transfer funds to the same account.");
            else MessageBox.Show($"Transfered ${transferBox.Text} to other account");
        }

        private void savings1_Click(object sender, RoutedEventArgs e)
        {
            if (checking1.IsChecked == true || savings1.IsChecked == false)
            {
                checking1.IsChecked = false;
                savings1.IsChecked = true;
            }
        }

        private void checking1_Click(object sender, RoutedEventArgs e)
        {
            if (savings1.IsChecked == true || checking1.IsChecked == false)
            {
                savings1.IsChecked = false;
                checking1.IsChecked = true;
            }
        }

        private void savings2_Click(object sender, RoutedEventArgs e)
        {
            if (checking2.IsChecked == true || savings2.IsChecked == false)
            {
                checking2.IsChecked = false;
                savings2.IsChecked = true;
            }
        }

        private void checking2_Click(object sender, RoutedEventArgs e)
        {
            if (savings2.IsChecked == true || checking2.IsChecked == false)
            {
                savings2.IsChecked = false;
                checking2.IsChecked = true;
            }
        }
    }
}
