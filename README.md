# Balanced Brackets
This a TDD implementation of a bracket balancing helper which ensures all brackets in a file are balanced with opening and closing brackets.

## The Kata
Take an input string with X opening brackets [ and Y closing brackets ], in a random order.

Determine if the generated string of brackets is balanced, that is it consists of pairs of opening/closing brackets in the
correct order with no matched opening and closing pairs.

The kata has been structured to be simple, yet loosely guided. You will need to make decisions just like you were writing
code for production.

The examples are not meant to guide your implementation, they are there merely to give examples.
Do not worry about input other than brackets and empty string.

#### Examples
* (empty) OK
* [] OK
* [][] OK
* [[]] OK
* [[[][]]] OK
* ][ FAIL
* ][][ FAIL
* [][]][ FAIL

##### Credit
All credit goes to [Chillisoft](http://www.chillisoft.co.za/) who provided me with the Katas and the training to solve these problems.