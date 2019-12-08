using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BookLeasing.Model;
using BookLeasing.CustomException;
using PublisherLeasing.DAL;

namespace PublisherLeasing.BLL
{
    public class PublisherController
    {
        PublisherManagement _publisherManagement;
        public PublisherController()
        {
            _publisherManagement = new PublisherManagement();

        }

        public bool Add(Publisher Publisher)
        {
            CheckFields(Publisher);
            int result = _publisherManagement.Insert(Publisher);
            return result > 0;
        }

        void CheckFields(Publisher Publisher)
        {
            if (string.IsNullOrWhiteSpace(Publisher.PublisherName))
            {
                throw new NotNullException("Yayınevi adı");
            }
        }

        public bool Update(Publisher Publisher)
        {
            CheckFields(Publisher);
            int result = _publisherManagement.Update(Publisher);
            return result > 0;

        }

        public bool Delete(Publisher Publisher)
        {
            int result = _publisherManagement.Delete(Publisher.PublisherID);
            return result > 0;

        }

        public Publisher GetPublisher(int PublisherID)
        {
            return _publisherManagement.GetPublisherByID(PublisherID);
        }

        public List<Publisher> GetPublishers()
        {
            return _publisherManagement.GetAllPublishers();
        }

        public int GetPublisherByName(Publisher currentPublisher)
        {
            return _publisherManagement.GetPublisherIDByName(currentPublisher.PublisherName);
        }
    }
}
