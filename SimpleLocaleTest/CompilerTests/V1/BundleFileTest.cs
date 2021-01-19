using System.IO;
using NUnit.Framework;
using SimpleLocale.Compiler.V1;

namespace SimpleLocaleTest.CompilerTests.V1 {
    public class BundleFileTest {
        [Test]
        public void BundleFile_Ctor_FakeFile_Exception() {
            Assert.Catch<FileNotFoundException>(new TestDelegate(() => new BundleFile("haha.bdl")));
        }
    }
}