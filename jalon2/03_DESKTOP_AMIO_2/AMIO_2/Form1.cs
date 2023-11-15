namespace AMIO_2
{
    public partial class Form1 : Form
    {
        DatabaseAccess _db = new();
        public Form1()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void TLPformConnection_Paint(object sender, PaintEventArgs e)
        {

        }

        private void BTvalid_Click(object sender, EventArgs e)
        {
            _db.GetAllMaterials();
        }
    }
}