using BookLeasing.Model;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookLeasing.DAL
{
    public class UserRoleManagement
    {
        Helper h;
        public UserRoleManagement()
        {
            h = new Helper();
        }

        public int Insert(UserRole userRole)
        {
            string query = "INSERT INTO [UserRole](RoleName) VALUES(@roleName)";
            List<SqlParameter> parameters = GetParameters(userRole, true);
            h.AddParametersToCommand(parameters);
            return h.MyExecuteQuery(query);
        }

        List<SqlParameter> GetParameters(UserRole userRole, bool isInsert)
        {
            List<SqlParameter> parameters = new List<SqlParameter>();

            if (isInsert)
            {
                parameters.Add(new SqlParameter("@roleID", userRole.RoleID));
            }
            parameters.Add(new SqlParameter("@roleName", userRole.RoleName));

            return parameters;
        }

        public int Update(UserRole UserRole)
        {
            string query = "UPDATE [UserRole] SET RoleName = @roleName";
            List<SqlParameter> parameters = GetParameters(UserRole, false);

            h.AddParametersToCommand(parameters);
            return h.MyExecuteQuery(query);
        }

        public int Delete(int UserRoleID)
        {
            string query = "DELETE FROM [UserRole] WHERE RoleID = @roleID";
            h.AddParametersToCommand(new List<SqlParameter>()
            {
                new SqlParameter()
                {
                    ParameterName = "@roleID",
                    Value = UserRoleID

                }
            });

            return h.MyExecuteQuery(query);
        }

        public UserRole GetUserRoleByID(int UserRoleID)
        {
            string query = "SELECT * FROM [UserRole] WHERE UserRoleID = @roleID";
            h.AddParametersToCommand(new List<SqlParameter>()
            {
                new SqlParameter()
                {
                    ParameterName = "@roleID",
                    Value = UserRoleID

                }
            });

            UserRole currentUserRole = new UserRole();
            SqlDataReader reader = h.MyExecuteReader(query);
            reader.Read();

            currentUserRole.RoleID = (int)reader["RoleID"];
            currentUserRole.RoleName = reader["Firstname"].ToString();

            reader.Close();

            return currentUserRole;
        }

        public List<UserRole> GetAllUserRoles()
        {
            List<UserRole> UserRoles = new List<UserRole>();
            string query = "SELECT * FROM [UserRole]";

            UserRole currentUserRole;
            SqlDataReader reader = h.MyExecuteReader(query);
            while (reader.Read())
            {
                currentUserRole = new UserRole();
                currentUserRole.RoleName = reader["RoleName"].ToString();
                currentUserRole.RoleID = (int)reader["RoleID"];

                UserRoles.Add(currentUserRole);
            }
            reader.Close();

            return UserRoles;
        }

    }
}
