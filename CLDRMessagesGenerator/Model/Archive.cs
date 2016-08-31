using System.Collections.Generic;

namespace Com.AzureSeed.CLDRMessagesGenerator.Model
{
    class Archive
    {
        public Archive()
        {
            Locales = new List<Locale>();
        }

        private List<Locale> Locales { get; set; }
    }
}
