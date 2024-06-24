open System

[<EntryPoint>]
let main args =
    let numerals = [
        "DCLV"; "LXVII"; "CCXXXI"; "CXCIX";
        "DCXXV"; "LXII"; "CCLXXII"; "CCCXLVI";
        "DCCCVI"; "CMXXIX"; "DCCXLV"; "XXIII"; 
        "CCXXIX"; "DCCLXX"; "DIX"; "CCXLVIII"; 
        "CCCLXVI"; "CMX"; "DLVI"; "CDXCVII";
        "III"; "LVIII"; "MCMXCIV"; "XXL";
    ]

    for numeral in numerals do
        let result = Roman.ToInt numeral
        printfn $"{numeral} {result}"
    0
