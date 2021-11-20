using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CleanCodeDemos
{
    public sealed class DbConnection
    {
        private int counter = 0;
        public static DbConnection instance = null;
        private DbConnection()
        {
            counter++;
            Console.WriteLine("Counter: " + counter);
            Console.WriteLine("Constrcutor");
        }

        public static DbConnection GetInstance()
        {
            if (instance == null)
                instance = new DbConnection();
            return instance;
        }
    }



    class Demo14
    {
        public static void Main2()
        {
            DbConnection db1 = DbConnection.GetInstance();
            DbConnection db2 = DbConnection.GetInstance();
            DbConnection db3 = DbConnection.GetInstance();

            //DbConnection.Child child = new DbConnection.Child();

            Console.ReadKey();
        }
    }
}
