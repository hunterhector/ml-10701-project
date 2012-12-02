Raw parallel data need to be preprocessed in the modern phrase-based SMT before they are aligned by alignment algorithms, one of which is the wellknown tool, GIZA++ (Och and Ney, 2003), for training IBM models (1-4).
J03-1002
The word alignments were created with Giza++ (Och and Ney, 2003) applied to a parallel corpus containing 200,000 sentence pairs of the training data, plus sets of 4,007 sentence pairs created by pairing the test sentences with the reference translations, and the test sentences paired with each of the system translations.
J03-1002
We use the n-best generation scheme interleaved with  optimization as described in (Och, 2003).
J03-1002
In recent years, statistical machine translation have experienced a quantum leap in quality thanks to automatic evaluation (Papineni et al., 2002) and errorbased optimization (Och, 2003).
J03-1002
A possible solution is the implementation of interpolation techniques to smooth sharp distributions estimated on few events (Och and Ney, 2003; Zhao and Xing, 2006).
J03-1002 P06-2124
In (Zhao and Xing, 2006), three fairly sophisticated bayesian topical translation models, taking IBM Model 1 as a baseline model, were presented under the bilingual topic admixture model formalism.
P06-2124
The classical approaches to word alignment are based on IBM models 1-5 (Brown et al., 1994) and the HMM based alignment model (Vogel et al., 1996) (Och and Ney, 2000a, 2000b), while recently discriminative approaches (Moore, 2006) and syntax based approaches (Zhang and Gildea, 2005) for word alignment are also studied.
C96-2141
? = . Then, Vogel et al.(1996) give 1 11 1 1 (|) (|,)(|) j J J JI jj ja ja pf e pa a Ipf e ??
C96-2141
Still, a confidence range for BLEU can be estimated by bootstrapping (Och, 2003; Zhang and Vogel, 2004).
J03-1002
Model weights were trained separately for all 3 systems using minimum error rate training to maximize BLEU (Och, 2003) on the development set (dev).
J03-1002
Philipp Koehn, Franz J. Och, and Daniel Marcu. 2003. 
J03-1002
Och, 2003, Minimum Error Rate Training in Statistical Machine Translation.
J03-1002
Koehn and others, 2007), but replacing the Viterbi alignments, usually provided by GIZA++ (Och and Ney, 2003), by those of the HMM mixture model with training scheme mix15H5.
J03-1002
The feature weights for the overall translation models were trained using Och?s (2003) minimum-error-rate training procedure.
J03-1002
We used the GIZA++ SMT Toolkit1 (Och and Ney, 2003) to generate word alignments.
J03-1002
73 2.2.4 Minimum Error Rate Training A good way of training is to minimize empirical top-1 error on training data (Och, 2003).
J03-1002
S. Vogel et al.1996. HMM-based word alignment in statistical translation.
C96-2141
It also contains tools for tuning these models using minimum error rate training (Och 2003) and evaluating the resulting translations using the BLEU score (Papineni et al.2002). Moses uses standard external tools for some of the tasks to avoid duplication, such as GIZA++ (Och and Ney 2003) for word alignments and SRILM for language modeling.
J03-1002
However, as discussed in (Toutanova et al.2002),the word dependent selftransition model can be viewed as an approximation of fertility model.
W02-1012
In (Toutanova et al., 2002), the word dependent self-transition probability P(stay|e) is interpolated with the global HMM self-transition probability to alleviate the data sparsity problem, where an interpolation weight is used for all words and that weight is tuned on a hold-out set.
W02-1012
Named Entity Transliteration and Discovery from Multilingual Comparable Corpora, COLING-ACL, Sidney, Australia Philipp Koehn, Franz Josef Och, and Daniel Marcu, 2003.
J03-1002
Deng and Byrne in (2005) improved this idea.
H05-1022
The weighting parameters of these features were optimized in terms of BLEU by the approach of minimum error rate training (Och, 2003).
J03-1002
Toutanova et al.(2002) has proposed to 86 estimate a word-dependent self-transition model P(stay|e) so that each word can have its own probability to decide whether to stay or jump to a different word.
W02-1012
These properties have made this model suitable for extensions (Toutanova et al., 2002) and integration in a phrase-based model (Deng and Byrne, 2005) in the past.
H05-1022 W02-1012
The comparison phrasal system was constructed using the same GIZA++ alignments and the heuristic combination described in (Och & Ney, 2003).
J03-1002
In the HMM based alignment model (Vogel et al., 1996), it is assumed that the HMM transition probabilities depend only on the jump width from the last state to the next state.
C96-2141
Och. 2003.
J03-1002 J03-1002
On the other hand, we are fully aware that indirectly assessing the quality of a model through a phrasebased system is a difficult task because of the different factors involved (Ayan and Dorr, 2006).
P06-1002
Here, we drop both dependencies in order to simplify to a jump width alignment probability distribution: p(aj |aj??1,xj??1,y) ?? braceleftbigg p(a j) j = 1 p(aj?aj)?? j > 1 (3) p(xj |aj1,xj??1,y) ?p(xj |yaj) (4) Furthermore, the treatment of the NULL word is the same as that presented in (Och and Ney, 2003).
J03-1002
In this paper, we present improvements to the HMM based alignment model originally proposed by (Vogel et al., 1996, Och and Ney, 2000a).
C96-2141
In the first part, a word alignment was computed (using the GIZA++ toolkit (Och and Ney, 2003)).
J03-1002
We selected 580 short sentences of length at most 50 characters from the 2002 NIST MT Evaluation test set as our development corpus and used it to tune s by maximizing the BLEU score (Och, 2003), and used the 2005 NIST MT Evaluation test set as our test corpus.
J03-1002
In the next section we briefly review modeling of transition probabilities in a conventional HMM alignment model (Vogel et al., 1996, Och and Ney, 2000a).
C96-2141
HMM alignment model We briefly review the HMM based word alignment models (Vogel, 1996, Och and Ney, 2000a).
C96-2141
Weights on the loglinear features are set using Och's algorithm (Och, 2003) to maximize the system's BLEU score on a development corpus.
J03-1002
Statistical Phrase-based Translation, In Proceedings of HLT-NAACL, Edmonton, Canada Franz Josef Och, 2003.
J03-1002
In the experiment, only the first 500 sentences were used to train the log-linear model weight vector, where minimum error rate (MER) training was used (Och, 2003).
J03-1002
Och (2003) introduced minimum error rate training (MERT), a technique for optimizing log-linear modelparametersrelativetoameasureoftranslation quality.
J03-1002
Oncetraininghastakenplace,minimumerrorrate training (Och, 2003) is used to tune the parameters i.
J03-1002
In this work, we present a mixture extension of the well-known HMM alignment model first proposed in (Vogel and others, 1996) and refined in (Och and Ney, 2003).
C96-2141 J03-1002
To model p(t,a|s), we use a standard loglinear approach: p(t,a|s) ??exp bracketleftBiggsummationdisplay i ifi(s,t,a) bracketrightBigg (1) where each fi(s,t,a) is a feature function, and weights i are set using Och?s algorithm (Och, 2003) to maximize the system?s BLEU score (Papineni et al., 2001) on a development corpus.
J03-1002
The factored translation model combines features in a log-linear fashion (Och, 2003).
J03-1002
? (1) In the HMM of (Vogel et al., 1996), it is further assumed these transition probabilities 1 (|,) ??
C96-2141
models (Och et al., 2004; Koehn et al., 2003; 
J03-1002
Later Deng and Byrne (2005) proposed a word dependent phrase length model to better model state occupancy.
H05-1022
