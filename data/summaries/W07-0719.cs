Raw parallel data need to be preprocessed in the modern phrase-based SMT before they are aligned by alignment algorithms, one of which is the wellknown tool, GIZA++ (Och and Ney, 2003), for training IBM models (1-4).
J03-1002
For evaluation we use ROUGE (Lin, 2004) SU4 recall metric1, which was among the official automatic evaluation metrics for DUC.
P04-1077
Portage is a statistical phrase-based SMT system similar to Pharaoh (Koehn et al, 2003).
N03-1017
It is also very similar to the joint training procedure for HMM wordalignment models in both directions described by Liang et al.(2006), which was the original inspiration for our training procedure.
P06-1096
However, at the short term, the incorporation of these type of features will force us to either build a new decoder or extend an existing one, or to move to a new MT architecture, for instance, in the fashion of the architectures suggested by Tillmann and Zhang (2006) or Liang et al.(2006). Acknowledgements This research has been funded by the Spanish Ministry of Education and Science, projects OpenMT (TIN2006-15307-C03-02) and TRAN165 GRAM (TIN2004-07925-C03-02).
P06-1091 P06-1096
Others try to accommodate both syntactic and lexical differences between the candidate translation and the reference, like CDER (Leusch et al., 2006), which employs a version of edit distance for word substitution and reordering; or METEOR (Banerjee and Lavie, 2005), which uses stemming and WordNet synonymy.
W05-0909
This might prove beneficial for various discriminative training methods (Tillmann and Zhang, 2006).
P06-1091
For instance, some max-margin methods restrict their computations to a set of examples from a ?feasible set,?? where they are expected to be maximally discriminative (Tillmann and Zhang, 2006).
P06-1091
Translations tables in Phrase-based Statistical Machine Translation (SMT) are often built on the basis of Maximum-likelihood Estimation (MLE), being one of the major limitations of this approach that the source sentence context in which phrases occur is completely ignored (Koehn et al., 2003).
N03-1017
We extend the work by Vickrey et al.(2005) in two main aspects.
H05-1097
The first of these models, that of Marcu and Wong (2002), was found by Koehn, et al.(2003), to produce translations not quite as good as their method.
N03-1017
While these are based on a relatively few number of items, and while we have not performed any tests to determine whether the differences in ? are statistically significant, the results 7The Czech-English conditions were excluded since there were so few systems 146 are nevertheless interesting, since three metrics have higher correlation than Bleu: ??Semantic role overlap (Gimenez and M`arquez, 2007), which makes its debut in the proceedings of this workshop ??ParaEval measuring recall (Zhou et al., 2006), which has a model of allowable variation in translation that uses automatically generated paraphrases (Callison-Burch, 2007) ??Meteor (Banerjee and Lavie, 2005) which also allows variation by introducing synonyms and by flexibly matches words using stemming.
W05-0909
Moore Chris Quirk Microsoft Research Redmond, WA 98052, USA {bobmoore,chrisq}@microsoft.com Abstract Attempts to estimate phrase translation probablities for statistical machine translation using iteratively-trained models have repeatedly failed to produce translations as good as those obtained by estimating phrase translation probablities from surface statistics of bilingual word alignments as described by Koehn, et al.(2003). We propose a new iteratively-trained phrase translation model that produces translations of quality equal to or better than those produced by Koehn, et al.?s model.
N03-1017
Results are also coherent with those attained by Vickrey et al.(2005). -1 -0.5 0 0.5 1 0 50000 100000 150000 200000 250000 300000 accuracy(DPT) accuracy(MLE) #examples Figure 1: Analysis of ?Phrase Translation??Results on the development set (Spanish-to-English).
H05-1097
As suggested in (Liang et al., 2006), we also use two separate sets of distortion parameters for transitioning into the first state, and for transitioning out of the last state, respectively.
P06-1096
Modern phrasal SMT systems such as (Koehn et al., 2003) derive much of their power from being able to memorize and use long phrases.
N03-1017
Phrase-based statistical machine translation (Koehn et al.2003) has emerged as the dominant paradigm in machine translation research.
N03-1017
In practice, we can bucket the distortion parameters {c(d)} into a few buckets as implemented in (Liang et al., 2006).
P06-1096
2004. Long-Distance Dependency Resolution in Automatically Acquired Wide-Coverage PCFG-Based LFG Approximations, In Proceedings of Association for Computational Linguistics 2004: 320-327.
P04-1077
Statistical Phrase-based Translation, In Proceedings of HLT-NAACL, Edmonton, Canada Franz Josef Och, 2003.
J03-1002
In spite of working on a very specific domain, a large room for improvement, coherent with WSD performance, and results by Vickrey et al.(2005), is predicted.
H05-1097
Och (2003) introduced minimum error rate training (MERT), a technique for optimizing log-linear modelparametersrelativetoameasureoftranslation quality.
J03-1002
Note that using stems and their synonyms as used in METEOR (Banerjee and Lavie, 2005) could also be considered for word similarity.
W05-0909
Alto, CA 94304 {thione|vdberg|culy|polanyi}@fxpal.com Abstract In this paper, we introduce LiveTree, a core component of LIDAS, the Linguistic Discourse Analysis System for automatic discourse parsing with the Unified Linguistic Discourse Model (U-LDM) (X et al, 2004).
P04-1077
The factored translation model combines features in a log-linear fashion (Och, 2003).
J03-1002
Viewed at a very high level, statistical machine translationinvolvesfourphases: languageandtranslation model training, parameter tuning, decoding, and evaluation (Lopez, 2007; Koehn et al., 2003).
N03-1017
The phrases in the translations were located using techniques from phrase-based statistical machine translation which extract phrase pairsfromwordalignments(Koehnetal., 2003; Och and Ney, 2004).
N03-1017
The comparison phrasal system was constructed using the same GIZA++ alignments and the heuristic combination described in (Och & Ney, 2003).
J03-1002
.,[ 1 n tt SS, i .e . t h e s e m a nt i c i nt e r p r e t a t i on of T, w h er e i t S 2 is e it h e r t h e ch o sen s en se f o r t i ( i .e ., t he r e s u l t of a pr e v i ou s 2 N o te t h a t wi t h i t S w e r ef er i n t er c h a n g ea b l y t o t h e s em a n t i c g r ap h as s o c i at e d w i t h a s e n s e o r t o t h e s e n s e na me . Association for Computational Linguistics for the Semantic Analysis of Text, Barcelona, Spain, July 2004 SENSEVAL-3: Third International Workshop on the Evaluation of Systems disambiguation step) or the empty set (i.e., the term is not yet disambiguated).
P04-1077
Translation Analogously to the ?word translation??definition by Vickrey et al.(2005), rather than predicting the sense of a word according to a given sense inventory, in ?phrase translation?? the goal is to predict the correct translation of a phrase, for a given target language, in the context of a sentence.
H05-1097
This makes it suitable for discriminative SMT training, which is still a challenge for large parameter sets (Tillmann and Zhang, 2006; Liang et al., 2006).
P06-1091 P06-1096
Still, a confidence range for BLEU can be estimated by bootstrapping (Och, 2003; Zhang and Vogel, 2004).
J03-1002
Philipp Koehn, Franz J. Och, and Daniel Marcu. 2003. 
J03-1002 N03-1017
We employ the phrase-based SMT framework (Koehn et al., 2003), and use the Moses toolkit (Koehn et al., 2007), and the SRILM language modelling toolkit (Stolcke, 2002), and evaluate our decoded translations using the BLEU measure (Papineni et al., 2002), using a single reference translation.
N03-1017
In a later work, Carpuat and Wu (2005a) analyzed the converse question, i.e. they measured the WSD performance of SMT models.
I05-2021 P05-1048
Factored translation with source words determining target words and CCG supertags For our experiments we used the following features: the translation probabilities Pr(sFs1 |tFt1 ) and Pr(tFt1 |sFs1 ),thelexicalweights(Koehnetal.,2003) lex(sFs1 |tFt1 ) and lex(tFt1 |sFs1 ), and a phrase penalty e, which allows the model to learn a preference for longer or shorter phrases.
N03-1017
The overall translation model score consists of a weighted sum of the following eight aggregated feature values for each translation hypothesis: ??the sum of the log probabilities of each source phrase in the hypothesis given the corresponding target phrase, computed either by our model or the standard model, ??the sum of the log probabilities of each target phrase in the hypothesis given the corresponding source phrase, computed either by our model or the standard model, ??the sum of lexical scores for each source phrase given the corresponding target phrase, ??the sum of lexical scores for each target phrase given the corresponding source phrase, ??the log of the target language model probability for the sequence of target phrases in the hypothesis, ??the total number of words in the target phrases in the hypothesis, ??the total number of source/target phrase pairs composing the hypothesis, ??the distortion penalty as implemented in the Pharaoh decoder (Koehn, 2003).
N03-1017
It also contains tools for tuning these models using minimum error rate training (Och 2003) and evaluating the resulting translations using the BLEU score (Papineni et al.2002). Moses uses standard external tools for some of the tasks to avoid duplication, such as GIZA++ (Och and Ney 2003) for word alignments and SRILM for language modeling.
J03-1002
Our work extends that of Vickrey et al.(2005) in two main aspects.
H05-1097
The weighting parameters of these features were optimized in terms of BLEU by the approach of minimum error rate training (Och, 2003).
J03-1002
We use the following features in our induced English-to-English grammar:3 3Hiero also uses lexical weights (Koehn et al., 2003) in both 122 ??The joint probability of the two English hierarchical paraphrases, conditioned on the nonterminal symbol, as defined by this formula: p(e1, e2|x) = c(X ???e1, e2??summationtext e1prime, e2prime c(X ???e1prime, e2prime??
N03-1017
Work The DTSC model is different from previous work based on dependency grammars by Eisner (2003), Lin (2004), Quirk et al.(2005), Ding et al.(2005) since they all deduce dependency structures on the target side.
P04-1077
Over the last several years, various statistical syntaxbased models were proposed to extend traditional word/phrase based models in statistical machine translation (SMT) (Lin, 2004; Chiang, 2005; Ding et al., 2005; Quirk et al., 2005; Marcu et al., 2006; Liu et al., 2006).
P04-1077
We selected 580 short sentences of length at most 50 characters from the 2002 NIST MT Evaluation test set as our development corpus and used it to tune s by maximizing the BLEU score (Och, 2003), and used the 2005 NIST MT Evaluation test set as our test corpus.
J03-1002
The features used in this study are: the length of t; a single-parameter distortion penalty on phrase reordering in a, as described in (Koehn et al., 2003); phrase translation model probabilities; and 4-gram language model probabilities logp(t), using Kneser-Ney smoothing as implemented in the SRILM toolkit.
N03-1017
In an experiment on 16,800 sentences of Chinese-English newswire text with segment-level human evaluation from the Linguistic Data Consortium?s (LDC) Multiple Translation project, we compare the LFG-based evaluation method with other popular metrics like BLEU, NIST, General Text Matcher (GTM) (Turian et al., 2003), Translation Error Rate (TER) (Snover et al., 2006)1, and METEOR (Banerjee and Lavie, 2005), and we show that combining dependency representations with synonyms leads to a more accurate evaluation that correlates better with human judgment.
W05-0909
In recent years, statistical machine translation have experienced a quantum leap in quality thanks to automatic evaluation (Papineni et al., 2002) and errorbased optimization (Och, 2003).
J03-1002
We used the GIZA++ SMT Toolkit1 (Och and Ney, 2003) to generate word alignments.
J03-1002
baseline System used for comparison was Pharaoh (Koehn et al., 2003; Koehn, 2004), which uses a beam search algorithm for decoding.
N03-1017
2 Phrase-based Statistical MT Our baseline is a standard phrase-based SMT system (Koehn et al., 2003).
N03-1017
The feature weights for the overall translation models were trained using Och?s (2003) minimum-error-rate training procedure.
J03-1002
models (Och et al., 2004; Koehn et al., 2003; 
J03-1002 N03-1017
For instance, Carpuat and Wu (2005b) suggested integrating WSD predictions into a SMT system in a ?hard?? manner, either for decoding, by constraining the set of acceptable translation candidates for each given source word, or for post-processing the SMT system output, by directly replacing the translation of each selected word with the WSD system prediction.
I05-2021 P05-1048
They are: ??Meteor (Banerjee and Lavie, 2005)?Meteor measures precision and recall of unigrams when comparing a hypothesis translation 142 Language Pair Test Set Adequacy Fluency Rank Constituent English-German Europarl 1,416 1,418 1,419 2,626 News Commentary 1,412 1,413 1,412 2,755 German-English Europarl 1,525 1,521 1,514 2,999 News Commentary 1,626 1,620 1,601 3,084 English-Spanish Europarl 1,000 1,003 1,064 1,001 News Commentary 1,272 1,272 1,238 1,595 Spanish-English Europarl 1,174 1,175 1,224 1,898 News Commentary 947 949 922 1,339 English-French Europarl 773 772 769 1,456 News Commentary 729 735 728 1,313 French-English Europarl 834 833 830 1,641 News Commentary 1,041 1,045 1,035 2,036 English-Czech News Commentary 2,303 2,304 2,331 3,968 Czech-English News Commentary 1,711 1,711 1,733 0 Totals 17,763 17,771 17,820 27,711 Table 2: The number of items that were judged for each task during the manual evaluation against a reference.
W05-0909
Named Entity Transliteration and Discovery from Multilingual Comparable Corpora, COLING-ACL, Sidney, Australia Philipp Koehn, Franz Josef Och, and Daniel Marcu, 2003.
J03-1002 N03-1017
To generate phrase pairs from a parallel corpus, we use the "diag-and" phrase induction algorithm described in (Koehn et al, 2003), with symmetrized word alignments generated using IBM model 2 (Brown et al, 1993).
N03-1017
Simultaneously, Vickrey et al.(2005) studied the 164 Source tiene la palabra la se?nora mussolini para una cuestion de orden . Ref 1 mrs mussolini has the floor for a point of order . Ref 2 you have the floor, missus mussolini, for a question of order . Ref 3 ms mussolini has now the floor for a point of order . P(e) + PMLE(e|f) i give the floor to the lady mussolini for a procedural motion . P(e) + PDPT(e|f) has the floor the mrs mussolini on a point of order . Table 4: Case of Analysis of sentence #422.
H05-1097
Following the approach by Vickrey et al.(2005), we deal with the ?phrase translation??problem as a classification problem.
H05-1097
A new automatic metric METEOR (Banerjee and Lavie, 2005) uses stems and synonyms of the words.
W05-0909
Other work has incorporated paraphrases into MT evaluation: Russo-Lassner et al.(2005) use a combination of paraphrase-based features to evaluate translation output; Zhou et al.(2006) propose a new metric that extends n-gram matching to include synonyms and paraphrases; and Lavie?s METEOR metric (Banerjee and Lavie, 2005) can be used with additionalknowledgesuchasWordNetinordertosupport inexact lexical matches.
W05-0909
In the first part, a word alignment was computed (using the GIZA++ toolkit (Och and Ney, 2003)).
J03-1002
??Initial phrase pairs are identified following the procedure typically employed in phrase based systems (Koehn et al., 2003; Och and Ney, 2004).
N03-1017
Oncetraininghastakenplace,minimumerrorrate training (Och, 2003) is used to tune the parameters i.
J03-1002
To model p(t,a|s), we use a standard loglinear approach: p(t,a|s) ??exp bracketleftBiggsummationdisplay i ifi(s,t,a) bracketrightBigg (1) where each fi(s,t,a) is a feature function, and weights i are set using Och?s algorithm (Och, 2003) to maximize the system?s BLEU score (Papineni et al., 2001) on a development corpus.
J03-1002
Computational Linguistics 30 (4): 417-449 (2004) Papineni, Kishore, Salim Roukos, Todd Ward, and Wei-Jing Zhu.
P04-1077
Our decoder is a reimplementation in Perl of the algorithm used by the Pharaoh decoder as described by Koehn (2003).2 The data we used comes from an English-French bilingual corpus of Canadian Hansards parliamentary proceedings supplied for the bilingual word alignment workshop held at HLT-NAACL 2003 (Mihalcea and Pedersen, 2003).
N03-1017
The word alignments were created with Giza++ (Och and Ney, 2003) applied to a parallel corpus containing 200,000 sentence pairs of the training data, plus sets of 4,007 sentence pairs created by pairing the test sentences with the reference translations, and the test sentences paired with each of the system translations.
J03-1002
We use the n-best generation scheme interleaved with  optimization as described in (Och, 2003).
J03-1002
We compared our system to Pharaoh, a leading phrasal SMT decoder (Koehn et al., 2003), and our treelet system.
N03-1017
Model weights were trained separately for all 3 systems using minimum error rate training to maximize BLEU (Och, 2003) on the development set (dev).
J03-1002
Och, 2003, Minimum Error Rate Training in Statistical Machine Translation.
J03-1002
In contrast to the work by Lin (2004) and by Quirk et al.(2005), the DTSC model does not need to generate target language dependency structures using source structures and word alignments.
P04-1077
We might find better suited metrics, such as METEOR (Banerjee and Lavie, 2005), which is oriented towards word selection8.
W05-0909
73 2.2.4 Minimum Error Rate Training A good way of training is to minimize empirical top-1 error on training data (Och, 2003).
J03-1002
159 2.1 Baseline System The baseline system is a phrase-based SMT system (Koehn et al., 2003), built almost entirely using freely available components.
N03-1017
Och showed thatsystemperformanceisbestwhenparametersare optimizedusingthesameobjectivefunctionthatwill be used for evaluation; BLEU (Papineni et al., 2002) remains common for both purposes and is often retained for parameter optimization even when alternative evaluation measures are used, e.g., (Banerjee and Lavie, 2005; Snover et al., 2006).
W05-0909
Approaches Koehn, et al.?s (2003) method of estimating phrasetranslation probabilities is very simple.
N03-1017
Word alignment is an important step of most modern approaches to statistical machine translation (Koehn et al., 2003).
N03-1017
Morpho-syntactic annotation of the English references and hypotheses is performed using the constraint grammar parser ENGCG (Voutilainen, 1995), and the Spanish texts are annotated using the FreeLing analyser (Carreras et al., 2004).
P04-1077
Och. 2003.
J03-1002 J03-1002
The most widely used method for estimating these probabilities is that of Koehn, et al.(2003), in which phrase pairs are extracted from word-aligned bilingual sentence pairs, and their translation probabilities estimated heuristically from surface statistics of the extracted phrase pairs.
N03-1017
It is an extension of Pharaoh (Koehn et al., 2003), and supports factor training and decoding.
N03-1017
IQMT. The optimal set is: { METEORwnsyn, ROUGEw 1.2 } which includes variants of METEOR, and ROUGE (Lin and Och, 2004).
P04-1077
These two attributes are similar to those introduced by Lin (Lin, 2004).
P04-1077
But it has been found that phrases longer than three words have little improvement in the performance (Koehn, 2003).
N03-1017
Weights on the loglinear features are set using Och's algorithm (Och, 2003) to maximize the system's BLEU score on a development corpus.
J03-1002
To derive the joint counts c(?s,?t) from which p(?s|?t) and p(?t|?s) are estimated, we use the phrase induction algorithm described in (Koehn et al., 2003), with symmetrized word alignments generated using IBM model 2 (Brown et al., 1993).
N03-1017
The menu bar In this paper, we introduce LiveTree, a core component of LIDAS (the Linguistic Discourse Analysis System) for automatic discourse parsing with the Unified Linguistic Discourse Model (U-LDM) (Polanyi et al, 2004).
P04-1077
In the experiment, only the first 500 sentences were used to train the log-linear model weight vector, where minimum error rate (MER) training was used (Och, 2003).
J03-1002
