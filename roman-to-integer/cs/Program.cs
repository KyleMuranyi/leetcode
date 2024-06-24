public class Program {
    public static void Main() {
        string[] numerals = [
            "DCLV", "LXVII", "CCXXXI", "CXCIX",
            "DCXXV", "LXII", "CCLXXII", "CCCXLVI",
            "DCCCVI", "CMXXIX", "DCCXLV", "XXIII", 
            "CCXXIX", "DCCLXX", "DIX", "CCXLVIII", 
            "CCCLXVI", "CMX", "DLVI", "CDXCVII",
            "III", "LVIII", "MCMXCIV", "XXL"
        ];

        foreach (string numeral in numerals) {
            int test = Roman.ToInt(numeral);
            Console.WriteLine(test);
        }
    }
}
