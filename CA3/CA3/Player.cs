using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CA3
{
    class Player
    {
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
    }
}
