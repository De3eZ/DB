using System.Windows.Forms;

namespace WinFormsApp1
{
    public partial class Form1 : Form
    {
        ContextMenuStrip contextMenuStrip;
        DB db = new DB();

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            contextMenuStrip = new ContextMenuStrip();
        }

        private void toolStripMenuItem2_Click(object sender, EventArgs e)
        {
            Form2 newForm2 = new Form2();
            newForm2.Show();
        }

        private void êëèåíòûToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MasterMain masterMain = new MasterMain(); 
            masterMain.Show();
        }
    }
}