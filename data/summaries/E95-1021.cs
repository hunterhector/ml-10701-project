analysis and guessing The morphological analyser is based on a lexical transducer (Karttunen et al., 1992).
C92-1025
statistical model We use the Xerox part-of-speech tagger (Cutting et al., 1992), a statistical tagger made at the Xerox Palo Alto Research Center.
A92-1018
The tagger has a close relative in (Koskenniemi, 1990; Koskenniemi et al., 1992; Voutilalnen and Tapanainen, 1993) where the rules are represented as finite-state machines that are conceptually intersected with each other.
C90-2040 C92-1027
of the tuggers We also tried combining the tuggers, using first the rules and then the statistics (a similar approach was also used in (Tapanainen and Voutilainen, 1994)).
A94-1008
Related work using finite-state machines has been done using local grammars (Roche, 1992; Silberztein, 1993; Laporte, 1994)'.
C92-3153
The tagger reads one sentence at a time, a string of words and alternative tags, feeds them to the grammatical transduc1There is a \]onger version (17 pages) of this paper in (Chanod and Tapanainen, 1994) ers that remove all but one alternative tag from all the words on the basis of contextual information.
A94-1008
A constraint-based system is also presented in (Karlsson, 1990; Karlsson et al., 1995).
C90-3030
The disambiguation rules are similar to phonological rewrite rules (Kaplan and Kay, 1994), and the parsing algorithm is similar to the algorithm for combining the morphological rules with the lexicon (Karttunen, 1994).
C94-1066 J94-3001
The Xerox tagger is claimed (Cutting el al., 1992) to be adaptable and easily trained; only a lexicon and suitable amount of untagged text is required.
A92-1018
