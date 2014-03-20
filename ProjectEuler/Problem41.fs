// We shall say that an n-digit number is pandigital if it makes use
// of all the digits 1 to n exactly once. For example, 2143 is a 
// 4-digit pandigital and is also prime.
//
// What is the largest n-digit pandigital prime that exists?
// Answer: 7652413

module Problem41

#if INTERACTIVE
#r "System.Core"
#endif

open System
open System.Linq

let FindPrimes max =
    let limit = (int) (sqrt (float max))
    let rec PrimeGen numbers =
        match numbers with
        | [] -> []
        | head :: tail when head > limit -> head :: tail
        | head :: tail -> head :: PrimeGen(tail |> List.filter(fun x -> x % head <> 0))
    PrimeGen [2..max]   

let IsPandigital number =
    let digits = number.ToString().ToCharArray() |> Seq.map (fun c -> Int32.Parse((string)c))    
    let mutable found : bool = true    
    for i = 1 to digits.Count() do
        found <- digits.Contains(i) && found
    found
    
let Find = 
    let primes = FindPrimes 13000000
    let mutable run : bool = true
    let mutable i : int = primes.Count() - 1
    printfn "%i" primes.[primes.Count() - 1]
    while run && i > -1 do
        if IsPandigital primes.[i] then
            run <- false  
        else
            i <- i - 1
    primes.[i]