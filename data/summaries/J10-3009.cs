to reordering French phrases in a preprocessing step. Xia and McCord (2004) present a
C04-1073
for syntactic constituent boundaries (Cherry 2008; Marton and Resnik 2008; Yamamoto,
P08-1009 P08-1114
Xia, Fei and Michael McCord. 2004.
C04-1073
Fox, Heidi. 2002. Phrasal cohesion and
W02-1039
following Fox (2002). If one child
W02-1039
et al. 2005; Kumar and Byrne 2005; Al-Onaizan and Papineni 2006). Xiong, Liu, and
H05-1021 P06-1067
Eisner, Jason. 2003. Learning non-isomorphic
P03-2041
We ran GIZA++ (Och and Ney 2000) on the parallel corpora (consisting of 101.93M
P00-1056
distance swappings (Xiong et al. 2008b).
I08-1066 P08-2038
Li et al. (2007) improve the preprocessing approach by generating n-best reordered
P07-1091
reordering is not widely explored in the SMT literature. Chiang et al. (2005) propose
H05-1098 P05-1033
Chiang, David. 2005. A hierarchical
H05-1098 P05-1033
2. The quantitative analysis in Xiong, Liu, and Lin (2006, page 525) further
P06-1066 P06-1077
Xiong, Liu, and Lin (2006) define reordering features using the boundary words of
P06-1066 P06-1077
(2001), Popovi´c and Ney (2006), and Zhang, Zens, and Ney (2007) use morphological,
D07-1056 W07-0401
Zhang, Hao and Daniel Gildea. 2005.
P05-1059
Kumar, Shankar and William Byrne. 2005.
H05-1021
which violate constituent boundaries. Yamamoto, Okuma, and Sumita (2008) impose
W08-0401
Lin, Dekang. 2004. A path-based transfer
C04-1090
to penalize word movements (Koehn, Och, and Marcu 2003). Similarly, under the ITG
N03-1017 P03-1021
Och, Franz Josef and Hermann Ney. 2000.
P00-1056
Marton, Yuval and Philip Resnik. 2008. Soft
P08-1114
distortion model (Koehn, Och, and Marcu 2003): Neither model considers linguistic
N03-1017 P03-1021
We evaluate LAR vs. BWR using the automatic metric BLEU (Papineni et al. 2002).
P02-1040
Koehn, Philipp. 2004. Statistical significance
W04-3250
Linguistics (Coling 2004), pages 508–514,
C04-1090
swappings in any zones which contain punctuation (Xiong et al. 2008b).
I08-1066 P08-2038
restricted by the ITG constraint (Wu 1997). Although it only allows two orders (straight
J97-3002
to-tree (Marcu et al. 2006), tree-to-string (Huang, Knight, and Joshi 2006; Liu, Liu, and
W06-1606
Wu, Dekai. 1997. Stochastic inversion
J97-3002
Marton and Resnik 2008) and hard constraints (Yamamoto, Okuma, and
P08-1114
Reorderings by Synchronous Grammars. Wu (1997) and Eisner (2003) use
J97-3002 P03-2041
Lin 2006), and tree-to-tree (Zhang et al. 2008) translation rules, just to name a few, are
C08-1136 P08-1064
receded in more powerful syntax-based models (Galley et al. 2004; Chiang 2005) and
H05-1098 P05-1033 N04-1035
Wu, Dekai. 1996. A polynomial-time
P96-1021
Liu, Yang, Qun Liu, and Shouxun Lin. 2006.
P06-1077
and Cherry (2008) use syntactic cohesion as a soft constraint by penalizing hypotheses
P08-1009
perspective of the ITG reordering (Xiong, Liu, and Lin 2006). The new perspective treats
P06-1066 P06-1077
then applied the “grow-diag-final” refinement rule (Koehn, Och, and Marcu 2003) to
N03-1017 P03-1021
Och, Franz Josef. 2003. Minimum error rate
P03-1021
(Xia and McCord 2004; Collins, Koehn, and Kucerova 2005; Li et al. 2007; Wang,
C04-1073 P05-1066 P07-1091
straint (Zens and Ney 2003), the early work uses a distortion-based reordering model
P03-1019
tuned on the development set to maximize BLEU using MERT (Och 2003). Statistical
P03-1021
words, syntactic cohesion (Fox 2002; Cherry 2008), has been studied and used in early
P08-1009 W02-1039
the common understanding of standard phrasal SMT (Koehn, Och, and Marcu 2003),
N03-1017 P03-1021
Collins, Koehn, and Kucerova (2005) propose reordering German clauses with six types
P05-1066
synchronous grammars to capture reorderings between two languages. Chiang (2005)
H05-1098 P05-1033
Xiong, Liu, and Lin (2006) and Zhang et al. but extends them further by using syntactic
P06-1066 P06-1077
Constrained decoding is different from both soft constraints (Cherry 2008;
P08-1009
one decoder (Lin 2004; Quirk, Menezes, and Cherry 2005; Ge, Ittycheriah, and Papineni
C04-1090 P05-1034
Yamada, Kenji and Kevin Knight. 2001. A
P01-1067
corporating Bracketing Transduction Grammar (BTG) (Wu 1997) into phrasal SMT. In
J97-3002
Zens, Richard, and Hermann Ney. 2003.
P03-1019
ing (LAR) (Xiong et al. 2008a). Xiong, Liu, and Lin (2006) also adapt a two-step reorder-
I08-1066 P06-1066 P06-1077 P08-2038
syntax-based SMT models (Wu 1997; Yamada and Knight 2001). But its value has
J97-3002 P01-1067
to boundary word-based reordering (BWR) (Xiong, Liu, and Lin 2006), which is a very compet-
P06-1066 P06-1077
To eliminate this restriction, Xiong, Liu, and Lin (2006) suggest using boundary words
P06-1066 P06-1077
Our evaluation metric is the case-insensitive BLEU-4 (Papineni et al. 2002) using the
P02-1040
(Marcu et al. 2006), introduces a huge extra cost. Instead, integrating a
W06-1606
(1997) and Zhang and Gildea (2005) but using the more sophisticated reordering models
P05-1059
Fox (2002) systematically studies syntactic cohesion between French and English
W02-1039
to the straight or inverted order (Wu 1996). These two models don’t respect the content
P96-1021
machine translations. Fox (2002) investigates syntactic constituent
W02-1039
Cherry, Colin. 2008. Cohesive phrase-based
P08-1009
assumptions. For example, the flat reordering model in the original BTG (Wu 1996)
P96-1021
of manual rules. Similarly, Wang, Collins, and Koehn (2007) reorder Chinese parse trees
D07-1077
non-syntactic phrasal models (Koehn, Och, and Marcu 2003). Marton and Resnik (2008)
N03-1017 P03-1021 P08-1114
(Chiang 2005) and tree-to-string (Liu, Liu, and Lin 2006) or string-to-tree
H05-1098 P05-1033 P06-1077
translation (Fox 2002), we particularly study how linguistic knowledge affects syntactic
W02-1039
1. Phrases frequently cohere across languages (Fox 2002). In cohesive phrase
W02-1039
Mu Li, Ming Zhou, and Yi Guan. 2007. A
P07-1091
Callison-Burch et al. (2007) propose a constituent-based evaluation that is very simi-
W07-0718
adopt the definition of span from Fox (2002): Given a node n that covers a word sequence s
W02-1039
