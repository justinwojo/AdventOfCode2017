# AdventOfCode2017
Housing locations of C# solutions to Advent of Code 2017
www.adventofcode.com/

## Day 1
#### Part 1
Find the sum of all digits that match the next digit in the list. The list is circular, so the digit after the last digit is the first digit in the list.

#### Part 2
Instead of considering the next digit, it wants you to consider the digit halfway around the circular list.

## Day 2
#### Part 1
Calculate the spreadsheet's checksum. For each row, determine the difference between the largest value and the smallest value; the checksum is the sum of all of these differences.

#### Part 2
Find the only two numbers in each row where one evenly divides the other - that is, where the result of the division operation is a whole number. They would like you to find those numbers on each line, divide them, and add up each line's result.

## Day 3
#### Part 1
Get the manhatten distance of the input given a spiral model as so:  

|    |    |    |    |    |
|----|----|----|----|----|
| 17 | 16 | 15 | 14 | 13 |
| 18 | 5  | 4  | 3  | 12 |
| 19 | 6  | 1  | 2  | 11 |
| 20 | 7  | 8  | 9  | 10 |
| 21 | 22 | 23 | 24 | 25 |

#### Part 2
Store the sum of all adjacent squares following the same spiral pattern in part 1  

|     |     |     |     |     |
|-----|-----|-----|-----|-----|
| 147 | 142 | 133 | 122 | 59  |
| 304 | 5   | 4   | 2   | 57  |
| 330 | 10  | 1   | 1   | 54  |
| 351 | 11  | 23  | 25  | 26  |
| 362 | 747 | 806 | --> | ... |

## Day 4
#### Part 1
A passphrase consists of a series of words (lowercase letters) separated by spaces. To ensure security, a valid passphrase must contain no duplicate words. How many passcodes are valid?

#### Part 2
The passphrase's security now doesn't accept anagrams instead of just duplicates. How many passphrases are valid that contain no anagrams? (Anagram = cat, act, tac, ...)

## Day 5
#### Part 1
Given a list of numbers starting at the first number, move your position in the list by the number at that spot and then increase that first number by 1.
So if the list was 1,2,3.. Start at 1, move right 1 to 2, but increase 1 to 2. Return the amount of steps you've gone until you're outside of the list.

#### Part 2
Same as part 1 except if the number at the spot is 3 or greater, minus that number by 1. If its 2 or less, still add 1.

## Day 6
#### Part 1
Given a list of numbers, find the memory bank with the most blocks (ties won by the lowest-numbered memory bank) and redistribute those blocks among the banks. To do this, remove all of the blocks from the selected bank, then move to the next (by index) memory bank and insert one of the blocks. Continue doing this until it runs out of blocks; if it reaches the last memory bank, wrap around to the first one.

The debugger would like to know how many redistributions can be done before a blocks-in-banks configuration is produced that has been seen before.

#### Part 2
Find the distance between the repeated memory banks (how many times between first occurance and next occurance).

## Day 7
#### Part 1
TBD

#### Part 2
TBD

## Day 8
#### Part 1
TBD

#### Part 2
TBD

## Day 9
#### Part 1
TBD

#### Part 2
TBD

## Day 10
#### Part 1
TBD

#### Part 2
TBD
