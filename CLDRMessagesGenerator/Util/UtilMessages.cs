using System;
using System.Windows.Forms;

namespace Com.AzureSeed.CLDRMessagesGenerator.Util
{
    static class UtilMessages
    {
        public static void ShowError(Exception ex)
        {
            MessageBox.Show("Error: " + ex.Message, "Error",  MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        public static void ShowWarning(string text)
        {
            MessageBox.Show(text, "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        }
    }
}
