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
        //TO DO: write all the arguments necessary on the update function call.
        private void BTupdate_Click(object sender, EventArgs e)
        {
            _db.updateMaterial(TXTname.Text);
        }

        private void BTdellete_Click(object sender, EventArgs e)
        {
            //TO DO: retrieve information about the element being deleted.
            var confirmResult = MessageBox.Show($"Confirmez-vous la suppression du matériel: ... ?", "confirmation", MessageBoxButtons.YesNo);
            if (confirmResult == DialogResult.Yes)
            {
                _db.DeleteMaterielAsync(TXTname.Text, NUDmatNumber.Value);
            }
        }

        private void TXTowner_TextChanged(object sender, EventArgs e)
        {

        }
    }
