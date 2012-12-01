Following Och and Ney (2002), we base our model on log-linear framework and adopt the seven feature functions described in (Liu et al., 2006).
P02-1038 P06-1077
They demonstrated very promising results when compared with the state of the art phrase-based system (Och and Ney, 2004) in the NIST 2006 machine translation evaluation 1. While Galley et al.(2006) and Marcu et al.(2006) put emphasis on target language analysis, Quirk et al.(2005) and Liu et al.(2006) show benefits from modeling the syntax of source language.
J04-4002 P05-1034 P06-1077 P06-1121 W06-1606 W06-1608
We compared our system Lynx against a freely available phrase-based decoder Pharaoh (Koehn et al., 2003).
N03-1017
Marcu et al.(2006) argue that this choice is inap704 propriate because large applicability contexts are required.
W06-1606
We ran GIZA++ (Och and Ney, 2000) on the training corpus in both directions using its default setting, and then applied the refinement rule “diagand” described in (Koehn et al., 2003) to obtain a single many-to-many word alignment for each sentence pair.
N03-1017 P00-1056
Following Marcu et al.(2006), we define the probability of a tuple 〈T,S,A〉 as the sum over all derivations θ i ∈ Θ that are consistent with the tuple, c(Θ) = 〈T,S,A〉.
W06-1606
Marcu et al.(2006) report that approximately 28% of bilingual phrases are non-syntactic on their English-Chinese corpus.
W06-1606
Our evaluation metric is BLEU-4 (Papineni et al., 2002), as calculated by the script mteval-v11b.pl with its default setting except that we used case-sensitive matching of n-grams.
P02-1040
To perform minimum error rate training (Och, 2003) to tune the feature weights to maximize the system’s BLEU score on development set, we used the script optimizeV5IBMBLEU.m (Venugopal and Vogel, 2005).
P03-1021
The past two years have witnessed the rapid development of linguistically syntax-based translation models (Quirk et al., 2005; Galley et al., 2006; Marcu et al., 2006; Liu et al., 2006), which induce tree-to-string translation rules from parallel texts with linguistic annotations.
P05-1034 P06-1077 P06-1121 W06-1606 W06-1608
Liu et al.(2006) treat bilingual phrases as lexicalized TATs (Tree-to-string Alignment Template).
P06-1077
Chiang (2005) shows significant improvement by keeping the strengths of phrases while incorporating syntax into statistical translation.
P05-1033
Och. 2003.
P03-1021
Studies reveal that linguistically syntax-based models are sensitive to syntactic analysis (Quirk and Corston-Oliver, 2006), which is still not reliable enough to handle real-world texts due to limited size and domain of training data.
W06-1608
For a non-syntactic phrase pair, Marcu et al.(2006) create a xRS rule headed by a pseudo, nonsyntactic nonterminal symbol that subsumes the phrase and corresponding multi-headed syntactic structure; and one sibling xRS rule that explains how the non-syntactic nonterminal symbol can be combined with other genuine nonterminals so as to obtain genuine parse trees.
W06-1606
We will try a more general way as suggested in (Galley et al., 2006), making no a priori assumption about assignment and using EM training to learn the probability distribution.
P06-1121
