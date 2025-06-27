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
    public partial class FormFindCustomer : Form
    {
        public FormFindCustomer()
        {
            InitializeComponent();
        }
        private void _ClearText()
        {
            textName.Text = "";
            textFamliy.Text = "";
            textFather.Text = "";
            textGrandFather.Text = "";
            textNumber.Text = "";
            if (dgvPhone.DataSource != null)
            {
                dgvPhone.DataSource=null;
            }
        }
        private bool SelectFirstRow(object DGV,DataTable Table)
        {
       

            if (Table.Rows.Count > 0)
            {
                DGVPerson.Columns["PersonID"].HeaderText = "ID";
                DGVPerson.Columns["PersonName"].HeaderText = "الاسم";
                DGVPerson.Columns["PersonFather"].HeaderText = "اسم الاب";
                DGVPerson.Columns["personGrandFather"].HeaderText = "اسم الجد";
                DGVPerson.Columns["FamilyName"].HeaderText = "اللقب";
               
           ((DataGridView)DGV).ClearSelection(); 
            ((DataGridView)DGV).CurrentCell = ((DataGridView)DGV).Rows[0].Cells[0];
            ((DataGridView)DGV).Rows[0].Selected = true;
                return true;
            }
            else
            {
                return false;
            }
        }
        private void _DGVEnable()
        {
                     
            if(DGVPerson.Rows.Count > 0)
            {
                DGVPerson.Enabled = true;
            }
            else
            {
                DGVPerson.Enabled = false;
            }
          
        }

        private void butFindName_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(textName.Text)|| string.IsNullOrWhiteSpace(textFather.Text)|| string.IsNullOrWhiteSpace(textGrandFather.Text)||
                string.IsNullOrWhiteSpace(textFamliy.Text))
            {
                MessageBox.Show("الرجاء ادخال بيانات الاسم كاملا", "خطأ", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            DataTable DataParson = clsPerson.GetAllPersonWithThisName(textName.Text.ToString(), textFather.Text.ToString(), textGrandFather.Text.ToString(), textFamliy.Text.ToString());
            DGVPerson.DataSource = DataParson;
            if (!SelectFirstRow(DGVPerson, DataParson))
            {

                MessageBox.Show("لا يوجد عميل بهاذا الاسم ", "خطأ", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
            _DGVEnable();
            _ClearText();
        }

        private void المقاساتToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //هنا سيكون كود عرض المقاسات
        }

        private void butFindNumber_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(textNumber.Text))
            {
                MessageBox.Show("الرجاء إدخال رقم الهاتف للبحث", "خطأ", MessageBoxButtons.OK, MessageBoxIcon.Error);

                return;
            }
            string[] PersonID = clsPhone.GitPerson_ID(textNumber.Text.ToString());
            DataTable Table = clsPerson.GetAllPersonWithThisID(PersonID);
            DGVPerson.DataSource = Table;
            if (!SelectFirstRow(DGVPerson,Table))
            {
                MessageBox.Show("لا يوجد عميل بهذا الرقم", "خطأ", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
          

            _DGVEnable();
            _ClearText();
        }

        private void الرقمToolStripMenuItem_Click(object sender, EventArgs e)
        {

            
            DataTable Table = clsPhone.FindID(DGVPerson.CurrentRow.Cells["PersonID"].Value.ToString());

            if (Table.Rows.Count > 0)
            { 

              
                    dgvPhone.DataSource = Table;
                    if (Table.Rows.Count > 0)
                    {
                        dgvPhone.Columns[0].Visible = false; // إخفاء عمود PhoneID
                        dgvPhone.Columns[1].HeaderText = "رقم الهاتف";
                        dgvPhone.Columns[3].HeaderText = "ملاحظات";
                        dgvPhone.Columns[2].Visible = false;
                    }
                    else
                    {
                        MessageBox.Show("لا يوجد هواتف مسجلة لهذا العميل", "خطأ", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
              
            }
            else
            {
                
                    MessageBox.Show("لا توجد بيانات", "خطأ", MessageBoxButtons.OK, MessageBoxIcon.Error);


                
            }
        }

        private void FormFindCustomer_Load(object sender, EventArgs e)
        {
            dgvPhone.Enabled = false;
            DGVPerson.Enabled = false;
        }

    }
}
