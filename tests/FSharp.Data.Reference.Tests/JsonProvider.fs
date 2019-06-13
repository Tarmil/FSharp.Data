module FSharp.Data.Reference.Tests.JsonProvider

open System.IO
open NUnit.Framework
open FsUnit

[<Test>]
let ``Can load JSON from embedded resource in referenced assembly``() =
    FSharp.Data.Tests.JsonProvider.GitHub.GetSample()
    |> should not' (equal null)
