open System

let print_age age = 
    if age < 10 then
        Console.WriteLine("is a kid")
    elif age < 24 then
        Console.WriteLine("is a young")
    else
        Console.WriteLine("is a big")

[1;11;33] |> List.iter(fun a -> print_age(a))

Console.ReadLine() |> ignore