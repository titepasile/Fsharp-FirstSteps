namespace FSharpKoans
open FSharpKoans.Core

//---------------------------------------------------------------
// Über Tupel
//
// Tupel werden verwendet, um Werte in F# einfach zusammenzufassen. Sie sind 
// ein weiteres grundlegendes Konstrukt der Sprache.
//---------------------------------------------------------------
[<Koan(Sort = 6)>]
module ``about tuples`` =
    
    [<Koan>]
    let CreatingTuples() =
        let items = ("apple", "dog")
        
        AssertEquality items ("apple", "dog")
        
    [<Koan>]
    let AccessingTupleElements() =
        let items = ("apple", "dog")
        
        let fruit = fst items
        let animal = snd items
        
        AssertEquality fruit "apple"
        AssertEquality animal "dog"

    [<Koan>]
    // Zugriff auf Tupel-Elemente mit Mustervergleichen
    let AccessingTupleElementsWithPatternMatching() =

        (* fst und snd sind in manchen Situationen nützlich, aber sie funktionieren nur mit
           Tupeln mit zwei Elementen. Normalerweise ist es besser, eine Technik 
           namens Pattern Matching (Musterabgleich) zu verwenden, um auf die 
           Werte eines Tupels zuzugreifen. 
           
           Pattern Matching funktioniert mit Tupeln beliebiger Arität (Anzahl der Argumente) 
           und ermöglicht es Ihnen gleichzeitig das Tupel zu zerlegen und jedem Wert 
           einen Namen zuzuweisen. Hier ist ein Beispiel. *)
        
        let items = ("apple", "dog", "Mustang")
        
        let fruit, animal, car = items
        
        AssertEquality fruit "apple"
        AssertEquality animal "dog"
        AssertEquality car "Mustang"
        
    [<Koan>]
    // Ignorieren von Werten mit Mustervergleichen
    let IgnoringValuesWithPatternMatching() =
        let items = ("apple", "dog", "Mustang")
        
        let _, animal, _ = items
        
        AssertEquality animal "dog"
    
    (* NOTE: Pattern Matching findet sich an vielen Stellen
             in F# zu finden, und wir werden später noch einmal darauf zurückkommen *)
        
    [<Koan>]
    // Rückgabe mehrerer Werte aus einer Funktion
    let ReturningMultipleValuesFromAFunction() =
        let squareAndCube x =
            (x ** 2.0, x ** 3.0)
        
        let squared, cubed = squareAndCube 3.0
        
        
        AssertEquality squared 9.0
        AssertEquality cubed 27.0
    
    (* THINK ABOUT IT: Gibt es wirklich mehr als einen Rückgabewert?
                       Welchen Typ gibt die Funktion squareAndCube
                       zurück? *)
    
    [<Koan>]
    // Die Wahrheit hinter Multiple Return Values
    let TheTruthBehindMultipleReturnValues() =
        let squareAndCube x =
            (x ** 2.0, x ** 3.0)
            
        let result = squareAndCube 3.0
       
        AssertEquality result
