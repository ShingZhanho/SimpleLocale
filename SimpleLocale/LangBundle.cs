using System.IO;

namespace SimpleLocale {
    /// <summary>
    /// The LangBundle represents a bdl file with metadata
    /// </summary>
    public abstract class LangBundle : LangSubBundle {
        
        
        // Metadata of LangBundle:
        public string LocaleCode { get; internal set; }
        public string LocaleName { get; internal set; }
        public string LocaleVersion { get; internal set; }
        public string LocaleAuthor { get; internal set; }
        public string LocaleDescription { get; internal set; }
    }
}