using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;
namespace New_Tailor_Shop_DataAccessLayer
{
    public  class clsPerson_Data
    {
        static public int Add(string Name,string Father ,string GrandFather,string Family)
        {
            int PersonID = -1;
            SqlConnection Connection = new SqlConnection(clsDataBaseAddress.GetConnectionString);
            string Query = "INSERT INTO Person(PersonName,PersonFather,personGrandFather,FamilyName)Values(@Name,@Father,@GrandFather,@Family);" +
                " SELECT SCOPE_IDENTITY();";
            SqlCommand Command = new SqlCommand(Query, Connection);
            Command.Parameters.AddWithValue("@Name", Name);
            Command.Parameters.AddWithValue("@Father", Father);
            Command.Parameters.AddWithValue("@GrandFather", GrandFather);
            Command.Parameters.AddWithValue("@Family", Family);
            try
            {
                Connection.Open();
                object result = Command.ExecuteScalar();
                if (result != null && int.TryParse(result.ToString(), out int ID))
                    PersonID = ID;


              

            }
            finally
            {
                Connection.Close();
            }
            return PersonID;

        }

        static public DataTable GetAllPersonWithThisID( string []ID)
        {
       
         
            SqlConnection Connection = new SqlConnection(clsDataBaseAddress.GetConnectionString);
            string Query = @"select person.PersonID, person.PersonName,person.PersonFather,person.personGrandFather,person.FamilyName from person " +
"where PersonID=@ID0 or PersonID=@ID1 or PersonID=@ID2 or PersonID=@ID3";
            SqlCommand Command = new SqlCommand(Query, Connection);
            Command.Parameters.AddWithValue("@ID0", ID[0] != null ? ID[0] : "0");
            Command.Parameters.AddWithValue("@ID1", ID[1] != null ? ID[1] : "0");
            Command.Parameters.AddWithValue("@ID2", ID[2] != null ? ID[2] : "0");
            Command.Parameters.AddWithValue("@ID3", ID[3] != null ? ID[3] : "0");
            DataTable Table = new DataTable();
            try
            {
                Connection.Open();


                SqlDataReader Reader = Command.ExecuteReader();
               
                if (Reader.HasRows)
                {
                    Table.Load(Reader);
                 
                }
                Reader.Close();
            }
            finally
            {
                
                Connection.Close();
            }
            return Table;
        }
        static public DataTable GetAllPersonWithThisName(string Name, string Father, string GrandFathe, string Family)
        {
            SqlConnection Connection = new SqlConnection(clsDataBaseAddress.GetConnectionString);
            string Query = @"select * from person where PersonName=@Name and PersonFather=@Father and personGrandFather=@GrandFathe and FamilyName=@Family";
            SqlCommand Command = new SqlCommand(Query, Connection);
            Command.Parameters.AddWithValue("@Name", Name);
            Command.Parameters.AddWithValue("@Father", Father);
            Command.Parameters.AddWithValue("@GrandFathe", GrandFathe);
            Command.Parameters.AddWithValue("@Family", Family);
            DataTable Table = new DataTable();
            try
            {
                Connection.Open();
                SqlDataReader Reader = Command.ExecuteReader();
               
                if (Reader.HasRows)
                {
                    Table.Load(Reader);
                }
                Reader.Close();
                
            }
            finally
            {
                Connection.Close();

            }
            return Table;


        }
       
            
            
            
            
            
            
            
            static public bool Find(ref int ID,  string Name,  string Father,  string GrandFather,  string Family)
        {
            bool Found = false;
            SqlConnection Connection = new SqlConnection(clsDataBaseAddress.GetConnectionString);
            string Query = @"select * from Person Where person.PersonName='@Name' and PersonFather='@Father'and Person.personGrandFather='@GrandFather' and person.FamilyName='@Family';";
            SqlCommand Command = new SqlCommand(Query, Connection);
            Command.Parameters.AddWithValue("@Name", ID);
            Command.Parameters.AddWithValue("@Father", Father);
            Command.Parameters.AddWithValue("@GrandFather", GrandFather);
            Command.Parameters.AddWithValue("@Family", Family);

            try
            {
                Connection.Open();
                SqlDataReader Reader = Command.ExecuteReader();
                if (Reader.Read())
                {
                    Found = true;
                    ID = Convert.ToInt32(Reader["PersonID"]);
                }
                Reader.Close();
            }
            finally
            {

                Connection.Close();
            }
            return Found;
        }



    }
}
