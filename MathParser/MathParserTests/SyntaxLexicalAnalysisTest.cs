using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using MathParser;

namespace MathParserTests
{
    [TestClass]
    public class SyntaxLexicalAnalysisTest
    {
        [TestMethod]
        public void SyntaxAnalysisInfixNotationTest1()
        {
            // Arrange
            var mathParser = new PrivateObject(typeof(RPNParser));
            var token = "$+";
            var input = new StringBuilder("#3#1");
            var stack = new Stack<string>();
            stack.Push("$-");
            var output = "#3#1$-";

            // Act
            var actual = (StringBuilder)mathParser.Invoke("SyntaxAnalysisInfixNotation", token, input, stack);

            // Assert
            Assert.AreEqual(output, actual.ToString());
            Assert.IsTrue(stack.Count == 1 && stack.Peek() == "$+");
        }

        [TestMethod]
        public void SyntaxAnalysisInfixNotationTest2()
        {
            // Arrange
            var mathParser = new PrivateObject(typeof(RPNParser));
            var token = "#1";
            var input = new StringBuilder("#3");
            var stack = new Stack<string>();
            var output = "#3#1";

            // Act
            var actual = (StringBuilder)mathParser.Invoke("SyntaxAnalysisInfixNotation", token, input, stack);

            // Assert
            Assert.AreEqual(output, actual.ToString());
        }

        [TestMethod]
        public void SyntaxAnalysisInfixNotationTest3()
        {
            // Arrange
            var mathParser = new PrivateObject(typeof(RPNParser));
            var token = "$*";
            var input = new StringBuilder("#3#1");
            var stack = new Stack<string>();
            stack.Push("$-");
            var output = "#3#1";

            // Act
            var actual = (StringBuilder)mathParser.Invoke("SyntaxAnalysisInfixNotation", token, input, stack);

            // Assert
            Assert.AreEqual(output, actual.ToString());
            Assert.IsTrue(stack.Count == 2 && stack.Peek() == "$*");
        }

        [TestMethod]
        public void SyntaxAnalysisInfixNotationTest4()
        {
            // Arrange
            var mathParser = new PrivateObject(typeof(RPNParser));
            var token = "$)";
            var input = new StringBuilder("#3#1#4#5");
            var stack = new Stack<string>();
            stack.Push("$(");
            stack.Push("$-");
            stack.Push("$+");
            stack.Push("$*");
            var output = "#3#1#4#5$*$+$-";

            // Act
            var actual = (StringBuilder)mathParser.Invoke("SyntaxAnalysisInfixNotation", token, input, stack);

            // Assert
            Assert.AreEqual(output, actual.ToString());
            Assert.IsTrue(stack.Count == 0);
        }

        [TestMethod]
        public void SyntaxAnalysisInfixNotationTest5()
        {
            // Arrange
            var mathParser = new PrivateObject(typeof(RPNParser));
            var token = "$)";
            var input = new StringBuilder("#3#1#4#5");
            var stack = new Stack<string>();
            stack.Push("@sqrt");
            stack.Push("$(");
            stack.Push("$-");
            stack.Push("$+");
            stack.Push("$*");
            var output = "#3#1#4#5$*$+$-@sqrt";

            // Act
            var actual = (StringBuilder)mathParser.Invoke("SyntaxAnalysisInfixNotation", token, input, stack);

            // Assert
            Assert.AreEqual(output, actual.ToString());
            Assert.IsTrue(stack.Count == 0);
        }

        [TestMethod]
        public void SyntaxAnalysisInfixNotationTest6()
        {
            // Arrange
            var mathParser = new PrivateObject(typeof(RPNParser));
            var token = "@sqrt";
            var input = new StringBuilder("#3#1");
            var stack = new Stack<string>();
            stack.Push("$-");
            var output = "#3#1";

            // Act
            var actual = (StringBuilder)mathParser.Invoke("SyntaxAnalysisInfixNotation", token, input, stack);

            // Assert
            Assert.AreEqual(output, actual.ToString());
            Assert.IsTrue(stack.Count == 2 && stack.Peek() == "@sqrt");
        }

        //Test LexicalAnalysisRPN

        [TestMethod]
        public void LexicalAnalysisRPNTest1()
        {
            // Arrange
            var mathParser = new PrivateObject(typeof(RPNParser));
            var input = "#2#2$+";
            var pos = 0;
            var output = "#2";

            // Act
            var actual = (string)mathParser.Invoke("LexicalAnalysisRPN", input, pos);

            // Assert
            Assert.AreEqual(output, actual);
        }

        [TestMethod]
        public void LexicalAnalysisRPNTest2()
        {
            // Arrange
            var mathParser = new PrivateObject(typeof(RPNParser));
            var input = "#2#2$+";
            var pos = 4;
            var output = "$+";

            // Act
            var actual = (string)mathParser.Invoke("LexicalAnalysisRPN", input, pos);

            // Assert
            Assert.AreEqual(output, actual);
        }

        [TestMethod]
        public void LexicalAnalysisRPNTest3()
        {
            // Arrange
            var mathParser = new PrivateObject(typeof(RPNParser));
            var input = "#2#2$+@sqrt";
            var pos = 6;
            var output = "@sqrt";

            // Act
            var actual = (string)mathParser.Invoke("LexicalAnalysisRPN", input, pos);

            // Assert
            Assert.AreEqual(output, actual);
        }

        //Test SyntaxAnalysisRPN method

        [TestMethod]
        public void SyntaxAnalysisRPNTest1()
        {
            // Arrange
            var mathParser = new PrivateObject(typeof(RPNParser));
            var stack = new Stack<double>();
            stack.Push(2);
            stack.Push(2);
            var token = "$+";
            var output = 4d;

            // Act
            var actual = (Stack<double>)mathParser.Invoke("SyntaxAnalysisRPN", stack, token);

            // Assert
            Assert.IsTrue(actual.Count == 1);
            Assert.AreEqual(output, actual.Peek());
        }

        [TestMethod]
        public void SyntaxAnalysisRPNTest2()
        {
            // Arrange
            var mathParser = new PrivateObject(typeof(RPNParser));
            var stack = new Stack<double>();
            stack.Push(2);
            stack.Push(2);
            var token = "$un-";
            var output = -2;

            // Act
            var actual = (Stack<double>)mathParser.Invoke("SyntaxAnalysisRPN", stack, token);

            // Assert
            Assert.IsTrue(actual.Count == 2);
            Assert.AreEqual(output, actual.Peek());
        }

        [TestMethod]
        public void SyntaxAnalysisRPNTest3()
        {
            // Arrange
            var mathParser = new PrivateObject(typeof(RPNParser));
            var stack = new Stack<double>();
            stack.Push(2);
            stack.Push(2);
            var token = "#4";
            var output = 4;

            // Act
            var actual = (Stack<double>)mathParser.Invoke("SyntaxAnalysisRPN", stack, token);

            // Assert
            Assert.IsTrue(actual.Count == 3);
            Assert.AreEqual(output, actual.Peek());
        }
    }
}
