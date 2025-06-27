using New_Tailor_Shop_BusinessLayer;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Project_New_Tailor_Shop
{
    public partial class FormAddNewNumber : Form
    {
        private int ID = -1;
        public FormAddNewNumber(int _PersonID)
        {
            ID = _PersonID;
        InitializeComponent();


        }
        public FormAddNewNumber()
        {
         
            InitializeComponent();


        }
        public static bool AddPhone(int PersonID, object Number, object Note)
        {


            clsPhone Phone = new clsPhone(PersonID);
            Phone.PhoneNumber = ((TextBox)Number).Text.Trim();
            if (!string.IsNullOrEmpty(((TextBox)Note).Text.Trim()))
            {
                Phone.Note = ((TextBox)Note).Text.Trim();
            }

            if (Phone.Save())
            {
                return true;
            }
            return false;
        }
        private void butADD_Click(object sender, EventArgs e)
        {
            if(AddPhone(ID, textNumber, textNote))
            {
                MessageBox.Show("تمت الإضافة بنجاح", "نجاح", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.DialogResult = DialogResult.OK;
                this.Close();
            }
            else
            {
                MessageBox.Show("حدث خطأ أثناء الإضافة", "خطأ", MessageBoxButtons.OK, MessageBoxIcon.Error);
                this.DialogResult = DialogResult.Cancel;
                this.Close();
            }
          
        }

        private void butClose_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
            this.Close();
        }

      
    }
}
