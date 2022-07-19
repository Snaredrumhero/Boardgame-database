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
using System.Windows.Shapes;

namespace Boardgame_database
{
    /// <summary>
    /// Interaction logic for CheckoutWindow.xaml
    /// </summary>
    public partial class CheckoutWindow : Window
    {
        private string Date;
        private string Login;
        private string GameId;
        public CheckoutWindow()
        {
            //This is your object constructor. It will run immediately when you call the new() method.
            InitializeComponent();
            DateBox.Focus();
            DateBox.SelectAll();
        }

        private void CheckoutWindow_OnLoaded(object sender, RoutedEventArgs e)
        {
            //This will call after the window fully loads
            
            // Throwing a "NotImplementedException" on load will crash your app because you haven't implemented the behavior.
            // Good idea for buttons, not a good idea for load and unload.
            //throw new NotImplementedException();

            //Better option is to just make a comment like this
            //todo Implement Load
        }

        private void CheckoutWindow_OnClosed(object? sender, EventArgs e)
        {
            //Same problem here with closing your window

            //throw new NotImplementedException();
            //todo Implement Unload

            
        }

        private void CloseWindowButton_OnClick(object sender, RoutedEventArgs e)
        {
            Close();
        }

        private void EnterDataButton_OnClick(object sender, RoutedEventArgs e)
        {
            //todo Implement Unload
            DateBox.Text = LoginBox.Text = IdBox.Text = "Enter:"; // Replaces all text within the textboxes

            DateBox.Focus(); // Focus back onto DateBox
            DateBox.SelectAll();
        }

        private void DateBox_OnTextInput(object sender, TextCompositionEventArgs e)
        {
            //todo Implement Unload
        }

        private void LoginBox_OnTextInput(object sender, TextCompositionEventArgs e)
        {
            //todo Implement Unload
            
        }

        private void IdBox_OnTextInput(object sender, TextCompositionEventArgs e)
        {
            //todo Implement Unload
        }
    }
}
