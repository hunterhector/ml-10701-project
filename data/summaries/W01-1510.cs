This paper describes an approach for sharing resources in various grammar formalisms such as Feature-Based Lexicalized Tree Adjoining Grammar (FB-LTAG 1 ) (Vijay-Shanker, 1987; Vijay-Shanker and Joshi, 1988) and Head-Driven Phrase Structure Grammar (HPSG) (Pollard and Sag, 1994) by a method of grammar conversion.
C88-2147
LTAG Resources Grammar: Elementary tree templates Lexicon Type hierarchy extractor Tree converter Lexicon converter RenTAL System HPSG Resources Grammar: Lexical entry templates Lexicon LTAG parsers HPSG parsers Derivation trees Parse trees Derivation translator LTAG-based application HPSG-based application Figure 1: The RenTAL System: Overview ment (Sarkar and Wintner, 1999; Doran et al., 2000; Makino et al., 1998).
P98-2132
Other works (Kasper et al., 1995; Becker and Lopez, 2000) convert HPSG grammars into LTAG grammars.
P95-1013
There have been many studies on parsing techniques (Poller and Becker, 1998; Flickinger et al., 2000), ones on disambiguation models (Chiang, 2000; Kanayama et al., 2000), and ones on programming/grammar-development environ1 In this paper, we use the term LTAG to refer to FBLTAG, if not confusing.
C00-1060 P00-1058
This system will enable a variety of resource sharing such as the sharing of the programming/grammar-development environment (Makino et al., 1998; Sarkar and Wintner, 1999) and grammar extraction methods from bracketed corpora (Xia, 1999; Chen and VijayShanker, 2000; Neumann, 1998).
P98-2132
The RenTAL system is implemented in LiLFeS (Makino et al., 1998) 2 . LiLFeS is one of the fastest inference engines for processing feature structure logic, and efficient HPSG parsers have already been built on this system (Nishida et al., 1999; Torisawa et al., 2000).
P98-2132
Our group has developed a wide-coverage HPSG grammar for Japanese (Mitsuishi et al., 1998), which is used in a high-accuracy Japanese dependency analyzer (Kanayama et al., 2000).
C00-1060 P98-2144
Trunk nodes are nodes on a trunk, which is a path from an anchor to the root node (the thick lines in Figure 7) (Kasper et al., 1995).
P95-1013
FBLTAG (Vijay-Shanker, 1987; Vijay-Shanker and Joshi, 1988) is an extension of the LTAG formalism.
C88-2147
2.1 Feature-Based Lexicalized Tree Adjoining Grammar (FB-LTAG) LTAG (Schabes et al., 1988) is a grammar formalism that provides syntactic analyses for a sentence by composing elementary trees with two operaArg : we can run ID grammar rule unify Sym : NP Arg : Sym : VP Arg : VP Sym : VP Arg : NP Arg : Sym : Arg : 2 3 2 unify 3 unify ID grammar rule we can run Sym : NP Arg : Sym : VP Arg : VP Sym : VP Arg : NP Arg : NPSym : Arg : Arg : 1 1 | 2 Arg : 2 unify we can run Sym : NP Arg : Sym : VP Arg : VP Sym : VP Arg : NP Arg : NP Arg : Figure 6: Parsing with an HPSG grammar S NP VP V run NP N We substitution α1 α2 S NP VP V run N We Figure 3: Substitution VP VPV can * adjunction β1 S NP VP V run N We S NP VP VPV can N We V run Figure 4: Adjunction tions called substitution and adjunction.
C88-2121
