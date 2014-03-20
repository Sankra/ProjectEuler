// The sum of the squares of the first ten natural numbers is,
//      1^2 + 2^2 + ... + 10^2 = 385
// The square of the sum of the first ten natural numbers is,
//      (1 + 2 + ... + 10)^2 = 55^2 = 3025
// Hence the difference between the sum of the squares of the 
// first ten natural numbers and the square of the sum is 3025 - 385 = 2640.
//
// Find the difference between the sum of the squares of the first one hundred natural 
// numbers and the square of the sum.
// Answer: 25164150

module Problem6

let diff = 
    let mutable sumOfSquares : int = 0
    let mutable squareOfSum : int = 0
    for i = 1 to 100 do
        sumOfSquares <- sumOfSquares + i*i
        squareOfSum <- squareOfSum + i
    squareOfSum * squareOfSum - sumOfSquares