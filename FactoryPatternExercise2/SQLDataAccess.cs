using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryPatternExercise2
{
    internal class SQLDataAccess : IDataAccess
    {
        public List<object> LoadData()
        {
            Console.WriteLine("I am reading data from the SQL database.");
            return new List<object>();
        }
        public void SaveData()
        {
            Console.WriteLine("I am saving data to a SQL database");
        }
    }
}
