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

let listMap() =
    let single_list = [1;2;3;]
    let list_double = List.map (fun x -> x * 2) single_list
    Console.WriteLine($"single list = {single_list}, double list = {list_double}")
listMap()

let pipeline() =
    [5;6;7;8]
    |> List.filter(fun v -> v % 2 = 0)
    |> List.map(fun v -> v * 2)
    |> Console.WriteLine
pipeline()

let func_chaining =
    let add_num x = x + 2
    let mul_num x = x * 3
    let add_mul = add_num >> mul_num
    let mul_add = add_num << mul_num
    Console.WriteLine($"add_mul(3) = {add_mul 3}, mul_add (3) = {mul_add 3}")
func_chaining

let _ = Console.ReadLine()