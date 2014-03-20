// The following iterative sequence is defined for the set of positive integers:
//
// n -> n/2 (n is even)
// n -> 3n + 1 (n is odd)
//
// Using the rule above and starting with 13, we generate the following sequence:
//
// 13 -> 40 -> 20 -> 10 -> 5 -> 16 -> 8 -> 4 -> 2 -> 1
//
// It can be seen that this sequence (starting at 13 and finishing at 1) contains
// 10 terms. Although it has not been proved yet (Collatz Problem), 
// it is thought that all starting numbers finish at 1.
//
// Which starting number, under one million, produces the longest chain?
//
// NOTE: Once the chain starts the terms are allowed to go above one million.
// Answer: 837799

module Problem14

let even x = x % 2L = 0L

let mutable steps : int64 = 0L

let rec gen n =
    steps <- steps + 1L
    if even n then gen (n / 2L)
    else if n <> 1L then gen (3L * n + 1L)
    else steps

let num = 
    let mutable max : int64 = 0L
    let mutable n : int = 0
    for i = 1 to 1000000 do
        steps <- 0L
        let current = gen ((int64)i)
        if current > max then
            max <- current
            n <- i
    n

