using Lessons.Iterations;
using Xunit;

namespace Lessons.Tests.Lessons.Iterations
{
    public class SolutionTest
    {
        [Theory]
        [InlineData(3, 6)]
        [InlineData(5, 120)]
        [InlineData(7, 5040)]
        public void RunTest(int number, int expected)
        {
            // Arrange
            Solution solution = new Solution();

            // Act
            int result = solution.Run(number);

            // Assert
            Assert.Equal(expected, result);
        }
    }
}
