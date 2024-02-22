using NUnit.Allure.Core;

namespace Calculator.Tests
{
    [TestFixture]
    [AllureNUnit]
    public class IntCalculatorTests
    {
        [SetUp]
        public void Setup()
        {
            Console.WriteLine("Starting test");
        }

        [TestCaseSource(typeof(AlternativeDataSource), nameof(AlternativeDataSource.AddTestCases))]
        [Category("Slow")]
        public int Add_Number_ReturnCorrectvalue(int a, int b)
        {
            return Calculator<int>.Add(a, b);
        }

        [TestCaseSource(typeof(AlternativeDataSource), nameof(AlternativeDataSource.SubtractTestCases))]
        public int Subtract_Number_ReturnCorrectvalue(int a, int b)
        {
            return Calculator<int>.Subtract(a, b);
        }

        [TestCaseSource(typeof(AlternativeDataSource), nameof(AlternativeDataSource.DivideTestCases))]
        public int Divide_Number_ReturnCorrectvalue(int a, int b)
        {
            return Calculator<int>.Divide(a, b);
        }

        [TestCaseSource(typeof(DataSoucre))]
        [Ignore("Just for Practice")]
        public void Multiply_Number_ReturnCorrectvalue(int a, int b, int expected)
        {
            int actual = Calculator<int>.Multiply(a, b);
            Assert.That(actual, Is.EqualTo(expected), string.Format("Actual{0} not Equal expected {1}", actual, expected));
        }

        [TearDown]
        public void TearDown()
        {
            Console.WriteLine("Ending test");
        }
    }
}