using System;
using Xunit;

namespace Ramona_New_Proyect
{
    public class StringCalculatorTest
    {
        [Fact]
        public void Can_Add_EmpyString()
        {
            //Arrange
            var calculator = new StringCalculator();
            //Act
            int result = calculator.Add("");

            //Assert
            Assert.Equal(0, result);


        }

        [Fact]
        public void Can_Add_SingleString()

        {
            //Arrange
            var calculator = new StringCalculator();

            //Act
            int result = calculator.Add("5");

            //Assert
            Assert.Equal(5, result);


        }

        [Fact]
        public void Can_Add_twoString()

        {
            //Arrange
            var calculator = new StringCalculator();

            //Act
            int result = calculator.Add("5,4");

            //Assert
            Assert.Equal(9, result);


        }

        [Fact]
        public void Can_Add_unknowString()

        {
            //Arrange
            var calculator = new StringCalculator();

            //Act
            int result = calculator.Add("60");

            //Assert
            Assert.Equal(60, result);


        }

        [Fact]
        public void Can_Add_newlinesString()

        {
            //Arrange
            var calculator = new StringCalculator();

            //Act
            int result = calculator.Add("1\n2,3");

            //Assert
            Assert.Equal(6, result);


        }
        [Fact]
        public void Can_Add_diferent_delimitersString()

        {
            //Arrange
            var calculator = new StringCalculator();

            //Act
            int result = calculator.Add("//;\n1;2");
            // ;;;1;2
            // []
            //Assert
            Assert.Equal(3, result);


        }

        [Fact]
        public void Cant_Add_negativeString()

        {
            //Arrange
            var calculator = new StringCalculator();

            //Act

            //Assert
            //  Assert.Equal(3, result);
            var exception = Assert.Throws<InvalidOperationException>(
                () => calculator.Add("-1")
            );
            //The thrown exception can be used for even more detailed assertions.
            Assert.Equal("negative not allowed: -1", exception.Message);
        }

        [Fact]
        public void Cant_Add_MultipleNegativeString()

        {
            //Arrange
            var calculator = new StringCalculator();

            //Act

            //Assert
            //  Assert.Equal(3, result);
            var exception = Assert.Throws<InvalidOperationException>(
                () => calculator.Add("-1, -2")
            );
            //The thrown exception can be used for even more detailed assertions.
            Assert.Equal("negative not allowed: -1,-2", exception.Message);
        }
    }
}
