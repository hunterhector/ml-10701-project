We used as a target dataset the PropBank corpus available at www.cis.upenn.edu/∼ace, along with the Penn TreeBank 2 for the gold trees (www.cis.upenn.edu/∼treebank)(Marcusetal., 1993), which includes about 53,700 sentences.
J93-2004
A lot of attention has been recently devoted to the design of systems for the automatic labeling of semantic roles (SRL) as defined in two important projects: FrameNet (Johnson and Fillmore, 2000), inspired by Frame Semantics, and PropBank (Kingsbury and Palmer, 2002) based on Levin’s verb classes.
A00-2008
on complete predicate argument structures The type of a target argument strongly depends on the type and number of the predicate’s arguments1 (Punyakanok et al., 2005; Toutanova et al., 2005).
P05-1073
set up The empirical evaluations were carried out within the setting defined in the CoNLL-2005 Shared Task (Carreras and M`arquez, 2005).
W05-0620
Usually the combination of two traditional systems (based on the same machine learning model) does not result in an improvement as their features are more or less equivalent as shown in (Carreras and M`arquez, 2005).
W05-0620
The experiments were carried out with the SVM-light-TK software available at http://ai-nlp.info.uniroma2.it/moschitti/ which encodes fast tree kernel evaluation (Moschitti, 2006) in the SVM-light software (Joachims, 1999).
E06-1015
This latter is equal to the number of common fragments rooted at nodes n1 and n2 and, according to (Collins and Duffy, 2002), it can be computed as follows: 1.
P02-1034
A careful analysis of such features reveals that most of them are syntactic tree fragments of training sentences, thus a natural way to represent them is the adoption of tree kernels as described in (Moschitti, 2004).
P04-1043
Finally, as CoNLL 2005 has shown that the most important contribution relates on re-ranking predicate argument structures based on one single tree (Toutanova et al., 2005) or several trees (Punyakanok et al., 2005), we would like to use tree kernels for the re-ranking task.
P05-1073
The approach proposed in (Moschitti, 2004) selects the minimal subtree that includes a predicate with its argument.
P04-1043
In this paper, we carry out tree kernel engineering (Moschitti et al., 2005) to increase both accuracy and speed of the boundary detection and argument classification phases.
W05-0407
We used a regularization parameter (option -c) equal to 1 and λ = 0.4 (see (Moschitti, 2004)).
P04-1043
Such approach is in linewithcurrentresearchontheuseoftreekernels for natural language learning, e.g. syntactic parsing re-ranking (Collins and Duffy, 2002), relation extraction (Zelenko et al., 2003) and named entity recognition (Cumby and Roth, 2003; Culotta and Sorensen, 2004).
P02-1034 P04-1054
Moreover, as shown in (Basili and Moschitti, 2005; Moschitti, 2006), there are other tree kernel functions that generate different fragment types.
E06-1015 W05-0407
Phrase Type, Predicate Word, Head Word, Governing Category, Position andVoiceproposedin(GildeaandJurasfky, 2002).
J02-3001
SRL approach The SRL approach that we adopt is based on the deep syntactic parse (Charniak, 2000) of the sentence that we intend to annotate semantically.
A00-2018
For example, the earlier studies concerning linguistic features suitable for semantic role labeling were carried out in (Gildea and Jurasfky, 2002).
J02-3001
(Xue and Palmer, 2004) or (Carreras and M`arquez, 2005).
W04-3212 W05-0620
Regarding the use of tree kernels for SRL, in (Moschitti, 2004) two main drawbacks have been 49 pointed out: • Highly accurate boundary detection cannot be carried out by a tree kernel model since correct and incorrect arguments may share a large portion of the encoding trees, i.e. they may share many substructures.
P04-1043
