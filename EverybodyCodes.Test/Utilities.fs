namespace EverybodyCodes.Test

open System.IO
open System.Reflection

module Utilities =
    let ReadResource (resourceName:string) : string =
        let assembly = Assembly.GetExecutingAssembly()
        use stream = assembly.GetManifestResourceStream("EverybodyCodes.Test.Inputs." + resourceName)
        use reader = new StreamReader(stream)
        reader.ReadToEnd()