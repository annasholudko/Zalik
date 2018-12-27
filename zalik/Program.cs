using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data.SqlTypes;
using System.Data.Odbc;

namespace zalik
{
    class Program
    {
        static void Main(string[] args)
        {
            Database db = new Database(@"Data Source=(local);Initial catalog=zalik;Integrated Security=True");
            db.Task1();
            db.Task2();
            db.Task3();
            db.Task4();
            Console.ReadKey();
        }
    }
}
