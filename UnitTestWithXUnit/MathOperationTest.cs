using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xunit;
using XUnitTestDemo;

namespace UnitTestWithXUnit
{
    public class MathOperationTest
    {
        [Fact]
        public void Add_Two_Double_Number()
        {
            //Arrange
            var num1 = 2.9;
            var num2 = 4.4;
            var expectedValue = 7.3;

            //Act
            var sum = MathOperation.Add(num1, num2);

            //Assert
            Assert.Equal(expectedValue, sum, 1);
        }

        [Fact]
        public void Convert_String_To_Guid()
        {
            //arrange
            var idAsString = "118a32f1-7737-45c7-8ef9-84e7808436f5";
            var expectedValue = Guid.Parse(idAsString);

            //Act
            var guid = idAsString.ConvertStringToGuid();

            //Assert
            Assert.Equal(expectedValue, guid);
        }

        [Fact]
        public void TestMinimum()
        {
            //arrange
            int a = 6; int b = 7; int c = 8;
            var expectedValue = 6;
            //act
            var min = MathOperation.Minimum(a, b, c);

            //assert
            Assert.Equal(expectedValue,min);
        }
    }
}
