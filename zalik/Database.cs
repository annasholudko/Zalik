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
    class Database
    {
        public string ConnectionString { get; set; }
        public Database(string Con) { this.ConnectionString = Con; }
        public SqlConnection cn;
        public void Task1()
        {
            cn = new SqlConnection(ConnectionString);
            cn.Open();
            Console.WriteLine("1.");
            string strSql = "select k.id,k.name,k.language,city.name from kind_of_inhabitant k inner join city on city.id_city=k.id_city where k.language='ukrainian' and city.name='Kyiv';";
            SqlCommand com = new SqlCommand(strSql, cn);
            SqlDataReader dr = com.ExecuteReader();
            while (dr.Read())
            {
                Console.WriteLine(dr[0] + " " + dr[1] + " " + dr[2] + " " + dr[3]);
            }
            dr.Close();
            cn.Close();
        }
        public void Task2()
        {
            cn = new SqlConnection(ConnectionString);
            cn.Open();
            Console.WriteLine("2.");
            string strSql1 = "select city.id_city,city.name,city.square,city.population from kind_of_inhabitant k inner join city on city.id_city=k.id_city where k.name='children';";
            SqlCommand com1 = new SqlCommand(strSql1, cn);
            SqlDataReader dr1 = com1.ExecuteReader();
            while (dr1.Read())
            {
                Console.WriteLine(dr1[0] + " " + dr1[1] + " " + dr1[2] + " " + dr1[3]);
            }
            dr1.Close();
            cn.Close();
        }
        public void Task3()
        {
            cn = new SqlConnection(ConnectionString);
            cn.Open();
            Console.WriteLine("3");
            string strSql2 = "select city.id_city,city.name,city.square,city.population, k.id,k.name from kind_of_inhabitant k inner join city on city.id_city=k.id_city where city.population=2000000;";
            SqlCommand com2 = new SqlCommand(strSql2, cn);
            SqlDataReader dr2 = com2.ExecuteReader();
            while (dr2.Read())
            {
                Console.WriteLine(dr2[0] + " " + dr2[1] + " " + dr2[2] + " " + dr2[3] + " " + dr2[4] + " " + dr2[5]);
            }
            dr2.Close();
            cn.Close();
        }
        public void Task4()
        {
            
            cn = new SqlConnection(ConnectionString);
            cn.Open();
            Console.WriteLine("4");
            string strSql3 = "select * from kind_of_inhabitant where name='pensioner';";
            SqlCommand com3 = new SqlCommand(strSql3, cn);
            SqlDataReader dr3 = com3.ExecuteReader();
            while (dr3.Read())
            {
                Console.WriteLine(dr3[0] + " " + dr3[1] + " " + dr3[2] + " " + dr3[3]);
            }
            dr3.Close();
            cn.Close();
        }
    }
}
