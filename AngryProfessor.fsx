open System

let rec angry a k =
  if k = 0 then false
  else
    match a with
      | [] -> true
      | ha :: ta when ha <= 0 -> angry ta (k-1)
      | ha :: ta -> angry ta k  
  
  
let t = Console.ReadLine() |> int

for i in 1..t do
  let s = Console.ReadLine().Split(' ')
  let n = s.[0] |> int
  let k = s.[1] |> int
  let a = Console.ReadLine().Split(' ') |> Array.map int |> Array.toList

  printfn "%s" (if angry a k then "YES" else "NO")
