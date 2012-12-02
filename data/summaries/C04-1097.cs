Divide by the total number of daughters: () /D m daughters C= This metric is like the “Generation Tree Accuracy” metric of Bangalore & Rambow (2000), except that there is no need to consider cross-constituent moves.
C00-1007
Amalgam generates sentence strings from abstract predicate-argument structures (Figure 1), using a pipeline of stages, many of which employ machine-learned models to predict where to perform specific linguistic operations based on the linguistic context (Corston-Oliver et al., 2002; Gamon et al., 2002a, 2002b; Smets et al., 2003).
E03-1006 P02-1004
In some systems, establishing order during the sentence realization stage of natural language generation has been accomplished by hand-crafted generation grammars in the past (see for example, Aikawa et al.(2001) and Reiter and Dale (2000)).
W01-0808
Experiments by Daumé et al (2002) and the parsing work of Charniak (2000) and others indicate that further lexicalization may yield some additional improvements for ordering.
A00-2018
Label heads, according to Charniak’s head labeling rules (Charniak, 2000) C.
A00-2018
The Fergus system (Bangalore and Rambow, 2000) employs a statistical tree model to select probable trees and a word n-gram model to rank the string candidates generated from the best trees.
C00-1007
However, the parsing results of Klein & Manning (2003) involving unlexicalized grammars suggest that gains may be limited.
P03-1054
As an extension to model Type 1, we include features computed by the following functions on the set i α of daughters of C already ordered (see Figure 2): • Number of daughters already ordered (size of i α ) • Number of daughters in i α having a particular label for each of the possible constituent labels {NP, AUXP, VP, etc.} (24 for German, 23 for French) We denote that set of features in shorthand as () i f α . With this extension, a model of Markov 3 A “Markov grammar” is a model of constituent structure that starts at the root of the tree and assigns probability to the expansion of a non-terminal one daughter at a time, rather than as entire productions (Charniak, 1997 & 2000).
A00-2018
