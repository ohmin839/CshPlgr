using System.Collections;
using System.Collections.Generic;
using Xunit;
using static CshPlgr.Lib.API;

namespace CshPlgr.Lib.Test
{
    public class CollectPolytonicWordsTests
    {
        [Theory]
        [ClassData(typeof(CollectPolytonicWordsTests.TestData))]
        public void TestMethod(string argument, SortedSet<string> expected)
        {
            var actual = CollectPolytonicWords(argument);
            Assert.Equal(expected, actual);
        }
        class TestData : IEnumerable<object[]>
        {
            public IEnumerator<object[]> GetEnumerator()
            {
                yield return new object[] { "", new SortedSet<string>() };
                yield return new object[] { "α β γ α", new SortedSet<string>() { "α", "β", "γ" } };
                yield return new object[] { "Α Β Γ Α", new SortedSet<string>() { "Α", "Β", "Γ" } };
            }
            IEnumerator IEnumerable.GetEnumerator() => GetEnumerator();
        }
    }
}