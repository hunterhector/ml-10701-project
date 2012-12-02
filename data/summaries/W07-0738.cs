For example, on the WMT 2006 Shared Task evaluation, the French to English translation BLEU scores dropped from about 30 to about 20 for nearly all systems, when tested on News Commentary rather than Europarl (Koehn and Monz, 2006).
W06-3114
Similarities are captured from different viewpoints: DP-HWC(i)-l This metric corresponds to the HWC metric presented by Liu and Gildea (2005).
W05-0904
Computational Linguistics 30 (4): 417-449 (2004) Papineni, Kishore, Salim Roukos, Todd Ward, and Wei-Jing Zhu.
C04-1072 P04-1077
These two attributes are similar to those introduced by Lin (Lin, 2004).
C04-1072 P04-1077
Koehn and Monz (2006) also include a human evaluation, in which this system ranked noticeably higher than one might have predicted from its BLEU score.
W06-3114
They are generated from the training corpus via the ?diag-and??method (Koehn et al., 2003) and smoothed using Kneser-Ney smoothing (Foster et al., 2006), ??one or several n-gram language model(s) trained with the SRILM toolkit (Stolcke, 2002); in the baseline experiments reported here, we used a trigram model, ??a distortion model which assigns a penalty based on the number of source words which are skipped when generating a new target phrase, ??a word penalty.
W06-3114
CP-STM(i)-l This metric corresponds to the STM metric presented by Liu and Gildea (2005).
W05-0904
Our method, extending this line of research with the use of labelled LFG dependencies, partial matching, and n-best parses, allows us to considerably outperform Liu and Gildea?s (2005) highest correlations with human judgement (they report 0.144 for the correlation with human fluency judgement, 0.202 for the correlation with human overall judgement), although it has to be kept in mind that such comparison is only tentative, as their correlation is calculated on a different test set.
W05-0904
For evaluation we use ROUGE (Lin, 2004) SU4 recall metric1, which was among the official automatic evaluation metrics for DUC.
C04-1072 P04-1077
.,[ 1 n tt SS, i .e . t h e s e m a nt i c i nt e r p r e t a t i on of T, w h er e i t S 2 is e it h e r t h e ch o sen s en se f o r t i ( i .e ., t he r e s u l t of a pr e v i ou s 2 N o te t h a t wi t h i t S w e r ef er i n t er c h a n g ea b l y t o t h e s em a n t i c g r ap h as s o c i at e d w i t h a s e n s e o r t o t h e s e n s e na me . Association for Computational Linguistics for the Semantic Analysis of Text, Barcelona, Spain, July 2004 SENSEVAL-3: Third International Workshop on the Evaluation of Systems disambiguation step) or the empty set (i.e., the term is not yet disambiguated).
C04-1072 P04-1077
We present a comparative study on the behavior of several metric representatives from each linguistic level in the context of some of the cases reported by Koehn and Monz (2006) and Callison-Burch et al.(2006) (see Section 3).
E06-1032 W06-3114
However, recent work suggests that Bleu?s correlation with human judgments may not be as strong as previously thought (Callison-Burch et al., 2006).
E06-1032
GTM We set to 1 the value of the e parameter (Melamed et al., 2003).
N03-2021
Previous ACL Workshops on Machine Translation were more limited in scope (Koehn and Monz, 2005; Koehn and Monz, 2006).
W06-3114
Constituency trees are provided by the Charniak-Johnson?s Max-Ent reranking parser (Charniak and Johnson, 2005).
P05-1022
Moses was the subject of this year?s Johns Hopkins University Workshop on Machine Translation (Koehn et al.2006). The decoder is the core component of Moses.
W06-3114
In addition to these engines, we also used the scripts included in the Moses toolkit (Koehn et al., 2006)3 to generate phrase tables from the training data.
W06-3114
c2007 Association for Computational Linguistics Linguistic Features for Automatic Evaluation of Heterogenous MT Systems Jesus Gimenez and Llus M`arquez TALP Research Center, LSI Department Universitat Polit`ecnica de Catalunya Jordi Girona Salgado 1??, E-08034, Barcelona {jgimenez,lluism}@lsi.upc.edu Abstract Evaluation results recently reported by Callison-Burch et al.(2006) and Koehn and Monz (2006), revealed that, in certain cases, the BLEU metric may not be a reliable MT quality indicator.
E06-1032 W06-3114
In an open competition (Koehn & Monz, 2006) systems trained on parliamentary proceedings were tested on text from 'news commentary' web sites, a very slightly different domain.
W06-3114
Chris Callison-Burch, Miles Osborne and Philipp Koehn, 2006.
E06-1032 W06-3114
They are: ??Meteor (Banerjee and Lavie, 2005)?Meteor measures precision and recall of unigrams when comparing a hypothesis translation 142 Language Pair Test Set Adequacy Fluency Rank Constituent English-German Europarl 1,416 1,418 1,419 2,626 News Commentary 1,412 1,413 1,412 2,755 German-English Europarl 1,525 1,521 1,514 2,999 News Commentary 1,626 1,620 1,601 3,084 English-Spanish Europarl 1,000 1,003 1,064 1,001 News Commentary 1,272 1,272 1,238 1,595 Spanish-English Europarl 1,174 1,175 1,224 1,898 News Commentary 947 949 922 1,339 English-French Europarl 773 772 769 1,456 News Commentary 729 735 728 1,313 French-English Europarl 834 833 830 1,641 News Commentary 1,041 1,045 1,035 2,036 English-Czech News Commentary 2,303 2,304 2,331 3,968 Czech-English News Commentary 1,711 1,711 1,733 0 Totals 17,763 17,771 17,820 27,711 Table 2: The number of items that were judged for each task during the manual evaluation against a reference.
W05-0909
These dependencies differ from those used by Liu and Gildea (2005), in that they are extracted according to the rules of the LFG grammar and they are labelled with a type of grammatical relation that connects the head and the modifier, such as subject, determiner, etc.
W05-0904
3 3 Related work 3.1 String-based metrics The insensitivity of BLEU and NIST to perfectly legitimate syntactic and lexical variation has been raised, among others, in Callison-Burch et al.(2006), but the criticism is widespread.
E06-1032
To summarize, we provided: ??sentence-aligned training corpora ??development and dev-test sets ??language models trained for each language ??an open source decoder for phrase-based SMT called Moses (Koehn et al., 2006), which replaces the Pharaoh decoder (Koehn, 2004) ??a training script to build models for Moses Theperformanceofthisbaselinesystemissimilar to the best submissions in last year?s shared task.
W06-3114
This finding has been previously reported, among others, in Liu and Gildea (2005).
W05-0904
Finally, word similarity can be computed from structural features like head-modifier relationships (Grefenstette 1994b; Ruge 1992; Dagan, Marcus, and Markovitch 1993; Pereira, Tishby, and Lee 1993; Dagan, Pereira, and Lee 1994).
J93-2004
Although widely popular thanks to their speed and efficiency, both BLEU and NIST have been criticized for inadequate accuracy of evaluation at the segment level (Callison-Burch et al., 2006).
E06-1032
Tag sets for English are derived from the Penn Treebank (Marcus et al., 1993).
J93-2004
It is widely agreed upon among researchers that a good evalutation metric should rank reference translation as higher than machine translation (Lin et al., 2004).
C04-1072 P04-1077
In contrast to the work by Lin (2004) and by Quirk et al.(2005), the DTSC model does not need to generate target language dependency structures using source structures and word alignments.
C04-1072 P04-1077
Mitchell P. Marcus, Beatrice Santorini, and Mary Ann Marcinkiewicz. 1993. Building a large annotated corpus of English: The Penn Treebank. Computational Linguistics, 19(2):313330.
J93-2004
We might find better suited metrics, such as METEOR (Banerjee and Lavie, 2005), which is oriented towards word selection8.
W05-0909
Stemming is enabled (Lin and Och, 2004a).
C04-1072 P04-1077
Unfortunately, the correlation between human assessment and BLEU score at sentence level is extremely low (Liu et al., 2005, 2006).
W05-0904
By contrast, Liu and Gildea (2005) present three metrics that use syntactic and unlabelled dependency information.
W05-0904
Although evaluated on a different test set, our method also outperforms the correlation with human scores reported in Liu and Gildea (2005).
W05-0904
We analyze some of the cases reported by Koehn and Monz (2006) and Callison-Burch et al.(2006). We distinguish different evaluation contexts.
E06-1032 W06-3114
Recent years have seen several studies investigating MT evaluation at the sentence level (Liu et al., 2005,2006; Quirk, 2004).
W05-0904
Other work has incorporated paraphrases into MT evaluation: Russo-Lassner et al.(2005) use a combination of paraphrase-based features to evaluate translation output; Zhou et al.(2006) propose a new metric that extends n-gram matching to include synonyms and paraphrases; and Lavie?s METEOR metric (Banerjee and Lavie, 2005) can be used with additionalknowledgesuchasWordNetinordertosupport inexact lexical matches.
W05-0909
Och showed thatsystemperformanceisbestwhenparametersare optimizedusingthesameobjectivefunctionthatwill be used for evaluation; BLEU (Papineni et al., 2002) remains common for both purposes and is often retained for parameter optimization even when alternative evaluation measures are used, e.g., (Banerjee and Lavie, 2005; Snover et al., 2006).
W05-0909
Metric Parameters The original version of Meteor (Banerjee and Lavie, 2005) has instantiated values for three parameters in the metric: one for controlling the relative weight of precision and recall in computing the Fmean score (); one governing the shape of the penalty as a function of fragmentation () and one for the relative weight assigned to the fragmentation penalty ().
W05-0909
??GTM (Melamed et al., 2003)?GTM generalizes precision, recall, and F-measure to measure overlap between strings, rather than overlap between bags of items.
N03-2021
al. 2006), we are interested in applying alternative metrics such a Meteor (Banerjee and Lavie 2005).
W05-0909
As suggested by Callison-Burch et al.(2006) we perform a focussed manual analysis of the output to see what changes have occurred.
E06-1032
This is done with the help of phrase model training code provided by University of Edinburgh during the NAACL 2006 Workshop on Statistical Machine Translation (Koehn and Monz, 2006).
W06-3114
Similarity We have incorporated, with minor modifications, some of the syntactic metrics described by Liu and Gildea (2005) and Amigo et al.(2006) based on dependency and constituency parsing.
W05-0904
Alto, CA 94304 {thione|vdberg|culy|polanyi}@fxpal.com Abstract In this paper, we introduce LiveTree, a core component of LIDAS, the Linguistic Discourse Analysis System for automatic discourse parsing with the Unified Linguistic Discourse Model (U-LDM) (X et al, 2004).
C04-1072 P04-1077
Morpho-syntactic annotation of the English references and hypotheses is performed using the constraint grammar parser ENGCG (Voutilainen, 1995), and the Spanish texts are annotated using the FreeLing analyser (Carreras et al., 2004).
C04-1072 P04-1077
3.2 Multiple-reference Scenario We study the case reported by Callison-Burch et al.(2006) in the context of the Arabic-to-English exercise of the ??005 NIST MT Evaluation Campaign??
E06-1032
However, automatic measures also have big disadvantages; (Callison-Burch et al., 2006) describes some of them.
E06-1032
Koehn. 2006.
W06-3114
CCG contains most of the structure of the grammar in the lexicon, which makes it possible to introduce CCG supertags as a factor in a factored translation model (Koehn et al., 2006).
W06-3114
Penn treebank (PTB) (Marcus et al., 1993). We used
J93-2004
Initial results show the potential benefit of factors for statistical machine translation, (Koehn et al.2006) and (Koehn and Hoang 2007).
W06-3114
3.1 Single-reference Scenario We use some of the test beds corresponding to the ?NAACL 2006 Workshop on Statistical Machine Translation??(WMT 2006) (Koehn and Monz, 2006).
W06-3114
Penn Treebank (Marcus et al., 1993), using a stan-
J93-2004
Eugene Charniak and Mark Johnson. 2005. Coarse-to-fine n-best parsing and maxent discriminative reranking. In ACL 43, pages 173180.
P05-1022
M.P. Marcus, B. Santorini, and M. Marcinkiewicz. 1993. Building a Large Annotated Corpus of English: The Penn Treebank. ComputationalLinguistics, 19(2):313330.
J93-2004
Even if human judges have explicit evaluation guidelines at hand, they still find it difficult to assign a numerical value which represents the quality of the translation for many sentences (Koehn and Monz, 2006).
W06-3114
Human Likeness Metrics are evaluated in terms of descriptive power, i.e., their ability to distinguish between human and automatic translations (Lin and Och, 2004b; Amigo et al., 2005).
C04-1072 P04-1077
Work The DTSC model is different from previous work based on dependency grammars by Eisner (2003), Lin (2004), Quirk et al.(2005), Ding et al.(2005) since they all deduce dependency structures on the target side.
C04-1072 P04-1077
Others try to accommodate both syntactic and lexical differences between the candidate translation and the reference, like CDER (Leusch et al., 2006), which employs a version of edit distance for word substitution and reordering; or METEOR (Banerjee and Lavie, 2005), which uses stemming and WordNet synonymy.
W05-0909
In previous research on natural language processing, many methodologies for extracting various relations from corpora have been developed, such as the ?is-a??relation (Hearst 1992), ?part-of??relation (Berland and Charniak 1999), causal relation (Girju 2003), and entailment relation (Geffet and Dagan 2005).
P05-1022
In an experiment on 16,800 sentences of Chinese-English newswire text with segment-level human evaluation from the Linguistic Data Consortium?s (LDC) Multiple Translation project, we compare the LFG-based evaluation method with other popular metrics like BLEU, NIST, General Text Matcher (GTM) (Turian et al., 2003), Translation Error Rate (TER) (Snover et al., 2006)1, and METEOR (Banerjee and Lavie, 2005), and we show that combining dependency representations with synonyms leads to a more accurate evaluation that correlates better with human judgment.
W05-0909
Our method follows and substantially extends the earlier work of Liu and Gildea (2005), who use syntactic features and unlabelled dependencies to evaluate MT quality, outperforming BLEU on segment-level correlation with human judgement.
W05-0904
Over the last several years, various statistical syntaxbased models were proposed to extend traditional word/phrase based models in statistical machine translation (SMT) (Lin, 2004; Chiang, 2005; Ding et al., 2005; Quirk et al., 2005; Marcu et al., 2006; Liu et al., 2006).
C04-1072 P04-1077
Models Inspired by work on factored language models, Koehn et al.(2006) extend phrase-based models to incorporate multiple levels of linguistic knowledge as factors.
W06-3114
While Liu and Gildea (2005) calculate n-gram matches on non-labelled head-modifier sequences derived by head-extraction rules from syntactic trees, we automatically evaluate the quality of translation by calculating an f-score on labelled dependency structures produced by a LexicalFunctional Grammar (LFG) parser.
W05-0904
Meteor, as well as several other proposed metrics such as GTM (Melamed et al., 2003), TER (Snover et al., 2006) and CDER (Leusch et al., 2006) aim to address some of these weaknesses.
N03-2021
For instance, Callison-Burch et al.(2006) and Koehn and Monz (2006) reported and analyzed several cases of strong disagreement between system rankings provided by human assessors and those produced by the BLEU metric (Papineni et al., 2001).
E06-1032 W06-3114
Liu et al.(2005) make use of dependency structure in sentence level machine translation evaluation in the form of headword chains, which are lexicalized dependency relations.
W05-0904
?wn stem??and ?wn synonymy?? in that order (Banerjee and Lavie, 2005).
W05-0909
2004. Long-Distance Dependency Resolution in Automatically Acquired Wide-Coverage PCFG-Based LFG Approximations, In Proceedings of Association for Computational Linguistics 2004: 320-327.
C04-1072 P04-1077
Previous publications on Meteor (Lavie et al., 2004; Banerjee and Lavie, 2005) have described the details underlying the metric and have extensively compared its performance with Bleu and several other MT evaluation metrics.
W05-0909
The menu bar In this paper, we introduce LiveTree, a core component of LIDAS (the Linguistic Discourse Analysis System) for automatic discourse parsing with the Unified Linguistic Discourse Model (U-LDM) (Polanyi et al, 2004).
C04-1072 P04-1077
Based on estimating a joint-probability model between the source and the target languages, Ngram-based SMT has proved to be a very competitive alternatively to phrase-based and other state-of-the-art systems in previous evaluation campaigns, as shown in (Koehn and Monz, 2005; Koehn and Monz, 2006).
W06-3114
Note that using stems and their synonyms as used in METEOR (Banerjee and Lavie, 2005) could also be considered for word similarity.
W05-0909
IQMT. The optimal set is: { METEORwnsyn, ROUGEw 1.2 } which includes variants of METEOR, and ROUGE (Lin and Och, 2004).
C04-1072 P04-1077
A new automatic metric METEOR (Banerjee and Lavie, 2005) uses stems and synonyms of the words.
W05-0909
Callison-Burch et al.(2006) extract phrase-level paraphrases by mapping input phrases into a phrase table and then mapping back to the source language.
E06-1032
The results of last year?s workshop further suggested that Bleu systematically underestimated the quality of rule-based machine translation systems (Koehn and Monz, 2006).
W06-3114
While these are based on a relatively few number of items, and while we have not performed any tests to determine whether the differences in ? are statistically significant, the results 7The Czech-English conditions were excluded since there were so few systems 146 are nevertheless interesting, since three metrics have higher correlation than Bleu: ??Semantic role overlap (Gimenez and M`arquez, 2007), which makes its debut in the proceedings of this workshop ??ParaEval measuring recall (Zhou et al., 2006), which has a model of allowable variation in translation that uses automatically generated paraphrases (Callison-Burch, 2007) ??Meteor (Banerjee and Lavie, 2005) which also allows variation by introducing synonyms and by flexibly matches words using stemming.
W05-0909
(Popovic and Ney, 2004)) or machine translation quality (Nieen and Ney (2001), Koehn and Knight (2003), Zollmann et al.(2006), among others, for various languages; Goldwater and McClosky (2005), Bojar et al.(2006) and Talbot and Osborne (2006) for Czech), however, they focus on translating from the highly inflectional language.
W06-3114
Following the growing awareness of the deciency of n-gram based automatic MT evaluation, many studies attempted to improve upon n-gram based metrics (Zhou et al., 2006; Liu, et al., 2005,2006) as well as propose ways to evaluate MT evaluation metrics (Lin, et al.2004). Previous studies, however, have focused on MT evaluation at the document level in order to ght n-gram sparseness problem.
C04-1072 P04-1077 W05-0904
The use of dependencies in MT evaluation has not been extensively researched before (one exception here would be Liu and Gildea (2005)), and requires more research to improve it, but the method shows potential to become an accurate evaluation metric.
W05-0904
