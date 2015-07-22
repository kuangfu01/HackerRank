let primes = [|2;3;5;7;11;13;17;19;23;29;31;37;41;43;47;53;59;61;67;71;73;79;83;89;97|]
let NN = 25

let 

let factors (n : int) (primes : int array) =
    let r = Array.zeroCreate (primes.Length)

    let rec loop (n : int) (idx : int) =
        if n = 1 then ()
        else
            let mutable 

[<EntryPoint>]
let main argv = 
    printfn "%A" argv
    0 // return an integer exit code
