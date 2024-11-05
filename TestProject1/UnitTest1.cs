using Labtest1Pav;
namespace TestProject1
{
    [Parallelizable(ParallelScope.Self)]
    [TestFixture]
    public class Tests : PageTest
    {
        [Test]
        public void BuildLowerTriangularMatrix_ValidInput_ReturnsCorrectMatrix()
        {
            // Arrange
            int[] input = new int[15] { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13, 14, 15 };
            int rows = 4;
            int[,] expected = new int[4, 4]
            {
            { 1, 0, 0, 0 },
            { 2, 3, 0, 0 },
            { 4, 5, 6, 0 },
            { 7, 8, 9, 10 }
            };

            // Act
            int[,] result = Class1.BuildLowerTriangularMatrix(input, rows);

            // Assert
            Assert.AreEqual(expected, result);
        }

        [Test]
        public void BuildLowerTriangularMatrix_InsufficientElements_FillsWithZeros()
        {
            // Arrange
            int[] input = new int[10] { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
            int rows = 5;
            int[,] expected = new int[5, 5]
            {
            { 1, 0, 0, 0, 0 },
            { 2, 3, 0, 0, 0 },
            { 4, 5, 6, 0, 0 },
            { 7, 8, 9, 10, 0 },
            { 0, 0, 0, 0, 0 }
            };

            // Act
            int[,] result = Class1.BuildLowerTriangularMatrix(input, rows);

            // Assert
            Assert.AreEqual(expected, result);
        }
    }
}