Raw parallel data need to be preprocessed in the modern phrase-based SMT before they are aligned by alignment algorithms, one of which is the wellknown tool, GIZA++ (Och and Ney, 2003), for training IBM models (1-4).
J03-1002 P03-1021
A detailed description of the system can be found in (Vilar et al., 2005; Matusov et al., 2006).
E06-1005
3see http://www.statmt.org/moses/ 194 4 Implementation Details 4.1 Alignment of MT output The input text and the output text of the MT systems was aligned by means of GIZA++ (Och and Ney, 2003), a tool with which statistical models for alignment of parallel texts can be trained.
J03-1002 P03-1021
The word alignments were created with Giza++ (Och and Ney, 2003) applied to a parallel corpus containing 200,000 sentence pairs of the training data, plus sets of 4,007 sentence pairs created by pairing the test sentences with the reference translations, and the test sentences paired with each of the system translations.
J03-1002 P03-1021
We use the n-best generation scheme interleaved with  optimization as described in (Och, 2003).
J03-1002 P03-1021
Statistical Phrase-based Translation, In Proceedings of HLT-NAACL, Edmonton, Canada Franz Josef Och, 2003.
J03-1002 P03-1021
A possible solution is the implementation of interpolation techniques to smooth sharp distributions estimated on few events (Och and Ney, 2003; Zhao and Xing, 2006).
J03-1002 P03-1021
for multi-engine MT Combinations of MT systems into multi-engine architectures have a long tradition, starting perhaps with (Frederking and Nirenburg, 1994).
A94-1016
Still, a confidence range for BLEU can be estimated by bootstrapping (Och, 2003; Zhang and Vogel, 2004).
J03-1002 P03-1021
Model weights were trained separately for all 3 systems using minimum error rate training to maximize BLEU (Och, 2003) on the development set (dev).
J03-1002 P03-1021
Philipp Koehn, Franz J. Och, and Daniel Marcu. 2003. 
J03-1002 P03-1021
Och, 2003, Minimum Error Rate Training in Statistical Machine Translation.
J03-1002 P03-1021
Koehn and others, 2007), but replacing the Viterbi alignments, usually provided by GIZA++ (Och and Ney, 2003), by those of the HMM mixture model with training scheme mix15H5.
J03-1002 P03-1021
The feature weights for the overall translation models were trained using Och?s (2003) minimum-error-rate training procedure.
J03-1002 P03-1021
We used the GIZA++ SMT Toolkit1 (Och and Ney, 2003) to generate word alignments.
J03-1002 P03-1021
73 2.2.4 Minimum Error Rate Training A good way of training is to minimize empirical top-1 error on training data (Och, 2003).
J03-1002 P03-1021
models (Och et al., 2004; Koehn et al., 2003; 
J03-1002 P03-1021
It also contains tools for tuning these models using minimum error rate training (Och 2003) and evaluating the resulting translations using the BLEU score (Papineni et al.2002). Moses uses standard external tools for some of the tasks to avoid duplication, such as GIZA++ (Och and Ney 2003) for word alignments and SRILM for language modeling.
J03-1002 P03-1021
BLEU score using the algorithm described in (Och, 2003).
J03-1002 P03-1021
Multiengine systems can be roughly divided into simple 1See (Hutchins et al., 2006) for a list of commercial MT systems 2See http://www.euromatrix.net 193 Figure 1: Architecture for multi-engine MT driven by a SMT decoder architectures that try to select the best output from a number of systems, but leave the individual hypotheses as is (Tidhar and Kussner, 2000; Akiba et al., 2001; Callison-Burch and Flournoy, 2001; Akiba et al., 2002; Nomoto, 2004; Eisele, 2005) and more sophisticated setups that try to recombine the best parts from multiple hypotheses into a new utterance that can be better than the best of the given candidates, as described in (Rayner and Carter, 1997; Hogan and Frederking, 1998; Bangalore et al., 2001; Jayaraman and Lavie, 2005; Matusov et al., 2006; Rosti et al., 2007).
C00-2122 C02-1076 E06-1005 N07-1029 P04-1063 P05-3026 W05-0828
Named Entity Transliteration and Discovery from Multilingual Comparable Corpora, COLING-ACL, Sidney, Australia Philipp Koehn, Franz Josef Och, and Daniel Marcu, 2003.
J03-1002 P03-1021
The weighting parameters of these features were optimized in terms of BLEU by the approach of minimum error rate training (Och, 2003).
J03-1002 P03-1021
The comparison phrasal system was constructed using the same GIZA++ alignments and the heuristic combination described in (Och & Ney, 2003).
J03-1002 P03-1021
Och. 2003.
J03-1002 J03-1002 J03-1002 P03-1021 P03-1021 P03-1021
It is today common practice to use phrases as translation units (Koehn et al., 2003; Och and Ney, 2003) and a log linear framework in order to introduce several models explaining the translation process: e??= argmaxp(e|f) = argmaxe {exp(summationdisplay i ihi(e,f))} (1) The feature functions hi are the system models and the i weights are typically optimized to maximize a scoring function on a development set (Och and Ney, 2002).
J03-1002 P03-1021
The optimal weights for the different columns can then be assigned with the help of minimum error rate training (Och, 2003).
J03-1002 P03-1021
Here, we drop both dependencies in order to simplify to a jump width alignment probability distribution: p(aj |aj??1,xj??1,y) ?? braceleftbigg p(a j) j = 1 p(aj?aj)?? j > 1 (3) p(xj |aj1,xj??1,y) ?p(xj |yaj) (4) Furthermore, the treatment of the NULL word is the same as that presented in (Och and Ney, 2003).
J03-1002 P03-1021
In the first part, a word alignment was computed (using the GIZA++ toolkit (Och and Ney, 2003)).
J03-1002 P03-1021
We selected 580 short sentences of length at most 50 characters from the 2002 NIST MT Evaluation test set as our development corpus and used it to tune s by maximizing the BLEU score (Och, 2003), and used the 2005 NIST MT Evaluation test set as our test corpus.
J03-1002 P03-1021
Weights on the loglinear features are set using Och's algorithm (Och, 2003) to maximize the system's BLEU score on a development corpus.
J03-1002 P03-1021
In recent years, statistical machine translation have experienced a quantum leap in quality thanks to automatic evaluation (Papineni et al., 2002) and errorbased optimization (Och, 2003).
J03-1002 P03-1021
Och (2003) introduced minimum error rate training (MERT), a technique for optimizing log-linear modelparametersrelativetoameasureoftranslation quality.
J03-1002 P03-1021
Oncetraininghastakenplace,minimumerrorrate training (Och, 2003) is used to tune the parameters i.
J03-1002 P03-1021
The translation system used is the phrase-based statistical machine translation system described in (Vilar et al., 2005; Matusov et al., 2006).
E06-1005
In this work, we present a mixture extension of the well-known HMM alignment model first proposed in (Vogel and others, 1996) and refined in (Och and Ney, 2003).
J03-1002 P03-1021
To model p(t,a|s), we use a standard loglinear approach: p(t,a|s) ??exp bracketleftBiggsummationdisplay i ifi(s,t,a) bracketrightBigg (1) where each fi(s,t,a) is a feature function, and weights i are set using Och?s algorithm (Och, 2003) to maximize the system?s BLEU score (Papineni et al., 2001) on a development corpus.
J03-1002 P03-1021
The factored translation model combines features in a log-linear fashion (Och, 2003).
J03-1002 P03-1021
In the experiment, only the first 500 sentences were used to train the log-linear model weight vector, where minimum error rate (MER) training was used (Och, 2003).
J03-1002 P03-1021
