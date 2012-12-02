In fact (Williams et al., 2004) and (Baldewein et al., 2004) even improved the results on the test set.
W04-2413 W04-2422
The system of Park et al.(2004) also tracks the number of different syntactic elements found between the pair.
W04-2420
It has become very clear that a good election for this problem is phrase-byphrase processing (P-by-P, using the notation introduced by Hacioglu et al.(2004)) instead of word-by-word (Wby-W).
W04-2416
The system by Baldewein et al.(2004) works with a bit more general elements called “chunk sequences”, extracted in a preprocess using heuristic rules.
W04-2413
At this point, the system of Punyakanok et al.(2004) deserves special consideration, since it formally implements a set of structural and linguistic constraints directly in the global cost function to maximize.
W04-2421
Two other groups applied Memory-Based Learning (MBL) (van den Bosch et al., 2004; Kouchnir, 2004).
W04-2414 W04-2418
Chunker and Clause Recognizer: (Carreras and M`arquez, 2003), based on Voted Perceptrons, and following the CoNLL settings of 2000 and 2001 tasks (Tjong Kim Sang and Buchholz, 2000; Tjong Kim Sang and D´ejean, 2001).
W00-0726 W01-0708
As an exception to the general approach, the system of Williams et al.(2004) does not make use of word forms.
W04-2422
Two teams used the Maximum Entropy (ME) statistical framework (Baldewein et al., 2004; Lim et al., 2004).
W04-2413 W04-2419
The iterative classifier stacking mechanism used by van den Bosch et al.(2004) also tries to alleviate the problem of locality of the low-level classifiers.
W04-2414
As a variant of the first two-phase strategy, van den Bosch et al.(2004) first perform a direct classification of chunks into argument labels, and then decide the actual arguments in a post-process by joining previously classified argument fragments.
W04-2414
Concerning lexicalization of the argument, most of the techniques rely on head word rules based on Collins’, or content word rules as in Surdeanu et al.(2003). Only Carreras et al.(2004) decide to use a bag-of-words model, apart from heuristicbased lexicalization.
P03-1002 W04-2415
Two teams used Brill’s Transformation-based Error-driven Learning (TBL) (Higgins, 2004; Williams et al., 2004).
W04-2417 W04-2422
The best system, presented by the most experienced group on the task (Hacioglu et al., 2004), achieved a moderate performance of 69.49 at the F1 measure.
W04-2416
Similar in expressiveness, the system designed by Punyakanok et al.(2004) expanded the feature space with all pairs of basic features.
W04-2421
Additionally, the team of Baldewein et al.(2004) used a EM–based clustering algorithm for feature development (see section 4.3).
W04-2413
derived from the basic information are strongly inspired by previous works on the SRL task (Gildea and Jurafsky, 2002; Surdeanu et al., 2003; Pradhan et al., 2003a).
J02-3001 P02-1031 P03-1002 W03-1008
The remaining four teams employed vector-based linear classifiers of different types: Hacioglu et al.(2004) and Park et al.(2004) used Support Vector Machines (SVM) with polynomial kernels, Carreras et al.(2004) used Voted Perceptrons (VP) also with polynomial kernels, and finally, Punyakanok et al.(2004) used SNoW, a Winnow-based network of linear separators.
W04-2415 W04-2416 W04-2420 W04-2421
The data consists of six sections of the Wall Street Journal part of the Penn Treebank (Marcus et al., 1993), and follows the setting of past editions of the CoNLL shared task: training set (sections 15-18), development set (section 20) and test set (section 21).
J93-2004
Carreras et al.(2004) and Punyakanok et al.(2004) also define a global scoring function to maximize.
W04-2415 W04-2421
Named entities with (Chieu and Ng, 2003), based on Maximum-Entropy classifiers, and following the CoNLL-2003 task setting (Tjong Kim Sang and De Meulder, 2003).
W03-0419 W03-0423
1CoNLL-2004 Shared Task web page —with data, software and systems’ outputs available— at http://cnts.uia.ac.be/conll2004/roles. Regarding the learning component of the systems, we find pure probabilistic models (Gildea and Jurafsky, 2002; Gildea and Palmer, 2002; Gildea and Hockenmaier, 2003), Maximum Entropy (Fleischman et al., 2003), generative models (Thompson et al., 2003), Decision Trees (Surdeanu et al., 2003; Chen and Rambow, 2003), and Support Vector Machines (Hacioglu and Ward, 2003; Pradhan et al., 2003a; Pradhan et al., 2003b).
J02-3001 N03-2009 P02-1031 P03-1002 W03-1006 W03-1007 W03-1008
As an exception, van den Bosch et al.(2004) applied a 3Arguments in data do not embed, though format allows so.
W04-2414
For instance, in (Pradhan et al., 2003a; Hacioglu and Ward, 2003), a SVM-based SRL system is devised which performs an IOB sequence tagging using only shallow syntactic information at the level of phrase chunks.
N03-2009
Remarkably, the system of Baldewein et al.(2004) uses an EM clustering technique to derive features representing the affinity of an argument and a predicate.
W04-2413
However, some of the systems restrict the search for arguments only to the immediate clause (Park et al., 2004; Williams et al., 2004) and others use the clause hierarchy to guide the exploration of the sentence (Lim et al., 2004; Carreras et al., 2004).
W04-2415 W04-2419 W04-2420 W04-2422
Interestingly, the system of Lim et al.(2004) represents the context of an argument relative to the syntactic hierarchy by means of relative constituent sequences and syntactic levels.
W04-2419
An exception is the system of Carreras et al.(2004), which performs the annotation of all propositions simultaneously.
W04-2415
The systems working with Maximum Entropy Models (Baldewein et al., 2004; Lim et al., 2004) use beam search to find taggings that maximize the probability of the output sequence.
W04-2413 W04-2419
The best performance was obtained by the SVMbased IOB tagger of (Hacioglu et al., 2004), which almost reached the performance of 70 in F1 on the test.
W04-2416
