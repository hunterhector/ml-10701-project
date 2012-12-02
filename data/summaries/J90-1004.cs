This is the correlate of the link relation used in left-corner parsers with top-down filtering; we direct the reader to the discussion by Matsumoto et al.(1983) or Pereira and Shieber (1985) for further information.
P85-1018
In particular, we developed an architecture inspired by the Earley deduction work of Pereira and Warren (1983), but which generalized that work allowing for its use in both a parsing and generation mode merely by setting the values of a small number of parameters.
P83-1021
Hobbs, J.R. and Shieber, S.M. 1987 An Algorithm for Generating Quantifier Scopings".
J87-1005
Pereira, F.C.N. and Warren, D.H.D. 1983 "Parsing as Deduction".
P83-1021
For instance, in analyses of Dutch cross-serial verb constructions (Evers 1975; Huybrechts 1984), subcategorization lists may be concatenated by syntactic rules (Moort32 Computational Linguistics Volume 16, Number 1, March 1990 Shieber et al.Semantic Head-Driven Grammar gat 1984; Fodor et al.1985; Pollard 1988), resulting in arbitrarily long lists.
C88-2128 P85-1018
For example, the "complements" rule given by Shieber (1985a) in the PATR-II formalism VP 1 --* VP 2 X (VPl head) = (VP2 head) (VP2 syncat first) = (X) <VP2 syncat rest) = (VPI syncat) can be encoded as the DCG rule: vp(Head, Syncat)/VP ->,~(Head, \[Compl/LFlSyncat\])/VP, Compl/LF.
P85-1018
Pereira, F.C.N. 1981 "Extraposition Grammars".
J81-4003
In particular, generation from grammars with recursions whose well-foundedness relies on lexical information will terminate; top-down generation regimes such as those of Wedekind (1988) or Dymetman and Isabelle (1988) lack this property; further discussion can be found in Section 2.1.
C88-2150
In previous work (Shieber 1988), however, one of us attempted to characterize these differing properties in such a way that a single uniform architecture, appropriately parameterized, might be used for both natural language processes.
C88-2128
Shieber, S.M. 1985a "An Introduction to Unification-Based Approaches to Grammar," Volume 4 of CSLI Lecture Notes.
P85-1018
3. Pereira and Warren (1983) point out that Earley deduction is not restricted to a left-to-right expansion of goals, but this suggestion was not followed up with a specific algorithm addressing the problems discussed here.
P83-1021
Finally, Calder et al.(1989) report on a generation algorithm for unification categorial grammar that appears to be a special case of ours.
E89-1032
Shieber, S.M. 1985b "Using Restriction to Extend Parsing Algorithms for Complex-Feature-Based Formalisms".
P85-1018
Adding appropriate side conditions to the rules, following the constraints discussed by Hobbs and Shieber (1987) would not be difficult.
J87-1005
As stated in the original Earley generation paper (Shieber 1988), "perhaps the most immediate problem raised by \[Earley generation\] is the strong requirement of semantic monotonicity ....
C88-2128
2. Again, see the text by Pereira and Shieber (1985, p.
P85-1018
Wedekind (1988) achieves the reordering by first generating nodes that are connected, that is, whose semantics is instantiated.
C88-2150
Shieber, S.M. 1988 "A Uniform Architecture for Parsing and Generation".
C88-2128
Topicalization can be handled by gap-threading (Pereira 1981; Pereira arid Shieber 1985).
J81-4003 P85-1018
However, the parameterization is much more broad than for the uniform Earley architecture (Shieber 1988).
C88-2128
Consider, for example, a grammar with a gap-threading treatment of wh-movement (Pereira 1981; Pereira and Shieber 1985), which might include the rule np(Affr, \[np(Agr)/SemJX\]-X)/Sem --> \[ \].
J81-4003 P85-1018
See for instance the text by Pereira and Shieber (1985) for an overview and further references.
P85-1018
Such rules can be translated into Prolog directly using a difference list encoding of string positions; we assume readers are familiar with this technique (Pereira and Shieber, 1985).
P85-1018
In fact, the partial execution techniques described by two of us (Pereira and Shieber 1985) could form the basis of a compiler built by partial execution of the new algorithm we propose below relative to a grammar.
P85-1018
Pereira, F.C.N. and Shieber, S.M. 1985 "Prolog and Natural-Language Analysis," Volume 10 of CSLI Lecture Notes.
P85-1018
Although we believe that this algorithm could be seen as an instance of a uniform architecture for parsing and generation--just as tile extended Earley parser (Shieber, 1985b) and the bottom-up generator were instances of the generalized Earley deduction architecture--our efforts to date have been aimed foremost toward the development of the algorithm for generation alone.
P85-1018
5. Further details of the use of shuffle in scoping are given by Pereira and Shieber (1985).
P85-1018
