using CalculatorLib;
using CommandLine;

namespace Calculator
{
  class Options
  {
    [Option('f', "first", Required = true, HelpText = "Operand 1.")]
    public int Operand1 { get; set; }

    [Option('s', "second", Required = true, HelpText = "Operand 2.")]
    public int Operand2 { get; set; }

    [Option('o', "operation", Required = true, HelpText = "Operation.")]
    public Operation Operation { get; set; }
  }
}