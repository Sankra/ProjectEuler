// The prime factors of 13195 are 5, 7, 13 and 29.
//
// What is the largest prime factor of the number 600851475143 ?
// Answer: 6857

module Problem3

let num = 600851475143L
let isFactor (n:int64) (i:int64) = n % i = 0L;
let isPrime (x:int64) =
    x > 1L &&
    not(Seq.exists (fun n -> x % n = 0L) {2L..int64(sqrt (float x))})

let LargestPrimeFactor (num:int64) = 
    let mutable maxFactor : int64 = int64(sqrt (float num)) + 1L
    let mutable max : int64 = 0L;
    let mutable work : bool = true
    while work do
        if isFactor num maxFactor then
            if isPrime maxFactor then
                max <- maxFactor
                work <- false
        maxFactor <- maxFactor - 1L
    max
            


