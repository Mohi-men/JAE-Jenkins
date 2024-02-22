using System;
using System.Collections;

namespace Calculator.Tests
{
    public class AlternativeDataSource
    {
        public static IEnumerable<TestCaseData> AddTestCases
        {
            get
            {
                yield return new TestCaseData(1, 2).Returns(3);
                yield return new TestCaseData(55, 2).Returns(57);
                yield return new TestCaseData(6, 2).Returns(8);
            }
        }

        public static IEnumerable<TestCaseData> SubtractTestCases
        {
            get
            {
                yield return new TestCaseData(1, 2).Returns(-1);
                yield return new TestCaseData(55, 2).Returns(53);
                yield return new TestCaseData(6, 2).Returns(4);
            }
        }

        public static IEnumerable<TestCaseData> DivideTestCases
        {
            get
            {
                yield return new TestCaseData(3, 2).Returns(1);
                yield return new TestCaseData(50, 2).Returns(25);
                yield return new TestCaseData(6, 2).Returns(3);
            }
        }

        public static IEnumerable<TestCaseData> MultiplyTestCases
        {
            get
            {
                yield return new TestCaseData(1, 2).Returns(2);
                yield return new TestCaseData(55, 2).Returns(110);
                yield return new TestCaseData(6, 0).Returns(0);
            }
        }
    }
}
