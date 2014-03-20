// The Fibonacci sequence is defined by the recurrence relation:
//
// Fn = Fn-1 + Fn-2, where F1 = 1 and F2 = 1.
// Hence the first 12 terms will be:
//
// F1 = 1
// F2 = 1
// F3 = 2
// F4 = 3
// F5 = 5
// F6 = 8
// F7 = 13
// F8 = 21
// F9 = 34
// F10 = 55
// F11 = 89
// F12 = 144
// The 12th term, F12, is the first term to contain three digits.
//
// What is the first term in the Fibonacci sequence to contain 1000 digits?
// Answer: 4782

module Problem25

open System.Collections.Generic
open System.Numerics

let fibs = new Dictionary<BigInteger, BigInteger>()

let rec fib n = 
    if fibs.ContainsKey(n) then
        fibs.[n]
    else if n <= 2I then
        1I
    else 
        let res = fib (n-1I) + fib (n-2I)
        fibs.Add(n, res)
        res

let firstTerm limit =
    let mutable run : bool = true
    let mutable n : BigInteger = 1I
    while run do
        let number = fib n
        let digits = number.ToString().ToCharArray().Length
        if digits = limit then
            run <- false
        else
            n <- n + 1I
    n