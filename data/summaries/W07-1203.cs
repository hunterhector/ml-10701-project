work In their psychological study, Clark and Krych (2004) showed that speakers alter their utterances midcourse while monitoring not only the listener?s vocal signals, but also the listener?s gestural signals as well as through other mutually visible events.
P04-1014
In Clark and Curran (2004b) we use a cluster of 45 machines, together with a parallel implementation of BFGS, to solve this problem, but need up to 20 GB of RAM.
P04-1014
For the log-linear parsing model in Clark and Curran (2004b), the inside-outside algorithm is used to calculate feature expectations, which are then used by the BFGS algorithm to optimise the likelihood function.
P04-1014
We use the same feature representation (x,y) as in Clark and Curran (2004b), to allow comparison with the log-linear model.
P04-1014
2.2 Log-linear models for disambiguation Since Johnson et al.(1999), log-linear models of the following form have become standard as disambiguation devices for precision grammars: P(x|y) = e summationtextm j=1 jfj(x,y) summationtext xprime?X(y) e summationtextm j=1 jfj(xprime,y) They are used for parse selection in the English Resource Grammar (Toutanova et al., 2002), the English ParGram LFG (Riezler et al., 2002), the English Enju HPSG (Miyao and Tsujii, 2002), the HPSG-inspired Alpino parser for Dutch (Malouf and van Noord, 2004; van Noord, 2006) and the English CCG from Edinburgh (Clark and Curran, 2004).
P02-1035 P04-1014 P99-1069
We use a lexicalized phrase-structure parser, the CCG parser of Clark and Curran (2004b), together with a DP-based decoder.
P04-1014
used properties for disambiguation The first set of properties with which we conducted experiments was built on the model of the property set used for the disambiguation of English ParGram LFG parses (Riezler et al., 2002; Riezler and Vasserman, 2004).
P02-1035
By demonstrating that property design is the key to good log-linear models for ?deep??syntactic disambiguation, our work confirms that ?specifying the features of a SUBG [stochastic unification-based grammar] is as much an empirical matter as specifying the grammar itself??(Johnson et al., 1999).
P99-1069
Supertagging has been especially successful for CCG: Clark and Curran (2004a) demonstrates the considerable increases in speed that can be obtained through use of a supertagger.
P04-1014
A feature forest is essentially a packed chart with only the feature information retained (see Miyao and Tsujii (2002) and Clark and Curran (2004b) for the details).
P04-1014
Previous discriminative models for CCG (Clark and Curran, 2004b) required cluster computing resources to train.
P04-1014
In Clark and Curran (2004b) we use a cluster of 45 machines, together with a parallel implementation of the BFGS training algorithm, to solve this problem.
P04-1014
The CCG supertagger (Clark, 2002; Clark and Curran, 2004) was provided with the C&C Language Processing Tools3.
P04-1014
Our error reduction of 51.0% also compares favorably to the 36% error reduction on English LFG parses reported in Riezler et al.(2002). However, it is considerably lower than the error reduction of 78% reported for the Dutch Alpino parser (Malouf and van Noord, 2004), but this may be due to the fact that our lower bound is calculated on the basis of analyses that have already passed a prefilter and is thus relatively high.
P02-1035
Clark and Curran (2004a) also shows how the supertagger can reduce the size of the packed charts to allow discriminative log-linear training.
P04-1014
The key idea is to exploit the properties of lexicalized grammars by using a finite-state supertagger prior to parsing (Bangalore and Joshi, 1999; Clark and Curran, 2004a).
P04-1014
The part-of-speech tagging uses the Curran and Clark POS tagger (Curran and Clark, 2003) trained on MedPost data (Smith et al., 2004), whilst the other preprocessing stages are all rule based.
P04-1014
For sentences out of coverage, it employs the robustness techniques (fragment parsing, ?skimming?? implemented in XLE and described in Riezler et al.(2002), so that 100% of our corpus sentences receive at least some sort of analysis.
P02-1035
In taskmanipulation situations where the listener manipulates objects by following the speaker?s instructions, correct task manipulation by the listener serves as more direct evidence of understanding (Brennan 2000, Clark and Krych 2004), and affects the speaker?s dialogue control strategies.
P04-1014
This report uses an iterative procedure to demonstrate that what appears to be near magical could result mostly from mechanisms that do not require the existence of innate principles of grammar, as they are based on children?s inherent capacities for perception, 7; Saffran, Johnson, Aslin, & Newport, 1999).
P99-1069
A recent development in data-driven parsing is the use of discriminative training methods (Riezler et al., 2002; Taskar et al., 2004; Collins and Roark, 2004; Turian and Melamed, 2006).
P02-1035
A dependency-based evaluation of the analyses produced by the grammar on the TiGer Dependency Bank (Forst et al., 2004) results in an F-score between 80.42% on all gram17 matical relations and morphosyntactic features (or 72.59% on grammatical relations only) and 85.50% (or 79.36%).
W04-1905
Following Clark and Curran (2004b), accuracy is measured using F-score over the goldstandard predicate-argument dependencies in CCGbank.
P04-1014
Clark and Curran (2004b) describe how a set of CCG derivations can be represented as a feature forest.
P04-1014
We applied the same normal-form restrictions used in Clark and Curran (2004b): categories can 12 only combine if they have been seen to combine in Sections 2-21 of CCGbank, and only if they do not violate the Eisner (1996a) normal-form constraints.
P04-1014
One popular approach is to use a log-linear parsing model and maximise the conditional likelihood function (Johnson et al., 1999; Riezler et al., 2002; Clark and Curran, 2004b; Malouf and van Noord, 2004; Miyao and Tsujii, 2005).
P02-1035 P04-1014 P99-1069
In Clark and Curran (2004b) we use cluster computing resources to solve this problem.
P04-1014
CCG Parser Clark and Curran (2004b) describes the CCG parser.
P04-1014
