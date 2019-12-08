using BookLeasing.CustomException;
using BookLeasing.DAL;
using BookLeasing.DTO;
using BookLeasing.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Mail;
using System.Text;
using System.Threading.Tasks;

namespace BookLeasing.BLL
{
    public class UserController
    {
        UserManagement _userManagement;
        public UserController()
        {
            _userManagement = new UserManagement();

        }

        public bool Add(User user)
        {
            CheckFields(user);
            CheckMail(user.EMail);
            CheckPassword(user.Password);
            user.RoleID = _userManagement.GetUserRoleByName("Standart").RoleID;
            int result = _userManagement.Insert(user);
            return result > 0;
        }
        void CheckMail(string mail)
        {
            try
            {
                MailAddress address = new MailAddress(mail);
            }
            catch (Exception)
            {
                throw new MailFormatException();
            }
            List<User> users = _userManagement.GetAllUsers();
            foreach (User item in users)
            {
                if (item.EMail == mail)
                {
                    throw new MailException();
                }
            }
        }

        void CheckFields(User user)
        {
            if (string.IsNullOrWhiteSpace(user.EMail))
            {
                throw new NotNullException("Email");
            }
            else if (string.IsNullOrWhiteSpace(user.Password))
            {
                throw new NotNullException("Password");
            }
        }

        void CheckPassword(string password)
        {
            if (password.Length < 6 || password.Length > 19)
            {
                throw new PasswordLengthException(6, 20);
            }
            int letterCount = 0;
            foreach (char item in password)
            {
                if (char.IsLetter(item))
                {
                    letterCount++;
                }

            }
            if (letterCount < 3)
            {
                throw new ThreeLettersException();
            }
            int recurrentLetter = 1;
            int sequentialLetters = 1;
            for (int i = 0; i < password.Length - 1; i++)
            {
                if (password[i] == password[i + 1])
                {
                    recurrentLetter++;
                }
                if (Convert.ToInt32(password[i]) + 1 == Convert.ToInt32(password[i + 1]))
                {
                    sequentialLetters++;
                }
            }
            if (recurrentLetter > 3)
            {
                throw new RecurrentLetterException(3);

            }
            if (sequentialLetters > 3)
            {
                throw new SequentialLetterException(3);
            }
        }
        public bool Update(User user)
        {
            CheckPassword(user.Password);
            CheckFields(user);
            int result = _userManagement.Update(user);
            return result > 0;

        }
        public bool Delete(User user)
        {
            int result = _userManagement.Delete(user.UserID);
            return result > 0;

        }
        public User GetUser(int userID)
        {
            return _userManagement.GetUserByID(userID);
        }
        public string GetUserRoleByUserID(int userID)
        {
            return _userManagement.GetUserRoleByUserID(userID);
        }
        public List<User> GetUsers()
        {
            return _userManagement.GetAllUsers();
        }
        public List<User> GetActiveUsers()
        {
            return _userManagement.GetActiveUsers();
        }

        public List<User> GetPassiveUsers()
        {
            return _userManagement.GetPassiveUsers();
        }
        public bool PassiveToActive(User user)
        {
            int result = _userManagement.PassiveToActive(user);
            return result > 0;
        }

        public int GetUserIDByName(string name)
        {
            return _userManagement.GetUserIDByName(name);
        }

        public string Login(LoginDTO login)
        {
            List<User> users = _userManagement.GetAllUsers();

            foreach (User item in users)
            {
                if (item.EMail == login.Mail)
                {
                    if (item.Password == login.Password)
                    {
                        return item.UserID.ToString();
                    }
                    else
                    {
                        return "Şifre Yanlış!";
                    }
                }
            }

            return "Mail yanlış";
        }
    }
}
