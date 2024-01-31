namespace FactoryPatternExercise2
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("What database do you want to use?\nType List, SQL, or Mongo:");
            IDataAccess access = DataAccessFactory.GetDataAccessType(Console.ReadLine());
            Console.WriteLine("--------------------------"); 
            access.LoadData();
            Console.WriteLine("--------------------------");
            access.SaveData();
        }
    }
}
