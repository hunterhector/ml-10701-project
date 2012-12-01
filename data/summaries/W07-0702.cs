To overcome this problem, Smith et al.(2006) demonstrated that using ensembles of separately trained models and combining them in a logarithmic opinion pool (LOP) leads to better parameter values.
W06-2918
The comparison phrasal system was constructed using the same GIZA++ alignments and the heuristic combination described in (Och & Ney, 2003).
P03-1021
Such rules can be used to translate from Spanish to English by searching for the best English language tree for a given Spanish language string (Marcu et al., 2006).
W06-1606
Raw parallel data need to be preprocessed in the modern phrase-based SMT before they are aligned by alignment algorithms, one of which is the wellknown tool, GIZA++ (Och and Ney, 2003), for training IBM models (1-4).
P03-1021
Supertags were introduced by Bangalore (1999) as a way of increasing parsing efficiency by reducing the number of structures assigned to each word.
J99-2004
In particular, we use the Word Sketch dif2To facilitate processing, the complete CGC was segmented and POS tagged using the Academia Sinica segmentation and tagging system (Ma and Huang, 2006).
W06-3601
The supertagger was trained on the CCGBank in English (Hockenmaier and Steedman, 2005) and in German (Hockenmaier, 2006).
P06-1064
using xR rules In the absence of a language model or other contextually dependent features, finding the highest scoring derivation would be a simple dynamic program (Huang et al.2006) 6 .However exact search using an null -gram language model leads to split states for each null -gram context.
W06-3601
We compared our system to Pharaoh, a leading phrasal SMT decoder (Koehn et al., 2003), and our treelet system.
N03-1017
Model weights were trained separately for all 3 systems using minimum error rate training to maximize BLEU (Och, 2003) on the development set (dev).
P03-1021
The CCG supertagger (Clark, 2002; Clark and Curran, 2004) was provided with the C&C Language Processing Tools3.
P04-1014
work In their psychological study, Clark and Krych (2004) showed that speakers alter their utterances midcourse while monitoring not only the listener?s vocal signals, but also the listener?s gestural signals as well as through other mutually visible events.
P04-1014
While xRS 2 Marcu et al.(2006) and Zollmann et al.(2006) recognize this problem and attempt to alleviate it by grafting surface phrases into constituency trees by various methods.
W06-1606
Moses is also able to integrate factored language models, such as those described in (Bilmes and Kirchhoff 2003) and (Axelrod 2006).
N03-2002
Factored translation with source words determining target words and CCG supertags For our experiments we used the following features: the translation probabilities Pr(sFs1 |tFt1 ) and Pr(tFt1 |sFs1 ),thelexicalweights(Koehnetal.,2003) lex(sFs1 |tFt1 ) and lex(tFt1 |sFs1 ), and a phrase penalty e, which allows the model to learn a preference for longer or shorter phrases.
N03-1017
Philipp Koehn, Franz J. Och, and Daniel Marcu. 2003. 
N03-1017 P03-1021
models (Och et al., 2004; Koehn et al., 2003; 
N03-1017 P03-1021
It also contains tools for tuning these models using minimum error rate training (Och 2003) and evaluating the resulting translations using the BLEU score (Papineni et al.2002). Moses uses standard external tools for some of the tasks to avoid duplication, such as GIZA++ (Och and Ney 2003) for word alignments and SRILM for language modeling.
P03-1021
translation Hierarchical systems (Chiang, 2005) induce a context-free grammar with one non-terminal directly from the parallel corpus, with the advantage of not requiring any additional knowledge source or tools, such as a treebank or a parser.
P05-1033
This is similar to syntax-directed translation originally proposedfor compiling (Ahoand Ullman, 1969),andalsousedinmachinetranslation(Quirket al., 2005; Huang et al., 2006).
P05-1034 W06-3601
This is a simple way of including syntactic information in a phrase-based model, and has also been suggested by Hassan et al.(2007). For both Arabic-English (Hassan et al., 2007) and our experiments in Dutch-English, n-gram models over CCG supertags improve the quality of translation.
P07-1037
As suggested by Callison-Burch et al.(2006) we perform a focussed manual analysis of the output to see what changes have occurred.
E06-1032
Chiang, 2005), some of measure words can be 
P05-1033
The weighting parameters of these features were optimized in terms of BLEU by the approach of minimum error rate training (Och, 2003).
P03-1021
However, these models, which are equivalent to finite-state machines (Kumar and Byrne, 2003), are unable to model long range word orderdifferences.
N03-1019
An early attempt at greater generality in a purely phrasal setting was the alignment template approach (Och & Ney 2004); newer approaches include formally syntactic (Chiang 2005), and linguistically syntactic approaches (Quirk et al.2005), (Huang et al.2006). In the next section, we examine these representative approaches to the reordering problem.
P05-1033 P05-1034 W06-3601
Alternately English trees produced by a parser can be transduced to 2 Spanish strings using the same rules (Huang et al., 2006).
W06-3601
Though taggers based on dependency networks (Toutanova et al., 2003), SVM (Gimenez and M`arquez, 2003), MaxEnt (Ratnaparkhi, 1996), CRF (Smith et al., 2005), and other methods may reach slightly better results, their train/test cycle is orders of magnitude longer.
P05-1003
Each transduction rule null has a vector of variables null nullnull,?null nullnull . Each variable is associated with an input node nullnullnullnull . For each input node null, we keep a beam of derivations nullnullnullnull . Derivations are represented as a pair nullnull,nullnull where null is a transduction rule and nullnullnull null is a vector with one integer for each of the null variables in null . The interpretation is that the complete candidate can be constructed by recursively substituting for each 6 Like Chiang (2005) we only search for the yield of the most likely derivation, rather than the most likely yield.
P05-1033
Different backoff paths are possible, and it would be interesting but prohibitively slow to apply a strategy similar to generalised parallel backoff (Bilmes and Kirchhoff, 2003) which is used in factored language models.
N03-2002
It is an extension of Pharaoh (Koehn et al., 2003), and supports factor training and decoding.
N03-1017
In taskmanipulation situations where the listener manipulates objects by following the speaker?s instructions, correct task manipulation by the listener serves as more direct evidence of understanding (Brennan 2000, Clark and Krych 2004), and affects the speaker?s dialogue control strategies.
P04-1014
We propose using a logarithmic opinion pool (Smith et al., 2005) to combinethemorespecificmodels(whichdependon both words and supertags) with more general models(whichonlydependsonwords).
P05-1003
Modern phrasal SMT systems such as (Koehn et al., 2003) derive much of their power from being able to memorize and use long phrases.
N03-1017
order templates For each pair of parallel training sentences, we parse the source sentence, obtain a source dependency tree, and use GIZA++ word alignments to project a target dependency tree as described in Quirk et al.(2005). Given this pair of aligned source and target dependency trees, we recursively extract one order template for each pair of aligned non-leaf source and target nodes.
P05-1034
Phrase-based statistical machine translation (Koehn et al.2003) has emerged as the dominant paradigm in machine translation research.
N03-1017
Note that this decoding is an equivalent formulation to a uniformly weighted logarithmic opinion pool, as described in Smith et al.(2005). Of the three decoding methods, Standalone has the lowest complexity, requiring only a binary Viterbi decoding for each weak learner.
P05-1003
Recently 1www.nist.gov/speech/tests/mt/mt06eval official results.html there have been a few syntax-based models that show performance comparable to the phrase-based models (Chiang, 2005; Marcu et al., 2006).
P05-1033 W06-1606
similar to Chiang (2005), in which FBIS corpus is 
P05-1033
There are several free parameters to tune: ??Beam size ??Maximum number of candidates per input node (in this paper we use 100) ??Beam threshold ??maximum range of scores between top and bottom scoring candidate (we use a logprob difference of 30) ??Maximum combinations considered ??To bound search time, we can stop after a specified number of elements are popped off the priority queue (we use 5000) 5 Models We use all of the Treelet models we described in Quirk et al.(2005) namely: ??Treelet table with translation probabilities estimated using maximum likelihood, with absolute discounting.
P05-1034
treelet translation We previously described (Quirk et al, 2005) a linguistically syntax-based system that parses the source language, uses word-based alignments to project a target dependency tree, and extracts paired dependency tree fragments (treelets) instead of surface phrases.
P05-1034
These models also suffer from a large search space when decoding with an integrated language model, which can lead to search errors (Chiang, 2005).
P05-1033
The factored translation model combines features in a log-linear fashion (Och, 2003).
P03-1021
David Chiang. 2005. A hierarchical phrase-based mod-
P05-1033
