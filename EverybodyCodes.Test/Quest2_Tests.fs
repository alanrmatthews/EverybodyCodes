namespace EverybodyCodes.Test

open Xunit
open EverybodyCodes
open Quest2

module Quest2Tests =
    // [<Fact>]
    // let ``Test Part 1 Example`` () =
    //     let input = [| "WORDS:THE,OWE,MES,ROD,HER"; ""; "AWAKEN THE POWER ADORNED WITH THE FLAMES BRIGHT IRE" |]
    //     Assert.Equal(4, Solve input)

    // [<Fact>]
    // let ``Test Part 1`` () =
    //     let input = Utilities.ReadResourceLines "everybody_codes_e2024_q02_p1.txt"
    //     Assert.Equal(26, Solve input)

    [<Fact>]
    let ``Test Part 2 Example`` () =
        let input = [| "WORDS:THE,OWE,MES,ROD,HER,QAQ"; ""; "AWAKEN THE POWE ADORNED WITH THE FLAMES BRIGHT IRE"; "THE FLAME SHIELDED THE HEART OF THE KINGS"; "POWE PO WER P OWE R"; "THERE IS THE END"; "QAQAQ" |]
        Assert.Equal(42, Solve input)

    // [<Fact>]
    // let ``Test Part 2`` () =
    //     let input = Utilities.ReadResource "everybody_codes_e2024_q01_p2.txt"
    //     Assert.Equal(5600, Solve input 2)

    // [<Fact>]
    // let ``Test Part 3 Example`` () =
    //     Assert.Equal(30, Solve "xBxAAABCDxCC" 3)

    // [<Fact>]
    // let ``Test Part 3`` () =
    //     let input = Utilities.ReadResource "everybody_codes_e2024_q01_p3.txt"
    //     Assert.Equal(27612, Solve input 3)