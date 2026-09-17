using System;
using System.Collections.Generic;
using System.Text;
using Xunit;

namespace UnitTestCaseProject
{
   
    public class CalculatorTest
    {
        [Fact]
        public void TestAdd()
        {
            Calculate calculator = new Calculate();
            int result = calculator.Add(2, 3);
            Assert.Equal(5, result);
        }

        [Fact]
        public void TestSubtract()
        {
            Calculate calculator = new Calculate();
            int result = calculator.Subtract(5, 3);
            Assert.Equal(2, result);                    
        }
        [Fact]  
        public void TestMultiplication()
        {
            Calculate calculator = new Calculate();
            int result = calculator.Multiplication(2, 3);
            Assert.Equal(6, result);

        }
        [Fact]
        public void TestDivide()
        {
            Calculate calculator = new Calculate();
            int result = calculator.Divide(6, 3);
            Assert.Equal(2, result);
        }
    }
}
