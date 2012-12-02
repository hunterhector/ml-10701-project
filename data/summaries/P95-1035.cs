Even in (Beaven, 1992a), the derivation information is used simply to cache previous results to avoid exact recomputation at a later stage, not to improve on previous guesses.
C92-2091
Beaven. 1992a.
C92-2091
However, none of these approaches is guaranteed to avoid protracted search times if an exact answer is required, because bag generation is NPcomplete (Brew, 1992).
C92-2092
The Shake-an&Bake generation algorithm of (Whitelock, 1992) combines target language signs using the technique known as generate-and-test.
C92-2117
However, the Shake-and-Bake generation algorithm of (Whitelock, 1992) is NPcomplete.
C92-2117
Grammars The Shake-and-Bake system of (Whitelock, 1992) employs a bag generation algorithm because it is assumed that the input to the generator is no more than a collection of instantiated signs.
C92-2117
Lexicalist approaches to MT, particularly those incorporating the technique of Shake-and-Bake generation (Beaven, 1992a; Beaven, 1992b; Whitelock, 1994), combine the linguistic advantages of transfer (Arnold et al., 1988; Allegranza et al., 1991) and interlingual (Nirenburg et al., 1992; Dorr, 1993) approaches.
C92-2091
For example, (Beaven, 1992a) employs a chart to avoid recalculating the same combinations of signs more than once during testing, and (Popowich, 1994) proposes a more general technique for storing which rule applications have been attempted; (Brew, 1992) avoids certain pathological cases by employing global constraints on the solution space; researchers such as (Brown et al., 1990) and (Chen and Lee, 1994) provide a system for bag generation that is heuristically guided by probabilities.
C92-2091 C92-2092 J90-2002
We tested a TNCB-based generator in the SLEMaT MT system with the pathological cases described in (Brew, 1992) against Whitelock's original generation algorithm, and have obtained speed improvements of several orders of magnitude.
C92-2092
Beaven. 1992b.
C92-2091
