using BookLeasing.Model;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookLeasing.DAL
{
    public class PaymentTypeManagement
    {
        Helper h;
        public PaymentTypeManagement()
        {
            h = new Helper();
        }

        public int Insert(PaymentType paymentType)
        {
            string query = "INSERT INTO PaymentType(Description) VALUES(@description)";
            List<SqlParameter> parameters = GetParameters(paymentType, true);
            h.AddParametersToCommand(parameters);
            return h.MyExecuteQuery(query);
        }

        List<SqlParameter> GetParameters(PaymentType paymentType, bool isInsert)
        {
            List<SqlParameter> parameters = new List<SqlParameter>();

            if (isInsert)
            {
                parameters.Add(new SqlParameter("@paymentTypeID", paymentType.PaymentTypeID));
            }
            parameters.Add(new SqlParameter("@description", paymentType.Description));

            return parameters;
        }

        public int Update(PaymentType PaymentType)
        {
            string query = "UPDATE PaymentType SET Description = @description where PaymentTypeID=@paymentTypeID";
            List<SqlParameter> parameters = GetParameters(PaymentType, true);

            h.AddParametersToCommand(parameters);
            return h.MyExecuteQuery(query);
        }

        public int Delete(int PaymentTypeID)
        {
            string query = "DELETE FROM PaymentType WHERE PaymentTypeID  = @paymentTypeID";
            h.AddParametersToCommand(new List<SqlParameter>()
            {
                new SqlParameter()
                {
                    ParameterName = "@paymentTypeID",
                    Value = PaymentTypeID

                }
            });

            return h.MyExecuteQuery(query);
        }

        public PaymentType GetPaymentTypeByID(int PaymentTypeID)
        {
            string query = "SELECT * FROM PaymentType WHERE PaymentTypeID = @paymentTypeID";
            h.AddParametersToCommand(new List<SqlParameter>()
            {
                new SqlParameter()
                {
                    ParameterName = "@paymentTypeID",
                    Value = PaymentTypeID

                }
            });

            PaymentType currentPaymentType = new PaymentType();
            SqlDataReader reader = h.MyExecuteReader(query);
            reader.Read();

            currentPaymentType.PaymentTypeID = (int)reader["PaymentTypeID"];
            currentPaymentType.Description = reader["Description"].ToString();

            reader.Close();

            return currentPaymentType;
        }

        public List<PaymentType> GetAllPaymentTypes()
        {
            List<PaymentType> PaymentTypes = new List<PaymentType>();
            string query = "SELECT * FROM PaymentType";

            PaymentType currentPaymentType;
            SqlDataReader reader = h.MyExecuteReader(query);
            while (reader.Read())
            {
                currentPaymentType = new PaymentType();
                currentPaymentType.Description = reader["Description"].ToString();
                currentPaymentType.PaymentTypeID = (int)reader["PaymentTypeID"];

                PaymentTypes.Add(currentPaymentType);
            }
            reader.Close();

            return PaymentTypes;
        }

        public int GetTypeIDByName(string name)
        {
            int typeID = 0;

            string query = "SELECT PaymentTypeID FROM PaymentType WHERE Description = @name";
            h.AddParametersToCommand(new List<SqlParameter>()
            {
                new SqlParameter()
                {
                    ParameterName = "@name",
                    Value = name
                }
            });

            SqlDataReader reader = h.MyExecuteReader(query);
            reader.Read();
            typeID = (int)reader["PaymentTypeID"];
            reader.Close();
            return typeID;
        }

    }
}
