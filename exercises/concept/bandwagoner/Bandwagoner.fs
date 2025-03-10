module Bandwagoner

// DID: please define the 'Coach' record type
type Coach =
   {
      Name: string
      FormerPlayer: bool
   }

// DID: please define the 'Stats' record type
type Stats =
   {
      Wins: int
      Losses: int
   }

// DID: please define the 'Team' record type
type Team =
   {
      Name: string
      Coach: Coach
      Stats: Stats
   }

let createCoach (name: string) (formerPlayer: bool): Coach =
    let Coach: Coach =
       {
         Name = name
         FormerPlayer = formerPlayer
       }
    Coach
let createStats(wins: int) (losses: int): Stats =
   { Wins = wins; Losses = losses }

let createTeam(name: string) (coach: Coach)(stats: Stats): Team =
  {
      Name = name
      Coach = coach
      Stats = stats
  }

let replaceCoach(team: Team) (coach: Coach): Team =
   { team with Coach = coach }
   
let isSameTeam(homeTeam: Team) (awayTeam: Team): bool =
   homeTeam.Equals awayTeam

let rootForTeam(team: Team): bool =
   match team with
   | team when team.Name = "Chicago Bulls" -> true
   | team when team.Coach.Name = "Gregg Popovich" || team.Coach.FormerPlayer -> true
   | team when team.Stats.Wins >= 60 || team.Stats.Losses > team.Stats.Wins -> true
   | _ -> false
