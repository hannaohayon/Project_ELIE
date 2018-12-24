using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BE
{
    public class WeekPlanning
    {
        bool[,] _workingTime = {
            { false,false,false,false,false,false },
            { false,false,false,false,false,false },
            { false,false,false,false,false,false },
            { false,false,false,false,false,false },
            { false,false,false,false,false,false },
            { false,false,false,false,false,false }

        };

        public bool[,] WorkingTime
        {
            get { return _workingTime; }
            set { _workingTime = value; }
        }

        public bool Works(DateTime time)
        {
            
            int hour = time.Hour;

            //  get the day
            //  sunday 0
            //  monday 1 ...
            //  saturday 6
            int day = (int) time.DayOfWeek; 

            int index = 6 - (15 - hour);

            //  check if inside the normal planning
            if (day == (int)DayOfWeek.Friday 
                || day == (int)DayOfWeek.Saturday
                || hour < 9
                || hour>=15)
                return false;

            //  check inside the matrix
            return _workingTime[day, index];
        }
    }
}
