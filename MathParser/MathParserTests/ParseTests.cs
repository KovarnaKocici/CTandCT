
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using MathParser;

namespace MathParserTests
{
    class ParseTest
    {
        [TestMethod]
        public void ParseTest1()
        {
            // Arrange
            var mathParser = new RPNParser();
            var input = "2-2";
            var output = 0d;

            // Act
            var actual = mathParser.Parse(input);

            // Assert
            Assert.AreEqual(output, actual);
        }

        [TestMethod]
        public void ParseTest2()
        {
            // Arrange
            var mathParser = new RPNParser();
            var input = "2.5+2";
            var output = 4.5d;

            // Act
            var actual = mathParser.Parse(input);

            // Assert
            Assert.AreEqual(output, actual);
        }

        [TestMethod]
        public void ParseTest3()
        {
            // Arrange
            var mathParser = new RPNParser();
            var input = "2.0*3.0";
            var output = 6d;

            // Act
            var actual = mathParser.Parse(input);

            // Assert
            Assert.AreEqual(output, actual);
        }

        [TestMethod]
        public void ParseTest4()
        {
            // Arrange
            var mathParser = new RPNParser();
            var input = "10/2.5";
            var output = 4d;

            // Act
            var actual = mathParser.Parse(input);

            // Assert
            Assert.AreEqual(output, actual);
        }

        [TestMethod]
        public void ParseTest5()
        {
            // Arrange
            var mathParser = new RPNParser();
            var input = "2*(3+4)";
            var output = 14d;

            // Act
            var actual = mathParser.Parse(input);

            // Assert
            Assert.AreEqual(output, actual);
        }

        [TestMethod]
        public void ParseTest6()
        {
            // Arrange
            var mathParser = new RPNParser();
            var input = "2^2+4";
            var output = 8d;

            // Act
            var actual = mathParser.Parse(input);

            // Assert
            Assert.AreEqual(output, actual);
        }

        [TestMethod]
        public void ParseTest7()
        {
            // Arrange
            var mathParser = new RPNParser();
            var input = "5*5+5*3-5*5-5*3";
            var output = 0d;

            // Act
            var actual = mathParser.Parse(input);

            // Assert
            Assert.AreEqual(output, actual);
        }

        [TestMethod]
        public void ParseTest8()
        {
            // Arrange
            var mathParser = new RPNParser();
            var input = "-5*(+5)+5*(-3)-5*(+5)-5*(-3)";
            var output = -50d;

            // Act
            var actual = mathParser.Parse(input);

            // Assert
            Assert.AreEqual(output, actual);
        }

        [TestMethod]
        public void ParseTest9()
        {
            // Arrange
            var mathParser = new RPNParser();
            var input = "-(-1)";
            var output = 1d;

            // Act
            var actual = mathParser.Parse(input);

            // Assert
            Assert.AreEqual(output, actual);
        }

        [TestMethod]
        public void ParseTest10()
        {
            // Arrange
            var mathParser = new RPNParser();
            var input = "-1^2";
            var output = -1d;

            // Act
            var actual = mathParser.Parse(input);

            // Assert
            Assert.AreEqual(output, actual);
        }

        [TestMethod]
        public void ParseTest11()
        {
            // Arrange
            var mathParser = new RPNParser();
            var input = "(-1)^2";
            var output = 1d;

            // Act
            var actual = mathParser.Parse(input);

            // Assert
            Assert.AreEqual(output, actual);
        }

        [TestMethod]
        public void ParseTest12()
        {
            // Arrange
            var mathParser = new RPNParser();
            var input = "pi*1+e*2+.95";
            var output = 9.5281563105078888d;

            // Act
            var actual = mathParser.Parse(input);

            // Assert
            Assert.AreEqual(output, actual);
        }

        [TestMethod]
        public void ParseTest14()
        {
            // Arrange
            var mathParser = new RPNParser();
            var input = "ctg(tg(cos(sin(100))))";
            var output = 0.39311779109637159D;

            // Act
            var actual = mathParser.Parse(input);

            // Assert
            Assert.AreEqual(output, actual);
        }

        [TestMethod]
        public void ParseTest15()
        {
            // Arrange
            var mathParser = new RPNParser();
            var input = "abs(-2)+exp(1)+(2)Log(4)+√(4)";
            var output = 2 + Math.E + 2 + 2;

            // Act
            var actual = mathParser.Parse(input);

            // Assert
            Assert.AreEqual(output, actual);
        }

        [TestMethod]
        public void ParseTest16()
        {
            // Arrange
            var mathParser = new RPNParser();
            var input = "-1*(-(+(5*(+5)+5*(+3)-5*(+5)-5*(-3))))";
            var output = 30D;

            // Act
            var actual = mathParser.Parse(input);

            // Assert
            Assert.AreEqual(output, actual);
        }
    }
}
