using CSharpier.Tests.TestFileTests;
using NUnit.Framework;

namespace CSharpier.Tests.TestFiles
{
    public class DoStatementTests : BaseTest
    {
        [Test]
        public void BasicDoStatement()
        {
            this.RunTest("DoStatement", "BasicDoStatement");
        }
    }
}