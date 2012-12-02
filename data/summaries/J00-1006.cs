Results that emerged earlier from this work appear elsewhere (Kiraz 1994b, 1996, 1997a, 1997b, 1997c, in press), but have been thoroughly enhanced and reworked since.
C94-1029 P96-1022 P97-1042 W97-1108
The categories are incorporated in the automata compilation process following the algorithms in Kiraz (1997a).
P97-1042 W97-1108
Linear nontemplatic morphotactics is handled via regular operations, usually nway concatenation (Kaplan and Kay 1994) in the multitiered case.
J94-3001
The identity and insert operators are the n-tape version of their counterparts in Kaplan and Kay (1994).
J94-3001
In his 1996 paper, and subsequent work, Beesley reimplemented the system using the Xerox lexical and rule compilers (Karttunen 1993; Karttunen and Beesley 1992).
C92-1025
The entire grammar is taken as the composition of two sets of rules (Karttunen, Kaplan, and Zaenen 1992).
C92-1025
Pulman (Grimley-Evans, Kiraz, and Pulman 1996).
C96-1077 P96-1022
An on-line demo of the reimplementation was also developed (Beesley 1998a).
W98-1007 W98-1312
The initial runs took quite some time (many 100 Kiraz Multitiered Nonlinear Morphology hours for 100 roots)! since the insert operator was initially implemented by the expression Range(A o (G U c:B)*) for inserting B into A (Kaplan and Kay 1994).
J94-3001
To resolve the problem, these authors (with the exception of Beesley's work from 1996 on) provided for a simultaneous search of various root and affix lexica, the result of which served as the lexical tape of the two-level system.
C96-1017
The library was successfully used, however, to implement the algorithms in the current work as well as those presented by Grimley-Evans (1997) and Kiraz (1997a).
P97-1042 P97-1058 W97-1108
In the current framework, categories of the form: cat-name ATTRIBUTE1 ~ VALUE1 ATTRIBUTE2 = VALUE2 are used in the lexicon as well as rules to resolve such issues (Bear 1988; Ritchie et al.1992). Here, a value can be either an atom or a set of atoms.
C88-1006
An interpreter version of the work presented here was described earlier (Kiraz 1996).
P96-1022
There is no reason to believe that our multitiered rewrite rules component cannot be applied to other rewrite rules systems (Koskenniemi 1983; Kaplan and Kay 1994; Mohri and Sproat 1996; Karttunen 1997).
J94-3001 P96-1031
The lexical description gives the root and pattern superficially concatenated in the form (Beesley 1996, p.
C96-1017
The core ideas are published in Kaplan and Kay (1994).
J94-3001
The interpretation of the latter condition is based on Grimley-Evans, Kiraz, and Pulman (1996).
C96-1077 P96-1022
S k substitutes every occurrence of I in S with Sq 3 Insert is also called the ignore operator, e.g., in the Xerox finite-state compiler (Karttunen and Beesley 1992; Karttunen 1993).
C92-1025
A faithful implementation of Beesley's bracketing approach and ours was performed using the Bell Labs Lextools compiler (Sproat 1995; Kiraz 1997b).
P97-1042 W97-1108
6. Other Approaches to Finite-State Semitic Morphology 6.1 Kay's Multitape Approach Kay (1987) proposed handling the autosegmental analysis of Arabic by means of multitape automata• Kay adds some extensions to traditional FSTs.
E87-1002
The expression for the ith sublexicon becomes: Li= U W (1) WE f-.i (Daciuk et al.\[2000\] give a more sophisticated incremental algorithm for compiling acyclic lexica).
J00-1002
Previous work to implement Semitic languages, namely, Akkadian (Kataja and Koskenniemi 1988), Arabic (Beesley, Buckwalter, and Newton 1989; Beesley 1990, 1991, 1996, 1998a, 1998b, 1998c, forthcoming) and Hebrew (Lavie, Itai, and Ornan 1990), employed traditional two-level morphology with some augmentation to handle the nonlinearity of stems, but did not make any use of the then-available theory of nonconcatenative morphology.
C96-1017 W98-1007 W98-1312
As for the grammars themselves, a small-scale Syriac grammar was implemented based on the 100 most frequent roots, including their numerous inflexions, of the Syriac New Testament (Kiraz 1994a).
C94-1029
Firstly, the use of various bracketing notations to control the moves of the machine head(s) causes the read heads of the three upper input tapes to move independently of each other; this put the expressiveness of the device under question: Bird and Ellison (1992, but not 1994) questioned the formal power of the device.
J94-1003
Kay (1987) was the first computational linguist to make use of McCarthy's findings.
E87-1002
Beesley (1998c) employed a similar approach for eliminating invalid forms in Arabic long-distance dependencies by means of composition.
W98-1007 W98-1312
