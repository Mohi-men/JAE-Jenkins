using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculator.Tests
{
    [SetUpFixture]
    public class NamespaceSetupTeardown
    {
        [OneTimeSetUp]
        public void SetUp()
        {
            Console.WriteLine("Setup started from namespace");
        }

        [OneTimeTearDown]
        public void TearDown()
        {
            Console.WriteLine("Teardown started from namespace");
        }
    }
}
