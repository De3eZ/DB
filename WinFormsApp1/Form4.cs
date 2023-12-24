using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinFormsApp1
{
    public partial class Form4 : Form
    {
        DB db = new DB();
        public Form4()
        {
            InitializeComponent();
        }

        private void Form4_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            db.openConnection();
            string query = $"insert into [Order] ([Registration_Date], [Assume_Date_Issue],[Date_Issue],[Fabric_ID],[Fabric_Count],[Model_ID],[Client_ID],[Size_ID],[Order_Cost],[Prepayment],[Order_State]) values ('" + textBox1.Text + "', '" + textBox2.Text + "','" + textBox3.Text + "'," + textBox4.Text + "," + textBox5.Text + "," + textBox6.Text + "," + textBox7.Text + "," + textBox8.Text + "," + textBox9.Text + "," + textBox10.Text + "," + textBox11.Text + ")WHERE Order_ID = "+textBox12.Text+";";
            MySqlCommand command = new MySqlCommand(query, db.getConnection());
            command.ExecuteNonQuery();
            db.closeConnection();

            Form2 newForm2 = new Form2();
            newForm2.Show();
        }
    }
}
