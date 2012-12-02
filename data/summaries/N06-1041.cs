Adding the BOUNDARY label yields significant improvements, as indicated by the PROTO+SIM+BOUND setting in Table 5.3, surpassing the best unsupervised result of Grenageret al.(2005) which is 72.4%.
P05-1046
Setting Accuracy BASE 46.4 PROTO 53.7 PROTO+SIM 71.5 PROTO+SIM+BOUND 74.1 Figure 7: Results on test set for ads data in (Grenageret al., 2005).
P05-1046
We used a trigramtaggerof the modelform outlinedin section4.1 withthe sameset of spellingfeaturesreportedin SmithandEisner(2005): exactwordtype, 2At each position choosingthe label which has the highest posterior probability, obtained from the forward-backward algorithm.
P05-1044
3 TasksandRelatedWork: Extraction Grenager et al.(2005) presents an unsupervised approach to an information extraction task, called CLASSIFIEDS here,whichinvolvessegmentingclassified advertisements into topical sections (see figure 1(c)).
P05-1046
We believe theperformanceforChinesePOStagging is not as high as English for two reasons: the generaldifficultyof ChinesePOStagging(Tsenget al., 2005)and the lack of a larger segmentedcorpus fromwhichtobuilddistributionalmodels.Nonetheless,theadditionofdistributionalsimilarityfeatures doesreducethe errorrateby 35%from BASE.
I05-3005
Grenager etal.(2005)reportthatinordertolearnthis“sticky” structure, they had to alter the structure of their HMM so that a fixed mass is placed on each diagonal transition.
P05-1046
WhenSmithand Eisner(2005)limittheirtaggingdictionarytowords which occur at least twice, their best performing neighborhoodmodel achieves 79.5%.
P05-1044
On the test set of (Grenager et al., 2005), BASE scored an accuracy of 46.4%, comparable to Grenager et al.(2005)’s unsupervisedHMM baseline.
P05-1046
The best comparison is to Smith and Eisner (2005) who use a partial tagging dictionary.
P05-1044
The partition function is given by Z(θ) = summationdisplay x summationdisplay y nproductdisplay i=1 φ(xi,yi)φ(yi−1,yi) = summationdisplay x summationdisplay y score(x,y) Z(θ) can be computed exactly under certain assumptionsabout the cliquepotentials,but can in all casesbe boundedby ˆZ(θ) = Ksummationdisplay lscript=1 ˆZlscript(θ) = Ksummationdisplay lscript=1 summationdisplay x:|x|=lscript score(x,y) WhereK isasuitablychosenlargeconstant.Wecan efficientlycompute ˆZlscript(θ) for fixed lscript using a generalization of the forward-backward algorithm to the lattice of all observations x of length lscript (see Smith andEisner(2005)for an exposition).
P05-1044
The overall approach of Grenager et al.(2005) typifies the process involved in fully unsupervisedlearning on new domain: they first alter the structure of their HMMsothatdiagonaltransitionsarepreferred,then modify the transition structure to explicitly model boundary tokens, and so on.
P05-1046
Furthermore, our PROTO+SIM+BOUND model comes close to the supervisedHMMaccuracy of 74.4%reported in Grenageret al.(2005). We also compared our method to the most basicsemi-supervisedsetting,wherefullylabeleddocuments are provided along with unlabeled ones.
P05-1046
One recent and much more successful approach to part-of-speechlearningis contrastive estimation, presentedin Smith and Eisner (2005).
P05-1044
When Smith andEisner(2005)includetaggingdictionaryentries forallwordsinthefirsthalfoftheir24Ktokens,givingtaggingknowledgefor3,362wordtypes,theydo achieve a higheraccuracy of 88.1%.
P05-1044
We tested our framework on the CLASSIFIEDS data describedin Grenageret al.(2005)underconditions similarto POS tagging.
P05-1046
Addingdistributionalsimilarityfeaturesto ourmodel(PROTO+SIM) improves accuracy substantially, yielding 71.5%, a 38.4% error reductionover BASE.6 Another feature of this domain that Grenager et al.(2005) take advantage of is that end of sentence punctuation tends to indicate the end of a field and the beginning of a new one.
P05-1046
In syntactic distributional clustering, words are grouped on the basis of the vectors of their preceedingandfollowingwords(Sch¨utze,1995;Clark, 2001).
W01-0713
Grenager et al.(2005)experimentwith manuallyaddingboundary states and biasing transitions from these states to not self-loop.
P05-1046
The model is wholly unmodified from the English version except that the suffix features are removed since, in Chinese, suffixes are not a reliable indicator of part-of-speechas in English (Tseng et al., 2005).
I05-3005
NianwenXueIrcs. 2002.
C02-1145
The starred tokens are the results of collapsing of basic entities during pre-processing as is done in (Grenageret al., 2005) mentsthemodellearnstosegmentwithareasonable matchto the target structure.
P05-1046
