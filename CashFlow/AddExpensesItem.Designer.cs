namespace CashFlow
{
    partial class AddExpensesItem
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
            this.lDate = new System.Windows.Forms.Label();
            this.tbSum = new System.Windows.Forms.TextBox();
            this.lSum = new System.Windows.Forms.Label();
            this.bCancel = new System.Windows.Forms.Button();
            this.bAdd = new System.Windows.Forms.Button();
            this.tbName = new System.Windows.Forms.TextBox();
            this.lName = new System.Windows.Forms.Label();
            this.tbQuantity = new System.Windows.Forms.TextBox();
            this.lQuantity = new System.Windows.Forms.Label();
            this.tbPrice = new System.Windows.Forms.TextBox();
            this.lPrice = new System.Windows.Forms.Label();
            this.dtpDate = new System.Windows.Forms.DateTimePicker();
            this.SuspendLayout();
            // 
            // lDate
            // 
            this.lDate.AutoSize = true;
            this.lDate.Location = new System.Drawing.Point(13, 13);
            this.lDate.Name = "lDate";
            this.lDate.Size = new System.Drawing.Size(36, 13);
            this.lDate.TabIndex = 18;
            this.lDate.Text = "Дата:";
            // 
            // tbSum
            // 
            this.tbSum.Location = new System.Drawing.Point(10, 221);
            this.tbSum.Name = "tbSum";
            this.tbSum.Size = new System.Drawing.Size(104, 20);
            this.tbSum.TabIndex = 17;
            this.tbSum.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // lSum
            // 
            this.lSum.AutoSize = true;
            this.lSum.Location = new System.Drawing.Point(13, 205);
            this.lSum.Name = "lSum";
            this.lSum.Size = new System.Drawing.Size(44, 13);
            this.lSum.TabIndex = 16;
            this.lSum.Text = "Сумма:";
            // 
            // bCancel
            // 
            this.bCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.bCancel.Location = new System.Drawing.Point(128, 256);
            this.bCancel.Name = "bCancel";
            this.bCancel.Size = new System.Drawing.Size(104, 23);
            this.bCancel.TabIndex = 15;
            this.bCancel.Text = "Отмена";
            this.bCancel.UseVisualStyleBackColor = true;
            this.bCancel.Click += new System.EventHandler(this.bCancel_Click);
            // 
            // bAdd
            // 
            this.bAdd.Location = new System.Drawing.Point(10, 256);
            this.bAdd.Name = "bAdd";
            this.bAdd.Size = new System.Drawing.Size(104, 23);
            this.bAdd.TabIndex = 14;
            this.bAdd.Text = "Добавить";
            this.bAdd.UseVisualStyleBackColor = true;
            this.bAdd.Click += new System.EventHandler(this.bAdd_Click);
            // 
            // tbName
            // 
            this.tbName.Location = new System.Drawing.Point(10, 78);
            this.tbName.Name = "tbName";
            this.tbName.Size = new System.Drawing.Size(222, 20);
            this.tbName.TabIndex = 13;
            // 
            // lName
            // 
            this.lName.AutoSize = true;
            this.lName.Location = new System.Drawing.Point(13, 62);
            this.lName.Name = "lName";
            this.lName.Size = new System.Drawing.Size(86, 13);
            this.lName.TabIndex = 12;
            this.lName.Text = "Наименование:";
            // 
            // tbQuantity
            // 
            this.tbQuantity.Location = new System.Drawing.Point(10, 126);
            this.tbQuantity.Name = "tbQuantity";
            this.tbQuantity.Size = new System.Drawing.Size(104, 20);
            this.tbQuantity.TabIndex = 21;
            this.tbQuantity.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // lQuantity
            // 
            this.lQuantity.AutoSize = true;
            this.lQuantity.Location = new System.Drawing.Point(13, 110);
            this.lQuantity.Name = "lQuantity";
            this.lQuantity.Size = new System.Drawing.Size(69, 13);
            this.lQuantity.TabIndex = 20;
            this.lQuantity.Text = "Количество:";
            // 
            // tbPrice
            // 
            this.tbPrice.Location = new System.Drawing.Point(10, 174);
            this.tbPrice.Name = "tbPrice";
            this.tbPrice.Size = new System.Drawing.Size(104, 20);
            this.tbPrice.TabIndex = 23;
            this.tbPrice.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // lPrice
            // 
            this.lPrice.AutoSize = true;
            this.lPrice.Location = new System.Drawing.Point(13, 158);
            this.lPrice.Name = "lPrice";
            this.lPrice.Size = new System.Drawing.Size(36, 13);
            this.lPrice.TabIndex = 22;
            this.lPrice.Text = "Цена:";
            // 
            // dtpDate
            // 
            this.dtpDate.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpDate.Location = new System.Drawing.Point(10, 29);
            this.dtpDate.MaxDate = new System.DateTime(2100, 12, 31, 0, 0, 0, 0);
            this.dtpDate.Name = "dtpDate";
            this.dtpDate.Size = new System.Drawing.Size(104, 20);
            this.dtpDate.TabIndex = 24;
            // 
            // AddExpensesItem
            // 
            this.AcceptButton = this.bAdd;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.bCancel;
            this.ClientSize = new System.Drawing.Size(246, 292);
            this.Controls.Add(this.dtpDate);
            this.Controls.Add(this.tbPrice);
            this.Controls.Add(this.lPrice);
            this.Controls.Add(this.tbQuantity);
            this.Controls.Add(this.lQuantity);
            this.Controls.Add(this.lDate);
            this.Controls.Add(this.tbSum);
            this.Controls.Add(this.lSum);
            this.Controls.Add(this.bCancel);
            this.Controls.Add(this.bAdd);
            this.Controls.Add(this.tbName);
            this.Controls.Add(this.lName);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "AddExpensesItem";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Добавление позиции расходов";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label lDate;
        private System.Windows.Forms.TextBox tbSum;
        private System.Windows.Forms.Label lSum;
        private System.Windows.Forms.Button bCancel;
        private System.Windows.Forms.Button bAdd;
        private System.Windows.Forms.TextBox tbName;
        private System.Windows.Forms.Label lName;
        private System.Windows.Forms.TextBox tbQuantity;
        private System.Windows.Forms.Label lQuantity;
        private System.Windows.Forms.TextBox tbPrice;
        private System.Windows.Forms.Label lPrice;
        private System.Windows.Forms.DateTimePicker dtpDate;
    }
}