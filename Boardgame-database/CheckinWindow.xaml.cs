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
    /// Interaction logic for CheckinWindow.xaml
    /// </summary>
    public partial class CheckinWindow : Window
    {
        public CheckinWindow()
        {
            InitializeComponent();
            Searchbar.Focus();
            Searchbar.SelectAll();
        }

        private void CloseWindowButton_OnClick(object sender, RoutedEventArgs e)
        {
            Close();
        }

        private void EnterCheckinButton_OnClick(object sender, RoutedEventArgs e)
        {
            //todo Implement Unload
            Searchbar.Text = "Search"; // Replace the Searchbar's text
            Searchbar.Focus(); // Refocus the keyboard onto Searchbar
            Searchbar.SelectAll();
        }

        private void Searchbar_OnTextInput(object sender, TextCompositionEventArgs e)
        {
            //todo Implement Unload
        }

        private void SearchbarDropMenu_OnSelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            //todo Implement Unload
        }
    }
}
