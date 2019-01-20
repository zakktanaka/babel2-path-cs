using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Babel
{
    using System.IO;
    using WPath = System.IO.Path;

    public class BabelDirectory
    {
        private Uri uri;

        public BabelDirectory(string path)
        {
            
            uri = new Uri(WPath.GetFullPath(path.ToLower() + "\\"));
            Path = Uri.UnescapeDataString(uri.AbsolutePath);
        }

        public string Path { get; }

        public IEnumerable<string> AllFiles
        {
            get
            {
                return Directory
                    .EnumerateFiles(Path, "*", SearchOption.AllDirectories)
                    .Select(file =>
                    {
                        var rel = uri.MakeRelativeUri(new Uri(file));
                        return Uri.UnescapeDataString(rel.ToString());
                    });
            }
        }

        public IEnumerable<string> AllDirectories
        {
            get
            {
                return Directory
                    .EnumerateDirectories(Path, "*", SearchOption.AllDirectories)
                    .Select(file =>
                    {
                        var rel = uri.MakeRelativeUri(new Uri(file));
                        return Uri.UnescapeDataString(rel.ToString());
                    });
            }
        }
    }
}
