module TisburyTreasureHunt

open System
open FsUnit.Xunit

let getCoordinate (line: string * string): string =
    snd line

let convertCoordinate (coordinate: string): int * char = 
    Int32.Parse(string coordinate[0]), coordinate[1]

let mid (_,c,_) = c

let compareRecords (azarasData: string * string) (ruisData: string * (int * char) * string) : bool = 
    convertCoordinate (snd azarasData) = mid ruisData

let createRecord (azarasData: string * string) (ruisData: string * (int * char) * string) : (string * string * string * string) =
    let (a, _, c) = ruisData
    let (d, e) = azarasData
    match e with
    | e when convertCoordinate e = mid ruisData -> (e , a, c, d)
    | _ -> ("", "", "", "")
