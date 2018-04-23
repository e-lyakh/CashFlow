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
    public partial class MainForm : Form
    {
        List<ListViewItem> revRows = new List<ListViewItem>();
        List<ListViewItem> expRows = new List<ListViewItem>();
        bool descSort = false;

        public MainForm()
        {
            InitializeComponent();
            tvRevenues.ExpandAll();
            tvExpenses.ExpandAll();           

            var rNode1 = new TreeNode("Зарплата");
            rNode1.ImageIndex = 0;
            rNode1.SelectedImageIndex = 2;
            rNode1.ContextMenuStrip = cmRevenueGroup;
            tvRevenues.Nodes[0].Nodes.Add(rNode1);                       
            var lvi1 = new ListViewItem(new string[] { "21.04.2017", "Аванс по зарплате", "15000"});
            lvi1.Tag = 0;            
            revRows.Add(lvi1);
            lvRevenues.Items.Add(lvi1);           

            var rNode2 = new TreeNode("Фриланс");
            rNode2.ImageIndex = 0;
            rNode2.SelectedImageIndex = 2;
            rNode2.ContextMenuStrip = cmRevenueGroup;
            tvRevenues.Nodes[0].Nodes.Add(rNode2);            
            var lvi2 = new ListViewItem(new string[] { "15.04.2017", "За фриланс-проект АБВ", "10000" });
            lvi2.Tag = 1;
            revRows.Add(lvi2);
            lvRevenues.Items.Add(lvi2);            

            var rNode3 = new TreeNode("Прочие");
            rNode3.ImageIndex = 0;
            rNode3.SelectedImageIndex = 2;
            rNode3.ContextMenuStrip = cmRevenueGroup;
            tvRevenues.Nodes[0].Nodes.Add(rNode3);            
            var lvi3 = new ListViewItem(new string[] { "10.04.2017", "Наследство от дяди", "100000" });
            lvi3.Tag = 2;
            revRows.Add(lvi3);
            lvRevenues.Items.Add(lvi3);
                        
            var eNode1 = new TreeNode("Питание");
            eNode1.ImageIndex = 1;
            eNode1.SelectedImageIndex = 2;
            eNode1.ContextMenuStrip = cmExpensesGroup;
            tvExpenses.Nodes[0].Nodes.Add(eNode1);                   
            var lvi4 = new ListViewItem(new string[] { "21.04.2017", "Покупки в супермаркете", "", "", "1000"});
            lvi4.Tag = 0;            
            expRows.Add(lvi4);
            lvExpenses.Items.Add(lvi4);

            var eNode2 = new TreeNode("Одежда");
            eNode2.ImageIndex = 1;
            eNode2.SelectedImageIndex = 2;
            eNode2.ContextMenuStrip = cmExpensesGroup;
            tvExpenses.Nodes[0].Nodes.Add(eNode2);
            var lvi5 = new ListViewItem(new string[] { "11.04.2017", "Джинсы", "2", "2000", "4000" });
            lvi5.Tag = 1;
            expRows.Add(lvi5);
            lvExpenses.Items.Add(lvi5);

            var eNode3 = new TreeNode("Образование");
            eNode3.ImageIndex = 1;
            eNode3.SelectedImageIndex = 2;
            eNode3.ContextMenuStrip = cmExpensesGroup;
            tvExpenses.Nodes[0].Nodes.Add(eNode3);
            var lvi6 = new ListViewItem(new string[] { "30.04.2017", "Оплата за Шаг", "", "", "10000" });
            lvi6.Tag = 2;
            expRows.Add(lvi6);
            lvExpenses.Items.Add(lvi6);

            tvRevenues.SelectedNode = tvRevenues.Nodes[0];
            UpdateRevenuesTable();
            tvExpenses.SelectedNode = tvExpenses.Nodes[0];
            UpdateExpensesTable();
        }

        private void bAddRevenueGroup_Click(object sender, EventArgs e)
        {
            var arg = new AddRevenueGroup();
            if(arg.ShowDialog() == DialogResult.OK)
            {
                string name = arg.NewGroupName;
                var newNode = new TreeNode(name);
                newNode.ImageIndex = 0;
                newNode.SelectedImageIndex = 2;
                newNode.ContextMenuStrip = cmRevenueGroup;
                tvRevenues.Nodes[0].Nodes.Add(newNode);                
            }
        }

        private void bAddExpensesGroup_Click(object sender, EventArgs e)
        {
            var aeg = new AddExpensesGroup();
            if(aeg.ShowDialog() == DialogResult.OK)
            {
                string name = aeg.NewGroupName;
                var newNode = new TreeNode(name);
                newNode.ImageIndex = 1;
                newNode.SelectedImageIndex = 2;
                newNode.ContextMenuStrip = cmExpensesGroup;
                tvExpenses.Nodes[0].Nodes.Add(newNode);
            }
        }        

        private void tsmRevenueGroupRename_Click(object sender, EventArgs e)
        {
            RenameRevenueGroup rrg = new RenameRevenueGroup();
            if (rrg.ShowDialog() == DialogResult.OK)
            {
                tvRevenues.SelectedNode.Text = rrg.NewName;
            }
        }        

        private void tsmRevenueGroupDelete_Click(object sender, EventArgs e)
        {
            DeleteRevenueGroup drg = new DeleteRevenueGroup();
            if(drg.ShowDialog() == DialogResult.Yes)
            {
                int grId = tvRevenues.SelectedNode.Index;                
                for (int i=0; i < revRows.Count; i++)
                {
                    if ( Convert.ToInt32(revRows[i].Tag) == grId)
                    {                        
                        revRows.RemoveAt(i);
                        break;
                    }                        
                }
                tvRevenues.SelectedNode.Remove();
                for (int i = 0; i < revRows.Count; i++)
                {
                    revRows[i].Tag = i;                    
                }
                UpdateRevenuesTable();
            }
        }

        private void tsmExpensesGroupRename_Click(object sender, EventArgs e)
        {
            RenameExpensesGroup reg = new RenameExpensesGroup();
            if (reg.ShowDialog() == DialogResult.OK)
            {
                tvExpenses.SelectedNode.Text = reg.NewName;
            }
        }

        private void tsmExpensesGroupDelete_Click(object sender, EventArgs e)
        {
            DeleteExpensesGroup deg = new DeleteExpensesGroup();
            if(deg.ShowDialog() == DialogResult.Yes)
            {
                int grId = tvExpenses.SelectedNode.Index;                
                for (int i = 0; i < expRows.Count; i++)
                {
                    if ( Convert.ToInt32(expRows[i].Tag) == grId)
                    {                        
                        expRows.RemoveAt(i);
                        break;
                    }
                }
                tvExpenses.SelectedNode.Remove();
                for (int i = 0; i < expRows.Count; i++)
                {
                    expRows[i].Tag = i;
                }
                UpdateExpensesTable();
            }
        }

        private void bAddNewRevenue_Click(object sender, EventArgs e)
        {
            if(tvRevenues.SelectedNode != tvRevenues.Nodes[0])
            {
                var ari = new AddRevenueItem();
                if (ari.ShowDialog() == DialogResult.OK)
                {
                    DateTime d = new DateTime();
                    d = ari.Date;
                    string ds = d.ToShortDateString();
                    string n = ari.Title;
                    string s = ari.Sum;
                    ListViewItem lvi = new ListViewItem(new string[] { ds, n, s });
                    int grId = tvRevenues.SelectedNode.Index;
                    lvi.Tag = grId;
                    lvRevenues.Items.Add(lvi);
                    revRows.Add(lvi);
                    UpdateRevenuesTable();
                }
            }            
        }

        private void bAddNewExpense_Click(object sender, EventArgs e)
        {
            if (tvExpenses.SelectedNode != tvExpenses.Nodes[0])
            {
                var aei = new AddExpensesItem();
                if (aei.ShowDialog() == DialogResult.OK)
                {
                    DateTime d = new DateTime();
                    d = aei.Date;
                    string ds = d.ToShortDateString();
                    string n = aei.Title;
                    string q = aei.Quantity;
                    string p = aei.Price;
                    string s = aei.Sum;
                    ListViewItem lvi = new ListViewItem(new string[] { ds, n, q, p, s });
                    int grId = tvExpenses.SelectedNode.Index;
                    lvi.Tag = grId;
                    lvExpenses.Items.Add(lvi);
                    expRows.Add(lvi);
                    UpdateExpensesTable();
                }
            }         
        }        

        private void tvRevenues_AfterSelect(object sender, TreeViewEventArgs e)
        {
            UpdateRevenuesTable();
        }

        private void tvExpenses_AfterSelect(object sender, TreeViewEventArgs e)
        {
            UpdateExpensesTable();
        }

        private void tsbSort_Click(object sender, EventArgs e)
        {
            if ( (lvRevenues.Sorting == SortOrder.None) && (descSort == false) )
            {
                tsbSort.Image = imageList.Images[4];
                lvRevenues.Sorting = SortOrder.Ascending;
                lvExpenses.Sorting = SortOrder.Ascending;
                tslSort.Text = "По возрастанию";
                descSort = false;
            }
            else if (lvRevenues.Sorting == SortOrder.Ascending)
            {
                tsbSort.Image = imageList.Images[5];                
                lvRevenues.Sorting = SortOrder.Descending;
                lvExpenses.Sorting = SortOrder.Descending;
                tslSort.Text = "По убыванию";
                lvRevenues.Sorting = SortOrder.None;
                lvExpenses.Sorting = SortOrder.None;
                var tempRevSum = lvRevenues.Items[0];
                lvRevenues.Items[0].Remove();
                lvRevenues.Items.Add(tempRevSum);                
                var tempExpSum = lvExpenses.Items[0];
                lvExpenses.Items[0].Remove();
                lvExpenses.Items.Add(tempExpSum);
                descSort = true;
            }
            else
            {
                lvRevenues.Sorting = SortOrder.None;
                lvExpenses.Sorting = SortOrder.None;
                UpdateRevenuesTable();
                UpdateExpensesTable();
                tsbSort.Image = imageList.Images[3];
                tslSort.Text = "Без сортировки";
                descSort = false;
            }
        }

        private void UpdateRevenuesTable()
        {
            lvRevenues.Items.Clear();
            int grId = tvRevenues.SelectedNode.Index;
            int sum = 0;
            for (int i = 0; i < revRows.Count; i++)
            {
                int rowId = Convert.ToInt32(revRows[i].Tag);
                if (tvRevenues.SelectedNode == tvRevenues.Nodes[0])
                {
                    lvRevenues.Items.Add(revRows[i]);
                    int itemSum = Convert.ToInt32(revRows[i].SubItems[2].Text);
                    sum += itemSum;
                }
                else if (rowId == grId)
                {
                    lvRevenues.Items.Add(revRows[i]);
                    int itemSum = Convert.ToInt32(revRows[i].SubItems[2].Text);
                    sum += itemSum;
                }
            }            
            ListViewItem lviSum = new ListViewItem(new string[] { "Итого", "", sum.ToString() });
            lviSum.SubItems[0].BackColor = Color.FromArgb(240,240,240);
            if( (lvRevenues.Sorting == SortOrder.None) || (lvRevenues.Sorting == SortOrder.Ascending) )
            {
                lvRevenues.Items.Add(lviSum);
            }
            else
            {
                lvRevenues.Items.Insert(0, lviSum);
            }
                        
        }

        private void UpdateExpensesTable()
        {
            lvExpenses.Items.Clear();
            int grId = tvExpenses.SelectedNode.Index;
            int sum = 0;
            for (int i = 0; i < expRows.Count; i++)
            {
                int rowId = Convert.ToInt32(expRows[i].Tag);
                if (tvExpenses.SelectedNode == tvExpenses.Nodes[0])
                {
                    lvExpenses.Items.Add(expRows[i]);
                    int itemSum = Convert.ToInt32(expRows[i].SubItems[4].Text);
                    sum += itemSum;
                }
                else if (rowId == grId)
                {
                    lvExpenses.Items.Add(expRows[i]);
                    int itemSum = Convert.ToInt32(expRows[i].SubItems[4].Text);
                    sum += itemSum;
                }
            }
            ListViewItem lviSum = new ListViewItem(new string[] { "Итого", "","", "", sum.ToString() });
            lviSum.SubItems[0].BackColor = Color.FromArgb(240, 240, 240);
            lvExpenses.Items.Add(lviSum);
        }        
    }
}