open System

let str1 = "This is a random string"
let str2 = "this is a random string"
Console.WriteLine($"Length is {String.length str1}")
Console.WriteLine($"""letter at index 1 is "{str1[1]}" """)
Console.WriteLine($"""0..3 letters are "{str1[0..3]}" """)

let comma_str = String.collect(fun c -> String.Format($"{c}, ")) "commas"
Console.WriteLine($"Comma: {comma_str}")

Console.WriteLine($"Any one is an uppercase in string {str1}? {String.exists(fun c -> Char.IsUpper(c)) str1}")
Console.WriteLine($"Any one is an uppercase in string {str2}? {String.exists(fun c -> Char.IsUpper(c)) str2}")

let digits_str = "2354534"
let digits_and_letters_str = "23f54h5g34"
Console.WriteLine($"All of characters are digits in {digits_str}? {String.forall(fun c -> Char.IsDigit(c)) digits_str}")
Console.WriteLine($"All of characters are digits in {digits_and_letters_str}? {String.forall(fun c -> Char.IsDigit(c)) digits_and_letters_str}")
Console.WriteLine($"Any of characters are digits in {digits_and_letters_str}? {String.exists(fun c -> Char.IsDigit(c)) digits_and_letters_str}")

let str3 = String.init 10 (fun i -> i.ToString())
Console.WriteLine($"str3 {str3}")

String.iter(fun c -> Console.Write($"_{c}")) "Print Me!"

Console.ReadLine() |> ignore