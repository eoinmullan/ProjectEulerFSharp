module Problem001

let isMultipleOf3Or5 x =
    match x with
    | x when x % 3 = 0 -> true
    | x when x % 5 = 0 -> true
    | _                -> false

let answer =
    [1..999]
    |> List.filter isMultipleOf3Or5
    |> List.sum