using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

using Xunit;
using Amazon.Lambda.Core;
using Amazon.Lambda.TestUtilities;

using UnitTests;

namespace UnitTests.Tests
{
    public class FunctionTest
    {
        [Theory]
        [InlineData("pop","POP")]
        [InlineData("hello world","HELLO WORLD")]
        public void TestToUpperFunction(string input, string output)
        {

            // Invoke the lambda function and confirm the string was upper cased.
            var function = new Function();
            var context = new TestLambdaContext();
            var upperCase = function.FunctionHandler(input, context);

            Assert.Equal(output, upperCase);
        }
    }
}
