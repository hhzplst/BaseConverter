using System;

namespace BaseConverter {
  public class BaseConverterTest {
    public static void Main (string[] args) {
      BaseConverter testConverter = new BaseConverter();
      Console.WriteLine("Welcome to testConverter!");
      testConverter.ShowSettings();
      testConverter.Number = 102;
      testConverter.ShowSettings();
      testConverter.PrintResult();

      testConverter.Number = -18;
      testConverter.ShowSettings();
      testConverter.PrintResult();

      testConverter.Number = 11000110;
      testConverter.FromBase = "Binary";
      testConverter.ToBase = "Decimal";
      testConverter.ShowSettings();
      testConverter.PrintResult();

      testConverter.Number = 19142;
      testConverter.FromBase = "Decimal";
      testConverter.ToBase = "Octal";
      testConverter.ShowSettings();
      testConverter.PrintResult();

      testConverter.Number = 377;
      testConverter.FromBase = "Octal";
      testConverter.ToBase = "Decimal";
      testConverter.ShowSettings();
      testConverter.PrintResult();

      testConverter.Number = 8869;
      testConverter.FromBase = "Decimal";
      testConverter.ToBase = "Hexadecimal";
      testConverter.ShowSettings();
      testConverter.PrintResult();

      testConverter.Number = 368298;
      testConverter.FromBase = "Hexadecimal";
      testConverter.ToBase = "Decimal";
      testConverter.ShowSettings();
      testConverter.PrintResult();

      testConverter.Number = 1101110;
      testConverter.FromBase = "Binary";
      testConverter.ToBase = "Octal";
      testConverter.ShowSettings();
      testConverter.PrintResult();

      testConverter.Number = 725;
      testConverter.FromBase = "Octal";
      testConverter.ToBase = "Binary";
      testConverter.ShowSettings();
      testConverter.PrintResult();

      testConverter.Number = 1101110;
      testConverter.FromBase = "Binary";
      testConverter.ToBase = "Hexadecimal";
      testConverter.ShowSettings();
      testConverter.PrintResult();

      testConverter.Number = 725;
      testConverter.FromBase = "Hexadecimal";
      testConverter.ToBase = "Binary";
      testConverter.ShowSettings();
      testConverter.PrintResult();

      testConverter.Number = 645;
      testConverter.FromBase = "Octal";
      testConverter.ToBase = "Hexadecimal";
      testConverter.ShowSettings();
      testConverter.PrintResult();

      testConverter.Number = 9876;
      testConverter.FromBase = "Hexadecimal";
      testConverter.ToBase = "Octal";
      testConverter.ShowSettings();
      testConverter.PrintResult();

      testConverter.Number = -385;
      testConverter.FromBase = "Base5";
      testConverter.ToBase = "Decimal";
      testConverter.ShowSettings();
      testConverter.PrintResult();

      testConverter.ResetBaseConverter();
      testConverter.ShowSettings();

    }
  }
}