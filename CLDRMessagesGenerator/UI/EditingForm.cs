using Com.AzureSeed.CLDRMessagesGenerator.Util;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace Com.AzureSeed.CLDRMessagesGenerator.UI
{
    public partial class EditingForm : Form
    {
        // The translation selected in grid.
        private Model.Translation _selectedTranslation;

        //// The translation c
        //private Model.Translation _editingTranslation;

        private readonly List<Model.Translation> _translations = new List<Model.Translation>();

        public EditingForm()
        {
            InitializeComponent();
        }

        private void EditingForm_Load(object sender, EventArgs e)
        {
            gridView.DataSource = _translations;
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            try
            {
                SaveEditingData();
            }
            catch (Exception ex)
            {
                UtilMessages.ShowError(ex);
            }
        }

        private void SaveEditingData()
        {
            if (!ValidateEditingData())
            {
                return;
            }

            // If it is a new key.
            if (_selectedTranslation == null)
            {
                _selectedTranslation = new Model.Translation();
                _selectedTranslation.Key = txtKey.Text.Trim();
            }

            _selectedTranslation.Value = txtValue.Text.Trim();
            _selectedTranslation.Comment = txtComment.Text.Trim();
        }

        private bool ValidateEditingData()
        {
            bool hasErrors = false;
            errorProvider1.Clear();

            // If we are adding a new translation, check that the key is not already existing.
            if (_selectedTranslation == null)
            {
                var exists = _translations.Any(o => o.Key.ToLower() == txtKey.Text.Trim().ToLower());
                if (exists)
                {
                    UtilMessages.ShowWarning("Can not add aldready existing.");
                    return false;
                }
            }

            if (string.IsNullOrWhiteSpace(txtKey.Text))
            {
                hasErrors = true;
                errorProvider1.SetError(txtKey, "Key not set.");
            }

            if (hasErrors)
            {
                UtilMessages.ShowWarning("Check form errors");
            }

            return !hasErrors;
        }

        private void EditingForm_KeyDown(object sender, KeyEventArgs e)
        {
            try
            {
                if (e.Control && e.KeyCode == Keys.Return)
                {
                    SaveEditingData();
                }
            }
            catch (Exception ex)
            {
                UtilMessages.ShowError(ex);
            }
        }

    }
}
