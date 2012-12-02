Our parser scored 84.4#25 compared with 82.4#25 for #28Hwa, 1998#29, an error reduction of 11#25.
P98-1091
#28This is where the analogy with #28Chelba and Jelinek, 1998#29 breaks down.#29 Thus certain possibilities which were not apparent in a PCFG framework or prohibitively complicated might become simple to implementinaPTAG framework; we conclude by o#0Bering two such possibilities.
P98-1035
One approach, taken in #28Hwa, 1998#29, is to choose some grammar general enough to parse the whole corpus and obtain a maximum-likelihoodestimate by EM.
P98-1091
We use a beam search, computing the score of an item #5B#11;i;j#5D by multiplying it by the prior probability P#28#11#29 #28Goodman, 1997#29; any item with score less than 10,5 times that of the best item in a cell is pruned.
W97-0302
For example, the attachment of an S depends on the presence or absence of the embedded subject #28Collins, 1999#29; Treebank-style two-level NPs are mismodeled by PCFG #28Collins, 1999; Johnson, 1998#29; the generation of a node depends on the label of its grandparent #28Charniak, 2000; Johnson, 1998#29.
A00-2018 J98-4004
a stochastic grammar from the Treebank 4.1 Reconstructing derivations We want to extract from the Penn Treebank an LTAG whose derivations mirror the dependency analysis implicit in the head-percolation rules of #28Magerman, 1995; Collins, 1997#29.
P95-1037 P97-1003
formalism The formalism we use is a variant of lexicalized tree-insertion grammar #28LTIG#29, whichis in turn a restriction of LTAG #28Schabes and Waters, 1995#29.
J95-4002
Magerman. 1995.
P95-1037
We #0Cnd that this induction method is an improvementover the EM-based method of #28Hwa, 1998#29, and that the induced model yields results comparable to lexicalized PCFG.
P98-1091
We #0Crst compared the parser with #28Hwa, 1998#29: we trained the model on sentences of length 40 or less in sections 02#7B09 of the Penn Treebank, down to parts of speech only, and then tested on sentences of length 40 or less in section 23, parsing from part-of-speech tag sequences to fully bracketed parses.
P98-1091
But #28Chelba and Jelinek, 1998#29 chooses the lexical heads of the two previous constituents as determined by a shift-reduce parser, and works better than a trigram model.
P98-1035
With #14 40 words #14 100 words LR LP CB 0CB #14 2CB LR LP CB 0CB #14 2CB #28Magerman, 1995#29 84.6 84.9 1.26 56.6 81.4 84.0 84.3 1.46 54.0 78.8 #28Collins, 1996#29 85.8 86.3 1.14 59.9 83.6 85.3 85.7 1.32 57.2 80.8 present model 86.9 86.6 1.09 63.2 84.3 86.2 85.8 1.29 60.4 81.8 #28Collins, 1997#29 88.1 88.6 0.91 66.5 86.9 87.5 88.1 1.07 63.9 84.6 #28Charniak, 2000#29 90.1 90.1 0.74 70.1 89.6 89.6 89.5 0.88 67.6 87.7 Figure 6: Parsing results.
A00-2018 P95-1037 P96-1025 P97-1003
The ability of probabilistic LTAG to NP NNP John S NP#23 VP VB leave VP MD should VP#03 NP NN tomorrow #28#0B 1 #29 #28#0B 2 #29 #28#0C#29 #28#0D#29 #29 #0B 2 #0B 1 1 #0C 2 #0D 2,1 S NP NNP John VP MD should VP VB leave NP NN tomorrow Figure 1: Grammar and derivation for #5CJohn should leave tomorrow." model bilexical dependencies was noted early on by #28Resnik, 1992#29.
C92-2065
Sister-adjunction is not an operation found in standard de#0Cnitions of TAG, but is borrowed from D-Tree Grammar #28Rambow et al., 1995#29.
P95-1021
Following #28Schabes and Shieber, 1994#29, multiple modi#0Cer trees can be sister-adjoined at a single site, but only one auxiliary tree may be adjoined at a single node.
J94-1004
The parameters of a probabilistic TAG #28Resnik, 1992; Schabes, 1992#29 are: X #0B P i #28#0B#29 = 1 X #0B P s #28#0B j #11#29 = 1 X #0C P a #28#0C j #11#29+P a #28NONE j #11#29 = 1 where #0B ranges over initial trees, #0C over auxiliary trees, #0D over modi#0Cer trees, and #11 over nodes.
C92-2065 C92-2066
We #0Cnd that the automatically-extracted grammar gives an improvementover the EM-based induction method of #28Hwa, 1998#29, and that the parser performs comparably to lexicalized PCFG parsers, though certainly with room for improvement.
P98-1091
Following #28Collins, 1997#29, words occurring fewer than four times in training were replaced with the symbol *UNKNOWN* and tagged with the output of the part-of-speech tagger described in #28Ratnaparkhi, 1996#29.
P97-1003 W96-0213
The backed-o#0B modelsare combined by linear interpolation, with the weights chosen as in #28Bikel et al., 1997#29.
A97-1029
Another approach, taken in #28Magerman, 1995#29 and others for lexicalized PCFGs and #28Neumann, 1998; Xia, 1999; Chen and VijayShanker, 2000#29 for LTAGs, is to use heuristics to reconstruct the derivations,and directlyestimate the PTAG parameters from the reconstructed derivations.
P95-1037
But beginning with #28Magerman, 1995#29 statistical parsers have used bilexical dependencies with great success.
P95-1037
The approach of Chelba and Jelinek #281998#29 to language modeling is illustrative: even though the probability estimate of w appearing as the kth word can be conditioned on the entire history w 1 ;:::;w k,1, the quantity of available training data limits the usable context to about two words|but which two?
P98-1035
