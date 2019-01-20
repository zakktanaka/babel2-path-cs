using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.IO;

namespace BabelPathTests.Sandbox
{
    [TestClass]
    public class SandboxUriTest
    {
        [TestMethod]
        public void SandboxUriTest_UriTest0()
        {
            var uri = new Uri("C:\\program files\\[]#~_*+-(){}\"'`あいうえお散歩トカラtest.txt");
            Console.WriteLine(uri.AbsolutePath);
            Console.WriteLine(uri.AbsoluteUri);
            Console.WriteLine(uri.ToString());
            Console.WriteLine(uri.OriginalString);
            Console.WriteLine(uri.LocalPath);
            Console.WriteLine(uri.Fragment);
            Console.WriteLine(Uri.UnescapeDataString(uri.Fragment));
        }

        [TestMethod]
        public void SandboxUriTest_UriTest1()
        {
            var uri = new Uri("\\\\serv\\program files\\[]#~_*+-(){}\"'`あいうえお散歩トカラtest.txt");
            Console.WriteLine(uri.AbsolutePath);
            Console.WriteLine(uri.AbsoluteUri);
            Console.WriteLine(uri.ToString());
            Console.WriteLine(uri.OriginalString);
            Console.WriteLine(uri.LocalPath);
            Console.WriteLine(uri.Fragment);
            Console.WriteLine(Uri.UnescapeDataString(uri.Fragment));
        }

        [TestMethod]
        public void SandboxUriTest_UriTest2()
        {
            var uri = new Uri("c:\\test\\hoge\\..\\fuga\\");
            Console.WriteLine(uri.AbsolutePath);
            Console.WriteLine(uri.AbsoluteUri);
            Console.WriteLine(uri.ToString());
            Console.WriteLine(uri.OriginalString);
            Console.WriteLine(uri.LocalPath);
            Console.WriteLine(uri.Fragment);
            Console.WriteLine(Uri.UnescapeDataString(uri.AbsolutePath));

            var rel = uri.MakeRelativeUri(new Uri("c:\\test\\fuga\\hogehoge\\[]#~_*+-(){}\"'`あいうえお散歩トカラtest.txt"));
            Console.WriteLine(rel.ToString());
            Console.WriteLine(Uri.UnescapeDataString(rel.ToString()));
        }

        [TestMethod]
        public void SandboxUriTest_UriTest3()
        {
            var dir0 = "c:\\test";
            Console.WriteLine(Path.GetFullPath(dir0));

            var dir1 = "c:\\test\\";
            Console.WriteLine(Path.GetFullPath(dir1));

            var dir2 = "c:\\test\\\\";
            Console.WriteLine(Path.GetFullPath(dir2));
        }
    }
}
