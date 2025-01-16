namespace EverybodyCodes.Test

open Xunit
open EverybodyCodes

module Quest1Tests =
    [<Fact>]
    let ``Test Part 1 Example`` () =
        Assert.Equal(5, Quest1.Solve "ABBAC" 1)

    [<Fact>]
    let ``Test Part 1`` () =
        let input = Utilities.ReadResource "everybody_codes_e2024_q01_p1.txt"
        Assert.Equal(1356, Quest1.Solve input 1)

    [<Fact>]
    let ``Test Part 2 Example`` () =
        Assert.Equal(28, Quest1.Solve "AxBCDDCAxD" 2)

    [<Fact>]
    let ``Test Part 2`` () =
        let input = Utilities.ReadResource "everybody_codes_e2024_q01_p2.txt"
        Assert.Equal(5600, Quest1.Solve input 2)

    [<Fact>]
    let ``Test Part 3 Example`` () =
        Assert.Equal(30, Quest1.Solve "xBxAAABCDxCC" 3)

    [<Fact>]
    let ``Test Part 3`` () =
        let input = Utilities.ReadResource "everybody_codes_e2024_q01_p3.txt"
        Assert.Equal(27612, Quest1.Solve input 3)