namespace CashFlow
{
    partial class DeleteExpensesGroup
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
            this.bYes = new System.Windows.Forms.Button();
            this.lDelete = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // bCancel
            // 
            this.bCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.bCancel.Location = new System.Drawing.Point(160, 56);
            this.bCancel.Name = "bCancel";
            this.bCancel.Size = new System.Drawing.Size(75, 23);
            this.bCancel.TabIndex = 5;
            this.bCancel.Text = "Отмена";
            this.bCancel.UseVisualStyleBackColor = true;
            this.bCancel.Click += new System.EventHandler(this.bCancel_Click);
            // 
            // bYes
            // 
            this.bYes.Location = new System.Drawing.Point(49, 56);
            this.bYes.Name = "bYes";
            this.bYes.Size = new System.Drawing.Size(75, 23);
            this.bYes.TabIndex = 4;
            this.bYes.Text = "Да";
            this.bYes.UseVisualStyleBackColor = true;
            this.bYes.Click += new System.EventHandler(this.bYes_Click);
            // 
            // lDelete
            // 
            this.lDelete.AutoSize = true;
            this.lDelete.Location = new System.Drawing.Point(69, 18);
            this.lDelete.Name = "lDelete";
            this.lDelete.Size = new System.Drawing.Size(145, 13);
            this.lDelete.TabIndex = 3;
            this.lDelete.Text = "Удалить статью расходов?";
            // 
            // DeleteExpensesGroup
            // 
            this.AcceptButton = this.bYes;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.bCancel;
            this.ClientSize = new System.Drawing.Size(284, 107);
            this.Controls.Add(this.bCancel);
            this.Controls.Add(this.bYes);
            this.Controls.Add(this.lDelete);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "DeleteExpensesGroup";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Удаление статьи расходов";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button bCancel;
        private System.Windows.Forms.Button bYes;
        private System.Windows.Forms.Label lDelete;
    }
}