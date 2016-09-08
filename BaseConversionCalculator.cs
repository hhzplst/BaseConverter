using System;

namespace BaseConverter {
  public class BaseConversionCalculator {
    int number;
    public BaseConversionCalculator(int number) {
      this.number = number;
    }
    public string DecimalToBinary() {
        return Convert.ToString(number, 2);
    }
     public int BinaryToDecimal() {
        return Convert.ToInt32(Convert.ToString(number), 2);
    }
    public string DecimalToOctal() {
        return Convert.ToString(number, 8);
    }
    public int OctalToDecimal() {
        return Convert.ToInt32(Convert.ToString(number), 8);
    }
    public string DecimalToHex() {
        return Convert.ToString(number, 16);
    }
    public int HexToDecimal() {
        return Convert.ToInt32(Convert.ToString(number), 16);
    }
    public string BinaryToOctal() {
        return Convert.ToString(BinaryToDecimal(), 8);
    }
    public string OctalToBinary() {
        return Convert.ToString(OctalToDecimal(), 2);
    }
    public string BinaryToHex() {
        return Convert.ToString(BinaryToDecimal(), 16);
    }
    public string HexToBinary() {
        return Convert.ToString(HexToDecimal(), 2);
    }
    public string OctalToHex() {
        return Convert.ToString(OctalToDecimal(), 16);
     }
    public string HexToOctal() {
        return Convert.ToString(HexToDecimal(), 8);
    }
  }
}