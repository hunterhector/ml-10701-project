ProFIT terms to Prolog terms 3.1 Compilation of Sorted Feature Terms The compilation of sorted feature terms into a Prolog term representation is based on the following principles, which are explained in more detail in (Mellish, 1988; Mellish, 1992; Schgter, 1993; Erbach, 1994).
J88-1004
Implementations of sorted feature formalisms such as TDL (Krieger and Sch~ifer, 1994), ALE (Carpenter, 1993), CUF (DSrre and Dorna, 1993), TFS (Emele and Zajac, 1990) and others have been used successfully for the development and testing of large grammars and lexicons, but they may be too slow for actual use in applications 180 because they are generally built on top of Prolog or LISP, and can therefore not be as efficient as the built-in unification of Prolog.
C90-3052 C94-2144
4see the complexity analysis by Brew (Brew, 1991).
J91-4002
183 2.7 Finite Domains For domains involving only a finite set of atoms as possible values, it is possible to provide a Prolog term representation (due to Colmerauer, and described by Mellish (Mellish, 1988)) to encode any subset of the possible values in one term.
J88-1004
• Use of recta-programming for self-monitoring to ensure generation of unambiguous utterances (Neumann and van Noord, 1992) • Work in the area of Explanation-Based Learning (EBL) to learn frequently used' structures (Samuelsson, 1994) • Tabulation techniques, from the use of wellformed substring tables to the latest developments in Earley deduction, and memoing techniques for logic programming (Neumann, 1994) • Work based on Constraint Logic Programming (CLP) to provide processing models for principle-based grammars (Matiasek, 1994) • Using coroutining (dif, freeze etc).
C92-2105
This work was supported by • The Commission of the European Communities through the project LRE-61-061 "Reusable Gratnmatical Resources", where it has been (ab-)used in creative ways to prototype extensions for the ALEP formalism such as set descriptions, linear precedence constraints and guarded constraints (Manandhat, 1994; Manandhar, 1995).
E95-1023
Mellish. 1988.
J88-1004
184 $sign(yar, $phrasal(Phrasesort,Clausesort,Dtrs), Phon, Synsem, Qstore, Retrieved) 3.2 Compilation of Finite Domains The compilation of finite domains into Prolog terms is performed by the "brute-force" method described in (Mellish, 1988).
J88-1004
