Delayed phrase construction To avoid the major practical problem of phrasal SMT—namely large phrase tables, most of which are not useful to any one sentence—one can instead construct phrase tables on the fly using an indexed form of the training data (Zhang and Vogel 2005; Callison-Burch et al.2005). However, this does not relieve any of the theoretical problems with phrase-based SMT.
P05-1032
Model weights were also trained following Och (2003).
J03-1002 P03-1021
Finally we trained model weights by maximizing BLEU (Och 2003) and set decoder optimization parameters (n-best list size, timeouts 14 etc) on a development test set of 200 held-out sentences each with a single reference translation.
J03-1002 P03-1021
Unless otherwise noted, the following discussion is generally applicable to Alignment Template systems (Och and Ney 2004) as well.
J04-4002
|)(|),,( ||),,( )|(),,( tphrasecoun wordcount || 1 1 targetLM AtreeletsATSf TATSf ttPATSf T i i nii = = = ∏ = − − Syntactic models As in Quirk and Menezes (2005), we include a linguistically-informed order model that predicts the head-relative position of each node independently, and a tree-based bigram target language model; these models are referred to as set (4).
P05-1034
Systems must therefore impose some limits on phrasal reordering, often hard limits based on distance as in Koehn et al.(2003) or some linguistically motivated constraint, such as ITG (Zens and Ney, 2004).
N03-1017
Hierarchical phrases Recent work in the use of hierarchical phrases (Chiang 2005) improves the ability to capture linguistic generalizations, and also removes the limitation to contiguous phrases.
P05-1033
1. Introduction The last several years have seen phrasal statistical machine translation (SMT) systems outperform word-based approaches by a wide margin (Koehn 2003).
N03-1017
As an additional baseline, we compare against a phrasal SMT decoder, Pharaoh (Koehn et al.2003). 4.1.
N03-1017
Given a fixed length limit, the number of surface phrases extracted from any sentence pair of length n where all words are uniquely aligned is O(n), but the number of treelets is potentially exponential in the number of children; and the number of rules with two gaps extracted by Chiang (2005) is potentially O(n3).
P05-1033
Word alignments were produced by GIZA++ (Och and Ney 2003) with a standard training regimen of five iterations of Model 1, five iterations of the HMM Model, and five iterations of Model 4, in both directions.
J03-1002 P03-1021
3.3. Other translation models Phrasal channel models We can estimate traditional channel models using maximum likelihood or lexical weighting: ∏ ∏ ∏ ∏ ∏ ∏ ∈ ∈ ∈ ∈ ∈ ∈ ∈ ∈ = = = = )(),( InverseM1 )(),( DirectM1 )(),( InverseMLE )(),( DirectMLE )|(),,( )|(),,( )(*, ),(),,(,*)( ),(),,( Atreelets s t Atreelets t s Atreelets Atreelets tspATSf stpATSf c cATSf c cATSf τσ σ τ τσ τ σ τσ τσ τ τσ σ τσ We use word probability tables p(t | s) and p(s | t) estimated by IBM Model 1 (Brown et al.1993). Such models can be built over phrases if used in a phrasal decoder or over treelets if used in a treelet decoder.
J93-2003
3. Translation by MTUs In this paper, we address all four theoretical problems using a novel combination of our syntactically-informed treelet approach (Quirk and Menezes 2005) and a modified version of bilingual n-gram channel models (Banchs et al.2005). As in our previous work, we first parse the sentence into a dependency tree.
P05-1034
We used the heuristic combination described in (Och and Ney 2003) and extracted phrasal translation pairs from this combined alignment as described in (Koehn et al., 2003).
J03-1002 N03-1017 P03-1021
In Quirk and Menezes (2005) we presented an approach to phrasal SMT based on a parsed dependency tree representation of the source language.
P05-1034
Recent research into syntaxbased SMT (Quirk and Menezes 2005; Chiang 2005) has produced promising results in addressing some of the problems; research motivated by other statistical models has helped to address others (Banchs et al.2005). We refine and unify two threads of research in an attempt to address all of these problems simultaneously.
P05-1033 P05-1034
