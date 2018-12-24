using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BE;

namespace DAL
{
    public interface IDAL
    {
        //  ADD
        void AddTester(Tester t);
        void AddTrainee(Trainee t);
        void AddTest(Test t);


        //  DELETE
        void DeleteTester(Tester t);
        void DeleteTrainee(Trainee t);
        void DeleteTest(Test t);

        //  UPDATE
        void UpdateTester(Tester t);
        void UpdateTrainee(Trainee t);
        void UpdateTest(Test t);

        //  GetLists
        List<Tester> GetTesters();
        List<Trainee> GetTrainees();
        List<Test> GetTests();
    }
}
