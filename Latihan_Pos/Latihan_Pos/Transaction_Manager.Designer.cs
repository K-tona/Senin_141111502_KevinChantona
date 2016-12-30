namespace Latihan_Pos
{
    partial class Transaction_Manager
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Transaction_Manager));
            this.Label_Transaction = new System.Windows.Forms.Label();
            this.Label_Catalog = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.Label_TransactionLog = new System.Windows.Forms.Label();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.TextBox_Kuantitas = new System.Windows.Forms.TextBox();
            this.Button_Jual = new System.Windows.Forms.Button();
            this.Button_Beli = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.Button_Back = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            this.SuspendLayout();
            // 
            // Label_Transaction
            // 
            this.Label_Transaction.AutoSize = true;
            this.Label_Transaction.Font = new System.Drawing.Font("OCR A Extended", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label_Transaction.Location = new System.Drawing.Point(12, 9);
            this.Label_Transaction.Name = "Label_Transaction";
            this.Label_Transaction.Size = new System.Drawing.Size(547, 35);
            this.Label_Transaction.TabIndex = 8;
            this.Label_Transaction.Text = "Point Of Sales - Transaction";
            // 
            // Label_Catalog
            // 
            this.Label_Catalog.AutoSize = true;
            this.Label_Catalog.Font = new System.Drawing.Font("OCR A Extended", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label_Catalog.Location = new System.Drawing.Point(13, 81);
            this.Label_Catalog.Name = "Label_Catalog";
            this.Label_Catalog.Size = new System.Drawing.Size(110, 25);
            this.Label_Catalog.TabIndex = 14;
            this.Label_Catalog.Text = "Catalog";
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(12, 109);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowTemplate.Height = 28;
            this.dataGridView1.Size = new System.Drawing.Size(704, 261);
            this.dataGridView1.TabIndex = 15;
            // 
            // Label_TransactionLog
            // 
            this.Label_TransactionLog.AutoSize = true;
            this.Label_TransactionLog.Font = new System.Drawing.Font("OCR A Extended", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label_TransactionLog.Location = new System.Drawing.Point(13, 373);
            this.Label_TransactionLog.Name = "Label_TransactionLog";
            this.Label_TransactionLog.Size = new System.Drawing.Size(222, 25);
            this.Label_TransactionLog.TabIndex = 14;
            this.Label_TransactionLog.Text = "Transaction Log";
            // 
            // dataGridView2
            // 
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Location = new System.Drawing.Point(12, 401);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.RowTemplate.Height = 28;
            this.dataGridView2.Size = new System.Drawing.Size(704, 261);
            this.dataGridView2.TabIndex = 15;
            // 
            // TextBox_Kuantitas
            // 
            this.TextBox_Kuantitas.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TextBox_Kuantitas.Location = new System.Drawing.Point(273, 669);
            this.TextBox_Kuantitas.Multiline = true;
            this.TextBox_Kuantitas.Name = "TextBox_Kuantitas";
            this.TextBox_Kuantitas.Size = new System.Drawing.Size(165, 52);
            this.TextBox_Kuantitas.TabIndex = 16;
            // 
            // Button_Jual
            // 
            this.Button_Jual.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Button_Jual.Location = new System.Drawing.Point(583, 669);
            this.Button_Jual.Name = "Button_Jual";
            this.Button_Jual.Size = new System.Drawing.Size(133, 52);
            this.Button_Jual.TabIndex = 21;
            this.Button_Jual.Text = "SELL";
            this.Button_Jual.UseVisualStyleBackColor = true;
            this.Button_Jual.Click += new System.EventHandler(this.Button_Jual_Click);
            // 
            // Button_Beli
            // 
            this.Button_Beli.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Button_Beli.Location = new System.Drawing.Point(444, 669);
            this.Button_Beli.Name = "Button_Beli";
            this.Button_Beli.Size = new System.Drawing.Size(133, 52);
            this.Button_Beli.TabIndex = 21;
            this.Button_Beli.Text = "BUY";
            this.Button_Beli.UseVisualStyleBackColor = true;
            this.Button_Beli.Click += new System.EventHandler(this.Button_Beli_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("OCR A Extended", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(129, 669);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(138, 25);
            this.label1.TabIndex = 14;
            this.label1.Text = "Kuantitas";
            // 
            // Button_Back
            // 
            this.Button_Back.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("Button_Back.BackgroundImage")));
            this.Button_Back.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.Button_Back.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Button_Back.Location = new System.Drawing.Point(12, 668);
            this.Button_Back.Name = "Button_Back";
            this.Button_Back.Size = new System.Drawing.Size(51, 52);
            this.Button_Back.TabIndex = 22;
            this.Button_Back.UseVisualStyleBackColor = true;
            this.Button_Back.Click += new System.EventHandler(this.Button_Back_Click);
            // 
            // Transaction_Manager
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(728, 744);
            this.Controls.Add(this.Button_Back);
            this.Controls.Add(this.Button_Beli);
            this.Controls.Add(this.Button_Jual);
            this.Controls.Add(this.TextBox_Kuantitas);
            this.Controls.Add(this.dataGridView2);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Label_TransactionLog);
            this.Controls.Add(this.Label_Catalog);
            this.Controls.Add(this.Label_Transaction);
            this.Name = "Transaction_Manager";
            this.Text = "Transaction_Manager";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label Label_Transaction;
        private System.Windows.Forms.Label Label_Catalog;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label Label_TransactionLog;
        private System.Windows.Forms.DataGridView dataGridView2;
        private System.Windows.Forms.TextBox TextBox_Kuantitas;
        private System.Windows.Forms.Button Button_Jual;
        private System.Windows.Forms.Button Button_Beli;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button Button_Back;
    }
}