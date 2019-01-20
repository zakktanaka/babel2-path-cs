using Microsoft.VisualStudio.TestTools.UnitTesting;
using Babel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Babel.Tests
{
    [TestClass()]
    public class BabelDirectoryTests
    {
        [TestMethod()]
        public void BabelDirectory_BabelDirectoryTest()
        {
            {
                var path = new BabelDirectory("c:\\Temp");
                Console.WriteLine(path.Path);
            }
            {
                var path = new BabelDirectory("c:\\hoge\\..\\temp");
                Console.WriteLine(path.Path);
            }
            {
                var path = new BabelDirectory("c:\\hoge\\..\\temp\\");
                Console.WriteLine(path.Path);
            }
        }

        [TestMethod()]
        public void AllFilesTest()
        {
            var folder = new BabelDirectory(Environment.CurrentDirectory+"\\..\\..");
            foreach(var file in folder.AllFiles)
            {
                Console.WriteLine(file);
                Assert.IsTrue(File.Exists(Path.Combine(folder.Path, file)));
            }
        }

        [TestMethod()]
        public void AllDirectoriesTest()
        {
            var folder = new BabelDirectory(Environment.CurrentDirectory + "\\..\\..");
            foreach (var directory in folder.AllDirectories)
            {
                Console.WriteLine(directory);
                Assert.IsTrue(Directory.Exists(Path.Combine(folder.Path, directory)));
            }
        }
    }
}