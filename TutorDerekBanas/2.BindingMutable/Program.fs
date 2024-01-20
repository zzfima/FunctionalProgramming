open System

let bind_stuff = 
    let mutable weight = 1
    weight <- 2
    Console.WriteLine($"Weight = {weight}")

    let change_me = ref 3
    change_me := 4
    Console.WriteLine($"change_me = {!change_me}")
    Console.WriteLine($"change_me = {change_me.Value}")


let _ = Console.ReadLine()