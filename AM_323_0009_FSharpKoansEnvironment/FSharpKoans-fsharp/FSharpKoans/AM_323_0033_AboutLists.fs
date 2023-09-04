namespace FSharpKoans
open FSharpKoans.Core
open System.Collections.Generic

//---------------------------------------------------------------
// Über Listen
//
// Listen sind wichtige Bausteine, die Sie in der F#-Programmierung häufig verwenden werden.
// Sie werden verwendet, um beliebig große Sequenzen von Werten zu grupieren. 
// Es ist sehr üblich, Werte in einer Liste zu speichern und Operationen auf jedem Wert in der 
// Liste durchzuführen.
//---------------------------------------------------------------
[<Koan(Sort = 9)>]
module ``about lists`` =

    [<Koan>]
    let CreatingLists() =
        let list = ["apple"; "pear"; "grape"; "peach"]
        
        //Note: Der Datentyp Liste in F# ist eine einfach verkettete Liste, 
        // daher ist die Indizierung von Elementen O(n).  
        
        AssertEquality list.Head "apple"
        AssertEquality list.Tail ["pear"; "grape"; "peach"]
        AssertEquality list.Length 4

        (* .NET-Entwickler, die aus anderen Sprachen kommen, sind vielleicht überrascht,
           dass der Listentyp von F# nicht derselbe ist wie der der Basisklassenbibliothek
           List<T> ist. Mit anderen Worten, die folgende Behauptung ist wahr *)

        let dotNetList = new List<string>()
        //Sie brauchen die folgende Zeile nicht zu ändern
        AssertInequality (list.GetType()) (dotNetList.GetType())

    [<Koan>]
    let BuildingNewLists() =
        let first = ["grape"; "peach"]
        let second = "pear" :: first
        let third = "apple" :: second

        //Note: "::" ist bekannt als "cons"
        
        AssertEquality ["apple"; "pear"; "grape"; "peach"] third
        AssertEquality second ["pear"; "grape"; "peach"]
        AssertEquality first ["grape"; "peach"]

        //Was passiert, wenn Sie die folgende Zeile auskommentieren?

        //first.Head <- "apple"
        //first.Tail <- ["peach"; "pear"]

        //THINK ABOUT IT: Kann man den Inhalt einer Liste ändern, nachdem sie
        // erstellt wurde?


    [<Koan>]
    let ConcatenatingLists() =
        let first = ["apple"; "pear"; "grape"]
        let second = first @ ["peach"]

        AssertEquality first ["apple"; "pear"; "grape"]
        AssertEquality second ["apple"; "pear"; "grape"; "peach"]

    (* THINK ABOUT IT: Was eignet sich im Allgemeinen besser für den Aufbau von Listen? 
       :: oder @? Und warum?
       
       Hinweis: Es gibt keine Möglichkeit, "first" in dem obigen Beispiel zu ändern. Es ist
       unveränderlich. Was muss die Funktion @ also tun, um
       um ["peach"] an "first" anzuhängen, um "second" zu erzeugen? *)
        
    [<Koan>]
    let CreatingListsWithARange() =
        let list = [0..4]
        
        AssertEquality list.Head 0
        AssertEquality list.Tail [1; 2; 3; 4]
        
