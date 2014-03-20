// Let d(n) be defined as the sum of proper divisors of n 
// (numbers less than n which divide evenly into n).
// If d(a) = b and d(b) = a, where a != b, then a and b are an 
// amicable pair and each of a and b are called amicable numbers.
//
// For example, the proper divisors of 220 are 1, 2, 4, 5, 10, 
// 11, 20, 22, 44, 55 and 110; therefore d(220) = 284. The proper 
// divisors of 284 are 1, 2, 4, 71 and 142; so d(284) = 220.
//
// Evaluate the sum of all the amicable numbers under 10000.

module Problem21

let sumOfDivisors n =
    let mutable sum : int = 0
    for i = 1 to n-1 do
        if n % i = 0 then
            sum <- sum + i
    sum

let sum limit = 
    let mutable sum : int = 0
    for a = 2 to limit-1 do
        let d_a = sumOfDivisors a
        let dd_a = sumOfDivisors d_a
        if  dd_a = a && d_a <> a then
            sum <- sum + a 
    sum

