using BookLeasing.Model;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookLeasing.DAL
{
    public class UserManagement
    {
        Helper h;
        public UserManagement()
        {
            h = new Helper();
        }

        public int Insert(User user)
        {
            string query = "INSERT INTO [User](RoleID,FirstName,LastName,EMail,Password,IsActive) VALUES(@roleID,@name,@surname,@mail,@pass,@active)";
            List<SqlParameter> parameters = GetParameters(user, true);
            h.AddParametersToCommand(parameters);
            return h.MyExecuteQuery(query);
        }

        List<SqlParameter> GetParameters(User user, bool isInsert)
        {
            List<SqlParameter> parameters = new List<SqlParameter>();

            if (isInsert)
            {
                parameters.Add(new SqlParameter("@roleID", user.RoleID));
            }
            parameters.Add(new SqlParameter("@userID", user.UserID));
            parameters.Add(new SqlParameter("@name", user.FirstName));
            parameters.Add(new SqlParameter("@surname", user.LastName));
            parameters.Add(new SqlParameter("@mail", user.EMail));
            parameters.Add(new SqlParameter("@pass", user.Password));
            parameters.Add(new SqlParameter("@active", user.IsActive));
            return parameters;
        }

        public int Update(User user)
        {
            string query = "UPDATE [User] SET Firstname = @name, Lastname = @surname, EMail = @mail, Password = @pass, IsActive = @active WHERE UserID = @userID";
            List<SqlParameter> parameters = GetParameters(user, false);

            h.AddParametersToCommand(parameters);
            return h.MyExecuteQuery(query);
        }

        public int Delete(int userID)
        {
            string query = "DELETE FROM [User] WHERE UserID = @userID";
            h.AddParametersToCommand(new List<SqlParameter>()
            {
                new SqlParameter()
                {
                    ParameterName = "@userID",
                    Value = userID

                }
            });

            return h.MyExecuteQuery(query);
        }
        public int PassiveToActive(User user)
        {
            string query = "UPDATE [User] SET IsActive = @active WHERE UserID = @userID";
            List<SqlParameter> parameters = GetParameters(user, false);

            h.AddParametersToCommand(parameters);
            return h.MyExecuteQuery(query);

        }
        public List<User> GetActiveUsers()
        {
            List<User> users = new List<User>();
            string query = "SELECT UserID,RoleID,Firstname,Lastname,Email,Password,CreatedDate FROM User WHERE IsActive = 1";

            User currentUser;
            SqlDataReader reader = h.MyExecuteReader(query);
            while (reader.Read())
            {
                currentUser = new User();
                currentUser.UserID = (int)reader["UserID"];
                currentUser.RoleID = (int)reader["RoleID"];
                currentUser.FirstName = reader["Firstname"].ToString();
                currentUser.LastName = reader["Lastname"].ToString();
                currentUser.EMail = reader["Email"].ToString();
                currentUser.Password = reader["Password"].ToString();
                currentUser.CreatedDate = (DateTime)reader["CreatedDate"];
                users.Add(currentUser);
            }
            reader.Close();

            return users;
        }
        public List<User> GetPassiveUsers()
        {
            List<User> users = new List<User>();
            string query = "SELECT UserID,RoleID,Firstname,Lastname,Email,Password,CreatedDate FROM [User] WHERE IsActive = 0";

            User currentUser;
            SqlDataReader reader = h.MyExecuteReader(query);
            while (reader.Read())
            {
                currentUser = new User();
                currentUser.UserID = (int)reader["UserID"];
                currentUser.RoleID = (int)reader["RoleID"];
                currentUser.FirstName = reader["Firstname"].ToString();
                currentUser.LastName = reader["Lastname"].ToString();
                currentUser.EMail = reader["Email"].ToString();
                currentUser.Password = reader["Password"].ToString();
                currentUser.CreatedDate = (DateTime)reader["CreatedDate"];
                users.Add(currentUser);
            }
            reader.Close();

            return users;
        }

        public User GetUserByID(int userID)
        {
            string query = "SELECT * FROM [User] WHERE UserID = @userID";
            h.AddParametersToCommand(new List<SqlParameter>()
            {
                new SqlParameter()
                {
                    ParameterName = "@userID",
                    Value = userID

                }
            });

            User currentUser = new User();
            SqlDataReader reader = h.MyExecuteReader(query);
            reader.Read();
            currentUser.UserID = userID;
            currentUser.RoleID = (int)reader["RoleID"];
            currentUser.FirstName = reader["Firstname"].ToString();
            currentUser.LastName = reader["Lastname"].ToString();
            currentUser.EMail = reader["Email"].ToString();
            currentUser.Password = reader["Password"].ToString();
            currentUser.IsActive = (bool)reader["IsActive"];
            currentUser.CreatedDate = (DateTime)reader["CreatedDate"];

            reader.Close();

            return currentUser;
        }

        public string GetUserRoleByUserID(int userID)
        {
            string query = "SELECT ur.RoleName FROM UserRole ur JOIN User u ON u.RoleID = ur.RoleID WHERE u.userID = @userID";
            h.AddParametersToCommand(new List<SqlParameter>()
            {
                new SqlParameter()
                {
                    ParameterName = "@userID",
                    Value = userID
                }
            });

            SqlDataReader reader = h.MyExecuteReader(query);
            string roleName = string.Empty;
            reader.Read();
            roleName = reader["RoleName"].ToString();
           
            reader.Close();

            return roleName;
        }

        public List<User> GetAllUsers()
        {
            List<User> users = new List<User>();
            string query = "SELECT * FROM [User]";

            User currentUser;
            SqlDataReader reader = h.MyExecuteReader(query);
            while (reader.Read())
            {
                currentUser = new User();
                currentUser.UserID = (int)reader["UserID"];
                currentUser.RoleID = (int)reader["RoleID"];
                currentUser.FirstName = reader["Firstname"].ToString();
                currentUser.LastName = reader["Lastname"].ToString();
                currentUser.EMail = reader["Email"].ToString();
                currentUser.Password = reader["Password"].ToString();
                currentUser.IsActive = (bool)reader["IsActive"];
                currentUser.CreatedDate = (DateTime)reader["CreatedDate"];
                users.Add(currentUser);
            }
            reader.Close();

            return users;
        }

        public UserRole GetUserRoleByID(int roleID)
        {
            string query = "SELECT * FROM UserRole WHERE RoleID = @roleID";
            h.AddParametersToCommand(new List<SqlParameter>()
            {
                new SqlParameter()
                {
                    ParameterName = "@roleID",
                    Value = roleID
                }
            });

            SqlDataReader reader = h.MyExecuteReader(query);
            UserRole role = new UserRole();
            reader.Read();
            role.RoleID = roleID;
            role.RoleName = reader.GetString(1);
            reader.Close();

            return role;
        }

        public UserRole GetUserRoleByName(string roleName)
        {
            string query = "SELECT * FROM UserRole WHERE RoleName = @name";
            h.AddParametersToCommand(new List<SqlParameter>()
            {
                new SqlParameter()
                {
                    ParameterName = "@name",
                    Value = roleName
                }
            });

            SqlDataReader reader = h.MyExecuteReader(query);
            UserRole role = new UserRole();
            reader.Read();
            role.RoleID = reader.GetInt32(0);
            role.RoleName = roleName;
            reader.Close();

            return role;
        }

        public int GetUserIDByName (string fullName)
        {
            int userID = 0;

            string query = "SELECT UserID FROM [User] WHERE FirstName + ' ' + LastName = @fullName";
            h.AddParametersToCommand(new List<SqlParameter>()
            {
                new SqlParameter()
                {
                    ParameterName = "@fullName",
                    Value = fullName
                }
            });

            SqlDataReader reader = h.MyExecuteReader(query);
            reader.Read();
            userID = (int)reader["UserID"];
            reader.Close();
            return userID;
        }
    }
}
