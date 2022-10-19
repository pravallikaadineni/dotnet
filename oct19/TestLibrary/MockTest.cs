using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static oct19.Mock;

namespace TestLibrary
{

    public class MockTest
    {
        [TestFixture]
        public class UnitTest2
        {
            [TestCase]
            public void TestMethod1()
            {
                //Act  
                MockExtensionService mockobject = new MockExtensionService();
                //Inject mock object now  
                ExtensionAnalyzer analyzer = new ExtensionAnalyzer(mockobject);
                //Action  
                analyzer.ExtensionCheck("somefile.someextension");

                //Assert  
                Assert.AreEqual(mockobject.ErrorMessage, "Wrong Type");
            }
        }

    }
}