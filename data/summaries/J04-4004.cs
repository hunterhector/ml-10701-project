32 7.3 Unknown Words and Parts of Speech When the parser encounters an unknown word, the first-best tag delivered by Ratnaparkhi’s (1996) tagger is used.
W96-0213
However, Gildea (2001) reimplemented Collins’ Model 1 (essentially Model 2 but without subcats) and altered the P L w and P R w parameters so that they no longer had the top level of context that included the headword (he removed back-off level 0, as depicted in Table 1).
W01-0521
503 Bikel Intricacies of Collins’ Parsing Model Table 4 Overall parsing results using only details found in Collins (1997, 1999).
P97-1003
Partly to this end, in Chiang and Bikel (2002), we explored methods for recovering latent information in treebanks.
C02-1126
8. Evaluation 8.1 Effects of Unpublished Details In this section we present the results of effectively doing a “clean-room” implementation of Collins’ parsing model, that is, using only information available in (Collins 1997, 1999), as shown in Table 4.
P97-1003
Previous work (Goodman 1997) has shown that the inside probability alone is an insufficient scoring metric when comparing chart items covering the same span during decoding and that some estimate of the outside probability of a chart item should be factored into the score.
W97-0302
Not only did they achieve new performance benchmarks on parsing the Penn Treebank (Marcus, Santorini, and Marcinkiewicz 1993), and not only did they serve as the basis of Collins’ own future work (Collins 2000; Collins and Duffy 2002), but they also served as the basis of important work on parser selection (Henderson and Brill 1999), an investigation of corpus variation and the effectiveness of bilexical dependencies (Gildea 2001), sample selection (Hwa 2001), bootstrapping non-English parsers (Hwa, Resnik, and Weinberg 2002), and the automatic labeling of semantic roles and predicate-argument extraction (Gildea and Jurafsky 2000; Gildea and Palmer 2002), as well as that of other research efforts.
J93-2004 P00-1065 P02-1031 P02-1034 W01-0521 W01-0710 W99-0623
Black et al.1992), anything previously generated—that is, anything in the history—can appear in the conditioning context.
H92-1026
In addition to the effects of the unpublished details, we also have new evidence to show that the discriminative power of Collins’ model does not lie where once thought: Bilexical dependencies play an extremely small role in Collins’ models (Gildea 2001), and head choice is not nearly as critical as once thought.
W01-0521
1. Introduction Michael Collins’ (1996, 1997, 1999) parsing models have been quite influential in the field of natural language processing.
P96-1025 P97-1003
Bilexical statistics (Eisner 1996), as represented by the maximal context of the P L w and P R w parameters, serve as a proxy for such semantic preferences, where the actual modifier word (as opposed to, say, merely its part of speech) indicates the particular semantics of its head.
C96-1058
Another consequence of not generating posthead conjunctions and punctuation as first-class words is that they 19 In fact, if punctuation occurs before the head, it is not generated at all—a deficiency in the parsing model that appears to be a holdover from the deficient punctuation handling in the model of Collins (1997).
P97-1003
For example, Gildea (2001) reimplemented Collins’ Model 1 but obtained results with roughly 16.7% more relative error than Collins’ reported results using that model.
W01-0521
Recently, in order to continue our work combining word sense with parsing (Bikel 2000) and the study of language-dependent and -independent parsing features (Bikel and Chiang 2000), we built a multilingual parsing engine that is capable of instantiating a wide variety of generative statistical parsing models (Bikel 2002).
W00-1201 W00-1320
These confidence values can be derived in a number of sensible ways; the technique used by Collins was adapted from that used in Bikel et al.(1997), which makes use of a quantity called the diversity of the history context (Witten and Bell 1991), which is equal to the number of unique futures observed in training for that history context.
A97-1029 P97-1003
