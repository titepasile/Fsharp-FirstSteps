namespace FSharpKoans
open FSharpKoans.Core

//---------------------------------------------------------------
// Erste Schritte
//
// Die F# Koans sind eine Reihe von �bungen, die Sie mit F# vertraut machen.
//
// Beantwortung von Problemen
// 
// Hier beginnt der Spa�! Jede Koan-Methode enth�lt
// ein Beispiel, das Ihnen eine Lektion �ber die Sprache F# vermitteln soll. 
// Wenn Sie das in diesem Projekt definierte Programm ausf�hren, erhalten Sie
// eine Meldung, dass das unten stehende AssertEquality-Koan fehlgeschlagen ist. Ihre
// Aufgabe ist es, die Leerstelle (das __-Symbol) auszuf�llen, damit die Pr�fung bestanden wird. Sobald
// Sie die �nderung vorgenommen haben, f�hren Sie das Programm erneut aus, um sicherzustellen, dass das Koan
// bestanden wird, und fahren Sie mit dem n�chsten fehlgeschlagenen Koan fort.  Mit jedem 
// bestandenen Koan lernen Sie mehr �ber F# und f�gen eine weitere
// Waffe zu Ihrem F#-Programmierarsenal hinzu.
//---------------------------------------------------------------
[<Koan(Sort = 1)>]
module ``about asserts`` =

    [<Koan>]
    let AssertExpectation() =
        let expected_value = 1 + 1
        let actual_value = __ //beginnen Sie mit dem �ndern dieser Zeile
     
        AssertEquality expected_value actual_value
 
    //Einfach, nicht wahr? Jetzt noch einen Versuch

    [<Koan>]
    let FillInValues() =
        AssertEquality (1 + 1) __