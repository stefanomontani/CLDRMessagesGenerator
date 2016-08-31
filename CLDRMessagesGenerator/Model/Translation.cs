using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Com.AzureSeed.CLDRMessagesGenerator.Model
{
    /// <summary>
    /// Represents a translation in editing.
    /// </summary>
    class Translation
    {
        public string Key { get; set; } = string.Empty;
        public string Value { get; set; } = string.Empty;
        public string Comment { get; set; } = string.Empty;
    }
}
