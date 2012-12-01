Raw parallel data need to be preprocessed in the modern phrase-based SMT before they are aligned by alignment algorithms, one of which is the wellknown tool, GIZA++ (Och and Ney, 2003), for training IBM models (1-4).
J03-1002 P03-1021
In past research, the approach used by Yang et al.(2006) was based on the Thayer?s model (1989), which divided emotions into 4 categories.
E06-1006
Using bootstrap resampling to compute confidence intervals (Koehn, 2004), we find that the improvement in BLEU score is statistically significant at p < .01.
W04-3250
Franz J. Och and Hermann Ney. 2004. The alignment 
C04-1045
3see http://www.statmt.org/moses/ 194 4 Implementation Details 4.1 Alignment of MT output The input text and the output text of the MT systems was aligned by means of GIZA++ (Och and Ney, 2003), a tool with which statistical models for alignment of parallel texts can be trained.
J03-1002 P03-1021
In this work, we describe results from the open-source Syntax Augmented Machine Translation (SAMT) toolkit (Zollmann and Venugopal, 2006) applied to the Spanish-to-English in-domain translation task of the ACL??7 workshop on statistical machine translation.
N06-2051
and SMT Our previous experience with SMT into Turkish (Durgar El-Kahlout and Oflazer, 2006) hinted that exploiting sub-lexical structure would be a fruitful avenue to pursue.
W06-3102
Portage is a statistical phrase-based SMT system similar to Pharaoh (Koehn et al, 2003).
E03-1076
A possible solution is the implementation of interpolation techniques to smooth sharp distributions estimated on few events (Och and Ney, 2003; Zhao and Xing, 2006).
J03-1002 P03-1021
Since the creation of BLEU (Papineni et al., 2002) and NIST (Doddington, 2002), the subject of automatic evaluation metrics for MT has been given quite a lot of attention.
P02-1040
Still, a confidence range for BLEU can be estimated by bootstrapping (Och, 2003; Zhang and Vogel, 2004).
J03-1002 P03-1021
Durgar El-Kahlout and Oflazer (2006) report preliminary experiments in English to Turkish singlefactored phrase-based translation, gaining significant improvements by splitting root words and their morphemes into a sequence of tokens.
W06-3102
We use two different estimates for the conditional probabilities p(?t|?s) and p(?s|?t): relative frequencies and ?lexical??probabilities as described in (Zens and Ney, 2004).
C04-1045
Since this trade-off is also affected by the settings of various pruning parameters, we compared decoding time and translation quality, as measured by BLEU score (Papineni et al, 2002), for the two models on our first test set over a broad range of settings for the decoder pruning parameters.
P02-1040
The alignment template approach (Och & Ney, 2004) uses word classes rather than lexical items to model phrase translation.
C04-1045
Koehn and others, 2007), but replacing the Viterbi alignments, usually provided by GIZA++ (Och and Ney, 2003), by those of the HMM mixture model with training scheme mix15H5.
E03-1076 J03-1002 P03-1021
BLEU score using the algorithm described in (Och, 2003).
J03-1002 P03-1021
It is today common practice to use phrases as translation units (Koehn et al., 2003; Och and Ney, 2003) and a log linear framework in order to introduce several models explaining the translation process: e??= argmaxp(e|f) = argmaxe {exp(summationdisplay i ihi(e,f))} (1) The feature functions hi are the system models and the i weights are typically optimized to maximize a scoring function on a development set (Och and Ney, 2002).
E03-1076 J03-1002 P03-1021
(Brown et al., 1992). We chose to work with the
J92-4003
Translations tables in Phrase-based Statistical Machine Translation (SMT) are often built on the basis of Maximum-likelihood Estimation (MLE), being one of the major limitations of this approach that the source sentence context in which phrases occur is completely ignored (Koehn et al., 2003).
E03-1076
The first of these models, that of Marcu and Wong (2002), was found by Koehn, et al.(2003), to produce translations not quite as good as their method.
E03-1076
The Pharaoh phrase-based decoder (Koehn 2004b) was used for decoding.
W04-3250
Minimum Error Rate Training for Statistical Machine Translation, In Proceedings of the 41th Annual Meeting of the Association for Computation Linguistics, Sapporo Kishore Papineni, Salim Roukos, Todd Ward, and Wei-Jing Zhu, 2002.
P02-1040
The most widely known are the Word Error Rate (WER), the Position independent word Error Rate (PER), the NIST score (Doddington, 2002) and, especially in recent years, the BLEU score (Papineni et al., 2002) and the Translation Error Rate (TER) (Snover et al., 2005).
P02-1040
The compound splitting was based on (Koehn and Knight, 2003) and was applied on the lowercased source sentences.
E03-1076
P. Koehn, 2004a, Statistical Significance Tests for Machine Translation Evaluation, in Proceedings of EMNLP.
W04-3250
Nowadays, statistical machine translation is mainly based on phrases (Koehn et al., 2003).
E03-1076
Niessen and Ney, 2004).
C04-1045
(Koehn, 2004a)) and introduces a feature in the following form: ?hmap:S?Tm (?ck, ?fk) = logp( ?fSk |?cTk ) (4) The conditional probability of ?fSk, i.e. the phrase ?fk restricted to factors S, given ?cTk, i.e. the phrase ?ck restricted to factors T is estimated from relative frequencies: p( ?fSk |?cTk ) = N( ?fS,?cT)/N(?cT) where N( ?fS,?cT) denotes the number of co-occurrences of a phrase pair ( ?fS,?cT) that are consistent with the word alignment.
W04-3250
Moore Chris Quirk Microsoft Research Redmond, WA 98052, USA {bobmoore,chrisq}@microsoft.com Abstract Attempts to estimate phrase translation probablities for statistical machine translation using iteratively-trained models have repeatedly failed to produce translations as good as those obtained by estimating phrase translation probablities from surface statistics of bilingual word alignments as described by Koehn, et al.(2003). We propose a new iteratively-trained phrase translation model that produces translations of quality equal to or better than those produced by Koehn, et al.?s model.
E03-1076
The backoff model, a slightly modified version of the method proposed by Yang and Kirchhoff (2006),1 does significantly better than the baseline (p <.05).
E06-1006
Yang et al.(2006) adopted Thayer?s model (1989) to classify music emotions.
E06-1006
Feature weight tuning was carried out using minimum error rate training, maximizing BLEU scores on a held-out development set (Och, 2003).
J03-1002 P03-1021
Modern phrasal SMT systems such as (Koehn et al., 2003) derive much of their power from being able to memorize and use long phrases.
E03-1076
Popovi, Maja and Hermann Ney, 2004.
C04-1045
Phrase-based statistical machine translation (Koehn et al.2003) has emerged as the dominant paradigm in machine translation research.
E03-1076
similar to Chiang (2005), in which FBIS corpus is 
P05-1033
Statistical Phrase-based Translation, In Proceedings of HLT-NAACL, Edmonton, Canada Franz Josef Och, 2003.
J03-1002 P03-1021
Goldwater and McClosky (2005) use morphological analysis on Czech text to get improvements in Czech to English SMT.
H05-1085
Data sets consisting of truncatedformswerealsogenerated; usingalengthlimit of 6, which Goldwater and McClosky (2005) experimentally determined to be optimal for translation performance.
H05-1085
Och (2003) introduced minimum error rate training (MERT), a technique for optimizing log-linear modelparametersrelativetoameasureoftranslation quality.
J03-1002 P03-1021
{1,...,#NT()} ??{1,...,#NT()} oneto-one mapping from nonterminal tokens in  to nonterminal tokens in  ??w ??[0,?? : nonnegative real-valued weight Chiang (2005) uses a single nonterminal category, Galley et al.(2004) use syntactic constituents for the PSCFG nonterminal set, and Zollmann and Venugopal (2006) take advantage of CCG (CombinatorialCategoricalGrammar)(Steedman, 1999)inspired?slash?and?plus?categories,focusingontarget (rather than source side) categories to generate well formed translations.
N06-2051 P05-1033
Proceedings 1999 Joint SIGDAT Conference on EMNLP and VLC Peter F.Brown, et al.1992. Class-Based n-gram Model of Natural Language.
J92-4003
The factored translation model combines features in a log-linear fashion (Och, 2003).
J03-1002 P03-1021
The feature weights i are trained in concert with the LM weight via minimum error rate (MER) training (Och, 2003).
J03-1002 P03-1021
For tractability, we followed standard practice with this technique and considered only monotonic alignments when decoding (Zens and Ney, 2004).
C04-1045
David Chiang. 2005. A hierarchical phrase-based mod-
P05-1033
Viewed at a very high level, statistical machine translationinvolvesfourphases: languageandtranslation model training, parameter tuning, decoding, and evaluation (Lopez, 2007; Koehn et al., 2003).
E03-1076
The phrases in the translations were located using techniques from phrase-based statistical machine translation which extract phrase pairsfromwordalignments(Koehnetal., 2003; Och and Ney, 2004).
C04-1045 E03-1076 W04-3250
Goldwater and McClosky (2005) show improvements in a Czech to English word-based translation system when inflectional endings are simplified or removed entirely.
H05-1085
P.F. Brown, V.J. Della Pietra, P.V. deSouza, J.C. Lai, and R.L. Mercer. 1992. Class-Based n-gram Models of Natural Language. Computational Linguistics,
J92-4003
Popovic and Ney (2004) investigate improving translation qual2This disambiguator has about 94% accuracy.
C04-1045
To avoid this pitfall, Talbot and Osborne (2006) use a datadriven approach to cluster source-language morphological variants that are meaningless in the target language, and Yang and Kirchhoff (2006) propose the use of a backoff model that uses morphologically reduced forms only when the translation of the surface form is unavailable.
E06-1006 P06-1122
It is an extension of Pharaoh (Koehn et al., 2003), and supports factor training and decoding.
E03-1076
translation Hierarchical systems (Chiang, 2005) induce a context-free grammar with one non-terminal directly from the parallel corpus, with the advantage of not requiring any additional knowledge source or tools, such as a treebank or a parser.
P05-1033
To summarize, we provided: ??sentence-aligned training corpora ??development and dev-test sets ??language models trained for each language ??an open source decoder for phrase-based SMT called Moses (Koehn et al., 2006), which replaces the Pharaoh decoder (Koehn, 2004) ??a training script to build models for Moses Theperformanceofthisbaselinesystemissimilar to the best submissions in last year?s shared task.
W04-3250
We employ the phrase-based SMT framework (Koehn et al., 2003), and use the Moses toolkit (Koehn et al., 2007), and the SRILM language modelling toolkit (Stolcke, 2002), and evaluate our decoded translations using the BLEU measure (Papineni et al., 2002), using a single reference translation.
E03-1076 P02-1040
(Popovic and Ney, 2004)) or machine translation quality (Nieen and Ney (2001), Koehn and Knight (2003), Zollmann et al.(2006), among others, for various languages; Goldwater and McClosky (2005), Bojar et al.(2006) and Talbot and Osborne (2006) for Czech), however, they focus on translating from the highly inflectional language.
C04-1045 E03-1076 H05-1085 N06-2051 P06-1122
Even the 3 A demo of the parser can be found at http://lfgdemo.computing.dcu.ie/lfgparser.html creators of BLEU point out that it may not correlate particularly well with human judgment at the sentence level (Papineni et al., 2002).
P02-1040
Factored translation with source words determining target words and CCG supertags For our experiments we used the following features: the translation probabilities Pr(sFs1 |tFt1 ) and Pr(tFt1 |sFs1 ),thelexicalweights(Koehnetal.,2003) lex(sFs1 |tFt1 ) and lex(tFt1 |sFs1 ), and a phrase penalty e, which allows the model to learn a preference for longer or shorter phrases.
E03-1076
Ney. 2004.
C04-1045 C04-1045
The most widely used are Word Error Rate (WER), Position independent word Error Rate (PER), the BLEU score (Papineni et al., 2002) and the NIST score (Doddington, 2002).
P02-1040
It also contains tools for tuning these models using minimum error rate training (Och 2003) and evaluating the resulting translations using the BLEU score (Papineni et al.2002). Moses uses standard external tools for some of the tasks to avoid duplication, such as GIZA++ (Och and Ney 2003) for word alignments and SRILM for language modeling.
J03-1002 P02-1040 P03-1021
Research Class-based LMs (Brown et al., 1992) or factored LMs (Bilmes and Kirchhoff, 2003) are very similar to our T+C scenario.
J92-4003 N03-2002
Yet this approach loses the advantage of context-sensitive lexical selection: the word translation model depends only on the word classes to subcategorize for translations, which leads to less accurate lexical choice in practice (Zens & Ney, 2004).
C04-1045
Different backoff paths are possible, and it would be interesting but prohibitively slow to apply a strategy similar to generalised parallel backoff (Bilmes and Kirchhoff, 2003) which is used in factored language models.
N03-2002
The weighting parameters of these features were optimized in terms of BLEU by the approach of minimum error rate training (Och, 2003).
J03-1002 P03-1021
They are generated from the training corpus via the ?diag-and??method (Koehn et al., 2003) and smoothed using Kneser-Ney smoothing (Foster et al., 2006), ??one or several n-gram language model(s) trained with the SRILM toolkit (Stolcke, 2002); in the baseline experiments reported here, we used a trigram model, ??a distortion model which assigns a penalty based on the number of source words which are skipped when generating a new target phrase, ??a word penalty.
E03-1076
1 in the alignment visualization style defined by Galley et al.(2004). Following the Data-Oriented Parsing inspired rule generalization technique proposed by Chiang (2005), one can now generalize each identified rule (initial or already partially generalized) N ?? f1...fm/e1 ...en for which there is an initial rule M ??fi ...fu/ej ...ev where 1 ??i < u ??m and 1 ??j < v ??n, to obtain a new rule N ?f1 ...fi??Mkfu+1 ...fm/e1 ...ej??Mkev+1 ...en where k is an index for the nonterminal M that indicates the one-to-one correspondence between the new M tokens on the two sides (it is not in the space of word indices like i,j,u,v,m,n).
P05-1033
BLEU (Papineni et al, 2002) was devised to provide automatic evaluation of MT output.
P02-1040
We use the following features in our induced English-to-English grammar:3 3Hiero also uses lexical weights (Koehn et al., 2003) in both 122 ??The joint probability of the two English hierarchical paraphrases, conditioned on the nonterminal symbol, as defined by this formula: p(e1, e2|x) = c(X ???e1, e2??summationtext e1prime, e2prime c(X ???e1prime, e2prime??
E03-1076
This suggests that the Goldwater and McClosky (2005) results are highly dependent on the kind of translation model and quantity of data.
H05-1085
The Moses system is an implementation of the phrase-based machine translation approach (Koehn et al., 2003).
E03-1076
Work The DTSC model is different from previous work based on dependency grammars by Eisner (2003), Lin (2004), Quirk et al.(2005), Ding et al.(2005) since they all deduce dependency structures on the target side.
P03-2041
The most widely used method for estimating these probabilities is that of Koehn, et al.(2003), in which phrase pairs are extracted from word-aligned bilingual sentence pairs, and their translation probabilities estimated heuristically from surface statistics of the extracted phrase pairs.
E03-1076
Over the last several years, various statistical syntaxbased models were proposed to extend traditional word/phrase based models in statistical machine translation (SMT) (Lin, 2004; Chiang, 2005; Ding et al., 2005; Quirk et al., 2005; Marcu et al., 2006; Liu et al., 2006).
P05-1033
We selected 580 short sentences of length at most 50 characters from the 2002 NIST MT Evaluation test set as our development corpus and used it to tune s by maximizing the BLEU score (Och, 2003), and used the 2005 NIST MT Evaluation test set as our test corpus.
J03-1002 P03-1021
Measure and MERT We evaluate our experiments using the (lowercase, tokenized) BLEU metric and estimate the empirical confidence using the bootstrapping method described in Koehn (2004b).6 We report the scores obtained on the test section with model parameters tuned using the tuning section for minimum error rate training (MERT, (Och, 2003)).
J03-1002 P03-1021 W04-3250
The features used in this study are: the length of t; a single-parameter distortion penalty on phrase reordering in a, as described in (Koehn et al., 2003); phrase translation model probabilities; and 4-gram language model probabilities logp(t), using Kneser-Ney smoothing as implemented in the SRILM toolkit.
E03-1076
Och and Ney (2004) gave a framework of alignment templates for this kind of models.
C04-1045
Mishne (2005), and Yang and Chen (2006) used emoticons as tags to train SVM (Cortes and Vapnik, 1995) classifiers at document or sentence level.
E06-1006
However, such models are typically applied over limited source sentence ranges to prevent errors introduced by these models and to maintain efficient decoding (Och and Ney, 2004).
C04-1045
In recent years, statistical machine translation have experienced a quantum leap in quality thanks to automatic evaluation (Papineni et al., 2002) and errorbased optimization (Och, 2003).
J03-1002 P02-1040 P03-1021
phrase-based decoding Chiang (2005; to appear 2007) introduced hierarchical phrase-based translation models, which are formally based on synchronous context-free grammars.
P05-1033
We used the GIZA++ SMT Toolkit1 (Och and Ney, 2003) to generate word alignments.
J03-1002 P03-1021
baseline System used for comparison was Pharaoh (Koehn et al., 2003; Koehn, 2004), which uses a beam search algorithm for decoding.
E03-1076 W04-3250
84 5.2 Machine translation on Europarl corpus We further tested our WDHMM on a phrase-based machine translation system to see whether our improvement on word alignment can also improve MT accuracy measured by BLEU score (Papineni et al., 2002).
P02-1040
The BLEU metric (Papineni et al., 2002) and the closely related NIST metric (Doddington, 2002) along with WER and PER 48 have been widely used by many machine translation researchers.
P02-1040
Compounds tend to lead to sparse data problems and splitting them has been shown to improve German-English translation (Koehn and Knight, 2003).
E03-1076
216 2.1 Grammar Induction Zollmann and Venugopal (2006) describe a process to generate a PSCFG given parallel sentence pairs ?f,e?? a parse tree pi for each e, the maximum a posteriori word alignment a over ?f,e?? and phrase pairs Phrases(a) identified by any alignment-driven phrase induction technique such as e.g.
N06-2051
The most commonly used MT evaluation metric in recent years has been IBM?s Bleu metric (Papineni et al., 2002).
P02-1040
2 Phrase-based Statistical MT Our baseline is a standard phrase-based SMT system (Koehn et al., 2003).
E03-1076
Table 1 shows the impact of increasing reordering window length (Koehn et al., 2003) on translation quality for the ?dev06??data.2 Increasing the reordering window past 2 has minimal impact on translation quality, implying that most of the reordering effects across Spanish and English are well modeled at the local or phrase level.
E03-1076
The feature weights for the overall translation models were trained using Och?s (2003) minimum-error-rate training procedure.
J03-1002 P03-1021
Moses is also able to integrate factored language models, such as those described in (Bilmes and Kirchhoff 2003) and (Axelrod 2006).
N03-2002
To evaluate the result of the translation, the BLEU metric (Papineni et al.2002) was used.
P02-1040
models (Och et al., 2004; Koehn et al., 2003; 
E03-1076 J03-1002 P03-1021
Kishore Papineni et al.2002. BLEU : A Method for Automatic Evaluation of Machine Translation.
P02-1040
Named Entity Transliteration and Discovery from Multilingual Comparable Corpora, COLING-ACL, Sidney, Australia Philipp Koehn, Franz Josef Och, and Daniel Marcu, 2003.
E03-1076 J03-1002 P03-1021
Chiang, 2005), some of measure words can be 
P05-1033
To generate phrase pairs from a parallel corpus, we use the "diag-and" phrase induction algorithm described in (Koehn et al, 2003), with symmetrized word alignments generated using IBM model 2 (Brown et al, 1993).
E03-1076
Another body of related work is the literature on word clustering in computational linguistics (Brown et al.1992; Finch 1993; Pereira, Tishby, and Lee 1993; Grefenstette 1994a) and document clustering in information retrieval (van Rijsbergen 1979; Willett 1988; Sparck-Jones 1991; Cutting et al.1992). In contrast to this earlier work, we cluster contexts or, equivalently, word tokens here, not words (or, more precisely, word types) or documents.
J92-4003
The word alignments were created with Giza++ (Och and Ney, 2003) applied to a parallel corpus containing 200,000 sentence pairs of the training data, plus sets of 4,007 sentence pairs created by pairing the test sentences with the reference translations, and the test sentences paired with each of the system translations.
J03-1002 P03-1021
As in phrasebased translation model estimation, ? also contains two lexical weights (Koehn et al., 2003), counters for number of target terminals generated.
E03-1076
We first generate a representation that contains both the lexical segments and the morphological features encoded for all possible segmenta1This is in a sense very similar to the more general problem of lexical redundancy addressed by Talbot and Osborne (2006) but our approach does not require the more sophisticated solution there.
P06-1122
Niessen and Ney (2004) have used morphological decomposition to improve alignment quality.
C04-1045
In order to verify whether these gains from WDHMM are statistically significant, we implemented paired bootstrap resampling method proposed by Koehn (2004b) to compute statistical significance of the above test results.
W04-3250
Whereas the use of linguistic knowledge for improving the performance of a statistical machine translation system is investigated in many publications for various language pairs (like for example (Nieen and Ney, 2000), (Goldwater and McClosky, 2005)), its use for the analysis of translation errors is still a rather unexplored area.
H05-1085
Each transduction rule null has a vector of variables null nullnull,?null nullnull . Each variable is associated with an input node nullnullnullnull . For each input node null, we keep a beam of derivations nullnullnullnull . Derivations are represented as a pair nullnull,nullnull where null is a transduction rule and nullnullnull null is a vector with one integer for each of the null variables in null . The interpretation is that the complete candidate can be constructed by recursively substituting for each 6 Like Chiang (2005) we only search for the yield of the most likely derivation, rather than the most likely yield.
P05-1033
Regarding the argmax search, we used the Pharaoh beam search decoder (Koehn, 2004), which naturally fits with the previous tools.
W04-3250
Here, we drop both dependencies in order to simplify to a jump width alignment probability distribution: p(aj |aj??1,xj??1,y) ?? braceleftbigg p(a j) j = 1 p(aj?aj)?? j > 1 (3) p(xj |aj1,xj??1,y) ?p(xj |yaj) (4) Furthermore, the treatment of the NULL word is the same as that presented in (Och and Ney, 2003).
J03-1002 P03-1021
We use the n-best generation scheme interleaved with  optimization as described in (Och, 2003).
J03-1002 P03-1021
Yang and Kirchhoff (2006) have recently documented minor BLEU improvement using factored LMs in singlefactored SMT to English.
E06-1006
Translation scores are reported using caseinsensitive BLEU (Papineni et al., 2002) with a single reference translation.
P02-1040
To further emphasize the importance of morphology in MT to Czech, we compare the standard BLEU (Papineni et al., 2002) of a baseline phrasebased translation with BLEU which disregards word forms (lemmatized MT output is compared to lemmatized reference translation).
P02-1040
In the first part, a word alignment was computed (using the GIZA++ toolkit (Och and Ney, 2003)).
J03-1002 P03-1021
??Initial phrase pairs are identified following the procedure typically employed in phrase based systems (Koehn et al., 2003; Och and Ney, 2004).
C04-1045 E03-1076 W04-3250
Oncetraininghastakenplace,minimumerrorrate training (Och, 2003) is used to tune the parameters i.
J03-1002 P03-1021
 ThePotentialandLimitationsofAutomatic SentenceExtractionforSummarization Chin-YewLinandEduardHovy UniversityofSouthernCalifornia/InformationSciencesInstitute 4676AdmiraltyWay MarinadelRey,CA90292,USA {cyl,hovy}@isi.edu   Abstract Inthispaperwepresentanempiricalstudyof thepotentialandlimitationofsentenceextraction in text summarization. Our results show that the single document generic summarizationtaskasdefinedinDUC2001needstobe carefullyrefocusedasreflectedinthelowinter-human agreement at 100-word 1 (0.40 score) and high upper bound at full text 2  (0.88) summaries. For 100-word summaries, theperformanceupperbound,0.65,achieved oracleextracts 3.Suchoracleextractsshowthe promise of sentence extraction algorithms; however, we first need to raise inter-human agreementtobeabletoachievethisperformance level. We show that compression is a promisingdirectionandthatthecompression ratioofsummariesaffectsaveragehumanand systemperformance. 1 Introduction Most automatic text summarization systems existing todayareextractionsystemsthatextractpartsoforiginal documents and output the results as summaries. Among them, sentence extraction is by far the most  1 Wecomputeunigramco-occurrencescoreofapairofmanual summaries, one as candidate summary and the other as reference. 2 Wecomputeunigramco-occurrencescoresofafulltextand itsmanualsummariesof100words.Thesescoresarethebest achievable using the unigram co-occurrence scoring metric sinceallpossiblewordsarecontainedinthefulltext.Three manualsummariesareused. 3 Oracle extracts are the best scoring extracts generated by exhaustive search of all possible sentence combinations of 1005words. popular (Edmundson 1969, Luhn 1969, Kupiec et al. 1995,Goldsteinetal.1999,HovyandLin1999).The majorityofsystemsparticipatinginthepastDocument Understanding Conference (DUC 2002), a large scale summarization evaluation effort sponsored by the US government, are extraction based. Although systems basedoninformationextraction(RadevandMcKeown 1998,Whiteetal.2001,McKeownetal.2002)anddiscourseanalysis(Marcu1999b,Strzalkowskietal.1999) alsoexist,wefocusourstudyonthepotentialandlimitationsofsentenceextractionsystemswiththehopethat ourresultswillfurtherprogressinmostoftheautomatic textsummarizationsystemsandevaluationsetup. TheevaluationresultsofthesingledocumentsummarizationtaskinDUC2001and2002(DUC2002,Paul& Liggett2002)indicatethatmostsystemsareasgoodas thebaselinelead-basedsystemandthathumansaresignificantlybetter,thoughnotbymuch.Thisleadstothe beliefthatlead-basedsummariesareasgoodaswecan get for single document summarization in the news genre, implying that the research community should investfutureeffortsinotherareas.Infact,averyshort summary of about 10 words (headline-like) task has replaced the single document 100-word summary task inDUC2003.Thegoalofthisstudyistorenewinterest in sentence extraction-based summarization and its evaluationby estimatingtheperformanceupperbound usingoracleextracts,andtohighlighttheimportanceof taking into account the compression ratio when we evaluateextractsorsummaries. Section 2 gives an overview of DUC relevant to this study.Section3introducesa recall-basedunigram cooccurrenceautomaticevaluationmetric.Section4presentstheexperimentaldesign.Section5showstheempirical results. Section 6 concludes this paper and discussesfuturedirections.  2 DocumentUnderstandingConference Fully automatic single-document summarization was one of two main tasks in the 2001 Document UnderstandingConference.Participantswererequiredtocreate a generic 100-word summary.There were 30 test setsinDUC2001andeachtestsetcontainedabout10 documents.Foreachdocument,onesummarywascreated manually as the ideal model summary at approximately 100 words.We will refer to this manual summary as H1. Two other manual summaries were alsocreatedataboutthatlength.Wewillrefertothese twoadditionalhumansummariesasH2  andH3.Inaddition,baselinesummarieswerecreatedautomaticallyby taking the first n sentences up to 100 words. We will referthisbaselineextractasB1. 3 UnigramCo-OccurrenceMetric Inarecentstudy(LinandHovy2003),weshowedthat therecall-basedunigramco-occurrenceautomaticscoringmetriccorrelatedhighlywithhumanevaluationand has high recall and precision in predicting statistical significanceofresultscomparingwithitshumancounterpart. The idea is to measure the content similarity betweenasystemextractandamanualsummaryusing simple n-gram overlap. A similar idea called IBM BLEU score has proved successful in automatic machinetranslationevaluation(Papinenietal.2001,NIST 2002).Forsummarization,wecanexpressthedegreeof contentoverlapintermsofn-grammatchesasthefollowingequation: )1( )( )( }{ }{       = UnitsModelCCgramn UnitsModelCCgramn match n gramnCount gramnCount C  Modelunitsaresegmentsof manual summaries.They are typically either sentences or elementary discourse unitsasdefinedbyMarcu(1999b).Count match (n-gram) is the maximum number of n-grams co-occurring in a systemextractandamodelunit.Count(n-gram)isthe number of n-grams in the model unit. Notice that the averagen-gramcoveragescore,C n,asshowninequation1,isarecall-basedmetric,sincethedenominatorof equation 1 is the sum total of the number of n-grams occurringinthemodelsummaryinsteadofthesystem summaryandonlyonemodelsummaryisusedforeach evaluation. In summary, the unigram co-occurrence statisticsweuseinthefollowingsectionsarebasedon thefollowingformula: )2(logexp),(         =  = j in nn CwjiNgram  Wherej i,iandjrangefrom1to4,andw n is1/(ji+1).Ngram(1,4)isaweightedvariablelengthn-gram match score similar to the IBM BLEU score; while Ngram(k,k),i.e.i=j=k,issimplytheaveragek-gram co-occurrencescoreC k .Inthisstudy,weseti=j=1, i.e.unigramco-occurrencescore. Withatestcollectionavailableandanautomaticscoring metric defined, we describe the experimental setup in thenextsection. 4 ExperimentalDesigns As stated in the introduction, we aim to find the performanceupperboundofasentenceextractionsystem andtheeffectofcompressionratioonitsperformance. We present our experimental designs to address these questionsinthefollowingsections. 4.1 Performance Upper Bound Estimation UsingOracleExtract Inordertoestimatethepotentialofsentenceextraction systems,itisimportanttoknowtheupperboundthatan ideal sentence extraction method might achieve and howfarthestate-of-the-artsystemsareawayfromthe bound. If the upper bound is close to state-of-the-art systems performance then we need to look for other summarizationmethodstoimproveperformance.Ifthe upper bound is much higher than any current systems canachieve,thenitisreasonabletoinvestmoreeffortin sentence extraction methods. The question is how to estimatetheperformanceupperbound.Oursolutionis tocastthisestimationproblemasanoptimizationproblem. We exhaustively generate all possible sentence combinationsthatsatisfygivenlengthconstraintsfora summary, for example, all the sentence combinations totaling 1005 words. We then compute the unigram co-occurrence score for each sentence combination, against the ideal. The best combinations are the ones withthehighestunigramco-occurrencescore.Wecall this sentence combination the oracle extract. Figure 1 showsanoracleextractfordocumentAP900424-0035. OneofitshumansummariesisshowninFigure2.The oracle extract covers almost all aspects of the human summaryexceptsentences5and6andpartofsentence 4.However,ifweallowtheautomaticextracttocontain morewords,forexample,150wordsshowninFigure3, the longeroracleextractthen covers everythinginthe humansummary.Thisindicatesthatlowercompression can boost system performance. The ultimate effect of compressioncanbecomputedusingthefulltextasthe oracleextract,sincethefulltextshouldcontaineverything included in the human summary. That situation provides the best achievable unigram co-occurrence score.Anearoptimalscorealsoconfirmsthevalidityof usingtheunigramco-occurrencescoringmethodasan automaticevaluationmethod.  4.2 Compression Ratio and Its Effect on System Performance Oneimportantfactorthat affectsthe averageperformance of sentence extraction system is the number of sentences contained in the original documents. This factorisoftenoverlookedandhasneverbeenaddressed systematically. For example, if a document contains onlyonesentencethenthisdocumentwillnotbeuseful indifferentiatingsummarizationsystemperformance there is only one choice. However, for a document of 100sentencesandassumingeachsentenceis20words long, there are C(100,5) = 75,287,520 different 100wordextracts.Thishugesearchspacelowersthechance of agreement between humans on what constitutes a good summary. It also makes system and human performance approach average since it is more likely to includesomegoodsentencesbutnotallofthem.EmpiricalresultsshowninSection5confirmthisandthat leadsustothequestionofhowtoconstructacorpusto evaluatesummarizationsystems.Wediscussthisissue intheconclusionsection. 4.3 Inter-HumanAgreementandItsEffecton SystemPerformance In this section we study how inter-human agreement affects system performance. Lin and Hovy (2002) reportedthat, comparedtoa manually createdideal,humansscoredabout0.40inaveragecoveragescoreand the best system scored about 0.35. According to these numbers,wemightassumethathumanscannotagreeto eachotheronwhatisimportantandthebestsystemis almostasgoodashumans.Ifthisistruethenestimating anupperboundusingoracleextractsismeaningless.No matterhowhightheestimatedupperboundsmaybe,we probablywouldneverbeabletoachievethatperformance due to lack of agreement between humans: the oracle approximating one human would fail miserably withanother.Thereforewesetupexperimentstoinvestigatethefollowing: 1. Whatisthedistributionofinter-humanagreement? Figure3.A150-wordoracleextractfordocumentAP900424-0035. Figure 2. A manual summary for document AP900424-0035. Figure1.A100-wordoracleextractfordocumentAP900424-0035. <DOC> <DOCNO>AP900424-0035</DOCNO> <DATE>04/24/90</DATE> <HEADLINE> <SHSNTNO="1">ElizabethTaylorinIntensiveCareUnit</S> <SHSNTNO="2">ByJEFFWILSON</S> <SHSNTNO="3">AssociatedPressWriter</S> <SHSNTNO="4">SANTAMONICA,Calif.(AP)</S> </HEADLINE> <TEXT> <SSNTNO="1">AseriouslyillElizabethTaylorbattledpneumoniaather hospital,herbreathingassistedbyaventilator,doctorssay.</S> <SSNTNO="2">HospitalofficialsdescribedherconditionlateMonday asstabilizingafteralungbiopsytodeterminethecauseofthepneumonia.</S> <SSNTNO="3">Analysisofthetissuesamplewasexpectedtotakeuntil Thursday,saidherspokeswoman,ChenSam.</S> <SSNTNO="9">Anotherspokewomanfortheactress,LisaDelFavaro, saidMissTaylor'sfamilywasatherbedside.</S> <SSNTNO="13">``Itisserious,buttheyarereallypleasedwithher progress.</S> <SSNTNO="22">Duringanearlyfatalboutwithpneumoniain1961, MissTaylorunderwentatracheotomy,anincisionintoherwindpipeto helpherbreathe.</S> </TEXT> </DOC> <DOC> <TEXT> <SSNTNO="1">ElizabethTaylorbattledpneumoniaatherhospital, assistedbyaventilator,doctorssay.</S> <SSNTNO="2">HospitalofficialsdescribedherconditionlateMonday asstabilizingafteralungbiopsytodeterminethecauseofthepneumonia.</S> <SSNTNO="3">AnalysisofthetissuesamplewasexpectedtobecompletebyThursday.</S> <SSNTNO="4">Ms.Sam,spokeswomansaid"itisserious,buttheyare reallypleasedwithherprogress.</S> <SSNTNO="5">She'snotwell.</S> <SSNTNO="6">She'snotonherdeathbedoranything.</S> <SSNTNO="7">Anotherspokeswoman,LisaDelFavaro,saidMiss Taylor'sfamilywasatherbedside.</S> <SSNTNO="8">Duringanearlyfatalboutwithpneumoniain1961,Miss Taylorunderwentatracheotomytohelpherbreathe.</S> </TEXT> </DOC> <DOC> <DOCNO>AP900424-0035</DOCNO> <DATE>04/24/90</DATE> <HEADLINE> <SHSNTNO="1">ElizabethTaylorinIntensiveCareUnit</S> <SHSNTNO="2">ByJEFFWILSON</S> <SHSNTNO="3">AssociatedPressWriter</S> <SHSNTNO="4">SANTAMONICA,Calif.(AP)</S> </HEADLINE> <TEXT> <SSNTNO="1">AseriouslyillElizabethTaylorbattledpneumoniaather hospital,herbreathingassistedbyaventilator,doctorssay.</S> <SSNTNO="2">HospitalofficialsdescribedherconditionlateMonday asstabilizingafteralungbiopsytodeterminethecauseofthepneumonia.</S> <SSNTNO="3">Analysisofthetissuesamplewasexpectedtotakeuntil Thursday,saidherspokeswoman,ChenSam.</S> <SSNTNO="4">The58-year-oldactress,whowonbest-actressOscars for``Butterfield8''and``Who'sAfraidofVirginiaWoolf,''hasbeen hospitalizedmorethantwoweeks.</S> <SSNTNO="8">Herconditionispresentlystabilizingandherphysicians arepleasedwithherprogress.''</S> <SSNTNO="9">Anotherspokewomanfortheactress,LisaDelFavaro, saidMissTaylor'sfamilywasatherbedside.</S> <SSNTNO="13">``Itisserious,buttheyarereallypleasedwithher progress.</S> <SSNTNO="14">She'snotwell.</S> <SSNTNO="15">She'snotonherdeathbedoranything,''Ms.Samsaid lateMonday.</S> <SSNTNO="22">Duringanearlyfatalboutwithpneumoniain1961, MissTaylorunderwentatracheotomy,anincisionintoherwindpipeto helpherbreathe.</S> </TEXT> </DOC>  2. Howdoesastate-of-the-artsystemdifferfrom averagehumanperformanceatdifferentinterhumanagreementlevels? We present our results in the next section using 303 newspaperarticlesfromtheDUC2001singledocument summarizationtask.Besidestheoriginaldocuments,we also have three human summaries, one lead summary (B1), and one automatic summary from one top performingsystem(T)foreachdocument. 5 Results In order to determine the empirical upper and lower bounds of inter-human agreement, we first ran crosshumanevaluationusingunigramco-occurrencescoring through six human summary pairs, i.e. (H1,H2), (H1,H3),(H2,H1),(H2,H3),(H3,H1),and(H3,H2).For a summary pair (X,Y), we used X as the model summaryandYasthesystemsummary.Figure4showsthe distributionsoffourdifferentscenarios.TheMaxHdistribution picks the best inter-human agreement scores foreachdocument,theMinHdistributiontheminimum one,theMedHdistributionthemedian,andthe AvgH distributiontheaverage.Theaverageofthebestinterhuman agreement and the average of average interhumanagreementdifferbyabout10percentinunigram co-occurrencescoreand18percentbetweenMaxHand MinH. These big differences might come from two sources. The first one is the limitation of the unigram 0 10 20 30 40 50 60 70 80 0.00 0.05 0.10 0.15 0.20 0.25 0.30 0.35 0.40 0.45 0.50 0.55 0.60 0.65 0.70 0.75 0.80 0.85 0.90 0.95 1.00 UnigramCo-occurrenceScores #  of  I n st an ce s AvgH MaxH MedH MinH AverageMAX=0.50 AverageAVG=0.40 AverageMED=0.39 AverageMIN=0.32 Figure 4. DUC 2001 single document interhuman unigram co-occurrence score distributions for maximum, minimum, average, and median. 0.00 0.10 0.20 0.30 0.40 0.50 0.60 0.70 0.80 0.90 1.00 D 4 1.
P02-1040
To model p(t,a|s), we use a standard loglinear approach: p(t,a|s) ??exp bracketleftBiggsummationdisplay i ifi(s,t,a) bracketrightBigg (1) where each fi(s,t,a) is a feature function, and weights i are set using Och?s algorithm (Och, 2003) to maximize the system?s BLEU score (Papineni et al., 2001) on a development corpus.
J03-1002 P03-1021
To optimize the system towards a maximal BLEU or NIST score, we use Minimum Error Rate (MER) Training as described in (Och, 2003).
J03-1002 P03-1021
Also, several other tree-based decoding algorithms introduced by Eisner (2003), Quirk et al.(2005) and Liu et al.(2006) can be classified as the chart-style parsing algorithm too.
P03-2041
Recently 1www.nist.gov/speech/tests/mt/mt06eval official results.html there have been a few syntax-based models that show performance comparable to the phrase-based models (Chiang, 2005; Marcu et al., 2006).
P05-1033
We wanted to test the following hypotheses: ??Translation models based on lemmas will improve translation quality (Popovi and Ney, 2004) ??Decompounding German nominal compounds will improve translation quality (Koehn and Knight, 2003) ??Re-ordering models based on word forms and parts-of-speech will improve translation quality (Zens and Ney, 2006).
C04-1045 E03-1076
Operationally, Moses performs a stack-based beam search very similar to Pharaoh (Koehn, 2004a).
W04-3250
are combined in a log-linear model to obtainthescoreforthetranslationeforaninputsentence f: score(e,f) = exp summationdisplay i i hi(e,f) (1) The weights of the components i are set by a discriminative training method on held-out development data (Och, 2003).
J03-1002 P03-1021
2007, URL: http://www.statmt.org/moses/ . Niessen, Sonja and Hermann Ney, 2004.
C04-1045
Our decoder is a reimplementation in Perl of the algorithm used by the Pharaoh decoder as described by Koehn (2003).2 The data we used comes from an English-French bilingual corpus of Canadian Hansards parliamentary proceedings supplied for the bilingual word alignment workshop held at HLT-NAACL 2003 (Mihalcea and Pedersen, 2003).
E03-1076
Some published work has shown that applying morphological analysis improved the quality of SMT (Lee, 2004; Goldwater and McClosky, 2005).
H05-1085
A ?backoff??set, corresponding approximately to the method of Yang and Kirchhoff (2006) was generated by lemmatizing only unknown words.
E06-1006
A universal estimation method is the bootstrap estimate: The core idea is to create replications of R by random sampling from the data set (Bisani and Ney, 2004).
C04-1045
We evaluated the translation quality of the system using the BLEU metric (Papineni et al., 2002).
P02-1040
We compared our system to Pharaoh, a leading phrasal SMT decoder (Koehn et al., 2003), and our treelet system.
E03-1076
Model weights were trained separately for all 3 systems using minimum error rate training to maximize BLEU (Och, 2003) on the development set (dev).
J03-1002 P03-1021
Bleu is fast and easy to run, and it can be used as a target function in parameter optimization training procedures that are commonly used in state-of-the-art statistical MT systems (Och, 2003).
J03-1002 P03-1021
Och, 2003, Minimum Error Rate Training in Statistical Machine Translation.
J03-1002 P03-1021
Moses has shown that it achieves results comparable to the most competitive and widely used statistical machine translation systems in translation quality and run-time (Shen et al.2006). It features all the capabilities of the closed sourced Pharaoh decoder (Koehn 2004).
W04-3250
Grammars for SMT Probabilistic synchronous context-free grammars (PSCFGs) are defined by a source terminal set (source vocabulary) TS, a target terminal set (target vocabulary)TT,asharednonterminalsetN andproduction rules of the form X ????,??w?? where following (Chiang, 2005) ??X ??N is a nonterminal ?? ??(N ?TS)??: sequence of source nonterminals and terminals ?? ??(N ?TT)??: sequence of target nonterminals and terminals ??the count #NT() of nonterminal tokens in  is equalto thecount #NT() ofnonterminal tokens in , ????
P05-1033
While xRS 2 Marcu et al.(2006) and Zollmann et al.(2006) recognize this problem and attempt to alleviate it by grafting surface phrases into constituency trees by various methods.
N06-2051
Philipp Koehn, Franz J. Och, and Daniel Marcu. 2003. 
E03-1076 J03-1002 P03-1021
??Bleu (Papineni et al., 2002)?Bleu is currently the de facto standard in machine translation evaluation.
P02-1040
Evaluation The BLEU score (Papineni et al., 2002) was defined to measure overlap between a hypothesized translation and a set of human references.
P02-1040
159 2.1 Baseline System The baseline system is a phrase-based SMT system (Koehn et al., 2003), built almost entirely using freely available components.
E03-1076
Och showed thatsystemperformanceisbestwhenparametersare optimizedusingthesameobjectivefunctionthatwill be used for evaluation; BLEU (Papineni et al., 2002) remains common for both purposes and is often retained for parameter optimization even when alternative evaluation measures are used, e.g., (Banerjee and Lavie, 2005; Snover et al., 2006).
P02-1040
As in (Koehn, 2004), the decoder takes a record of any recombined hypothesis, allowing for a rigorous N-best generation.
W04-3250
Again one perhaps can use methods similar to those suggested by Talbot and Osborne (2006).
P06-1122
3As in Brown et al. (1992), we limit the clustering algorithm
J92-4003
Approaches Koehn, et al.?s (2003) method of estimating phrasetranslation probabilities is very simple.
E03-1076
Word alignment is an important step of most modern approaches to statistical machine translation (Koehn et al., 2003).
E03-1076
Significance testing was done using bootstrap resampling (Koehn, 2004).
W04-3250
The comparison phrasal system was constructed using the same GIZA++ alignments and the heuristic combination described in (Och & Ney, 2003).
J03-1002 P03-1021
An early attempt at greater generality in a purely phrasal setting was the alignment template approach (Och & Ney 2004); newer approaches include formally syntactic (Chiang 2005), and linguistically syntactic approaches (Quirk et al.2005), (Huang et al.2006). In the next section, we examine these representative approaches to the reordering problem.
C04-1045 P05-1033
Och. 2003.
J03-1002 J03-1002 J03-1002 J03-1002 P03-1021 P03-1021 P03-1021 P03-1021
For example, the following two rules were extracted from the Spanish ??English segment of the Europarl corpus (Koehn, 2003): X ???la X1 de X2,X2 ?s X1??(2) X ???el X1 verde,the green X1??(3) Rule (2) expresses the fact that possessors can be expressed prior to the possessed object in English but must follow in Spanish.
E03-1076
Yang and Kirchhoff (2006) use phrase-based backoff models to translate words that are unknown to the decoder, by morphologically decomposing the unknown source word.
E06-1006
The optimal weights for the different columns can then be assigned with the help of minimum error rate training (Och, 2003).
J03-1002 P03-1021
the Bleu score (Papineni et al., 2002) changes be-
P02-1040
A variety of solutions have been proposed: Niessen and Ney (2001) use of morphological information to improve word reordering before training and after decoding.
W01-1407
Some efforts have been made e.g. to integrate more information about the words in the form of Part Of Speech tags (Popovic and Ney, 2005), using additional information about stems and suffixes (Popovic and Ney, 2004) or to reduce the morphological variability of the words (de Gispert, 2006).
C04-1045
As an alternative option to our verb-modifier experiments, structured language models (Chelba and Jelinek, 1998) might be considered to improve clause coherence, until full-featured syntax-based MT models (Yamada and Knight (2002), Eisner (2003), Chiang (2005) among many others) are tested when translating to morphologically rich languages.
P02-1039 P03-2041 P05-1033 P98-1035
Koehn and Knight, 2003).
E03-1076
We now describe the identification and estimation of PSCFG rules from parallel sentence aligned corpora under the framework proposed by Zollmann and Venugopal (2006).
N06-2051
In all experiments, word alignment was obtained using the grow-diag-final heuristic for symmetrizing GIZA++ (Och and Ney, 2003) alignments.
J03-1002 P03-1021
To address these concerns, hierarchically structured models as in Chiang (2005) define weighted transduction rules, interpretable as components of a probabilistic synchronous grammar (Aho and Ullman, 1969) that represent translation and reordering operations.
P05-1033
As Chiang (2005) and Koehn et al.(2003) note, purely lexical ?phrase-based??translation models suffer from sparse data effects when translating conceptual elements that span or skip across several source language words.
E03-1076 P05-1033
But it has been found that phrases longer than three words have little improvement in the performance (Koehn, 2003).
E03-1076
(Och and Ney, 2004).
C04-1045
Weights on the loglinear features are set using Och's algorithm (Och, 2003) to maximize the system's BLEU score on a development corpus.
J03-1002 P03-1021
To derive the joint counts c(?s,?t) from which p(?s|?t) and p(?t|?s) are estimated, we use the phrase induction algorithm described in (Koehn et al., 2003), with symmetrized word alignments generated using IBM model 2 (Brown et al., 1993).
E03-1076
all contributed to increased system?s complexity, and, as a result, time limitations prevented us from performing minimum-error-rate training (MERT) (Och, 2003) for ucb3, ucb4 and ucb5.
J03-1002 P03-1021
References Koehn, Philipp and Kevin Knight, 2003.
E03-1076
The overall translation model score consists of a weighted sum of the following eight aggregated feature values for each translation hypothesis: ??the sum of the log probabilities of each source phrase in the hypothesis given the corresponding target phrase, computed either by our model or the standard model, ??the sum of the log probabilities of each target phrase in the hypothesis given the corresponding source phrase, computed either by our model or the standard model, ??the sum of lexical scores for each source phrase given the corresponding target phrase, ??the sum of lexical scores for each target phrase given the corresponding source phrase, ??the log of the target language model probability for the sequence of target phrases in the hypothesis, ??the total number of words in the target phrases in the hypothesis, ??the total number of source/target phrase pairs composing the hypothesis, ??the distortion penalty as implemented in the Pharaoh decoder (Koehn, 2003).
E03-1076
These models also suffer from a large search space when decoding with an integrated language model, which can lead to search errors (Chiang, 2005).
P05-1033
In this work, we present a mixture extension of the well-known HMM alignment model first proposed in (Vogel and others, 1996) and refined in (Och and Ney, 2003).
J03-1002 P03-1021
73 2.2.4 Minimum Error Rate Training A good way of training is to minimize empirical top-1 error on training data (Och, 2003).
J03-1002 P03-1021
In the experiment, only the first 500 sentences were used to train the log-linear model weight vector, where minimum error rate (MER) training was used (Och, 2003).
J03-1002 P03-1021
