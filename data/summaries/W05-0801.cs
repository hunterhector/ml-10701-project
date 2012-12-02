Obviously, we are building directly on the work of Melamed (2000), sharing his use of the LLR statistic and adopting his competitive linking algorithm.
J00-2004
Finally, our work is similar to that of Cherry and Lin (2003) in our use of the conditional probability of a link given the co-occurrence of the linked words.
P03-1012
We chose this statistic because it has previously been found to be effective for automatically constructing translation lexicons (e.g., Melamed, 2000).
J00-2004
We report the performance of various alignment algorithms in terms of precision, recall, and alignment error rate (AER) as defined by Och and Ney (2003): recall = |A ∩ S| |S| precision = |A ∩ P| |A| AER = 1− |A ∩ P|+ |A ∩ S| |A| + |S| In these definitions, S denotes the set of alignments annotated as sure, P denotes the set of alignments annotated possible or sure, and A denotes the set of alignments produced by the method under test.
J03-1002
We trained and evaluated the models in both directions, English-toFrench and French-to-English, as well as the union, intersection, and what Och and Ney (2003) call the “refined” combination of the two alignments.
J03-1002
Log-Likelihood-Ratio Association Measure We base all our association-based word-alignment methods on the log-likelihood-ratio (LLR) statistic introduced to the NLP community by Dunning (1993).
J93-1003
Although the best performing systems are “phrasebased” (see, for instance, Och and Ney (2004) or Koehn et al.(2003)), possible phrase translations must first be extracted from word-aligned bilingual text segments.
J03-1002 N03-1017
The standard approach to word alignment makes use of five translation models defined by Brown et al.(1993), sometimes augmented by an HMM-based model or Och and Ney’s “Model 6” (Och and Ney, 2003).
J03-1002 J93-2003
and the hand alignments of the words in the trial and test data were created by Franz Och and Hermann Ney (Och and Ney, 2003).
J03-1002
We compute LLR scores using the following formula presented by Moore (2004): LLR(f,e)= summationdisplay f?∈{f,¬f} summationdisplay e?∈{e,¬e} C(f?,e?)log p(f?|e?) p(f?) In this formula f and e mean that the words whose degree of association is being measured occur in the respective target and source sentences of an aligned sentence pair, ¬f and ¬e mean that the corresponding words do not occur in the respective sentences, f? and e? are variables ranging over these values, and C(f?,e)? is the observed joint count for the values of f? and e?.
W04-3243
Gale and Church (1991) made what may be the first application of word association to word alignment.
H91-1026
This is the method that Melamed uses to generate an initial alignment that he refines by re-estimation in his “Method A” (Melamed, 2000).
J00-2004
The conventional wisdom in the statistical MT community has been that “heuristic” alignment methods based on word association statistics could not be competitive with methods that have a “well-founded mathematical theory that underlies their parameter estimation” (Och and Ney, 2003, p.
J03-1002
and Methodology for these Experiments The experiments reported here were carried out using data from the workshop on building and using parallel texts held at HLT-NAACL 2003 (Mihalcea and Pedersen, 2003).
W03-0301
The simplest method we consider uses the LLR scores to link words according to Melamed’s (2000) “competitive linking algorithm” for aligning words in a pair of sentences.
J00-2004
For this combination, the optimal value on the development set for the first score threshold of Method C was about 0.65 and the optimal value of the second score threshold of Method C was about 0.075. 7 Evaluation We computed the recall, precision, and AER on the held-out subset of the English-French data both for our Method 4C (using parameter values optimized on the development subset) and for IBM Model 4, computed using Och’s Giza++ software package (Och and Ney, 2003) trained on the same data as Method 4C.
J03-1002
Moore. 2004.
W04-3243
