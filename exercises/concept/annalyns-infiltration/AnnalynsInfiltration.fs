module AnnalynsInfiltration

let canFastAttack (knightIsAwake: bool): bool =
    not knightIsAwake

let canSpy (knightIsAwake: bool) (archerIsAwake: bool) (prisonerIsAwake: bool): bool =
    prisonerIsAwake || knightIsAwake || archerIsAwake

let canSignalPrisoner (archerIsAwake: bool) (prisonerIsAwake: bool): bool =
    not archerIsAwake && prisonerIsAwake

let canFreePrisoner (knightIsAwake: bool) (archerIsAwake: bool) (prisonerIsAwake: bool) (petDogIsPresent: bool): bool =
    (petDogIsPresent && not archerIsAwake) ||
    (not knightIsAwake && not archerIsAwake && prisonerIsAwake) 
