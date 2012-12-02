Raw parallel data need to be preprocessed in the modern phrase-based SMT before they are aligned by alignment algorithms, one of which is the wellknown tool, GIZA++ (Och and Ney, 2003), for training IBM models (1-4).
P03-1021
are combined in a log-linear model to obtainthescoreforthetranslationeforaninputsentence f: score(e,f) = exp summationdisplay i i hi(e,f) (1) The weights of the components i are set by a discriminative training method on held-out development data (Och, 2003).
P03-1021
T. Koo and M. Collins. 2005. Hidden-Variable Models for Discriminative Reranking. In Proceedings of HLTEMNLP, pages 507514.
P05-1066
3see http://www.statmt.org/moses/ 194 4 Implementation Details 4.1 Alignment of MT output The input text and the output text of the MT systems was aligned by means of GIZA++ (Och and Ney, 2003), a tool with which statistical models for alignment of parallel texts can be trained.
P03-1021
The word alignments were created with Giza++ (Och and Ney, 2003) applied to a parallel corpus containing 200,000 sentence pairs of the training data, plus sets of 4,007 sentence pairs created by pairing the test sentences with the reference translations, and the test sentences paired with each of the system translations.
P03-1021
We use the n-best generation scheme interleaved with  optimization as described in (Och, 2003).
P03-1021
Statistical Phrase-based Translation, In Proceedings of HLT-NAACL, Edmonton, Canada Franz Josef Och, 2003.
P03-1021
A possible solution is the implementation of interpolation techniques to smooth sharp distributions estimated on few events (Och and Ney, 2003; Zhao and Xing, 2006).
P03-1021
Still, a confidence range for BLEU can be estimated by bootstrapping (Och, 2003; Zhang and Vogel, 2004).
P03-1021
Model weights were trained separately for all 3 systems using minimum error rate training to maximize BLEU (Och, 2003) on the development set (dev).
P03-1021
Philipp Koehn, Franz J. Och, and Daniel Marcu. 2003. 
P03-1021
Och, 2003, Minimum Error Rate Training in Statistical Machine Translation.
P03-1021
Koehn and others, 2007), but replacing the Viterbi alignments, usually provided by GIZA++ (Och and Ney, 2003), by those of the HMM mixture model with training scheme mix15H5.
P03-1021 P07-2045
The feature weights for the overall translation models were trained using Och?s (2003) minimum-error-rate training procedure.
P03-1021
Koo and Collins, 2005; Petrov et al., 2006; Titov
P05-1066
This alternate decoding path model was developed by Birch et al.(2007). For our purposes, we use two decoding paths, each consisting of only one translation step.
W07-0702
We used the GIZA++ SMT Toolkit1 (Och and Ney, 2003) to generate word alignments.
P03-1021
73 2.2.4 Minimum Error Rate Training A good way of training is to minimize empirical top-1 error on training data (Och, 2003).
P03-1021
models (Och et al., 2004; Koehn et al., 2003; 
P03-1021
It also contains tools for tuning these models using minimum error rate training (Och 2003) and evaluating the resulting translations using the BLEU score (Papineni et al.2002). Moses uses standard external tools for some of the tasks to avoid duplication, such as GIZA++ (Och and Ney 2003) for word alignments and SRILM for language modeling.
P03-1021
We used Cowan and Collins (2005)?s parser for Spanish, Arun and Keller (2005)?s for French, Dubey (2005)?s for German, and Bikel (2002)?s for English.
P05-1066
BLEU score using the algorithm described in (Och, 2003).
P03-1021
framework: the Moses MT system The open source Moses (Koehn et al., 2007) MT system was originally developed at the University of Edinburgh and received a major boost through a 2007 Johns Hopkins workshop.
P07-2045
To optimize the system towards a maximal BLEU or NIST score, we use Minimum Error Rate (MER) Training as described in (Och, 2003).
P03-1021
Initial results show the potential benefit of factors for statistical machine translation, (Koehn et al.2006) and (Koehn and Hoang 2007).
P07-2045
Named Entity Transliteration and Discovery from Multilingual Comparable Corpora, COLING-ACL, Sidney, Australia Philipp Koehn, Franz Josef Och, and Daniel Marcu, 2003.
P03-1021
We employ the phrase-based SMT framework (Koehn et al., 2003), and use the Moses toolkit (Koehn et al., 2007), and the SRILM language modelling toolkit (Stolcke, 2002), and evaluate our decoded translations using the BLEU measure (Papineni et al., 2002), using a single reference translation.
P07-2045
The weighting parameters of these features were optimized in terms of BLEU by the approach of minimum error rate training (Och, 2003).
P03-1021
This paper describes the development of a statistical machine translation system based on the Moses decoder (Koehn et al., 2007) for the 2007 WMT shared tasks.
P07-2045
The comparison phrasal system was constructed using the same GIZA++ alignments and the heuristic combination described in (Och & Ney, 2003).
P03-1021
Och. 2003.
P03-1021 P03-1021 P03-1021 P03-1021
It is today common practice to use phrases as translation units (Koehn et al., 2003; Och and Ney, 2003) and a log linear framework in order to introduce several models explaining the translation process: e??= argmaxp(e|f) = argmaxe {exp(summationdisplay i ihi(e,f))} (1) The feature functions hi are the system models and the i weights are typically optimized to maximize a scoring function on a development set (Och and Ney, 2002).
P03-1021
One experiment was run by NRC using the language pair English<>French in the context of  Automatic Post-Edition  systems using the PORTAGE system as described in Simard et al.(2007). The second experiment based on the same principle was run on the German>English and Spanish>English1 language pairs using the Moses system (Koehn et al.2007). The objective was to train a SMT system on a parallel corpus composed of SYSTRAN translations with the referenced source aligned with its referenced translation.
P07-2045
The optimal weights for the different columns can then be assigned with the help of minimum error rate training (Och, 2003).
P03-1021
Here, we drop both dependencies in order to simplify to a jump width alignment probability distribution: p(aj |aj??1,xj??1,y) ?? braceleftbigg p(a j) j = 1 p(aj?aj)?? j > 1 (3) p(xj |aj1,xj??1,y) ?p(xj |yaj) (4) Furthermore, the treatment of the NULL word is the same as that presented in (Och and Ney, 2003).
P03-1021
Applied both in the training and decoding step, Collins et al.(2005) describe a method for introducing syntactic information for reordering in SMT.
P05-1066
Feature weight tuning was carried out using minimum error rate training, maximizing BLEU scores on a held-out development set (Och, 2003).
P03-1021
In the first part, a word alignment was computed (using the GIZA++ toolkit (Och and Ney, 2003)).
P03-1021
We selected 580 short sentences of length at most 50 characters from the 2002 NIST MT Evaluation test set as our development corpus and used it to tune s by maximizing the BLEU score (Och, 2003), and used the 2005 NIST MT Evaluation test set as our test corpus.
P03-1021
Collinsetal.(2005)suggestamethodtoreorder the German input before translating using a set of manually crafted rules.
P05-1066
Koehn. 2007.
P07-2045
Weights on the loglinear features are set using Och's algorithm (Och, 2003) to maximize the system's BLEU score on a development corpus.
P03-1021
In recent years, statistical machine translation have experienced a quantum leap in quality thanks to automatic evaluation (Papineni et al., 2002) and errorbased optimization (Och, 2003).
P03-1021
all contributed to increased system?s complexity, and, as a result, time limitations prevented us from performing minimum-error-rate training (MERT) (Och, 2003) for ucb3, ucb4 and ucb5.
P03-1021
Edinburgh, UK (Dugast et al., 2007) systran-nrc National Research Council, Canada (Simard et al., 2007) ucb University of California at Berkeley, USA (Nakov and Hearst, 2007) uedin University of Edinburgh, UK (Koehn and Schroeder, 2007) umd University of Maryland, USA (Dyer, 2007) upc University of Catalonia, Spain (Costa-Juss`a and Fonollosa, 2007) upv University of Valencia, Spain (Civera and Juan, 2007) Table 1: Participants in the shared task.
P07-2045
Och (2003) introduced minimum error rate training (MERT), a technique for optimizing log-linear modelparametersrelativetoameasureoftranslation quality.
P03-1021
Oncetraininghastakenplace,minimumerrorrate training (Och, 2003) is used to tune the parameters i.
P03-1021
In this work, we present a mixture extension of the well-known HMM alignment model first proposed in (Vogel and others, 1996) and refined in (Och and Ney, 2003).
P03-1021
To model p(t,a|s), we use a standard loglinear approach: p(t,a|s) ??exp bracketleftBiggsummationdisplay i ifi(s,t,a) bracketrightBigg (1) where each fi(s,t,a) is a feature function, and weights i are set using Och?s algorithm (Och, 2003) to maximize the system?s BLEU score (Papineni et al., 2001) on a development corpus.
P03-1021
The factored translation model combines features in a log-linear fashion (Och, 2003).
P03-1021
The feature weights i are trained in concert with the LM weight via minimum error rate (MER) training (Och, 2003).
P03-1021
In the experiment, only the first 500 sentences were used to train the log-linear model weight vector, where minimum error rate (MER) training was used (Och, 2003).
P03-1021
