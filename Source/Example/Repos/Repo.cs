using System;
using System.Collections.Generic;
using Dapper
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TuplesInterface.Repos
{
    public class ConcreteRepo<T, TKey>
    {
        private IDbConnection db;

        public ConcreteRepo(string connString)
        {
            this.db = new SqlConnection(connString);
        }

        public T Find(TKey keyForTable)
        {
            return this.db.Query<T>("SELECT * FROM Contacts WHERE Id = @Id", new { id }).SingleOrDefault();
        }

        public int Delete(TKey keyForTable)
        {
            this.db.Execute("DELETE FROM Contacts WHERE Id = @Id", new { id });
        }

        public T Add(T item)
        {
            var sql =
                "INSERT INTO Contacts (FirstName, LastName, Email, Company, Title) VALUES(@FirstName, @LastName, @Email, @Company, @Title); " +
                "SELECT CAST(SCOPE_IDENTITY() as int)";
            var id = this.db.Query<int>(sql, T).Single();
            contact.Id = id;
            return T;
        }

        public T Update(T item)
        {
            var sql =
                "UPDATE Contacts " +
                "SET FirstName = @FirstName, " +
                "    LastName  = @LastName, " +
                "    Email     = @Email, " +
                "    Company   = @Company, " +
                "    Title     = @Title " +
                "WHERE Id = @Id";
            this.db.Execute(sql, contact);
            return contact;
        }
    }
}
