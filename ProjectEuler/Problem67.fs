// By starting at the top of the triangle below and moving to adjacent 
// numbers on the row below, the maximum total from top to bottom is 23.
//
//    3
//   7 4
//  2 4 6
// 8 5 9 3
//
// That is, 3 + 7 + 4 + 9 = 23.
//
// Find the maximum total from top to bottom in triangle.txt 
// (right click and 'Save Link/Target As...'), a 15K text file containing 
// a triangle with one-hundred rows.
// Answer: 7273

module Problem67

open System.Collections.Generic;
open System
open System.IO

let Max a (b:int) =
    if a > b then a else b

let Find (pyramid:int[][]) =  
    let mutable i : int = pyramid.Length - 1
    while i > 0 do
        for j in [0..i-1] do
            pyramid.[i-1].[j] <- pyramid.[i-1].[j] + Max pyramid.[i].[j] pyramid.[i].[j+1]         
        i <- i - 1       
    pyramid.[0].[0]

let Convert arr =
    arr
    |> Array.map (fun a -> Int32.Parse(a))

let GetData = 
    let data = File.ReadAllLines(@"D:\My Dropbox\ProjectEuler\ProjectEuler\triangle.txt")
    data
    |> Array.map (fun a -> a.Split(' '))
    |> Array.map (fun b -> Convert b)
       

    

    