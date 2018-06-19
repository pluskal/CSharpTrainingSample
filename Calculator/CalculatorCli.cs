using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CalculatorLib;
using CommandLine;

namespace Calculator
{
  class CalculatorCli
  {
    static void Main(string[] args)
    {
      CommandLine.Parser.Default.ParseArguments<Options>(args)
        .WithParsed<Options>(RunOptionsAndReturnExitCode);
    }

    private static void RunOptionsAndReturnExitCode(Options options)
    {
      var operand1 = options.Operand1;
      var operand2 = options.Operand2;
      var operation = options.Operation;

      var result = CalculatorLib.Calculator.Calculate(operand1, operand2, operation);

      PrintEquation(operand1, operand2, operation, result);
    }

    private static void PrintEquation(int operand1, int operand2, Operation operation, int result)
    {
      Console.WriteLine($"{operation}({operand1},{operand2})={result}");
    }
  }
}
