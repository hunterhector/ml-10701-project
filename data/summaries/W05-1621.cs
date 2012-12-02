An additional random baseline is also defined following [Lapata, 2003].
P03-1069
This study employs PF.BFP and PF.KP, i.e. two of the best performing metrics of the experiments in [Karamanis et al., 2004], as well as M.NOCB and PF.NOCB, the two previously used baselines.
P04-1050
Following [Lapata, 2003], the Tukey test is employed to investigate significant differences between average ¿ scores.8 First, the average distance between (the orderings of)9 two experts e.g.
P03-1069
Similarly to standard psycholinguistic experiments, consulting these informants is difficult to extend to a larger corpus like the one used e.g. by [Karamanis et al., 2004] (122 sets of facts).
P04-1050
the BestOrders for each metric Following [Karamanis et al., 2004], we envisage a TS approach in which a metric of coherence M assigns a score to 3Since discussing the metrics in detail is well beyond the scope of this paper, the reader is referred to Chapter 3 of [Karamanis, 2003] for more information on this issue.
P04-1050
Because of its simplicity M.NOCB serves as the first baseline in the experiments of [Karamanis et al., 2004].
P04-1050
PF.BFP which is based on PF as well as the original formulation of CT in [Brennan et al., 1987].
P87-1022
While [Lapata, 2003] always appears to single out a unique best scoring ordering, we often have to deal with many best scoring orderings.
P03-1069
[Karamanis et al., 2004] report that PF.NOCB outperformed M.NOCB but was overtaken by PF.BFP and PF.KP.
P04-1050
The TS module is hypothesised to simply order a preselected set of information-bearing items such as sentences [Barzilay et al., 2002; Lapata, 2003; Barzilay and Lee, 2004] or database facts [Dimitromanolaki and Androutsopoulos, 2003; Karamanis et al., 2004].
N04-1015 P03-1069 P04-1050
Thus, there might exist more than one equally good solution for TS, a view shared by almost all TS researchers, but which has not been accounted for in the evaluation methodologies of [Karamanis et al., 2004] and [Barzilay and Lee, 2004].2 Collecting sentence orderings defined by many experts in our domain enables us to investigate the possibility that there might exist many good solutions for TS.
N04-1015 P04-1050
of coherence [Karamanis, 2003] discusses how a few basic notions of coherence captured by Centering Theory (CT) can be used to define a large range of metrics which might be useful for TS in our domain of interest.3 The metrics employed in the experiments of [Karamanis et al., 2004] include: M.NOCB which penalises NOCBs, i.e. pairs of adjacent facts without any arguments in common [Karamanis and Manurung, 2002].
P04-1050
The next section discusses how the methodology implemented in this study complements the methods of [Karamanis et al., 2004].
P04-1050
4These are distinct from, yet very similar to, the sets of facts used in [Karamanis et al., 2004].
P04-1050
Because the data used in the studies of [Dimitromanolaki and Androutsopoulos, 2003] and [Karamanis et al., 2004] are based on the insights of just one expert, an obvious unresolved question is whether they reflect general strategies for ordering facts in the domain of interest.
P04-1050
As in [Lapata, 2003], the same dependent variable which allows us to estimate how different the orders of E0 are from the orders of her colleagues is used to evaluate some of the metrics which perform best in [Karamanis et al., 2004].
P03-1069 P04-1050
Out of a much larger set of possibilities, 10 metrics were evaluated in [Karamanis et al., 2004], only a handful of which were found to overtake two simple baselines.
P04-1050
[Karamanis et al., 2004] Nikiforos Karamanis, Chris Mellish, Jon Oberlander, and Massimo Poesio.
P04-1050
[Kibble and Power, 2000] Rodger Kibble and Richard Power.
W00-1411
This methodology is very similar to the way [Barzilay and Lee, 2004] evaluate their probabilistic TS model in comparison to the approach of [Lapata, 2003].
N04-1015 P03-1069
References [Barzilay and Lee, 2004] Regina Barzilay and Lillian Lee.
N04-1015
Then, the measure of [Lapata, 2003], which estimates how close two orderings stand, can be employed not only to verify the reliability of E0 but also to compare the orderings preferred by the assumed TS approach with the orderings of the experts.
P03-1069
Based on the argumentation in [Howell, 2002], [Lapata, 2003] selects Kendall’s ¿ as the most appropriate measure and this was what we used for our analysis as well.
P03-1069
[Lapata, 2003] was the first to present an experimental setting which employs the distance between two orderings to estimate automatically how close a sentence ordering produced 1Chapter 9 of [Karamanis, 2003] reports the study in more detail.
P03-1069
Figure 1: MPIRO database facts corresponding to sentences A subset of the corpus created by the expert in the previous study (to whom we will henceforth refer as E0) is employed by [Karamanis et al., 2004] who attempt to distinguish between many metrics of coherence with respect to their usefulness for TS in the same domain.
P04-1050
baseline Following [Lapata, 2003], a random baseline (RB) was implemented as the lower bound of the analysis.
P03-1069
These orderings are then compared with the orders of E0 using the methodology of [Lapata, 2003].
P03-1069
In this paper, we reach a reasonable compromise by showing how the methodology of [Lapata, 2003] supplements the evaluation efforts of [Karamanis et al., 2004] using a similar (yet by necessity smaller) dataset.
P03-1069 P04-1050
The same variable used to investigate the distance between the experts is employed to automatically evaluate the best scoring orderings of some of the best performing metrics in [Karamanis et al., 2004].
P04-1050
As pointed out by [Karamanis, 2003; Barzilay and Lee, 2004] inter alia, using corpora for automatic evaluation is motivated by the fact that employing human informants in extended psycholinguistic experiments is often simply unfeasible.
N04-1015 P04-1050
PF.KP which makes use of PF as well as the recent reformulation of CT in [Kibble and Power, 2000].
W00-1411
[Brennan et al., 1987] Susan E.
P87-1022
In this paper, we assume the socalled search-based approach to TS [Karamanis et al., 2004] which employs a metric of coherence to select a text structure among various alternatives.
P04-1050
[Lapata, 2003] Mirella Lapata.
P03-1069
Rather than comparing the metrics directly with each other (as [Karamanis et al., 2004] do), this study compares them indirectly by examining their behaviour with respect to the upper and the lower bound.
P04-1050
