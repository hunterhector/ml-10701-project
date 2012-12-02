Illustration of results by PML with different methods on WSJ 24 with known arguments System Train Test Tasks P R F1 Lacc T Palmer (2005) W02-21 W23 BR+RL 68.60 57.80 62.74 81.70 3.785 PARA+PML W02-21 W23 BR+RL 71.24 70.79 71.02 88.77 0.941 Kouchnir (2004) W15-18 W21 RL 75.71 74.60 75.15 kNN W15-18 W21 RL 81.86 81.79 81.83 83.57 0.242 Table 12.
J05-1004 W04-2418
2.3 Predicate-Argument Recognition Algorithm (PARA) Lin & Smith (2005; 2006) describe a tree-based predicate-argument recognition algorithm (PARA).
W05-0626
Palmer, M., Gildea, D., and Kingsbury, P., (2005).
J05-1004
Combination of Priority Estimation for PML system originated from Gildea et al., (2002) The classification decision is made by the following calculation for each argument in a sentence: argmax r1 ..
J02-3001
Instead of calculating each node in a parse tree like the Palmer (2005) model, PARA+PML can only focus on essential nodes from the output of PARA, which helps to reduce the execution time as 0.941 second per sentence.
J05-1004
Illustration of path “NP↑ S↓ VP↓ VBD” from a constituent “The officer” to the predicate “came”. Predicate – the given predicate lemma Voice – whether the predicate is realized as an active or passive construction (Pradhan et al., 2004, claim approximately 11% of the sentences in PropBank use a passive instantiation) Phrase Type – the syntactic category (NP, PP, S, etc).
N04-1030
n P(r1…n | f1,..n) This approach is described in more detail in Gildea and Jurasky (2002).
J02-3001
The basic kNN in the fourth row, trained by four datasets (WSJ 15 to 18 in CoNLL 2004) for the RL” task (to label arguments by giving the known arguments) on the test data WSJ 21, increases F1:6.68 compared to the result of Kouchnir (2004) in the third row.
W04-2418
Figure 2 depicts a graphic organization of the priority combination with more-specific distribution toward the top, similar to Palmer et al.(2005) but adding another preposition feature.
J05-1004
It is possible to achieve acceptable F1 scores with considerably faster execution times (compared to Gildea & Jurasky, 2002) for the Semantic role labeling problem using the Priority Maximum Likelihood instance-based learning algorithm and the Tree-based Predicate-Argument Algorithm (PARA) as a preprocessing step, without any training given a state-of-the-art parser such as Charniak’s parser.
J02-3001
The PML method used here utilizes a modification of the backoff lattice method used by Gildea & Jurafsky (2002) to use a set of basic features—specifically, the features employed for learning in this paper are Predicate (pr), Voice (vo), Phrase Type (pt), Distance (di), Head Word (hw), Path (pa), Preposition in a PP (pp), and an “Actor” heuristic.
J02-3001
It includes several Wall Street Journal sections with parse-trees from both Charniak’s (2000) parser and Collins’ (1999) parser.
A00-2018
3. Execution time for the instance-based learning presented here is about four times faster for SRL than the comparable approach used by Palmer, (2005).
J05-1004
As Gildea & Jurasksy (2002) state, “the less-specific distributions were used only when no data were present for any more-specific distribution.
J02-3001
Gildea & Jurafsky (2002) propose the backoff combination in a linear interpolation for both coverage and precision.
J02-3001
If the full feature set is selected the probability is calculated by P (r | pr, vo, pt, di, hw, pa, pp) = # (r, pr, vo, pt, di, hw, pa, pp) / # (pr, vo, pt, di, hw, pa, pp) Gildea & Jurafsky (2002) claims “there is a trade-off between more-specific distributions, which have higher accuracy but lower coverage, and less-specific distributions, which have lower accuracy but higher coverage” and that the selection of feature subsets is exponential; and that selection of combinations of different feature subsets is doubly exponential, which is NPcomplete.
J02-3001
It is shown that applying the Tree-Based PredicateArgument Recognition Algorithm (PARA) to the data as a preprocessing stage allows kNN and PML to deliver F1: 68.61 and 71.02 respectively on the WSJ23, and F1: 56.96 and 60.55 on the Brown Corpus; an increase of 8.28 in F1 measurement over the most recent published PML results for this problem (Palmer et al., 2005).
J05-1004
Koomen et al.(2006), with more than 25 features, achieved the best results reported in CoNLL2005 on WSJ 24; but PML’s performance (using PARA as a preprocessor, and seven features) achieves an F1 measure 5.10 less than Kooman’s system (74.76) on WSJ 24 utilising Charniak-1 parses, and 4.07 less when using Kooman’s test result (WSJ 23) as knownboundary input.
W05-0625
Maximum Likelihood (PML) Estimation Gildea & Jurafsky (2002), Gildea & Hockenmaier (2003) and Palmer et al., (2005) use a statistical approach based on Maximum Likelihood method for SRL, with different backoff combinaPredicate Arg0 Argm-LOC 181 P(r | hw, pt, pre,pp) P(r | pt, pa, pr, pp) P(r | pt, di, vo, pr, pp) P(r | hw, pr, pp) P(r | pt, pr, pp) P(r | pr, pp) Local Global P(r | hw, pp) P(r | pt, di, vo, pp) tion methods in which selected probabilities are combined with linear interpolation.
J02-3001 J05-1004 W03-1008
Many research efforts utilize machine learning (ML) approaches; such as support vector machines (Moschitti et al., 2004; Pradhan et al., 2004), perceptrons (Carreras et al., 2004), the SNoW learning architecture (Punyakanok et al., 2004), EMbased clustering (Baldewein et al., 2004), transformation-based learning (Higgins, 2004), memory-based learning (Kouchnir, 2004), and inductive learning (Surdeanu et al., 2003).
C04-1197 N04-1030 P03-1002 W04-0817 W04-2415 W04-2417 W04-2418
Many existing SRL systems are also memory-based (Bosch et al., 2004;Kouchnir, 2004), implemented using TilMBL software (http://ilk.kub.nl/software.html) with advanced methods such as Feature Weighting, and so forth.
W04-2418
Execution time by Palmer (2005) is about 4 times longer than PARA+PML on the same machine (n.b.
J05-1004
Execution time for our own re-implementation of Palmer (2005) is about 3.785 sec per sentence.
J05-1004
In the second row (PARA+PML) is trained on all datasets (WSJ 02 to 21) for the “BR+RL” task (to recognize argument boundaries and label arguments) on the test data WSJ 23, with an improvement of F1:8.28 in comparison to the result of Palmer et al., (2005) given in the 185 first row.
J05-1004
