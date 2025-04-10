using Lommeregner;
using Xunit;

namespace xUnitTest
{
    public class UnitTest1
    {
        private readonly ICalculator _calculator;

        public UnitTest1()
        {
            //_calculator = new Calculator();
        }

        [Fact]
        public void Add_ReturnsCorrectSum()
        {
            // Arrange
            int a = 5;
            int b = 3;

            // Act
            int result = _calculator.Add(a, b);

            // Assert
            Assert.Equal(8, result);
        }

        [Fact]
        public void Subtract_ReturnsCorrectDifference()
        {
            // Arrange
            int a = 10;
            int b = 4;

            // Act
            int result = _calculator.Subtract(a, b);

            // Assert
            Assert.Equal(6, result);
        }

        [Fact]
        public void Multiply_ReturnsCorrectProduct()
        {
            // Arrange
            int a = 6;
            int b = 7;

            // Act
            int result = _calculator.Multiply(a, b);

            // Assert
            Assert.Equal(42, result);
        }

        [Fact]
        public void Divide_ReturnsCorrectQuotient()
        {
            // Arrange
            int a = 10;
            int b = 2;

            // Act
            double result = _calculator.Divide(a, b);

            // Assert
            Assert.Equal(5.0, result);
        }

        [Fact]
        public void Divide_ThrowsException_WhenDenominatorIsZero()
        {
            // Arrange
            int a = 10;
            int b = 0;

            // Act & Assert
            Assert.Throws<DivideByZeroException>(() => _calculator.Divide(a, b));
        }
    }

}
