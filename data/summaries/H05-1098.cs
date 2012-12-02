Over the last few years, several automatic metrics for machine translation evaluation have been introduced, largely to reduce the human cost of iterative system evaluation during the development cycle (Lin and Och, 2004; Melamed et al., 2003; Papineni et al., 2002).
J04-4002 N03-2021 N04-1021 P02-1038 P02-1040 P03-1021 P04-1077
up training Chiang (2005) reports on experiments in ChineseEnglish translation using a model trained on 7.2M+9.2M words of parallel data.2 For the NIST MT Eval 2005 large training condition, considerably more data than this is allowable.
P05-1033
(An interactive platform for this analysis is demonstrated by Lopez and Resnik (2005).) 5.2 Chinese We performed tag sequence analysis on the Hiero and Pharaoh systems trained on the FBIS data only.
H05-2007
The basic model uses the following features, analogous to Pharaoh’s default feature set: • P(γ | α) and P(α | γ) • the lexical weights Pw(γ | α) and Pw(α | γ) (Koehn et al., 2003);1 • a phrase penalty exp(1); • a word penalty exp(l), where l is the number of terminals in α.
N03-1017 P03-1040
manila 26 january 6 Conclusions The work reported in this paper extends the original treatment of Hiero (Chiang, 2005) by evaluating an improved version in a community-wide exercise for Chinese-English and Arabic-English translation, and by introducing a novel analysis technique for comparing MT systems’ output.
P05-1033
The feature weights are learned by maximizing the BLEU score (Papineni et al., 2002) on held-out data,usingminimum-error-ratetraining(Och,2003) as implemented by Koehn.
P02-1040 P03-1021
Nonetheless, attempts to incorporate richer linguistic features have generally met with little success (Och et al., 2004a).
J04-4002 N04-1021
DanielMarcuandWilliamWong. 2002.
W02-1018
Fox. 2002.
W02-1039
Hiero is a stochastic synchronous CFG, whose productions are extracted automatically from unannotated parallel texts, and whose rule probabilities form a log-linear model learned by minimum-errorrate training; together with a modified CKY beamsearch decoder (similar to that of Wu (1996)).
P96-1021
Chiang (2005) reported significant performance improvements in Chinese-English translation as compared with Pharaoh, a state-of-the-art phrase-based system (Koehn, 2004).
P05-1033
Third, we computed the correspondence between each hypothesis sentence and each of its corresponding reference sentences using an approximation to maximum matching (Melamed et al., 2003).
N03-2021
First, we describe the addition of two new features to the Chinese model, in a manner similar to that of Och et al.(2004b); then we describe how we scaled the system up to a much larger training set.
J04-4002 N04-1021
The need for some way to model aspects of syntactic behavior, such as the tendency of constituents to move together as a unit, is widely recognized—the role of syntactic units is well attested in recent systematic studies of translation (Fox, 2002; Hwa et al., 2002; Koehn and Knight, 2003), and their absence in phrase-based models is quite evident when looking at MT system output.
N03-1017 P02-1050 P03-1040 W02-1039
(Och and Ney, 2004; Koehnetal.,2003;MarcuandWong,2002))characterize a source sentence f as a flat partition of nonoverlapping subsequences, or “phrases”, ¯f1 ··· ¯fJ, and the process of translation involves selecting target phrases ¯ei corresponding to the ¯fj and modifying their sequential order.
J04-4002 N03-1017 N04-1021 P02-1038 P03-1021 P03-1040 W02-1018
In this paper, we discuss a new hierarchical phrase-based statistical machine translation system (Chiang, 2005), presenting recent extensions to the original proposal, new evaluation results in a community-wide evaluation, and a novel technique for fine-grained comparative analysis of MT systems.
P05-1033
We used MXPOST (Ratnaparkhi, 1996), and in order to discover more general patterns, we map the tag set down after tagging, e.g.
W96-0213
782 5.1 A New Analysis Method In developing a new analysis method, we are motivated in part by recent studies suggesting that word reorderings follow general patterns with respect to syntax, although there remains a high degree of flexibility (Fox, 2002; Hwa et al., 2002).
P02-1050 W02-1039
Unfortunately, recent work has shown that applying statistical parsers to ungrammatical MT output is unreliable at best, with the parser often assigning unreasonable probabilities and incongruent structure (Yamada and Knight, 2002; Och et al., 2004a).
J04-4002 N04-1021 P02-1039
Since one of these filters restricts the number of nonterminal symbols to two, our extracted grammar is equivalent to an inversion transduction grammar (Wu, 1997).
J97-3002
The model is a log-linear model (Och and Ney, 2002) over synchronous CFG derivations.
P02-1038
Training begins with phrase pairs, obtained as by Och, Koehn, and others: GIZA++ (Och and Ney, 2000) is used to obtain one-to-many word alignments in both directions, which are combined into a singlesetofrefinedalignmentsusingthe“final-and” method of Koehn et al.(2003); then those pairs of substrings that are exclusively aligned to each other are extracted as phrase pairs.
N03-1017 P00-1056 P03-1040
The lexical-weighting features are estimated using a method similar to that of Koehn et al.(2003). The language model is a trigram model with modified Kneser-Ney smoothing (Chen and Goodman, 1998), trained using the SRI-LM toolkit (Stolcke, 2002).
N03-1017 P03-1040
Chiang (2005) introduces Hiero, a hierarchical phrase-based model for statistical machine translation.
P05-1033
