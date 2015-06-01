// https://www.hackerrank.com/challenges/sequence-full-of-colors

open System

let rec judge r g y b list =
    match list with
    | [] -> if (r = g) && (y = b) then "True" else "False"
    | x :: xs ->
        match x with
        | 'R' when Math.Abs(r+1 - g) <= 1 -> judge (r+1) g y b xs
        | 'G' when Math.Abs(g+1 - r) <= 1 -> judge r (g+1) y b xs
        | 'Y' when Math.Abs(y+1 - b) <= 1 -> judge r g (y+1) b xs
        | 'B' when Math.Abs(b+1 - y) <= 1 -> judge r g y (b+1) xs
        | _ -> "False"

let explode (s:string) = [for c in s -> c]

[<EntryPoint>]
let main argv = 
    let f = judge 0 0 0 0

    let n = Console.ReadLine() |> int

    for i in 1..n do
        Console.ReadLine() |> explode |> f |> printfn "%s"

    0