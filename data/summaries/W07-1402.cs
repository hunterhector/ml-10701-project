The primary linguistic analysis components are the probabilistic LFG grammar for English developed at PARC (Riezler et al., 2002), and a combination of systems for frame semantic annotation: the probabilistic Shalmaneser system for frame and role annotation (Erk and Pado, 2006), and the rule-based Detour system for frame assignment (Burchardt et al., 2005).
P02-1035
This was done to some extent in Riezler et al.(2002) to automatically generate training data for the log-linear disambiguation component of XLE.
P02-1035
There is no direct connection between these different verbs in the ERG lexicon, even though they are intuitively related and are listed as belonging to the same or related word classes in semantic lexicons/ontologies such as VerbNet (Kipper et al., 2000) and FrameNet (Baker et al., 1998).
P98-1013
Our generic senses have been inspired by FrameNet (Baker et al., 1998).
P98-1013
Our error reduction of 51.0% also compares favorably to the 36% error reduction on English LFG parses reported in Riezler et al.(2002). However, it is considerably lower than the error reduction of 78% reported for the Dutch Alpino parser (Malouf and van Noord, 2004), but this may be due to the fact that our lower bound is calculated on the basis of analyses that have already passed a prefilter and is thus relatively high.
P02-1035
For the experiments reported in this paper, we parsed the source language side of a parallel corpus (a small subsection of the English-German Europarl corpus; (Koehn, 2002)) with the XLE system, using 36 the ParGram LFG grammar and applying probabilistic disambiguation (Riezler et al., 2002) to obtain a single analysis (i.e., a c-structure [phrase structure tree] and an f-structure [an associated attributevalue matrix with morphosyntactic feature information and a shallow semantic interpretation]) for each sentence.
P02-1035
This paper illustrates the above claims with respect to three lexical resources ??FrameNet (Baker et al., 1998), PropBank (Palmer et al., 2005) and VerbNet (Schuler, 2005) ??that convey information about lexical predicates and their arguments.
P98-1013
The observation that standard logical entailment and textual entailment deviate in certain respects is not surprising and has also been addressed in a discussion initiated by (Zaenen et al., 2005).
W05-1206
Our syntax relies on a frame-based design in the LF ontology, a common representation in semantic lexicons (Baker et al., 1998, Kipper et al., 2000).
P98-1013
A similar approach has also been reported in (Johnson et al., 1999; Riezler et al., 2002; Malouf and van Noord, 2004).
P02-1035
This approach significantly outperforms the multi-class perceptron on the same dataset based on WORDNET 1.6 and 1.7.1. 1 Introduction Lexical-semantic resources have been applied successful to a wide range of Natural Language Processing (NLP) problems ranging from collocation extraction (Pearce, 2001) and class-based smoothing (Clark and Weir, 2002), to text classification (Baker and McCallum, 1998) and question answering (Pasca and Harabagiu, 2001).
P98-1013
For instance, (Riezler et al., 2002) uses the fewest chunk method to choose the best fragment analyses for sentences without full analysis.
P02-1035
XLE selects the most probable analysis from the potentially large candidate set by means of a stochastic disambiguation component based on a log-linear probability model (Riezler et al., 2002) that works on the packed representations.
P02-1035
2.2 Log-linear models for disambiguation Since Johnson et al.(1999), log-linear models of the following form have become standard as disambiguation devices for precision grammars: P(x|y) = e summationtextm j=1 jfj(x,y) summationtext xprime?X(y) e summationtextm j=1 jfj(xprime,y) They are used for parse selection in the English Resource Grammar (Toutanova et al., 2002), the English ParGram LFG (Riezler et al., 2002), the English Enju HPSG (Miyao and Tsujii, 2002), the HPSG-inspired Alpino parser for Dutch (Malouf and van Noord, 2004; van Noord, 2006) and the English CCG from Edinburgh (Clark and Curran, 2004).
P02-1035
For sentences out of coverage, it employs the robustness techniques (fragment parsing, ?skimming?? implemented in XLE and described in Riezler et al.(2002), so that 100% of our corpus sentences receive at least some sort of analysis.
P02-1035
used properties for disambiguation The first set of properties with which we conducted experiments was built on the model of the property set used for the disambiguation of English ParGram LFG parses (Riezler et al., 2002; Riezler and Vasserman, 2004).
P02-1035
One popular approach is to use a log-linear parsing model and maximise the conditional likelihood function (Johnson et al., 1999; Riezler et al., 2002; Clark and Curran, 2004b; Malouf and van Noord, 2004; Miyao and Tsujii, 2005).
P02-1035
The SALSA RTE system is based on three main components: (i) a linguistic analysis of text and hypothesis based primarily on LFG and Frame Semantics (Baker et al., 1998), (ii) the computation of a match graph that encodes the semantic overlap between text and hypothesis, and (iii) a statistical entailment decision.
P98-1013
Setup Experiments aimed at extracting protein-protein interactions for Bakers yeast (Sacharomyces Cerevesiae) to assess BioNoculars (Cherry et al., 1998).
P98-1013
A recent development in data-driven parsing is the use of discriminative training methods (Riezler et al., 2002; Taskar et al., 2004; Collins and Roark, 2004; Turian and Melamed, 2006).
P02-1035
