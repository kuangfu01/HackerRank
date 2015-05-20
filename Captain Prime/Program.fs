// https://www.hackerrank.com/challenges/captain-prime
open System

let sieve n =
    let a : bool array = Array.create (n+1) true
    a.[0] <- false
    a.[1] <- false
    let top = n |> float |> Math.Sqrt |> int
    let mutable i = 2

    while i < top do
        if a.[i] then
            for j in (i+i)..i..n do
                 a.[j] <- false
        i <- i+1
    a

let primes = pown 10 6 |> sieve

let (|IsPrime|) (s : string) = primes.[s |> int]

let rec all (next : string -> string) (s : string) = 
    match s with
    | "" -> true
    | IsPrime false -> false
    | _ -> all next (next s) 

let right = fun (s : string) -> s.[0..s.Length-2]
let left = fun (s : string) -> s.[1..s.Length-1]

[<EntryPoint>]
let main argv = 
    let t = Console.ReadLine() |> int

    for i in 1..t do
        let id = Console.ReadLine() 

        if id.Contains "0" then
            printfn "DEAD"
        else
            match (all left id , all right id) with
            | (true, true)  -> printfn "CENTRAL"
            | (true, false) -> printfn "LEFT"
            | (false, true) -> printfn "RIGHT"
            | _             -> printfn "DEAD"
    0
