namespace FSharpKoans
open FSharpKoans.Core

type Character = {
    Name: string
    Occupation: string
}

//---------------------------------------------------------------
// Über Record Types
//
// Record Types sind eine einfache Möglichkeit, neue Typen zu konstruieren.
// Mit ihnen können Sie Daten auf eine strukturiertere Weise gruppieren als
// Tupel.
//---------------------------------------------------------------
[<Koan(Sort = 7)>]
module ``about record types`` =

    [<Koan>]
    // Records haben Eigenschaften
    let RecordsHaveProperties() =
        let mario = { Name = "Mario"; Occupation = "Plumber"; }

        AssertEquality mario.Name __
        AssertEquality mario.Occupation __

    [<Koan>]
    // Aus einem bestehenden Datensatz erstellen
    let CreatingFromAnExistingRecord() =
        let mario = { Name = "Mario"; Occupation = "Plumber"; }
        let luigi = { mario with Name = "Luigi"; }

        AssertEquality mario.Name __
        AssertEquality mario.Occupation __

        AssertEquality luigi.Name __
        AssertEquality luigi.Occupation __

    [<Koan>]
    // Records vergleichen
    let ComparingRecords() =
        let greenKoopa = { Name = "Koopa"; Occupation = "Soldier"; }
        let bowser = { Name = "Bowser"; Occupation = "Kidnapper"; }
        let redKoopa = { Name = "Koopa"; Occupation = "Soldier"; }

        let koopaComparison =
             if greenKoopa = redKoopa then
                 "all the koopas are pretty much the same"
             else
                 "maybe one can fly"

        let bowserComparison = 
            if bowser = greenKoopa then
                "the king is a pawn"
            else
                "he is still kind of a koopa"

        AssertEquality koopaComparison __
        AssertEquality bowserComparison __

    [<Koan>]
    // Sie können Pattern Matches gegen Datensätze durchführen
    let YouCanPatternMatchAgainstRecords() =
        let mario = { Name = "Mario"; Occupation = "Plumber"; }
        let luigi = { Name = "Luigi"; Occupation = "Plumber"; }
        let bowser = { Name = "Bowser"; Occupation = "Kidnapper"; }

        let determineSide character =
            match character with
            | { Occupation = "Plumber" } -> "good guy"
            | _ -> "bad guy"

        AssertEquality (determineSide mario) __
        AssertEquality (determineSide luigi) __
        AssertEquality (determineSide bowser) __
