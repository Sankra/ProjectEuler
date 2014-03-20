// 2^15 = 32768 and the sum of its digits is 3 + 2 + 7 + 6 + 8 = 26.
//
// What is the sum of the digits of the number 2^1000?
// Answer: 1366

module Problem16

open System.Numerics
open System

let num = 
    let mutable number : BigInteger = 2I
    for i = 2 to 1000 do
        number <- number * 2I
    let digits = number.ToString().ToCharArray()
    digits
    |> Seq.map (fun c -> Int32.Parse(c.ToString()))
    |> Seq.sum
        
