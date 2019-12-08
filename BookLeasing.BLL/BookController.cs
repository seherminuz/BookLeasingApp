using BookLeasing.CustomException;
using BookLeasing.DAL;
using BookLeasing.DTO;
using BookLeasing.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookLeasing.BLL
{
    public class BookController
    {
        BookManagement _BookManagement;
        public BookController()
        {
            _BookManagement = new BookManagement();

        }

        public bool Add(Book Book)
        {
            CheckFields(Book);
            int result = _BookManagement.Insert(Book);
            return result > 0;
        }

        public bool AddFavs(FavoriteDTO book)
        {
            CheckFavBook(book);
            int result = _BookManagement.InsertFavorite(book);
            return result > 0;
        }

        void CheckFields(Book book)
        {
            if (string.IsNullOrWhiteSpace(book.BookName))
            {
                throw new NotNullException("Kitap adı");
            }
            else if (string.IsNullOrWhiteSpace(book.PageCount.ToString()))
            {
                throw new NotNullException("Sayfa sayısı");
            }
            else if (string.IsNullOrWhiteSpace(book.Price.ToString()))
            {
                throw new NotNullException("Kitap fiyatı");
            }
            else if (string.IsNullOrWhiteSpace(book.PublishingYear.ToString()))
            {
                throw new NotNullException("Yayınlanma yılı");
            }
            else if (string.IsNullOrWhiteSpace(book.Summary))
            {
                throw new NotNullException("Özet");
            }
        }

        void CheckFavBook(FavoriteDTO book)
        {
            List<FavoriteDTO> favs = _BookManagement.GetAllFavDTOs();
            foreach (FavoriteDTO item in favs)
            {
                if (item.BookID == book.BookID && item.UserID == book.UserID)
                {
                    throw new AlreadyAddedException();
                }
            }
        }

        public bool Update(Book book)
        {
            CheckFields(book);
            int result = _BookManagement.Update(book);
            return result > 0;
        }

        public bool UpdateFavs(FavoriteDTO book)
        {
            int result = _BookManagement.UpdateFavorites(book);
            return result > 0;
        }

        public bool UpdateIsAvailable(int bookID)
        {
            int result = _BookManagement.UpdateIsAvailable(bookID);
            return result > 0;
        }

        public bool Delete(Book book)
        {
            int result = _BookManagement.Delete(book.BookID);
            return result > 0;
        }

        public bool DeleteFavs(int bookID)
        {
            int result = _BookManagement.DeleteFav(bookID);
            return result > 0;
        }

        public Book GetBook(int BookID)
        {
            return _BookManagement.GetBookByID(BookID);
        }

        public List<BookDTO> GetBooks()
        {
            return _BookManagement.GetAllBookss();
        }

        public List<BookDTO> GetFavs()
        {
            return _BookManagement.GetAllFavs();
        }

        public List<BookDTO> GetBookByPreference(string value, bool flag)
        {
            List<BookDTO> dTOs = _BookManagement.GetBookByPreference(value, flag);

            return dTOs;
        }

        public int GetBookIDByName(string bookName, string authorName)
        {
            return _BookManagement.GetBookIDByName(bookName, authorName);
        }
    }
}
