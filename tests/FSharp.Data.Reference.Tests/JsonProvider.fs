module FSharp.Data.Reference.Tests.JsonProvider

open System.IO
open NUnit.Framework
open FsUnit

[<Test>]
let ``Can load JSON from embedded resource in referenced assembly``() =
    typeof<FSharp.Data.Tests.JsonProvider.GitHub>.Assembly.GetManifestResourceStream("FSharp.Data.Tests.Data.GitHub.json")
    |> FSharp.Data.Tests.JsonProvider.GitHub.Load
    |> should not' (equal null)
