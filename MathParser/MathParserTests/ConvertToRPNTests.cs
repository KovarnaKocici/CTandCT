using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using MathParser;

namespace MathParserTests
{
    [TestClass]
    public class ConvertToRPNTest
    {
        [TestMethod]
        public void ConvertToRPNTest1()
        {
            // Arrange
            var mathParser = new PrivateObject(typeof(RPNParser));
            var input = "2+2";
            var output = "#2#2$+";

            // Act
            var actual = (string)mathParser.Invoke("ConvertToRPN", input);

            // Assert
            Assert.AreEqual(output, actual);
        }

        [TestMethod]
        public void ConvertToRPNTest2()
        {
            // Arrange
            var mathParser = new PrivateObject(typeof(RPNParser));
            var input = "-5*(+5)+5*(-3)-2^2^3/4";
            var output = "#5$un-#5$un+$*#5#3$un-$*$+#2#2#3$^$^#4$/$-";

            // Act
            var actual = (string)mathParser.Invoke("ConvertToRPN", input);

            // Assert
            Assert.AreEqual(output, actual);
        }
    }
}
