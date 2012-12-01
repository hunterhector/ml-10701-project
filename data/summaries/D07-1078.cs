Binarizing the syntax trees for syntax-based machine translation is similar in spirit to generalizing parsing models via markovization (Collins, 1997; Charniak, 2000).
A00-2018 P97-1003
Graehl. 2004.
N04-1014
We also computed the bootstrap p-values (Riezler and Maxwell, 2005) for the pairwise BLEU comparison between the baseline system and any of the system trained from binarized trees.
W05-0908
We therefore use the packed forest to store all the binarizations that operate on an e-parse in a compact way, and then use the inside-outside algorithm (Lari and Young, 1990; Knight and Graehl, 2004) for model estimation.
N04-1014
We used a bottom-up, CKY-style decoder that works with binary xRs rules obtained via a synchronous binarization procedure (Zhang et al., 2006).
N06-1033
It can be further computed by aggregating the rule probabilities p(r) in each derivation ω in the set of all derivations Ω (Galley et al., 2004; Marcu et al., 2006).
W06-1606
Syntax-based translation models (Eisner, 2003; Galley et al., 2006; Marcu et al., 2006) are usually built directly from Penn Treebank (PTB) (Marcus et al., 1993) style parse trees by composing treebank grammar rules.
J93-2004 P03-2041 W06-1606
For example, suppose we have an xRs (Knight and Graehl, 2004) rule R1 in Figure 1 that translates the Chinese phrase RUSSIA MINISTER VIKTOR-CHERNOMYRDIN into an English NPB tree fragment yielding an English phrase.
N04-1014
The translation model we are using in this paper belongs to the xRs formalism (Knight and Graehl, 2004), which has been proved successful for machine translation in (Galley et al., 2004; Galley et al., 2006; Marcu et al., 2006).
N04-1014 W06-1606
The parse trees on the English side of the bitexts were generated using a parser (Soricut, 2004) implementing the Collins parsing models (Collins, 1997).
P97-1003
We used the EM procedure described in (Knight and Graehl, 2004) to perform the inside-outside algorithm on synchronous derivation forests and to generate the Viterbi derivation forest.
N04-1014
Charniak. 2000.
A00-2018
Research Several researchers (Melamed et al., 2004; Zhang et al., 2006) have already proposed methods for binarizing synchronous grammars in the context of machine translation.
N06-1033 P04-1084
Borrowing terms from parsing semirings (Goodman, 1999), a packed forest is composed of additive forest nodes ( -nodes) and multiplicative forest nodes ( -nodes).
J99-4004
