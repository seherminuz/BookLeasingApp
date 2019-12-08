using BookLeasing.DTO;
using BookLeasing.Model;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookLeasing.DAL
{
    public class PaymentManagement
    {
        Helper h;
        List<ReportDTO> reports;
        public PaymentManagement()
        {
            h = new Helper();
        }
        public int Insert(Payment payment)
        {
            string query = "INSERT INTO Payment(UserID,ReasonID,PaymentDate,PaymentTypeID, Fee) VALUES(@userID,@reasonID,@paymentDate,@paymentTypeID, @fee)";
            List<SqlParameter> parameters = GetParameters(payment, true);
            h.AddParametersToCommand(parameters);
            return h.MyExecuteQuery(query);
        }
        List<SqlParameter> GetParameters(Payment payment, bool isInsert)
        {
            List<SqlParameter> parameters = new List<SqlParameter>();
            if (!isInsert)
            {
                parameters.Add(new SqlParameter("@paymentID", payment.PaymentID));
            }
            parameters.Add(new SqlParameter("@userID", payment.UserID));
            parameters.Add(new SqlParameter("@reasonID", payment.ReasonID));
            parameters.Add(new SqlParameter("@paymentDate", payment.PaymentDate));
            parameters.Add(new SqlParameter("@paymentTypeID", payment.PaymentTypeID));
            parameters.Add(new SqlParameter("@fee", payment.Fee));

            return parameters;
        }

        public int Update(Payment payment)
        {
            string query = "UPDATE Payment SET UserID = @userID, ReasonID=@reasonID, Fee= @fee where PaymentID=@paymentID";
            List<SqlParameter> parameters = GetParameters(payment, false);
            h.AddParametersToCommand(parameters);
            return h.MyExecuteQuery(query);
        }

        public int Delete(int paymentID)
        {
            string query = "DELETE FROM Payment WHERE PaymentID = @paymentID";
            h.AddParametersToCommand(new List<SqlParameter>()
            {
                new SqlParameter()
                {
                    ParameterName = "@paymentID",
                    Value = paymentID

                }
            });

            return h.MyExecuteQuery(query);
        }

        public Payment GetPaymentByID(int paymentID)
        {
            string query = "SELECT * FROM Payment WHERE PaymentID = @paymentID";
            h.AddParametersToCommand(new List<SqlParameter>()
            {
                new SqlParameter()
                {
                    ParameterName = "@paymentID",
                    Value = paymentID

                }
            });

            Payment currentPayment = new Payment();
            SqlDataReader reader = h.MyExecuteReader(query);
            reader.Read();
            currentPayment.PaymentID = paymentID;
            currentPayment.UserID = (int)reader["UserID"];
            currentPayment.ReasonID = (int)reader["ReasonID"];
            currentPayment.PaymentDate = (DateTime)reader["PaymentDate"];
            currentPayment.PaymentTypeID = (int)reader["paymentTypeID"];
            currentPayment.Fee = (int)reader["Fee"];

            reader.Close();

            return currentPayment;
        }

        public List<Payment> GetAllPayments()
        {
            List<Payment> payments = new List<Payment>();
            string query = "SELECT * FROM Payment";

            Payment currentPayment;
            SqlDataReader reader = h.MyExecuteReader(query);
            while (reader.Read())
            {
                currentPayment = new Payment();
                currentPayment.PaymentID = (int)reader["PaymentID"];

                currentPayment.UserID = (int)reader["UserID"];
                currentPayment.ReasonID = (int)reader["ReasonID"];
                currentPayment.PaymentDate = (DateTime)reader["PaymentDate"];
                currentPayment.PaymentTypeID = (int)reader["PaymentTypeID"];
                currentPayment.Fee = (int)reader["Fee"];
                payments.Add(currentPayment);
            }
            reader.Close();

            return payments;
        }

        public List<ReportDTO> GetAllReports(string startDate, string endDate)
        {
            reports = new List<ReportDTO>();
            string query = "SELECT b.BookName, a.FirstName+ ' '+ a.LastName AS AuthorName, pub.PublisherName, COUNT(*) AS Total FROM [OrderDetail] od JOIN Payment p ON od.PaymentID=p.PaymentID JOIN [Order] o ON o.OrderID=od.OrderID JOIN Book b ON od.BookID=b.BookID JOIN Author a ON a.AuthorID = b.AuthorID JOIN Publisher pub ON pub.PublisherID = b.PublisherID WHERE o.BorrowingDate BETWEEN cast(@startDate as datetime) AND cast(@endDate as datetime) GROUP BY BookName,a.FirstName+ ' '+ a.LastName, pub.PublisherName, p.Fee";
            h.AddParametersToCommand(new List<SqlParameter>()
            {
                new SqlParameter()
                {
                    ParameterName = "@startDate",
                    Value = startDate
                },
                new SqlParameter()
                {
                    ParameterName = "@endDate",
                    Value = endDate
                }
            });

            ReportDTO currentReport;
            SqlDataReader reader = h.MyExecuteReader(query);
            while (reader.Read())
            {
                currentReport = new ReportDTO();
                currentReport.BookName = reader["BookName"].ToString();
                currentReport.AuthorName = reader["AuthorName"].ToString();
                currentReport.PublisherName = reader["PublisherName"].ToString();
                currentReport.Total = Convert.ToDecimal( reader["Total"]);


                reports.Add(currentReport);
            }
            reader.Close();

            return reports;
        }

        public List<ReportDTO> GetReport1(string startDate, string endDate)
        {
            List<ReportDTO> reports = new List<ReportDTO>();
            string query = "SELECT p.PublisherName, COUNT(*) AS Sayi FROM [OrderDetail] Od JOIN [Order] o ON od.OrderID = o.OrderID JOIN Book b ON b.BookID=od.BookID JOIN Publisher p ON p.PublisherID = b.PublisherID WHERE o.BorrowingDate BETWEEN  cast(@startDate as datetime) AND cast(@endDate as datetime) GROUP BY p.PublisherName";
            h.AddParametersToCommand(new List<SqlParameter>()
            {
                new SqlParameter()
                {
                    ParameterName = "@startDate",
                    Value = startDate
                },
                new SqlParameter()
                {
                    ParameterName = "@endDate",
                    Value = endDate
                }
            });

            ReportDTO currentReport;
            SqlDataReader reader = h.MyExecuteReader(query);
            while (reader.Read())
            {
                currentReport = new ReportDTO();
                currentReport.PublisherName = reader["PublisherName"].ToString();
                currentReport.Total = Convert.ToDecimal(reader["Sayi"]);
                reports.Add(currentReport);
            }
            reader.Close();

            return reports;
        }

        public List<ReportDTO> GetReport2(string startDate, string endDate)
        {
            List<ReportDTO> reports = new List<ReportDTO>();
            string query = "SELECT a.FirstName+a.LastName AS AuthorName, COUNT(*) AS Sayi FROM [OrderDetail] Od JOIN [Order] o ON od.OrderID = o.OrderID JOIN Book b ON b.BookID=od.BookID JOIN Author a ON a.AuthorID = b.AuthorID WHERE o.BorrowingDate BETWEEN cast(@startDate as datetime) AND cast(@endDate as datetime) GROUP BY a.FirstName+a.LastName";
            h.AddParametersToCommand(new List<SqlParameter>()
            {
                new SqlParameter()
                {
                    ParameterName = "@startDate",
                    Value = startDate
                },
                new SqlParameter()
                {
                    ParameterName = "@endDate",
                    Value = endDate
                }
            });

            ReportDTO currentReport;
            SqlDataReader reader = h.MyExecuteReader(query);
            while (reader.Read())
            {
                currentReport = new ReportDTO();
                currentReport.AuthorName = reader["AuthorName"].ToString();
                currentReport.Total = Convert.ToDecimal(reader["Sayi"]);
                reports.Add(currentReport);
            }
            reader.Close();

            return reports;
        }

        public List<ReportDTO> GetReport3(string startDate, string endDate)
        {
            List<ReportDTO> reports = new List<ReportDTO>();
            string query = "SELECT u.FirstName+' '+u.LastName as UserName,b.BookName, COUNT(*) AS KitapSayisi FROM [OrderDetail] Od JOIN [Order] o ON o.OrderID=od.OrderID JOIN [User] u ON u.UserID= o.UserID JOIN Book b ON b.BookID=od.BookID  WHERE o.BorrowingDate BETWEEN cast(@startDate as datetime) AND cast(@endDate as datetime) GROUP BY u.FirstName+' '+u.LastName, b.BookName";
            h.AddParametersToCommand(new List<SqlParameter>()
            {
                new SqlParameter()
                {
                    ParameterName = "@startDate",
                    Value = startDate
                },
                new SqlParameter()
                {
                    ParameterName = "@endDate",
                    Value = endDate
                }
            });

            ReportDTO currentReport;
            SqlDataReader reader = h.MyExecuteReader(query);
            while (reader.Read())
            {
                currentReport = new ReportDTO();
                currentReport.UserName = reader["UserName"].ToString();
                currentReport.BookName = reader["BookName"].ToString();
                currentReport.Total = Convert.ToDecimal(reader["KitapSayisi"]);
                reports.Add(currentReport);
            }
            reader.Close();

            return reports;
        }

        public List<ReportDTO> GetReport4(string startDate, string endDate)
        {
            List<ReportDTO> reports = new List<ReportDTO>();
            string query = "SELECT o.BorrowingDate, p.Fee FROM [Order] o JOIN [OrderDetail] od ON od.OrderID = o.OrderID JOIN Payment p ON p.PaymentID=od.PaymentID WHERE o.BorrowingDate  BETWEEN cast(@startDate as datetime) AND cast(@endDate as datetime) GROUP BY o.BorrowingDate, p.Fee";
            h.AddParametersToCommand(new List<SqlParameter>()
            {
                new SqlParameter()
                {
                    ParameterName = "@startDate",
                    Value = startDate
                },
                new SqlParameter()
                {
                    ParameterName = "@endDate",
                    Value = endDate
                }
            });

            ReportDTO currentReport;
            SqlDataReader reader = h.MyExecuteReader(query);
            while (reader.Read())
            {
                currentReport = new ReportDTO();
                currentReport.BorrowingDate = (DateTime)reader["BorrowingDate"];
                currentReport.Total = Convert.ToDecimal(reader["Fee"]);

                reports.Add(currentReport);
            }
            reader.Close();

            return reports;
        }
    }
}
