We report precision, recall and balanced F-measure (Och and Ney, 2003).
J03-1002 P03-1021
This alignment system is powered by the IBM translation models (Brown et al., 1993), in which one sentence generates the other.
J93-2003
The surface heuristic can define consistency according to any word alignment; but most often, the alignment is provided by GIZA++ (Och and Ney, 2003).
J03-1002 P03-1021
2.1 Phrase Table Extraction Phrasal decoders require a phrase table (Koehn et al., 2003), which contains bilingual phrase pairs and 17 scores indicating their utility.
N03-1017
Birch et al.(2006) handle point 1 directly by reducing the size of the alignment space.
W06-3123
Hybrid methods that combine well-founded statistical analysis with high-confidence word-level alignments have made some headway (Birch et al., 2006), but suffer from the daunting task of heuristically exploring a still very large alignment space.
W06-3123
Wu (1997) used a binary bracketing ITG to segment a sen19 tence while simultaneously word-aligning it to its translation, but the model was trained heuristically with a fixed segmentation.
J97-3002
The similarities become moreapparentwhenweconsiderthecanonical-form binary-bracketing ITG (Wu, 1997) shown here: S → A | B | C A → [AB] | [BB] | [CB] | [AC] | [BC] | [CC] B → 〈AA〉 | 〈BA〉 | 〈CA〉 | 〈AC〉 | 〈BC〉 | 〈CC〉 C → ¯e/ ¯f (3) (3) is employed in place of (2) to reduce redundant alignments and clean up EM expectations.1 More importantly for our purposes, it introduces a preterminal C, which generates all phrase pairs or cepts.
J97-3002
Inversion transduction grammar (Wu, 1997), or ITG, is a wellstudied synchronous grammar formalism.
J97-3002
Like our predecessors (Marcu and Wong, 2002; Birch et al., 2006), we apply a lexicon constraint: no monolingual phrase can be used by any phrasal model unless it occurs at least five times.
W02-1018 W06-3123
This is similar to the constraint used in the C-JPTM, but we do not just eliminate those spans as potential phrase-to-phrase links: we never consider any ITG parse that builds a non-terminal over a pruned span.2 This fixed-link pruning will speed up both Viterbi alignment and EM training by reducing the number of analyzed spans, and so long as we trust 2Birch et al.(2006) re-introduce inconsistent phrase-pairs in cases where the sentence pair could not be aligned otherwise.
W06-3123
Results on the provided 2000sentence development set are reported using the BLEU metric (Papineni et al., 2002).
P02-1040
Past approaches have pruned spans using IBM Model 1 probability estimates (Zhang and Gildea, 2005) or using agreement with an existing parse tree (Cherry and Lin, 2006).
E06-1019 N06-1033 P05-1059
Empirical studies suggest that only a small percentage of human translations violate these constraints (Cherry and Lin, 2006).
E06-1019
Two are conditionalized phrasal models, each EM trained until performance degrades: • C-JPTM3 as described in (Birch et al., 2006) • Phrasal ITG as described in Section 4.1 Three provide alignments for the surface heuristic: • GIZA++ with grow-diag-final (GDF) • Viterbi Phrasal ITG with and without the noncompositional constraint We use the Pharaoh decoder (Koehn et al., 2003) with the SMT Shared Task baseline system (Koehn and Monz, 2006).
N03-1017 W06-3123
Method Prec Rec F-measure GIZA++ Intersect 96.7 53.0 68.5 GIZA++ Union 82.5 69.0 75.1 GIZA++ GDF 84.0 68.2 75.2 Phrasal ITG 50.7 80.3 62.2 Phrasal ITG + NCC 75.4 78.0 76.7 Following the lead of (Fraser and Marcu, 2006), we hand-aligned the first 100 sentence pairs of our training set according to the Blinker annotation guidelines (Melamed, 1998).
P06-1097
Och. 2003.
J03-1002 P03-1021
Pharaoh also includes lexical weighting parameters that are derived from the alignments used to induce its phrase pairs (Koehn et al., 2003).
N03-1017
It extracts all consistent phrase pairs from word-aligned bitext (Koehn et al., 2003).
N03-1017
Marcu and Wong (2002) address point 2 with a lexicon constraint; monolingual phrases that are above a length threshold or below a frequency threshold are excluded from the lexicon.
W02-1018
The expectation task of counting productions weighted by their probability is handled with dynamic programming, using the inside-outside algorithm extended to bitext (Zhang and Gildea, 2004).
C04-1060
Weights for the log-linear model are set using the 500-sentence tuning set provided for the shared task with minimum error rate training (Och, 2003) as implemented by Venugopal and Vogel (2005).
J03-1002 P03-1021
Modeling We can test our model’s utility for translation by transforming its parameters into a phrase table for the phrasal decoder Pharaoh (Koehn et al., 2003).
N03-1017
Melamed. 2003.
N03-1021
We can use a linear-time algorithm (Zhang et al., 2006) to detect non-ITG movement in our high-confidence links, and remove the offending sentence pairs from our training corpus.
N06-1033
(2) cannot represent all possible permutations of concepts that may occur during translation, because some permutations will require discontinuous constituents (Melamed, 2003).
N03-1021
In the meantime, synchronous parsing methods efficiently process the same bitext phrases while building their bilingual constituents, but continue to be employed primarily for word-to-word analysis (Wu, 1997).
J97-3002
Many-to-many alignments can be created by combining two GIZA++ alignments, one where English generates Foreign and another with those roles reversed (Och and Ney, 2003).
J03-1002 P03-1021
The joint phrasal translation model (Marcu and Wong, 2002), or JPTM, applies the same statistical techniquesfromtheIBMmodelsinaphrasalsetting.
W02-1018
The grow-diag-final (GDF) combination heuristic (Koehn et al., 2003) adds links so that each new link connects a previously unlinked token.
N03-1017
Stochastic ITGs are parameterized like their PCFG counterparts (Wu, 1997); productions A → X are assigned probability Pr(X|A).
J97-3002
This ITG constraint is characterized by the two forbidden structures shown in Figure 1 (Wu, 1997).
J97-3002
Vilar and Vidal (2005) used ITG-like dynamic programming to drive both training and alignment for their recursive translation model, but they employed a conditional model that did not maintain a phrasal lexicon.
W05-0835
