namespace CashFlow
{
    partial class DeleteRevenueGroup
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
            this.lDelete = new System.Windows.Forms.Label();
            this.bYes = new System.Windows.Forms.Button();
            this.bCancel = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lDelete
            // 
            this.lDelete.AutoSize = true;
            this.lDelete.Location = new System.Drawing.Point(69, 18);
            this.lDelete.Name = "lDelete";
            this.lDelete.Size = new System.Drawing.Size(139, 13);
            this.lDelete.TabIndex = 0;
            this.lDelete.Text = "Удалить статью доходов?";
            // 
            // bYes
            // 
            this.bYes.Location = new System.Drawing.Point(49, 56);
            this.bYes.Name = "bYes";
            this.bYes.Size = new System.Drawing.Size(75, 23);
            this.bYes.TabIndex = 1;
            this.bYes.Text = "Да";
            this.bYes.UseVisualStyleBackColor = true;
            this.bYes.Click += new System.EventHandler(this.bYes_Click);
            // 
            // bCancel
            // 
            this.bCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.bCancel.Location = new System.Drawing.Point(160, 56);
            this.bCancel.Name = "bCancel";
            this.bCancel.Size = new System.Drawing.Size(75, 23);
            this.bCancel.TabIndex = 2;
            this.bCancel.Text = "Отмена";
            this.bCancel.UseVisualStyleBackColor = true;
            this.bCancel.Click += new System.EventHandler(this.bCancel_Click);
            // 
            // DeleteRevenueGroup
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
            this.Name = "DeleteRevenueGroup";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Удаление статьи доходов";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lDelete;
        private System.Windows.Forms.Button bYes;
        private System.Windows.Forms.Button bCancel;
    }
}