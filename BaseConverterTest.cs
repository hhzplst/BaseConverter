using System;

namespace BaseConverter {
  public class BaseConverterTest {
    public static void Main (string[] args) {
      BaseConverter testConverter = new BaseConverter();
      Console.WriteLine("Welcome to testConverter!");
      testConverter.ShowSettings();
    }
  }
}