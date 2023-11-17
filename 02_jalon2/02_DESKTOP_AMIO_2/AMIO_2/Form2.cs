namespace AMIO_2
{
    public partial class Form2 : Form
    {
        DatabaseAccess _db = new();
        public Form2()
        {
            InitializeComponent();


        }

        private void checkBox2_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void CBXnum_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void FLPcontainerCRUD_Paint(object sender, PaintEventArgs e)
        {

        }

        private void BTread_Click(object sender, EventArgs e)
        {
            var materials = _db.GetMaterialsAsync();
        }

        private async void BTcreate_Click(object sender, EventArgs e)
        {
            var mateial = await _db.AddMaterialAsync(TXTname.Text, DTPservDat.Value, DTPendGarantee.Value, TXTowner.Text);
        }

        private void BTupdate_Click(object sender, EventArgs e)
        {
            _db.updateMaterial(TXTname.Text);
        }
    }
}
