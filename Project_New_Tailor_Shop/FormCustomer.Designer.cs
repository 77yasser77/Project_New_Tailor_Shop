namespace Project_New_Tailor_Shop
{
    partial class FormCustomer
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
            this.butAddCustomer = new System.Windows.Forms.Button();
            this.butFindCustomer = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // butAddCustomer
            // 
            this.butAddCustomer.Location = new System.Drawing.Point(30, 159);
            this.butAddCustomer.Name = "butAddCustomer";
            this.butAddCustomer.Size = new System.Drawing.Size(106, 81);
            this.butAddCustomer.TabIndex = 0;
            this.butAddCustomer.Text = "إظافة عميل";
            this.butAddCustomer.UseVisualStyleBackColor = true;
            this.butAddCustomer.Click += new System.EventHandler(this.butAddCustomer_Click);
            // 
            // butFindCustomer
            // 
            this.butFindCustomer.Location = new System.Drawing.Point(160, 159);
            this.butFindCustomer.Name = "butFindCustomer";
            this.butFindCustomer.Size = new System.Drawing.Size(106, 81);
            this.butFindCustomer.TabIndex = 1;
            this.butFindCustomer.Text = "بحث عن عميل";
            this.butFindCustomer.UseVisualStyleBackColor = true;
            this.butFindCustomer.Click += new System.EventHandler(this.butFindCustomer_Click);
            // 
            // FormCustomer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.butFindCustomer);
            this.Controls.Add(this.butAddCustomer);
            this.Name = "FormCustomer";
            this.Text = "FormCustomer";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button butAddCustomer;
        private System.Windows.Forms.Button butFindCustomer;
    }
}