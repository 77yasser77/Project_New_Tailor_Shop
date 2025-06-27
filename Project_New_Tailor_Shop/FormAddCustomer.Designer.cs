namespace Project_New_Tailor_Shop
{
    partial class FormAddCustomer
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
            this.textNameFather = new System.Windows.Forms.TextBox();
            this.textFamliy = new System.Windows.Forms.TextBox();
            this.textName = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.textGreangFather = new System.Windows.Forms.TextBox();
            this.butAddCustomer = new System.Windows.Forms.Button();
            this.butclose = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.textNumber = new System.Windows.Forms.TextBox();
            this.textNote = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.butAddNewNumber = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // textNameFather
            // 
            this.textNameFather.Location = new System.Drawing.Point(314, 114);
            this.textNameFather.MaxLength = 20;
            this.textNameFather.Name = "textNameFather";
            this.textNameFather.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.textNameFather.Size = new System.Drawing.Size(197, 23);
            this.textNameFather.TabIndex = 1;
            this.textNameFather.TabStop = false;
            // 
            // textFamliy
            // 
            this.textFamliy.Location = new System.Drawing.Point(314, 227);
            this.textFamliy.Name = "textFamliy";
            this.textFamliy.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.textFamliy.Size = new System.Drawing.Size(197, 23);
            this.textFamliy.TabIndex = 3;
            // 
            // textName
            // 
            this.textName.Location = new System.Drawing.Point(314, 58);
            this.textName.Name = "textName";
            this.textName.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.textName.Size = new System.Drawing.Size(197, 23);
            this.textName.TabIndex = 0;
            this.textName.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(479, 39);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(44, 16);
            this.label1.TabIndex = 5;
            this.label1.Text = "الأسم ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(473, 208);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(38, 16);
            this.label2.TabIndex = 6;
            this.label2.Text = "اللقب";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(478, 95);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(29, 16);
            this.label3.TabIndex = 7;
            this.label3.Text = "الاب";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(212, 39);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(61, 16);
            this.label6.TabIndex = 11;
            this.label6.Text = "الرقم الاول";
            // 
            // textGreangFather
            // 
            this.textGreangFather.Location = new System.Drawing.Point(314, 168);
            this.textGreangFather.Name = "textGreangFather";
            this.textGreangFather.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.textGreangFather.Size = new System.Drawing.Size(197, 23);
            this.textGreangFather.TabIndex = 2;
            // 
            // butAddCustomer
            // 
            this.butAddCustomer.Location = new System.Drawing.Point(327, 272);
            this.butAddCustomer.Name = "butAddCustomer";
            this.butAddCustomer.Size = new System.Drawing.Size(111, 70);
            this.butAddCustomer.TabIndex = 6;
            this.butAddCustomer.Text = "اضافة";
            this.butAddCustomer.UseVisualStyleBackColor = true;
            this.butAddCustomer.Click += new System.EventHandler(this.butAdd_Click);
            // 
            // butclose
            // 
            this.butclose.Location = new System.Drawing.Point(130, 272);
            this.butclose.Name = "butclose";
            this.butclose.Size = new System.Drawing.Size(111, 70);
            this.butclose.TabIndex = 13;
            this.butclose.Text = "الغاء";
            this.butclose.UseVisualStyleBackColor = true;
            this.butclose.Click += new System.EventHandler(this.butclose_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(481, 149);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(30, 16);
            this.label4.TabIndex = 15;
            this.label4.Text = "الجد";
            // 
            // textNumber
            // 
            this.textNumber.Location = new System.Drawing.Point(76, 58);
            this.textNumber.Name = "textNumber";
            this.textNumber.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.textNumber.Size = new System.Drawing.Size(197, 23);
            this.textNumber.TabIndex = 4;
            // 
            // textNote
            // 
            this.textNote.Location = new System.Drawing.Point(76, 114);
            this.textNote.Name = "textNote";
            this.textNote.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.textNote.Size = new System.Drawing.Size(197, 23);
            this.textNote.TabIndex = 5;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(212, 95);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(48, 16);
            this.label5.TabIndex = 16;
            this.label5.Text = "ملاحظة";
            // 
            // butAddNewNumber
            // 
            this.butAddNewNumber.Enabled = false;
            this.butAddNewNumber.Location = new System.Drawing.Point(130, 168);
            this.butAddNewNumber.Name = "butAddNewNumber";
            this.butAddNewNumber.Size = new System.Drawing.Size(111, 70);
            this.butAddNewNumber.TabIndex = 18;
            this.butAddNewNumber.Text = "اضافة رقم اخر";
            this.butAddNewNumber.UseVisualStyleBackColor = true;
            this.butAddNewNumber.Click += new System.EventHandler(this.butAddNewNumber_Click);
            // 
            // FormAddCustomer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(543, 363);
            this.Controls.Add(this.butAddNewNumber);
            this.Controls.Add(this.textNote);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.textNumber);
            this.Controls.Add(this.butclose);
            this.Controls.Add(this.butAddCustomer);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.textGreangFather);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textName);
            this.Controls.Add(this.textFamliy);
            this.Controls.Add(this.textNameFather);
            this.Name = "FormAddCustomer";
            this.Text = "FormAddCustomer";
            this.Load += new System.EventHandler(this.FormAddCustomer_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textNameFather;
        private System.Windows.Forms.TextBox textFamliy;
        private System.Windows.Forms.TextBox textName;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox textGreangFather;
        private System.Windows.Forms.Button butAddCustomer;
        private System.Windows.Forms.Button butclose;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox textNumber;
        private System.Windows.Forms.TextBox textNote;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button butAddNewNumber;
    }
}