// A palindromic number reads the same both ways. 
// The largest palindrome made from the product of two 2-digit numbers is 9009 = 91 * 99.
//
// Find the largest palindrome made from the product of two 3-digit numbers.
// Answer: 906609

module Problem4

let isPalindrome (num : string) =    
    num.Length = 6 && num.Chars 0 = num.Chars 5 && num.Chars 1 = num.Chars 4 && num.Chars 2 = num.Chars 3

let getPalindrome =
    let mutable max : int = 0
    for i = 100 to 999 do
        for j = 100 to 999 do
            let current = i*j
            let str = current.ToString()
            if isPalindrome str && current > max then
                max <- current
    max

