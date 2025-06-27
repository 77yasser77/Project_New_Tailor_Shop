using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace New_Tailor_Shop_DataAccessLayer
{
    public class clsCustomers_Data
    {
      

       public static int Add(int PersonID)
        {
          int CustomerID = -1;
            using (SqlConnection connection = new SqlConnection(clsDataBaseAddress.GetConnectionString))
            {
                string query = "INSERT INTO Customers (PersonID) OUTPUT INSERTED.CustomerID VALUES (@PersonID)";
                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@PersonID", PersonID);
                    try
                    {
                        connection.Open();
                        CustomerID = (int)command.ExecuteScalar();
                    }
                    finally { command.Clone(); }
                    
                }
            }
            return CustomerID;

        }
    }
}
