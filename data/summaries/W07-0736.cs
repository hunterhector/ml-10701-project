Computational Linguistics 30 (4): 417-449 (2004) Papineni, Kishore, Salim Roukos, Todd Ward, and Wei-Jing Zhu.
C04-1072 P04-1077
Fox (2002) reported that dependency trees correspond better across translation pairs than constituent trees.
W02-1039
Treelet is more representatively flexible than subtree which is widely used in models based on phrase structures (Marcu et al., 2006; Liu et al., 2006).
P06-2070
Our method, extending this line of research with the use of labelled LFG dependencies, partial matching, and n-best parses, allows us to considerably outperform Liu and Gildea?s (2005) highest correlations with human judgement (they report 0.144 for the correlation with human fluency judgement, 0.202 for the correlation with human overall judgement), although it has to be kept in mind that such comparison is only tentative, as their correlation is calculated on a different test set.
W05-0904
For evaluation we use ROUGE (Lin, 2004) SU4 recall metric1, which was among the official automatic evaluation metrics for DUC.
C04-1072 P04-1077
.,[ 1 n tt SS, i .e . t h e s e m a nt i c i nt e r p r e t a t i on of T, w h er e i t S 2 is e it h e r t h e ch o sen s en se f o r t i ( i .e ., t he r e s u l t of a pr e v i ou s 2 N o te t h a t wi t h i t S w e r ef er i n t er c h a n g ea b l y t o t h e s em a n t i c g r ap h as s o c i at e d w i t h a s e n s e o r t o t h e s e n s e na me . Association for Computational Linguistics for the Semantic Analysis of Text, Barcelona, Spain, July 2004 SENSEVAL-3: Third International Workshop on the Evaluation of Systems disambiguation step) or the empty set (i.e., the term is not yet disambiguated).
C04-1072 P04-1077
These dependencies differ from those used by Liu and Gildea (2005), in that they are extracted according to the rules of the LFG grammar and they are labelled with a type of grammatical relation that connects the head and the modifier, such as subject, determiner, etc.
W05-0904
This finding has been previously reported, among others, in Liu and Gildea (2005).
W05-0904
It is widely agreed upon among researchers that a good evalutation metric should rank reference translation as higher than machine translation (Lin et al., 2004).
C04-1072 P04-1077
In contrast to the work by Lin (2004) and by Quirk et al.(2005), the DTSC model does not need to generate target language dependency structures using source structures and word alignments.
C04-1072 P04-1077
Liu et al.(2005) make use of dependency structure in sentence level machine translation evaluation in the form of headword chains, which are lexicalized dependency relations.
W05-0904
Unfortunately, the correlation between human assessment and BLEU score at sentence level is extremely low (Liu et al., 2005, 2006).
P06-2070 W05-0904
By contrast, Liu and Gildea (2005) present three metrics that use syntactic and unlabelled dependency information.
W05-0904
Although evaluated on a different test set, our method also outperforms the correlation with human scores reported in Liu and Gildea (2005).
W05-0904
Recent years have seen several studies investigating MT evaluation at the sentence level (Liu et al., 2005,2006; Quirk, 2004).
P06-2070 W05-0904
Other work has incorporated paraphrases into MT evaluation: Russo-Lassner et al.(2005) use a combination of paraphrase-based features to evaluate translation output; Zhou et al.(2006) propose a new metric that extends n-gram matching to include synonyms and paraphrases; and Lavie?s METEOR metric (Banerjee and Lavie, 2005) can be used with additionalknowledgesuchasWordNetinordertosupport inexact lexical matches.
W06-1610
Alto, CA 94304 {thione|vdberg|culy|polanyi}@fxpal.com Abstract In this paper, we introduce LiveTree, a core component of LIDAS, the Linguistic Discourse Analysis System for automatic discourse parsing with the Unified Linguistic Discourse Model (U-LDM) (X et al, 2004).
C04-1072 P04-1077
The experimental results in the above tables conveyed several important messages: in the ranking setup, for both the MT and human mixed output and MT only output scenarios, we have a signicantly 245 Feature Set Mean Corr Corr Var BLEU 0.2913541 0.0324386 DS 0.3058766 0.0226442 PERP 0.2921684 0.0210605 BLEU+DS 0.315106 0.0206144 BLEU+PERP 0.2954833 0.0211094 PERP+DS 0.3067157 0.0217037 All 0.305248 0.0218777 Table 4: Training and Testing on Within-year Data (Test on MT only) improved correlation between human scoring and automatic ranking at sentence level compared to the state-of-the-art sentence level correlation for uency score of approximately 0.202 found previously (Liu et al., 2006).
P06-2070
Morpho-syntactic annotation of the English references and hypotheses is performed using the constraint grammar parser ENGCG (Voutilainen, 1995), and the Spanish texts are annotated using the FreeLing analyser (Carreras et al., 2004).
C04-1072 P04-1077
Therefore, integrating phrases into the syntax-based models can improve the performance (Marcu et al., 2006; Liu et al., 2006).
P06-2070
IQMT. The optimal set is: { METEORwnsyn, ROUGEw 1.2 } which includes variants of METEOR, and ROUGE (Lin and Och, 2004).
C04-1072 P04-1077
Work The DTSC model is different from previous work based on dependency grammars by Eisner (2003), Lin (2004), Quirk et al.(2005), Ding et al.(2005) since they all deduce dependency structures on the target side.
C04-1072 P04-1077
Our method follows and substantially extends the earlier work of Liu and Gildea (2005), who use syntactic features and unlabelled dependencies to evaluate MT quality, outperforming BLEU on segment-level correlation with human judgement.
W05-0904
Over the last several years, various statistical syntaxbased models were proposed to extend traditional word/phrase based models in statistical machine translation (SMT) (Lin, 2004; Chiang, 2005; Ding et al., 2005; Quirk et al., 2005; Marcu et al., 2006; Liu et al., 2006).
C04-1072 P04-1077 P06-2070
While Liu and Gildea (2005) calculate n-gram matches on non-labelled head-modifier sequences derived by head-extraction rules from syntactic trees, we automatically evaluate the quality of translation by calculating an f-score on labelled dependency structures produced by a LexicalFunctional Grammar (LFG) parser.
W05-0904
??ParaEval precision and ParaEval recall (Zhou et al., 2006)?ParaEval matches hypothesis and reference translations using paraphrases that are extracted from parallel corpora in an unsupervised fashion (Bannard and Callison-Burch, 2005).
W06-1610
The DTSC model is also quite distinct from previous tree-string models by Marcu et al.(2006) and Liu et al.(2006). Firstly, their models are based on phrase structure grammars.
P06-2070
2004. Long-Distance Dependency Resolution in Automatically Acquired Wide-Coverage PCFG-Based LFG Approximations, In Proceedings of Association for Computational Linguistics 2004: 320-327.
C04-1072 P04-1077
The menu bar In this paper, we introduce LiveTree, a core component of LIDAS (the Linguistic Discourse Analysis System) for automatic discourse parsing with the Unified Linguistic Discourse Model (U-LDM) (Polanyi et al, 2004).
C04-1072 P04-1077
While these are based on a relatively few number of items, and while we have not performed any tests to determine whether the differences in ? are statistically significant, the results 7The Czech-English conditions were excluded since there were so few systems 146 are nevertheless interesting, since three metrics have higher correlation than Bleu: ??Semantic role overlap (Gimenez and M`arquez, 2007), which makes its debut in the proceedings of this workshop ??ParaEval measuring recall (Zhou et al., 2006), which has a model of allowable variation in translation that uses automatically generated paraphrases (Callison-Burch, 2007) ??Meteor (Banerjee and Lavie, 2005) which also allows variation by introducing synonyms and by flexibly matches words using stemming.
W06-1610
These two attributes are similar to those introduced by Lin (Lin, 2004).
C04-1072 P04-1077
Following the growing awareness of the deciency of n-gram based automatic MT evaluation, many studies attempted to improve upon n-gram based metrics (Zhou et al., 2006; Liu, et al., 2005,2006) as well as propose ways to evaluate MT evaluation metrics (Lin, et al.2004). Previous studies, however, have focused on MT evaluation at the document level in order to ght n-gram sparseness problem.
C04-1072 P04-1077 P06-2070 W05-0904 W06-1610
Also, several other tree-based decoding algorithms introduced by Eisner (2003), Quirk et al.(2005) and Liu et al.(2006) can be classified as the chart-style parsing algorithm too.
P06-2070
The use of dependencies in MT evaluation has not been extensively researched before (one exception here would be Liu and Gildea (2005)), and requires more research to improve it, but the method shows potential to become an accurate evaluation metric.
W05-0904
