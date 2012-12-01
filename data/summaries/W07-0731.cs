Raw parallel data need to be preprocessed in the modern phrase-based SMT before they are aligned by alignment algorithms, one of which is the wellknown tool, GIZA++ (Och and Ney, 2003), for training IBM models (1-4).
P03-1021
Franz J. Och and Hermann Ney. 2004. The alignment 
J04-4002
3see http://www.statmt.org/moses/ 194 4 Implementation Details 4.1 Alignment of MT output The input text and the output text of the MT systems was aligned by means of GIZA++ (Och and Ney, 2003), a tool with which statistical models for alignment of parallel texts can be trained.
P03-1021
In this work, we describe results from the open-source Syntax Augmented Machine Translation (SAMT) toolkit (Zollmann and Venugopal, 2006) applied to the Spanish-to-English in-domain translation task of the ACL??7 workshop on statistical machine translation.
W06-3119
Portage is a statistical phrase-based SMT system similar to Pharaoh (Koehn et al, 2003).
N03-1017
A possible solution is the implementation of interpolation techniques to smooth sharp distributions estimated on few events (Och and Ney, 2003; Zhao and Xing, 2006).
P03-1021
The alignment template approach (Och & Ney, 2004) uses word classes rather than lexical items to model phrase translation.
J04-4002
Koehn and others, 2007), but replacing the Viterbi alignments, usually provided by GIZA++ (Och and Ney, 2003), by those of the HMM mixture model with training scheme mix15H5.
N03-1017 P03-1021
It is today common practice to use phrases as translation units (Koehn et al., 2003; Och and Ney, 2003) and a log linear framework in order to introduce several models explaining the translation process: e??= argmaxp(e|f) = argmaxe {exp(summationdisplay i ihi(e,f))} (1) The feature functions hi are the system models and the i weights are typically optimized to maximize a scoring function on a development set (Och and Ney, 2002).
N03-1017 P03-1021
Translations tables in Phrase-based Statistical Machine Translation (SMT) are often built on the basis of Maximum-likelihood Estimation (MLE), being one of the major limitations of this approach that the source sentence context in which phrases occur is completely ignored (Koehn et al., 2003).
N03-1017
The first of these models, that of Marcu and Wong (2002), was found by Koehn, et al.(2003), to produce translations not quite as good as their method.
N03-1017
The compound splitting was based on (Koehn and Knight, 2003) and was applied on the lowercased source sentences.
N03-1017
Nowadays, statistical machine translation is mainly based on phrases (Koehn et al., 2003).
N03-1017
Moore Chris Quirk Microsoft Research Redmond, WA 98052, USA {bobmoore,chrisq}@microsoft.com Abstract Attempts to estimate phrase translation probablities for statistical machine translation using iteratively-trained models have repeatedly failed to produce translations as good as those obtained by estimating phrase translation probablities from surface statistics of bilingual word alignments as described by Koehn, et al.(2003). We propose a new iteratively-trained phrase translation model that produces translations of quality equal to or better than those produced by Koehn, et al.?s model.
N03-1017
Feature weight tuning was carried out using minimum error rate training, maximizing BLEU scores on a held-out development set (Och, 2003).
P03-1021
Modern phrasal SMT systems such as (Koehn et al., 2003) derive much of their power from being able to memorize and use long phrases.
N03-1017
Phrase-based statistical machine translation (Koehn et al.2003) has emerged as the dominant paradigm in machine translation research.
N03-1017
similar to Chiang (2005), in which FBIS corpus is 
P05-1033
Statistical Phrase-based Translation, In Proceedings of HLT-NAACL, Edmonton, Canada Franz Josef Och, 2003.
P03-1021
Och (2003) introduced minimum error rate training (MERT), a technique for optimizing log-linear modelparametersrelativetoameasureoftranslation quality.
P03-1021
{1,...,#NT()} ??{1,...,#NT()} oneto-one mapping from nonterminal tokens in  to nonterminal tokens in  ??w ??[0,?? : nonnegative real-valued weight Chiang (2005) uses a single nonterminal category, Galley et al.(2004) use syntactic constituents for the PSCFG nonterminal set, and Zollmann and Venugopal (2006) take advantage of CCG (CombinatorialCategoricalGrammar)(Steedman, 1999)inspired?slash?and?plus?categories,focusingontarget (rather than source side) categories to generate well formed translations.
P05-1033 P99-1039 W06-3119
The factored translation model combines features in a log-linear fashion (Och, 2003).
P03-1021
The feature weights i are trained in concert with the LM weight via minimum error rate (MER) training (Och, 2003).
P03-1021
David Chiang. 2005. A hierarchical phrase-based mod-
P05-1033
2 Phrase-based Statistical MT Our baseline is a standard phrase-based SMT system (Koehn et al., 2003).
N03-1017
The phrases in the translations were located using techniques from phrase-based statistical machine translation which extract phrase pairsfromwordalignments(Koehnetal., 2003; Och and Ney, 2004).
J04-4002 N03-1017
Still, a confidence range for BLEU can be estimated by bootstrapping (Och, 2003; Zhang and Vogel, 2004).
J04-4002 P03-1021
Philipp Koehn, Franz J. Och, and Daniel Marcu. 2003. 
N03-1017 P03-1021
translation Hierarchical systems (Chiang, 2005) induce a context-free grammar with one non-terminal directly from the parallel corpus, with the advantage of not requiring any additional knowledge source or tools, such as a treebank or a parser.
P05-1033
We employ the phrase-based SMT framework (Koehn et al., 2003), and use the Moses toolkit (Koehn et al., 2007), and the SRILM language modelling toolkit (Stolcke, 2002), and evaluate our decoded translations using the BLEU measure (Papineni et al., 2002), using a single reference translation.
N03-1017
Factored translation with source words determining target words and CCG supertags For our experiments we used the following features: the translation probabilities Pr(sFs1 |tFt1 ) and Pr(tFt1 |sFs1 ),thelexicalweights(Koehnetal.,2003) lex(sFs1 |tFt1 ) and lex(tFt1 |sFs1 ), and a phrase penalty e, which allows the model to learn a preference for longer or shorter phrases.
N03-1017
The overall translation model score consists of a weighted sum of the following eight aggregated feature values for each translation hypothesis: ??the sum of the log probabilities of each source phrase in the hypothesis given the corresponding target phrase, computed either by our model or the standard model, ??the sum of the log probabilities of each target phrase in the hypothesis given the corresponding source phrase, computed either by our model or the standard model, ??the sum of lexical scores for each source phrase given the corresponding target phrase, ??the sum of lexical scores for each target phrase given the corresponding source phrase, ??the log of the target language model probability for the sequence of target phrases in the hypothesis, ??the total number of words in the target phrases in the hypothesis, ??the total number of source/target phrase pairs composing the hypothesis, ??the distortion penalty as implemented in the Pharaoh decoder (Koehn, 2003).
N03-1017
It also contains tools for tuning these models using minimum error rate training (Och 2003) and evaluating the resulting translations using the BLEU score (Papineni et al.2002). Moses uses standard external tools for some of the tasks to avoid duplication, such as GIZA++ (Och and Ney 2003) for word alignments and SRILM for language modeling.
P03-1021
BLEU score using the algorithm described in (Och, 2003).
P03-1021
The weighting parameters of these features were optimized in terms of BLEU by the approach of minimum error rate training (Och, 2003).
P03-1021
They are generated from the training corpus via the ?diag-and??method (Koehn et al., 2003) and smoothed using Kneser-Ney smoothing (Foster et al., 2006), ??one or several n-gram language model(s) trained with the SRILM toolkit (Stolcke, 2002); in the baseline experiments reported here, we used a trigram model, ??a distortion model which assigns a penalty based on the number of source words which are skipped when generating a new target phrase, ??a word penalty.
N03-1017
1 in the alignment visualization style defined by Galley et al.(2004). Following the Data-Oriented Parsing inspired rule generalization technique proposed by Chiang (2005), one can now generalize each identified rule (initial or already partially generalized) N ?? f1...fm/e1 ...en for which there is an initial rule M ??fi ...fu/ej ...ev where 1 ??i < u ??m and 1 ??j < v ??n, to obtain a new rule N ?f1 ...fi??Mkfu+1 ...fm/e1 ...ej??Mkev+1 ...en where k is an index for the nonterminal M that indicates the one-to-one correspondence between the new M tokens on the two sides (it is not in the space of word indices like i,j,u,v,m,n).
P05-1033
We use the following features in our induced English-to-English grammar:3 3Hiero also uses lexical weights (Koehn et al., 2003) in both 122 ??The joint probability of the two English hierarchical paraphrases, conditioned on the nonterminal symbol, as defined by this formula: p(e1, e2|x) = c(X ???e1, e2??summationtext e1prime, e2prime c(X ???e1prime, e2prime??
N03-1017
Over the last several years, various statistical syntaxbased models were proposed to extend traditional word/phrase based models in statistical machine translation (SMT) (Lin, 2004; Chiang, 2005; Ding et al., 2005; Quirk et al., 2005; Marcu et al., 2006; Liu et al., 2006).
P05-1033
We selected 580 short sentences of length at most 50 characters from the 2002 NIST MT Evaluation test set as our development corpus and used it to tune s by maximizing the BLEU score (Och, 2003), and used the 2005 NIST MT Evaluation test set as our test corpus.
P03-1021
The features used in this study are: the length of t; a single-parameter distortion penalty on phrase reordering in a, as described in (Koehn et al., 2003); phrase translation model probabilities; and 4-gram language model probabilities logp(t), using Kneser-Ney smoothing as implemented in the SRILM toolkit.
N03-1017
Och and Ney (2004) gave a framework of alignment templates for this kind of models.
J04-4002
However, such models are typically applied over limited source sentence ranges to prevent errors introduced by these models and to maintain efficient decoding (Och and Ney, 2004).
J04-4002
In recent years, statistical machine translation have experienced a quantum leap in quality thanks to automatic evaluation (Papineni et al., 2002) and errorbased optimization (Och, 2003).
P03-1021
phrase-based decoding Chiang (2005; to appear 2007) introduced hierarchical phrase-based translation models, which are formally based on synchronous context-free grammars.
P05-1033
We used the GIZA++ SMT Toolkit1 (Och and Ney, 2003) to generate word alignments.
P03-1021
Therefore, recent efforts (Och et al., 2004) have concentrated on feature design ??wherein more intelligent features may be added.
J04-4002
Viewed at a very high level, statistical machine translationinvolvesfourphases: languageandtranslation model training, parameter tuning, decoding, and evaluation (Lopez, 2007; Koehn et al., 2003).
N03-1017
We compare our scores against the CMU-UKA ISL phrase-based submission, a state-of-the art phrase-based SMT system with part-of-speech (POS) based word reordering (Paulik et al., 2007).
W07-0727
Compounds tend to lead to sparse data problems and splitting them has been shown to improve German-English translation (Koehn and Knight, 2003).
N03-1017
216 2.1 Grammar Induction Zollmann and Venugopal (2006) describe a process to generate a PSCFG given parallel sentence pairs ?f,e?? a parse tree pi for each e, the maximum a posteriori word alignment a over ?f,e?? and phrase pairs Phrases(a) identified by any alignment-driven phrase induction technique such as e.g.
W06-3119
With these considerations in mind, feature engineering is an active area of research (Och et al., 2004).
J04-4002
Table 1 shows the impact of increasing reordering window length (Koehn et al., 2003) on translation quality for the ?dev06??data.2 Increasing the reordering window past 2 has minimal impact on translation quality, implying that most of the reordering effects across Spanish and English are well modeled at the local or phrase level.
N03-1017
The feature weights for the overall translation models were trained using Och?s (2003) minimum-error-rate training procedure.
P03-1021
models (Och et al., 2004; Koehn et al., 2003; 
J04-4002 N03-1017 P03-1021
baseline System used for comparison was Pharaoh (Koehn et al., 2003; Koehn, 2004), which uses a beam search algorithm for decoding.
N03-1017
Named Entity Transliteration and Discovery from Multilingual Comparable Corpora, COLING-ACL, Sidney, Australia Philipp Koehn, Franz Josef Och, and Daniel Marcu, 2003.
N03-1017 P03-1021
Chiang, 2005), some of measure words can be 
P05-1033
To generate phrase pairs from a parallel corpus, we use the "diag-and" phrase induction algorithm described in (Koehn et al, 2003), with symmetrized word alignments generated using IBM model 2 (Brown et al, 1993).
N03-1017
As in phrasebased translation model estimation, ? also contains two lexical weights (Koehn et al., 2003), counters for number of target terminals generated.
N03-1017
Each transduction rule null has a vector of variables null nullnull,?null nullnull . Each variable is associated with an input node nullnullnullnull . For each input node null, we keep a beam of derivations nullnullnullnull . Derivations are represented as a pair nullnull,nullnull where null is a transduction rule and nullnullnull null is a vector with one integer for each of the null variables in null . The interpretation is that the complete candidate can be constructed by recursively substituting for each 6 Like Chiang (2005) we only search for the yield of the most likely derivation, rather than the most likely yield.
P05-1033
Here, we drop both dependencies in order to simplify to a jump width alignment probability distribution: p(aj |aj??1,xj??1,y) ?? braceleftbigg p(a j) j = 1 p(aj?aj)?? j > 1 (3) p(xj |aj1,xj??1,y) ?p(xj |yaj) (4) Furthermore, the treatment of the NULL word is the same as that presented in (Och and Ney, 2003).
P03-1021
To address these concerns, hierarchically structured models as in Chiang (2005) define weighted transduction rules, interpretable as components of a probabilistic synchronous grammar (Aho and Ullman, 1969) that represent translation and reordering operations.
P05-1033
138 ID Participant cmu-uka Carnegie Mellon University, USA (Paulik et al., 2007) cmu-syntax Carnegie Mellon University, USA (Zollmann et al., 2007) cu Charles University, Czech Republic (Bojar, 2007) limsi LIMSI-CNRS, France (Schwenk, 2007) liu University of Linkoping, Sweden(Holmqvist et al., 2007) nrc National Research Council, Canada (Ueffing et al., 2007) pct a commercial MT provider from the Czech Republic saar Saarland University & DFKI, Germany (Chen et al., 2007) systran SYSTRAN, France & U.
W07-0727
In the first part, a word alignment was computed (using the GIZA++ toolkit (Och and Ney, 2003)).
P03-1021
??Initial phrase pairs are identified following the procedure typically employed in phrase based systems (Koehn et al., 2003; Och and Ney, 2004).
J04-4002 N03-1017
Oncetraininghastakenplace,minimumerrorrate training (Och, 2003) is used to tune the parameters i.
P03-1021
To model p(t,a|s), we use a standard loglinear approach: p(t,a|s) ??exp bracketleftBiggsummationdisplay i ifi(s,t,a) bracketrightBigg (1) where each fi(s,t,a) is a feature function, and weights i are set using Och?s algorithm (Och, 2003) to maximize the system?s BLEU score (Papineni et al., 2001) on a development corpus.
P03-1021
To optimize the system towards a maximal BLEU or NIST score, we use Minimum Error Rate (MER) Training as described in (Och, 2003).
P03-1021
Recently 1www.nist.gov/speech/tests/mt/mt06eval official results.html there have been a few syntax-based models that show performance comparable to the phrase-based models (Chiang, 2005; Marcu et al., 2006).
P05-1033
We wanted to test the following hypotheses: ??Translation models based on lemmas will improve translation quality (Popovi and Ney, 2004) ??Decompounding German nominal compounds will improve translation quality (Koehn and Knight, 2003) ??Re-ordering models based on word forms and parts-of-speech will improve translation quality (Zens and Ney, 2006).
N03-1017
Our decoder is a reimplementation in Perl of the algorithm used by the Pharaoh decoder as described by Koehn (2003).2 The data we used comes from an English-French bilingual corpus of Canadian Hansards parliamentary proceedings supplied for the bilingual word alignment workshop held at HLT-NAACL 2003 (Mihalcea and Pedersen, 2003).
N03-1017
The word alignments were created with Giza++ (Och and Ney, 2003) applied to a parallel corpus containing 200,000 sentence pairs of the training data, plus sets of 4,007 sentence pairs created by pairing the test sentences with the reference translations, and the test sentences paired with each of the system translations.
P03-1021
We use the n-best generation scheme interleaved with  optimization as described in (Och, 2003).
P03-1021
We compared our system to Pharaoh, a leading phrasal SMT decoder (Koehn et al., 2003), and our treelet system.
N03-1017
Model weights were trained separately for all 3 systems using minimum error rate training to maximize BLEU (Och, 2003) on the development set (dev).
P03-1021
Och, 2003, Minimum Error Rate Training in Statistical Machine Translation.
P03-1021
Grammars for SMT Probabilistic synchronous context-free grammars (PSCFGs) are defined by a source terminal set (source vocabulary) TS, a target terminal set (target vocabulary)TT,asharednonterminalsetN andproduction rules of the form X ????,??w?? where following (Chiang, 2005) ??X ??N is a nonterminal ?? ??(N ?TS)??: sequence of source nonterminals and terminals ?? ??(N ?TT)??: sequence of target nonterminals and terminals ??the count #NT() of nonterminal tokens in  is equalto thecount #NT() ofnonterminal tokens in , ????
P05-1033
While xRS 2 Marcu et al.(2006) and Zollmann et al.(2006) recognize this problem and attempt to alleviate it by grafting surface phrases into constituency trees by various methods.
W06-3119
73 2.2.4 Minimum Error Rate Training A good way of training is to minimize empirical top-1 error on training data (Och, 2003).
P03-1021
159 2.1 Baseline System The baseline system is a phrase-based SMT system (Koehn et al., 2003), built almost entirely using freely available components.
N03-1017
FastTranslateChart implements both methods of handling the LM intersection described in (Venugopal et al., 2007).
N07-1063
The computational challenges of this search task (compounded by the integration of the LM) are addressed in (Chiang, 2007; Venugopal et al., 2007).
N07-1063
Approaches Koehn, et al.?s (2003) method of estimating phrasetranslation probabilities is very simple.
N03-1017
Word alignment is an important step of most modern approaches to statistical machine translation (Koehn et al., 2003).
N03-1017
The comparison phrasal system was constructed using the same GIZA++ alignments and the heuristic combination described in (Och & Ney, 2003).
P03-1021
An early attempt at greater generality in a purely phrasal setting was the alignment template approach (Och & Ney 2004); newer approaches include formally syntactic (Chiang 2005), and linguistically syntactic approaches (Quirk et al.2005), (Huang et al.2006). In the next section, we examine these representative approaches to the reordering problem.
J04-4002 P05-1033
Och. 2003.
P03-1021 P03-1021 P03-1021 P03-1021
For example, the following two rules were extracted from the Spanish ??English segment of the Europarl corpus (Koehn, 2003): X ???la X1 de X2,X2 ?s X1??(2) X ???el X1 verde,the green X1??(3) Rule (2) expresses the fact that possessors can be expressed prior to the possessed object in English but must follow in Spanish.
N03-1017
The most widely used method for estimating these probabilities is that of Koehn, et al.(2003), in which phrase pairs are extracted from word-aligned bilingual sentence pairs, and their translation probabilities estimated heuristically from surface statistics of the extracted phrase pairs.
N03-1017
It is an extension of Pharaoh (Koehn et al., 2003), and supports factor training and decoding.
N03-1017
IQMT. The optimal set is: { METEORwnsyn, ROUGEw 1.2 } which includes variants of METEOR, and ROUGE (Lin and Och, 2004).
J04-4002
Koehn and Knight, 2003).
N03-1017
We now describe the identification and estimation of PSCFG rules from parallel sentence aligned corpora under the framework proposed by Zollmann and Venugopal (2006).
W06-3119
As Chiang (2005) and Koehn et al.(2003) note, purely lexical ?phrase-based??translation models suffer from sparse data effects when translating conceptual elements that span or skip across several source language words.
N03-1017 P05-1033
But it has been found that phrases longer than three words have little improvement in the performance (Koehn, 2003).
N03-1017
(Och and Ney, 2004).
J04-4002
Weights on the loglinear features are set using Och's algorithm (Och, 2003) to maximize the system's BLEU score on a development corpus.
P03-1021
To derive the joint counts c(?s,?t) from which p(?s|?t) and p(?t|?s) are estimated, we use the phrase induction algorithm described in (Koehn et al., 2003), with symmetrized word alignments generated using IBM model 2 (Brown et al., 1993).
N03-1017
all contributed to increased system?s complexity, and, as a result, time limitations prevented us from performing minimum-error-rate training (MERT) (Och, 2003) for ucb3, ucb4 and ucb5.
P03-1021
References Koehn, Philipp and Kevin Knight, 2003.
N03-1017
These models also suffer from a large search space when decoding with an integrated language model, which can lead to search errors (Chiang, 2005).
P05-1033
In this work, we present a mixture extension of the well-known HMM alignment model first proposed in (Vogel and others, 1996) and refined in (Och and Ney, 2003).
P03-1021
The optimal weights for the different columns can then be assigned with the help of minimum error rate training (Och, 2003).
P03-1021
In the experiment, only the first 500 sentences were used to train the log-linear model weight vector, where minimum error rate (MER) training was used (Och, 2003).
P03-1021
