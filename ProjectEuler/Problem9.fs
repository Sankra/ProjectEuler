// A Pythagorean triplet is a set of three natural numbers, a < b < c, for which,
//      a^2 + b^2 = c^2
// For example, 3^2 + 4^2 = 9 + 16 = 25 = 5^2.
//
// There exists exactly one Pythagorean triplet for which a + b + c = 1000.
// Find the product abc.
// Answer: 31875000

module Problem9

let sq x = x * x

let ab =
    let tuple = [ for a in 1 .. 500 do
                    for b in a .. 500 -> a,b ]
    tuple
    |> Seq.filter (fun (a,b) -> sq a + sq b = sq (1000 - a - b) ) 
    |> Seq.head

let answer =
    let a = fst ab
    let b = snd ab
    let c = 1000 - a - b
    a * b * c