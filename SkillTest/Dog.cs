using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace SkillTest
{
    public class Dog
    {

        private int _id;
        private string _name;
        private string _race;
        private int _yearOfBirth;

        public Dog(int id, string name, string race, int yearOfBirth)
        {
            ID = id;
            Name = name;
            Race = race;
            YearOfBirth = yearOfBirth;
        }
        public int ID
        {
            get { return _id; }
            private set { _id = value; }
        }
        public string Name
        {
            get { return _name; }
            private set { _name = value; }
        }
        public string Race
        {
            get { return _race; }
            private set { _race = value; }
        }
        public int YearOfBirth
        {
            get { return _yearOfBirth; }
            private set { _yearOfBirth = value; }
        }

     

        public override string ToString()
        {
            return $"ID:{ID}, Navn:{Name}, Race: {Race}, YearOfBirth: {YearOfBirth}";
        }




    }
}
