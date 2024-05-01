using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Calculator.Services;

namespace CalculatorTests
{
    public class StringValidationTests
    {
        private StringValidation _validation;

        public StringValidationTests()
        {
            _validation = new StringValidation();
        }

        [Fact]
        public void ShouldCountCaracteresInHELLOAndReturn5()
        {
            string text = "Hello";
            
            int totalChars = _validation.CountChar(text);            

            Assert.Equal(5, totalChars);
        }
    }
}