module Roman

let private NumeralToInt =
    function
    | "I" -> 1
    | "V" -> 5
    | "X" -> 10
    | "L" -> 50
    | "C" -> 100
    | "D" -> 500
    | "M" -> 1000
    | _ -> 0

let ToInt (numeral:string) : int =
    let mutable total = 0
    let mutable i = 0

    while i < numeral.Length do
        let currentChar = numeral.[i].ToString()
        // if nextChar does not exist use A because A will result in 0
        let nextChar : string =
            try
                if i + 1 <= numeral.Length then
                    numeral.[i + 1].ToString()
                else
                    "A"
            with _ ->
                "A"

        match currentChar, nextChar with
        // I can be placed before V (5) and X (10) to make 4 and 9. 
        | "I", "V" -> total <- total + 4; i <- i + 2;
        | "I", "X" -> total <- total + 9; i <- i + 2;
        // X can be placed before L (50) and C (100) to make 40 and 90. 
        | "X", "L" -> total <- total + 40; i <- i + 2;
        | "X", "C" -> total <- total + 90; i <- i + 2;
        // C can be placed before D (500) and M (1000) to make 400 and 900.
        | "C", "D" -> total <- total + 400; i <- i + 2;
        | "C", "M" -> total <- total + 900; i <- i + 2;
        | _ ->
            total <- total + NumeralToInt currentChar
            i <- i + 1

    total
