namespace FSharpKoans
open FSharpKoans.Core

//---------------------------------------------------------------
// About Strings
//
// Die meisten Sprachen verfügen über eine Reihe von Hilfsprogrammen zur Manipulation von 
// Zeichenketten. F# ist nicht anders.
//---------------------------------------------------------------
[<Koan(Sort = 3)>]
module ``about strings`` =

    [<Koan>]
    let StringValue() =
        let message = "hello"

        AssertEquality message __

    [<Koan>]
    let StringConcatValue() =
        let message = "hello " + "world"

        AssertEquality message __

    [<Koan>]
    let FormattingStringValues() =
        let message = sprintf "F# turns it to %d!" 11

        AssertEquality message __

        //NOTE: Sie können printf verwenden, um auf die Standardausgabe zu drucken

        (* TRY IT: Was passiert, wenn man die 11 in etwas anderes als eine 
                   eine Zahl ist? *)

    [<Koan>]
    let FormattingOtherTypes() =
        let message = sprintf "hello %s" "world"

        AssertEquality message __

    [<Koan>]
    let FormattingAnything() =
        let message = sprintf "Formatting other types is as easy as: %A" (1, 2, 3)

        AssertEquality message __

    (* NOTE: Für alle %formatters, die Sie bei der Zeichenkettenformatierung verwenden können  
             see: https://docs.microsoft.com/en-us/dotnet/fsharp/language-reference/plaintext-formatting *)

    [<Koan>]
    let CombineMultiline() =
        let message = "super\
                        cali\
                        fragilistic\
                        expiali\
                        docious"

        AssertEquality message __

    [<Koan>]
    let Multiline() =
        let message = "This
                        is
                        on
                        five
                        lines"

        AssertEquality
              message __

    [<Koan>]
    let ExtractValues() =
        let message = "hello world"

        let first = message.[0]
        let other = message.[4] 

 (* Ein einzelnes Zeichen wird durch einfache Anführungszeichen gekennzeichnet, Beispiel: 'c',
        keine doppelten Anführungszeichen wie bei einer Zeichenkette *)
           
        AssertEquality first __
        AssertEquality other __

    [<Koan>]
    let ApplyWhatYouLearned() =
        (* Es ist an der Zeit, das bisher Gelernte anzuwenden. Füllen Sie die folgende Funktion aus, um
           damit die Asserts funktionieren *)
        let getFunFacts x =
            __

        let funFactsAboutThree = getFunFacts 3
        let funFactsAboutSix = getFunFacts 6

        AssertEquality "3 doubled is 6, and 3 tripled is 9!" funFactsAboutThree 
        AssertEquality "6 doubled is 12, and 6 tripled is 18!" funFactsAboutSix 
