using Microsoft.VisualStudio.TestTools.UnitTesting;
using Babel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
    }
}