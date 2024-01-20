open System

let do_func() =
    let sum (a, b) =  
        a + b
    Console.WriteLine($"5 + 4 = {sum(5, 4)}")
do_func()

let rec factorial x =
    if x < 1 then 1
    else x * factorial(x - 1)

Console.WriteLine($"factorial(5) = {factorial 5}")

let _ = Console.ReadLine()