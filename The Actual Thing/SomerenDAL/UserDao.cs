using SomerenModel;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SomerenDAL
{
    public class UserDao : BaseDao
    {
        //Selects everything from the users table
        public List<User> GetAllUsers()
        {
            string query = "SELECT * FROM Users";
            SqlParameter[] sqlParameters = new SqlParameter[0];
            return ReadTables(ExecuteSelectQuery(query, sqlParameters));
        }

        public void CreateUser(User user)
        {
            //string query = "INSERT INTO Users VALUES('@Username','@Password','@Secret_Question','@Secret_Answer')";
            //SqlParameter[] sqlParameters = { new SqlParameter("Username", user.Username), new SqlParameter("Password", user.Password), new SqlParameter("Secret_Question", user.SecretQuestion), new SqlParameter("Secret_Answer", user.SecretAnswer) };
            string query = $"INSERT INTO Users VALUES('{user.Username}','{user.Password}','{user.SecretQuestion}','{user.SecretAnswer}')";
            SqlParameter[] sqlParameters = new SqlParameter[0];
            ExecuteEditQuery(query, sqlParameters);
        }

        private List<User> ReadTables(DataTable dataTable)
        {
            List<User> users = new List<User>();

            foreach (DataRow dr in dataTable.Rows)
            {
                User user = new User()
                {
                    Id = (int)dr["Id"],
                    Username = (string)dr["Username"],
                    Password = (string)dr["Password"],
                    SecretQuestion = (string)dr["Secret_Question"],
                    SecretAnswer = (string)dr["Secret_Answer"],
                };
                users.Add(user);
            }
            return users;
        }
    }
}
