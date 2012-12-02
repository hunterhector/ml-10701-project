Since the descriptive power of unification-based grammars is considerably greater than that of CFG (Berwick, 1982), feature structures have to be restricted to maintain the efficiency of parsing and generation algorithms.
J82-3001
Since the number M of distinct pairs (X,w), for a nonterminal symbol X and a subsequence w of input string s, is bounded by Kn 2, we can compute the mbest choice of pattern candidates for every inactive chart in time O(ITIKn 3) as claimed by Maruyama (Maruyama, 1993), and Schabes and Waters (Schabes and Waters, 1995).
J95-4002
Berwick, R.C. 1982.
J82-3001
See also bilingual signs (Tsujii and Fujita, 1991) for a discussion of the importance of combining the appropriate domain of locality and synchronization.
E91-1048
5The meaning of the word "synchronized" here is exactly the same as in STAG (Shieber and Schabes, 1990).
C90-3045
3Lexicalized CFG, or Tree Insertion Grammar (TIG) (Schabes and Waters, 1995), has been recently introduced to achieve such efficiency and lexicalization.
J95-4002
Shieber and Schabes briefly discuss the issue (Shieber and Schabes, 1990).
C90-3045
TAG-based MT (Abeill~, Schabes, and Joshi, 1990) 1 and pattern-based translation (Maruyama, 1993) share many important properties for successful implementation in practical MT systems, namely: • The existence of a polynomial-time parsing algorithm • A capability for describing a larger domain of locality (Schabes, Abeill~, and Joshi, 1988) • Synchronization (Shieber and Schabes, 1990) of the source and target language structures Readers should note, however, that the pars1 See LTAG (Schabes, AbeiU~, and Joshi, 1988) (Lexicalized TAG) and STAG (Shieber and Schabes, 1990) (Synchronized TAG) for each member of the TAG (Tree Adjoining Grammar) family.
C88-2121 C90-3045
There are several alternative approaches that might eventually liberate us from this limitation on the usability of MT systems: Unification-based grammar formalisms and lexical-semantics formalisms (see LFG (Kaplan and Bresnan, 1982), HPSG (Pollard and Sag, 1987), and Generative Lexicon (Pustejovsky, 1991), for example) have been proposed to facilitate computationally precise description of naturallanguage syntax and semantics.
J91-4003
Practically, a timeout mechanism and a process for recovery from unsuccessful translation (e.g., applying the idea of fitted parse (Jensen and Heidorn, 1983) to target CFG rules) should be incorporated into the translation algorithm.
A83-1015
The notion of head constraints may have to be extended into one of a set membership constraint if we need to handle coordinated structures (Kaplan and Maxwell III, 1988).
C88-1061
Corpus-based or example-based MT (Sato and Nagao, 1990; Sumita and Iida, 1991) and statistical MT (Brown et al., 1993) systems provide the easiest customizability, since users have only to supply a collection of source and target sentence pairs (a bilingual corpus).
C90-3044 J93-2003 P91-1024
