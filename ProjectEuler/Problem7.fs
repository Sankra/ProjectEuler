// By listing the first six prime numbers: 2, 3, 5, 7, 11, and 13, 
// we can see that the 6th prime is 13.
//
// What is the 10001st prime number?
// Answer: 104743

module Problem7

let isPrime (x:int64) =
    x > 1L &&
    not(Seq.exists (fun n -> x % n = 0L) {2L..int64(sqrt (float x))})

let getNthPrime n = 
    let mutable count : int = 0
    let mutable run : bool = true
    let mutable num : int64 = 0L
    while run do
        num <- num + 1L
        if isPrime num then
            count <- count + 1
            if count = n then
                run <- false
    num