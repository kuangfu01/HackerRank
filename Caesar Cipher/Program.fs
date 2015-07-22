open System

let rotateChar x = fun c k -> (int x + ((int c) - (int x) + k) % 26) |> char

let rotate c k =
  match c with
    | c when c >= 'a' && c <= 'z' -> (rotateChar 'a') c k
    | c when c >= 'A' && c <= 'Z' -> (rotateChar 'A') c k
    | _ -> c

[<EntryPoint>]
let main args =
    Console.ReadLine() |> ignore
    let chars = Console.ReadLine().ToCharArray()
    let k = Console.ReadLine() |> int

    let chars' = chars |> Array.map (fun x -> rotate x k) 
    new string(chars') |> printfn "%s"
    
    0