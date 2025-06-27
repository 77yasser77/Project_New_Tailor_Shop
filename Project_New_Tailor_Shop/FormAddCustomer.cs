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
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Project_New_Tailor_Shop
{
    public partial class FormAddCustomer : Form
    {
        public FormAddCustomer()
        {
            InitializeComponent();
        }

        clsPerson Person = new clsPerson();
        private int  AddPerson()
        {
            
           
            int ID = -1;
                Person.Name =(string) textName.Text ;
                Person.Father = (string)textNameFather.Text;
                Person.GrandFather = (string)textGreangFather.Text;
                Person.Family = (string)textFamliy.Text;
            try
            {
                if (Person.Save())
                {
                    ID = Person.ID;
                    if (FormAddNewNumber.AddPhone(Person.ID, textNumber, textNote))
                    {
                        ID = Person.ID;
                    }
                  
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("هناك مشكله في ادخال البيانات في قاعدة البيانات ", "مشكلة ");
            }
                
           
            return ID;
        }

        private bool AddCustomer(int PersonID)
        {


            if (PersonID != -1)
            {
                clsCustomer Customer = new clsCustomer(PersonID);
                if (Customer.Save())
                {
                   
                    return true;
                }
                else
                {
              
                }

            }
            return false;
        }
        private void butAdd_Click(object sender, EventArgs e)
        {

                if (AddCustomer(AddPerson()))
                {
                    MessageBox.Show("تم إضافة الزبون", "نجاح", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    textName.Enabled = false;
                    textNameFather.Enabled = false;
                    textGreangFather.Enabled = false;
                    textFamliy.Enabled = false;
                    textNote.Enabled = false;
                    textNumber.Enabled = false;
                    butAddCustomer.Enabled = false;
                    butAddNewNumber.Enabled = true;
                }
                else
                {
                    MessageBox.Show("هناك خطاء", "خطاء", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
           


               

        }

        private void butclose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void butAddNewNumber_Click(object sender, EventArgs e)
        {
            FormAddNewNumber Ad = new FormAddNewNumber(Person.ID);
            if (Ad.ShowDialog() == DialogResult.OK)
            {
                // Handle the case where a new number was added successfully
                MessageBox.Show("New phone number added successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                // Handle the case where adding a new number was canceled or failed
                MessageBox.Show("Failed to add new phone number.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
           
        }

        private void FormAddCustomer_Load(object sender, EventArgs e)
        {
            textName.Focus();
        }

        
    }
}
