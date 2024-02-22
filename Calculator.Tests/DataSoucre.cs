using System.Collections;


namespace Calculator.Tests
{
    public class DataSoucre : IEnumerable
    {
        public IEnumerator GetEnumerator()
        {
            yield return new int[] { 1, 2, 2 };
            yield return new int[] { 3, 4, 12 };
        }
    }
}
