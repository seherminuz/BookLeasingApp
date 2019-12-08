using BookLeasing.DAL;
using BookLeasing.Model;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PublisherLeasing.DAL
{
    public class PublisherManagement
    {
        Helper h;
        public PublisherManagement()
        {
            h = new Helper();
        }
        public int Insert(Publisher publisher)
        {
            string query = "INSERT INTO Publisher(PublisherName) VALUES(@publisherName)";
            List<SqlParameter> parameters = GetParameters(publisher, true);

            h.AddParametersToCommand(parameters);
            return h.MyExecuteQuery(query);
        }

        public int Update(Publisher publisher)
        {
            string query = "UPDATE Publisher SET PublisherName = @publisherName WHERE PublisherID = @publisherID";
            List<SqlParameter> parameters = GetParameters(publisher, false);

            h.AddParametersToCommand(parameters);
            return h.MyExecuteQuery(query);
        }

        List<SqlParameter> GetParameters(Publisher publisher, bool isInsert)
        {
            List<SqlParameter> parameters = new List<SqlParameter>();
            if (!isInsert)
            {
                parameters.Add(new SqlParameter("@publisherID", publisher.PublisherID));
            }
            parameters.Add(new SqlParameter("@publisherName", publisher.PublisherName));
            return parameters;
        }

        public int Delete(int publisherID)
        {
            string query = "DELETE FROM Publisher WHERE PublisherID = @publisherID";
            h.AddParametersToCommand(new List<SqlParameter>()
            {
                new SqlParameter()
                {
                    ParameterName = "@publisherID",
                    Value = publisherID
                }
            });

            return h.MyExecuteQuery(query);
        }

        public int GetPublisherIDByName(string publisherName)
        {
            Publisher cP = new Publisher();
            string query = "SELECT PublisherID FROM Publisher WHERE PublisherName = @publisherName";
            h.AddParametersToCommand(new List<SqlParameter>()
            {
                new SqlParameter()
                {
                    ParameterName = "@publisherName",
                    Value = publisherName
                }
            });
            SqlDataReader reader = h.MyExecuteReader(query);
            while (reader.Read())
            {
                
                cP.PublisherID = (int)reader["PublisherID"];

            }
            reader.Close();

            return cP.PublisherID;

        }

        public Publisher GetPublisherByID(int publisherID)
        {
            Publisher currentPublisher = new Publisher();
            string query = "SELECT * FROM Publisher WHERE PublisherID = @publisherID";
            h.AddParametersToCommand(new List<SqlParameter>()
            {
                new SqlParameter()
                {
                    ParameterName = "@publisherID",
                    Value = publisherID
                }
            });

            SqlDataReader reader = h.MyExecuteReader(query);
            reader.Read();
            currentPublisher.PublisherID = publisherID;
            currentPublisher.PublisherName = reader["PublisherName"].ToString();

            reader.Close();

            return currentPublisher;
        }

        public List<Publisher> GetAllPublishers()
        {
            List<Publisher> publishers = new List<Publisher>();
            Publisher currentPublisher = null;
            string query = "SELECT * FROM Publisher";

            SqlDataReader reader = h.MyExecuteReader(query);
            while (reader.Read())
            {
                currentPublisher = new Publisher();
                currentPublisher.PublisherID = (int)reader["PublisherID"];
                currentPublisher.PublisherName = reader["PublisherName"].ToString();
                publishers.Add(currentPublisher);
            }
            reader.Close();

            return publishers;
        }
    }
}
