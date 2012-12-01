1.2 N-Gram Tagging N-gram part of speech taggers (Bahl(1976), Church(1992), Weischedel(1993)) are perhaps the most widely used of tagging algorithms.
J93-2006
Since the advent of manually tagged corpora such as the Brown Corpus and the Penn Treebank (Francis(1982), Marcus(1993)), the efficacy of machine learning for training a tagger has been demonstrated using a wide array of techniques, including: Markov models, decision trees, connectionist machines, transformations, nearest-neighbor algorithms, and maximum entropy (Weischedel(1993), Black(1992), Schmid(1994), Brill(1995),Daelemans(1995),Ratnaparkhi(1996 )).
C94-1027 H92-1023 J93-2004 J93-2006 J95-4004 W96-0102 W96-0213
Complementarity All experiments presented in this paper were run on the Penn Treebank Wall Street Joumal corpus (Marcus (1993)).
J93-2004
In our experiments, we use a standard trigram tagger using deleted interpolation (Jelinek (1980)) and used suffix information for handling unseen words (as was done in Weischedel (1993)).
J93-2006
1.3 Transformation-Based Tagging In transformation-based tagging (Brill (1995)), every word is first assigned an initial tag, This tag is the most likely tag for a word if the word is known and is guessed based upon properties of the word if the word is not known.
J95-4004
In Ratnaparkhi (1996), a maximum entropy tagger is presented.
W96-0213
For instance, we may learn that the Trigram tagger is most accurate at tagging the word up or that the Unigram tagger does best at tagging the word (Daelemans(1996)).
W96-0102
