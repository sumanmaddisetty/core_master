using System;
using PetaPoco;
using Core_DomainModel;
using Npgsql;
using PetaPoco.Providers;
using System.Collections.Generic;
using System.Linq;

namespace Core_DAL
{
    public class UserDAL
    {
        // var DbContest = new PetaPoco.Database();
        public List<User> GetUsers()
        {
           // List<User> userslst = new List<User>();
            //var users = new PetaPoco.Database(;           
             //var db = DatabaseConfiguration.Build().UsingConnectionString("Username=postgres;Password=123;Host=localhost;Port=54580;Database=BandP").UsingProvider(new PostgreSQLDatabaseProvider()).Create();
            NpgsqlConnection conn = new NpgsqlConnection("Username=postgres;Password=123;Host=localhost;Port=5433;Database=BandP");
            conn.Open();
            PetaPoco.Database db = new PetaPoco.Database(conn);

            List<User> userslst = db.Query<User>("select first_name FirstName,last_name LastName,user_id UserId from security.user_account").ToList();
            conn.Close();

            //PetaPoco.Database db1 = new PetaPoco.Database(;
            //IEnumerable<int> enumerable = Enumerable.Range(1, 300);


            //IEnumerable<User> result = from value in getdata.
            //                          select value;
            // getdata.
            //List<User> allusers = getdata.Cast<User>().ToList();
            // db.ConnectionString
            //  var db = DatabaseConfiguration.Build()
            //.UsingProvider(new Npgsql.ProvideClientCertificatesCallback())
            //.UsingConnectionString("DefaultConnection")
            //.Create();
            return userslst;

        }
    }
}
