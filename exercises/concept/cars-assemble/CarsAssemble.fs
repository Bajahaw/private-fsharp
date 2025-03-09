module CarsAssemble

let successRate (speed: int): float =
    match speed with
    | 0 -> 0.0
    | s when s >= 1 && s < 5 -> 1.0
    | s when s >= 5 && s < 9 -> 0.9
    | 9 -> 0.8
    | _ -> 0.77

let productionRatePerHour (speed: int): float =
    float (speed * 221) * successRate speed

let workingItemsPerMinute (speed: int): int =
    int (productionRatePerHour speed) / 60
