namespace FSharpKoans
open FSharpKoans.Core

//---------------------------------------------------------------
// Über die Reihenfolge der Auswertung
//
// Manchmal müssen Sie die Reihenfolge, in der Funktionen ausgewertet werden, explizit angeben. 
// F# bietet eine Reihe von Mechanismen, um dies zu tun.
//---------------------------------------------------------------
[<Koan(Sort = 8)>]
module ``about the order of evaluation`` =

    [<Koan>]
    let SometimesYouNeedParenthesisToGroupThings() =
        let add x y =
            x + y

        let result = add (add 5 8) (add 1 1)

        AssertEquality result 15

        (* TRY IT: Was passiert, wenn Sie die Klammern entfernen?*)

    [<Koan>]
    let TheBackwardPipeOperatorCanAlsoHelpWithGrouping() =
        let add x y =
            x + y

        let double x =
            x * 2
        (* Schauen Sie nach, was der "Backward Pipe Operator" --> "<|" ist
            und was er macht
            https://learn.microsoft.com/en-us/dotnet/fsharp/language-reference/symbol-and-operator-reference/
        *)
        let result = double <| add 5 8

        AssertEquality result 26
