The phrases in the translations were located using techniques from phrase-based statistical machine translation which extract phrase pairsfromwordalignments(Koehnetal., 2003; Och and Ney, 2004).
C04-1045 E03-1076
2007, URL: http://www.statmt.org/moses/ . Niessen, Sonja and Hermann Ney, 2004.
C04-1045 J04-2003
Franz J. Och and Hermann Ney. 2004. The alignment 
C04-1045
Compounds tend to lead to sparse data problems and splitting them has been shown to improve German-English translation (Koehn and Knight, 2003).
E03-1076
A universal estimation method is the bootstrap estimate: The core idea is to create replications of R by random sampling from the data set (Bisani and Ney, 2004).
C04-1045
Portage is a statistical phrase-based SMT system similar to Pharaoh (Koehn et al, 2003).
E03-1076
One can perhaps identify these using posterior probabilities (e.g., using techniques in Zens and Ney (2006)) and generate additional morphologically valid words that are ?close??and construct a lattice that can be rescored.
W06-3108
Popovic and Ney (2004) investigate improving translation qual2This disambiguator has about 94% accuracy.
C04-1045
We compared our system to Pharaoh, a leading phrasal SMT decoder (Koehn et al., 2003), and our treelet system.
E03-1076
We use two different estimates for the conditional probabilities p(?t|?s) and p(?s|?t): relative frequencies and ?lexical??probabilities as described in (Zens and Ney, 2004).
C04-1045
It is an extension of Pharaoh (Koehn et al., 2003), and supports factor training and decoding.
E03-1076
The alignment template approach (Och & Ney, 2004) uses word classes rather than lexical items to model phrase translation.
C04-1045
We employ the phrase-based SMT framework (Koehn et al., 2003), and use the Moses toolkit (Koehn et al., 2007), and the SRILM language modelling toolkit (Stolcke, 2002), and evaluate our decoded translations using the BLEU measure (Papineni et al., 2002), using a single reference translation.
E03-1076
159 2.1 Baseline System The baseline system is a phrase-based SMT system (Koehn et al., 2003), built almost entirely using freely available components.
E03-1076
Factored translation with source words determining target words and CCG supertags For our experiments we used the following features: the translation probabilities Pr(sFs1 |tFt1 ) and Pr(tFt1 |sFs1 ),thelexicalweights(Koehnetal.,2003) lex(sFs1 |tFt1 ) and lex(tFt1 |sFs1 ), and a phrase penalty e, which allows the model to learn a preference for longer or shorter phrases.
E03-1076
Ney. 2004.
C04-1045
Philipp Koehn, Franz J. Och, and Daniel Marcu. 2003. 
E03-1076
models (Och et al., 2004; Koehn et al., 2003; 
E03-1076
Our decoder is a reimplementation in Perl of the algorithm used by the Pharaoh decoder as described by Koehn (2003).2 The data we used comes from an English-French bilingual corpus of Canadian Hansards parliamentary proceedings supplied for the bilingual word alignment workshop held at HLT-NAACL 2003 (Mihalcea and Pedersen, 2003).
E03-1076
(Niessen and Ney, 2000) or adjective compounds such as ?multidimensionale??
C00-2162
Translations tables in Phrase-based Statistical Machine Translation (SMT) are often built on the basis of Maximum-likelihood Estimation (MLE), being one of the major limitations of this approach that the source sentence context in which phrases occur is completely ignored (Koehn et al., 2003).
E03-1076
Yet this approach loses the advantage of context-sensitive lexical selection: the word translation model depends only on the word classes to subcategorize for translations, which leads to less accurate lexical choice in practice (Zens & Ney, 2004).
C04-1045
Zens, Richard and Hermann Ney, 2006.
W06-3108
Named Entity Transliteration and Discovery from Multilingual Comparable Corpora, COLING-ACL, Sidney, Australia Philipp Koehn, Franz Josef Och, and Daniel Marcu, 2003.
E03-1076
The first of these models, that of Marcu and Wong (2002), was found by Koehn, et al.(2003), to produce translations not quite as good as their method.
E03-1076
To generate phrase pairs from a parallel corpus, we use the "diag-and" phrase induction algorithm described in (Koehn et al, 2003), with symmetrized word alignments generated using IBM model 2 (Brown et al, 1993).
E03-1076
Approaches Koehn, et al.?s (2003) method of estimating phrasetranslation probabilities is very simple.
E03-1076
Word alignment is an important step of most modern approaches to statistical machine translation (Koehn et al., 2003).
E03-1076
An early attempt at greater generality in a purely phrasal setting was the alignment template approach (Och & Ney 2004); newer approaches include formally syntactic (Chiang 2005), and linguistically syntactic approaches (Quirk et al.2005), (Huang et al.2006). In the next section, we examine these representative approaches to the reordering problem.
C04-1045
Niessen and Ney (2004) have used morphological decomposition to improve alignment quality.
C04-1045 J04-2003
We use the following features in our induced English-to-English grammar:3 3Hiero also uses lexical weights (Koehn et al., 2003) in both 122 ??The joint probability of the two English hierarchical paraphrases, conditioned on the nonterminal symbol, as defined by this formula: p(e1, e2|x) = c(X ???e1, e2??summationtext e1prime, e2prime c(X ???e1prime, e2prime??
E03-1076
Viewed at a very high level, statistical machine translationinvolvesfourphases: languageandtranslation model training, parameter tuning, decoding, and evaluation (Lopez, 2007; Koehn et al., 2003).
E03-1076
Nowadays, statistical machine translation is mainly based on phrases (Koehn et al., 2003).
E03-1076
Some efforts have been made e.g. to integrate more information about the words in the form of Part Of Speech tags (Popovic and Ney, 2005), using additional information about stems and suffixes (Popovic and Ney, 2004) or to reduce the morphological variability of the words (de Gispert, 2006).
C04-1045
Niessen and Ney, 2004).
C04-1045 J04-2003
Moore Chris Quirk Microsoft Research Redmond, WA 98052, USA {bobmoore,chrisq}@microsoft.com Abstract Attempts to estimate phrase translation probablities for statistical machine translation using iteratively-trained models have repeatedly failed to produce translations as good as those obtained by estimating phrase translation probablities from surface statistics of bilingual word alignments as described by Koehn, et al.(2003). We propose a new iteratively-trained phrase translation model that produces translations of quality equal to or better than those produced by Koehn, et al.?s model.
E03-1076
The features used in this study are: the length of t; a single-parameter distortion penalty on phrase reordering in a, as described in (Koehn et al., 2003); phrase translation model probabilities; and 4-gram language model probabilities logp(t), using Kneser-Ney smoothing as implemented in the SRILM toolkit.
E03-1076
The most widely used method for estimating these probabilities is that of Koehn, et al.(2003), in which phrase pairs are extracted from word-aligned bilingual sentence pairs, and their translation probabilities estimated heuristically from surface statistics of the extracted phrase pairs.
E03-1076
Koehn and Knight, 2003).
E03-1076
Modern phrasal SMT systems such as (Koehn et al., 2003) derive much of their power from being able to memorize and use long phrases.
E03-1076
Popovi, Maja and Hermann Ney, 2004.
C04-1045
Computational Linguistics, 181-204 . Niessen, Sonja and Hermann Ney, 2000.
C00-2162
2 Phrase-based Statistical MT Our baseline is a standard phrase-based SMT system (Koehn et al., 2003).
E03-1076
Phrase-based statistical machine translation (Koehn et al.2003) has emerged as the dominant paradigm in machine translation research.
E03-1076
Och and Ney (2004) gave a framework of alignment templates for this kind of models.
C04-1045
But it has been found that phrases longer than three words have little improvement in the performance (Koehn, 2003).
E03-1076
To derive the joint counts c(?s,?t) from which p(?s|?t) and p(?t|?s) are estimated, we use the phrase induction algorithm described in (Koehn et al., 2003), with symmetrized word alignments generated using IBM model 2 (Brown et al., 1993).
E03-1076
References Koehn, Philipp and Kevin Knight, 2003.
E03-1076
??Initial phrase pairs are identified following the procedure typically employed in phrase based systems (Koehn et al., 2003; Och and Ney, 2004).
C04-1045 E03-1076
Koehn and others, 2007), but replacing the Viterbi alignments, usually provided by GIZA++ (Och and Ney, 2003), by those of the HMM mixture model with training scheme mix15H5.
E03-1076
For tractability, we followed standard practice with this technique and considered only monotonic alignments when decoding (Zens and Ney, 2004).
C04-1045
The overall translation model score consists of a weighted sum of the following eight aggregated feature values for each translation hypothesis: ??the sum of the log probabilities of each source phrase in the hypothesis given the corresponding target phrase, computed either by our model or the standard model, ??the sum of the log probabilities of each target phrase in the hypothesis given the corresponding source phrase, computed either by our model or the standard model, ??the sum of lexical scores for each source phrase given the corresponding target phrase, ??the sum of lexical scores for each target phrase given the corresponding source phrase, ??the log of the target language model probability for the sequence of target phrases in the hypothesis, ??the total number of words in the target phrases in the hypothesis, ??the total number of source/target phrase pairs composing the hypothesis, ??the distortion penalty as implemented in the Pharaoh decoder (Koehn, 2003).
E03-1076
We wanted to test the following hypotheses: ??Translation models based on lemmas will improve translation quality (Popovi and Ney, 2004) ??Decompounding German nominal compounds will improve translation quality (Koehn and Knight, 2003) ??Re-ordering models based on word forms and parts-of-speech will improve translation quality (Zens and Ney, 2006).
C04-1045 E03-1076 W06-3108
baseline System used for comparison was Pharaoh (Koehn et al., 2003; Koehn, 2004), which uses a beam search algorithm for decoding.
E03-1076
