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
            //MessageBox.Show("The Checkout Button click event has triggered");


            CheckoutWindow cW = new() { Owner = this };
            //The above is shorthand for
            /* CheckoutWindow cW = new CheckoutWindow();
             * cW.Owner = this; */
            // The "this" keyword just means "the current object". Like "self" in python.

            //.Show() will open the window and return immediately, allowing people to continue working on the main window
            // However, for something like this, we probably don't want that, so it makes more sense to block this method until we finish our checkout
            // ShowDialog will not return until the new window calls the "Close" event
            cW.ShowDialog();
        }

        private int reviewClicked;

        private void Window_Loaded(object sender, RoutedEventArgs e)
        {

            //todo Remove this
            CheckoutReview.Content += Environment.NewLine + "Clicked: 0 Times";
        }

        private void Window_Closed(object sender, EventArgs e)
        {

        }

        private void CheckinButton_Click(object sender, RoutedEventArgs e)
        {
            //MessageBox.Show("The Checkin Button click event has triggered");
            CheckinWindow cW = new() {Owner = this};
            cW.ShowDialog();
        }

        private void CheckoutReview_Click(object sender, RoutedEventArgs e)
        {
            //MessageBox.Show("The Checkout Review Button click event has triggered");

            ReviewWindow rW = new() { Owner = this };
            rW.ShowDialog();

            //todo Remove this
            ++reviewClicked;
            CheckoutReview.Content = $"Review Checked Out Games{Environment.NewLine}Clicked: {reviewClicked} Times";
        }

        private void Search_Click(object sender, RoutedEventArgs e)
        {
            //MessageBox.Show("The Search Button click event has triggered");
            SearchWindow sW = new() { Owner = this};
            sW.ShowDialog();
            
        }

        private void SaveData_OnClick(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("Save Data has been pressed");
        }
    }
}
