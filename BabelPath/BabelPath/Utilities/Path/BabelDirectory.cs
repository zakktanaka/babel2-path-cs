using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Babel
{
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
    }
}
