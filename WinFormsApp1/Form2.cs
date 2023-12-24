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

namespace WinFormsApp1
{
    enum RowState
    {
        Existed,
        New,
        Modified,
        ModifiedNew,
        Deleted
    }

    public partial class Form2 : Form
    {
        DB db = new DB();

        int selectedRow;

        public Form2()
        {
            InitializeComponent();
        }

        private void CreateColums()
        {
            dataGridView1.Columns.Add("id", "id");
            dataGridView1.Columns.Add("Registration_Date", "Registration_Date");
            dataGridView1.Columns.Add("Assume_Date_Issue", "Assume_Date_Issue");
            dataGridView1.Columns.Add("Date_Issue", "Date_Issue");
            dataGridView1.Columns.Add("Fabric_ID", "Fabric_ID");
            dataGridView1.Columns.Add("Fabric_Count", "Fabric_Count");
            dataGridView1.Columns.Add("Model_ID", "Model_ID");
            dataGridView1.Columns.Add("Client_ID", "Client_ID");
            dataGridView1.Columns.Add("Size_ID", "Size_ID");
            dataGridView1.Columns.Add("Order_Cost", "Order_Cost");
            dataGridView1.Columns.Add("Prepayment", "Prepayment");
            dataGridView1.Columns.Add("Order_State", "Order_State");
        }

        private void ReadSingleRow(DataGridView dgw, IDataRecord record)
        {
                                                                                                                                                            dgw.Rows.Add(record.GetInt32(0),
                                                                                                                                                                record.GetData(1),
                record.GetData(2),
                record.GetData(3),
                record.GetInt32(4),
                record.GetInt32(5),
                record.GetInt32(6),
                record.GetInt32(7),
                record.GetInt32(8),
                record.GetInt32(9),
                record.GetInt32(10),
                record.GetString(11),
                RowState.ModifiedNew);
        }

        private void RefreshDataGrid(DataGridView dgw)
        {
            dgw.Rows.Clear();

            string query = $"SELECT * FROM Size;";
            db.openConnection();
            MySqlCommand command = new MySqlCommand(query, db.getConnection());


            MySqlDataReader reader = command.ExecuteReader();

            while (reader.Read())
            {
                ReadSingleRow(dgw, reader);
            }

            reader.Close();
        }

        private void Form2_load(object sender, EventArgs e)
        {
            CreateColums();
            RefreshDataGrid(dataGridView1);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form3 newForm3 = new Form3();
            newForm3.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form4 newForm4 = new Form4();
            newForm4.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Form5 newForm5 = new Form5();
            newForm5.Show();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
