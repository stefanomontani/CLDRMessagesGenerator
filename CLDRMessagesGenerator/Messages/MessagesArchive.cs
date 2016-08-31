using Com.AzureSeed.CLDRMessagesGenerator.Model;
using Newtonsoft.Json;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;

namespace Com.AzureSeed.CLDRMessagesGenerator.Messages
{
    class MessagesArchive
    {
        private readonly string _folderPath;

        private const string KEYWORDS_FILENAME = "keywords.json";
        private const string LOCALES_FILENAME = "locales.json";

        public MessagesArchive(string folderPath)
        {
            _folderPath = folderPath;
        }

        /// <summary>
        /// Returns TRUE if the folder contains the archive files.
        /// </summary>
        /// <returns></returns>
        public bool Exists()
        {
            if (!File.Exists(MapPath(KEYWORDS_FILENAME)))
            {
                return false;
            }

            if (!File.Exists(MapPath(LOCALES_FILENAME)))
            {
                return false;
            }

            return true;
        }

        public List<KeyWord> LoadKeywords()
        {
            string json = ReadFile(KEYWORDS_FILENAME);
            var result = JsonConvert.DeserializeObject<List<KeyWord>>(json);
            return result;
        }

        public Archive LoadArchive()
        {
            string json = ReadFile(LOCALES_FILENAME);
            var result = JsonConvert.DeserializeObject<Archive>(json);
            return result;
        }

        public MessageData LoadMessages(string locale)
        {
            string json = ReadFile(KEYWORDS_FILENAME);
            var result = JsonConvert.DeserializeObject<MessageData>(json);
            return result;
        }

        private string ReadFile(string fileName)
        {
            return File.ReadAllText(MapPath(fileName));
        }

        private void WriteFile(string fileName, string text)
        {
            File.WriteAllText(MapPath(fileName), text, Encoding.UTF8);
        }

        private string MapPath(string filename)
        {
            return Path.Combine(_folderPath, filename);
        }

    }
}
