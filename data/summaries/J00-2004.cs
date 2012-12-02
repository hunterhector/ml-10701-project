II cooc(.,). In informal experiments described elsewhere (Melamed 1995), I found that the G 2 statistic suggested by Dunning (1993) slightly outperforms ¢2.
J93-1003 W95-0115
Applications where word order is not essential include • cross-language information retrieval (e.g., McCarley 1999), • multilingual document filtering (e.g., Oard 1997), • computer-assisted language learning (e.g., Nerbonne et al.1997), • certain machine-assisted translation tools (e.g., Macklovitch 1994; Melamed 1996a), • concordancing for bilingual lexicography (e.g., Catizone, Russell, and Warwick 1989; Gale and Church 1991), 222 Melamed Models of Translational Equivalence • corpus linguistics (e.g., Svartvik 1992), • "crummy" machine translation (e.g., Church and Hovy 1992; Resnik 1997).
A97-1020 C96-2129 H91-1026 P99-1027 W97-0213
"The mathematics of statistical machine translation" proposed by Brown et al.(1993b) are just one kind of mathematics for one kind of statistical trans100 98 96 >, o 94 o 92 90 88 86 84 (99.2%) 0%) rrlct ~(92.8%) (91.6%) t"-..
H93-1039 J93-2003
Unlike the models proposed by Brown et al.(1993b), this model is symmetric, because both word bags are generated together from a joint probability distribution.
H93-1039 J93-2003
More recently, Brown et al.(1988) suggested that it may be possible to construct machine translation systems automatically.
C88-1016
Vogel, Ney, and Tillmann (1996) have shown how some additional assumptions can turn this model into a hidden Markov model, enabling even more efficient parameter estimation.
C96-2141
If each word's translation is treated as a sense tag (Resnik and Yarowsky 1997), then "translational" collocations have the unique property that the collocate and the word sense are one and the same!
W97-0213
Gale and Church (1991) have shown that entries at the very top of the list can be over 98% correct.
H91-1026
Almost all the similarity functions in the literature are based on a model of co-occurrence with some linguistically motivated filtering (see Fung \[1995\] for a notable exception).
P95-1032
However, Equation 26 is a sum rather than a product, so I scale the trans parameters logarithmically, to be consistent with its probabilistic interpretation: scoreA(u, v) = log trans(u, v) (28) 5.2 Method B: Improved Estimation Using an Explicit Noise Model Yarowsky (1993, 271) has shown that "for several definitions of sense and collocation, an ambiguous word has only one sense in a given collocation with a probability of 90-99%".
H93-1052
Choosing the most advantageous, Hiemstra has published parts of the translational distributions of certain words, induced using both his method and Brown et al.'s (1993b) Model 1 from the same training bitext.
H93-1039 J93-2003
The performance of cross-language information retrieval with a uniform T is likely to be limited in the same way as the performance of conventional information retrieval without term-frequency information, i.e., where the system knows which terms occur in which documents, but not how often (Buckley 1993).
H93-1070
Due to the parameter interdependencies introduced by the one-to-one assumption, we are unlikely to find a method for decomposing the assignments into parameters that can be estimated independently of each other as in Brown et al.\[1993b, Equation 26\]).
H93-1039 J93-2003
Sequence-to-Sequence Translation Models Most probabilistic translation model reestimation algorithms published to date are variations on the theme proposed by Brown et al.(1993b). These models involve conditional probabilities, but they can be compared to symmetric models if the latter are normalized by the appropriate marginal distribution.
H93-1039 J93-2003
For example, Gale and Church (1991, 154) suggest that "~b 2, a X2-1ike statistic, seems to be a particularly good choice because it makes good use of the off-diagonal cells" in the contingency table.
H91-1026
Models of translational equivalence that are ignorant of indirect associations have "a tendency.., to be confused by collocates" (Dagan, Church, and Gale 1993,5).
W93-0301
(h, jl)}, where each i ranges over {IJ 1 ..... 11l}, eachj ranges over {v~ ..... x~}, 3 Assignments are different from Brown, Della Pietra, Della Pietra, and Mercer's (1993) alignments in that assignments can range over pairs of arbitrary labels, not necessarily sequence position indexes.
H93-1039 J93-2003
Brown et al.(1988) introduced the idea that this correlation can be encoded in translation model parameters.
C88-1016
(Wu and Xia 1994, 211) This is a reasonable evaluation method, but it is not comparable to methods that simply count each lexicon entry as either right or wrong (e.g., Daille, Gaussier, and Lang6 1994; Melamed 1996b).
C94-1084 C96-2129
Translation Lexicons Many researchers have proposed greedy algorithms for estimating nonprobabilistic word-to-word translation models, also known as translation lexicons (e.g., Catizone, Russell, and Warwick 1989; Gale and Church 1991; Fung 1995; Kumano and Hirakawa 1994; Melamed 1995; Wu and Xia 1994).
C94-1009 H91-1026 P95-1032 W95-0115
In the models of Brown, Della Pietra, Della Pietra, and Mercer (1993), reviewed in Section 4.3, s COOC(R, V) = ~ ei(u) .j~(V), (12) i=1 where ei and j5 are the unigram frequencies of u and v, respectively, in each aligned text segment i.
H93-1039 J93-2003
For statistical machine translation, the translational distribution can be decoded with a source language model (Brown et al.1988; A1-Onaizan et al.1999). To predict how the different models might perform in such applications, the whole distribution task was to generate a whole set of links from each input word, weighted according to the probability assigned by the model to each of the input word's translations.
C88-1016
Brown et al.1993). When the auxiliary parameters are conditioned on different link classes, their optimization is carried out separately for each class: B (links (u, v)\[cooc(u, v), A +) scorec(u, vlZ = class(u, v)) = log B(links(u, v)\[cooc(u, v), A z)" (37) Section 6.1.1 describes the link classes used in the experiments below.
H93-1039 J93-2003
is instructive to consider the form of Equation 14 when all the translation probabilities trans(v\[u) for a particular u are initialized to the same constant p, as Brown et al.(1993b, 273) actually do: transl(v\]u) : z E p.e(u) .f(v) (15) (u,v)c(u,v) p.
H93-1039 J93-2003
Applications where word order is crucial include speech transcription for translation (Brousseau et al.1995), bootstrapping of OCR systems for new languages (Philip Resnik and Tapas Kanungo, personal communication), interactive translation (Foster, Isabelle, and Plamondon 1996), and fully automatic high-quality machine translation (e.g., A1-Onaizan et al.1999). In such applications, a word-to-word translation model can serve as an independent module in a more complex sequence-tosequence translation model.
C96-1067
Yet very few other researchers have taken up the cause, partly because Brown et al.'s (1988) approach was quite a departure from the paradigm in vogue at the time.
C88-1016
6. Evaluation 6.1 Evaluation at the Token Level This section compares translation model estimation methods A, B, and C to each other and to Brown et al.'s (1993b) Model 1.
H93-1039 J93-2003
I performed a post hoc evaluation of the link types produced by an earlier version of Method B (Melamed 1996b).
C96-2129
There are many plausible representations, such as pairs of trees from synchronous tree adjoining grammars (Abeill6 et al.1990; Shieber 1994; Candito 1998), lexical conceptual structures (Dorr 1992) and WordNet synsets (Fellbaum 1998; Vossen 1998).
P98-1033
The bitext used for this evaluation was the same aligned Hansards bitext used by Gale and Church (1991), except that I used only 300,000 aligned segment pairs to save time.
H91-1026
One-sided variants, which consider only source words, have also been used (Gale and Church 1991).
H91-1026
A similar strategy was employed by Wu and Xia (1994) and by Fung (1995).
P95-1032
A word order correlation bias, as well as the phrase structure biases in Brown et al.'s (1993b) Models 4 and 5, would be less beneficial with noisier training bitexts or for language pairs with less similar word order.
H93-1039 J93-2003
In this situation, Brown et al.(1993b, 293) recommend "evaluating the expectations using only a single, probable alignment".
H93-1039 J93-2003
expression is obtained by substituting Brown, Della Pietra, Della Pietra, and Mercer's (1993) Equation 17 into their Equation 14.
H93-1039 J93-2003
Formally, Brown et al.(1988) built statistical models of translational equivalence (or translation models 1, for short).
C88-1016
White and O'Connell 1993) or using relative metrics, such as perplexity with respect to other models (Brown et al.1993b). Objective and more accurate tests can be carried out using a "gold standard".
H93-1039 H93-1040 J93-2003
Dagan, Church, and Gale (1993) expanded on this idea by replacing Brown et al.'s (1988) word alignment parameters, which were based on absolute word positions in aligned segments, with a much smaller set of relative offset parameters.
C88-1016 W93-0301
