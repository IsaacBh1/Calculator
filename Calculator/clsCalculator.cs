using System;
using System.Globalization;

namespace Calculator
{
    internal class clsCalculator
    {

    

        public static bool useDegrees = true;

        public static string CalculateResult(string input)
        {
            try
            {
                double result = Evaluate(input);
                return result.ToString(); 
            }
            catch (Exception ex)
            {
                return "Error" ; 
            }

        }

        /*   if (input.ToLower() == "deg")
           {
               useDegrees = true;
               Console.WriteLine("Switched to Degrees mode.");
           }
           else if (input.ToLower() == "rad")
           {
               useDegrees = false;
               Console.WriteLine("Switched to Radians mode.");
           }
           else if (input.ToLower() == "exit")
           {

           }*/






        static double Evaluate(string expression)
        {
            try
            {
                var parser = new ExpressionParser(expression.ToLower()); // Convert the expression to lowercase here
                return parser.Parse();
            }
            catch (DivideByZeroException)
            {
                throw new InvalidOperationException("Division by zero is not allowed.");
            }
            catch (Exception ex)
            {
                throw new InvalidOperationException("Invalid expression: " + ex.Message);
            }
        }

        class ExpressionParser
        {
            private readonly string _expression;
            private int _index;

            public ExpressionParser(string expression)
            {
                _expression = expression;
                _index = 0;
            }

            public double Parse()
            {
                double value = ParseExpression();
                SkipWhiteSpace();
                if (_index < _expression.Length)
                {
                    throw new Exception("Unexpected characters at end of expression.");
                }
                return value;
            }

            private double ParseExpression()
            {
                double value = ParseTerm();
                while (true)
                {
                    SkipWhiteSpace();
                    if (_index < _expression.Length && (_expression[_index] == '+' || _expression[_index] == '-'))
                    {
                        char op = _expression[_index++];
                        double term = ParseTerm();
                        if (op == '+')
                        {
                            value += term;
                        }
                        else
                        {
                            value -= term;
                        }
                    }
                    else
                    {
                        break;
                    }
                }
                return value;
            }

            private double ParseTerm()
            {
                double value = ParseFactor();
                while (true)
                {
                    SkipWhiteSpace();
                    if (_index < _expression.Length && (_expression[_index] == '*' || _expression[_index] == '/' || _expression[_index] == '^'))
                    {
                        char op = _expression[_index++];
                        double factor = ParseFactor();
                        if (op == '*')
                        {
                            value *= factor;
                        }
                        else if (op == '/')
                        {
                            value /= factor;
                        }
                        else if (op == '^')
                        {
                            value = Math.Pow(value, factor);
                        }
                    }
                    else
                    {
                        break;
                    }
                }
                return value;
            }

            private double ParseFactor()
            {
                SkipWhiteSpace();
                if (_index < _expression.Length && _expression[_index] == '(')
                {
                    _index++;
                    double value = ParseExpression();
                    SkipWhiteSpace();
                    if (_index == _expression.Length || _expression[_index] != ')')
                    {
                        throw new Exception("Missing closing parenthesis.");
                    }
                    _index++;
                    return value;
                }
                return ParseUnary();
            }

            private double ParseUnary()
            {
                SkipWhiteSpace();
                if (_index < _expression.Length && (_expression[_index] == '+' || _expression[_index] == '-'))
                {
                    char op = _expression[_index++];
                    double factor = ParseUnary();
                    if (op == '-')
                    {
                        return -factor;
                    }
                    return factor;
                }
                return ParseNumberOrFunctionOrConstant();
            }

            private double ParseNumberOrFunctionOrConstant()
            {
                SkipWhiteSpace();
                if (_index < _expression.Length && (char.IsDigit(_expression[_index]) || _expression[_index] == '.'))
                {
                    return ParseNumber();
                }
                else
                {
                    return ParseFunctionOrConstant();
                }
            }

            private double ParseNumber()
            {
                SkipWhiteSpace();
                int start = _index;
                while (_index < _expression.Length && (char.IsDigit(_expression[_index]) || _expression[_index] == '.'))
                {
                    _index++;
                }
                if (start == _index)
                {
                    throw new Exception("Expected number.");
                }
                double number = double.Parse(_expression.Substring(start, _index - start), CultureInfo.InvariantCulture);
                SkipWhiteSpace();
                if (_index < _expression.Length && _expression[_index] == '%')
                {
                    _index++;
                    number /= 100;
                }
                return number;
            }

            private double ParseFunctionOrConstant()
            {
                SkipWhiteSpace();
                int start = _index;
                while (_index < _expression.Length && char.IsLetter(_expression[_index]))
                {
                    _index++;
                }
                string name = _expression.Substring(start, _index - start).ToLower();

                if (name == "pi")
                {
                    return Math.PI;
                }
                if (name == "e")
                {
                    return Math.E;
                }

                SkipWhiteSpace();
                if (_index == _expression.Length || _expression[_index] != '(')
                {
                    throw new Exception("Expected opening parenthesis after function name.");
                }
                _index++;
                double arg = ParseExpression();
                SkipWhiteSpace();
                if (_index == _expression.Length || _expression[_index] != ')')
                {
                    throw new Exception("Expected closing parenthesis after function argument.");
                }
                _index++;

                switch (name)
                {
                    case "sqrt":
                        return Math.Sqrt(arg);
                    case "sin":
                        return useDegrees ? Math.Sin(arg * Math.PI / 180) : Math.Sin(arg);
                    case "cos":
                        return useDegrees ? Math.Cos(arg * Math.PI / 180) : Math.Cos(arg);
                    case "tan":
                        return useDegrees ? Math.Tan(arg * Math.PI / 180) : Math.Tan(arg);
                    case "log":
                        return Math.Log(arg);
                    case "log10":
                        return Math.Log10(arg);
                    case "exp":
                        return Math.Exp(arg);
                    case "abs":
                        return Math.Abs(arg);
                    default:
                        throw new Exception("Unknown function: " + name);
                }
            }

            private void SkipWhiteSpace()
            {
                while (_index < _expression.Length && char.IsWhiteSpace(_expression[_index]))
                {
                    _index++;
                }
            }
        }
    }
}

