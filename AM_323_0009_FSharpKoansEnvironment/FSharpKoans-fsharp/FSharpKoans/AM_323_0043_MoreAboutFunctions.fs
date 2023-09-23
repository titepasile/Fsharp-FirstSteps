namespace FSharpKoans
open FSharpKoans.Core

//---------------------------------------------------------------
// More About Functions
//
// Sie haben bereits ein wenig über Funktionen in F# gelernt, aber
// da F# eine funktionale Sprache ist, gibt es noch mehr Tricks
// zu lernen!
//---------------------------------------------------------------
[<Koan(Sort = 11)>]
module ``more about functions`` =
    
    [<Koan>]
    let DefiningLambdas() =
        
        let colors = ["maize"; "blue"]

        let echo = 
            colors
            |> List.map (fun x -> x + " " + x)

        AssertEquality echo __

        (* Mit dem Schlüsselwort "fun" können Sie eine Funktion inline erstellen, ohne ihr einen Namen zu geben.
           einen Namen zu geben. Diese Funktionen sind bekannt als anonyme Funktionen, Lambdas,
           oder Lambda-Funktionen. *)

    [<Koan>]
    let FunctionsThatReturnFunctions() =
        (* Ein netter Trick der funktionalen Programmierung ist es, Funktionen zu erstellen, die 
           andere Funktionen zurückgeben. Dies führt zu einigen interessanten Verhaltensweisen. *)
        let add x =
            (fun y -> x + y)

        (* Die leichtgewichtige Syntax von F# erlaubt es Ihnen, beide Funktionen aufzurufen, 
           als ob es nur eine nur eine  *)
        let simpleResult = add 2 4
        AssertEquality simpleResult __

        (* ...aber Sie können auch jeweils nur ein Argument übergeben, um eine
           Restfunktionen zu erstellen. Diese Technik wird als partielle Anwendung bezeichnet. *)
        let addTen = add 10
        let fancyResult = addTen 14

        AssertEquality fancyResult __

        //NOTE: Funktionen, die in diesem Stil geschrieben sind, werden als "curried" bezeichnet.

    [<Koan>]
    let AutomaticCurrying() =
        (* Die obige Technik ist so weit verbreitet, dass F# sie sogar
           standardmäßig unterstützt. Mit anderen Worten: Funktionen werden automatisch curried.*)
        let add x y = 
            x + y

        let addSeven = add 7
        let unluckyNumber = addSeven 6
        let luckyNumber = addSeven 0

        AssertEquality unluckyNumber __
        AssertEquality luckyNumber __

    [<Koan>]
    let NonCurriedFunctions() =
        (* Sie sollten sich die meiste Zeit an die Syntax der Auto-Curried-Funktion 
           halten. Sie können jedoch auch Funktionen in einer nicht-curried Form schreiben, 
           um sie in Sprachen wie C#, in denen Currying nicht so häufig verwendet wird, leichter 
           zu verwendet. *)

        let add(x, y) =
            x + y

        (* NOTE: "add 5" wird jetzt nicht kompiliert. Sie müssen beide Argumente 
                 auf einmal übergeben *)

        let result = add(5, 40)

        AssertEquality result __

        (* THINK ABOUT IT: Sie haben bereits gelernt, dass Funktionen mit mehreren 
                           Rückgabewerten eigentlich nur Funktionen sind, die
                           Tupel zurückgeben. Können Funktionen, die in der nicht-curried Form
                           definiert sind, wirklich mehr als ein Argument auf einmal akzeptieren? *)
