// Using names.txt (right click and 'Save Link/Target As...'), 
// a 46K text file containing over five-thousand first names, 
// begin by sorting it into alphabetical order. Then working 
// out the alphabetical value for each name, multiply this value 
// by its alphabetical position in the list to obtain a name score.
//
// For example, when the list is sorted into alphabetical order, COLIN, 
// which is worth 3 + 15 + 12 + 9 + 14 = 53, is the 938th name in the list. 
// So, COLIN would obtain a score of 938 * 53 = 49714.
//
// What is the total of all the name scores in the file?
// Answer: 871198282

module Problem22

open System.IO
open System.Numerics
open System.Collections.Generic

let path = @"C:\Users\roh\Documents\My Dropbox\ProjectEuler\Data\names.txt"
let content = File.ReadAllText(path)

let score = new Dictionary<char, int>()

let chars = ['a'..'z']

let mutable index = 0

while index < 26 do
    let num = index + 1
    score.Add(chars.Item(index), num);
    index <- num

let charScore char =
    score.[char]

let wordScore (word: string) = 
    let mutable sum : int = 0
    word
    |> Seq.fold (fun acc s -> acc + (charScore s)) 0

let mutable acc : int = 0

let computeScore (s:string) =
    acc <- acc + 1
    let small = s.ToLower()
    (wordScore small) * acc

let names =
    content.Split(',')
    |> Seq.map (fun s -> s.Trim('\"'))
    |> Seq.sort
    |> Seq.map (fun s -> computeScore s)
    |> Seq.sum