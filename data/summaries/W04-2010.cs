Yarowsky and Wicentowski (2000) present a corpus-based approach for morphological analysis of both regular and irregular forms based on four models including: relative corpus frequency, context similarity, weighted string similarity and incremental retraining of inflectional transduction probabilities.
P00-1027
Thede and Harper (1997) consider contextual information, word endings, entropy and open-class smoothing.
W97-0124
Another interesting work, exploiting capitalisation and fixed/variable suffixes, is presented in Cucerzan and Yarowsky (2000).
P00-1027 P00-1035
Gaussier (1999) induces derivational morphology from a lexicon by means of p-similarity based splitting.
W99-0904
The XEROX tagger comes with a list of built-in ending guessing rules (Cutting et al.,1992). In addition to the ending, Weischedel et al.(1993) exploit capitalisation.
A92-1018 J93-2006
looks like Mikheev (1997) did not observe that kind of redundancy.
J97-3003
Ruch et al.(2000) combine POS guessing, contextual rules and Markov models to build a POS tagger for biomedical text.
W00-0722
Next, it looks promising to try to estimate the dictionary word frequencies using a search engine instead of text corpus, as proposed by Lapata and Keller (2004).
N04-1016
Schone and Jurafsky (2000) apply latent semantic analysis for a knowledge-free morphology induction.
W00-0712
Yarowsky. 2000.
P00-1027
Mikheev (1997) proposes a similar approach, but learns the rules from raw as opposed to tagged text.
J97-3003
Rules Our approximate rules are similar to the ones proposed by Mikheev (1997), who uses a dictionary to build POS prediction rules with four parts: deletion (–), addition (+), checking against the dictionary ()? and POS assignment (;).
J97-3003
