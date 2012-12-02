The deterministic shift/reduce classifier-based dependency parsing approach (Nivre and Scholz, 2004) has been shown to offer state-of-the-art accuracy (Nivre et al., 2006) with high efficiency due to a greedy search strategy.
C04-1010 W06-2933
In addition, the HPSG grammar is extracted from the HPSG Treebank using a corpusbased procedure, and it does not necessarily cover all possible grammatical phenomena in unseen text (Miyao and Tsujii, 2005).
P05-1011
Using the extremely lexicalized framework of (Ninomiya et al., 2006) by performing supertagging before parsing, we obtain similar accuracy as Ninomiya et al.(87.1% LP and 85.9% LR).
W06-1619
Our baseline approach outperformed previously published results on this test 4The accuracy figures for the dependency parsers is expressed as unlabeled accuracy of the surface dependencies only, and are not comparable to the HPSG parsing accuracy figures 629 Parser LP LR F-score HPSG Baseline 87.4 87.0 87.2 Shift-Reduce + HPSG 88.2 87.7 87.9 C1 + HPSG 88.5 88.0 88.2 C2 + HPSG 88.4 87.9 88.1 Baseline(gold) 89.8 89.4 89.6 Shift-Reduce(gold) 90.62 90.23 90.42 C1+HPSG(gold) 90.9 90.4 90.6 C2+HPSG(gold) 90.8 90.4 90.6 Miyao and Tsujii, 2005 85.0 84.3 84.6 Ninomiya et al., 2006 87.4 86.3 86.8 Table 2: Final results on test set.
P05-1011 W06-1619
Several efficient, accurate and robust approaches to data-driven dependency parsing have been proposed recently (Nivre and Scholz, 2004; McDonald et al., 2005; Buchholz and Marsi, 2006) for syntactic analysis of natural language using bilexical dependency relations (Eisner, 1996).
C04-1010 C96-1058 H05-1066 W06-2920 W06-2933
The disambiguation model of this parser is based on a maximum entropy model (Berger et al., 1996).
J96-1002
We created a dependency training corpus based on the Penn Treebank (Marcus et al., 1993), or more specifically on the HPSG Treebank generated from the Penn Treebank (see section 2.2).
J93-2004
In the second approach, combination of 3Downloadedfromhttp://sourceforge.net/projects/mstparser the three dependency parsers is done according to the maximum spanning tree combination scheme of Sagae and Lavie (2006), which results in high accuracy of surface dependencies.
N06-2033
In this paper, we use an HPSG parser developed by Miyao and Tsujii (2005).
P05-1011
The second parser is MSTParser, the large-margin maximum spanning tree parser described in (McDonald et al., 2005)3.
H05-1066
To illustrate how this framework allows for improvements in the accuracy of dependency parsing to be used directly to improve the accuracy of HPSG parsing, we showed that by combining the results of different dependency parsers using the search-based parsing ensemble approach of (Sagae and Lavie, 2006), we obtain improved HPSG parsing accuracy as a result of the improved dependency accuracy.
N06-2033
Curran and Vadas, 2006) is used, instead of hard assignment of single tags in a preprocessing step as done here.
P06-1088
This has been found to work well in previous work on dependency parser combination (Zeman and ˇZabokrtsk´y, 2005; Sagae and Lavie, 2006).
N06-2033 W05-1518
constraints with dependency parser combination Parser combination has been shown to be a powerful way to obtain very high accuracy in dependency parsing (Sagae and Lavie, 2006).
N06-2033
The probability p(T|W) of an HPSG parse tree T for the sentence W = 〈w1,...,wn〉 is given as: p(T|W) = p(T|L,W)p(L|W) = 1Z exp parenleftBiggsummationdisplay i λifi(T) parenrightBiggproductdisplay j p(lj|W), where L = 〈l1,...,ln〉 are lexical entries and 625 p(li|W) is the supertagging probability, i.e., the probability of assignining the lexical entry li to wi (Ninomiya et al., 2006).
W06-1619
1The extraction software can be obtained from http://wwwtsujii.is.s.u-tokyo.ac.jp/enju. 627 4.1 Baseline HPSG parsing results using the same HPSG grammar and treebank have recently been reported by Miyao and Tsujii (2005) and Ninomia et al.(2006). ByrunningtheHPSGparserdescribedinsection2.2 on the development data without dependency constraints, we obtain similar values of LP (86.8%) and LR (85.6%) as those reported by Miyao and Tsujii (Miyao and Tsujii, 2005).
P05-1011
We evaluate the accuracy of HPSG parsing with dependencyconstraintsontheHPSGTreebank(Miyao et al., 2003), which is extracted from the Wall Street Journal portion of the Penn Treebank (Marcus et al., 1993)1.
J93-2004
Our final results are shown in table 2, where we also include the results published in (Ninomiya et al., 2006) for comparison purposes, and the result of using dependency constraints obtained with gold standard POS tags.
W06-1619
Additionally, our approach is in many ways similar to supertagging (Bangalore and Joshi, 1999), which uses sequence labeling techniques as an efficient way to pre-compute parsing constraints (specifically, the assignment of lexical entries to input words).
J99-2004
work There are other approaches that combine shallow processing with deep parsing (Crysmann et al., 2002; Frank et al., 2003; Daum et al., 2003) to improve parsing efficiency.
E03-1052 P02-1056 P03-1014
At the same time, there is growing interest in parsing with more sophisticated lexicalized grammar formalisms, such as Lexical Functional Grammar (LFG) (Bresnan, 1982), Lexicalized Tree Adjoining Grammar (LTAG) (Schabes et al., 1988), Headdriven Phrase Structure Grammar (HPSG) (Pollard and Sag, 1994) and Combinatory Categorial Grammar (CCG) (Steedman, 2000), which represent deep syntactic structures that cannot be expressed in a shallower formalism designed to represent only aspects of surface syntax, such as the dependency formalism used in current mainstream dependency parsing.
C88-2121
Given the HPSG treebank as training data, the model parametersλi are estimated so as to maximize the log-likelihood of the training data (Malouf, 2002).
W02-2018
This is done by training a classifier to determine parser actions based on local features that represent the current state of the parser (Nivre and Scholz, 2004; Sagae and Lavie, 2005).
C04-1010 W05-1513
