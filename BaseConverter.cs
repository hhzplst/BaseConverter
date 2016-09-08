using System;

namespace BaseConverter {
    public class BaseConverter {
        public int Number {get; set; }
        public string FromBase {get; set; }
        public string ToBase {get; set; }
        public void Init() {
            Number = 0;
            FromBase = "Decimal";
            ToBase = "Binary";
        }
        public BaseConverter() {
            Init();
        }
        public void ResetBaseConverter() {
            Init();
        }
        public void ShowSettings() {
            Console.WriteLine("\n********************");
            Console.WriteLine("CURRENT SETTINGS\nNumber: {0}\nFrom Base: {1}\nTo Base: {2}", Number, FromBase, ToBase);
            Console.WriteLine("********************\n");
        }
        public void PrintResult() {
            BaseConversionCalculator myCalculator = new BaseConversionCalculator(Number);
            switch(FromBase + "To" + ToBase) {
                case "DecimalToBinary":
                    Console.WriteLine("{0} in {1} is {2} in {3}. ", Number, FromBase, myCalculator.DecimalToBinary(), ToBase);
                    break;
                case "BinaryToDecimal":
                    Console.WriteLine("{0} in {1} is {2} in {3}. ", Number, FromBase, myCalculator.BinaryToDecimal(), ToBase);
                    break;
                case "DecimalToOctal":
                    Console.WriteLine("{0} in {1} is {2} in {3}. ", Number, FromBase, myCalculator.DecimalToOctal(), ToBase);
                    break;
                case "OctalToDecimal":
                    Console.WriteLine("{0} in {1} is {2} in {3}. ", Number, FromBase, myCalculator.OctalToDecimal(), ToBase);
                    break;
                case "DecimalToHexadecimal":
                    Console.WriteLine("{0} in {1} is {2} in {3}. ", Number, FromBase, myCalculator.DecimalToHex(), ToBase);
                    break;
                case "HexadecimalToDecimal":
                    Console.WriteLine("{0} in {1} is {2} in {3}. ", Number, FromBase, myCalculator.HexToDecimal(), ToBase);
                    break;
                case "BinaryToOctal":
                    Console.WriteLine("{0} in {1} is {2} in {3}. ", Number, FromBase, myCalculator.BinaryToOctal(), ToBase);
                    break;
                case "OctalToBinary":
                    Console.WriteLine("{0} in {1} is {2} in {3}. ", Number, FromBase, myCalculator.OctalToBinary(), ToBase);
                    break;
                case "BinaryToHexadecimal":
                    Console.WriteLine("{0} in {1} is {2} in {3}. ", Number, FromBase, myCalculator.BinaryToHex(), ToBase);
                    break;
                case "HexadecimalToBinary":
                    Console.WriteLine("{0} in {1} is {2} in {3}. ", Number, FromBase, myCalculator.HexToBinary(), ToBase);
                    break;
                case "OctalToHexadecimal":
                    Console.WriteLine("{0} in {1} is {2} in {3}. ", Number, FromBase, myCalculator.OctalToHex(), ToBase);
                    break;
                case "HexadecimalToOctal":
                    Console.WriteLine("{0} in {1} is {2} in {3}. ", Number, FromBase, myCalculator.HexToOctal(), ToBase);
                    break;
                default: 
                    Console.WriteLine("This program only support the conversion between 2, 8, 10 and 16. ");    
                    break;
            }
        }       
    }
}