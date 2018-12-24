using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BE;

namespace DS
{
    public class DataSource
    {

        public static List<Tester> TesterList {get; set;}
        public static List<Test> TestList { get; set; }
        public static List<Trainee> TraineeList { get; set; }


        public DataSource()
        {
            if (TesterList == null)
                TesterList = new List<Tester>();

            if (TestList == null)
                TestList = new List<Test>();

            if (TraineeList == null)
                TraineeList = new List<Trainee>();
        }
    }
}
