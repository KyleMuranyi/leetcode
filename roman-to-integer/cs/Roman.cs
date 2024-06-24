public class Roman {

    private static int NumeralToInt (string numeral) {
        switch (numeral.ToUpper()) {
            case "I": return 1;
            case "V": return 5;
            case "X": return 10;
            case "L": return 50;
            case "C": return 100;
            case "D": return 500;
            case "M": return 1000;
            default: return 0;
        }
    }

    public static int ToInt (string numerals) {
        int total = 0;
        int i = 0;

        while (i < numerals.Length) {
            string currentChar = numerals[i].ToString();
            string nextChar = "A";  // default A so it counts as 0

            if (i + 1 <= numerals.Length - 1) {
                nextChar = numerals[i + 1].ToString();
            }

            if (currentChar == "I" && nextChar == "V") { total = total + 4; i++; }
            else if (currentChar == "I" && nextChar == "X") { total = total + 9; i++; }
            else if (currentChar == "X" && nextChar == "L") { total = total + 40; i++; }
            else if (currentChar == "X" && nextChar == "C") { total = total + 90; i++; }
            else if (currentChar == "C" && nextChar == "D") { total = total + 400; i++; }
            else if (currentChar == "C" && nextChar == "M") { total = total + 900; i++; }
            else { total = total + NumeralToInt(currentChar); }
            
            i++;
        }

        return total;
    }
}
