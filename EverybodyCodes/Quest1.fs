namespace EverybodyCodes

module Quest1 =
    let PotionsNeeded (creature:char) =
        match creature with
        | 'A' -> 0
        | 'B' -> 1
        | 'C' -> 3
        | 'D' -> 5
        | _ -> 0

    let PotionsNeededForGroup (group:char array) =
        let filteredGroup = Array.filter (fun c -> c <> 'x') group
        let extraPotions = filteredGroup.Length - 1

        filteredGroup
        |> Seq.sumBy (fun c -> PotionsNeeded c + extraPotions)

    let Solve (input:string) (groups:int) =
        input
        |> Seq.chunkBySize groups
        |> Seq.sumBy (fun group -> PotionsNeededForGroup group)