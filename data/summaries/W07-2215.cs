6) Johnson (1995) appears to have been the first to integrate memoization with a method for dealing with left recursion in pure top-down parsing.
J95-3005
Although Johnson (1995) also integrates a technique for dealing with left recursion with memoization, our method differs from Johnson’s O(n3) approach in the technique that we use to accommodate left recursion.
J95-3005
The problem of exponential time complexity in top-down parsers constructed as sets of mutuallyrecursive functions has been solved by Norvig (1991) who uses memotables to achieve polynomial complexity.
J91-1004
As in Norvig (1991) a memotable is constructed during recognition.
J91-1004
In particular: a) we make use of the length of the remaining input as does Kuno (1965), b) we keep a record of how many times each parser is applied to each input position in a way that is similar to the use of cancellation sets by Nederhof and Koster (1993), c) we integrate memoization with a technique for dealing with left recursion as does Johnson (1995), and d) we store “left-recursion counts” in the memotable, and encapsulate the memoization process in a programming construct called a monad, as suggested by Frost and Hafiz (2006).
J95-3005
This problem of grammar size has been solved by Moore (2000) who developed a method, based on a left-corner grammar transformation, which produces non-left recursive grammars that are not much larger than the originals.
A00-2033
