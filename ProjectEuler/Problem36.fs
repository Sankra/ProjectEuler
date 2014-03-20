// The decimal number, 585 = 1001001001_2 (binary), 
// is palindromic in both bases.
//
// Find the sum of all numbers, less than one million, '
// which are palindromic in base 10 and base 2.
// Answer: 872187

module Problem36

open System

let isPalindrome nums =
    nums = Array.rev nums 

let convertToBinaryList (n:int) = 
    System.Convert.ToString(n,2)
    |> Seq.map (fun c -> int c - int '0')
    |> Seq.toArray

let isPalindrome10and2 num =
    let chars = num.ToString().ToCharArray()
    if isPalindrome chars then 
        let bin = convertToBinaryList num
        isPalindrome bin
    else
        false

let Find =
    [1..999999]
    |> Seq.filter isPalindrome10and2
    |> Seq.sum


