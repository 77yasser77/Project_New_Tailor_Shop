namespace Project_New_Tailor_Shop
{
    partial class FormMian
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
            this.butCustomer = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // butCustomer
            // 
            this.butCustomer.Location = new System.Drawing.Point(72, 158);
            this.butCustomer.Name = "butCustomer";
            this.butCustomer.Size = new System.Drawing.Size(165, 81);
            this.butCustomer.TabIndex = 0;
            this.butCustomer.Text = "العميل";
            this.butCustomer.UseVisualStyleBackColor = true;
            this.butCustomer.Click += new System.EventHandler(this.butCustomer_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.butCustomer);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button butCustomer;
    }
}

