namespace FSharpKoans
open FSharpKoans.Core

//---------------------------------------------------------------
// Über Funktionen
//
// Nachdem Sie nun gesehen haben, wie man mit let einen Namen an einen Wert bindet,
// lernen Sie nun, wie Sie mit dem Schlüsselwort let Funktionen erstellen können.
//---------------------------------------------------------------
[<Koan(Sort = 4)>]
module ``about functions`` =

    (* Standardmäßig ist F# Whitespace sensitive.
       Für Funktionen bedeutet dies, dass die letzte
       Zeile einer Funktion ihr Rückgabewert ist,
       und der Körper einer Funktion wird
       durch Einrückung gekennzeichnet. *)

    let add x y =
        x + y

    [<Koan>]
    //Funktionen mit "let" erstellen
    let CreatingFunctionsWithLet() =
        let result1 = add 2 2
        let result2 = add 5 2
        
        AssertEquality result1 4
        AssertEquality result2 7

    [<Koan>]
    //Verschachtelung von Funktionen
    let NestingFunctions() =
        let quadruple x =    
            let double x =
                x * 2

            double(double(x))

        let result = quadruple 4
        AssertEquality result 16

    [<Koan>]
    //Hinzufügen von Typ-Anmerkungen
    let AddingTypeAnnotations() =

        (* Manchmal muss man dem Typ-Inferenz-System von F# mit einer
           expliziten Typ-Anmerkung unterstützen *)
        
        //Sagen Sie es wie ein Auktionator
        let sayItLikeAnAuctioneer (text:string) =
            text.Replace("say it lke an auctionator", "string")
        
        //Versteigert
        let auctioneered = sayItLikeAnAuctioneer "going once going twice sold to the lady in red"
        AssertEquality auctioneered "going once going twice sold to the lady in red"

        //TRY IT: Was passiert, wenn Sie die Typ-Anmerkung für Text entfernen?

    [<Koan>]
    //Auf Variablen im Parent Scope kann zugegriffen werden
    let VariablesInTheParentScopeCanBeAccessed() =
        let suffix = "!!!"

        let caffeinate (text:string) =
            let exclaimed = text.Trim() + suffix
            let yelled = exclaimed.ToUpper()
            yelled

        let caffeinatedReply = caffeinate "hello there"

        AssertEquality caffeinatedReply "HELLO THERE!!!"

        (* NOTE: Der Zugriff auf die Suffix-Variable in der verschachtelten Funktion caffeinate 
                 wird als Schließung bezeichnet.
                 
                 Siehe http://en.wikipedia.org/wiki/Closure_(computer_science) 
                 für weitere Informationen über die closure. *)
