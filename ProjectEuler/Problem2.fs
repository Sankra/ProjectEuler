﻿// Each new term in the Fibonacci sequence is generated by 
// adding the previous two terms.
// By starting with 1 and 2, the first 10 terms will be:
// 1, 2, 3, 5, 8, 13, 21, 34, 55, 89, ...
//
// Find the sum of all the even-valued terms in the sequence
// which do not exceed four million.
// Answer: 4613732

module Problem2

let limit = 4000000

let rec Fib x =
    if x < 2 then 1
    else Fib (x-1) + Fib (x-2)

let Even x = x % 2 = 0

let Sum =
    let mutable value : int = 0
    let mutable counter : int = 0
    let mutable sum : int = 0
    while value < limit do
        value <- Fib counter
        if Even value then
            sum <- value + sum
        counter <- 1 + counter
    sum
