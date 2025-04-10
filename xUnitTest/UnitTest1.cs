using Lommeregner;
using Xunit;

namespace xUnitTest
{
    public class UnitTest1
    {
        private readonly ICalculator _calculator;

        public UnitTest1()
        {
            _calculator = new Calculator();
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

        [Fact]
        public void Power_ReturnsCorrectPositive()
        {
            // Arrange
            double a = 3;
            double b = 4;

            //Act
            double result = _calculator.Power(a, b);

            //Assert
            Assert.Equal(81, result);


        }

        [Fact]
        public void Power_ReturnsCorrectNegativeExponent()
        {
            // Arrange
            double a = 3;
            double b = -2;

            // Act
            double result = _calculator.Power(a, b);

            // Assert
            Assert.Equal(1.0 / 9.0, result);
        }

        [Fact]
        public void SquareRoot_ReturnsCorrectValue()
        {
            // Arrange
            double a = 16;

            // Act
            double result = _calculator.SquareRoot(a);

            // Assert
            Assert.Equal(4, result);
        }

        [Fact]
        public void SquareRoot_ThrowsException_WhenInputIsNegative()
        {
            // Arrange
            double a = -9;

            // Act & Assert
            Assert.Throws<ArgumentException>(() => _calculator.SquareRoot(a));
        }
    }

}
