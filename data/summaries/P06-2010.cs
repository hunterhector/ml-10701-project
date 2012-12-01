In order to speed up the learning process, we use a four-stage learning architecture: Stage 1: To save time, we use a pruning stage (Xue and Palmer, 2004) to filter out the constituents that are clearly not semantic arguments to the predicate.
W04-3212
In this paper, we decompose the Moschitti (2004)’s predicate-argument feature (PAF) kernel into a Path kernel and a Constituent Structure ker1http://www.cs.unt.edu/∼rada/senseval/senseval3/ 73 nel, and then compose them into a hybrid convolution tree kernel.
P04-1043
The data consist of sections of the Wall Street Journal (WSJ) part of the Penn TreeBank (Marcus et al., 1993), with information on predicate-argument structures extracted from the PropBank corpus (Palmer et al., 2005).
J05-1004 J93-2004
Many researchers (Gildea and Jurafsky, 2002; Pradhan et al., 2005a) use feature-based methods Figure 1: Semantic role labeling in a phrase structure syntactic tree representation for argument identification and classification in building SRL systems and participating in evaluations, such as Senseval-3 1, CoNLL-2004 and 2005 shared tasks: SRL (Carreras and M`arquez, 2004; Carreras and M`arquez, 2005), where a flat feature vector is usually used to represent a predicate-argument structure.
J02-3001 P02-1031 P05-1072 W04-2412 W05-0620
In addition, Moschitti (2004)’s Tree Kernel Tool is used to compute the tree kernel function.
P04-1043
In the context of convolution kernels, more and more kernels for restricted syntaxes or specific domains, such as string kernel for text categorization (Lodhi et al., 2002), tree kernel for syntactic parsing (Collins and Duffy, 2001), kernel for relation extraction (Zelenko et al., 2003; Culotta and Sorensen, 2004) are proposed and explored in NLP domain.
P04-1054
They used a linear interpolation method and extract features from a parse tree to identify and classify the constituents in the FrameNet (Baker et al., 1998) with syntactic parsing results.
P98-1013
Most of the following works focused on feature engineering (Xue and Palmer, 2004; Jiang et al., 2005) and machine learning models (Nielsen and Pradhan, 2004; Pradhan et al., 2005a).
J05-1004 P05-1072 W04-3211 W04-3212
Convolution Tree Kernels for SRL In this section, we introduce the previous kernel method for SRL in Subsection 4.1, discuss our method in Subsection 4.2 and compare our method with previous work in Subsection 4.3. 4.1 Convolution Tree Kernels for SRL Moschitti (2004) proposed to apply convolution tree kernels (Collins and Duffy, 2001) to SRL.
P04-1043
Figure 1 shows an example of a semantic role labeling annotation in PropBank (Palmer et al., 2005).
J05-1004
The same as Moschitti (2004), we also set the µ = 0.4 in the computation of convolution tree kernels.
P04-1043
On the other hand, the previous researches (Gildea and Palmer, 2002; Punyakanok et al., 2005) have also recognized the 74                       Figure 2: Predicate Argument Feature space necessity of syntactic parsing for semantic role labeling.
J02-3001 J05-1004 P02-1031
In addition Moschitti (2004) only study the task of argument classification while in our experiment, we report the experimental results on both identification and classification.
P04-1043
Stage 4: A rule-based post-processing stage (Liu et al., 2005) is used to handle some unmatched arguments with constituents, such as AM-MOD, AM-NEG.
W05-0627
Table 3 compares the performance comparison among our Hybrid convolution tree kernel, Moschitti (2004)’s PAF kernel, standard flat features with Linear kernels, and Poly kernel (d = 2).
P04-1043
Setting 5.1.1 Corpus We use the benchmark corpus provided by CoNLL-2005 SRL shared task (Carreras and M`arquez, 2005) provided corpus as our training, development, and test sets.
W05-0620
Work Automatic semantic role labeling was first introduced by Gildea and Jurafsky (2002).
J02-3001 P02-1031
Our method is similar to the Moschitti (2004)’s predicate-argument feature (PAF) kernel.
P04-1043
Train Devel tWSJ tBrown Sentences 39,832 1,346 2,416 426 Tokens 950,028 32,853 56,684 7,159 Propositions 90,750 3,248 5,267 804 Arguments 239,858 8,346 14,077 2,177 Table 2: Counts on the data set The preprocessing modules used in CONLL2005 include an SVM based POS tagger (Gim´enez and M`arquez, 2003), Charniak (2000)’s full syntactic parser, and Chieu and Ng (2003)’s Named Entity recognizer.
A00-2018 W03-0423
Moschitti (2004) only selected the relative portion between a predicate and an argument.
P04-1043
Their features are usually extended from Gildea and Jurafsky (2002)’s work, which uses flat information derived from a parse tree.
J02-3001 P02-1031
Some other works paid much attention to the robust SRL (Pradhan et al., 2005b) and post inference (Punyakanok et al., 2004).
C04-1197 P05-1072
Of special interest here, Moschitti (2004) proposed Predicate Argument Feature (PAF) kernel under the framework of convolution tree kernel for SRL.
P04-1043
