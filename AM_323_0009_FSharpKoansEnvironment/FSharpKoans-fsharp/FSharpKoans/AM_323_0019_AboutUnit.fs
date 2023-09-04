namespace FSharpKoans
open FSharpKoans.Core
open Microsoft.FSharp.Reflection

//---------------------------------------------------------------
// Über die Einheit
//
// Der unit type ist ein spezieller Typ, der das Fehlen eines Wertes darstellt. 
// Er ist ähnlich wie void in anderen Sprachen, aber unit
// wird in F# tatsächlich als Typ betrachtet.
//---------------------------------------------------------------
[<Koan(Sort = 5)>]
module ``about unit`` =

    [<Koan>]
    //Unit wird verwendet, wenn es keinen Rückgabewert für eine Funktion gibt
    let UnitIsUsedWhenThereIsNoReturnValueForAFunction() =
        let sendData data =
            //...sending the data to the server...
            ()

        let x = sendData "data"
        AssertEquality x //Denken Sie nicht zu viel darüber nach. Beachten Sie auch, dass der Wert "()" in einigen Fällen als "null" angezeigt wird.

    [<Koan>]
    // Parameterlose Funktionen mit Einheit als Argument
    let ParameterlessFunctionsTakeUnitAsTheirArgument() =
        let sayHello() =
            "hello"

        let result = sayHello()
        AssertEquality result "hello"