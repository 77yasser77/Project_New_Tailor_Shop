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
    public partial class FormCustomer : Form
    {
        public FormCustomer()
        {
            InitializeComponent();
        }

        private void butAddCustomer_Click(object sender, EventArgs e)
        {
            Form formAddCustomer = new FormAddCustomer();
            formAddCustomer.ShowDialog();
        }

        private void butFindCustomer_Click(object sender, EventArgs e)
        {
            Form FindCustomer = new FormFindCustomer();
            FindCustomer.ShowDialog();
        }
    }
}
