using System;

public class ExpressionEvaluator
{
    public static string Evaluate(string expression)
    {
        if (string.IsNullOrWhiteSpace(expression))
            return "Error:InvalidExpression";

        // Split by space (spaces are required)
        var parts = expression.Split(' ');

        // Must be exactly: a op b
        if (parts.Length != 3)
            return "Error:InvalidExpression";

        // Validate numbers
        if (!int.TryParse(parts[0], out int a) ||
            !int.TryParse(parts[2], out int b))
            return "Error:InvalidNumber";

        string op = parts[1];

        switch (op)
        {
            case "+":
                return (a + b).ToString();

            case "-":
                return (a - b).ToString();

            case "*":
                return (a * b).ToString();

            case "/":
                if (b == 0)
                    return "Error:DivideByZero";
                return (a / b).ToString();

            default:
                return "Error:UnknownOperator";
        }
    }

    public static void Main(string[] args)
    {
        // Read input expression
        string expression = Console.ReadLine();

        // Evaluate and print result
        string result = Evaluate(expression);
        Console.WriteLine(result);
    }
}
