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
        public int DecimalToBinary() {

        }
        public int BinaryToDecimal() {

        }
        public int DecimalToOctal() {

        }
        public int OctalToDecimal() {

        }
        public int DecimalToHex() {

        }
        public int HexToDecimal() {

        }
        public int BinaryToOctal() {

        }
        public int OctalToBinary() {

        }
        public int BinaryToHex() {

        }
        public int HexToBinary() {

        }
        public int OctalToHex() {

        }
        public int HexToOctal() {

        }
        public void PrintResult() {

        }       
    }
}
