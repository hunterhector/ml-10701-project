The chunker is trained on the answer side of the Training corpus in order to learn 2 and 3word collocations, defined using the likelihood ratio of Dunning (1993).
J93-1003
We implemented an answer extraction algorithm using the BLEU score of Papineni et al.(2002) as a means of assessing the overlap between the question and the proposed answers.
P02-1040
The Question Answering (QA) task has received a great deal of attention from the Computational Linguistics research community in the last few years (e.g., Text REtrieval Conference TREC 2001-2003).
N03-1020
Our parallel corpus of questions and answers can be used to compute the translation table t(q j | a i ) using the EM algorithm, as described by Brown et al.(1993). Note that, similarly with the statistical machine translation framework, we deal here with “inverse” probabilities, i.e. the probability of a question term given an answer, and not the more intuitive probability of answer term given question.
J93-2003
For comparison purposes, we consider two different algorithms for our AnswerExtraction module: one that does not bridge the lexical chasm, based on N-gram cooccurrences between the question terms and the answer terms; and one that attempts to bridge the lexical chasm using Statistical Machine Translation inspired techniques (Brown et al., 1993) in order to find the best answer for a given question.
J93-2003
The challenges posed by answering factoid question have been addressed using a large variety of techniques, such as question parsing (Hovy et al., 2001; Moldovan et al., 2002), question-type determination (Brill et al., 2001; Ittycheraih and Roukos, 2002; Hovy et al., 2001; Moldovan et al., 2002), WordNet exploitation (Hovy et al., 2001; Pasca and Harabagiu, 2001; Prager et al., 2001), Web exploitation (Brill et al., 2001; Kwok et al., 2001), noisy-channel transformations (Echihabi and Marcu, 2003), semantic analysis (Xu et al., 2002; Hovy et al., 2001; Moldovan et al., 2002), and inferencing (Moldovan et al., 2002).
P03-1003
4.4.1 N-gram Co-Occurrence Statistics for Answer Extraction N-gram co-occurrence statistics have been successfully used in automatic evaluation (Papineni et al.2002, Lin and Hovy 2003), and more recently as training criteria in statistical machine translation (Och 2003).
N03-1020 P02-1040 P03-1021
