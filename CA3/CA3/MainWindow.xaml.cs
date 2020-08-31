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
using CA3;

namespace CA3
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        List<Player> allPlayers = new List<Player>();
        List<Player> selectedPlayers = new List<Player>();

        public MainWindow()
        {
            InitializeComponent();
        }

        private void Window_Loaded_1(object sender, RoutedEventArgs e)
        {
            //Sorting by first name then second name.
            allPlayersLB.ItemsSource = allPlayers.OrderBy(s => s.Name).ThenBy(s => s.Surname);

            // Setting up the contents of the ComboBox
            formationsCbx.ItemsSource = new string[] { "4-4-2", "4-3-3", "4-5-1" };
        }

        private void addBtn_Click(object sender, RoutedEventArgs e)
        {
            //Figure out which player is selected on screen //
            Player selectedPlayer = allPlayersLB.SelectedItem as Player;

            //Null Checker
            if (selectedPlayer != null)
            {
                //Move the item which is clicked from the left listbox to the right listbox
                allPlayers.Remove(selectedPlayer);
                selectedPlayers.Add(selectedPlayer);
            }
        }

        private void removeBtn_Click(object sender, RoutedEventArgs e)
        {
            //Figure out which player is selected on screen //
            Player selectedPlayer = allPlayersLB.SelectedItem as Player;

            //Null Checker
            if (selectedPlayer != null)
            {
                //Move the item which is clicked from the left listbox to the right listbox
                allPlayers.Remove(selectedPlayer);
                selectedPlayers.Add(selectedPlayer);
            }
        }

        private void RefreshingScreen()
        {
            allPlayersLB.ItemsSource = null;
            allPlayersLB.ItemsSource = allPlayers;

            selectedPlayersLB.ItemsSource = null;
            selectedPlayersLB.ItemsSource = selectedPlayers;
        }

        private void Grid_Loaded(object sender, RoutedEventArgs e)
        {
            
        }
    }
}
