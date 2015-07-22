open System

let fac n : string =
    let rec loop n (acc : bigint) : bigint =
        match n with
        | 0 -> acc
        | n -> loop (n-1) (acc * (bigint n))
    
    loop n (bigint 1) |> string

[<EntryPoint>]
let main argv = 
    Console.ReadLine() |> int |> fac |> printfn "%s"
    0 
