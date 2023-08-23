namespace WinformCRUDSample
{
    public partial class frmHero : Form
    {
        private readonly IHeroRepository _heroRepository;
        public frmHero(IHeroRepository heroRepository)
        {
            InitializeComponent();
            _heroRepository = heroRepository;
            this.StartPosition = FormStartPosition.CenterScreen;
        }

        private void btnCreate_Click(object sender, EventArgs e)
        {
            heroBindingSource.AddNew();
            ReadOnlyFields(false);
        }

        private void ReadOnlyFields(bool readOnly)
        {
            txtName.ReadOnly = txtDescription.ReadOnly = readOnly;
            cmbHeroType.Enabled = !readOnly;
            btnCreate.Enabled = btnUpdate.Enabled = btnDelete.Enabled = readOnly;
            pictureHero.Enabled = btnCancel.Enabled = btnSave.Enabled = !readOnly;
        }

        private async void btnSave_Click(object sender, EventArgs e)
        {
            ValidateFields();

            var entity = heroBindingSource.Current as Hero;
            entity.PictureUrl = "xcxada";
            if (entity?.Id == 0)
                await _heroRepository.Add(entity);
            else if (entity != null)
                await _heroRepository.Update(entity);


            MessageBox.Show("Successfully added/updated", "Inserted/Updated",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
            ReadOnlyFields(true);

        }

        private void ValidateFields()
        {
            heroDetailError.SetError(txtName, string.IsNullOrWhiteSpace(txtName.Text) ? txtName.Text : "");
            heroDetailError.SetError(txtDescription, string.IsNullOrWhiteSpace(txtDescription.Text) ? txtDescription.Text : "");
            heroDetailError.SetError(txtPicture, string.IsNullOrWhiteSpace(txtPicture.Text) ? txtPicture.Text : "");
            heroDetailError.SetError(cmbHeroType, string.IsNullOrWhiteSpace(cmbHeroType.Text) ? cmbHeroType.Text : "");

        }
        private void btnUpdate_Click(object sender, EventArgs e)
        {
            ReadOnlyFields(false);
        }

        private void pictureHero_Click(object sender, EventArgs e)
        {
            var result = heroFileDialog.ShowDialog();
            if (result == DialogResult.OK)
            {
                txtPicture.Text = heroFileDialog.FileName;
            }
        }

        private void txtPicture_TextChanged(object sender, EventArgs e)
        {
            pictureHero.ImageLocation = txtPicture.Text;
        }

        private async void frmHero_Load(object sender, EventArgs e)
        {
            ReadOnlyFields(true);
            heroBindingSource.DataSource = await _heroRepository.GetAll();
        }
        private async void btnDelete_Click(object sender, EventArgs e)
        {
            var entity = heroBindingSource.Current as Hero;
            if (entity != null && MessageBox.Show($"Delete {entity.Name}", "Delete Record",
                MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                await _heroRepository.Delete(entity);
                heroBindingSource.RemoveCurrent();
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            ReadOnlyFields(true);
        }
    }
}