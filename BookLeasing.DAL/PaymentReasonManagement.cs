using BookLeasing.Model;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookLeasing.DAL
{
    public class PaymentReasonManagement
    {
        Helper h;
        public PaymentReasonManagement()
        {
            h = new Helper();
        }

        public int Insert(PaymentReason paymentReason)
        {
            string query = "INSERT INTO [PaymentReason](Reason) VALUES(@reason)";
            List<SqlParameter> parameters = GetParameters(paymentReason, true);
            h.AddParametersToCommand(parameters);
            return h.MyExecuteQuery(query);
        }

        List<SqlParameter> GetParameters(PaymentReason paymentReason, bool isInsert)
        {
            List<SqlParameter> parameters = new List<SqlParameter>();

            if (isInsert)
            {
                parameters.Add(new SqlParameter("@reasonID", paymentReason.ReasonID));
            }
            parameters.Add(new SqlParameter("@reason", paymentReason.Reason));

            return parameters;
        }

        public int Update(PaymentReason PaymentReason)
        {
            string query = "UPDATE [PaymentReason] SET Reason = @reason  WHERE ReasonID=@reasonID";
            List<SqlParameter> parameters = GetParameters(PaymentReason, true);

            h.AddParametersToCommand(parameters);
            return h.MyExecuteQuery(query);
        }

        public int Delete(int PaymentReasonID)
        {
            string query = "DELETE FROM [PaymentReason] WHERE ReasonID  = @reasonID";
            h.AddParametersToCommand(new List<SqlParameter>()
            {
                new SqlParameter()
                {
                    ParameterName = "@reasonID",
                    Value = PaymentReasonID

                }
            });

            return h.MyExecuteQuery(query);
        }

        public PaymentReason GetPaymentReasonByID(int PaymentReasonID)
        {
            string query = "SELECT * FROM [PaymentReason] WHERE PaymentReasonID = @reasonID";
            h.AddParametersToCommand(new List<SqlParameter>()
            {
                new SqlParameter()
                {
                    ParameterName = "@reasonID",
                    Value = PaymentReasonID

                }
            });

            PaymentReason currentPaymentReason = new PaymentReason();
            SqlDataReader reader = h.MyExecuteReader(query);
            reader.Read();

            currentPaymentReason.ReasonID = (int)reader["ReasonID"];
            currentPaymentReason.Reason = reader["Reason"].ToString();

            reader.Close();

            return currentPaymentReason;
        }

        public List<PaymentReason> GetAllPaymentReasons()
        {
            List<PaymentReason> PaymentReasons = new List<PaymentReason>();
            string query = "SELECT * FROM [PaymentReason]";

            PaymentReason currentPaymentReason;
            SqlDataReader reader = h.MyExecuteReader(query);
            while (reader.Read())
            {
                currentPaymentReason = new PaymentReason();
                currentPaymentReason.Reason = reader["Reason"].ToString();
                currentPaymentReason.ReasonID = (int)reader["ReasonID"];

                PaymentReasons.Add(currentPaymentReason);
            }
            reader.Close();

            return PaymentReasons;
        }

        public int GetReasonIDByName(string name)
        {
            int reasonID = 0;

            string query = "SELECT ReasonID FROM PaymentReason WHERE Reason = @name";
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
            reasonID = (int)reader["ReasonID"];
            reader.Close();
            return reasonID;
        }

    }
}
