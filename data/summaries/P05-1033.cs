To do this, we first identify initial phrase pairs using the same criterion as previous systems (Och and Ney, 2004; Koehn et al., 2003): Definition 1.
J04-4002 N03-1017 P03-1021
For our experiments we used the following features, analogous to Pharaoh’s default feature set: • P(γ | α) and P(α | γ), the latter of which is not found in the noisy-channel model, but has been previously found to be a helpful feature (Och and Ney, 2002); • the lexical weights Pw(γ | α) and Pw(α | γ) (Koehn et al., 2003), which estimate how well the words in α translate the words in γ;2 • a phrase penalty exp(1), which allows the model to learn a preference for longer or shorter derivations, analogous to Koehn’s phrase penalty (Koehn, 2003).
N03-1017 P02-1038 P03-1021
Our evaluation metric was BLEU (Papineni et al., 2002), as calculated by the NIST script (version 11a) with its default settings, which is to perform case-insensitive matching of n-grams up to n = 4, and to use the shortest (as opposed to nearest) reference sentence for the brevity penalty.
P02-1040
5We used Zhang’s significance tester (Zhang et al., 2004), which uses bootstrap resampling (Koehn, 2004b); it was modified to conform to NIST’s current definition of the BLEU brevity penalty.
W04-3250
The alignment template translation model (Och and Ney, 2004) and related phrase-based models advanced the previous state of the art by moving from words to phrases as the basic unit of translation.
J04-4002
The baseline system we used for comparison was Pharaoh (Koehn et al., 2003; Koehn, 2004a), as publicly distributed.
N03-1017 W04-3250
A system like that of Yamada and Knight (2001) is both formally and linguistically syntax-based: formally because it uses synchronous CFG, linguistically because the structures it is defined over are (on the English side) informed by syntactic theory (via the Penn Treebank).
P01-1067
Other phrase-based models model the joint distribution P(e, f ) (Marcu and Wong, 2002) or made P(e) and P( f | e) into features of a log-linear model (Och and Ney, 2002).
P02-1038 W02-1018
The basic phrase-based model is an instance of the noisy-channel approach (Brown et al., 1993),1 in which the translation of a French sentence f into an 1Throughout this paper, we follow the convention of Brown et al.of designating the source and target languages as “French” and “English,” respectively.
J93-2003
But Koehn et al.(2003) find that phrases longer than three words improve performance little, suggesting that data sparseness takes over for longer phrases.
N03-1017
Above the phrase level, these models typically have a simple distortion model that reorders phrases independently of their content (Och and Ney, 2004; Koehn et al., 2003), or not at all (Zens and Ney, 2004; Kumar et al., 2005).
J04-4002 N03-1017 N04-1033 P03-1021 W04-3250
This involves running GIZA++ (Och and Ney, 2000) on the corpus in both directions, and applying refinement rules (the variant they designate “final-and”) to obtain a single many-to-many word alignment for each sentence.
P00-1056
In this respect it resembles Wu’s 264 bilingual bracketer (Wu, 1997), but ours uses a different extraction method that allows more than one lexical item in a rule, in keeping with the phrasebased philosophy.
J97-3002
We ran the trainer with its default settings (maximum phrase length 7), and then used Koehn’s implementation of minimumerror-rate training (Och, 2003) to tune the feature weights to maximize the system’s BLEU score on our development set, yielding the values shown in Table 2.
N03-1017 P03-1021
We obtain the word alignments using the method of Koehn et al.(2003), which is based on that of Och and Ney (2004).
J04-4002 N03-1017 W04-3250
When we run a phrase-based system, Pharaoh (Koehn et al., 2003; Koehn, 2004a), on this sentence (using the experimental setup described below), we get the following phrases with translations: (4) [Aozhou] [shi] [yu] [Bei Han] [you] [bangjiao]1 [de shaoshu guojia zhiyi] [Australia] [is] [dipl.
N03-1017 W04-3250
Following Och and Ney (2002), we depart from the traditional noisy-channel approach and use a more general log-linear model.
P02-1038
A lexicalized phrase-reordering model like that in use in ISI’s system (Och et al., 2004) might be able to learn a better reordering, but simpler distortion models will probably not.
J04-4002
We compared a baseline system, the state-of-the-art phrase-based system Pharaoh (Koehn et al., 2003; Koehn, 2004a), against our system.
N03-1017 W04-3250
This feature adds a factor to (17), (20) c(i, j) =    1 if f ji is a constituent 0 otherwise as determined by a statistical tree-substitutiongrammar parser (Bikel and Chiang, 2000), trained on the Penn Chinese Treebank, version 3 (250k words).
W00-1201
Koehn et al.(2003) mention German 〈es gibt, there is〉 as an example of a good phrase pair which is not a syntactic phrase pair, and report that favoring syntactic phrases does not improve accuracy.
N03-1017
