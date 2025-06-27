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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void butCustomer_Click(object sender, EventArgs e)
        {
            Form formCustome =new FormCustomer();
            formCustome.ShowDialog();
        }
    }
}
