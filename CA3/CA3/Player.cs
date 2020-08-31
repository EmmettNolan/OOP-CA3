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

        //Random Player Creation
        private void RandName()
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
    }
}
