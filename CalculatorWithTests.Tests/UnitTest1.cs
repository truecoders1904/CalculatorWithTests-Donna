using System;
using Xunit;

namespace CalculatorWithTests.Tests
{
    public class UnitTest1
    {
        [Theory]
        [InlineData(100, 200, 300)]
        [InlineData(0, 0, 0)]
        [InlineData(-5, 5, 0)]

        public void ShouldAddData(double num1, double num2, double expected)
        {
            //Arrange
            Calculator calculator = new Calculator();

            //Act
            double acutal = calculator.GetSum(num1, num2);

            //Assert
            Assert.Equal(expected, acutal);

        }

        [Theory]
        [InlineData(100, 20, 80)]
        [InlineData(10, 6, 4)]
        [InlineData(0, 0, 0)]

        public void ShouldSubtractData(double num1, double num2, double expected)
        {
            //Arrnge
            Calculator calculator = new Calculator();

            //Act
            double acutal = calculator.GetDifference(num1, num2);

            //Assert
            Assert.Equal(expected, acutal);

        }


        [Theory]
        [InlineData(5, 5, 25)]
        [InlineData(-4, -3, 12)]
        [InlineData(3, -8, -24)]
        [InlineData(0, 0, 0)]

        public void ShouldMultiplyData(double num1, double num2, double expected)
        {
            //Arrange
            Calculator calculator = new Calculator();

            //Act
            double actual = calculator.GetProduct(num1, num2);

            //Assert
            Assert.Equal(expected, actual);
        }

        [Theory]
        [InlineData(5, 5, 1)]
        [InlineData(-15, 3, 5)]
        [InlineData(15, -3, -5)]
        [InlineData(0, 2, 0)]
        [InlineData(14, 0, 0)]
        public void ShouldDivideData(double num1, double num2, double expected)
        {
            //Arrangeooooo
            Calculator calculator = new Calculator();

            //Act
            double actual = calculator.GetQuotient(num1, num2);

            //Assert
            Assert.Equal(expected, actual);


        }
        [Theory]
        [InlineData(6, 720)]
        [InlineData(5, 120)]
        [InlineData(1, 1)]
        [InlineData(0, 1)]


        public void ShouldFactorialData(double num1, double expected)
        {
            //Arrange
            Calculator calculator = new Calculator();

            //Act
            double actual = calculator.GetFactorial(num1);

            //Assert
            Assert.Equal(expected, actual);
        }
    }
}
