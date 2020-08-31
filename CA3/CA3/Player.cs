using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CA3
{
    class Player
    {
        //Enum
        public enum Position { Goalkeeper, Defender, Midfielder, Forward }

        //Properties
        public string Name { get; set; }
        public string Surname { get; set; }
        public Position PerferredPosition { get; set; }
        public DateTime DateOfBirth { get; set; }
        public int Age { get; set; }
        public int age
        {
            get
            {
                Age = DateTime.Now.Year - DateOfBirth.Year;
                if (DateOfBirth.DayOfYear > DateTime.Now.DayOfYear)
                    Age--;
                return Age;
            }
        }

        public Player(string name,string surname, Position perferredPosition)
        {
            Name = name;
            Surname = surname;
            PerferredPosition = perferredPosition;
        }

        ////Methods

        ////Random Player Creation
        //private void RandName()
        //{
        //    string[] firstNames = new string[]
        //    {
        //        "Adam", "Amelia", "Ava", "Chloe", "Conor", "Daniel", "Emily",
        //        "Emma", "Grace", "Hannah", "Harry", "Jack", "James",
        //        "Lucy", "Luke", "Mia", "Michael", "Noah", "Sean", "Sophie"};


        //    string[] lastNames = new string[]
        //        {
        //        "Brennan", "Byrne", "Daly", "Doyle", "Dunne", "Fitzgerald", "Kavanagh",
        //        "Kelly", "Lynch", "McCarthy", "McDonagh", "Murphy", "Nolan", "O'Brien",
        //        "O'Connor", "O'Neill", "O'Reilly", "O'Sullivan", "Ryan", "Walsh"
        //        };

        //    Random rnd = new Random();
        //    int index = rnd.Next(firstNames.Length) + rnd.Next(lastNames.Length);
        //}

        ////Create List
        //private void PlayerList()
        //{
        //    Player p1 = new Player(Name, Surname, Player.Position.Goalkeeper);
        //    Player p2 = new Player(Name, Surname, Player.Position.Goalkeeper);
        //    Player p3 = new Player(Name, Surname, Player.Position.Defender);
        //    Player p4 = new Player(Name, Surname, Player.Position.Defender);
        //    Player p5 = new Player(Name, Surname, Player.Position.Defender);
        //    Player p6 = new Player(Name, Surname, Player.Position.Defender);
        //    Player p7 = new Player(Name, Surname, Player.Position.Defender);
        //    Player p8 = new Player(Name, Surname, Player.Position.Defender);
        //    Player p9 = new Player(Name, Surname, Player.Position.Midfielder);
        //    Player p10 = new Player(Name, Surname, Player.Position.Midfielder);
        //    Player p11 = new Player(Name, Surname, Player.Position.Midfielder);
        //    Player p12 = new Player(Name, Surname, Player.Position.Midfielder);
        //    Player p13 = new Player(Name, Surname, Player.Position.Midfielder);
        //    Player p14 = new Player(Name, Surname, Player.Position.Midfielder);
        //    Player p15 = new Player(Name, Surname, Player.Position.Forward);
        //    Player p16 = new Player(Name, Surname, Player.Position.Forward);
        //    Player p17 = new Player(Name, Surname, Player.Position.Forward);
        //    Player p18 = new Player(Name, Surname, Player.Position.Forward);

        //    List<Player> allPlayers = new List<Player>();

        //    allPlayers.Add(p1);
        //    allPlayers.Add(p2);
        //    allPlayers.Add(p3);
        //    allPlayers.Add(p4);
        //    allPlayers.Add(p5);
        //    allPlayers.Add(p6);
        //    allPlayers.Add(p7);
        //    allPlayers.Add(p8);
        //    allPlayers.Add(p9);
        //    allPlayers.Add(p10);
        //    allPlayers.Add(p11);
        //    allPlayers.Add(p12);
        //    allPlayers.Add(p13);
        //    allPlayers.Add(p14);
        //    allPlayers.Add(p15);
        //    allPlayers.Add(p16);
        //    allPlayers.Add(p17);
        //    allPlayers.Add(p18);
        //}

        //Order FirstName, LastName, DateOfBirth, Position
        public override string ToString()
        {
            return $"{Name} {Surname} {DateOfBirth} {PerferredPosition}";
        }
    }
}
