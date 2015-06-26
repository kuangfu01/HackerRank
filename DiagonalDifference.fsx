open System

let n = Console.ReadLine() |> int

let rec scan i (first : int) second =
    if i > n then Math.Abs(first - second)
    else
        let nums = Console.ReadLine().Split(' ') |> Array.map int
        scan (i+1) (first + nums.[i-1]) (second + nums.[n-i])

printfn "%d" (scan 1 0 0)

