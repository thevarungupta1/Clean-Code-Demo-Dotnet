using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace CleanCodeDemos
{
    // Single Responsibility Principle (SRP)

    public class UserService
    {
        public void registerUser(string username)
        {
            if (username == "admin")
                throw new InvalidOperationException();

            SqlConnection connection = new SqlConnection();
           // connection.open();
            SqlCommand comm = new SqlCommand("inset user");

            // email
        }
    }











    class Demo9
    {
    }
}
