The decoder in Table 1 fills a115a152a131 a113 state sets a94a118a107a153a100a101a111a154a15 a103a3a116 a23 a30a97a30a50a30 a23a97a115 a106 . All the coverage vectorsa79 for states in the set a94a86a107 cover the same number of source positions a111 . When a state set a94a118a107 is processed, the decoder has finished processing all states in the sets a94 a125 where a155a157a156a158a111 . Before expanding a state set, the decoder prunes a state set based on its coverage vector and the path costs only: two different pruning strategies are used that have been introduced in (Tillmann and Ney, 2003): 1) coverage pruning prunes states that share the same coverage vector a79, 2) cardinality pruning prunes states according to the cardinality a19 a4a159a79a150a11 of covered positions: all states in the beam are compared with each other.
J03-1005 W03-1001
Without proof, for the search algorithm in Section 2.1 we observe that the number of states is finite and that all the states are actually reachable from the start state a105a87a98 . This way for the single-word based search in (Tillmann and Ney, 2003), a complexity of a174a101a4a60a175a18a172 a28 a175a177 a30 a115a147a178 a30 a179 a96 a11 is shown, where a175a18a172 a28 a175 is the size of the target vocabulary and a115 is the length of the input sentence.
J03-1005 W03-1001
Generally, the regular search space can only be fully searched for small search grids under appropriate restrictions, i.e. the monotonicity restrictions in (Tillmann et al., 1997) or the inverted search graph in (Niessen et al., 1998).
P97-1037
Beam-search results are presented in terms of two pruning thresholds: the coverage pruning threshold a220 a222 and the cardinality pruning threshold a220 a95 (Tillmann and Ney, 2003).
J03-1005 W03-1001
(Knight, 1999) shows that the decoding problem for SMT as well as some bilingual tiling problems are NP-complete, so no efficient algorithm exists in the general case.
J99-4005
To restrict the block selection based on word aligned training data, interval projection functions are defined as follows 4: a140 is a source interval and a148 is an target inter3(Tillmann, 2003) reports an intersection coverage of about a186a168a187 % for Arabic-English parallel data, and a coverage of a188a97a189 % for Chinese-English data.
J03-1005 W03-1001
The phrase learning approach in (Och and Ney, 2004) takes two alignments: a source-to-target alignment a180 a10 and a target-to-source alignment a180 a178 . The intersection of these two alignments is computed to obtain a high-precision word alignment.
J04-4002
4), it constitutes a bijection between source and target sentence positions, since the intersecting alignments are functions according to their definition in (Brown et al., 1993) 3.
J93-2003
In the case of uncomplete coverage, the current algorithm can be extended as described in Section 4.1. 4(Och and Ney, 2004) defines the notion of consistency for the set of phrasal translations that are learned from wordFigure 3: Following the definition in Eq.
J04-4002
The decoding algorithm shown here is most similar to the decoding algorithms presented in (Koehn, 2004) and (Och and Ney, 2004), the later being used for the Alignment Template Model for SMT.
J04-4002
The paper contains the following original contributions: 1) the DP-based decoding algorithm in (Tillmann and Ney, 2003) is extended in a formal way to handle phrases and a novel pruning strategy with increased translation speed is presented 2) a novel alignment algorithm is presented that computes a phrase alignment efficiently in the case that it is consistent with an underlying word alignment.
J03-1005 W03-1001
is carried out in one pass over some input along a specific ’direction’: in speech recognition the search is timesynchronous, the single-word based search algorithm in (Tillmann et al., 1997) is (source) position-synchronous or left-to-right, the search algorithm in (Niessen et al., 1998) is (target) position-synchronous or bottom-to-top, and the search algorithm in (Tillmann and Ney, 2003) is so-called cardinality-synchronous.
J03-1005 P97-1037 W03-1001
The real-valued features include the following: a block translation score derived from phrase occurrence statistics a4a9a113a77a11, a trigram language model to predict target words a4a179a112a229 a78a204a11, a lexical weighting score for the block internal words a4a127a202a204a11, a distortion model a4a0a207a229 a218a147a11 as well as the negative target phrase length a4a60a36a87a11 . The transition cost is computed as a19 a4a20a6 a23 a6 a39 a11a224a15 a27 a28 a30a89a32 a4a7a6 a83 a6a20a39a34a11, where a27 a199a230a227 a228 is a weight vector that sums up to a113a89a35a116 : a228 a13a26a17 a10 a27 a13a217a15a231a113a25a35a116 . The weights are trained using a procedure similar to (Och, 2003) on held-out test data.
P03-1021
Block Alignment Algorithm A common approach to phrase-based SMT is to learn phrasal translation pairs from word-aligned training data (Och and Ney, 2004).
J04-4002
The complexity is dominated by the exponential number of coverage vectorsa79 that occur in the search, and the complexity of phrase-based decoding is higher yet since its hypotheses store a source interval a37a38a25a39 a23 a38a89a40 rather than a single source position a38 . In the general case, no efficient search algorithm exists to search all word or phrase reorderings (Knight, 1999).
J99-4005
Under certain restrictions, both algorithms handle MT-related problems efficiently that are generally NP complete (Knight, 1999).
J99-4005
For all re-ordering experiments, the notion of skips is used (Tillmann and Ney, 2003) to restrict the phrase re-ordering: the number of skips restricts the number of holes in the coverage vector for a left-to-right traversal of the input sentence.
J03-1005 W03-1001
Dynamic Programming based search algorithms are being used in speech recognition (Jelinek, 1998; Ney et al., 1992) as well as in statistical machine translation (Tillmann et al., 1997; Niessen et al., 1998; Tillmann and Ney, 2003).
J03-1005 P97-1037 W03-1001
In this paper, the DP-based search algorithm in (Tillmann and Ney, 2003) is extended in a formal way to handle phrase-based translation.
J03-1005 W03-1001
The efficient block alignment algorithm in Section 4 is related to the inversion transduction grammar approach to bilingual parsing described in (Wu, 1997): in both cases the number of alignments is drastically reduced by introducing appropriate re-ordering restrictions.
J97-3002
