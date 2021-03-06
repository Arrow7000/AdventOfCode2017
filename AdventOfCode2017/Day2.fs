﻿// http://adventofcode.com/2017/day/2

module Day2

open Commons

let rowDiff (row : int list) =
    (List.max row) - (List.min row) |> abs

let rowToInts (row : string) =
    row
    |> strSplit '\t'
    |> List.map int

let rows = 
    "day2.tsv"
    |> getLines
    |> List.map rowToInts

let main = 
    rows
    |> List.sumBy rowDiff


let divideEachOther a b =
    if a = b then None else

    let fA = float a
    let fB = float b
    let right = fA / fB
    let left = fB / fA
    let rightInt = floor right
    let leftInt = floor left
    let intSome = int >> Some
    if rightInt = right then
        intSome <| rightInt
    else if leftInt = left then
        intSome <| leftInt
    else None

let divideDivisibles row =
    List.allPairs row row
    |> List.choose (fun (a, b) -> divideEachOther a b)
    |> List.item 0

let part2 = 
    rows
    |> List.sumBy divideDivisibles
