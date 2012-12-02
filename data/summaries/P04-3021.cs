a117 a65a116a88 : test features of the word a117 a65 a84 : test features of the left context a117 a65 a85 : test features of the right context We use the representation of context-dependent rewrite rules (Johnson, 1972; Kaplan and Kay, 1994) and their weighted version (Mohri and Sproat, 1996) to represent these weak learners.
J94-3001 P96-1029 P96-1031
Finite state models have been extensively applied to many aspects of language processing including, speech recognition (Pereira and Riley, 1997), phonology (Kaplan and Kay, 1994), morphology (Koskenniemi, 1984), chunking (Abney, 1991; Bangalore and Joshi, 1999), parsing (Roche, 1999; O azer, 1999) and machine translation (Vilar et al., 1999; Bangalore and Riccardi, 2000).
J94-3001 J99-2004 W00-0508
a127 a12a128a90 a42 a126 a42 (7) We note that the due to the difference in the nature of the learning algorithm, compiling decision trees results in a composition of WFSTs representing the rules on the path from the root to a leaf node (Sproat and Riley, 1996), while compiling boosted rules results in a union of WFSTs, which is expected to result in smaller transducers.
P96-1029
Sproat. 1996.
P96-1029
Although these approaches have been more effective than HMMs, there have not been many attempts to represent these models as a WFST, with the exception of the work on compiling decision trees (Sproat and Riley, 1996).
P96-1029
We note that these rules apply left to right on an input and do not repeatedly apply at the same point in an input since the output vocabularya1 would typically be disjoint from the input vocabulary a0 . We use the technique described in (Mohri and Sproat, 1996) to compile each weighted contextdependency rules into an WFST.
P96-1029 P96-1031
The interpretation of these rules are as follows: Rewrite a83 by a120 when it is preceded by a122 and followed by a123 . Furthermore, a120 can be extended to a rational power series which are weighted regular expressions where the weights encode preferences over the paths ina120 (Mohri and Sproat, 1996).
P96-1029 P96-1031
