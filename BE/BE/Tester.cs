using BE.Configurations;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BE
{
    public class Tester
    {
        //  Fields
        public int Id { get; set; }
        public string LastName { get; set; }
        public string FirstName { get; set; }
        public DateTime BirthDate { get; set; }
        public Gender Gender { get; set; }
        public int PhoneNumber { get; set; }
        public Address Address { get; set; }
        public int Seniority { get; set; }
        public int MaxTests { get; set; }
        public string SpecialCar { get; set; }
        public WeekPlanning  WeekPlanning { get; set; }
        public int MaxDistance { get; set; }
 

        //  Constructors
        public Tester(int id) { Id = id;  }
        public Tester(Tester t)
        {
            Id = t.Id;
        }

        //  METHODS
        public override string ToString()
        {
            return Id.ToString() + " " + FirstName + " " + LastName;
        }


    }
}
