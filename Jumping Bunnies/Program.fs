// https://www.hackerrank.com/challenges/jumping-bunnies
open System

let rec gcd (x:uint64) (y:uint64) : uint64 =
    let min = Math.Min(x, y)
    let max = Math.Max(x, y)
    
    if (max % min = 0UL) then min
    else gcd min (max % min)    

let lcm (list : uint64 list) =
    match list with
    | [] -> failwith "Use your brain !"
    | [e] -> e
    | x :: xs -> 
        let rec loop l acc =
            match l with
            | [] -> acc
            | x :: xs -> 
                let t = gcd x acc
                loop xs (acc / t * x)
        loop xs x


[<EntryPoint>]
let main argv = 
    Console.In.ReadLine() |> ignore
    
    Console.In.ReadLine().Split(' ') 
    |> Array.toList 
    |> List.map uint64
    |> lcm
    |> printfn "%d"
    
    0 