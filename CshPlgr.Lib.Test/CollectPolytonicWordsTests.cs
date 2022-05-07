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
        public void TestMethod(string argument, List<string> expected)
        {
            var actual = CollectPolytonicWords(argument);
            Assert.Equal(expected, actual);
        }
        class TestData : IEnumerable<object[]>
        {
            public IEnumerator<object[]> GetEnumerator()
            {
                yield return new object[] { "", new List<string>() };
                yield return new object[] { "α β γ", new List<string>() { "α", "β", "γ" } };
                yield return new object[] { "Α Β Γ", new List<string>() { "Α", "Β", "Γ" } };
            }
            IEnumerator IEnumerable.GetEnumerator() => GetEnumerator();
        }
    }
}