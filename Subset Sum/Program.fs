// https://www.hackerrank.com/challenges/subset-sum
open System

let find (a : uint64 array) (s : uint64) =
    
    let mutable l = 0
    let mutable r = a.Length

    while l < r do
        let m = l + ((r-l) >>> 1)
        if a.[m] < s then l <- m + 1 else r <- m

    if l < a.Length then l + 1 else -1

[<EntryPoint>]
let main argv = 
    let n = Console.ReadLine() |> int
    let a = Console.ReadLine().Split(' ') |> Array.map uint64 |> Array.sortWith (fun x y  -> (int (y - x))) 

    for i in 1..a.Length-1 do
        a.[i] <- a.[i-1] + a.[i]

    let t = Console.ReadLine() |> int

    let curriedFind = find a

    for i in 1..t do
        Console.ReadLine() |> uint64 |> curriedFind |> printfn "%d"

    0
