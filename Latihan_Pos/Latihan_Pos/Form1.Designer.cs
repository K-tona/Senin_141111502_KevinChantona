namespace Latihan_Pos
{
    partial class Form1
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
            this.Label_Question = new System.Windows.Forms.Label();
            this.Button_Stuff = new System.Windows.Forms.Button();
            this.Button_Staff = new System.Windows.Forms.Button();
            this.Button_Supplier = new System.Windows.Forms.Button();
            this.Button_Transaction = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // Label_Question
            // 
            this.Label_Question.AutoSize = true;
            this.Label_Question.Font = new System.Drawing.Font("OCR A Extended", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label_Question.Location = new System.Drawing.Point(13, 13);
            this.Label_Question.Name = "Label_Question";
            this.Label_Question.Size = new System.Drawing.Size(623, 70);
            this.Label_Question.TabIndex = 0;
            this.Label_Question.Text = "Sir\r\nWhat are you going to do today ?";
            // 
            // Button_Stuff
            // 
            this.Button_Stuff.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Button_Stuff.Location = new System.Drawing.Point(19, 110);
            this.Button_Stuff.Name = "Button_Stuff";
            this.Button_Stuff.Size = new System.Drawing.Size(211, 52);
            this.Button_Stuff.TabIndex = 21;
            this.Button_Stuff.Text = "Stuff Editor";
            this.Button_Stuff.UseVisualStyleBackColor = true;
            this.Button_Stuff.Click += new System.EventHandler(this.Button_Stuff_Click);
            // 
            // Button_Staff
            // 
            this.Button_Staff.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Button_Staff.Location = new System.Drawing.Point(19, 183);
            this.Button_Staff.Name = "Button_Staff";
            this.Button_Staff.Size = new System.Drawing.Size(211, 52);
            this.Button_Staff.TabIndex = 21;
            this.Button_Staff.Text = "Staff Editor";
            this.Button_Staff.UseVisualStyleBackColor = true;
            this.Button_Staff.Click += new System.EventHandler(this.Button_Staff_Click);
            // 
            // Button_Supplier
            // 
            this.Button_Supplier.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Button_Supplier.Location = new System.Drawing.Point(19, 257);
            this.Button_Supplier.Name = "Button_Supplier";
            this.Button_Supplier.Size = new System.Drawing.Size(211, 52);
            this.Button_Supplier.TabIndex = 21;
            this.Button_Supplier.Text = "Supplier Editor";
            this.Button_Supplier.UseVisualStyleBackColor = true;
            this.Button_Supplier.Click += new System.EventHandler(this.Button_Supplier_Click);
            // 
            // Button_Transaction
            // 
            this.Button_Transaction.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Button_Transaction.Location = new System.Drawing.Point(19, 331);
            this.Button_Transaction.Name = "Button_Transaction";
            this.Button_Transaction.Size = new System.Drawing.Size(211, 52);
            this.Button_Transaction.TabIndex = 21;
            this.Button_Transaction.Text = "Transaction";
            this.Button_Transaction.UseVisualStyleBackColor = true;
            this.Button_Transaction.Click += new System.EventHandler(this.Button_Transaction_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(667, 711);
            this.Controls.Add(this.Button_Transaction);
            this.Controls.Add(this.Button_Supplier);
            this.Controls.Add(this.Button_Staff);
            this.Controls.Add(this.Button_Stuff);
            this.Controls.Add(this.Label_Question);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label Label_Question;
        private System.Windows.Forms.Button Button_Stuff;
        private System.Windows.Forms.Button Button_Staff;
        private System.Windows.Forms.Button Button_Supplier;
        private System.Windows.Forms.Button Button_Transaction;
    }
}

