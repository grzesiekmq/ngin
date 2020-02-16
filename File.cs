using Newtonsoft.Json;
using System.IO;

namespace rgn
{
    public class File
    {
        public File()
        {
        }

        /// <summary>
        /// Loads and parses the json file.
        /// </summary>
        /// <returns>The object.</returns>
        /// <param name="file">File.</param>
        public static object Load(string file)
        {
            StreamReader sr = System.IO.File.OpenText(file);
            var contents = sr.ReadToEnd();
            dynamic json = JsonConvert.DeserializeObject(contents);

            return json;
        }

        /// <summary>
        /// Saves object to json file
        /// </summary>
        /// <param name="file">File.</param>
        /// <param name="contents">Contents.</param>
        public static void Save(string file, object contents)
        {
            var json = JsonConvert.SerializeObject(contents);
            System.IO.File.WriteAllText(file, json);
        }
    }
}