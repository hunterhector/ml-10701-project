Strapping may be harder in cases like gender induction: it is hard to stumble into the kind of detailed seed used by Cucerzan and Yarowsky (2003).
N03-1006
Yarowsky algorithm Yarowsky (1995) sparked considerable interest in bootstrapping with his successful method for word sense disambiguation.
P95-1026
Pseudowords should be plausible instances of the task (Gaustad, 2001; Nakov and Hearst, 2003): so it is deliberate that banana and wine share syntactic and semantic features, as senses of real ambiguous words often do.
N03-2023
Cucerzan and Yarowsky (1999) built a similar system that identified proper names as well as classifying them.
W99-0612
9By contrast, Gale et al.(1992b) used the French portion as a source of training supervision.
H92-1045
This has obvious benefits for training an English-to-French MT system: separate parameters can be learned for the two senses of drug.7 Gale et al.(1992b) identified six such words in the Canadian Hansards, a parallel sentence-aligned corpus of parliamentary debate in English and French: drug, duty, land, language, position, sentence.
H92-1045
8We are not certain that our version of the Hansards is identical to that in (Gale et al., 1992b).
H92-1045
While they begin with a small translation lexicon, they are sufficiently robust to the choice of this initial seed (lexicon) that it suffices to construct a single seed by crude automatic means (Brown et al., 1990; Melamed, 1997).
J90-2002 P97-1063
Our experiments on the Canadian Hansards show that our unsupervised technique is significantly more effective than picking seeds by hand (Yarowsky, 1995), which in turn is known to rival supervised methods.
P95-1026
Strapping would guess various different seeds that extended the original document, then try to determine which seeds found a cohesive “relevant set.” Collins and Singer (1999) bootstrapped a system for classifying phrases in context.
W99-0613
In this paper, we showed that it is sometimes possible— indeed, preferable—to eliminate the initial bit of supervision in “bootstrapping” algorithms such as the Yarowsky (1995) algorithm for word sense disambiguation.
P95-1026
2Ando and Zhang (2005) independently used this phrase, for a semi-supervised, cross-task learner that differs from our unsupervised, cross-instance learner.
P05-1001
We extracted all examples of each word from the 14-million-word English portion of the Hansards.8 Note that this is considerably smaller than Yarowsky’s (1995) corpus of 460 million words, so bootstrapping will not perform as well, and may be more sensitive to the choice of seed.
P95-1026
In the case of word-sense disambiguation, one can automatically construct ambiguous pseudowords (Gale et al., 1992c; Sch¨utze, 1998) by replacing all occurences of two words or phrases with their conflation.
H92-1045
Cucerzan and Yarowsky (2003) classified masculine vs.
N03-1006
Riloff et al.(2003) learned lists of subjective nouns in English, seeding their method with 20 high-frequency, strongly subjective words.
W03-0404
In the supervised condition, we used just 2 additional task instances, plant and tank, each with 4000 handannotated instances drawn from a large balanced corpus (Yarowsky, 1995).
P95-1026
This property tends to hold for correct classifiers (Gale et al., 1992a), at least for homonyms.
H92-1045
