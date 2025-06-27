using New_Tailor_Shop_DataAccessLayer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;
using New_Tailor_Shop_DataAccessLayer;
namespace New_Tailor_Shop_BusinessLayer
{
    public class clsCustomer
    {
        public int CustomerID { get; set; }
        public int PersonID { get; set; }

        enum enMode { Add, Update };
        enMode _Mode = enMode.Update;

        public clsCustomer(int PersonID)
        {
            this.PersonID =PersonID;
            this.CustomerID = -1;
            _Mode = enMode.Add;

        }
        private bool _Add()
        {
            this.CustomerID=clsCustomers_Data.Add(this.PersonID);
            return (this.CustomerID != -1);
        }
        public bool Save()
        {
            switch (_Mode)
            {
                case enMode.Add:
                    if (_Add())
                    {
                        _Mode = enMode.Update;
                        return true;
                    }
                    return false;
                case enMode.Update:
                    return false;
            }
            return false;
        }
    }
}
