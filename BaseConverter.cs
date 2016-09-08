using System;

namespace BaseConverter {
    public class BaseConverter {
        public int Number {get; set; }
        public string FromBase {get{ return FromBase; } set{ FromBase =  value.ToLower(); } }
        public string ToBase {get{ return ToBase; } set{ ToBase = value.ToLower(); } }
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
        public string DecimalToBinary() {
            return Convert.ToString(Number, 2);
        }
        public int BinaryToDecimal() {
            return Convert.ToInt32(Convert.ToString(Number), 2);
        }
        public string DecimalToOctal() {
            return Convert.ToString(Number, 8);
        }
        public int OctalToDecimal() {
            return Convert.ToInt32(Convert.ToString(Number), 8);
        }
        public string DecimalToHex() {
            return Convert.ToString(Number, 16);
        }
        public int HexToDecimal() {
            return Convert.ToInt32(Convert.ToString(Number), 16);
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
        public void PrintResult() {
            switch(FromBase + "TO" + ToBase) {
                case "decimalTObinary":
                    Console.WriteLine("{1} in {2} is {3} in {4}. ", Number, FromBase, DecimalToBinary(), ToBase);
                    break;
                case "binaryTOdecimal":
                    Console.WriteLine("{1} in {2} is {3} in {4}. ", Number, FromBase, BinaryToDecimal(), ToBase);
                    break;
                case "decimalTOoctal":
                    Console.WriteLine("{1} in {2} is {3} in {4}. ", Number, FromBase, DecimalToOctal(), ToBase);
                    break;
                case "octalTOdecimal":
                    Console.WriteLine("{1} in {2} is {3} in {4}. ", Number, FromBase, OctalToDecimal(), ToBase);
                    break;
                case "decimalTOhex":
                    Console.WriteLine("{1} in {2} is {3} in {4}. ", Number, FromBase, DecimalToHex(), ToBase);
                    break;
                case "hexTOdecimal":
                    Console.WriteLine("{1} in {2} is {3} in {4}. ", Number, FromBase, HexToDecimal(), ToBase);
                    break;
                case "binaryTOoctal":
                    Console.WriteLine("{1} in {2} is {3} in {4}. ", Number, FromBase, BinaryToOctal(), ToBase);
                    break;
                case "octalTObinary":
                    Console.WriteLine("{1} in {2} is {3} in {4}. ", Number, FromBase, OctalToBinary(), ToBase);
                    break;
                case "binaryTOhex":
                    Console.WriteLine("{1} in {2} is {3} in {4}. ", Number, FromBase, BinaryToHex(), ToBase);
                    break;
                case "hexTObinary":
                    Console.WriteLine("{1} in {2} is {3} in {4}. ", Number, FromBase, HexToBinary(), ToBase);
                    break;
                case "octalTOhex":
                    Console.WriteLine("{1} in {2} is {3} in {4}. ", Number, FromBase, OctalToHex(), ToBase);
                    break;
                case "hexTOoctal":
                    Console.WriteLine("{1} in {2} is {3} in {4}. ", Number, FromBase, HexToOctal(), ToBase);
                    break;
                default: 
                    Console.WriteLine("This program only support the conversion between 2, 8, 10 and 16. ");    
                    break;
            }
        }       
    }
}
