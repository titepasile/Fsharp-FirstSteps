namespace FSharpKoans
open FSharpKoans.Core

//---------------------------------------------------------------
// Über Let
//
// Das Schlüsselwort let ist einer der grundlegendsten Bestandteile von F#.
// Sie werden es in fast jeder Zeile F#-Code verwenden, die Sie schreiben, also
// sollten Sie es gut kennenlernen!
//---------------------------------------------------------------
[<Koan(Sort = 2)>]
module ``about let`` =

    [<Koan>]
    //Let bindet einen Namen an einen Wert
    let LetBindsANameToAValue() =
        let x = 50
        
        //Ersetzen Sie die __ mit dem Wert des Symbols x
        AssertEquality x 50
    
    (* In F# werden Werte, die mit let erstellt werden, einem Typ zugeordnet, wie
       "int" für Ganzzahlwerte, "string" für Textwerte und "bool" 
       für wahre oder falsche Werte.. *)
    [<Koan>]
    //"let" (bzw. der Compiler) leitet die Typen von Werten ab, wo dies möglich ist
    let LetInfersTheTypesOfValuesWherePossible() =
        let x = 50
        let typeOfX = x.GetType()
        
        //Ersetzen Sie die __ mit dem Wert des Symbols x
        AssertEquality typeOfX typeof<FILL_ME_IN>

        let y = "a string"
        let expectedTypeOfY = y.GetType()
        
        //Ersetzen Sie die __ mit dem Wert des Symbols y
        AssertEquality expectedTypeOfY typeof<FILL_ME_IN>

        let z = true
        let expectedTypeOfZ = z.GetType()
        
        //Ersetzen Sie die __ mit dem Wert des Symbols y
        AssertEquality expectedTypeOfZ typeof<FILL_ME_IN>

    [<Koan>]
    //Sie können Typen explizit machen
    let YouCanMakeTypesExplicit() =
        let (x:int) = 42
        let typeOfX = x.GetType()

        let y:string = "forty two"
        let typeOfY = y.GetType()

        AssertEquality typeOfX typeof<FILL_ME_IN>
        AssertEquality typeOfY typeof<FILL_ME_IN>

        (* Normalerweise müssen Sie keine expliziten Typ-Annotationen für 
           lokale Variablen, aber Typ-Annotationen können in anderen Zusammenhängen nützlich sein 
           Kontexten nützlich sein. *)
    
    [<Koan>]
    let FloatsAndInts() =
        (* Je nach Ihrem Hintergrund werden Sie vielleicht überrascht sein zu erfahren, dass
           in F# Ganzzahlen und Fließkommazahlen unterschiedliche Typen sind. 
           Mit anderen Worten, das Folgende ist wahr. *)
        let x = 20
        let typeOfX = x.GetType()

        let y = 20.0
        let typeOfY = y.GetType()

        //dies brauchen Sie nicht zu ändern
        AssertEquality typeOfX typeof<int>
        AssertEquality typeOfY typeof<float>

        //Wenn Sie aus einer anderen .NET-Sprache kommen, ist float F#-Slang für
        //den Double-Typ.

    [<Koan>]
    // Einfach der Vollständigkeit halber, merken Sie es sich nicht, wir werden dies nie mehr brauchen!!
    //Ändernder Wert von Variablen
    let ModifyingTheValueOfVariables() =
        let mutable x = 100
        x <- 200

        AssertEquality x __

    [<Koan>]
    let YouCannotModifyALetBoundValueIfItIsNotMutable() =
        let x = 50
        
        //Was passiert, wenn Sie die folgende Zeile auskommentieren?
        //x <- 100

        //NOTE: Obwohl Sie unveränderliche Werte nicht ändern können, ist es möglich
        // den Namen eines Wertes in einigen Fällen durch "Shadowing" wiederzuverwenden.
        let x = 100
         
        AssertEquality x __
