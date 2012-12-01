For example, (Pang et al., 2002) collected reviews from a movie database and rated them as positive, negative, or neutral based on the rating (e.g., number of stars) given by the reviewer.
W02-1011
Previous work on sentence-level subjectivity classification (Wiebe et al., 1999) used training corpora that had been manually annotated for subjectivity.
P99-1032
Some existing resources contain lists of subjective words (e.g., Levin’s desire verbs (1993)), and some empirical methods in NLP have automatically identified adjectives, verbs, and N-grams that are statistically associated with subjective language (e.g., (Turney, 2002; Hatzivassiloglou and McKeown, 1997; Wiebe, 2000; Wiebe et al., 2001)).
P02-1053 P97-1023
Many of the subjective clues are from manually developed resources, including entries from (Levin, 1993; Ballmer and Brennenstuhl, 1981), Framenet lemmas with frame element experiencer (Baker et al., 1998), adjectives manually annotated for polarity (Hatzivassiloglou and McKeown, 1997), and subjectivity clues listed in (Wiebe, 1990).
P97-1023 P98-1013
For example, (Spertus, 1997) developed a system to identify inflammatory texts and (Turney, 2002; Pang et al., 2002) developed methods for classifying reviews as positive or negative.
P02-1053 W02-1011
ExDisco (Yangarber et al., 2000) uses a bootstrapping mechanism to find new extraction patterns using unannotated texts and some seed patterns as the initial input.
C00-2136
Some research in genre classification has included the recognition of subjective genres such as editorials (e.g., (Karlgren and Cutting, 1994; Kessler et al., 1997; Wiebe et al., 2001)).
C94-2174 P97-1005
Others were derived from corpora, including subjective nouns learned from unannotated data using bootstrapping (Riloff et al., 2003).
W03-0404
There are certainly lexical items that are statistically correlated with the obKnown Subjective Vocabulary High−Precision Objective Sentence Classifier (HP−Obj) High−Precision Subjective Sentence Classifier (HP−Subj) Unannotated Text Collection unlabeled sentences unlabeled sentences unlabeled sentences Pattern−based Subjective Sentence Classifier Extraction Pattern Learner subjective sentences subjective sentences objective sentences subjective patterns subjective patterns Figure 1: Bootstrapping Process jective class (examples are cardinal numbers (Wiebe et al., 1999), and words such as per, case, market, and total), but the presence of such clues does not readily lead to high precision objective classification.
P99-1032
Most of these algorithms require special training resources, such as texts annotated with domain-specific tags (e.g., AutoSlog (Riloff, 1993), CRYSTAL (Soderland et al., 1995), RAPIER (Califf, 1998), SRV (Freitag, 1998), WHISK (Soderland, 1999)) or manually defined keywords, frames, or object recognizers (e.g., PALKA (Kim and Moldovan, 1993) and LIEP (Huffman, 1996)).
P98-1067
