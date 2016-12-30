using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Latihan_Pos
{
    public partial class Form1 : Form
    {
        
        public Form1()
        {
            InitializeComponent();
        }

        private void Button_Stuff_Click(object sender, EventArgs e)
        {
            this.Hide();
            Modify_Barang form_Barang = new Modify_Barang();
            form_Barang.Show();
        }

        private void Button_Staff_Click(object sender, EventArgs e)
        {
            this.Hide();
            Modify_Staff form_Barang = new Modify_Staff();
            form_Barang.Show();
        }

        private void Button_Supplier_Click(object sender, EventArgs e)
        {
            this.Hide();
            Modify_Supplier form_Barang = new Modify_Supplier();
            form_Barang.Show();
        }

        private void Button_Transaction_Click(object sender, EventArgs e)
        {
            this.Hide();
            Transaction_Manager form_Barang = new Transaction_Manager();
            form_Barang.Show();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            Modify_Barang form_Barang = new Modify_Barang();
            Modify_Staff form_Staff = new Modify_Staff();
            Modify_Supplier form_Supplier = new Modify_Supplier();
            Transaction_Manager form_Transaction = new Transaction_Manager();
            form_Barang.Close();
            form_Staff.Close();
            form_Supplier.Close();
            form_Transaction.Close();
        }
    }
}
