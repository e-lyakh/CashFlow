using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CashFlow
{
    public partial class AddExpensesItem : Form
    {
        public DateTime Date
        {
            get { return dtpDate.Value; }
            set { dtpDate.Value = value; }
        }

        public string Title
        {
            get { return tbName.Text; }
            set { tbName.Text = value; }
        }

        public string Quantity
        {
            get { return tbQuantity.Text; }
            set { tbQuantity.Text = value; }
        }

        public string Price
        {
            get { return tbPrice.Text; }
            set { tbPrice.Text = value; }
        }

        public string Sum
        {
            get { return tbSum.Text; }
            set { tbSum.Text = value; }
        }

        public AddExpensesItem()
        {
            InitializeComponent();
        }

        private void bAdd_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.OK;
            this.Close();
        }

        private void bCancel_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
            this.Close();
        }
    }
}
