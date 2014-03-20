// 2520 is the smallest number that can be divided by each 
// of the numbers from 1 to 10 without any remainder.
//
// What is the smallest number that is evenly divisible 
// by all of the numbers from 1 to 20?
// Answer: 232792560


module Problem5

let smallestNumber =
    let mutable smallet : int = 0
    let mutable divisable : int = 0
    let mutable run : bool = true
    let mutable runSmall : bool = true
    let mutable i : int = 0
    while run do
        divisable <- divisable + 380
        runSmall <- true
        i <- 1
        while runSmall && i <= 20 do
            if divisable % i = 0 then
                i <- i + 1
            else
                runSmall <- false
        if runSmall then
            run <- false
    divisable
            
