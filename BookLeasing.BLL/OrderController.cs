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
    public class OrderController
    {
        OrderManagement _orderManagement;
        public OrderController()
        {
            _orderManagement = new OrderManagement();
        }
        public bool Add(int userID)
        {
            CheckBookCount(userID);
            int result = _orderManagement.Insert(userID);
            return result > 0;
        }

        public bool AddOrderDetail(OrderDetailDTO orderDetail)
        {
            int result = _orderManagement.InsertOrderDetail(orderDetail);
            return result > 0;
        }

        void CheckBookCount(int UserID)
        {
            if (_orderManagement.GetOrdersOfUser(UserID).Count >= 3)
            {
                throw new OverStockException();
            }
        }

        public bool Update(Order order)
        {
            int result = _orderManagement.Update(order);
            return result > 0;
        }

        public bool UpdateOrderDetail(OrderDetailDTO orderDetail)
        {
            int result = _orderManagement.UpdateOrderDetail(orderDetail);
            return result > 0;
        }

        public bool Delete(int OrderID)
        {
            int result = _orderManagement.Delete(OrderID);
            return result > 0;
        }

        public bool DeleteOrderDetail(int OrderID)
        {
            int result = _orderManagement.DeleteOrderDetail(OrderID);
            return result > 0;
        }

        public Order GetOrder(int orderID)
        {
            return _orderManagement.GetOrderByID(orderID);
        }

        public List<Order> GetAllOrders()
        {
            return _orderManagement.GetAllOrders();
        }

        public List<OrderDTO> GetOrderDTOsOfUser(int UserID)
        {
            return _orderManagement.GetOrderDTOsOfUser(UserID);
        }

        public List<Order> GetOrdersOfUser(int UserID)
        {
            return _orderManagement.GetOrdersOfUser(UserID);
        }

        public int GetOrderOfUser (int UserID)
        {
            return _orderManagement.GetOrderOfUser(UserID);
        }

        public List<OrderDTO> GetAllLeasedBooks()
        {
            return _orderManagement.GetAllLeasedBooks();
        }
    }
}
