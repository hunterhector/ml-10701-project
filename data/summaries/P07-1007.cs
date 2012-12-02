This is similar to the approach taken in (Koeling et al., 2005) where they focus on determining the predominant sense of words in corpora drawn from finance versus sports domains.1 Hence, we select the subset of DSO nouns that have at least one synset labeled with any of these domain labels: commerce, enterprise, money, finance, banking, and economy.
H05-1053
Roark. 2003.
N03-1027
For WSD, Fujii et al.(1998) used selective sampling for a Japanese language WSD system, Chen et al.(2006) used active learning for 5 verbs using coarse-grained evaluation, and H.
J98-4002 N06-1016
Following the setup of (Escudero et al., 2000), we similarly made use of the DSO corpus to perform our experiments on domain adaptation.
W00-1322
Using 10%, 20%, and 30% of WSJ adaptation examples to build a classifier, the accuracy of these runs is lower than the active learning a curve and paired t-tests show that the difference is statistically significant at the level of significance 0.01. 6.2 Using Sense Priors Information As mentioned in section 1, research in (Escudero et al., 2000) noted an improvement in accuracy when they adjusted the BC and WSJ datasets such that the proportions of the different senses of each word were the same between BC and WSJ.
W00-1322
Escudero et al.(2000) pointed out that one of the reasons for the drop in accuracy is the difference in sense priors (i.e., the proportions of the different senses of a word) between BC and WSJ.
W00-1322
In (McCarthy et al., 2004), a method was presented to determine the predominant sense of a word in a corpus.
P04-1036
Exploiting the difference in coverage between these two corpora, Escudero et al.(2000) separated the DSO corpus into its BC and WSJ parts to investigate the domain dependence of several WSD algorithms.
W00-1322
Predominant Sense Information Research by McCarthy et al.(2004) and Koeling et al.(2005) pointed out that a change of predominant sense is often indicative of a change in domain.
H05-1053 P04-1036
Roark and Bacchiani (2003) showed that weighted count-merging is a special case of maximum a posteriori (MAP) estimation, and successfully used it for probabilistic context-free grammar domain adaptation (Roark and Bacchiani, 2003) and language model adaptation (Bacchiani and Roark, 2003).
N03-1027
A similar work is the recent research by Chen et al.(2006), where active learning was used successfully to reduce the annotation effort for WSD of 5 English verbs using coarse-grained evaluation.
N06-1016
However, in (Chan and Ng, 2005), we showed that in a supervised setting where one has access to some annotated training data, the EMbased method in section 5 estimates the sense priors more effectively than the method described in (McCarthy et al., 2004).
P04-1036
of Corpus The DSO corpus (Ng and Lee, 1996) contains 192,800 annotated examples for 121 nouns and 70 verbs, drawn from BC and WSJ.
P96-1006
Among the few currently available manually sense-annotated corpora for WSD, the SEMCOR (SC) corpus (Miller et al., 1994) is the most widely used.
H94-1046
Escudero et al.(2000) used the DSO corpus to highlight the importance of the issue of domain dependence of WSD systems, but did not propose methods such as active learning or countmerging to address the specific problem of how to perform domain adaptation for WSD.
W00-1322
Work In applying active learning for domain adaptation, Zhang et al.(2003) presented work on sentence boundary detection using generalized Winnow, while Tur et al.(2004) performed language model adaptation of automatic speech recognition systems.
W03-0408
To investigate this, Escudero et al.(2000) and Martinez and Agirre (2000) conducted experiments using the DSO corpus, which contains sentences from two different corpora, namely Brown Corpus (BC) and Wall Street Journal (WSJ).
W00-1322 W00-1326
These knowledge sources were effectively used to build a state-of-the-art WSD program in one of our prior work (Lee and Ng, 2002).
W02-1006
This is slightly higher than the 5.8 senses per verb in (Chen et al., 2006), where the experiments were conducted using coarse-grained evaluation.
N06-1016
