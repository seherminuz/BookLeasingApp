using BookLeasing.CustomException;
using BookLeasing.DAL;
using BookLeasing.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookLeasing.BLL
{
    public class UserRoleController
    {
        UserRoleManagement _userRoleManagement;
        public UserRoleController()
        {
            _userRoleManagement = new UserRoleManagement();
        }

        public bool Add(UserRole UserRole)
        {
            CheckFields(UserRole);
            int result = _userRoleManagement.Insert(UserRole);
            return result > 0;
        }

        void CheckFields(UserRole UserRole)
        {
            if (string.IsNullOrWhiteSpace(UserRole.RoleName))
            {
                throw new NotNullException("Rol Tipi");
            }
        }

        public bool Update(UserRole UserRole)
        {
            CheckFields(UserRole);
            int result = _userRoleManagement.Update(UserRole);
            return result > 0;

        }

        public bool Delete(UserRole UserRole)
        {
            int result = _userRoleManagement.Delete(UserRole.RoleID);
            return result > 0;

        }

        public UserRole GetPaymentReason(int UserRoleID)
        {
            return _userRoleManagement.GetUserRoleByID(UserRoleID);
        }

        public List<UserRole> GetUserRoles()
        {
            return _userRoleManagement.GetAllUserRoles();
        }
    }
}
