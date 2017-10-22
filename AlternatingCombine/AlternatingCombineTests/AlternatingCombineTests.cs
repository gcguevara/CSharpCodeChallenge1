using NUnit.Framework;
using System.Collections.Generic;
using AlternatingCombine;

namespace AlternatingCombineTests
{
    [TestFixture]
    public class AlternatingCombineTests
    {
        [Test]
        public void AlternatingCombineTest()
        {
            var alternateCombiner = new AlternateCombiner();
            var result = alternateCombiner.AlternateCombine(new List<string>() { "a", "b", "c" }, new List<string>() { "1", "2", "3" });
            Assert.IsTrue(result.Count == 6);
            Assert.IsTrue(result[0] == "a" &&
                          result[1] == "1" &&
                          result[2] == "b" &&
                          result[3] == "2" &&
                          result[4] == "c" &&
                          result[5] == "3");
        }
    }
}
