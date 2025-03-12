module SqueakyClean

open System

let transform (c: char) : string =
    match c with
    | '-' -> "_"
    | ' ' -> ""
    | c when Char.IsUpper c -> "-" + Char.ToString (Char.ToLower c) 
    | c when Char.IsDigit c -> ""
    | c when int c >= int 'α' && int c <= int 'ω' -> "?"
    | _ -> Char.ToString c
    
let clean (identifier: string): string =
    String.collect transform identifier