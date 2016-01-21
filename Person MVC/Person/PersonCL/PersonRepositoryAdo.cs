using Microsoft.Practices.EnterpriseLibrary.Data;
using Microsoft.Practices.EnterpriseLibrary.Data.Sql;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Common;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PersonCL
{
    public class PersonRepositoryAdo : IRepository<Person>
    {
        static string connectionString = /*"Persist Security Info=False;Integrated Security=true;Initial Catalog=PersonCL.PersonContextEntitySQL;server=(local)";//*/"Data Source=(local); Initial Catalog=PersonCL.PersonContextEntitySQL" + "Data Source=C:\\Users\\Mariya\\Documents\\GitHub\\Tasks\\Person MVC\\Person\\Person\\App_Data\\;";//+"Integrated Security=True";
        private Database db;

        public PersonRepositoryAdo()
        {
            db = new SqlDatabase(connectionString);
        }

        public void Create(Person item)
        {
            string queryString = "INSERT INTO [Person] ([FirstName],[LastName],[Age]) VALUES (@FirstName,@LastName,@Age)";
            try
            {
                DbCommand command = db.GetSqlStringCommand(queryString);
                db.AddInParameter(command, "FirstName", DbType.String, item.FirstName);
                db.AddInParameter(command, "LastName", DbType.String, item.LastName);
                db.AddInParameter(command, "Age", DbType.Int32, item.Age);
                db.AddInParameter(command, "ID", DbType.Int32, item.ID);
                using (db.ExecuteReader(command))///???? what is this
                {
                    return;
                }
            }
            catch
            {

            }
        }

        public void Delete(Person item)////////////??????????????
        {
            string queryString = "DELETE FROM [Person] WHERE ID LIKE @ID";
            try
            {
                DbCommand command = db.GetSqlStringCommand(queryString);
                db.AddInParameter(command, "ID", DbType.Int32, item.ID);
                using (db.ExecuteReader(command))///???? what is this
                {
                    return;
                }
            }
            catch
            {

            }
        }

        public IEnumerable<Person> GetAll()
        {
            string queryString = "SELECT * from [Person]";
            List<Person> result = new List<Person>();
            try
            {
                DbCommand command = db.GetSqlStringCommand(queryString);
                IDataReader reader = db.ExecuteReader(command);
                while (reader.Read())///Mapper seperatly
                {
                    result.Add(new Person()
                    {
                        ID = reader.GetInt32(0),
                        FirstName = reader.GetString(1),
                        LastName = reader.GetString(2),
                        Age = reader.GetInt32(3)
                    });
                }
                reader.Close();///
            }
            catch
            {

            }
            return result;
        }

        public Person GetByID(int id)
        {
            string queryString = "SELECT * from [Person] WHERE ID LIKE @ID";
            Person result = new Person();
            try
            {
                DbCommand command = db.GetSqlStringCommand(queryString);
                db.AddInParameter(command, "ID", DbType.Int32, id);
                IDataReader reader = db.ExecuteReader(command);
                reader.Read();///////SIngle Mepper
                result.ID = (int)reader["ID"];
                result.FirstName = (string)reader["FirstName"];
                result.LastName = (string)reader["LastName"];
                result.Age = (int)reader["Age"];
            }
            catch
            {

            }
            return result;
        }

        public void Update(Person item)
        {
            string queryString = "UPDATE [PERSON] SET FirstName=@FirstName,LastName=@LastName,Age=@Age WHERE ID LIKE @ID";
            try
            {
                DbCommand command = db.GetSqlStringCommand(queryString);
                db.AddInParameter(command, "FirstName", DbType.String, item.FirstName);
                db.AddInParameter(command, "LastName", DbType.String, item.LastName);
                db.AddInParameter(command, "Age", DbType.Int32, item.Age);
                using (db.ExecuteReader(command))///???? what is this
                {
                    return;
                }
            }
            catch
            {

            }
        }
    }
}
