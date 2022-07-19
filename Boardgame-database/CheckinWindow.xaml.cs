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
        private readonly List<string> gamesList = new(){ "Ticket to Ride", "Mysterium", "Monopoly", "Magic the Gathering", "Werewolf" };
        
        public CheckinWindow()
        {
            InitializeComponent();
            Searchbar.TextChanged += Searchbar_OnTextChanged;
        }

        private void CloseWindowButton_OnClick(object sender, RoutedEventArgs e)
        {
            Close();
        }

        private void EnterCheckinButton_OnClick(object sender, RoutedEventArgs e)
        {
            //todo Implement Unload

            if (!(sender is Button button))
            {
                MessageBox.Show(new NullReferenceException().Message);
            }
            else switch (button.Content.ToString())
            {
                case "Sure?":
                    button.Content = "Enter";
                    return;
                case "Enter":
                {
                    button.Content = "Sure?";
                    return;
                }
            }

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
            

            Searchbar.Focus(); // Refocus the keyboard onto Searchbar
            Searchbar.SelectAll();
        }

        private void Searchbar_OnTextChanged(object sender, TextChangedEventArgs e)
        {
            ResultsListBox.ItemsSource = gamesList.Where(z => z.ToLower().Contains(Searchbar.Text.ToLower()));

            ResultsListBox.SelectedIndex = 0;
        }

        private void CheckinWindow_OnLoaded(object sender, RoutedEventArgs e)
        {
            Searchbar.Focus();
            Searchbar.SelectAll();
            ResultsListBox.ItemsSource = gamesList;
        }
    }
}
