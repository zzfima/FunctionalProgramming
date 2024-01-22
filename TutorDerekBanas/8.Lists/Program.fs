open System

let list_stuff = 
    let list1 = [1..4]
    Console.WriteLine(list1)

    list1 |> List.iter(fun v -> Console.Write(v))
    Console.WriteLine()

    list1 |> List.iter(Console.Write)
    Console.WriteLine()

    let list2 = 5::6::7::[]
    Console.WriteLine(list2)

    ['a'..'e'] |> List.iter(Console.Write)
    Console.WriteLine()

    let list3 = List.init 5 (fun i -> i * 2)
    list3 |> List.iter(Console.Write)
    Console.WriteLine()



list_stuff

Console.ReadLine() |> ignore