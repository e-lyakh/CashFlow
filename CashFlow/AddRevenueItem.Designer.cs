namespace CashFlow
{
    partial class AddRevenueItem
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
            this.lName = new System.Windows.Forms.Label();
            this.tbName = new System.Windows.Forms.TextBox();
            this.bCancel = new System.Windows.Forms.Button();
            this.bAdd = new System.Windows.Forms.Button();
            this.lSum = new System.Windows.Forms.Label();
            this.tbSum = new System.Windows.Forms.TextBox();
            this.lDate = new System.Windows.Forms.Label();
            this.dtpDate = new System.Windows.Forms.DateTimePicker();
            this.SuspendLayout();
            // 
            // lName
            // 
            this.lName.AutoSize = true;
            this.lName.Location = new System.Drawing.Point(15, 62);
            this.lName.Name = "lName";
            this.lName.Size = new System.Drawing.Size(86, 13);
            this.lName.TabIndex = 0;
            this.lName.Text = "Наименование:";
            // 
            // tbName
            // 
            this.tbName.Location = new System.Drawing.Point(12, 78);
            this.tbName.Name = "tbName";
            this.tbName.Size = new System.Drawing.Size(222, 20);
            this.tbName.TabIndex = 1;
            // 
            // bCancel
            // 
            this.bCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.bCancel.Location = new System.Drawing.Point(130, 160);
            this.bCancel.Name = "bCancel";
            this.bCancel.Size = new System.Drawing.Size(104, 23);
            this.bCancel.TabIndex = 7;
            this.bCancel.Text = "Отмена";
            this.bCancel.UseVisualStyleBackColor = true;
            this.bCancel.Click += new System.EventHandler(this.bCancel_Click);
            // 
            // bAdd
            // 
            this.bAdd.Location = new System.Drawing.Point(12, 160);
            this.bAdd.Name = "bAdd";
            this.bAdd.Size = new System.Drawing.Size(104, 23);
            this.bAdd.TabIndex = 6;
            this.bAdd.Text = "Добавить";
            this.bAdd.UseVisualStyleBackColor = true;
            this.bAdd.Click += new System.EventHandler(this.bAdd_Click);
            // 
            // lSum
            // 
            this.lSum.AutoSize = true;
            this.lSum.Location = new System.Drawing.Point(15, 110);
            this.lSum.Name = "lSum";
            this.lSum.Size = new System.Drawing.Size(44, 13);
            this.lSum.TabIndex = 8;
            this.lSum.Text = "Сумма:";
            // 
            // tbSum
            // 
            this.tbSum.Location = new System.Drawing.Point(12, 126);
            this.tbSum.Name = "tbSum";
            this.tbSum.Size = new System.Drawing.Size(104, 20);
            this.tbSum.TabIndex = 9;
            this.tbSum.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // lDate
            // 
            this.lDate.AutoSize = true;
            this.lDate.Location = new System.Drawing.Point(15, 13);
            this.lDate.Name = "lDate";
            this.lDate.Size = new System.Drawing.Size(36, 13);
            this.lDate.TabIndex = 10;
            this.lDate.Text = "Дата:";
            // 
            // dtpDate
            // 
            this.dtpDate.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpDate.Location = new System.Drawing.Point(12, 29);
            this.dtpDate.MaxDate = new System.DateTime(2100, 12, 31, 0, 0, 0, 0);
            this.dtpDate.Name = "dtpDate";
            this.dtpDate.Size = new System.Drawing.Size(104, 20);
            this.dtpDate.TabIndex = 12;
            // 
            // AddRevenueItem
            // 
            this.AcceptButton = this.bAdd;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.bCancel;
            this.ClientSize = new System.Drawing.Size(246, 195);
            this.Controls.Add(this.dtpDate);
            this.Controls.Add(this.lDate);
            this.Controls.Add(this.tbSum);
            this.Controls.Add(this.lSum);
            this.Controls.Add(this.bCancel);
            this.Controls.Add(this.bAdd);
            this.Controls.Add(this.tbName);
            this.Controls.Add(this.lName);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "AddRevenueItem";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Добавление позиции доходов";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lName;
        private System.Windows.Forms.TextBox tbName;
        private System.Windows.Forms.Button bCancel;
        private System.Windows.Forms.Button bAdd;
        private System.Windows.Forms.Label lSum;
        private System.Windows.Forms.TextBox tbSum;
        private System.Windows.Forms.Label lDate;
        private System.Windows.Forms.DateTimePicker dtpDate;
    }
}