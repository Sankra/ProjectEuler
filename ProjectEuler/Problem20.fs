// n! means n * (n  1) * ... * 3 * 2 * 1
//
// Find the sum of the digits in the number 100!
// Answer: 648

module Problem20

open System.Numerics
open System

let rec factorial x = 
    if x = 1I then
        1I
    else
        x * factorial (x - 1I)

let num = 
    let number = factorial 100I
    let digits = number.ToString().ToCharArray()
    digits
    |> Seq.map (fun c -> Int32.Parse(c.ToString()))
    |> Seq.sum