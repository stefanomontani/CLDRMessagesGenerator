using Com.AzureSeed.CLDRMessagesGenerator.Util;
using System;
using System.IO;
using System.Windows.Forms;

namespace Com.AzureSeed.CLDRMessagesGenerator.UI
{
    public partial class StartForm : Form
    {
        public StartForm()
        {
            InitializeComponent();
        }

        private void btnOpenMessagesArchive_Click(object sender, EventArgs e)
        {
            try
            {
                if (!ValidateData())
                {
                    return;
                }

                OpenArchive();
            }
            catch (Exception ex)
            {
                UtilMessages.ShowError(ex);
            }
        }

        private void btnCreateMessagesArchive_Click(object sender, EventArgs e)
        {
            try
            {
                if (!ValidateData())
                {
                    return;
                }

                CreateArchive();
            }
            catch (Exception ex)
            {
                UtilMessages.ShowError(ex);
            }
        }


        private bool ValidateData()
        {
            string folderPath = txtMessagesFolder.Text.Trim();

            if (string.IsNullOrWhiteSpace(folderPath))
            {
                UtilMessages.ShowWarning("Select a messages archive folder.");
                return false;
            }

            if (!Directory.Exists(folderPath))
            {
                UtilMessages.ShowWarning("Can not find selected folder.");
                return false;
            }



            return true;
        }

        private void OpenArchive()
        {

        }

        private void CreateArchive()
        {

        }
    }
}
