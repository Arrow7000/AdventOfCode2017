﻿// http://adventofcode.com/2017

[<EntryPoint>]
let main argv = 
    Day1.main |> printf "Day 1: %i\n"
    Day2.main |> printf "Day 2: %i\n"
    Day2.part2 |> printf "Day 2 part 2: %i\n"
    Day3.main |> printf "Day 3: %i\n"
    Day4.main |> printf "Day 4: %i\n"
    Day4.part2 |> printf "Day 4 part 2: %i\n"

    System.Console.ReadLine() |> ignore
    0
