using BookLeasing.DTO;
using BookLeasing.Model;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookLeasing.DAL
{
    public class BookManagement
    {
        Helper h;
        public BookManagement()
        {
            h = new Helper();
        }

        public int Insert(Book book)
        {
            string query = "INSERT INTO Book(AuthorID,PublisherID,BookName,PageCount,PublishingYear,Summary,Price) VALUES(@authorID,@publisherID,@bookName,@pageCount,@publishingYear,@summary,@price)";
            List<SqlParameter> parameters = GetParameters(book, true);

            h.AddParametersToCommand(parameters);
            return h.MyExecuteQuery(query);
        }

        public int InsertFavorite(FavoriteDTO book)
        {
            string query = "INSERT INTO Favorite(UserID, BookID) VALUES(@userID,@bookID)";
            List<SqlParameter> parameters = GetParametersFavs(book);

            h.AddParametersToCommand(parameters);
            return h.MyExecuteQuery(query);
        }

        public int Update(Book book)
        {
            string query = "UPDATE Book SET AuthorID = @authorID, BookName = @bookName,IsAvailable = @isAvailable,PageCount = @pageCount,Price = @price,PublisherID = @publisherID,  PublishingYear = @publishingYear, Summary = @summary WHERE BookID = @bookID";
            List<SqlParameter> parameters = GetParameters(book, false);
            h.AddParametersToCommand(parameters);
            return h.MyExecuteQuery(query);
        }

        public int UpdateFavorites(FavoriteDTO book)
        {
            string query = "UPDATE Favorite SET BookID = @bookID WHERE UserID = @userID";
            List<SqlParameter> parameters = GetParametersFavs(book);

            h.AddParametersToCommand(parameters);
            return h.MyExecuteQuery(query);
        }

        List<SqlParameter> GetParameters(Book book, bool isInsert)
        {
            List<SqlParameter> parameters = new List<SqlParameter>();
            if (!isInsert)
            {
                parameters.Add(new SqlParameter("@bookID", book.BookID));
            }
            parameters.Add(new SqlParameter("@authorID", book.AuthorID));
            parameters.Add(new SqlParameter("@publisherID", book.PublisherID));
            parameters.Add(new SqlParameter("@bookName", book.BookName));
            parameters.Add(new SqlParameter("@pageCount", book.PageCount));
            parameters.Add(new SqlParameter("@publishingYear", book.PublishingYear));
            parameters.Add(new SqlParameter("@summary", book.Summary));
            parameters.Add(new SqlParameter("@isAvailable", book.IsAvailable));
            parameters.Add(new SqlParameter("@price", book.Price));
            return parameters;
        }

        public int UpdateIsAvailable(int bookID)
        {
            string query = "UPDATE Book SET IsAvailable = 0 WHERE BookID = @bookID";
            h.AddParametersToCommand(new List<SqlParameter>()
            {
                new SqlParameter()
                {
                    ParameterName = "@bookID",
                    Value = bookID
                }
            });

            return h.MyExecuteQuery(query);
        }

        List<SqlParameter> GetParametersFavs(FavoriteDTO book)
        {
            List<SqlParameter> parameters = new List<SqlParameter>();
            parameters.Add(new SqlParameter("@userID", book.UserID));
            parameters.Add(new SqlParameter("@bookID", book.BookID));
            return parameters;
        }

        public int Delete(int bookID)
        {
            string query = "DELETE FROM Book WHERE BookID = @bookID";
            h.AddParametersToCommand(new List<SqlParameter>()
            {
                new SqlParameter()
                {
                    ParameterName = "@bookID",
                    Value = bookID
                }
            });

            return h.MyExecuteQuery(query);
        }

        public int DeleteFav(int bookID)
        {
            string query = "DELETE FROM Favorite WHERE BookID = @bookID";
            h.AddParametersToCommand(new List<SqlParameter>()
            {
                new SqlParameter()
                {
                    ParameterName = "@bookID",
                    Value = bookID
                }
            });

            return h.MyExecuteQuery(query);
        }

        public Book GetBookByID(int bookID)
        {
            Book currentBook = new Book();
            string query = "SELECT * FROM Book WHERE BookID = @bookID";
            h.AddParametersToCommand(new List<SqlParameter>()
            {
                new SqlParameter()
                {
                    ParameterName = "@bookID",
                    Value = bookID
                }
            });

            SqlDataReader reader = h.MyExecuteReader(query);
            reader.Read();
            currentBook.BookID = bookID;
            currentBook.AuthorID = (int)reader["AuthorID"];
            currentBook.PublisherID = (int)reader["PublisherID"];
            currentBook.BookName = reader["BookName"].ToString();
            currentBook.PageCount = (int)reader["PageCount"];
            currentBook.PublishingYear = (int)reader["PublishingYear"];
            currentBook.Summary = reader["Summary"].ToString();
            currentBook.IsAvailable = (bool)reader["IsAvailable"];
            currentBook.Price = (decimal)reader["Price"];

            reader.Close();

            return currentBook;
        }

        public List<BookDTO> GetAllBooks()
        {
            List<BookDTO> books = new List<BookDTO>();
            BookDTO currentBook = null;
            string query = "SELECT b.BookName,a.FirstName + ' '+ a.LastName AS Author, p.PublisherName, b.PublishingYear, b.[PageCount], b.Summary, b.Price, b.IsAvailable FROM Book b JOIN Publisher p ON p.PublisherID = b.PublisherID JOIN Author a ON a.AuthorID = b.AuthorID";

            SqlDataReader reader = h.MyExecuteReader(query);
            while (reader.Read())
            {
                currentBook = new BookDTO();
                currentBook.BookName = reader["BookName"].ToString();
                currentBook.AuthorName = reader["Author"].ToString();
                currentBook.PublishingYear = (int)reader["PublishingYear"];
                currentBook.PublisherName = reader["PublisherName"].ToString();
                currentBook.PageCount = (int)reader["PageCount"];
                currentBook.Summary = reader["Summary"].ToString();
                currentBook.IsAvailable = (bool)reader["IsAvailable"];
                currentBook.Price = (decimal)reader["Price"];
                books.Add(currentBook);
            }
            reader.Close();
            return books;
        }

        public List<BookDTO> GetAllBookss()
        {
            List<BookDTO> books = new List<BookDTO>();
            BookDTO currentBook = null;
            string query = "  SELECT b.BookName,a.FirstName + ' '+ a.LastName AS Author, p.PublisherName, b.PublishingYear, b.[PageCount], b.Summary, b.Price, b.IsAvailable,b.BookID,b.AuthorID,b.PublisherID FROM Book b JOIN Publisher p ON p.PublisherID = b.PublisherID JOIN Author a ON a.AuthorID = b.AuthorID ";

            SqlDataReader reader = h.MyExecuteReader(query);
            while (reader.Read())
            {
                currentBook = new BookDTO();

                currentBook.BookName = reader["BookName"].ToString();
                currentBook.AuthorName = reader["Author"].ToString();
                currentBook.PublishingYear = (int)reader["PublishingYear"];
                currentBook.PublisherName = reader["PublisherName"].ToString();
                currentBook.PageCount = (int)reader["PageCount"];
                currentBook.Summary = reader["Summary"].ToString();
                currentBook.IsAvailable = (bool)reader["IsAvailable"];
                currentBook.Price = (decimal)reader["Price"];
                currentBook.BookID = (int)reader["BookID"];
                currentBook.PublisherID = (int)reader["PublisherID"];
                currentBook.AuthorID = (int)reader["AuthorID"];
                books.Add(currentBook);
            }
            reader.Close();
            return books;
        }

        public List<BookDTO> GetAllFavs()
        {
            List<BookDTO> books = new List<BookDTO>();
            BookDTO currentBook = null;
            string query = "SELECT b.BookName,a.FirstName + ' ' + a.LastName AS Author, p.PublisherName, b.PublishingYear, b.[PageCount], b.Summary, b.Price, b.IsAvailable FROM Favorite f JOIN Book b ON b.BookID = f.BookID JOIN Author a ON b.AuthorID = a.AuthorID JOIN Publisher p ON p.PublisherID = b.PublisherID";

            SqlDataReader reader = h.MyExecuteReader(query);
            while (reader.Read())
            {
                currentBook = new BookDTO();
                currentBook.BookName = reader["BookName"].ToString();
                currentBook.AuthorName = reader["Author"].ToString();
                currentBook.PublishingYear = (int)reader["PublishingYear"];
                currentBook.PublisherName = reader["PublisherName"].ToString();
                currentBook.PageCount = (int)reader["PageCount"];
                currentBook.Summary = reader["Summary"].ToString();
                currentBook.IsAvailable = (bool)reader["IsAvailable"];
                currentBook.Price = (decimal)reader["Price"];
                books.Add(currentBook);
            }
            reader.Close();
            return books;
        }

        public List<FavoriteDTO> GetAllFavDTOs()
        {
            List<FavoriteDTO> books = new List<FavoriteDTO>();
            FavoriteDTO currentBook = null;
            string query = "SELECT UserID,BookID FROM Favorite";

            SqlDataReader reader = h.MyExecuteReader(query);
            while (reader.Read())
            {
                currentBook = new FavoriteDTO();
                currentBook.BookID = (int)reader["BookID"];
                currentBook.UserID = (int)reader["UserID"];
                books.Add(currentBook);
            }
            reader.Close();
            return books;
        }

        public Book GetAvailableBooks (bool isAvailable)
        {
            Book currentBook = new Book();
            string query = "SELECT * FROM Book WHERE IsAvailable = @isAvailable";
            h.AddParametersToCommand(new List<SqlParameter>()
            {
                new SqlParameter()
                {
                    ParameterName = "@isAvailable",
                    Value = isAvailable
                }
            });

            SqlDataReader reader = h.MyExecuteReader(query);
            reader.Read();
            currentBook.BookID = (int)reader["BookID"];
            currentBook.AuthorID = (int)reader["AuthorID"];
            currentBook.PublisherID = (int)reader["PublisherID"];
            currentBook.BookName = reader["BookName"].ToString();
            currentBook.PageCount = (int)reader["PageCount"];
            currentBook.PublishingYear = (int)reader["PublishingYear"];
            currentBook.Summary = reader["Summary"].ToString();
            currentBook.IsAvailable = isAvailable;
            currentBook.Price = (decimal)reader["Price"];

            reader.Close();

            return currentBook;
        }

        public List<BookDTO> GetBookByPreference (string value,bool flag)
        {
            List<BookDTO> books = new List<BookDTO>();
            BookDTO currentBook = null;
            string query = "";
            if (flag)
            {
                query = "SELECT b.BookName,a.FirstName + ' '+ a.LastName AS Author, p.PublisherName, b.PublishingYear, b.[PageCount], b.Summary, b.Price, b.IsAvailable FROM Book b JOIN Publisher p ON p.PublisherID = b.PublisherID JOIN Author a ON a.AuthorID = b.AuthorID WHERE b.BookName = @value OR a.FirstName + ' '+ a.LastName = @value";
            }
            else
            {
                query = "SELECT b.BookName,a.FirstName + ' '+ a.LastName AS Author, p.PublisherName, b.PublishingYear, b.[PageCount], b.Summary, b.Price, b.IsAvailable FROM Book b JOIN Publisher p ON p.PublisherID = b.PublisherID JOIN Author a ON a.AuthorID = b.AuthorID WHERE PublishingYear = @value";
            }
          

            h.AddParametersToCommand(new List<SqlParameter>()
            {
                new SqlParameter()
                {
                    ParameterName = "@value",
                    Value = value
                }
            });

            SqlDataReader reader = h.MyExecuteReader(query);
            while (reader.Read())
            {
                currentBook = new BookDTO();
                currentBook.BookName = reader["BookName"].ToString();
                currentBook.AuthorName = reader["Author"].ToString();
                currentBook.PublishingYear = (int)reader["PublishingYear"];
                currentBook.PublisherName = reader["PublisherName"].ToString();
                currentBook.PageCount = (int)reader["PageCount"];
                currentBook.Summary = reader["Summary"].ToString();
                currentBook.IsAvailable = (bool)reader["IsAvailable"];
                currentBook.Price = (decimal)reader["Price"];
                books.Add(currentBook);
            }
            reader.Close();
            return books;
        }

        public int GetBookIDByName (string bookName, string authorName)
        {
            int bookID = 0;

            string query = "SELECT * FROM Book b JOIN Author a ON a.AuthorID = b.AuthorID WHERE BookName = @bookName AND a.FirstName + ' ' + a.LastName = @authorName";
            h.AddParametersToCommand(new List<SqlParameter>()
            {
                new SqlParameter()
                {
                    ParameterName = "@bookName",
                    Value = bookName
                },
                new SqlParameter()
                {
                    ParameterName = "@authorName",
                    Value = authorName
                }
            });

            SqlDataReader reader = h.MyExecuteReader(query);
            reader.Read();
            bookID = (int)reader["BookID"];
            reader.Close();
            return bookID;
        }
    }
}
