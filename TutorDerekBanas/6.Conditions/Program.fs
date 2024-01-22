open System

let print_age age = 
    if age < 5 then
        Console.WriteLine("Preschool")
    elif age = 5 then
        Console.WriteLine("Kindergarten")
    elif ((age > 5) && (age <= 18))  then
        Console.WriteLine($"Grade is {age - 5}")
    else
        Console.WriteLine("College")

[1;11;33] |> List.iter(fun a -> print_age(a))

Console.ReadLine() |> ignore