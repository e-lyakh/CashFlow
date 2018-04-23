namespace CashFlow
{
    partial class AddExpensesGroup
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
            this.bCancel = new System.Windows.Forms.Button();
            this.bAdd = new System.Windows.Forms.Button();
            this.lNewGroup = new System.Windows.Forms.Label();
            this.tbNewGroup = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // bCancel
            // 
            this.bCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.bCancel.Location = new System.Drawing.Point(153, 73);
            this.bCancel.Name = "bCancel";
            this.bCancel.Size = new System.Drawing.Size(104, 23);
            this.bCancel.TabIndex = 9;
            this.bCancel.Text = "Отмена";
            this.bCancel.UseVisualStyleBackColor = true;
            this.bCancel.Click += new System.EventHandler(this.bCancel_Click);
            // 
            // bAdd
            // 
            this.bAdd.Location = new System.Drawing.Point(28, 73);
            this.bAdd.Name = "bAdd";
            this.bAdd.Size = new System.Drawing.Size(104, 23);
            this.bAdd.TabIndex = 8;
            this.bAdd.Text = "Добавить";
            this.bAdd.UseVisualStyleBackColor = true;
            this.bAdd.Click += new System.EventHandler(this.bAdd_Click);
            // 
            // lNewGroup
            // 
            this.lNewGroup.AutoSize = true;
            this.lNewGroup.Location = new System.Drawing.Point(13, 12);
            this.lNewGroup.Name = "lNewGroup";
            this.lNewGroup.Size = new System.Drawing.Size(97, 13);
            this.lNewGroup.TabIndex = 7;
            this.lNewGroup.Text = "Название статьи:";
            // 
            // tbNewGroup
            // 
            this.tbNewGroup.Location = new System.Drawing.Point(13, 36);
            this.tbNewGroup.Name = "tbNewGroup";
            this.tbNewGroup.Size = new System.Drawing.Size(259, 20);
            this.tbNewGroup.TabIndex = 6;
            // 
            // AddExpenseGroup
            // 
            this.AcceptButton = this.bAdd;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.bCancel;
            this.ClientSize = new System.Drawing.Size(284, 111);
            this.Controls.Add(this.bCancel);
            this.Controls.Add(this.bAdd);
            this.Controls.Add(this.lNewGroup);
            this.Controls.Add(this.tbNewGroup);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "AddExpenseGroup";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Добавление статьи расходов";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button bCancel;
        private System.Windows.Forms.Button bAdd;
        private System.Windows.Forms.Label lNewGroup;
        private System.Windows.Forms.TextBox tbNewGroup;
    }
}