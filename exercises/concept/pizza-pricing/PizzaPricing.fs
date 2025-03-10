module PizzaPricing

// DID: please define the 'Pizza' discriminated union type

type Pizza =
    | Margherita
    | Caprese
    | Formaggio
    | ExtraSauce of Pizza
    | ExtraToppings of Pizza

let rec pizzaPrice (pizza: Pizza): int =
    match pizza with
    | Margherita -> 7
    | Caprese -> 9
    | Formaggio -> 10
    | ExtraSauce pizza -> 1 + pizzaPrice pizza
    | ExtraToppings pizza -> 2 + pizzaPrice pizza
let orderPrice(pizzas: Pizza list): int =
    let rec total (acc: int) (pizzas: Pizza list): int =
        match pizzas with
        | head :: tail -> total (acc + pizzaPrice head) tail
        | [] -> acc
        
    let fee =
        match pizzas.Length with
        | 1 -> 3
        | 2 -> 2
        | _ -> 0
        
    total 0 pizzas + fee