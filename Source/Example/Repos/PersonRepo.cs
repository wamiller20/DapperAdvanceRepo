using System.Data;
using System.Data.SqlClient;
using RepoExample.Entities;
using Dapper;

namespace RepoExample.Repos
{
    public class PersonRepo
    {
        private IDbConnection db;

        public PersonRepo(string connString)
        {
            this.db = new SqlConnection(connString);
        }

        public Person Add(Person person)
        {
            var sql =
                "INSERT INTO Contacts (FirstName, LastName, Email, Company, Title) VALUES(@FirstName, @LastName, @Email, @Company, @Title); " +
                "SELECT CAST(SCOPE_IDENTITY() as int)";
            var id = this.db.Query<int>(sql, person).Single();
            person.BusinessEntityID = id;
            return person;
        }

        public Person Find(int id)
        {
            return this.db.Query<Person>("SELECT * FROM Person WHERE Id = @Id", new { id }).SingleOrDefault();
        }

        

        //public Address Add(Address address)
        //{
        //    var sql =
        //        "INSERT INTO Addresses (ContactId, AddressType, StreetAddress, City, StateId, PostalCode) VALUES(@ContactId, @AddressType, @StreetAddress, @City, @StateId, @PostalCode); " +
        //        "SELECT CAST(SCOPE_IDENTITY() as int)";
        //    var id = this.db.Query<int>(sql, address).Single();
        //    address.Id = id;
        //    return address;
        //}

        //public Address Update(Address address)
        //{
        //    this.db.Execute("UPDATE Addresses " +
        //        "SET AddressType = @AddressType, " +
        //        "    StreetAddress = @StreetAddress, " +
        //        "    City = @City, " +
        //        "    StateId = @StateId, " +
        //        "    PostalCode = @PostalCode " +
        //        "WHERE Id = @Id", address);
        //    return address;
        //}

        //public List<Contact> GetAll()
        //{
        //    return this.db.Query<Contact>("SELECT * FROM Contacts").ToList();
        //}

        //public void Remove(int id)
        //{
        //    this.db.Execute("DELETE FROM Contacts WHERE Id = @Id", new { id });
        //}

        //public Contact Update(Contact contact)
        //{
        //    var sql =
        //        "UPDATE Contacts " +
        //        "SET FirstName = @FirstName, " +
        //        "    LastName  = @LastName, " +
        //        "    Email     = @Email, " +
        //        "    Company   = @Company, " +
        //        "    Title     = @Title " +
        //        "WHERE Id = @Id";
        //    this.db.Execute(sql, contact);
        //    return contact;
        //}
    }
}
