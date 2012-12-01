See (Satta and Peserico, 2005, Sec.
H05-1101
We also compare the top result of our synchronous binarization system with the state-of-theart alignment-template approach (ATS) (Och and Ney, 2004).
J04-4002
We believe that extensions of our technique to more powerful models such as synchronous tree-adjoining grammar (Shieber and Schabes, 1990) is an interesting area for further work.
C90-3045
One way around this dif culty is to stipulate that all rules must be binary from the outset, as in inversion-transduction grammar (ITG) (Wu, 1997) and the binary synchronous context-free grammar (SCFG) employed by the Hiero system (Chiang, 2005) to model the hierarchical phrases.
J97-3002 P05-1033
Wu (1997) shows that parsing a binary SCFG is in O(|w|6) while parsing SCFG is NP-hard in general (Satta and Peserico, 2005).
H05-1101 J97-3002
In contrast, the rule extraction method of Galley et al.(2004) aims to incorporate more syntactic information by providing parse trees for the target language and extracting tree transducer rules that apply to the parses.
N04-1035
boundary words u and v to produce a bigram-item like parenleftBig u ··· v Xi j parenrightBig, following the dynamic programming algorithm of Wu (1996).
P96-1021
In the case of m-gram integrated decoding, we have to maintain 2(m−1) boundary words for each child nonterminal, which leads to a prohibitive overall complexity of O(|w|3+2n(m−1)), which is exponential in rule size (Huang et al., 2005).
W05-1507
An alternative de nition by Satta and Peserico (2005) allows co-indexed nonterminals taking different symbols in two dimensions.
H05-1101
This problem can be cast as an instance of synchronous ITG parsing (Wu, 1997).
J97-3002
We use [] and 〈〉 for straight and inverted combinations respectively, following the ITG notation (Wu, 1997).
J97-3002
However, in the source-channel approach to machine translation, we need to combine probabilities from the translation model (an SCFG) with the language model (an ngram), which has been shown to be very important for translation quality (Chiang, 2005).
P05-1033
Melamed (2003) discusses binarization of multitext grammars on a theoretical level, showing the importance and dif culty of binarization for ef cient synchronous parsing.
N03-1021
Wu (1997, Sec.
J97-3002
As illustrated in Figure 2, VPP-VP has contiguous spans on both source and target sides, so that we can generate a binary-branching SCFG: (2) S→ NP (1) V PP-VP (2), NP(1) V PP-VP (2) VPP-VP → VP(1) PP(2), PP(2) VP(1) In this case m-gram integrated decoding can be done in O(|w|3+4(m−1)) time which is much lowerorder polynomial and no longer depends on rule size (Wu, 1996), allowing the search to be much faster and more accurate facing pruning, as is evidenced in the Hiero system of Chiang (2005) where he restricts the hierarchical phrases to be a binary SCFG.
P05-1033 P96-1021
Several recent syntax-based models for machine translation (Chiang, 2005; Galley et al., 2004) can be seen as instances of the general framework of synchronous grammars and tree transducers.
N04-1035 P05-1033
It has been shown by Shapiro and Stephens (1991) and Wu (1997, Sec.
J97-3002
Our rule set is obtained by rst doing word alignment using GIZA++ on a Chinese-English parallel corpus containing 50 million words in English, then parsing the English sentences using a variant of Collins parser, and nally extracting rules using the graph-theoretic algorithm of Galley et al.(2004). We did a spectrum analysis on the resulting rule set with 50,879,242 rules.
N04-1035
2In making one nonterminal play dual roles, we follow the de nitions in (Aho and Ullman, 1972; Chiang, 2005), originally known as Syntax Directed Translation Schema (SDTS).
P05-1033
From a synchronous rewriting point of view, this is more akin to synchronous tree substitution grammar (STSG) (Eisner, 2003).
P03-2041
Suppose we have the following tree-to-string rules, following Galley et al.(2004): (3) S(x0:NP, VP(x2:VP, x1:PP))→x0 x1 x2 NP(NNP(Powell))→Baoweier VP(VBD(held), NP(DT(a) NPS(meeting))) →juxing le huitan PP(TO(with), NP(NNP(Sharon)))→yu Shalong where the reorderings of nonterminals are denoted by variables xi.
N04-1035
