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
    public partial class Modify_Supplier : Form
    {
        string max;
        MySqlConnection koneksi = new MySqlConnection("Server=127.0.0.1;Database=DataSales;Uid=root;Pwd=Weak");
        DataTable MyD_Table;
        MySqlDataAdapter MyD_Adapter;
        MySqlCommand command;
        public Modify_Supplier()
        {
            InitializeComponent();
        }


        private void Button_Update_Click(object sender, EventArgs e)
        {
            if (TextBox_ID.Text == max)
            {
                insertData();
            }
            else
            {
                updateData();
            }
        }
        void reset()
        {
            command = new MySqlCommand("select ifnull(max(id),0)+1 from Supplier", koneksi);
            MyD_Adapter = new MySqlDataAdapter(command);
            MyD_Table = new DataTable();
            MyD_Adapter.Fill(MyD_Table);
            max = MyD_Table.Rows[0][0].ToString();
            TextBox_ID.Text = MyD_Table.Rows[0][0].ToString();
            TextBox_Kode.Text = "";
            TextBox_Nama.Text = "";
            TextBox_Alamat.Text = "";
        }

        void showAll()
        {
            command = new MySqlCommand("select * from Supplier", koneksi);
            MyD_Adapter = new MySqlDataAdapter(command);
            MyD_Table = new DataTable();
            MyD_Adapter.Fill(MyD_Table);
            //Masukkan ke Data Gridview
            dataGridView1.DataSource = MyD_Table;
        }

        void filteredSelect()
        {
            command = new MySqlCommand("select * from Supplier where _code like concat('%', @_code, '%') and _name like concat('%', @_name, '%')", koneksi);
            command.Parameters.AddWithValue("@_code", TextBox_Kode.Text);
            command.Parameters.AddWithValue("@_name", TextBox_Nama.Text);
            MyD_Adapter = new MySqlDataAdapter(command);
            MyD_Table = new DataTable();
            MyD_Adapter.Fill(MyD_Table);

            dataGridView1.DataSource = MyD_Table;

        }

        void insertData()
        {
            try
            {
                koneksi.Open();
                command = new MySqlCommand("insert into Supplier values(@id,@_code,@_name,@_Address,@Born,@Mutated)", koneksi);
                command.Parameters.AddWithValue("@id", TextBox_ID.Text);
                command.Parameters.AddWithValue("@_code", TextBox_Kode.Text);
                command.Parameters.AddWithValue("@_name", TextBox_Nama.Text);
                command.Parameters.AddWithValue("@_Address", TextBox_Alamat.Text);
                command.Parameters.AddWithValue("@Born", DateTime.Today);
                command.Parameters.AddWithValue("@Mutated", DateTime.Today);
                command.ExecuteNonQuery();
                koneksi.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

            showAll();
            reset();
        }

        void updateData()
        {
            koneksi.Open();
            try
            {
                command = new MySqlCommand("update Supplier set _code=@_code,_name=@_name,_Address=@_Address,Born=@Born,Mutated=@Mutated where id=@id", koneksi);
                command.Parameters.AddWithValue("@id", TextBox_ID.Text);
                command.Parameters.AddWithValue("@_code", TextBox_Kode.Text);
                command.Parameters.AddWithValue("@_name", TextBox_Nama.Text);
                command.Parameters.AddWithValue("@_Address", TextBox_Alamat.Text);
                command.Parameters.AddWithValue("@Born", dateTimePicker1.Value);
                command.Parameters.AddWithValue("@Mutated", DateTime.Today);
                command.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

            showAll();
            reset();
            koneksi.Close();

        }

        private void Modify_Supplier_Load(object sender, EventArgs e)
        {
            showAll();
            reset();

            dataGridView1.ClearSelection();

        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dataGridView1.SelectedCells.Count > 0)
            {
                int index = dataGridView1.SelectedCells[0].RowIndex;
                TextBox_ID.Text = dataGridView1.Rows[index].Cells[0].Value.ToString();
                TextBox_Kode.Text = dataGridView1.Rows[index].Cells[1].Value.ToString();
                TextBox_Nama.Text = dataGridView1.Rows[index].Cells[2].Value.ToString();
                TextBox_Alamat.Text = dataGridView1.Rows[index].Cells[3].Value.ToString();
                dateTimePicker1.Value = DateTime.Parse(dataGridView1.Rows[index].Cells[6].Value.ToString());
            }
        }

        private void txtKode_TextChanged(object sender, EventArgs e)
        {
            filteredSelect();
        }

        private void txtNama_TextChanged(object sender, EventArgs e)
        {
            filteredSelect();
        }

        private void Button_Back_Click(object sender, EventArgs e)
        {
            Form1 Main_Menu = new Form1();
            Main_Menu.Show();
        }
    }
}
