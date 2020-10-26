using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MathParser
{
    public class Parser
    {

        //Markers
        protected const string NumberMaker = "#";
        protected const string OperatorMarker = "$";
        protected const string FunctionMarker = "@";

        //Internal tokens
        protected const string Plus = OperatorMarker + "+";
        protected const string UnPlus = OperatorMarker + "un+";
        protected const string Minus = OperatorMarker + "-";
        protected const string UnMinus = OperatorMarker + "un-";
        protected const string Multiply = OperatorMarker + "*";
        protected const string Divide = OperatorMarker + "/";
        protected const string Degree = OperatorMarker + "^";
        protected const string LeftParent = OperatorMarker + "(";
        protected const string RightParent = OperatorMarker + ")";
        protected const string Sqrt = FunctionMarker + "sqrt";
        protected const string Sin = FunctionMarker + "sin";
        protected const string Cos = FunctionMarker + "cos";
        protected const string Tg = FunctionMarker + "tg";
        protected const string Ctg = FunctionMarker + "ctg";
        protected const string Log = FunctionMarker + "log";
        protected const string Ln = FunctionMarker + "ln";
        protected const string Exp = FunctionMarker + "exp";
        protected const string Abs = FunctionMarker + "abs";

        //Supported operators
        protected readonly Dictionary<string, string> supportedOperators =
            new Dictionary<string, string>
            {
                { "+", Plus },
                { "-", Minus },
                { "*", Multiply },
                { "/", Divide },
                { "^", Degree },
                { "(", LeftParent },
                { ")", RightParent }
            };

        //Supported functions
        protected readonly Dictionary<string, string> supportedFunctions =
            new Dictionary<string, string>
             {
                { "sqrt", Sqrt },
                { "√", Sqrt },
                { "sin", Sin },
                { "cos", Cos },
                { "tg", Tg },
                { "ctg", Ctg },
                { "log", Log },
                { "exp", Exp },
                { "abs", Abs }
            };

        //Supported constans
        protected readonly Dictionary<string, string> supportedConstants =
        new Dictionary<string, string>
        {
                {"pi", NumberMaker +  Math.PI.ToString() },
                {"e", NumberMaker + Math.E.ToString() },
                {"x", NumberMaker + "x" }
        };

        protected char decimalSeparator ='.';

        public Parser(){}

        public virtual string FormatString(string expression)
        {
            if (string.IsNullOrEmpty(expression))
            {
                throw new ArgumentNullException("Expression is null or empty");
            }

            StringBuilder formattedString = new StringBuilder();
            int balanceOfParenth = 0; // Check number of parenthesis

            // Format string in one iteration and check number of parenthesis
            // (this function do 2 tasks because performance priority)
            for (int i = 0; i < expression.Length; i++)
            {
                char ch = expression[i];

                if (ch == '(')
                {
                    balanceOfParenth++;
                }
                else if (ch == ')')
                {
                    balanceOfParenth--;
                }

                if (Char.IsWhiteSpace(ch))
                {
                    continue;
                }
                else if (Char.IsUpper(ch))
                {
                    formattedString.Append(Char.ToLower(ch));
                }
                else
                {
                    formattedString.Append(ch);
                }
            }

            if (balanceOfParenth != 0)
            {
                throw new FormatException("Number of left and right parenthesis is not equal");
            }

            return formattedString.ToString();
        }

        public virtual double Calculate(string expression)
        {
           return 0;
        }

        public double Parse(string expression)
        {
            try
            {
                return Calculate(FormatString(expression));
            }
            catch (DivideByZeroException e)
            {
                throw e;
            }
            catch (FormatException e)
            {
                throw e;
            }
            catch (InvalidOperationException e)
            {
                throw e;
            }
            catch (ArgumentOutOfRangeException e)
            {
                throw e;
            }
            catch (ArgumentException e)
            {
                throw e;
            }
            catch (Exception e)
            {
                throw e;
            }

        }

        protected int GetPriority(string token)
        {
            switch (token)
            {
                case LeftParent:
                    return 0;
                case Plus:
                case Minus:
                    return 2;
                case UnPlus:
                case UnMinus:
                    return 6;
                case Multiply:
                case Divide:
                    return 4;
                case Degree:
                case Sqrt:
                    return 8;
                case Sin:
                case Cos:
                case Tg:
                case Ctg:
                case Log:
                case Ln:
                case Exp:
                case Abs:
                    return 10;
                default:
                    throw new ArgumentException("Unknown operator " + token);
            }
        }

        protected int NumberOfArguments(string token)
        {
            switch (token)
            {
                case UnPlus:
                case UnMinus:
                case Sqrt:
                case Tg:
                case Ln:
                case Ctg:
                case Sin:
                case Cos:
                case Exp:
                case Abs:
                    return 1;
                case Plus:
                case Minus:
                case Multiply:
                case Divide:
                case Degree:
                case Log:
                    return 2;
                default:
                    throw new ArgumentException("Unknown operator " + token);
            }
        }
    }
}
