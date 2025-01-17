namespace EverybodyCodes

open System.Text.RegularExpressions

module Quest2 =
    let Solve (input: string array) =
        let words = input.[0].Split(':').[1].Split(',')

        let lineMatches (line:string) =
            // Array.sumBy(fun word -> Regex.Matches(line, word).Count) words
            let sum = Array.sumBy(fun word -> Regex.Matches(line, word).Count) words
            printfn "Line: %s, Sum: %d" line sum
            sum

        let forwardSum = input.[2..] |> Array.sumBy lineMatches
        let backwardSum =
            input.[2..]
            |> Array.map(fun l -> l |> Seq.rev |> Seq.toArray |> System.String)
            |> Array.sumBy lineMatches

        forwardSum + backwardSum