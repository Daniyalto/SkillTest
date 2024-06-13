using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Diagnostics.Metrics;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace SkillTest
{
    public class Member
    {
        List<Dog> _dogList;
        private int _id;
        private string _name;   
        private string _adress;
        private DateTime _birthDate;
        private string _phone;
        private string _email;
        static bool _useList = false;
        private int _age;

        
        public Member(int id, string name, string adress, DateTime birthDate, string phone, string email)
        {
            ID = id;
            Name = name;
            Adress = adress;
            BirthDate = birthDate;
            Phone = phone;
            Email = email;
            _dogList = new List<Dog>();

        }

      
        public Member()
        {
            _dogList = new List<Dog>();
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

        public string Adress
        {
            get { return _adress; }
            private set { _adress = value; }
        }

        public DateTime BirthDate
        {
            get { return _birthDate; }
            private set { _birthDate = value; }
        }

        public string Phone
        {
            get { return _phone; }
            private set { _phone = value; }
        }

        public string Email
        {
            get { return _email; }
            private set { _email = value; }
        }

        public static bool UseList
        {
            get { return _useList; }
            private set { _useList = value; }
        }

        public int Age => DateTime.Now.Year - BirthDate.Year;
        
       



        public void RegisterDog(Dog dog) 
        {
            _dogList.Add(dog);

        }

     

        public void PrintDogs()
        {
            if (_dogList == null)
                return;

            foreach (Dog m in _dogList)
            {
                Console.WriteLine(m);
            }
        }

        

        public void RemoveDog(Dog dog)
        {
            if (UseList)
            {
                Dog dFound = null;
                foreach (Dog d in _dogList)
                {
                    if (d.ID == _id)
                    {
                        dFound = d;
                    }
                }

                if (dFound != null)
                {
                    _dogList.Remove(dFound);
                }
            }
            else
            {
                _dogList.Remove(dog);
            }
        }

        public double MemberFee(double baseFee) 
        {
            
            double totalfee = 1000 + _dogList.Count() * baseFee; 
            if(Age >= 65) 
            {
                totalfee = totalfee - 500;
            }

            return totalfee;
        }

        public bool Validate() 
        {
            if (Age < 18)
            {
                /*Console.WriteLine("Member must be at least 18 years old.");
                return false;*/
                string msg = "Member must be at least 18 years old";
                throw new ArgumentException(msg);
            }

            if (string.IsNullOrEmpty(Name) || string.IsNullOrEmpty(Adress) ||
                string.IsNullOrEmpty(Phone) || string.IsNullOrEmpty(Email))
            {
                /*Console.WriteLine("All personal details must be filled out (Name, Address, Phone, Email)");
                return false;*/
                throw new ArgumentException("All personal details must be filled out (Name, Address, Phone, Email)");
            }

            return true;

        }

        public override string ToString()
        {
            return $"ID:{ID}, Navn:{Name}, Adress:{Adress}, BirthDate: {BirthDate}, Phone: {Phone}, Email: {Email}, Age: {Age}";
        }




    }
}
