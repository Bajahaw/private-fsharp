module GuessingGame

let reply (guess: int): string =
    match guess - 42 with
    | 1 -> "So close"
    | -1 -> "So close"
    | b when b > 1 -> "Too high"
    | b when b < -1 -> "Too low"
    | _ -> "Correct"
    
