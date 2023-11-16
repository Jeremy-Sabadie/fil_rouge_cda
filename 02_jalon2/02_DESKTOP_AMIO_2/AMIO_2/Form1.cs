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

        private async void BTvalid_Click(object sender, EventArgs e)
        {
            await _db.GetMaterialsAsync();
        }

        private void BTvalid_Click_1(object sender, EventArgs e)
        {
            Form2 form2 = new Form2();
            form2.Show();
        }
    }
}