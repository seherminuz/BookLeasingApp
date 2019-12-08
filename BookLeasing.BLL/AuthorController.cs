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
    public class AuthorController
    {
        AuthorManagement _authorManagement;

        public AuthorController()
        {
            _authorManagement = new AuthorManagement();
        }
        public bool Add(Author author)
        {
            CheckFields(author);
            int result = _authorManagement.Insert(author);
            return result > 0;
        }

        void CheckFields(Author author)
        {
            if (string.IsNullOrWhiteSpace(author.FirstName))
            {
                throw new NotNullException("Firstname");
            }
            else if (string.IsNullOrWhiteSpace(author.LastName))
            {
                throw new NotNullException("Lastname");
            }
        }

        public bool Update(Author author)
        {
            CheckFields(author);

            int result = _authorManagement.Update(author);
            return result > 0;

        }

        public bool Delete(Author author)
        {
            int result = _authorManagement.Delete(author.AuthorID);
            return result > 0;

        }
        public Author GetAuthor(int authorID)
        {
            return _authorManagement.GetAuthorByID(authorID);
        }

        public List<Author> GetAuthors()
        {
            return _authorManagement.GetAllAuthors();
        }

        public int GetAuthorbyName(Author currentAuthor)
        {
            return _authorManagement.GetAutorByName(currentAuthor.FirstName,currentAuthor.LastName);
        }
    }
}
