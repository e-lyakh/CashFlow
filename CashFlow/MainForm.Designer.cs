namespace CashFlow
{
    partial class MainForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.TreeNode treeNode3 = new System.Windows.Forms.TreeNode("Доходы", 0, 2);
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            System.Windows.Forms.TreeNode treeNode1 = new System.Windows.Forms.TreeNode("Расходы", 1, 2);
            this.cmExpensesGroup = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.tsmExpensesGroupRename = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmExpensesGroupDelete = new System.Windows.Forms.ToolStripMenuItem();
            this.cmRevenueGroup = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.tsmRevenueGroupRename = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmRevenueGroupDelete = new System.Windows.Forms.ToolStripMenuItem();
            this.tvRevenues = new System.Windows.Forms.TreeView();
            this.imageList = new System.Windows.Forms.ImageList(this.components);
            this.lExpensesRevenues = new System.Windows.Forms.Label();
            this.bAddIncomeGroup = new System.Windows.Forms.Button();
            this.lvRevenues = new System.Windows.Forms.ListView();
            this.columnIDate = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnIName = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnISum = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.lDetails = new System.Windows.Forms.Label();
            this.bAddExpensesGroup = new System.Windows.Forms.Button();
            this.tvExpenses = new System.Windows.Forms.TreeView();
            this.bAddNewIncome = new System.Windows.Forms.Button();
            this.lvExpenses = new System.Windows.Forms.ListView();
            this.columnEDate = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnEName = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnQuantity = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnPrice = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnSum = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.bAddNewExpense = new System.Windows.Forms.Button();
            this.tsSort = new System.Windows.Forms.ToolStrip();
            this.tsbSort = new System.Windows.Forms.ToolStripButton();
            this.tslSpace = new System.Windows.Forms.ToolStripLabel();
            this.tslSort = new System.Windows.Forms.ToolStripLabel();
            this.cmExpensesGroup.SuspendLayout();
            this.cmRevenueGroup.SuspendLayout();
            this.tsSort.SuspendLayout();
            this.SuspendLayout();
            // 
            // cmExpensesGroup
            // 
            this.cmExpensesGroup.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmExpensesGroupRename,
            this.tsmExpensesGroupDelete});
            this.cmExpensesGroup.Name = "cmsExpensesGroup";
            this.cmExpensesGroup.Size = new System.Drawing.Size(162, 48);
            // 
            // tsmExpensesGroupRename
            // 
            this.tsmExpensesGroupRename.Name = "tsmExpensesGroupRename";
            this.tsmExpensesGroupRename.Size = new System.Drawing.Size(161, 22);
            this.tsmExpensesGroupRename.Text = "Переименовать";
            this.tsmExpensesGroupRename.Click += new System.EventHandler(this.tsmExpensesGroupRename_Click);
            // 
            // tsmExpensesGroupDelete
            // 
            this.tsmExpensesGroupDelete.Name = "tsmExpensesGroupDelete";
            this.tsmExpensesGroupDelete.Size = new System.Drawing.Size(161, 22);
            this.tsmExpensesGroupDelete.Text = "Удалить";
            this.tsmExpensesGroupDelete.Click += new System.EventHandler(this.tsmExpensesGroupDelete_Click);
            // 
            // cmRevenueGroup
            // 
            this.cmRevenueGroup.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmRevenueGroupRename,
            this.tsmRevenueGroupDelete});
            this.cmRevenueGroup.Name = "cmRevenueGroup";
            this.cmRevenueGroup.Size = new System.Drawing.Size(162, 48);
            this.cmRevenueGroup.Text = "Переименовать";
            // 
            // tsmRevenueGroupRename
            // 
            this.tsmRevenueGroupRename.Name = "tsmRevenueGroupRename";
            this.tsmRevenueGroupRename.Size = new System.Drawing.Size(161, 22);
            this.tsmRevenueGroupRename.Text = "Переименовать";
            this.tsmRevenueGroupRename.Click += new System.EventHandler(this.tsmRevenueGroupRename_Click);
            // 
            // tsmRevenueGroupDelete
            // 
            this.tsmRevenueGroupDelete.Name = "tsmRevenueGroupDelete";
            this.tsmRevenueGroupDelete.Size = new System.Drawing.Size(161, 22);
            this.tsmRevenueGroupDelete.Text = "Удалить";
            this.tsmRevenueGroupDelete.Click += new System.EventHandler(this.tsmRevenueGroupDelete_Click);
            // 
            // tvRevenues
            // 
            this.tvRevenues.ImageIndex = 0;
            this.tvRevenues.ImageList = this.imageList;
            this.tvRevenues.Indent = 20;
            this.tvRevenues.ItemHeight = 20;
            this.tvRevenues.Location = new System.Drawing.Point(12, 34);
            this.tvRevenues.Name = "tvRevenues";
            treeNode3.ImageIndex = 0;
            treeNode3.Name = "Revenues";
            treeNode3.NodeFont = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            treeNode3.SelectedImageIndex = 2;
            treeNode3.Text = "Доходы";
            this.tvRevenues.Nodes.AddRange(new System.Windows.Forms.TreeNode[] {
            treeNode3});
            this.tvRevenues.SelectedImageIndex = 0;
            this.tvRevenues.Size = new System.Drawing.Size(185, 155);
            this.tvRevenues.TabIndex = 0;
            this.tvRevenues.AfterSelect += new System.Windows.Forms.TreeViewEventHandler(this.tvRevenues_AfterSelect);
            // 
            // imageList
            // 
            this.imageList.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageList.ImageStream")));
            this.imageList.TransparentColor = System.Drawing.Color.Transparent;
            this.imageList.Images.SetKeyName(0, "income.jpg");
            this.imageList.Images.SetKeyName(1, "outcome.png");
            this.imageList.Images.SetKeyName(2, "selected.png");
            this.imageList.Images.SetKeyName(3, "sort_none.png");
            this.imageList.Images.SetKeyName(4, "sort_asc.png");
            this.imageList.Images.SetKeyName(5, "sort_desc.png");
            // 
            // lExpensesRevenues
            // 
            this.lExpensesRevenues.AutoSize = true;
            this.lExpensesRevenues.Location = new System.Drawing.Point(13, 11);
            this.lExpensesRevenues.Name = "lExpensesRevenues";
            this.lExpensesRevenues.Size = new System.Drawing.Size(45, 13);
            this.lExpensesRevenues.TabIndex = 1;
            this.lExpensesRevenues.Text = "Статьи:";
            // 
            // bAddIncomeGroup
            // 
            this.bAddIncomeGroup.Location = new System.Drawing.Point(12, 202);
            this.bAddIncomeGroup.Name = "bAddIncomeGroup";
            this.bAddIncomeGroup.Size = new System.Drawing.Size(184, 23);
            this.bAddIncomeGroup.TabIndex = 2;
            this.bAddIncomeGroup.Text = "Добавить статью доходов";
            this.bAddIncomeGroup.UseVisualStyleBackColor = true;
            this.bAddIncomeGroup.Click += new System.EventHandler(this.bAddRevenueGroup_Click);
            // 
            // lvRevenues
            // 
            this.lvRevenues.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnIDate,
            this.columnIName,
            this.columnISum});
            this.lvRevenues.Location = new System.Drawing.Point(213, 34);
            this.lvRevenues.Name = "lvRevenues";
            this.lvRevenues.Size = new System.Drawing.Size(585, 155);
            this.lvRevenues.TabIndex = 3;
            this.lvRevenues.UseCompatibleStateImageBehavior = false;
            this.lvRevenues.View = System.Windows.Forms.View.Details;
            // 
            // columnIDate
            // 
            this.columnIDate.Text = "Дата";
            this.columnIDate.Width = 100;
            // 
            // columnIName
            // 
            this.columnIName.Text = "Наименование";
            this.columnIName.Width = 380;
            // 
            // columnISum
            // 
            this.columnISum.Text = "Сумма";
            this.columnISum.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.columnISum.Width = 100;
            // 
            // lDetails
            // 
            this.lDetails.AutoSize = true;
            this.lDetails.Location = new System.Drawing.Point(213, 11);
            this.lDetails.Name = "lDetails";
            this.lDetails.Size = new System.Drawing.Size(78, 13);
            this.lDetails.TabIndex = 4;
            this.lDetails.Text = "Детализация:";
            // 
            // bAddExpensesGroup
            // 
            this.bAddExpensesGroup.Location = new System.Drawing.Point(12, 414);
            this.bAddExpensesGroup.Name = "bAddExpensesGroup";
            this.bAddExpensesGroup.Size = new System.Drawing.Size(184, 23);
            this.bAddExpensesGroup.TabIndex = 6;
            this.bAddExpensesGroup.Text = "Добавить статью расходов";
            this.bAddExpensesGroup.UseVisualStyleBackColor = true;
            this.bAddExpensesGroup.Click += new System.EventHandler(this.bAddExpensesGroup_Click);
            // 
            // tvExpenses
            // 
            this.tvExpenses.ImageIndex = 1;
            this.tvExpenses.ImageList = this.imageList;
            this.tvExpenses.Indent = 20;
            this.tvExpenses.ItemHeight = 20;
            this.tvExpenses.Location = new System.Drawing.Point(12, 245);
            this.tvExpenses.Name = "tvExpenses";
            treeNode1.ImageIndex = 1;
            treeNode1.Name = "Expenses";
            treeNode1.NodeFont = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            treeNode1.SelectedImageIndex = 2;
            treeNode1.Text = "Расходы";
            this.tvExpenses.Nodes.AddRange(new System.Windows.Forms.TreeNode[] {
            treeNode1});
            this.tvExpenses.SelectedImageIndex = 0;
            this.tvExpenses.Size = new System.Drawing.Size(185, 155);
            this.tvExpenses.TabIndex = 5;
            this.tvExpenses.AfterSelect += new System.Windows.Forms.TreeViewEventHandler(this.tvExpenses_AfterSelect);
            // 
            // bAddNewIncome
            // 
            this.bAddNewIncome.Location = new System.Drawing.Point(213, 202);
            this.bAddNewIncome.Name = "bAddNewIncome";
            this.bAddNewIncome.Size = new System.Drawing.Size(184, 23);
            this.bAddNewIncome.TabIndex = 7;
            this.bAddNewIncome.Text = "Добавить позицию доходов";
            this.bAddNewIncome.UseVisualStyleBackColor = true;
            this.bAddNewIncome.Click += new System.EventHandler(this.bAddNewRevenue_Click);
            // 
            // lvExpenses
            // 
            this.lvExpenses.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnEDate,
            this.columnEName,
            this.columnQuantity,
            this.columnPrice,
            this.columnSum});
            this.lvExpenses.Location = new System.Drawing.Point(213, 245);
            this.lvExpenses.Name = "lvExpenses";
            this.lvExpenses.Size = new System.Drawing.Size(585, 155);
            this.lvExpenses.TabIndex = 8;
            this.lvExpenses.UseCompatibleStateImageBehavior = false;
            this.lvExpenses.View = System.Windows.Forms.View.Details;
            // 
            // columnEDate
            // 
            this.columnEDate.Text = "Дата";
            this.columnEDate.Width = 100;
            // 
            // columnEName
            // 
            this.columnEName.Text = "Наименование";
            this.columnEName.Width = 180;
            // 
            // columnQuantity
            // 
            this.columnQuantity.Text = "Кол-во";
            this.columnQuantity.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.columnQuantity.Width = 100;
            // 
            // columnPrice
            // 
            this.columnPrice.Text = "Цена";
            this.columnPrice.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.columnPrice.Width = 100;
            // 
            // columnSum
            // 
            this.columnSum.Text = "Сумма";
            this.columnSum.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.columnSum.Width = 100;
            // 
            // bAddNewExpense
            // 
            this.bAddNewExpense.Location = new System.Drawing.Point(213, 414);
            this.bAddNewExpense.Name = "bAddNewExpense";
            this.bAddNewExpense.Size = new System.Drawing.Size(184, 23);
            this.bAddNewExpense.TabIndex = 9;
            this.bAddNewExpense.Text = "Добавить позицию расходов";
            this.bAddNewExpense.UseVisualStyleBackColor = true;
            this.bAddNewExpense.Click += new System.EventHandler(this.bAddNewExpense_Click);
            // 
            // tsSort
            // 
            this.tsSort.AutoSize = false;
            this.tsSort.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden;
            this.tsSort.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tslSpace,
            this.tsbSort,
            this.tslSort});
            this.tsSort.LayoutStyle = System.Windows.Forms.ToolStripLayoutStyle.HorizontalStackWithOverflow;
            this.tsSort.Location = new System.Drawing.Point(0, 0);
            this.tsSort.Name = "tsSort";
            this.tsSort.Padding = new System.Windows.Forms.Padding(0);
            this.tsSort.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.tsSort.Size = new System.Drawing.Size(813, 33);
            this.tsSort.TabIndex = 0;
            this.tsSort.Text = "toolStrip1";
            // 
            // tsbSort
            // 
            this.tsbSort.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tsbSort.Image = ((System.Drawing.Image)(resources.GetObject("tsbSort.Image")));
            this.tsbSort.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbSort.Name = "tsbSort";
            this.tsbSort.Size = new System.Drawing.Size(23, 30);
            this.tsbSort.Text = "Сортировать по сроку";
            this.tsbSort.Click += new System.EventHandler(this.tsbSort_Click);
            // 
            // tslSpace
            // 
            this.tslSpace.Name = "tslSpace";
            this.tslSpace.Size = new System.Drawing.Size(16, 30);
            this.tslSpace.Text = "   ";
            // 
            // tslSort
            // 
            this.tslSort.Name = "tslSort";
            this.tslSort.Size = new System.Drawing.Size(93, 30);
            this.tslSort.Text = "Без сортировки";
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(813, 455);
            this.Controls.Add(this.bAddNewExpense);
            this.Controls.Add(this.lvExpenses);
            this.Controls.Add(this.bAddNewIncome);
            this.Controls.Add(this.bAddExpensesGroup);
            this.Controls.Add(this.tvExpenses);
            this.Controls.Add(this.lDetails);
            this.Controls.Add(this.lvRevenues);
            this.Controls.Add(this.bAddIncomeGroup);
            this.Controls.Add(this.lExpensesRevenues);
            this.Controls.Add(this.tvRevenues);
            this.Controls.Add(this.tsSort);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(829, 494);
            this.MinimumSize = new System.Drawing.Size(829, 494);
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Учет личных финансов";
            this.cmExpensesGroup.ResumeLayout(false);
            this.cmRevenueGroup.ResumeLayout(false);
            this.tsSort.ResumeLayout(false);
            this.tsSort.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TreeView tvRevenues;
        private System.Windows.Forms.Label lExpensesRevenues;
        private System.Windows.Forms.Button bAddIncomeGroup;
        private System.Windows.Forms.ListView lvRevenues;
        private System.Windows.Forms.Label lDetails;
        private System.Windows.Forms.Button bAddExpensesGroup;
        private System.Windows.Forms.TreeView tvExpenses;
        private System.Windows.Forms.ColumnHeader columnIDate;
        private System.Windows.Forms.ColumnHeader columnISum;
        private System.Windows.Forms.ColumnHeader columnIName;
        private System.Windows.Forms.Button bAddNewIncome;
        private System.Windows.Forms.ListView lvExpenses;
        private System.Windows.Forms.ColumnHeader columnEDate;
        private System.Windows.Forms.ColumnHeader columnEName;
        private System.Windows.Forms.ColumnHeader columnQuantity;
        private System.Windows.Forms.Button bAddNewExpense;
        private System.Windows.Forms.ColumnHeader columnPrice;
        private System.Windows.Forms.ColumnHeader columnSum;
        private System.Windows.Forms.ImageList imageList;
        private System.Windows.Forms.ContextMenuStrip cmRevenueGroup;
        private System.Windows.Forms.ToolStripMenuItem tsmRevenueGroupRename;
        private System.Windows.Forms.ToolStripMenuItem tsmRevenueGroupDelete;
        private System.Windows.Forms.ContextMenuStrip cmExpensesGroup;
        private System.Windows.Forms.ToolStripMenuItem tsmExpensesGroupRename;
        private System.Windows.Forms.ToolStripMenuItem tsmExpensesGroupDelete;
        private System.Windows.Forms.ToolStrip tsSort;
        private System.Windows.Forms.ToolStripButton tsbSort;
        private System.Windows.Forms.ToolStripLabel tslSpace;
        private System.Windows.Forms.ToolStripLabel tslSort;
    }
}

