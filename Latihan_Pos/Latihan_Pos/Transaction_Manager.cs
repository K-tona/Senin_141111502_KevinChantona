using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace Latihan_Pos
{
    public partial class Transaction_Manager : Form
    {
        string max;
        MySqlConnection koneksi = new MySqlConnection("Server=127.0.0.1;Database=DataSales;Uid=root;Pwd=Weak");
        DataTable MyD_Table;
        MySqlDataAdapter MyD_Adapter;
        MySqlCommand command;
        private string Selected_ID;
        private string Selected_Code;
        private string Selected_Name;
        private int Selected_Jumlah;
        private decimal Selected_HargaHPP;
        private decimal Selected_HargaJual;
        private DateTime Selected_Date;
        public Transaction_Manager()
        {
            InitializeComponent();
        }

        private void Button_Beli_Click(object sender, EventArgs e)
        {
            if (TextBox_Kuantitas == null)
            {
                TextBox_Kuantitas.Text = "0";
            }
            updateData("BUY");
        }

        private void Button_Jual_Click(object sender, EventArgs e)
        {
            if (TextBox_Kuantitas == null)
            {
                TextBox_Kuantitas.Text = "0";
            }
            updateData("SELL");
        }
        void showAll()
        {
            command = new MySqlCommand("select * from Things", koneksi);
            MyD_Adapter = new MySqlDataAdapter(command);
            MyD_Table = new DataTable();
            MyD_Adapter.Fill(MyD_Table);
            //Masukkan ke Data Gridview
            dataGridView1.DataSource = MyD_Table;

            command = new MySqlCommand("select * from Trans_Log", koneksi);
            MyD_Adapter = new MySqlDataAdapter(command);
            MyD_Table = new DataTable();
            MyD_Adapter.Fill(MyD_Table);
            //Masukkan ke Data Gridview
            dataGridView2.DataSource = MyD_Table;
        }

        void updateData(string Status)
        {
            koneksi.Open();
            try
            {
                command = new MySqlCommand("update Things set _code=@_code,_name=@_name,_FirstSUM=@_FirstSUM,_HPPPrice=@_Hppprice,_SalePrice=@_SalePrice,Born=@Born,Mutated=@Mutated where id=@id", koneksi);
                command.Parameters.AddWithValue("@id", Selected_ID);
                command.Parameters.AddWithValue("@_code", Selected_Code);
                command.Parameters.AddWithValue("@_name", Selected_Name);
                if(Status == "BUY") { command.Parameters.AddWithValue("@_FirstSUM", Selected_Jumlah + int.Parse(TextBox_Kuantitas.Text)); }
                else if(Status == "SELL") { command.Parameters.AddWithValue("@_FirstSUM", Selected_Jumlah - int.Parse(TextBox_Kuantitas.Text)); }
                command.Parameters.AddWithValue("@_Hppprice", Selected_HargaHPP);
                command.Parameters.AddWithValue("@_SalePrice", Selected_HargaJual);
                command.Parameters.AddWithValue("@Born", Selected_Date);
                command.Parameters.AddWithValue("@Mutated", DateTime.Today);
                command.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            koneksi.Close();

            try
            {
                koneksi.Open();
                command = new MySqlCommand("insert into Trans_Log values(@id_Trans,@id_Things,@code_Things,@Name_Things,@_status,@_quantity,@_totalprice,@_time)", koneksi);
                command.Parameters.AddWithValue("@id_trans", MyD_Table.Rows[0][0].ToString());
                command.Parameters.AddWithValue("@id_Things", Selected_ID);
                command.Parameters.AddWithValue("@code_things", Selected_Code);
                command.Parameters.AddWithValue("@Name_things", Selected_Name);
                command.Parameters.AddWithValue("@_status", Status);
                command.Parameters.AddWithValue("@_quantity", int.Parse(TextBox_Kuantitas.Text));
                if (Status == "BUY") { command.Parameters.AddWithValue("@_totalprice", int.Parse(TextBox_Kuantitas.Text) * Selected_HargaHPP); }
                else if (Status == "SELL") { command.Parameters.AddWithValue("@_totalprice", int.Parse(TextBox_Kuantitas.Text) * Selected_HargaJual); }
                command.Parameters.AddWithValue("@_time", DateTime.Today);
                command.ExecuteNonQuery();
                koneksi.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

            showAll();

        }

        private void Button_Back_Click(object sender, EventArgs e)
        {
            this.Close();
            Form1 Main_Menu = new Form1();
            Main_Menu.Show();
        }
    }
}
