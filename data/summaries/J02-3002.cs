Initially the system described in this article was developed as a text normalization module for a named-entity recognition system (Mikheev, Grover, and Moens 1998) that participated in MUC-7.
M98-1021
Thus, for instance, we do not expect our system to perform well on single-cased texts (e.g., texts written in all capital or all lower-cased letters) or on 3 Palmer and Hearst (1997) report a speed of over 10,000 sentences a minute, which with their average sentence length of 20 words equals over 3,000 words per second, but on a slower machine (DEC Alpha 3000).
J97-2002
In the disambiguation of capitalized words, the most widespread method is POS tagging, which achieves about a 3% error rate on the Brown corpus and a 5% error rate on the WSJ corpus, as reported in Mikheev (2000).
A00-2035
It has been applied not only to the identification of proper names, as described in this article, but also to their classification (Mikheev, Grover, and Moens 1998).
M98-1021
The error rate on sentence boundaries in the Brown corpus was not significantly worse than the lowest quoted before (Riley 1989: 0.28% vs.
H89-2048
E-mail: mikheev@cogsci.ed.ac.uk 290 Computational Linguistics Volume 28, Number 3 Proper names are the main concern of the named-entity recognition subtask (Chinchor 1998) of information extraction.
M98-1001
We see no good reason, however, why such text spans should necessarily be sentences, since the majority of tagging paradigms (e.g., Hidden Markov Model [HMM] [Kupiec 1992], Brill’s [Brill 1995a], and MaxEnt [Ratnaparkhi 1996]) do not attempt to parse an entire sentence and operate only in the local window of two to three tokens.
J95-4004 W95-0101 W96-0213
This is similar to “one sense per collocation” idea of Yarowsky (1993).
H93-1052
This was done because purely unsupervised techniques (e.g., Baum-Welch [Baum and Petrie 1966] or Brill’s [Brill 1995b]) enable regularities to be induced for word classes which contain many entries, exploiting the fact that individual words that belong to a POS class occur in different ambiguity patterns.
J95-4004 W95-0101
For instance, the Alembic workbench (Aberdeen et al.1995) contains a sentence-splitting module that employs over 100 regular-expression rules written in Flex.
M95-1012
The best performance on the Brown corpus, a 0.2% error rate, was reported by Riley (1989), who trained a decision tree classifier on a 25-million-word corpus.
H89-2048
This is implemented as a cascade of simple strategies, which were briefly described in Mikheev (1999).
P99-1021
Gale, Church, and Yarowsky (1992) showed that words strongly tend to exhibit only one sense in a document or discourse (“one sense per discourse”).
H92-1045
On the WSJ corpus our system performed slightly better than the combination of the Alembic and SATZ systems described in Palmer and Hearst (1997) (0.44% vs.
J97-2002
For the development of these lists we used a collection of texts of about 300,000 words derived from the New York Times (NYT) corpus that was supplied as training data for the 7th Message Understanding Conference (MUC-7) (Chinchor 1998).
M98-1001
As Church (1988) rightly pointed out, however, “Proper nouns and capitalized words are particularly problematic: some capitalized words are proper nouns and some are not.
A88-1019
In this case apart from the error rate (which corresponds to precision or accuracy as 1−error rate) we also measure the system’s coverage or recall coverage = correctly assigned all to be assigned 2.1 Corpora for Evaluation There are two corpora normally used for evaluation in a number of text-processing tasks: the Brown corpus (Francis and Kucera 1982) and the Wall Street Journal (WSJ) corpus, both part of the Penn Treebank (Marcus, Marcinkiewicz, and Santorini 1993).
J93-2004
The simplest strategy for deciding whether or not a capitalized word in an ambiguous position is a proper name is to apply a lexical-lookup strategy (possibly enhanced with a morphological word guesser, e.g., Mikheev [1997]).
J97-3003
This is where robust syntactic systems like SATZ (Palmer and Hearst 1997) or the POS tagger reported in Mikheev (2000), which do not heavily rely on word capitalization and are not sensitive to document length, have an advantage.
A00-2035 J97-2002
Unlike other POS taggers, this POS tagger (Mikheev 2000) was also trained to disambiguate sentence boundaries.
A00-2035
In some systems such dependencies are learned from labeled examples (Bikel et al.1997). The advantage of the namedentity approach is that the system not only identifies proper names but also determines their semantic class.
A97-1029
Park and Byrd (2001) recently described a hybrid method for finding abbreviations and their definitions.
W01-0516
Since then this idea has been applied to several tasks, including word sense disambiguation (Yarowsky 1995) and named-entity recognition (Cucerzan and Yarowsky 1999).
P95-1026 W99-0612
For instance, Palmer and Hearst (1997) report that the SATZ system (decision tree variant) was trained on a set of about 800 labeled periods, which corresponds to a corpus of about 16,000 words.
J97-2002
We used these texts because the approach described in this article was initially designed to be part of a named-entity recognition system (Mikheev, Grover, and Moens 1998) developed for MUC-7.
M98-1021
Thus, the second class of SBD systems employs machine learning techniques such as decision tree classifiers (Riley 1989), neural networks (Palmer and Hearst 1994), and maximum-entropy modeling (Reynar and Ratnaparkhi 1997).
A94-1013 A97-1004 H89-2048 J97-2002
The best performance on the WSJ corpus was achieved by a combination of the SATZ system (Palmer and Hearst 1997) with the Alembic system (Aberdeen et al.1995): a 0.5% error rate.
J97-2002 M95-1012
A detailed introduction to the SBD problem can be found in Palmer and Hearst (1997).
J97-2002
