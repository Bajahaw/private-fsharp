module ValentinesDay

// DID: please define the 'Approval' discriminated union type
type Approval =
    | Yes
    | No
    | Maybe

// DID: please define the 'Cuisine' discriminated union type
type Cuisine =
    | Korean
    | Turkish

// DID: please define the 'Genre' discriminated union type
type Genre =
    | Crime
    | Horror
    | Romance
    | Thriller

// DID: please define the 'Activity' discriminated union type
type Activity =
    | BoardGame
    | Chill
    | Movie of Genre
    | Restaurant of Cuisine
    | Walk of int

let rateActivity (activity: Activity): Approval =
    match activity with
    | BoardGame -> No
    | Chill -> No
    | Movie Romance -> Yes
    | Restaurant Korean -> Yes
    | Restaurant Turkish -> Maybe
    | Walk dist when dist < 3 -> Yes
    | Walk dist when dist < 5 -> Maybe
    | _ -> No
