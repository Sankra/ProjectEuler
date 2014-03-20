// The sum of the primes below 10 is 2 + 3 + 5 + 7 = 17.
//
// Find the sum of all the primes below two million.
// Answer: 142913828922
module Problem10

open System.Collections.Generic;

let isPrime (x:int64) =
    x > 1L &&
    not(Seq.exists (fun n -> x % n = 0L) {2L..int64(sqrt (float x))})

let sum list =
    list
    |> Seq.filter isPrime
    |> Seq.sum

let sieve n =
    let maxNum = (int) (((float) n)/log ((float) n))
    let primes = new List<int64>(maxNum);
    primes.Add(2L);
    primes.Add(3L);
    let mutable run : bool = true
    let mutable num : int64 = 5L
    while run do
        let mutable innerLoop : bool = true
        let mutable i : int = 0
        while i < primes.Count && innerLoop do
            if num % primes.[i] = 0L then
                innerLoop <- false
            i <- i + 1
        if innerLoop then
            primes.Add(num)
        num <- num + 2L
        if num > n then
            run <- false
    primes

let sum2 n = 
    sieve n
    |> Seq.sum