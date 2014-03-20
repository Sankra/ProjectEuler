// Surprisingly there are only three numbers that can be written
// as the sum of fourth powers of their digits:
//
// 1634 = 1^4 + 6^4 + 3^4 + 4^4
// 8208 = 8^4 + 2^4 + 0^4 + 8^4
// 9474 = 9^4 + 4^4 + 7^4 + 4^4
// As 1 = 1^4 is not a sum it is not included.
//
// The sum of these numbers is 1634 + 8208 + 9474 = 19316.
//
// Find the sum of all the numbers that can be written
// as the sum of fifth powers of their digits.
// Answer: 443839

module Problem30

#if INTERACTIVE
#r "FSharp.PowerPack.Parallel.Seq.dll"
#endif

open System
open Microsoft.FSharp.Collections

let digits num =
    let nums = num.ToString().ToCharArray()
    nums
    |> Seq.map (fun x -> Int32.Parse(x.ToString()))

let rdt5 num =
    digits num
    |> Seq.map (fun x -> Math.Pow((float)x, 5.0))
    |> Seq.sum

let sum limit = 
    let mutable sum : int = 0
    for i = 2 to limit do
        let s = rdt5 i
        if s = (float)i then
            sum <- sum + i
    sum