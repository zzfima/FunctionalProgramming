open System

Console.WriteLine("a")
for i = 0 to 5 do
    Console.Write(i)
Console.WriteLine("")

Console.WriteLine("b")
for i = 5 downto 0 do
    Console.Write(i)
Console.WriteLine("")

Console.WriteLine("c")
for i in [1..10] do
    Console.Write(i)
Console.WriteLine("")

Console.WriteLine("d")
[1..10] |> List.iter (fun c -> Console.Write(c))
Console.WriteLine("")

Console.WriteLine("e")
[1..10] |> List.iter (Console.Write)
Console.WriteLine("")

Console.WriteLine("f")
let sum1 = List.reduce(+) [1..10]
Console.WriteLine($"Sum of [1..10] = {sum1}")
Console.WriteLine("")

Console.WriteLine("g")
let magic = "7"
let mutable answer = ""
while not (magic.Equals(answer)) do
    Console.WriteLine("Please, insert number")
    answer <- Console.ReadLine()
Console.WriteLine("Good!")
Console.WriteLine("")

Console.ReadLine() |> ignore