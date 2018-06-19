using System;

namespace CalculatorLib
{
  public class Calculator
  {
    public static int Calculate(int operand1, int operand2, Operation operation)
    {
      int result;
      switch (operation)
      {
        case Operation.Addition:
          result = Add(operand1, operand2);
          break;
        case Operation.Subtraction:
          result = Sub(operand1, operand2);
          break;
        case Operation.Multiplication:
          result = Mult(operand1, operand2);
          break;
        case Operation.Division:
          result = Div(operand1, operand2);
          break;
        default:
          throw new ArgumentOutOfRangeException(nameof(operation), operation, null);
      }

      return result;

    }

    public static int Div(int operand1, int operand2)
    {
      return operand1 / operand2;
    }

    public static int Mult(int operand1, int operand2)
    {
      return operand1 * operand2;
    }

    public static int Sub(int operand1, int operand2)
    {
      return operand1 - operand2;
    }

    public static int Add(int operand1, int operand2)
    {
      return operand1+operand2;
    }
  }
}