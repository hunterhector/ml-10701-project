Test and training materials were derived from the Brown corpus of American English, all of which has been parsed and manually verified by the Penn T~eebank project (Marcus et al., 1993) and parts of which have been manually sense-tagged by the WordNet group (Miller et al., 1993).
H93-1061 J93-2004
In other work, Yarowsky (1993) has shown that local collocational information, including selectional constraints, can be used to great effect in sense disambiguation, though his algorithm requires super55 vised training.
H93-1052
Unsupervised Method for Sense Disambiguation Table 1 presents a selected sample of Resnik's (1993a) comparison with argument plausibility judgments made by human subjects.
H93-1054
The simplest way to use the resulting scores, following Miller et al.(1994), is as follows: if n has only one sense, select it; otherwise select the sense st for which at is greatest, breaking ties by random choice.
H94-1046
Closely related proposals have been applied in syntactic disambiguation (Resnik, 1993b; Lauer, 1994) and to automatic acquisition of more KatzFodoresque selection restrictions in the form of weighted disjunctions (Ribas, 1994).
H93-1054 P94-1052
In marked contrast to annotated training material for partof-speech tagging, (a) there is no coarse-level set of sense distinctions widely agreed upon (whereas part-of-speech tag sets tend to differ in the details); (b) sense annotation has a comparatively high error rate (Miller, personal communication, reports an upper bound for human annotators of around 90% for ambiguous cases, using a non-blind evaluation method that may make even this estimate overly optimistic); and (c) no fully automatic method provides high enough quality output to support the "annotate automatically, correct manually" methodology used to provide high volume annotation by data providers like the Penn Treebank project (Marcus et al., 1993).
J93-2004
In that respect, the most direct point of comparison is the performance of Miller et al.'s (1994) frequency heuristic always choose the most frequent sense of a word as evaluated using the full sense-tagged corpus, including nouns, verbs, adjectives, and adverbs.
H94-1046
One experiment where results were reported was conducted by Cowie et al.(1992); their method involved using a stochastic search procedure to maximize the overlap in dictionary definitions (LDOCE) for alternative senses of words co-occurring in a sentence.
C92-1056
More important is information beyond selectional preference, notably the wider context utilized by Yarowsky (1992).
C92-2070
Formally, selectional association is defined as: Am(p, c) -1 Pr(c\[p) Pr(c\[p) log Pr(c) " This model of selectional preference has turned out to make reasonable predictions about human judgments of argument plausibility obtained by psycholinguistic methods (Resnik, 1993a).
H93-1054
Preference as Statistical Association The treatment of selectional preference used here is that proposed by Resnik (1993a; 1996), combining statistical and knowledge-based methods.
H93-1054
Baseline. Following Miller et al.(1994), disambiguation by random choice was used as a baseline: if a noun has one sense, use it; otherwise select at random among its senses.
H94-1046
Pereira et al.(1993)). I This estimation method is similar to that used by Yarowsky (1992) for Roget's thesaurus categories, and works for similar reasons.
C92-2070 P93-1024
The approach combines statistical and knowledge-based methods, but unlike many recent corpus-based approaches to sense disambiguation (¥arowsky, 1993; Bruce and Wiebe, 1994; Miller et al., 1994), it takes as its starting point the assumption that senseannotated training text is not available.
H94-1046 P94-1020
The best results reported for an unsupervised sense disambiguation method are those of Yarowsky (1992), who uses evidence from a wider context (a window of 100 surrounding words) to build up a co-occurrence model using classes from Roget's thesaurus.
C92-2070
