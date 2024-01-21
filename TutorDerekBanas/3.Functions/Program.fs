open System

let do_func() =
    let sum (a, b) =  
        a + b
    Console.WriteLine($"5 + 4 = {sum(5, 4)}")
do_func()

let rec factorial x =
    if x < 1 then 1
    else x * factorial(x - 1)
Console.WriteLine($"factorial(4) = {factorial 4}")

let lists() =
    let single_list = [1;2;3;]
    let list_double = List.map (fun x -> x * 2) single_list
    Console.WriteLine($"single list = {single_list}, double list = {list_double}")
lists()

let _ = Console.ReadLine()