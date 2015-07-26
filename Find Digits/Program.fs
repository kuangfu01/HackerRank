open System

let find num =
    let rec loop n acc =
        match n with
        | 0 -> acc
        | n -> 
            let d = n % 10
            if (d <> 0) && (num % d = 0) then 
                loop (n/10) (acc+1)
            else
                loop (n/10) acc
    loop num 0

let t = Console.ReadLine() |> int

for i in 1..t do
    Console.ReadLine() 
    |> int
    |> find
    |> printfn "%d"