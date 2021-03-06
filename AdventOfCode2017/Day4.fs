﻿// http://adventofcode.com/2017/day/4

module Day4

open System.IO
open Commons

type Word = string
type Line = Word list

let lines : Line list = 
    getLines "day4.txt" 
    |> List.map ((fun str -> str.Split [|' '|]) >> Array.toList)

let uniqueWords (words : Line) = 
    new Set<string>(words) |> Set.toList 
    
let hasUniques (words : Line) = 
    words.Length = List.length (uniqueWords words)


let main = 
    lines
    |> List.filter hasUniques
    |> List.length


let getWordCharSet (word : Word) = new Set<char>(word)
let anagramUniqueWords (words : Word list) = List.distinctBy getWordCharSet words
let hasAnaUniqueWords (words: Word list) = List.length words = List.length (anagramUniqueWords words)

let hasAnagrams (lines : Line list) : Line list =
    lines |> List.filter hasAnaUniqueWords

let part2 = 
    lines
    |> hasAnagrams
    |> List.length