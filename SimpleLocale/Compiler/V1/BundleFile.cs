using System.IO;

namespace SimpleLocale.Compiler.V1 {
    /// <summary>
    /// Represents a bdl file with metadata defined
    /// </summary>
    public class BundleFile {
        public BundleFile(string file) {
            if (!File.Exists(file))
                throw new FileNotFoundException(
                    "The specified bundle file was not found.", file);
        }
    }
}