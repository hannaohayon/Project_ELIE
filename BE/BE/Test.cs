using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BE
{
    public class Test
    {
        //  Fields
        public int Id { get; set; }
        public int TesterId { get; set; }
        public int TraineeId { get; set; }
        public DateTime DayTest { get; set; }
        public Address StartingAddress { get; set; }
        public Criterias Criterias { get; set; }
        public bool Succeed { get; set; }
        public string Commentaries { get; set; }

        //  Constructor
        public Test(Test t)
        {
        }

        //Methods
        public override string ToString()
        {
            return "Test number: " + Id.ToString() + 
                "\nTester's id: " + TesterId.ToString() +
                 "\nTrainee's id: " + TraineeId.ToString();
        }

    }
}
