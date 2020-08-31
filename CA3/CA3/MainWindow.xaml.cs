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

        public string Surname { get; private set; }

        public MainWindow()
        {
            InitializeComponent();
        }

        private void Window_Loaded_1(object sender, RoutedEventArgs e)
        {
            //Methods

            //Random Player Creation
            void RandName()
            {
                string[] firstNames = new string[]
                {
                "Adam", "Amelia", "Ava", "Chloe", "Conor", "Daniel", "Emily",
                "Emma", "Grace", "Hannah", "Harry", "Jack", "James",
                "Lucy", "Luke", "Mia", "Michael", "Noah", "Sean", "Sophie"};


                string[] lastNames = new string[]
                    {
                "Brennan", "Byrne", "Daly", "Doyle", "Dunne", "Fitzgerald", "Kavanagh",
                "Kelly", "Lynch", "McCarthy", "McDonagh", "Murphy", "Nolan", "O'Brien",
                "O'Connor", "O'Neill", "O'Reilly", "O'Sullivan", "Ryan", "Walsh"
                    };

                Random rnd = new Random();
                int index = rnd.Next(firstNames.Length) + rnd.Next(lastNames.Length);
            }

            //Create List
            void PlayerList()
            {
                RandName();
                Player p1 = new Player(Name, Surname, Player.Position.Goalkeeper);
                Player p2 = new Player(Name, Surname, Player.Position.Goalkeeper);
                Player p3 = new Player(Name, Surname, Player.Position.Defender);
                Player p4 = new Player(Name, Surname, Player.Position.Defender);
                Player p5 = new Player(Name, Surname, Player.Position.Defender);
                Player p6 = new Player(Name, Surname, Player.Position.Defender);
                Player p7 = new Player(Name, Surname, Player.Position.Defender);
                Player p8 = new Player(Name, Surname, Player.Position.Defender);
                Player p9 = new Player(Name, Surname, Player.Position.Midfielder);
                Player p10 = new Player(Name, Surname, Player.Position.Midfielder);
                Player p11 = new Player(Name, Surname, Player.Position.Midfielder);
                Player p12 = new Player(Name, Surname, Player.Position.Midfielder);
                Player p13 = new Player(Name, Surname, Player.Position.Midfielder);
                Player p14 = new Player(Name, Surname, Player.Position.Midfielder);
                Player p15 = new Player(Name, Surname, Player.Position.Forward);
                Player p16 = new Player(Name, Surname, Player.Position.Forward);
                Player p17 = new Player(Name, Surname, Player.Position.Forward);
                Player p18 = new Player(Name, Surname, Player.Position.Forward);
                Player p19 = new Player("Emmett", "Nolan", Player.Position.Defender);

                List<Player> allPlayers = new List<Player>();

                allPlayers.Add(p1);
                allPlayers.Add(p2);
                allPlayers.Add(p3);
                allPlayers.Add(p4);
                allPlayers.Add(p5);
                allPlayers.Add(p6);
                allPlayers.Add(p7);
                allPlayers.Add(p8);
                allPlayers.Add(p9);
                allPlayers.Add(p10);
                allPlayers.Add(p11);
                allPlayers.Add(p12);
                allPlayers.Add(p13);
                allPlayers.Add(p14);
                allPlayers.Add(p15);
                allPlayers.Add(p16);
                allPlayers.Add(p17);
                allPlayers.Add(p18);
                allPlayers.Add(p19);
            }


            allPlayersLB.ItemsSource = allPlayers;

            //Sorting by first name then second name.
            //allPlayersLB.ItemsSource = allPlayers.OrderBy(s => s.Name).ThenBy(s => s.Surname);

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
