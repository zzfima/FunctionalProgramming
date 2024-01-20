open System

let hello = 
    printfn "please enter your name"
    let name = Console.ReadLine()
    printfn $"hello, {name}!"

    printfn $"PI = %.4f{Math.PI}"
    printfn $"PI = %.10f{Math.PI}"
    printfn $"PI = %M{(decimal)Math.PI}"
    let big_pi = 3.141592653589793238462643383M
    printfn $"PI = %M{big_pi}"

hello
Console.ReadLine() |> ignore