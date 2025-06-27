using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;

namespace New_Tailor_Shop_DataAccessLayer
{
    public class clsPhone_Data
    {
      public static int Add(string PhoneNumber,int Person_ID,string Note)
        {
            using (SqlConnection conn = new SqlConnection(clsDataBaseAddress.GetConnectionString))
            {
                int PhoneID = -1;
                conn.Open();
                using (SqlCommand cmd = new SqlCommand(@"INSERT INTO Phones (PhoneNumber, Person_ID, Note) OUTPUT INSERTED.PhoneID VALUES (@PhoneNumber, @Person_ID, @Note)", conn))
                {
                    cmd.Parameters.AddWithValue("@PhoneNumber", PhoneNumber);
                    cmd.Parameters.AddWithValue("@Person_ID", Person_ID);

                    cmd.Parameters.AddWithValue("@Note", string.IsNullOrWhiteSpace(Note) ? System.DBNull.Value : (object)Note);
                    

                    PhoneID= (int)cmd.ExecuteScalar(); 
                }
                return PhoneID;
            }
        }


        public static string[] GetPerson_ID(string Phone)
        {
            string[] person = new string[4];
            using (SqlConnection Connection = new SqlConnection(clsDataBaseAddress.GetConnectionString))
            {
                int i = 0;
                string Query = @"select Phones.Person_ID from Phones where PhoneNumber=@Phone;";
                using (SqlCommand cmd = new SqlCommand(Query, Connection))
                {
                    Connection.Open();
                        cmd.Parameters.AddWithValue("@Phone", Phone);
                    using (SqlDataReader Data = cmd.ExecuteReader())
                    {
                        while (Data.Read())
                        {
                            if (i < 4)
                            {
                                person[i] = Data["Person_ID"].ToString();
                                i++;
                            }
                        }
                        return person;

                    }

                    return person = null;
                }


            }
        }

        public static  DataTable FindID(string ID)
        {
         
            using (SqlConnection Connection = new SqlConnection(clsDataBaseAddress.GetConnectionString))
            {
                DataTable Table = new DataTable();
                string Query = @"select * from Phones where Person_ID=@ID;";
                using (SqlCommand cmd = new SqlCommand(Query, Connection))
                {
                    Connection.Open();
                    cmd.Parameters.AddWithValue("@ID", ID);
                    using (SqlDataReader Data = cmd.ExecuteReader())
                    {
                        if (Data.HasRows)
                        {
                            Table.Load(Data);
                        }


                        return Table;
                    }

                }


            }
        }
        public static bool Update(int PhoneID, string PhoneNumber, int Person_ID, string Note)
        {
            using (SqlConnection conn = new SqlConnection(clsDataBaseAddress.GetConnectionString))
            {
                conn.Open();
                using (SqlCommand cmd = new SqlCommand("UPDATE Phones SET PhoneNumber = @PhoneNumber, Person_ID = @Person_ID, Note = @Note WHERE PhoneID = @PhoneID", conn))
                {
                    cmd.Parameters.AddWithValue("@PhoneID", PhoneID);
                    cmd.Parameters.AddWithValue("@PhoneNumber", PhoneNumber);
                    cmd.Parameters.AddWithValue("@Person_ID", Person_ID);
                    cmd.Parameters.AddWithValue("@Note", Note);
                    return cmd.ExecuteNonQuery() > 0; // Returns true if at least one row was updated
                }
            }
        }
    }
}
