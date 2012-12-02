However, additional aspects of a document inuence its relevance, including, e.g., the evidential status of the material presented, and the attitudes expressed about the topic (Kessler et al., 1997).
P97-1005
Lin. 1998.
P98-2127
Additionally, these ndings suggest that it may be possible to automatically correct the type biases expressed by the taggers using the technique described in (Bruce and Wiebe, 1999), a topic that will be investigated in future work.
P99-1032
Knowledge of subjective language would also be useful in ame recognition (Spertus, 1997;; Kaufer, 2000), email classi cation (Aone et al., 2000), intellectual attribution in text (Teufel and Moens, 2000), recognizing speaker role in radio broadcasts (Barzilayet al., 2000), review mining (Terveen et al., 1997), generation and style (Hovy, 1987), clustering documents by ideological point of view (Sack, 1995), and any other application that would bene t from knowledgeofhowopinionatedthe languageis, and whether or not the writer purports to objectively present factual material.
W00-1302
Work on Subjectivity Tagging In previous work (Wiebe et al., 1999;; Bruce and Wiebe, 1999), a corpus of sentences from the Wall Street Journal Treebank Corpus (Marcus et al., 1993) was manually annotated with subjectivity classi cations bymultiplejudges.
J93-2004 P99-1032
Recall that the sentences of this corpus were manuallyannotated with subjectivity classi cations as described in (Wiebe et al., 1999;; Bruce and Wiebe, 1999).
P99-1032
Among Taggers There are techniques for analyzing agreement when annotations involve segment boundaries (Litman and Passonneau, 1995;; Marcu et al., 1999), but our focus in this paper is on words.
P95-1015
Additionally,itmaybe possible to re ne the classi cations automatically using methods such as those described in (Wiebe et al., 1999).
P99-1032
One judge annotated allarticles in four datasets of the Wall Street Journal Treebank corpus (Marcus et al., 1993) (W9-4, W9-10, W9-22, and W933, each approximately 160K words) as well as thecorpusofWall Street Journal articles used in (Wiebe et al., 1999) (called WSJ-SE below).
J93-2004 P99-1032
For a more complete description of these models and their use in analyzing intercoder reliability see (Bruce and Wiebe, 1999).
P99-1032
Based on previous work (Wiebe et al., 1998), we hypothesized that low-frequency words are associated with subjectivity.Table 6 provides evidence that the number of unique words (words that appear just once) in subjective elements is higher than expected.
W98-1126
We use three text categories: editorials (Kessler et al., 1997), reviews, and \ames", i.e., hostile messages (Spertus, 1997;; Kaufer, 2000).
P97-1005
The highagreementon adjectives inbothgenres isconAll Words Nouns Verbs Modals Adj's Adverbs Det's NG-FE 0:4657 0:5213 0.4571 0:4008 0:5011 0:3576 0:4286 WSJ-SE, Exp1 0:4228 0:3999 0.4235 0:6992 0:6000 0:4328 0:2661 WSJ-SE, Exp2 0:3703 0:3705 0.4261 0:4298 0:4294 0:2256 0:1234 Table 2:  Values for Word Agreement sistent with results from other work (Bruce and Wiebe, 1999;; Wiebe et al., 1999), but high agreementon nouns inthe amedata verses highagreement on modals in the WSJ data suggests a genre speci c usage of these categories.
P99-1032
Toidentify richer features, (Wiebe, 2000) used Lin's (1998) method for clustering words according to distributional similarity,seededby a small amount of detailed manual annotation, to automatically identify adjective PSEs.
P98-2127 W98-1126
All corpora were stemmed (Karp et al., 1992) and part-of-speech tagged (Brill, 1992).
A92-1021 C92-3145
For references to work on subjectivity, please see (Ban eld, 1982;; Fludernik, 1993;; Wiebe, 1994;; Stein and Wright, 1995).
J94-2004
Brill. 1992.
A92-1021
R.Bruce andJ.Wiebe. 1999.
P99-1032
A subjective element is an instance of a potential subjective element, in a particular context, that is indeed subjectiveinthatcontext (Wiebe, 1994).
J94-2004
Subjectivity in natural language refers to aspects of language used to express opinions and evaluations (Ban eld, 1982;; Wiebe, 1994).
J94-2004
Wiebe. 1994.
J94-2004
