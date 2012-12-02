These applications crucially depend on the quality of the word alignment (Och and Ney 2000; Yarowsky and Wicentowski 2000).
C00-2163 P00-1027
2.3 Fertility-Based Alignment Models In the following, we give a short description of the fertility-based alignment models of Brown, Della Pietra, Della Pietra, and Mercer (1993).
H93-1039 J93-2003
(For further details on the greedy search algorithm, see Brown, Della Pietra, Della Pietra, and Mercer [1993]).
H93-1039 J93-2003
In Melamed (2000), a further simplification is performed that enforces a one-to-one alignment for nonempty words.
J00-2004
In the work presented here, we use a more efficient greedy search algorithm for the best alignment, as suggested in Brown, Della Pietra, Della Pietra, and Mercer (1993).
H93-1039 J93-2003
In the M-step, the lexicon parameters are computed: p(f | e)= summationtext s c(f | e; f s, e s ) summationtext s,f c(f | e; f s, e s ) (36) Similarly, the alignment and fertility probabilities can be estimated for all other alignment models (Brown, Della Pietra, Della Pietra, and Mercer 1993).
H93-1039 J93-2003
Definition We follow Brown, Della Pietra, Della Pietra, and Mercer (1993) to define alignment as an object for indicating the corresponding words in a parallel text.
H93-1039 J93-2003
One method is to choose as alignment a j = i for position j the word with the largest association score: a j = argmax i {dice(i, j)} (7) A refinement of this method is the competitive linking algorithm (Melamed 2000).
J00-2004
The software used to train the statistical alignment models described in this article is publicly available (Och 2000).
C00-2163
effect did not occur in Brown, Della Pietra, Della Pietra, and Mercer (1993), as Models 3 and 4 were not trained directly.
H93-1039 J93-2003
• Och and Ney (2000) suggest that the effective multiplicity of a dictionary entry be set to a large value µ + greatermuch 1 if the lexicon entry actually occurs in one of the sentence pairs of the bilingual corpus and to a low value otherwise: µ(e, f)= braceleftBigg µ + if e and f co-occur µ − otherwise (40) As a result, only dictionary entries that indeed occur in the training corpus have a large effect in training.
C00-2163
In Yarowsky, Ngai, and Wicentowski (2001), word alignment is used to transfer text analysis tools such as morphologic analyzers or part-of-speech taggers from a language, such as English, for which many tools already exist to languages for which such resources are scarce.
H01-1035
The use of models that explicitly deal with the hierarchical structures of natural language is very promising (Wu 1996; Yamada and Knight 2001).
P01-1067 P96-1021
Our work follows and extends the methods introduced by Brown, Della Pietra, Della Pietra, and Mercer (1993) by using refined statistical models for the translation process.
H93-1039 J93-2003
In the literature, it is often claimed that the refined alignment models of Brown, Della Pietra, Della Pietra, and Mercer (1993) are not suitable for small corpora because of data sparseness problems.
H93-1039 J93-2003
Considerably simpler methods for obtaining word alignments use a function of the similarity between the types of the two languages (Smadja, McKeown, and Hatzivassiloglou 1996; Ker and Chang 1997; Melamed 2000).
J00-2004 J96-1001 J97-2004
Brown, Della Pietra, Della Pietra, and Mercer (1993) describe a method for obtaining Pr(a prime | e, f) incrementally from Pr(a | e, f) if alignment a differs only by moves or swaps from alignment a prime . This method results in a constant number of operations that is sufficient to calculate the score of a move or the score of a swap.
H93-1039 J93-2003
A similar idea was suggested by Dagan, Church, and Gale (1993).
W93-0301
We consider the five alignment models presented in Brown, Della Pietra, Della Pietra, and Mercer (1993), the hidden Markov alignment model, smoothing techniques, and refinements.
H93-1039 J93-2003
In such systems, the quality of the machine translation output directly depends on the quality of the initial word alignment (Och and Ney 2000).
C00-2163
An obvious application for word alignment methods is the automatic extraction of bilingual lexica and terminology from corpora (Smadja, McKeown, and Hatzivassiloglou 1996; Melamed 2000).
J00-2004 J96-1001
An analysis of the alignments shows that smoothing the fertility probabilities significantly reduces the frequently occurring problem of rare words forming “garbage collectors” in that they tend to align with too many words in the other language (Brown, Della Pietra, Della Pietra, Goldsmith, et al.1993). Without smoothing, we observe early overfitting: The alignment error rate increases after the second iteration of HMM, as shown in Figure 4.
H93-1039 J93-2003
Using a dynamic programming approach, it is possible to obtain the Viterbi alignment for the HMM with a complexity of O(I 2 ·J) (Vogel, Ney, and Tillmann 1996).
C96-2141
This model is also referred to as a homogeneous HMM (Vogel, Ney, and Tillmann 1996).
C96-2141
Straightforward Implementation A straightforward count collection procedure for a sentence pair (f,e) following the description in Brown, Della Pietra, Della Pietra, and Mercer (1993) is as follows: 5 1.
H93-1039 J93-2003
In this paper, we use Models 1 through 5 described in Brown, Della Pietra, Della Pietra, and Mercer (1993), the hidden Markov alignment model described in Vogel, Ney, and Tillmann (1996) and Och and Ney (2000), and a new alignment model, which we call Model 6.
C00-2163 C96-2141 H93-1039 J93-2003
We present a new statistical alignment model, a log-linear combination of the best models of Vogel, Ney, and Tillmann (1996) and Brown, Della Pietra, Della Pietra, and Mercer (1993).
C96-2141 H93-1039 J93-2003
For short sentences, a possible solution could be an A* search algorithm (Och, Ueffing, and Ney 2001).
W01-1408
Such models are called deficient (Brown, Della Pietra, Della Pietra, and Mercer 1993).
H93-1039 J93-2003
For HMM and Models 4 and 5, it is straightforward to extend the alignment parameters to include a dependence on the word classes of the surrounding words (Och and Ney 2000).
C00-2163
A gentle introduction can be found in Knight (1999b).
J99-4005
The fertility-based alignment models (Models 3, 4, and 5) (Brown, Della Pietra, Della Pietra, and Mercer 1993) have a significantly more complicated structure than the simple Models 1 and 2.
H93-1039 J93-2003
Some papers report improvements in the alignment quality of statistical methods when linguistic knowledge is used (Ker and Chang 1997; Huang and Choi 2000).
J97-2004 P00-1050
The method for constructing these alignments (Brown, Della Pietra, Della Pietra, and Mercer 1993) guarantees that for each lexical relationship in every sentence pair, at least one alignment is considered.
H93-1039 J93-2003
Statistical alignment models are often the basis of single-word-based statistical machine translation systems (Berger et al.1994; Wu 1996; Wang and Waibel 1998; Nießen et al.1998; Garc´ıa-Varea, Casacuberta, and Ney 1998; Och, Ueffing, and Ney 2001; Germann et al.2001). In addition, these models are the starting point for refined phrase-based statistical (Och and Weber 1998; Och, Tillmann, and Ney 1999) or example-based translation systems (Brown 1997).
H94-1028 P01-1030 P96-1021 P98-2162 W01-1408 W99-0604
In applications such as statistical machine translation (Och, Tillmann, and Ney 1999), a higher recall is more important (Och and Ney 2000), so an alignment union would probably be chosen.
C00-2163 W99-0604
of Alignment Quality on Translation Quality Alignment models similar to those studied in this article have been used as a starting point for refined phrase-based statistical machine translation systems (Alshawi, Bangalore, and Douglas 1998; Och, Tillmann, and Ney 1999; Ney et al.2000). In Och and Ney (2000), the overall result of the experimental evaluation has been that an improved alignment quality yields an improved subjective quality of the statistical machine translation system as well.
C00-2163 P98-1006 W99-0604
Similarly, we can include dependencies on source and target word classes in Models 4 and 5 (Brown, Della Pietra, Della Pietra, and Mercer 1993).
H93-1039 J93-2003
Another remedy, adopted in Och and Ney (2000), is to choose a value for the parameter p 1 of the empty-word fertility and keep it fixed.
C00-2163
Fertility-based alignment models use the following decomposition and assumptions: 2 Pr(f J 1, a J 1 | e I 1 )=Pr(f J 1, B I 0 | e I 1 ) (21) = Pr(B 0 | B I 1 )· I productdisplay i=1 Pr(B i | B i−1 1, e I 1 )·Pr(f J 1 | B I 0, e I 1 ) (22) = p(B 0 | B I 1 )· I productdisplay i=1 p(B i | B i−1, e i )· I productdisplay i=0 productdisplay j∈B i p(f j | e i ) (23) As might be seen from this equation, we have tacitly assumed that the set B 0 of words aligned with the empty word is generated only after the nonempty positions have 2 The original description of the fertility-based alignment models in Brown, Della Pietra, Della Pietra, and Mercer (1993) includes a more refined derivation of the fertility-based alignment models.
H93-1039 J93-2003
Further improvements in alignments are expected to be produced through the adoption of cognates (Simard, Foster, and Isabelle 1992) and from statistical alignment 46 Computational Linguistics Volume 29, Number 1 models based on word groups rather than single words (Och, Tillmann, and Ney 1999).
W99-0604
22 Computational Linguistics Volume 29, Number 1 Another application of word alignments is in the field of word sense disambiguation (Diab 2000).
W00-0801
As the Viterbi alignment computation itself is very time consuming for Models 3 to 6, the Viterbi alignment is computed only approximately, using the method described in Brown, Della Pietra, Della Pietra, and Mercer (1993).
H93-1039 J93-2003
(For an exact definition of the neighborhood of an alignment, the reader is referred to the Appendix.) • Brown, Della Pietra, Della Pietra, and Mercer (1993) use an even larger set of alignments, including also the pegged alignments, a large set of alignments with a high probability Pr(f J 1, a J 1 | e I 1 ).
H93-1039 J93-2003
In Models 3 and 4 as defined in Brown, Della Pietra, Della Pietra, and Mercer (1993), the alignment model for nonempty words is deficient, but the alignment model for the empty word is nondeficient.
H93-1039 J93-2003
To integrate a dictionary into the EM algorithm, we compare two different methods: • Brown, Della Pietra, Della Pietra, Goldsmith, et al.(1993) developed a multinomial model for the process of constructing a dictionary (by a human lexicographer).
H93-1039 J93-2003
