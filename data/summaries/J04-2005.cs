The new algorithm is a generalized version of the first algorithm presented in Daciuk et al.(2000). The relation between the algorithm presented here and the first algorithm in Daciuk et al.(2000) is the same as that between the algorithm for adding strings in Carrasco and Forcada (2002) and the second algoritm in Daciuk et al.(2000). Acknowledgments This research was carried out within the framework of the PIONIER Project Algorithms for Linguistic Processing, funded by NWO (Dutch Organization for Scientific Research) and the University of Groningen.
J00-1002 J02-2004
In Carrasco and Forcada (2002), the prefix states are also cloned.
J02-2004
By taking the process off-line, one saves much memory, as certain structures needed for construction are not needed for consultation, and other structures can be very efficiently compressed (Kowaltowski, Lucchesi, and Stolfi 1993; Daciuk, 2000).
J00-1002
If strings are added in an ordered way, the minimization process can be optimized in the same way as in the “sorted data algorithm,” the first algorithm described in Daciuk et al.(2000). We introduce two changes to the string addition algorithm in Carrasco and Forcada (2002): • Prefix states are not cloned when not necessary.
J00-1002 J02-2004
In Carrasco and Forcada, (2002), the algorithm for addition of strings proceeds by minimizing the queue states and cloned states, arriving at the minimal automaton.
J02-2004
Most of the speedup was not the result of using an algorithm optimized for sorted data—an improvement to the algorithm for adding strings in Carrasco and Forcada (2002) consisting in avoiding unnecessary cloning of prefix states (as described in section 3.2 and mentioned on page 215 in Carrasco and Forcada [2002] as a suggestion from one of Carrasco and Forcada’s reviewers) was 3.12 and respectively 2.35 times faster than the original algorithm.
J02-2004
1. Introduction Carrasco and Forcada (2002) present two algorithms: one algorithm for incremental addition of strings into a minimal, cyclic, deterministic, finite-state automaton, and another for removal of strings from such an automaton.
J02-2004
5. Evaluation Two experiments have been performed to compare the new algorithm with the algorithm for adding strings to a minimal, deterministic, cyclic automaton presented in Carrasco and Forcada (2002).
J02-2004
The first algorithm is a generalization of the “algorithm for unsorted data”—the second of the two incremental algorithms for construction of minimal, deterministic, acyclic automata presented in Daciuk et al.(2000). We show that the other algorithm in the older article—the “algorithm for sorted data”—can be generalized in a similar way.
J00-1002
The algorithm has the same asymptotic complexity as the corresponding algorithms in Carrasco and Forcada (2002) and Daciuk et al.(2000). However, it is faster than algorithms for unsorted data, because it does not have to reprocess the states over and over again.
J00-1002 J02-2004
It is explained in Daciuk et al.(2000) and omitted in Carrasco and Forcada (2002).
J00-1002 J02-2004
Incremental Addition of Sorted Strings 3.1 The Role of the Register Carrasco and Forcada (2002) derive their algorithm for addition of strings from the union of an automaton M =(Q, Σ,δ, q 0, F) with a single-string automaton M w =(Q w, Σ, δ w, q 0w, F w ).
J02-2004
It turns out that not only the algorithm for unsorted data (the second algorithm in Daciuk et al.[2000]), but also the algorithm for sorted data (the first one in that article) can be extended in the same way.
J00-1002
As in Carrasco and Forcada (2002), we define δ : Q ×Σ → Q as a total mapping.
J02-2004
The algorithm for addition of strings can be seen as an extension to cyclic automata of the algorithm for unsorted data, the second algorithm in Daciuk et al, (2000).
J00-1002
Forcada Jan Daciuk ∗ Gda ´nsk University of Technology In a recent article, Carrasco and Forcada (June 2002) presented two algorithms: one for incremental addition of strings to the language of a minimal, deterministic, cyclic automaton, and one for incremental removal of strings from the automaton.
J02-2004
It is faster than the algorithm for adding strings presented in Carrasco and Forcada (2002), but it operates on sorted input data.
J02-2004
It resembles more closely a similar function from the algorithm for unsorted data (Daciuk et al.2000). The longest prefix common to the string to be added and the last string added to the automaton is not necessarily the same as the longest prefix common to the string to be added to the automaton and all strings already in the automaton.
J00-1002
