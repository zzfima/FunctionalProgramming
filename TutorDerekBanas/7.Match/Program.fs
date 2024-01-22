open System

let print_age (age: int): string = 
    match age with
    | age when age < 5 -> "Preschool"
    | 5 -> "Kindergarten"
    | age when ((age > 5) && (age <= 18)) -> $"Grade is {age - 5}"
    | _ -> "College"

[1;11;33] |> List.iter(fun a -> Console.WriteLine(print_age(a)))

Console.ReadLine() |> ignore