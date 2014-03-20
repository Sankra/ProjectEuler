// The prime 41, can be written as the sum of six consecutive primes:
// 
// 41 = 2 + 3 + 5 + 7 + 11 + 13
//
// This is the longest sum of consecutive primes that adds 
// to a prime below one-hundred.
//
// The longest sum of consecutive primes below one-thousand 
// that adds to a prime, contains 21 terms, and is equal to 953.
//
// Which prime, below one-million, can be written as the 
// sum of the most consecutive primes?
// Answer: 997651

module Problem50

#if INTERACTIVE
#r "C:\\Users\\Sankra\\Projects\\ProjectEuler\\ProjectEulerCSharp\\bin\\Debug\\ProjectEulerCSharp.dll"
#endif

open System
open System.Linq
open ProjectEulerCSharp
 
let FindPrimes max =
    let limit = (int) (sqrt (float max))
    let rec PrimeGen numbers =
        match numbers with
        | [] -> []
        | head :: tail when head > limit -> head :: tail
        | head :: tail -> head :: PrimeGen(tail |> List.filter(fun x -> x % head <> 0))
    PrimeGen [2..max]    

let FindLongest3 max =
    let primes = FindPrimes max    
    Problem50.FindLongestSumOfConsecutivePrimes(max, primes.ToArray())

let FindLongest2 max =
    let primes = FindPrimes max    
    let mutable maxSum = 0 : int
    let mutable maxN = 0 : int
    for i = 0 to 7000 do
        printf "%i - " primes.[i]
        printf "%i - " maxSum
        printfn "%i" i
        for startIndex = 0 to i - 1 do
            let mutable sum = 0 : int
            let mutable n = 0 : int
            let mutable j = startIndex : int
            let mutable run = true : bool
            while run do
                if j < i - 1 then
                    sum <- sum + primes.[j]
                    n <- n + 1
                    if sum = primes.[i] then
                        run <- false
                        if n > maxN then
                            maxN <- n        
                            maxSum <- sum                
                    else if sum > primes.[i] then
                        run <- false
                    j <- j + 1
                else
                    run <- false
    maxSum
   
let FindLongest max =
    let primes = FindPrimes max    
    let mutable startIndex = 0 : int    
    let mutable maxSum = 0 : int
    let mutable maxN = 0 : int
    while startIndex < primes.Length do
        printfn "%i" startIndex
        let mutable sum = 0 : int
        let mutable n = 0 : int
        for i = startIndex to primes.Length - 1 do
            sum <- sum + primes.[i]
            if primes.Contains(sum) then
                if n > maxN then
                    maxN <- n        
                    maxSum <- sum                
            n <- n + 1
        startIndex <- startIndex + 1
    maxSum