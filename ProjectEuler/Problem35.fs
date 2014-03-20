//The number, 197, is called a circular prime because all 
// rotations of the digits: 197, 971, and 719, are themselves prime.
//
// There are thirteen such primes below 100: 2, 3, 5, 7, 11, 13, 17, 31, 37, 71, 73, 79, and 97.
//
// How many circular primes are there below one million?
// Answer: 55

module Problem35

#if INTERACTIVE
#r "System.Core"
#endif

open System
open System.Diagnostics
open System.Collections.Generic

let FindPrimes max =
    let limit = (int) (sqrt (float max))
    let rec PrimeGen numbers =
        match numbers with
        | [] -> []
        | head :: tail when head > limit -> head :: tail
        | head :: tail -> head :: PrimeGen(tail |> List.filter(fun x -> x % head <> 0))
    PrimeGen [2..max]  

let circle (s : string) = s.Substring(1) + s.Substring(0,1)

let Find max = 
    let p = FindPrimes max
    let hashSet = new HashSet<string>()
    for n in p do
        hashSet.Add(n.ToString()) |> ignore
    let isSircle (num : int) =
        let mutable s = num.ToString() : string
        let mutable allPrime = true : bool
        let mutable i = 0 : int
        while allPrime && i < s.Length do
            s <- circle s
            allPrime <- hashSet.Contains(s)
            i <- i + 1
        allPrime
    let circles = p |> Seq.filter isSircle |> Seq.toArray 
    circles.Length
