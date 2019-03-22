using NUnit.Framework;
using Problems.DynamicProgramming;

namespace Problems.Tests
{
    public class UniquePathsProblemTests
    {
        [Test]
        public void UniquePathsTest1()
        {
            var result = UniquePathsProblem.UniquePaths(3, 2);
            Assert.AreEqual(result, 3);
        }

        [Test]
        public void UniquePathsTest2()
        {
            var result = UniquePathsProblem.UniquePaths(7, 3);
            Assert.AreEqual(result, 28);
        }

        [Test]
        public void UniquePathsWithObstaclesTest1()
        {
            var result = UniquePathsProblem.UniquePathsWithObstacles(new[,] {{0}});
            Assert.AreEqual(result, 1);
        }

        [Test]
        public void UniquePathsWithObstaclesTest2()
        {
            var result = UniquePathsProblem.UniquePathsWithObstacles(new[,] {{1, 0}});
            Assert.AreEqual(result, 0);
        }
    }
}