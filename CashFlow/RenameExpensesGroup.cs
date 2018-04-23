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
    public partial class RenameExpensesGroup : Form
    {
        public string NewName
        {
            get { return tbNewName.Text; }
            set { tbNewName.Text = value; }
        }

        public RenameExpensesGroup()
        {
            InitializeComponent();
        }

        private void bOK_Click(object sender, EventArgs e)
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
