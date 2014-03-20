// The series, 1^1 + 2^2 + 3^3 + ... + 10^10 = 10405071317.
//
// Find the last ten digits of the series, 1^1 + 2^2 + 3^3 + ... + 1000^1000.
// Answer: 9110846700

module Problem48

open System.Numerics

let sum n =
    let seq = [1I..n]
    seq
    |> Seq.map (fun x -> BigInteger.Pow(x, (int)x))
    |> Seq.sum

let lastTenDigits n =
    let num = sum n
    let nums = num.ToString()
    let digits = nums.Substring(nums.Length - 10)
    digits