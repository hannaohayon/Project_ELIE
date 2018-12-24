using BE.Configurations;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BE
{
    public class Trainee
    {

        //  Fields/Properties
        public int Id { get; set; }
        public string LastName { get; set; }
        public string FirstName { get; set; }
        public DateTime BirthDate { get; set; }
        public Gender Gender { get; set; }
        public int PhoneNumber { get; set; }
        public Address Address { get; set; }
        public Transmission Transmission { get; set; }
        public string DrivingSchoolName { get; set; }
        public string Car { get; set; }
        public int NumberOfLessons { get; set; }
        public string TeacherName { get; set; }


        //  Constructor
        public Trainee(int id)
        {
            Id = id;
        }

        public Trainee(Trainee t)
        {
            Id = t.Id;
        }

        //  Methods
        public override string ToString()
        {
            return Id.ToString() + " " + FirstName + " " + LastName;
        }

    }
}
