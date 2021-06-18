using O2S.Components.PDF4NET;
using Xunit;

namespace Pdf4netBug.UnitTests
{
    public class UnitTest1
    {
        [Fact]
        public void Test1()
        {
            var doc = new PDFFixedDocument();

            // How do we fix this error: CS0012?
            Util.DoSomething(doc);
        }
    }
}
