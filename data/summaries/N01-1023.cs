1998; Goldman and Zhou, 2000) that has been used previously to train classifiers in applications like word-sense disambiguation (Yarowsky, 1995), document classification (Blum and Mitchell, 1998) and named-entity recognition (Collins and Singer, 1999) and apply this method to the more complex domain of statistical parsing.
P95-1026 W99-0613
We obtained 80.02% and 79.64% labeled bracketing precision and recall respectively (as defined in (Black et al., 1991)).
H91-1060
Ratnaparkhi. 1996.
W96-0213
We use a tool described in (Xia et al., 2000) to convert the Penn Treebank into this representation.
W00-1307
They train from the Penn Treebank (Marcus et al., 1993); a collection of 40,000 sentences that are labeled with corrected parse trees (approximately a million word tokens).
J93-2004
The experiments in (Merialdo, 1994; Elworthy, 1994) showed that only in very specific cases HMMs were effective in combining labeled and unlabeled data.
A94-1009 J94-2001
The approach uses the notion of tree rewriting as defined in the Lexicalized Tree Adjoining Grammar (LTAG) formalism (Joshi and Schabes, 1992) 1 which re1 This is a lexicalized version of Tree Adjoining Grammar (Joshi et al., 1975; Joshi, 1985).
C92-2066
We use a CoTraining method (Yarowsky, 1995; Blum and Mitchell, #03 I would like to thank Aravind Joshi, Mitch Marcus, Mark Liberman, B.
P95-1026
Also, we used Adwait Ratnaparkhi’s part-of-speech tagger (Ratnaparkhi, 1996) to tag unknown words in the test data.
W96-0213
(Cutting et al., 1992) reported very high results (96% on the Brown corpus) for unsupervised POS tagging using Hidden Markov Models (HMMs) by exploiting hand-built tag dictionaries and equivalence classes.
A92-1018
Schabes. 1992.
C92-2066
Our approach is closely related to previous CoTraining methods (Yarowsky, 1995; Blum and Mitchell, 1998; Goldman and Zhou, 2000; Collins and Singer, 1999).
P95-1026 W99-0613
Co-Training has been used before in applications like word-sense disambiguation (Yarowsky, 1995), web-page classification (Blum and Mitchell, 1998) and namedentity identification (Collins and Singer, 1999).
P95-1026 W99-0613
We used EVALB (written by Satoshi Sekine and Michael Collins) which scores based on PARSEVAL (Black et al., 1991); with the standard parameter file (as per standard practice, part of speech brackets were not part of the evaluation).
H91-1060
(Collins and Singer, 1999) further extend the use of classifiers that have mutual constraints by adding terms to AdaBoost which force the classifiers to agree (called CoBoosting).
W99-0613
(Collins and Singer, 1999; Goldman and Zhou, 2000) #0F Take these examples as being valuable as training examples and iterate this procedure until the unlabeled data is exhausted.
W99-0613
Generative Model A stochastic LTAG derivation proceeds as follows (Schabes, 1992; Resnik, 1992).
C92-2065 C92-2066
One way to incorporate this into our algorithm would be to incorporate some form of sample selection (or active learning) into the selection of examples that are considered as labeled with high confidence (Hwa, 2000).
W00-1306
Elworthy. 1994.
A94-1009
(Yarowsky, 1995) first introduced an iterative method for increasing a small set of seed data used to disambiguate dual word senses by exploiting the constraint that in a segment of discourse only one sense of a word is used.
P95-1026
Co-training (Blum and Mitchell, 1998; Yarowsky, 1995) can be informally described in the following manner: #0F Pick two (or more) “views” of a classification problem.
P95-1026
6.1 Setup The experiments we report were done on the Penn Treebank WSJ Corpus (Marcus et al., 1993).
J93-2004
(Chelba and Jelinek, 1998) combine unlabeled and labeled data for parsing with a view towards language modeling applications.
P98-1035
