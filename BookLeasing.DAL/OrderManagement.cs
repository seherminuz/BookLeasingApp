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
    public class OrderManagement
    {
        Helper h;
        public OrderManagement()
        {
            h = new Helper();
        }

        public int Insert(int userID)
        {
            string query = "INSERT INTO [Order](UserID) VALUES(@userID)";
            h.AddParametersToCommand(new List<SqlParameter>()
            {
                new SqlParameter()
                {
                    ParameterName = "@userID",
                    Value = userID
                }
            });
            return h.MyExecuteQuery(query);
        }

        public int InsertOrderDetail(OrderDetailDTO orderDetail)
        {
            string query = "INSERT INTO OrderDetail(OrderID, BookID, PaymentID) VALUES(@orderID, @bookID, @paymentID)";
            List<SqlParameter> parameters = GetParametersOrderDetail(orderDetail);

            h.AddParametersToCommand(parameters);
            return h.MyExecuteQuery(query);
        }

        List<SqlParameter> GetParametersOrderDetail(OrderDetailDTO orderDetail)
        {
            List<SqlParameter> parameters = new List<SqlParameter>();
            parameters.Add(new SqlParameter("@orderID", orderDetail.OrderID));
            parameters.Add(new SqlParameter("@bookID", orderDetail.BookID));
            parameters.Add(new SqlParameter("@paymentID", orderDetail.PaymentID));
            return parameters;
        }

        List<SqlParameter> GetParameters(Order order)
        {
            List<SqlParameter> parameters = new List<SqlParameter>();
            parameters.Add(new SqlParameter("@orderID", order.OrderID));
            parameters.Add(new SqlParameter("@userID", order.UserID));
            parameters.Add(new SqlParameter("@borrowingDate", order.BorrowingDate));
            parameters.Add(new SqlParameter("@givingBackDate", order.GivingBackDate));
            parameters.Add(new SqlParameter("@requiredDate", order.RequiredDate));
            parameters.Add(new SqlParameter("@isDamaged", order.IsDamaged));
            return parameters;
        }

        public int Update(Order order)
        {
            string query = "UPDATE [Order] SET BorrowingDate = @borrowingDate, IsDamaged=@isDamaged where UserID=@userID";
            List<SqlParameter> parameters = GetParameters(order);
            h.AddParametersToCommand(parameters);
            return h.MyExecuteQuery(query);
        }

        public int UpdateOrderDetail(OrderDetailDTO orderDetail)
        {
            string query = "UPDATE OrderDetail SET BookID = @bookID, PaymentID = @paymentID WHERE UserID = @userID";
            List<SqlParameter> parameters = GetParametersOrderDetail(orderDetail);
            h.AddParametersToCommand(parameters);
            return h.MyExecuteQuery(query);
        }

        public int Delete(int orderID)
        {
            string query = "DELETE FROM [Order] WHERE OrderID = @orderID";
            h.AddParametersToCommand(new List<SqlParameter>()
            {
                new SqlParameter()
                {
                    ParameterName = "@orderID",
                    Value = orderID

                }
            });

            return h.MyExecuteQuery(query);
        }

        public int DeleteOrderDetail(int orderID)
        {
            string query = "DELETE FROM OrderDetail WHERE OrderID = @orderID";
            h.AddParametersToCommand(new List<SqlParameter>()
            {
                new SqlParameter()
                {
                    ParameterName = "@orderID",
                    Value = orderID
                }
            });

            return h.MyExecuteQuery(query);
        }

        public Order GetOrderByID(int orderID)
        {
            string query = "SELECT * FROM [Order] WHERE OrderID = @orderID";
            h.AddParametersToCommand(new List<SqlParameter>()
            {
                new SqlParameter()
                {
                    ParameterName = "@orderID",
                    Value = orderID

                }
            });

            Order currentOrder = new Order();
            SqlDataReader reader = h.MyExecuteReader(query);
            reader.Read();
            currentOrder.OrderID = orderID;
            currentOrder.UserID = (int)reader["UserID"];
            currentOrder.RequiredDate = (DateTime)reader["RequiredDate"];
            currentOrder.BorrowingDate = (DateTime)reader["BorrowingDate"];
            currentOrder.GivingBackDate = (DateTime)reader["GivingBackDate"];
            currentOrder.IsDamaged = (bool)reader["IsDamaged"];

            reader.Close();

            return currentOrder;
        }

        public List<OrderDTO> GetOrderDTOsOfUser(int userID)
        {
            List<OrderDTO> orders = new List<OrderDTO>();
            string query = "SELECT b.BookName, a.FirstName + ' ' + a.LastName AS AuthorName, o.BorrowingDate,o.GivingBackDate, o.RequieredDate, o.IsDamaged FROM[Order] o JOIN OrderDetail od ON o.OrderID = od.OrderID JOIN Book b ON b.BookID = od.BookID JOIN Author a ON a.AuthorID = b.AuthorID WHERE UserID = @userID";
            h.AddParametersToCommand(new List<SqlParameter>()
            {
                new SqlParameter()
                {
                    ParameterName = "@userID",
                    Value = userID
                }
            });

            OrderDTO currentOrder;
            SqlDataReader reader = h.MyExecuteReader(query);
            while (reader.Read())
            {
                currentOrder = new OrderDTO();
                currentOrder.BookName = reader["BookName"].ToString();

                currentOrder.AuthorName = reader["AuthorName"].ToString();
                currentOrder.RequiredDate = (DateTime)reader["RequieredDate"];
                currentOrder.BorrowingDate = (DateTime)reader["BorrowingDate"];
                orders.Add(currentOrder);
            }
            reader.Close();

            return orders;
        }

        public List<Order> GetOrdersOfUser(int userID)
        {
            List<Order> orders = new List<Order>();
            string query = "SELECT * FROM [Order] WHERE UserID = @userID";
            h.AddParametersToCommand(new List<SqlParameter>()
            {
                new SqlParameter()
                {
                    ParameterName = "@userID",
                    Value = userID
                }
            });

            Order currentOrder;
            SqlDataReader reader = h.MyExecuteReader(query);
            while (reader.Read())
            {
                currentOrder = new Order();
                currentOrder.OrderID = (int)reader["orderID"];
                currentOrder.UserID = userID;
                currentOrder.RequiredDate = (DateTime)reader["RequieredDate"];
                currentOrder.BorrowingDate = (DateTime)reader["BorrowingDate"];
                orders.Add(currentOrder);
            }
            reader.Close();

            return orders;
        }

        public int GetOrderOfUser(int userID)
        {
            int orderID = 0;
            string query = "SELECT OrderID FROM [Order] WHERE UserID = @userID";
            h.AddParametersToCommand(new List<SqlParameter>()
            {
                new SqlParameter()
                {
                    ParameterName = "@userID",
                    Value = userID
                }
            });

            SqlDataReader reader = h.MyExecuteReader(query);
            while (reader.Read())
            {
                orderID = (int)reader["orderID"];
            }
            reader.Close();

            return orderID;
        }

        public List<Order> GetAllOrders()
        {
            List<Order> orders = new List<Order>();
            string query = "SELECT * FROM [Order]";

            Order currentOrder;
            SqlDataReader reader = h.MyExecuteReader(query);
            while (reader.Read())
            {
                currentOrder = new Order();
                currentOrder.OrderID = (int)reader["orderID"];

                currentOrder.UserID = (int)reader["UserID"];
                currentOrder.RequiredDate = (DateTime)reader["RequieredDate"];
                currentOrder.BorrowingDate = (DateTime)reader["BorrowingDate"];
                currentOrder.GivingBackDate = (DateTime)reader["GivingBackDate"];
                currentOrder.IsDamaged = (bool)reader["IsDamaged"];
                orders.Add(currentOrder);
            }
            reader.Close();

            return orders;
        }

        public List<OrderDTO> GetAllLeasedBooks()
        {
            List<OrderDTO> orders = new List<OrderDTO>();
            string query = "SELECT b.BookName, a.FirstName + ' ' + a.LastName AS AuthorName, o.BorrowingDate,o.GivingBackDate, o.RequieredDate, o.IsDamaged FROM[Order] o JOIN OrderDetail od ON o.OrderID = od.OrderID JOIN Book b ON b.BookID = od.BookID JOIN Author a ON a.AuthorID = b.AuthorID";

            OrderDTO currentOrder;
            SqlDataReader reader = h.MyExecuteReader(query);
            while (reader.Read())
            {
                currentOrder = new OrderDTO();
                currentOrder.BookName = reader["BookName"].ToString();
                currentOrder.AuthorName = reader["AuthorName"].ToString();
                currentOrder.RequiredDate = (DateTime)reader["RequieredDate"];
                currentOrder.BorrowingDate = (DateTime)reader["BorrowingDate"];
                currentOrder.GivingBackDate = (DateTime)reader["GivingBackDate"];
                currentOrder.IsDamaged = (bool)reader["IsDamaged"];
                orders.Add(currentOrder);
            }
            reader.Close();
            return orders;
        }
    }
}
