Forthis we will use (Mohri, 1997)’s concept of the residual weight.
J97-2003
Data-Oriented Parsing (DOP)’s methodology is to calculate weighted derivations, but asnoted in(Bod,2003), itis thehighest ranking parse,notderivation,thatisdesired.
E03-1005
For example, let . Then two possible output transducer states could be and . Ifwechoose v thena valid vector pair q w is q, w . The sets v, v, and v are defined asfollows: v q w from v q . v q w from v q . v q w from v q . . v is the set of vector pairs q w constructed from v where each q is an input vector in atransition withlabel . v isthesetof unique transitions paired with the appropriate pair foreach q w in v . v isthesetofstates reachable fromthe transitions in v . The consideration of vectors of states on the incident edge of transitions effects two noticeable changes on the algorithm as it is presented in (Mohri, 1997).
J97-2003
Ittakes asinput abottom-up tree-to-weight transducer and returns as output a subsequential bottom-up tree-to-weight transducer suchthatthe tree language recognized by is equivalent to that of andtheoutputweightgiveninputtree on is equaltothesumofallpossibleoutputweightsgiven on . Like the algorithm of (Mohri, 1997), this Figure 4: a) Portion of a transducer before determinization; b) The same portion after determinization algorithmwillterminateforautomatathatrecognize finite tree languages.
J97-2003
Thelistsmaybeused withannotation and a tuning process, such as in (Collins and Roark, 2004), to iteratively alter feature weights and improve results.
P04-1015
It occurs because many systems, such astheonesproposedby(Bod,1992),(Galley,et.
C92-3126
On average, the determinized forests contain 13.7% of the original 3 As in (Mohri, 1997), determinization may be applicable to some automata that recognize infinite languages.
J97-2003
Note that in transitioning from recognizers to transducers we are following the convention established in (Mohri, 1997) where a transducer with weight outputs is used to represent a weighted recognizer.
J97-2003
(Mohri,1997)encounteredthisprobleminspeech recognition, and presented a solution to the problem of repetition in -best lists of strings that are derived from finite-state automata.
J97-2003
Comput. System Sci.,4. M.Galley and M.Hopkins and K.Knight and D.Marcu. 2004.
N04-1035
We remove cycles from each 355 Algorithm 1: Weighted Determinization ofTreeAutomata Input: BOTTOM-UPTREE-TO-WEIGHTTRANSDUCER . Output: SUBSEQUENTIALBOTTOM-UPTREE-TO-WEIGHTTRANSDUCER . begin1 2 3 PRIORITYQUEUE4 5 6 ENQUEUE7 while do8 v head9 v10 for each vsuch that do11 if such that then12 s.t.13 14 for each such that v do15 v v16 v v v v s.t.17 v v v18 /* RANK returns the largest hyperedge size that can leave state . COMBINATIONS returns all possible vectors of length containing members of and at least one member of . */ if v is a new state then19 for each u COMBINATIONS v v RANK do 20 ifuis a new vector then21 ENQUEUE u22 v23 DEQUEUE24 end25 forest, 3 applyourdeterminizationalgorithm,andextract the -best trees using a variant of (Huang and Chiang,2005).
W05-1506
Liang Huang and David Chiang 2005.
W05-1506
We will present an algorithm for determinizing weighted finite tree recognizers, and use a variant of the procedure found in (Huang and Chiang, 2005)toobtain -bestlistsoftreesthatareweighted correctly and contain no repetition.
W05-1506
