using New_Tailor_Shop_DataAccessLayer;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace New_Tailor_Shop_BusinessLayer
{
    public class clsPhone
    {
        enum _Mode { Add, Update };
        _Mode Mode = _Mode.Update;
        public int PhoneID { get; set; }
        public string PhoneNumber { get; set; }
        public int Person_ID { get; set; }
        public string Note { get; set; }


      public  clsPhone(int PhoneID, string PhoneNumber, int Person_ID, string Note)
        {
            this.PhoneID = PhoneID;
            this.PhoneNumber = PhoneNumber;
            this.Person_ID = Person_ID;
            this.Note = Note;
            Mode = _Mode.Update;

        }

        public clsPhone(int Person_ID)
        {
            this.PhoneID = -1;
            this.PhoneNumber = "";
            this.Person_ID = Person_ID;
            this.Note = "";
            Mode = _Mode.Add;
        }

        private bool Add()
        {
            this.PhoneID = clsPhone_Data.Add(this.PhoneNumber, this.Person_ID, this.Note);
            return (this.PhoneID != -1);

        }
        static public string[] GitPerson_ID(string PhoneNumber)
        {
            return clsPhone_Data.GetPerson_ID(PhoneNumber);
        }

        static public DataTable FindID(string ID)
        {
            return clsPhone_Data.FindID(ID);
        }
        public bool Save()
        {
            switch (Mode)
            {
                case _Mode.Add:
                    if (Add())
                        return true;
                    else
                        return false;
                case _Mode.Update:
                    // Call the data access layer to update an existing phone record
                    // clsPhone_Data.Update(this);
                    return true;
            }
                        
            return false;
                        

        }
    }
}
