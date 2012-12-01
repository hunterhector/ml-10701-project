Raw parallel data need to be preprocessed in the modern phrase-based SMT before they are aligned by alignment algorithms, one of which is the wellknown tool, GIZA++ (Och and Ney, 2003), for training IBM models (1-4).
P03-1021
Computational Linguistics 30 (4): 417-449 (2004) Papineni, Kishore, Salim Roukos, Todd Ward, and Wei-Jing Zhu.
C04-1090
We also ran a phrase-based system (PB) with a distortion reordering model (Xiong et al., 2006) on the same corpus.
P06-1066
These two attributes are similar to those introduced by Lin (Lin, 2004).
C04-1090
Treelet is more representatively flexible than subtree which is widely used in models based on phrase structures (Marcu et al., 2006; Liu et al., 2006).
P06-1077 W06-1606
similar to Chiang (2005), in which FBIS corpus is 
P05-1033
For evaluation we use ROUGE (Lin, 2004) SU4 recall metric1, which was among the official automatic evaluation metrics for DUC.
C04-1090
.,[ 1 n tt SS, i .e . t h e s e m a nt i c i nt e r p r e t a t i on of T, w h er e i t S 2 is e it h e r t h e ch o sen s en se f o r t i ( i .e ., t he r e s u l t of a pr e v i ou s 2 N o te t h a t wi t h i t S w e r ef er i n t er c h a n g ea b l y t o t h e s em a n t i c g r ap h as s o c i at e d w i t h a s e n s e o r t o t h e s e n s e na me . Association for Computational Linguistics for the Semantic Analysis of Text, Barcelona, Spain, July 2004 SENSEVAL-3: Third International Workshop on the Evaluation of Systems disambiguation step) or the empty set (i.e., the term is not yet disambiguated).
C04-1090
There are several free parameters to tune: ??Beam size ??Maximum number of candidates per input node (in this paper we use 100) ??Beam threshold ??maximum range of scores between top and bottom scoring candidate (we use a logprob difference of 30) ??Maximum combinations considered ??To bound search time, we can stop after a specified number of elements are popped off the priority queue (we use 5000) 5 Models We use all of the Treelet models we described in Quirk et al.(2005) namely: ??Treelet table with translation probabilities estimated using maximum likelihood, with absolute discounting.
P05-1034
Among them, the most similar work is (Quirk et al., 2005).
P05-1034
Dependency trees have been used in a variety of NLP applications, such as relation extraction (Culotta and Sorensen, 2004) and machine translation (Ding and Palmer, 2005).
P05-1067
Model weights were trained separately for all 3 systems using minimum error rate training to maximize BLEU (Och, 2003) on the development set (dev).
P03-1021
Philipp Koehn, Franz J. Och, and Daniel Marcu. 2003. 
P03-1021
translation Hierarchical systems (Chiang, 2005) induce a context-free grammar with one non-terminal directly from the parallel corpus, with the advantage of not requiring any additional knowledge source or tools, such as a treebank or a parser.
P05-1033
While xRS 2 Marcu et al.(2006) and Zollmann et al.(2006) recognize this problem and attempt to alleviate it by grafting surface phrases into constituency trees by various methods.
W06-1606
In contrast to the work by Lin (2004) and by Quirk et al.(2005), the DTSC model does not need to generate target language dependency structures using source structures and word alignments.
C04-1090 P05-1034
models (Och et al., 2004; Koehn et al., 2003; 
P03-1021
It also contains tools for tuning these models using minimum error rate training (Och 2003) and evaluating the resulting translations using the BLEU score (Papineni et al.2002). Moses uses standard external tools for some of the tasks to avoid duplication, such as GIZA++ (Och and Ney 2003) for word alignments and SRILM for language modeling.
P03-1021
Such rules can be used to translate from Spanish to English by searching for the best English language tree for a given Spanish language string (Marcu et al., 2006).
W06-1606
This is similar to syntax-directed translation originally proposedfor compiling (Ahoand Ullman, 1969),andalsousedinmachinetranslation(Quirket al., 2005; Huang et al., 2006).
P05-1034 W06-1608
This result can be improved further using a better parser (Quirk et al., 2006) or using a statistical attaching model.
W06-1608
Named Entity Transliteration and Discovery from Multilingual Comparable Corpora, COLING-ACL, Sidney, Australia Philipp Koehn, Franz Josef Och, and Daniel Marcu, 2003.
P03-1021
Chiang, 2005), some of measure words can be 
P05-1033
In the first part, a word alignment was computed (using the GIZA++ toolkit (Och and Ney, 2003)).
P03-1021
The weighting parameters of these features were optimized in terms of BLEU by the approach of minimum error rate training (Och, 2003).
P03-1021
Alto, CA 94304 {thione|vdberg|culy|polanyi}@fxpal.com Abstract In this paper, we introduce LiveTree, a core component of LIDAS, the Linguistic Discourse Analysis System for automatic discourse parsing with the Unified Linguistic Discourse Model (U-LDM) (X et al, 2004).
C04-1090
The comparison phrasal system was constructed using the same GIZA++ alignments and the heuristic combination described in (Och & Ney, 2003).
P03-1021
An early attempt at greater generality in a purely phrasal setting was the alignment template approach (Och & Ney 2004); newer approaches include formally syntactic (Chiang 2005), and linguistically syntactic approaches (Quirk et al.2005), (Huang et al.2006). In the next section, we examine these representative approaches to the reordering problem.
P05-1033 P05-1034 W06-1608
Therefore, integrating phrases into the syntax-based models can improve the performance (Marcu et al., 2006; Liu et al., 2006).
P06-1077 W06-1606
< D,S > must be consistent with the word alignment M of the corresponding sentence pair ?(i,j) ??M,i ??D ??j ??S A treelet is defined to be any connected subgraph, which is similar to the definition in (Quirk et al., 2005).
P05-1034
Our 46 treelets allow variables at any non-crossed nodes and target strings allow gaps, which are not available in (Quirk et al., 2005).
P05-1034
Each transduction rule null has a vector of variables null nullnull,?null nullnull . Each variable is associated with an input node nullnullnullnull . For each input node null, we keep a beam of derivations nullnullnullnull . Derivations are represented as a pair nullnull,nullnull where null is a transduction rule and nullnullnull null is a vector with one integer for each of the null variables in null . The interpretation is that the complete candidate can be constructed by recursively substituting for each 6 Like Chiang (2005) we only search for the yield of the most likely derivation, rather than the most likely yield.
P05-1033
treelet translation We previously described (Quirk et al, 2005) a linguistically syntax-based system that parses the source language, uses word-based alignments to project a target dependency tree, and extracts paired dependency tree fragments (treelets) instead of surface phrases.
P05-1034
Franz J. Och and Hermann Ney. 2000. Improved statis-
P00-1056
Melamed (2004) also used a similar way to integrate the language model.
P04-1083
Work The DTSC model is different from previous work based on dependency grammars by Eisner (2003), Lin (2004), Quirk et al.(2005), Ding et al.(2005) since they all deduce dependency structures on the target side.
C04-1090 P03-2041 P05-1034 P05-1067
And finally, our model allow gaps on the target side, which is an advantage shared by (Melamed, 2004) and (Simard, 2005).
H05-1095 P04-1083
Over the last several years, various statistical syntaxbased models were proposed to extend traditional word/phrase based models in statistical machine translation (SMT) (Lin, 2004; Chiang, 2005; Ding et al., 2005; Quirk et al., 2005; Marcu et al., 2006; Liu et al., 2006).
C04-1090 P05-1033 P05-1034 P05-1067 P06-1077 W06-1606 W06-1608
The most important distinction between the treelet in (Quirk et al., 2005) and ours is that we allow variables at positions of subnodes.
P05-1034
We selected 580 short sentences of length at most 50 characters from the 2002 NIST MT Evaluation test set as our development corpus and used it to tune s by maximizing the BLEU score (Och, 2003), and used the 2005 NIST MT Evaluation test set as our test corpus.
P03-1021
order templates For each pair of parallel training sentences, we parse the source sentence, obtain a source dependency tree, and use GIZA++ word alignments to project a target dependency tree as described in Quirk et al.(2005). Given this pair of aligned source and target dependency trees, we recursively extract one order template for each pair of aligned non-leaf source and target nodes.
P05-1034
Recently 1www.nist.gov/speech/tests/mt/mt06eval official results.html there have been a few syntax-based models that show performance comparable to the phrase-based models (Chiang, 2005; Marcu et al., 2006).
P05-1033 W06-1606
The DTSC model is also quite distinct from previous tree-string models by Marcu et al.(2006) and Liu et al.(2006). Firstly, their models are based on phrase structure grammars.
P06-1077 W06-1606
Weights on the loglinear features are set using Och's algorithm (Och, 2003) to maximize the system's BLEU score on a development corpus.
P03-1021
Statistical Phrase-based Translation, In Proceedings of HLT-NAACL, Edmonton, Canada Franz Josef Och, 2003.
P03-1021
The menu bar In this paper, we introduce LiveTree, a core component of LIDAS (the Linguistic Discourse Analysis System) for automatic discourse parsing with the Unified Linguistic Discourse Model (U-LDM) (Polanyi et al, 2004).
C04-1090
These models also suffer from a large search space when decoding with an integrated language model, which can lead to search errors (Chiang, 2005).
P05-1033
The factored translation model combines features in a log-linear fashion (Och, 2003).
P03-1021
ZA++ (Och and Ney, 2000) on the training corpus 
P00-1056
Also, several other tree-based decoding algorithms introduced by Eisner (2003), Quirk et al.(2005) and Liu et al.(2006) can be classified as the chart-style parsing algorithm too.
P03-2041 P05-1034 P06-1077 W06-1608
David Chiang. 2005. A hierarchical phrase-based mod-
P05-1033
