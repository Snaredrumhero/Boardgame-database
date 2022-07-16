using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace Boardgame_database
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void CheckoutButton_Click(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("The Checkout Button click event has triggered");
            CheckoutWindow cW = new CheckoutWindow();
            cW.Show();
        }

        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("The window has opened");
        }

        private void Window_Closed(object sender, EventArgs e)
        {
            MessageBox.Show("The window has closed");
        }

        private void CheckinButton_Click(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("The Checkin Button click event has triggered");
        }

        private void CheckoutReview_Click(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("The Checkout Review Button click event has triggered");
        }

        private void Search_Click(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("The Search Button click event has triggered");
        }
    }
}
