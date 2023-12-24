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
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace WinFormsApp1
{
    public partial class Form5 : Form
    {
        DB db = new DB();
        public Form5()
        {
            InitializeComponent();
        }

        private void Form5_Load(object sender, EventArgs e)
        {
           
        }

        private void button1_Click(object sender, EventArgs e)
        {
            db.openConnection();
            string query = $"DELETE FROM [ORDER] WHERE [Order_ID] = {textBox6.Text};";
            MySqlCommand command = new MySqlCommand(query, db.getConnection());
            command.ExecuteNonQuery();
            db.closeConnection();

            Form2 newForm2 = new Form2();
            newForm2.Show();
        }
    }
}
