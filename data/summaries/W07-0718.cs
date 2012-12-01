Raw parallel data need to be preprocessed in the modern phrase-based SMT before they are aligned by alignment algorithms, one of which is the wellknown tool, GIZA++ (Och and Ney, 2003), for training IBM models (1-4).
J03-1002
Franz J. Och and Hermann Ney. 2004. The alignment 
J04-4002
Portage is a statistical phrase-based SMT system similar to Pharaoh (Koehn et al, 2003).
N03-1017
Others try to accommodate both syntactic and lexical differences between the candidate translation and the reference, like CDER (Leusch et al., 2006), which employs a version of edit distance for word substitution and reordering; or METEOR (Banerjee and Lavie, 2005), which uses stemming and WordNet synonymy.
W05-0909
The alignment template approach (Och & Ney, 2004) uses word classes rather than lexical items to model phrase translation.
J04-4002
Although widely popular thanks to their speed and efficiency, both BLEU and NIST have been criticized for inadequate accuracy of evaluation at the segment level (Callison-Burch et al., 2006).
E06-1032
2 Phrase-based Statistical MT Our baseline is a standard phrase-based SMT system (Koehn et al., 2003).
N03-1017
The first of these models, that of Marcu and Wong (2002), was found by Koehn, et al.(2003), to produce translations not quite as good as their method.
N03-1017
While these are based on a relatively few number of items, and while we have not performed any tests to determine whether the differences in ? are statistically significant, the results 7The Czech-English conditions were excluded since there were so few systems 146 are nevertheless interesting, since three metrics have higher correlation than Bleu: ??Semantic role overlap (Gimenez and M`arquez, 2007), which makes its debut in the proceedings of this workshop ??ParaEval measuring recall (Zhou et al., 2006), which has a model of allowable variation in translation that uses automatically generated paraphrases (Callison-Burch, 2007) ??Meteor (Banerjee and Lavie, 2005) which also allows variation by introducing synonyms and by flexibly matches words using stemming.
W05-0909 W06-1610
Koehn. 2006.
W06-3114
Even if human judges have explicit evaluation guidelines at hand, they still find it difficult to assign a numerical value which represents the quality of the translation for many sentences (Koehn and Monz, 2006).
W06-3114
Moore Chris Quirk Microsoft Research Redmond, WA 98052, USA {bobmoore,chrisq}@microsoft.com Abstract Attempts to estimate phrase translation probablities for statistical machine translation using iteratively-trained models have repeatedly failed to produce translations as good as those obtained by estimating phrase translation probablities from surface statistics of bilingual word alignments as described by Koehn, et al.(2003). We propose a new iteratively-trained phrase translation model that produces translations of quality equal to or better than those produced by Koehn, et al.?s model.
N03-1017
Following Bannard and Callison-Burch (2005), we first identify English-to-F correspondences, then map from English to English by following translation units from English to F and back.
P05-1074
Its flexible matching was extended to French, Spanish, German and Czech for this workshop (Lavie and Agarwal, 2007).
W07-0734
Modern phrasal SMT systems such as (Koehn et al., 2003) derive much of their power from being able to memorize and use long phrases.
N03-1017
Intra-annotator agreement We measured pairwise agreement among annotators usingthekappacoefficient(K)whichiswidelyused in computational linguistics for measuring agreement in category judgments (Carletta, 1996).
J96-2004
Phrase-based statistical machine translation (Koehn et al.2003) has emerged as the dominant paradigm in machine translation research.
N03-1017
Statistical Phrase-based Translation, In Proceedings of HLT-NAACL, Edmonton, Canada Franz Josef Och, 2003.
J03-1002
Och (2003) introduced minimum error rate training (MERT), a technique for optimizing log-linear modelparametersrelativetoameasureoftranslation quality.
J03-1002
Note that using stems and their synonyms as used in METEOR (Banerjee and Lavie, 2005) could also be considered for word similarity.
W05-0909
Callison-Burch et al.(2006) extract phrase-level paraphrases by mapping input phrases into a phrase table and then mapping back to the source language.
E06-1032
The factored translation model combines features in a log-linear fashion (Och, 2003).
J03-1002
Viewed at a very high level, statistical machine translationinvolvesfourphases: languageandtranslation model training, parameter tuning, decoding, and evaluation (Lopez, 2007; Koehn et al., 2003).
N03-1017
The phrases in the translations were located using techniques from phrase-based statistical machine translation which extract phrase pairsfromwordalignments(Koehnetal., 2003; Och and Ney, 2004).
J04-4002 N03-1017
T. Koo and M. Collins. 2005. Hidden-Variable Models for Discriminative Reranking. In Proceedings of HLTEMNLP, pages 507514.
J05-1003
Koehn and Monz (2006) also include a human evaluation, in which this system ranked noticeably higher than one might have predicted from its BLEU score.
W06-3114
Models Inspired by work on factored language models, Koehn et al.(2006) extend phrase-based models to incorporate multiple levels of linguistic knowledge as factors.
W06-3114
However, recent work suggests that Bleu?s correlation with human judgments may not be as strong as previously thought (Callison-Burch et al., 2006).
E06-1032
Still, a confidence range for BLEU can be estimated by bootstrapping (Och, 2003; Zhang and Vogel, 2004).
J03-1002 J04-4002
Philipp Koehn, Franz J. Och, and Daniel Marcu. 2003. 
J03-1002 N03-1017
3 3 Related work 3.1 String-based metrics The insensitivity of BLEU and NIST to perfectly legitimate syntactic and lexical variation has been raised, among others, in Callison-Burch et al.(2006), but the criticism is widespread.
E06-1032
To summarize, we provided: ??sentence-aligned training corpora ??development and dev-test sets ??language models trained for each language ??an open source decoder for phrase-based SMT called Moses (Koehn et al., 2006), which replaces the Pharaoh decoder (Koehn, 2004) ??a training script to build models for Moses Theperformanceofthisbaselinesystemissimilar to the best submissions in last year?s shared task.
W06-3114
We employ the phrase-based SMT framework (Koehn et al., 2003), and use the Moses toolkit (Koehn et al., 2007), and the SRILM language modelling toolkit (Stolcke, 2002), and evaluate our decoded translations using the BLEU measure (Papineni et al., 2002), using a single reference translation.
N03-1017 W07-0733
Factored translation with source words determining target words and CCG supertags For our experiments we used the following features: the translation probabilities Pr(sFs1 |tFt1 ) and Pr(tFt1 |sFs1 ),thelexicalweights(Koehnetal.,2003) lex(sFs1 |tFt1 ) and lex(tFt1 |sFs1 ), and a phrase penalty e, which allows the model to learn a preference for longer or shorter phrases.
N03-1017
The overall translation model score consists of a weighted sum of the following eight aggregated feature values for each translation hypothesis: ??the sum of the log probabilities of each source phrase in the hypothesis given the corresponding target phrase, computed either by our model or the standard model, ??the sum of the log probabilities of each target phrase in the hypothesis given the corresponding source phrase, computed either by our model or the standard model, ??the sum of lexical scores for each source phrase given the corresponding target phrase, ??the sum of lexical scores for each target phrase given the corresponding source phrase, ??the log of the target language model probability for the sequence of target phrases in the hypothesis, ??the total number of words in the target phrases in the hypothesis, ??the total number of source/target phrase pairs composing the hypothesis, ??the distortion penalty as implemented in the Pharaoh decoder (Koehn, 2003).
N03-1017
It also contains tools for tuning these models using minimum error rate training (Och 2003) and evaluating the resulting translations using the BLEU score (Papineni et al.2002). Moses uses standard external tools for some of the tasks to avoid duplication, such as GIZA++ (Och and Ney 2003) for word alignments and SRILM for language modeling.
J03-1002
Koo and Collins, 2005; Petrov et al., 2006; Titov
J05-1003
As suggested by Callison-Burch et al.(2006) we perform a focussed manual analysis of the output to see what changes have occurred.
E06-1032
The weighting parameters of these features were optimized in terms of BLEU by the approach of minimum error rate training (Och, 2003).
J03-1002
CCG contains most of the structure of the grammar in the lexicon, which makes it possible to introduce CCG supertags as a factor in a factored translation model (Koehn et al., 2006).
W06-3114
We use the following features in our induced English-to-English grammar:3 3Hiero also uses lexical weights (Koehn et al., 2003) in both 122 ??The joint probability of the two English hierarchical paraphrases, conditioned on the nonterminal symbol, as defined by this formula: p(e1, e2|x) = c(X ???e1, e2??summationtext e1prime, e2prime c(X ???e1prime, e2prime??
N03-1017
We selected 580 short sentences of length at most 50 characters from the 2002 NIST MT Evaluation test set as our development corpus and used it to tune s by maximizing the BLEU score (Och, 2003), and used the 2005 NIST MT Evaluation test set as our test corpus.
J03-1002
The features used in this study are: the length of t; a single-parameter distortion penalty on phrase reordering in a, as described in (Koehn et al., 2003); phrase translation model probabilities; and 4-gram language model probabilities logp(t), using Kneser-Ney smoothing as implemented in the SRILM toolkit.
N03-1017
Och and Ney (2004) gave a framework of alignment templates for this kind of models.
J04-4002
In an experiment on 16,800 sentences of Chinese-English newswire text with segment-level human evaluation from the Linguistic Data Consortium?s (LDC) Multiple Translation project, we compare the LFG-based evaluation method with other popular metrics like BLEU, NIST, General Text Matcher (GTM) (Turian et al., 2003), Translation Error Rate (TER) (Snover et al., 2006)1, and METEOR (Banerjee and Lavie, 2005), and we show that combining dependency representations with synonyms leads to a more accurate evaluation that correlates better with human judgment.
W05-0909
In recent years, statistical machine translation have experienced a quantum leap in quality thanks to automatic evaluation (Papineni et al., 2002) and errorbased optimization (Och, 2003).
J03-1002
Edinburgh, UK (Dugast et al., 2007) systran-nrc National Research Council, Canada (Simard et al., 2007) ucb University of California at Berkeley, USA (Nakov and Hearst, 2007) uedin University of Edinburgh, UK (Koehn and Schroeder, 2007) umd University of Maryland, USA (Dyer, 2007) upc University of Catalonia, Spain (Costa-Juss`a and Fonollosa, 2007) upv University of Valencia, Spain (Civera and Juan, 2007) Table 1: Participants in the shared task.
W07-0722 W07-0728 W07-0729 W07-0730 W07-0732 W07-0733
The major part of data comes from current and upcoming full releases of the Europarl data set (Koehn, 2005).
W05-0820
Therefore, recent efforts (Och et al., 2004) have concentrated on feature design ??wherein more intelligent features may be added.
J04-4002
baseline System used for comparison was Pharaoh (Koehn et al., 2003; Koehn, 2004), which uses a beam search algorithm for decoding.
N03-1017
With these considerations in mind, feature engineering is an active area of research (Och et al., 2004).
J04-4002
Previous ACL Workshops on Machine Translation were more limited in scope (Koehn and Monz, 2005; Koehn and Monz, 2006).
W05-0820 W06-3114
The feature weights for the overall translation models were trained using Och?s (2003) minimum-error-rate training procedure.
J03-1002
The results of last year?s workshop further suggested that Bleu systematically underestimated the quality of rule-based machine translation systems (Koehn and Monz, 2006).
W06-3114
models (Och et al., 2004; Koehn et al., 2003; 
J03-1002 J04-4002 N03-1017
We used Cowan and Collins (2005)?s parser for Spanish, Arun and Keller (2005)?s for French, Dubey (2005)?s for German, and Bikel (2002)?s for English.
J05-1003 P05-1038 P05-1039
They are: ??Meteor (Banerjee and Lavie, 2005)?Meteor measures precision and recall of unigrams when comparing a hypothesis translation 142 Language Pair Test Set Adequacy Fluency Rank Constituent English-German Europarl 1,416 1,418 1,419 2,626 News Commentary 1,412 1,413 1,412 2,755 German-English Europarl 1,525 1,521 1,514 2,999 News Commentary 1,626 1,620 1,601 3,084 English-Spanish Europarl 1,000 1,003 1,064 1,001 News Commentary 1,272 1,272 1,238 1,595 Spanish-English Europarl 1,174 1,175 1,224 1,898 News Commentary 947 949 922 1,339 English-French Europarl 773 772 769 1,456 News Commentary 729 735 728 1,313 French-English Europarl 834 833 830 1,641 News Commentary 1,041 1,045 1,035 2,036 English-Czech News Commentary 2,303 2,304 2,331 3,968 Czech-English News Commentary 1,711 1,711 1,733 0 Totals 17,763 17,771 17,820 27,711 Table 2: The number of items that were judged for each task during the manual evaluation against a reference.
W05-0909
This is akin to post-editing (though definitely not akin to the much more sophisticated approach in described in Simard et al.(2007)). We proceeded as follows: We used the selective segmentation based model above and decoded our English training data ETrain and English test data ETest to obtain T1Train and T1Test reStep BLEU From Table 4 24.61 Iter.
W07-0728
??GTM (Melamed et al., 2003)?GTM generalizes precision, recall, and F-measure to measure overlap between strings, rather than overlap between bags of items.
N03-2021
Initial results show the potential benefit of factors for statistical machine translation, (Koehn et al.2006) and (Koehn and Hoang 2007).
W06-3114 W07-0733
Named Entity Transliteration and Discovery from Multilingual Comparable Corpora, COLING-ACL, Sidney, Australia Philipp Koehn, Franz Josef Och, and Daniel Marcu, 2003.
J03-1002 N03-1017
138 ID Participant cmu-uka Carnegie Mellon University, USA (Paulik et al., 2007) cmu-syntax Carnegie Mellon University, USA (Zollmann et al., 2007) cu Charles University, Czech Republic (Bojar, 2007) limsi LIMSI-CNRS, France (Schwenk, 2007) liu University of Linkoping, Sweden(Holmqvist et al., 2007) nrc National Research Council, Canada (Ueffing et al., 2007) pct a commercial MT provider from the Czech Republic saar Saarland University & DFKI, Germany (Chen et al., 2007) systran SYSTRAN, France & U.
W07-0723 W07-0724 W07-0725 W07-0726 W07-0727 W07-0731 W07-0735
To generate phrase pairs from a parallel corpus, we use the "diag-and" phrase induction algorithm described in (Koehn et al, 2003), with symmetrized word alignments generated using IBM model 2 (Brown et al, 1993).
N03-1017
A new automatic metric METEOR (Banerjee and Lavie, 2005) uses stems and synonyms of the words.
W05-0909
In an open competition (Koehn & Monz, 2006) systems trained on parliamentary proceedings were tested on text from 'news commentary' web sites, a very slightly different domain.
W06-3114
Other work has incorporated paraphrases into MT evaluation: Russo-Lassner et al.(2005) use a combination of paraphrase-based features to evaluate translation output; Zhou et al.(2006) propose a new metric that extends n-gram matching to include synonyms and paraphrases; and Lavie?s METEOR metric (Banerjee and Lavie, 2005) can be used with additionalknowledgesuchasWordNetinordertosupport inexact lexical matches.
W05-0909 W06-1610
In the first part, a word alignment was computed (using the GIZA++ toolkit (Och and Ney, 2003)).
J03-1002
??ParaEval precision and ParaEval recall (Zhou et al., 2006)?ParaEval matches hypothesis and reference translations using paraphrases that are extracted from parallel corpora in an unsupervised fashion (Bannard and Callison-Burch, 2005).
P05-1074 W06-1610
??Initial phrase pairs are identified following the procedure typically employed in phrase based systems (Koehn et al., 2003; Och and Ney, 2004).
J04-4002 N03-1017
Oncetraininghastakenplace,minimumerrorrate training (Och, 2003) is used to tune the parameters i.
J03-1002
The Dutch-English parallel training data comes from the Europarl corpus (Koehn, 2005) and excludes the proceedings from the last quarter of 2000.
W05-0820
To model p(t,a|s), we use a standard loglinear approach: p(t,a|s) ??exp bracketleftBiggsummationdisplay i ifi(s,t,a) bracketrightBigg (1) where each fi(s,t,a) is a feature function, and weights i are set using Och?s algorithm (Och, 2003) to maximize the system?s BLEU score (Papineni et al., 2001) on a development corpus.
J03-1002
But it has been found that phrases longer than three words have little improvement in the performance (Koehn, 2003).
N03-1017
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
73 2.2.4 Minimum Error Rate Training A good way of training is to minimize empirical top-1 error on training data (Och, 2003).
J03-1002
??Maximumcorrelationtrainingonadequacyand on fluency (Liu and Gildea, 2007)?a linear combination of different evaluation metrics (Bleu, Meteor, Rouge, WER, and stochastic iterative alignment) with weights set to maximize Pearson?s correlation with adequacy and fluency judgments.
N07-1006
Och showed thatsystemperformanceisbestwhenparametersare optimizedusingthesameobjectivefunctionthatwill be used for evaluation; BLEU (Papineni et al., 2002) remains common for both purposes and is often retained for parameter optimization even when alternative evaluation measures are used, e.g., (Banerjee and Lavie, 2005; Snover et al., 2006).
W05-0909
Approaches Koehn, et al.?s (2003) method of estimating phrasetranslation probabilities is very simple.
N03-1017
Word alignment is an important step of most modern approaches to statistical machine translation (Koehn et al., 2003).
N03-1017
The comparison phrasal system was constructed using the same GIZA++ alignments and the heuristic combination described in (Och & Ney, 2003).
J03-1002
An early attempt at greater generality in a purely phrasal setting was the alignment template approach (Och & Ney 2004); newer approaches include formally syntactic (Chiang 2005), and linguistically syntactic approaches (Quirk et al.2005), (Huang et al.2006). In the next section, we examine these representative approaches to the reordering problem.
J04-4002
However, automatic measures also have big disadvantages; (Callison-Burch et al., 2006) describes some of them.
E06-1032
Och. 2003.
J03-1002 J03-1002
The most widely used method for estimating these probabilities is that of Koehn, et al.(2003), in which phrase pairs are extracted from word-aligned bilingual sentence pairs, and their translation probabilities estimated heuristically from surface statistics of the extracted phrase pairs.
N03-1017
It is an extension of Pharaoh (Koehn et al., 2003), and supports factor training and decoding.
N03-1017
Dyer. 2007.
W07-0729
Koehn (2005) reports on translation from English to Finnish, another language that is morphologically as complex as Turkish, with the added complexity of compounding and stricter agreement between modifiers and head nouns.
W05-0820
Weights on the loglinear features are set using Och's algorithm (Och, 2003) to maximize the system's BLEU score on a development corpus.
J03-1002
To derive the joint counts c(?s,?t) from which p(?s|?t) and p(?t|?s) are estimated, we use the phrase induction algorithm described in (Koehn et al., 2003), with symmetrized word alignments generated using IBM model 2 (Brown et al., 1993).
N03-1017
Moses was the subject of this year?s Johns Hopkins University Workshop on Machine Translation (Koehn et al.2006). The decoder is the core component of Moses.
W06-3114
on measures for inter-rater reliability (Carletta, 1996), on frameworks for evaluating spoken dialogue agents (Walker et al., 1998) and on the use of different corpora in the development of a particular system (The Carnegie-Mellon Communicator, Eskenazi et al.(1999)). The question we are addressing in this paper is how to collect and analyse relevant corpora.
J96-2004
In the experiment, only the first 500 sentences were used to train the log-linear model weight vector, where minimum error rate (MER) training was used (Och, 2003).
J03-1002
