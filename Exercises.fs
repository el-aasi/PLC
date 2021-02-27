module Exercises

open System

//Ex 2.1 
let x = 23
let myName = "Bobby"
let age = 25
let country = "Canada"
let y = 6 + 6

let a = 5
let b = let a = 10 in a + 5
let c = a + b

//Ex 2.2 
let addNum1 x = x + 1
let addNum10 x = x + 10
let addNum20 x = (addNum10(0) * 2) + x

//Ex 2.3 
let max2 x y = if(x > y) then x else y
let evenOrOdd x = if(x % 2 = 0) then printf("Event Number\n") else printf("Odd Number\n") 
let addXY x y = printf($"First Number {x} \nSecond Number {y}\n Sum {x+y}\n") 

//Ex 2.4
let rec addNum_jk x y = 
    if y = 0 then x 
    else addNum10(0) + addNum_jk x (y-1)

//Ex 2a.1a
let vowelToUpper = function
    |vowel when vowel = 'a' -> 'A'
    |vowel when vowel = 'e' -> 'E'
    |vowel when vowel = 'i' -> 'I'
    |vowel when vowel = 'o' -> 'O'
    |vowel when vowel = 'u' -> 'U'
    |anyChar -> anyChar

// 2a.1b
let rec vowelToUpperInString (word : string) = 
    match (Seq.toList word) with 
    |[] -> ""
    |sHead::sTail -> string (vowelToUpper sHead) + vowelToUpperInString (new string (sTail|> List.toArray))

// 2a.2a
let rec plcLength someList = 
    match someList with
    | [] -> 0
    | lstHd::lstTail -> 1 + plcLength lstTail 

// 2a.2b
let rec plcSum (someIntList : list<int>) = 
    match someIntList with
    | [] -> 0
    | lstHead::lstTail -> lstHead + plcSum lstTail

// 2a.3
let rec takeSome numberOfElements listOfElements = 
    match numberOfElements, listOfElements with 
    | 0, [] -> []
    | n, head::tail when n > 0 -> [head] @ takeSome (n-1) tail

// 2a.4a
let rec pclFold fn initialValue someList =
    match someList with
    | [] -> initialValue
    | head::tail -> pclFold fn (fn initialValue head) tail

// 2a.4b
let rec plcSumWithFold (someIntList : list<int>) = 
    match someIntList with
    | [] -> 0
    | theList -> pclFold (+) 0 theList

// 2a.5a
let rec pclFoldBack fn initialValue someList =
    match someList with
    | [] -> initialValue
    | head::tail -> fn head (pclFoldBack fn initialValue tail)

// 2a.5b
let rec plcSumWithFoldBack (someIntList : list<int>) = 
    match someIntList with
    | [] -> 0
    | theList -> pclFoldBack (+) 0 theList

// 2a.6 
let rec plcIncList (someList : list<int>) = 
    match someList with
    | [] -> []
    | head::tail -> [head + 1] @ plcIncList tail

// 2a.7a
let rec plcMap fn someList = 
    match someList with
    | [] -> []
    | head::tail -> [fn head] @ plcMap fn tail

//2a.7b
let rec plcIncListWithMap (someList : list<int>) = plcMap (fun x -> x+1) someList

//2a.8a
let rec plcFilter fn someList =
    match someList with
    | [] -> []
    | head::tail -> if fn head then [head] @ plcFilter fn tail else plcFilter fn tail

//2a.8b
let plcEven number = if number % 2 = 0 then false else true

//Ex 3.1
let vowels = ['a';'e';'i';'o';'u']
let isVowel (someChar : char) = if vowels |> List.contains someChar then true else false
let countNumberOfVowels (someString : string) = List.fold(fun accumulator character -> accumulator + if isVowel character then 1 else 0) 0 (Seq.toList someString)

//Ex 3.2
//Check if the numbers are divisible
let isDivisible firstNumber secondNumber =
    secondNumber = firstNumber || secondNumber % firstNumber <> 0

//Remove all the numbers that are divisible with each other
let rec RemoveMultipliers firstListOfNumbers secondListOfNumbers = 
    match firstListOfNumbers with
    | [] -> secondListOfNumbers
    | head :: tail -> RemoveMultipliers tail (List.filter (isDivisible head) secondListOfNumbers)

//Get prime numbers up to
let primesUpTo number = RemoveMultipliers [2 .. number] [1 .. number]

//Ex 3.3 
let rec plcFib number = 
    match number with
    | n when n < 0 -> -1
    | 0 -> 0
    | 1 -> 1
    | m when m > 1 -> plcFib (number - 1) + plcFib(number - 2)

//Ex 3.4 
let doubleNum x = x * 2
let sqrNum x = x * x

let plcQuad x = doubleNum (doubleNum x)
let plcFourth x = sqrNum (sqrNum x)

//TEST
//Ex 1.a 
let myInfoTuple = (279910, "Gais El-AAsi", "Moldova")

//Ex 1.b 
let printTuple someTuple = 
    match someTuple with
    | (a,b,c) -> printfn $"Student Number: {a}\nName: {b}\nCountry: {c}"


let rec myStrLength (str : string) =
    match (Seq.toList str) with
    | [] -> 0
    | sHead::sTail -> 1 + myStrLength (new string [|for c in sTail -> c|])

let usingMapOnList someList = someList |> List.map(fun x-> x+1)