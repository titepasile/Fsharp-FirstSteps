﻿// For more information see https://aka.ms/fsharp-console-apps
printfn "Hello from F#"

let square x = x * x

[<EntryPoint>]
let main argv =
    printfn "%d squared is: %d!" 12 (square 12)
    0 // Return an integer exit code
