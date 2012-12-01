Raw parallel data need to be preprocessed in the modern phrase-based SMT before they are aligned by alignment algorithms, one of which is the wellknown tool, GIZA++ (Och and Ney, 2003), for training IBM models (1-4).
P03-1021
3see http://www.statmt.org/moses/ 194 4 Implementation Details 4.1 Alignment of MT output The input text and the output text of the MT systems was aligned by means of GIZA++ (Och and Ney, 2003), a tool with which statistical models for alignment of parallel texts can be trained.
P03-1021
Based on estimating a joint-probability model between the source and the target languages, Ngram-based SMT has proved to be a very competitive alternatively to phrase-based and other state-of-the-art systems in previous evaluation campaigns, as shown in (Koehn and Monz, 2005; Koehn and Monz, 2006).
W06-3114
Portage is a statistical phrase-based SMT system similar to Pharaoh (Koehn et al, 2003).
E03-1076
A possible solution is the implementation of interpolation techniques to smooth sharp distributions estimated on few events (Och and Ney, 2003; Zhao and Xing, 2006).
P03-1021
Koehn and others, 2007), but replacing the Viterbi alignments, usually provided by GIZA++ (Och and Ney, 2003), by those of the HMM mixture model with training scheme mix15H5.
E03-1076 P03-1021
Och and Ney (2000a) have suggested estimating word-class based transition models so as to provide more detailed transition probabilities.
P00-1056
This transformation searches an adequate monotonic segmentation for each of the m source-target language pairs on the basis of bilingual alignments such as those given by GIZA++ (Och, 2000).
P00-1056
It is today common practice to use phrases as translation units (Koehn et al., 2003; Och and Ney, 2003) and a log linear framework in order to introduce several models explaining the translation process: e??= argmaxp(e|f) = argmaxe {exp(summationdisplay i ihi(e,f))} (1) The feature functions hi are the system models and the i weights are typically optimized to maximize a scoring function on a development set (Och and Ney, 2002).
E03-1076 P03-1021
Translations tables in Phrase-based Statistical Machine Translation (SMT) are often built on the basis of Maximum-likelihood Estimation (MLE), being one of the major limitations of this approach that the source sentence context in which phrases occur is completely ignored (Koehn et al., 2003).
E03-1076
The first of these models, that of Marcu and Wong (2002), was found by Koehn, et al.(2003), to produce translations not quite as good as their method.
E03-1076
Koehn. 2006.
W06-3114
The compound splitting was based on (Koehn and Knight, 2003) and was applied on the lowercased source sentences.
E03-1076
Nowadays, statistical machine translation is mainly based on phrases (Koehn et al., 2003).
E03-1076
Even if human judges have explicit evaluation guidelines at hand, they still find it difficult to assign a numerical value which represents the quality of the translation for many sentences (Koehn and Monz, 2006).
W06-3114
Moore Chris Quirk Microsoft Research Redmond, WA 98052, USA {bobmoore,chrisq}@microsoft.com Abstract Attempts to estimate phrase translation probablities for statistical machine translation using iteratively-trained models have repeatedly failed to produce translations as good as those obtained by estimating phrase translation probablities from surface statistics of bilingual word alignments as described by Koehn, et al.(2003). We propose a new iteratively-trained phrase translation model that produces translations of quality equal to or better than those produced by Koehn, et al.?s model.
E03-1076
Och. 2000.
P00-1056
Modern phrasal SMT systems such as (Koehn et al., 2003) derive much of their power from being able to memorize and use long phrases.
E03-1076
HMM alignment model We briefly review the HMM based word alignment models (Vogel, 1996, Och and Ney, 2000a).
P00-1056
Phrase-based statistical machine translation (Koehn et al.2003) has emerged as the dominant paradigm in machine translation research.
E03-1076
Fig. 1 only presents AER results that are calculated after combination of word alignments of both E??F and F??E directions based on a set of heuristics proposed by Och and Ney (2000b).
P00-1056
The main difference with the reordering technique for WMT06 (Crego et al., 2006) lies in (1) the tuples are extracted from the word alignment between the reordered source training corpus and the given target training corpus and (2) the graph structure: the SMR graph provides weights for each reordering path.
W06-3125
Statistical Phrase-based Translation, In Proceedings of HLT-NAACL, Edmonton, Canada Franz Josef Och, 2003.
P03-1021
Och (2003) introduced minimum error rate training (MERT), a technique for optimizing log-linear modelparametersrelativetoameasureoftranslation quality.
P03-1021
The factored translation model combines features in a log-linear fashion (Och, 2003).
P03-1021
In addition to these engines, we also used the scripts included in the Moses toolkit (Koehn et al., 2006)3 to generate phrase tables from the training data.
W06-3114
baseline System used for comparison was Pharaoh (Koehn et al., 2003; Koehn, 2004), which uses a beam search algorithm for decoding.
E03-1076
The phrases in the translations were located using techniques from phrase-based statistical machine translation which extract phrase pairsfromwordalignments(Koehnetal., 2003; Och and Ney, 2004).
E03-1076
Previous ACL Workshops on Machine Translation were more limited in scope (Koehn and Monz, 2005; Koehn and Monz, 2006).
W06-3114
Koehn and Monz (2006) also include a human evaluation, in which this system ranked noticeably higher than one might have predicted from its BLEU score.
W06-3114
Models Inspired by work on factored language models, Koehn et al.(2006) extend phrase-based models to incorporate multiple levels of linguistic knowledge as factors.
W06-3114
Still, a confidence range for BLEU can be estimated by bootstrapping (Och, 2003; Zhang and Vogel, 2004).
P03-1021
It is an extension of Pharaoh (Koehn et al., 2003), and supports factor training and decoding.
E03-1076
To summarize, we provided: ??sentence-aligned training corpora ??development and dev-test sets ??language models trained for each language ??an open source decoder for phrase-based SMT called Moses (Koehn et al., 2006), which replaces the Pharaoh decoder (Koehn, 2004) ??a training script to build models for Moses Theperformanceofthisbaselinesystemissimilar to the best submissions in last year?s shared task.
W06-3114
Approaches Koehn, et al.?s (2003) method of estimating phrasetranslation probabilities is very simple.
E03-1076
Factored translation with source words determining target words and CCG supertags For our experiments we used the following features: the translation probabilities Pr(sFs1 |tFt1 ) and Pr(tFt1 |sFs1 ),thelexicalweights(Koehnetal.,2003) lex(sFs1 |tFt1 ) and lex(tFt1 |sFs1 ), and a phrase penalty e, which allows the model to learn a preference for longer or shorter phrases.
E03-1076
The overall translation model score consists of a weighted sum of the following eight aggregated feature values for each translation hypothesis: ??the sum of the log probabilities of each source phrase in the hypothesis given the corresponding target phrase, computed either by our model or the standard model, ??the sum of the log probabilities of each target phrase in the hypothesis given the corresponding source phrase, computed either by our model or the standard model, ??the sum of lexical scores for each source phrase given the corresponding target phrase, ??the sum of lexical scores for each target phrase given the corresponding source phrase, ??the log of the target language model probability for the sequence of target phrases in the hypothesis, ??the total number of words in the target phrases in the hypothesis, ??the total number of source/target phrase pairs composing the hypothesis, ??the distortion penalty as implemented in the Pharaoh decoder (Koehn, 2003).
E03-1076
It also contains tools for tuning these models using minimum error rate training (Och 2003) and evaluating the resulting translations using the BLEU score (Papineni et al.2002). Moses uses standard external tools for some of the tasks to avoid duplication, such as GIZA++ (Och and Ney 2003) for word alignments and SRILM for language modeling.
P03-1021
Differently, Crego et al.(2006) presents a reordering approach based on reordering patterns which is coupled with decoding.
W06-3125
BLEU score using the algorithm described in (Och, 2003).
P03-1021
That is why we provide a fair comparison between the reordering patterns (Crego and Mari no, 2006) technique and the SMR reordering technique.
W06-3125
The weighting parameters of these features were optimized in terms of BLEU by the approach of minimum error rate training (Och, 2003).
P03-1021
Using this annotation, we report the word alignment performance in terms of alignment error rate (AER) as defined by Och and Ney (2000a): |||| 1 |||| A SAP AER AS ????
P00-1056
They are generated from the training corpus via the ?diag-and??method (Koehn et al., 2003) and smoothed using Kneser-Ney smoothing (Foster et al., 2006), ??one or several n-gram language model(s) trained with the SRILM toolkit (Stolcke, 2002); in the baseline experiments reported here, we used a trigram model, ??a distortion model which assigns a penalty based on the number of source words which are skipped when generating a new target phrase, ??a word penalty.
E03-1076 W06-1607 W06-3114
CCG contains most of the structure of the grammar in the lexicon, which makes it possible to introduce CCG supertags as a factor in a factored translation model (Koehn et al., 2006).
W06-3114
Crego et al.2006. N-gram-based SMT System Enhanced with Reordering Patterns.
W06-3125
We use the following features in our induced English-to-English grammar:3 3Hiero also uses lexical weights (Koehn et al., 2003) in both 122 ??The joint probability of the two English hierarchical paraphrases, conditioned on the nonterminal symbol, as defined by this formula: p(e1, e2|x) = c(X ???e1, e2??summationtext e1prime, e2prime c(X ???e1prime, e2prime??
E03-1076
In this paper, we present improvements to the HMM based alignment model originally proposed by (Vogel et al., 1996, Och and Ney, 2000a).
P00-1056
A position-dependent word agreement score as described in (Ueffing and Ney, 2005) with a position window instead of the Levenshtein alignment, the n-best list n-gram probability as described in (Zens and Ney, 2006) and a position-independent n-gram agreement, which is a variation on the first two.
H05-1096 W06-3110
We selected 580 short sentences of length at most 50 characters from the 2002 NIST MT Evaluation test set as our development corpus and used it to tune s by maximizing the BLEU score (Och, 2003), and used the 2005 NIST MT Evaluation test set as our test corpus.
P03-1021
The features used in this study are: the length of t; a single-parameter distortion penalty on phrase reordering in a, as described in (Koehn et al., 2003); phrase translation model probabilities; and 4-gram language model probabilities logp(t), using Kneser-Ney smoothing as implemented in the SRILM toolkit.
E03-1076
We also trained IBM model 4 using GIZA++ provided by Och and Ney (2000c), where 5 iterations of model 4 training was performed after 5 iterations of model 1 plus 5 iterations of HMM.
P00-1056
In recent years, statistical machine translation have experienced a quantum leap in quality thanks to automatic evaluation (Papineni et al., 2002) and errorbased optimization (Och, 2003).
P03-1021
We used the GIZA++ SMT Toolkit1 (Och and Ney, 2003) to generate word alignments.
P03-1021
ZA++ (Och and Ney, 2000) on the training corpus 
P00-1056
Viewed at a very high level, statistical machine translationinvolvesfourphases: languageandtranslation model training, parameter tuning, decoding, and evaluation (Lopez, 2007; Koehn et al., 2003).
E03-1076
The raw rel197 ative frequency estimates found in the phrase translation tables are then smoothed by applying modified Kneser-Ney discounting as explained in (Foster et al., 2006).
W06-1607
Compounds tend to lead to sparse data problems and splitting them has been shown to improve German-English translation (Koehn and Knight, 2003).
E03-1076
Alignments of both directions are generated and then are combined by heuristic rules described in (Och and Ney 2000b).
P00-1056
One can perhaps identify these using posterior probabilities (e.g., using techniques in Zens and Ney (2006)) and generate additional morphologically valid words that are ?close??and construct a lattice that can be rescored.
W06-3110
2 Phrase-based Statistical MT Our baseline is a standard phrase-based SMT system (Koehn et al., 2003).
E03-1076
The classical approaches to word alignment are based on IBM models 1-5 (Brown et al., 1994) and the HMM based alignment model (Vogel et al., 1996) (Och and Ney, 2000a, 2000b), while recently discriminative approaches (Moore, 2006) and syntax based approaches (Zhang and Gildea, 2005) for word alignment are also studied.
P00-1056
The feature weights for the overall translation models were trained using Och?s (2003) minimum-error-rate training procedure.
P03-1021
In order to improve transition models in the HMM based alignment, Och and Ney (2000a) extended the transition models to be word-class dependent.
P00-1056
The results of last year?s workshop further suggested that Bleu systematically underestimated the quality of rule-based machine translation systems (Koehn and Monz, 2006).
W06-3114
models (Och et al., 2004; Koehn et al., 2003; 
E03-1076 P03-1021
This is done with the help of phrase model training code provided by University of Edinburgh during the NAACL 2006 Workshop on Statistical Machine Translation (Koehn and Monz, 2006).
W06-3114
First, we used several types of phrase table smoothing in the WMT 2007 system because this proved helpful on other translation tasks: relative frequency estimates, Kneser-Neyand Zens-Ney-smoothed probabilities (Foster et al., 2006).
W06-1607 W06-3110
Initial results show the potential benefit of factors for statistical machine translation, (Koehn et al.2006) and (Koehn and Hoang 2007).
W06-3114
Named Entity Transliteration and Discovery from Multilingual Comparable Corpora, COLING-ACL, Sidney, Australia Philipp Koehn, Franz Josef Och, and Daniel Marcu, 2003.
E03-1076 P03-1021
138 ID Participant cmu-uka Carnegie Mellon University, USA (Paulik et al., 2007) cmu-syntax Carnegie Mellon University, USA (Zollmann et al., 2007) cu Charles University, Czech Republic (Bojar, 2007) limsi LIMSI-CNRS, France (Schwenk, 2007) liu University of Linkoping, Sweden(Holmqvist et al., 2007) nrc National Research Council, Canada (Ueffing et al., 2007) pct a commercial MT provider from the Czech Republic saar Saarland University & DFKI, Germany (Chen et al., 2007) systran SYSTRAN, France & U.
W07-0731
To generate phrase pairs from a parallel corpus, we use the "diag-and" phrase induction algorithm described in (Koehn et al, 2003), with symmetrized word alignments generated using IBM model 2 (Brown et al, 1993).
E03-1076
Briefly, training a Hiero model proceeds as follows: ??GIZA++ (Och and Ney, 2000) is run on the parallel corpus in both directions, followed by an alignment refinement heuristic that yields a many-to-many alignment for each parallel sentence.
P00-1056
Franz J. Och and Hermann Ney. 2000. Improved statis-
P00-1056
In the next section we briefly review modeling of transition probabilities in a conventional HMM alignment model (Vogel et al., 1996, Och and Ney, 2000a).
P00-1056
Here, we drop both dependencies in order to simplify to a jump width alignment probability distribution: p(aj |aj??1,xj??1,y) ?? braceleftbigg p(a j) j = 1 p(aj?aj)?? j > 1 (3) p(xj |aj1,xj??1,y) ?p(xj |yaj) (4) Furthermore, the treatment of the NULL word is the same as that presented in (Och and Ney, 2003).
P03-1021
Zens, Richard and Hermann Ney, 2006.
W06-3110
For details on the posterior probabilities, see (Ueffing and Ney, 2007; Zens and Ney, 2006).
W06-3110
In an open competition (Koehn & Monz, 2006) systems trained on parliamentary proceedings were tested on text from 'news commentary' web sites, a very slightly different domain.
W06-3114
In the first part, a word alignment was computed (using the GIZA++ toolkit (Och and Ney, 2003)).
P03-1021
More details on the syntax-augmented system can be found in (Zollmann et al., 2007).
W07-0731
??Initial phrase pairs are identified following the procedure typically employed in phrase based systems (Koehn et al., 2003; Och and Ney, 2004).
E03-1076
Oncetraininghastakenplace,minimumerrorrate training (Och, 2003) is used to tune the parameters i.
P03-1021
To model p(t,a|s), we use a standard loglinear approach: p(t,a|s) ??exp bracketleftBiggsummationdisplay i ifi(s,t,a) bracketrightBigg (1) where each fi(s,t,a) is a feature function, and weights i are set using Och?s algorithm (Och, 2003) to maximize the system?s BLEU score (Papineni et al., 2001) on a development corpus.
P03-1021
To optimize the system towards a maximal BLEU or NIST score, we use Minimum Error Rate (MER) Training as described in (Och, 2003).
P03-1021
We wanted to test the following hypotheses: ??Translation models based on lemmas will improve translation quality (Popovi and Ney, 2004) ??Decompounding German nominal compounds will improve translation quality (Koehn and Knight, 2003) ??Re-ordering models based on word forms and parts-of-speech will improve translation quality (Zens and Ney, 2006).
E03-1076 W06-3110
Our decoder is a reimplementation in Perl of the algorithm used by the Pharaoh decoder as described by Koehn (2003).2 The data we used comes from an English-French bilingual corpus of Canadian Hansards parliamentary proceedings supplied for the bilingual word alignment workshop held at HLT-NAACL 2003 (Mihalcea and Pedersen, 2003).
E03-1076
The word alignments were created with Giza++ (Och and Ney, 2003) applied to a parallel corpus containing 200,000 sentence pairs of the training data, plus sets of 4,007 sentence pairs created by pairing the test sentences with the reference translations, and the test sentences paired with each of the system translations.
P03-1021
We use the n-best generation scheme interleaved with  optimization as described in (Och, 2003).
P03-1021
We also investigate the feasibility of combining the ISL syntax-augmented MT system (Zollmann et al., 2007) with our phrase-based system by combining and rescoring the n-best lists produced by both systems for the Spanish ??English Europarltask.
W07-0731
In (Och and Ney, 2000a), the word null is introduced to generate the French words that don't align to any English words.
P00-1056
We compared our system to Pharaoh, a leading phrasal SMT decoder (Koehn et al., 2003), and our treelet system.
E03-1076
Model weights were trained separately for all 3 systems using minimum error rate training to maximize BLEU (Och, 2003) on the development set (dev).
P03-1021
Och, 2003, Minimum Error Rate Training in Statistical Machine Translation.
P03-1021
73 2.2.4 Minimum Error Rate Training A good way of training is to minimize empirical top-1 error on training data (Och, 2003).
P03-1021
159 2.1 Baseline System The baseline system is a phrase-based SMT system (Koehn et al., 2003), built almost entirely using freely available components.
E03-1076
Finally, we further smooth transition probabilities with a uniform distribution as described in (Och and Ney, 2000a), __ 1 (|,) (1 )(|,) jj jj p aa I paa I I ??=??????.
P00-1056
We employ the phrase-based SMT framework (Koehn et al., 2003), and use the Moses toolkit (Koehn et al., 2007), and the SRILM language modelling toolkit (Stolcke, 2002), and evaluate our decoded translations using the BLEU measure (Papineni et al., 2002), using a single reference translation.
E03-1076
Word alignment is an important step of most modern approaches to statistical machine translation (Koehn et al., 2003).
E03-1076
The comparison phrasal system was constructed using the same GIZA++ alignments and the heuristic combination described in (Och & Ney, 2003).
P03-1021
Further details on the previous experiment can be seen in (Crego and Mari?no, 2006b; Crego and Mari?no, 2006a), where additionally, the input word graph and extended N-gram tagged LM?s are successfully used to improve accuracy at a very low computational cost.
W06-3125
Och. 2003.
P03-1021 P03-1021 P03-1021 P03-1021
Tests sentencepairs were manually aligned and were marked with both sure and possible alignments (Och and Ney 2000a).
P00-1056
The most widely used method for estimating these probabilities is that of Koehn, et al.(2003), in which phrase pairs are extracted from word-aligned bilingual sentence pairs, and their translation probabilities estimated heuristically from surface statistics of the extracted phrase pairs.
E03-1076
M. Crego et al., 2006) to the POS-tagged source sentences before decoding.
W06-3125
Koehn and Knight, 2003).
E03-1076
Another approach that has related TAGS and reordering was presented in (Crego and Mari no, 2006) where instead of rules, they learned reordering patterns based on TAGS as named in this paper?s introduction.
W06-3125
Philipp Koehn, Franz J. Och, and Daniel Marcu. 2003. 
E03-1076 P03-1021
ISL Phrase-Based MT System 2.1 Word and Phrase Alignment Phrase-to-phrase translation pairs are extracted by training IBM Model-4 word alignments in both directions, using the GIZA++ toolkit (Och and Ney, 2000), and then extracting phrase pair candidates which are consistent with these alignments, starting from the intersection of both alignments.
P00-1056
But it has been found that phrases longer than three words have little improvement in the performance (Koehn, 2003).
E03-1076
Weights on the loglinear features are set using Och's algorithm (Och, 2003) to maximize the system's BLEU score on a development corpus.
P03-1021
To derive the joint counts c(?s,?t) from which p(?s|?t) and p(?t|?s) are estimated, we use the phrase induction algorithm described in (Koehn et al., 2003), with symmetrized word alignments generated using IBM model 2 (Brown et al., 1993).
E03-1076
Moses was the subject of this year?s Johns Hopkins University Workshop on Machine Translation (Koehn et al.2006). The decoder is the core component of Moses.
W06-3114
References Koehn, Philipp and Kevin Knight, 2003.
E03-1076
We speculated that this may have been due to non-smooth component models, and tried various smoothing schemes, including Kneser-Ney phrase table smoothing similar to that described in (Foster et al., 2006), and binary features to indicate phrasepair presence within different components.
W06-1607
In this work, we present a mixture extension of the well-known HMM alignment model first proposed in (Vogel and others, 1996) and refined in (Och and Ney, 2003).
P03-1021
The optimal weights for the different columns can then be assigned with the help of minimum error rate training (Och, 2003).
P03-1021
In the experiment, only the first 500 sentences were used to train the log-linear model weight vector, where minimum error rate (MER) training was used (Och, 2003).
P03-1021
