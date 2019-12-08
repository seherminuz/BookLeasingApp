using BookLeasing.Model;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookLeasing.DAL
{
    public class AuthorManagement
    {
        Helper h;
        public AuthorManagement()
        {
            h = new Helper();

        }

        public int Insert(Author author)
        {
            string query = "INSERT INTO Author(Firstname,Lastname) VALUES(@name,@surname)";
            List<SqlParameter> parameters = GetParameters(author, true);
            h.AddParametersToCommand(parameters);
            return h.MyExecuteQuery(query);

        }

        List<SqlParameter> GetParameters(Author author, bool isInsert)
        {
            List<SqlParameter> parameters = new List<SqlParameter>();
            if (!isInsert)
            {
                parameters.Add(new SqlParameter("@authorID", author.AuthorID));
            }
            parameters.Add(new SqlParameter("@name", author.FirstName));
            parameters.Add(new SqlParameter("@surname", author.LastName));
            return parameters;
        }

        public int Update(Author author)
        {
            string query = "UPDATE Author SET Firstname = @name, Lastname = @surname WHERE AuthorID = @authorID";
            List<SqlParameter> parameters = GetParameters(author, false);

            h.AddParametersToCommand(parameters);
            return h.MyExecuteQuery(query);
        }

        public int Delete(int authorID)
        {
            string query = "DELETE FROM Author WHERE AuthorID = @authorID";
            h.AddParametersToCommand(new List<SqlParameter>()
        {
            new SqlParameter()
            {
                ParameterName = "@authorID",
                Value = authorID

            }
        });
            return h.MyExecuteQuery(query);
        }

        public int GetAutorByName(string firstName, string lastName)
        {
            string query = "SELECT AuthorID FROM Author WHERE FirstName = @firstName and LastName =@lastName";
            h.AddParametersToCommand(new List<SqlParameter>()
        {
            new SqlParameter()
            {
                ParameterName = "@firstName",
                Value = firstName

            },
            new SqlParameter()
            {
                ParameterName = "@lastName",
                Value = lastName

            }
        });

            Author currentAuthor = new Author();
            SqlDataReader reader = h.MyExecuteReader(query);
            while (reader.Read())
            {
                currentAuthor.AuthorID = (int)reader["AuthorID"];
            }
           
           
 
            reader.Close();
            return currentAuthor.AuthorID;
        }

        public Author GetAuthorByID(int authorID)
        {
            string query = "SELECT * FROM Author WHERE AuthorID = @authorID";
            h.AddParametersToCommand(new List<SqlParameter>()
        {
            new SqlParameter()
            {
                ParameterName = "@authorID",
                Value = authorID

            }
        });

            Author currentAuthor = new Author();
            SqlDataReader reader = h.MyExecuteReader(query);
            reader.Read();
            currentAuthor.AuthorID = authorID;
            currentAuthor.FirstName = reader["Firstname"].ToString();
            currentAuthor.LastName = reader["Lastname"].ToString();


            reader.Close();

            return currentAuthor;
        }

        public List<Author> GetAllAuthors()
        {
            List<Author> authors = new List<Author>();
            string query = "SELECT * FROM Author";

            Author currentAuthor;
            SqlDataReader reader = h.MyExecuteReader(query);
            while (reader.Read())
            {
                currentAuthor = new Author();
                currentAuthor.AuthorID = (int)reader["AuthorID"];
                currentAuthor.FirstName = reader["Firstname"].ToString();
                currentAuthor.LastName = reader["Lastname"].ToString();

                authors.Add(currentAuthor);
            }
            reader.Close();

            return authors;
        }
    }
}
