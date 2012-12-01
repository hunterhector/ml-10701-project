In this paper, we use the Charniak language model (Charniak, 2001) for determiner selection.
P01-1017
and Future Work With the Charniak (Charniak, 2001) language model, our results exceed those of the previous best (Minnen et al., 2000) on the determiner selection task.
P01-1017 W00-0708
Heine. 1998.
P98-1085
As far as we know, language modeling always improves with additional training data, so we add data from the North American News Text Corpus (NANC) (Graff, 1995) automatically parsed with the Charniak parser (McClosky et al., 2006) to train our language model on up to 20 million additional words.
N06-1020
and Discussion The best results of Minnen et al.(2000) are using leave-one-out cross-validation.
W00-0708
Immediate-Head Parsing Model The language model we use is described in (Charniak, 2001).
P01-1017
A determiner selection program can aid in Machine Translation of determiner-free languages (by adding determiners after the text has been translated), correct English text written by nonnative speakers (Lee, 2004), and choose determiners for text generation programs.
N04-2006
the model As with (Minnen et al., 2000), we train the language model on the Penn Treebank (Marcus et al., 1993).
J93-2004 W00-0708
We also test our language model using leave-one-out cross-validation on the Penn Treebank (Marcus et al., 1993) (WSJ), giving us 86.74% accuracy (see Table 1).
J93-2004
Our approach significantly improves upon the work of Minnen et al.(2000). We also use additional automatically parsed data from the North American News Text Corpus (Graff, 1995), further improving our results.
W00-0708
Early work on determiner selection focuses on rule-based systems (Gawronska, 1990; Murata and Nagao, 1993; Bond and Ogura, 1994; Heine, 1998).
P98-1085
Church (2000) shows that a word appears with much higher probability when seen elsewhere in an article.
C00-1027
(Deciding between a and an is a trivial postprocessing step.) Minnen et al.(2000) use a memory-based learner (Daelemans et al., 2000) to choose determiners of base noun phrases.
W00-0708
