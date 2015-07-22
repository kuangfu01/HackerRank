open System

let count (nums : int list) =
    let rec loop (es : int list) (p, n, z) =
        match es with
        | [] -> (p, n, z)
        | e :: ex ->
            if e > 0 then loop ex (p+1, n, z)
            elif e = 0 then loop ex (p, n, z+1)
            else loop ex (p, n+1, z)
            
    loop nums (0, 0, 0)
   

let n = Console.ReadLine() |> float
let ret = 
    Console.ReadLine().Split(' ')
    |> Array.map int 
    |> Array.toList
    |> count


let f = function
    | x -> x |> float |> (fun x -> x / n) |> printfn "%0.3f"
     
let a, b, c = ret

f a
f b
f c