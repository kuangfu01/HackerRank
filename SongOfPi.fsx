open System

let PI = [3;1;4;1;5;9;2;6;5;3;5;8;9;7;9;3;2;3;8;4;6;2;6;4;3;3;8;3;3]

let rec check (words : string list) (pi : int list) : bool =
  match (words, pi) with
    | [], _ -> true
    | w::wx, p::px when w.Length = p -> check wx px
    | _ -> false

let t = Console.ReadLine() |> int

for i in 1..t do
  let words = Console.ReadLine().Split(' ') |> Array.toList
  
  if check words PI then
    printfn "It's a pi song."
  else
    printfn "It's not a pi song."
