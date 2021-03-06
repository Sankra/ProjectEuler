﻿// The sequence of triangle numbers is generated by adding the natural numbers. So the 7th triangle number would be 1 + 2 + 3 + 4 + 5 + 6 + 7 = 28. The first ten terms would be:
// 1, 3, 6, 10, 15, 21, 28, 36, 45, 55, ...
// Let us list the factors of the first seven triangle numbers:
//
//  1: 1
//  3: 1,3
//  6: 1,2,3,6
// 10: 1,2,5,10
// 15: 1,3,5,15
// 21: 1,3,7,21
// 28: 1,2,4,7,14,28
// We can see that 28 is the first triangle number to have over five divisors.
//
// What is the value of the first triangle number to have over five hundred divisors?
// Answer: 76576500

module Problem12

open System.Collections.Generic

let Divisors n =
    let divs : HashSet<int> = new HashSet<int>()
    ignore(divs.Add(1))
    ignore(divs.Add(n))
    let mutable limit : int = n/2
    let mutable num : int = 2
    while num <= limit do
        if n % num = 0 then
            if divs.Contains(num) = false then
                ignore(divs.Add(num))
            limit <- n/num
            if divs.Contains(limit) = false then
                ignore(divs.Add(limit))
        num <- num + 1
    divs.Count
    
let Find =
    let mutable n : int = 1
    let mutable num : int = 0
    while Divisors num <= 500 do
        num <- num + n
        n <- n + 1
    num

