using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using New_Tailor_Shop_DataAccessLayer;

namespace New_Tailor_Shop_BusinessLayer
{
    public class clsPerson
    {
        enum enMode { Add, Update };
        private enMode _Mode = enMode.Update;
        public int ID { get; set; }
    public string Name { get; set; }
    public string Father { get; set; }
    public string GrandFather { get; set; }
    public string Family { get; set; }

        public clsPerson (int ID,string Name,string Father,string GrandFather,string Family)
        {
                       this.ID = ID;
            this.Name = Name;
            this.Father = Father;
            this.GrandFather = GrandFather;
            this.Family = Family;
            _Mode = enMode.Update;
        }
        public clsPerson()
        {
            this.ID = -1;
            this.Name = string.Empty;
            this.Father = "";
            this.GrandFather = "";
            this.Family = "";
            _Mode = enMode.Add;
        }
        private bool _Add()
        {
            this.ID=clsPerson_Data.Add(this.Name,this.Father,this.GrandFather,this.Family);
            return (this.ID != -1);
        }
         public static DataTable GetAllPersonWithThisID(string []ID) {

            return clsPerson_Data.GetAllPersonWithThisID(ID);
            
        }
        public static DataTable GetAllPersonWithThisName(string Name, string Father, string GrandFather, string Family)
        { 
            return clsPerson_Data.GetAllPersonWithThisName(Name, Father, GrandFather, Family);
        }
        //private bool _Update()
        //{

        //}
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
