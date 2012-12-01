For a fair comparison, our system was among the best at CoNLL-04, where the best system (Hacioglu et al., 2004) achieve a 69.49 F1 score.
W04-2416
Specifically, we assume as input resources a part-of-speech tagger, a shallow parser that can process the input to the level of based chunks and clauses (Tjong Kim Sang and Buchholz, 2000; Tjong Kim Sang and D´ejean, 2001), and a named-entity recognizer (Tjong Kim Sang and De Meulder, 2003).
W00-0726 W01-0708 W03-0419
The training set is extracted from TreeBank (Marcus et al., 1993) section 15–18, the development set, used in tuning parameters of the system, from section 20, and the test set from section 21.
J93-2004
Learning Architecture The learning algorithm used is a variation of the Winnow update rule incorporated in SNoW (Roth, 1998; Roth and Yih, 2002), a multi-class classifier that is specifically tailored for large scale learning tasks.
C02-1151
In particular, a regularization term is added, which has the effect of trying to separate the data with a thick separator (Grove and Roth, 2001; Hang et al., 2002).
C02-1151
Previous approaches to the SRL task have made use of a full syntactic parse of the sentence in order to define argument boundaries and to determine the role labels (Gildea and Palmer, 2002; Chen and Rambow, 2003; Gildea and Hockenmaier, 2003; Pradhan et al., 2003; Pradhan et al., 2004; Surdeanu et al., 2003).
N04-1030 P02-1031 P03-1002 W03-1006 W03-1008
We take a similar approach that has been previously used for entity/relation recognition (Roth and Yih, 2004), and model this inference procedure as solving an ILP.
W04-2401
Note that the result here is not comparable with the best in this domain (Pradhan et al., 2004) where the full parse tree is assumed given.
N04-1030
