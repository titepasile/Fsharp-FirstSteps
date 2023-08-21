namespace FSharpKoans
open FSharpKoans.Core

//---------------------------------------------------------------
// Erste Schritte
//
// Die F# Koans sind eine Reihe von Übungen, die Sie mit F# vertraut machen.
//
// Beantwortung von Problemen
// 
// Hier beginnt der Spaß! Jede Koan-Methode enthält
// ein Beispiel, das Ihnen eine Lektion über die Sprache F# vermitteln soll. 
// Wenn Sie das in diesem Projekt definierte Programm ausführen, erhalten Sie
// eine Meldung, dass das unten stehende AssertEquality-Koan fehlgeschlagen ist. Ihre
// Aufgabe ist es, die Leerstelle (das __-Symbol) auszufüllen, damit die Prüfung bestanden wird. Sobald
// Sie die Änderung vorgenommen haben, führen Sie das Programm erneut aus, um sicherzustellen, dass das Koan
// bestanden wird, und fahren Sie mit dem nächsten fehlgeschlagenen Koan fort.  Mit jedem 
// bestandenen Koan lernen Sie mehr über F# und fügen eine weitere
// Waffe zu Ihrem F#-Programmierarsenal hinzu.
//---------------------------------------------------------------
[<Koan(Sort = 1)>]
module ``about asserts`` =

    [<Koan>]
    let AssertExpectation() =
        let expected_value = 1 + 1
        let actual_value = __ //beginnen Sie mit dem Ändern dieser Zeile
     
        AssertEquality expected_value actual_value
 
    //Einfach, nicht wahr? Jetzt noch einen Versuch

    [<Koan>]
    let FillInValues() =
        AssertEquality (1 + 1) __