namespace Project_New_Tailor_Shop
{
    partial class FormAddNewNumber
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
            this.butADD = new System.Windows.Forms.Button();
            this.butClose = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.textNumber = new System.Windows.Forms.TextBox();
            this.textNote = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // butADD
            // 
            this.butADD.Location = new System.Drawing.Point(226, 218);
            this.butADD.Name = "butADD";
            this.butADD.Size = new System.Drawing.Size(112, 68);
            this.butADD.TabIndex = 0;
            this.butADD.Tag = "OK";
            this.butADD.Text = "إضافة";
            this.butADD.UseVisualStyleBackColor = true;
            this.butADD.Click += new System.EventHandler(this.butADD_Click);
            // 
            // butClose
            // 
            this.butClose.Location = new System.Drawing.Point(56, 218);
            this.butClose.Name = "butClose";
            this.butClose.Size = new System.Drawing.Size(112, 68);
            this.butClose.TabIndex = 1;
            this.butClose.Text = "الغاء";
            this.butClose.UseVisualStyleBackColor = true;
            this.butClose.Click += new System.EventHandler(this.butClose_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(305, 85);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(33, 16);
            this.label1.TabIndex = 2;
            this.label1.Text = "الرقم";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(290, 142);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(48, 16);
            this.label2.TabIndex = 3;
            this.label2.Text = "ملاحظة";
            // 
            // textNumber
            // 
            this.textNumber.Location = new System.Drawing.Point(178, 104);
            this.textNumber.Name = "textNumber";
            this.textNumber.Size = new System.Drawing.Size(160, 23);
            this.textNumber.TabIndex = 4;
            // 
            // textNote
            // 
            this.textNote.Location = new System.Drawing.Point(178, 161);
            this.textNote.Name = "textNote";
            this.textNote.Size = new System.Drawing.Size(160, 23);
            this.textNote.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Tahoma", 11.26957F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(118, 42);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(138, 23);
            this.label3.TabIndex = 6;
            this.label3.Text = "إضافة رقم أخر";
            // 
            // FormAddNewNumber
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(382, 312);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.textNote);
            this.Controls.Add(this.textNumber);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.butClose);
            this.Controls.Add(this.butADD);
            this.Name = "FormAddNewNumber";
            this.Text = "AddNewNumber";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button butADD;
        private System.Windows.Forms.Button butClose;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textNumber;
        private System.Windows.Forms.TextBox textNote;
        private System.Windows.Forms.Label label3;
    }
}