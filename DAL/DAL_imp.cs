using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BE;
using DS;

namespace DAL
{
    public class DAL_imp : IDAL
    {
        #region ADD


        public void AddTest(Test t)
        {
            //  give the id
            t.Id = BE.Configurations.Configuration.RunningTestId;
            BE.Configurations.Configuration.RunningTestId += 1;
   
            //add the test
            DataSource.TestList.Add(new Test(t));

        }

        public void AddTester(Tester t)
        {
            
            if (GetTesters().FirstOrDefault(x => x.Id == t.Id) != null)
                throw new Exception("Error, this tester already exists.\nYou cannot add him.");

            DataSource.TesterList.Add(new Tester(t));
        }

        public void AddTrainee(Trainee t)
        {
            if (GetTrainees().FirstOrDefault(x => x.Id == t.Id) != null)
                throw new Exception("Error, this trainee already exists.\nYou cannot add him.");

            DataSource.TraineeList.Add(new Trainee(t));
        }


        #endregion

        #region DELETE
        public void DeleteTest(Test t)
        {
            if (GetTests().FirstOrDefault(x => x.Id == t.Id) == null)
                throw new Exception("Error, this test doesn't exists.\nYou cannot remove it.");

            DataSource.TestList.Remove(GetTests().Find(x => x.Id == t.Id));
        }

        public void DeleteTester(Tester t)
        {
            if (GetTesters().FirstOrDefault(x => x.Id == t.Id) == null)
                throw new Exception("Error, this tester doesn't exists.\nYou cannot remove him.");

            DataSource.TesterList.Remove(GetTesters().Find(x => x.Id == t.Id));
        }

        public void DeleteTrainee(Trainee t)
        {
            if (GetTrainees().FirstOrDefault(x => x.Id == t.Id) == null)
                throw new Exception("Error, this trainee doesn't exists.\nYou cannot remove him.");

            DataSource.TraineeList.Remove(GetTrainees().Find(x => x.Id == t.Id));
        }
        #endregion

        #region UPDATE

        public void UpdateTest(Test t)
        {
            if (GetTests().FirstOrDefault(x => x.Id == t.Id) == null)
                throw new Exception("Error, this test doesn't exists.\nYou cannot update it.");


            //  perform the update by removing and then adding the old test
            DataSource.TestList.Remove(GetTests().Find(x => x.Id == t.Id));
            DataSource.TestList.Add(new Test(t));
        }

        public void UpdateTester(Tester t)
        {
            if (GetTesters().FirstOrDefault(x => x.Id == t.Id) == null)
                throw new Exception("Error, this tester doesn't exists.\nYou cannot update him.");

            //  perform the update by removing and then adding the old tester
            DeleteTester(t);
            AddTester(t);
        }

        public void UpdateTrainee(Trainee t)
        {
            if (GetTrainees().FirstOrDefault(x => x.Id == t.Id) == null)
                throw new Exception("Error, this trainee doesn't exists.\nYou cannot update him.");

            //  perform the update by removing and then adding the old trainee
            DeleteTrainee(t);
            AddTrainee(t);
        }

        #endregion

        #region GETLISTS
        public List<Test> GetTests()
        {
            return new List<Test>(DataSource.TestList);
        }

        public List<Tester> GetTesters()
        {
            return new List<Tester> (DataSource.TesterList);
        }

        public List<Trainee> GetTrainees()
        {
            return new List<Trainee> (DataSource.TraineeList);
        }
        #endregion

        
    }
}
