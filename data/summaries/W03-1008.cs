We compare a parser based on Combinatory Categorial Grammar (CCG) (Hockenmaier and Steedman, 2002b) with the Collins parser.
P02-1043
Gildea and Palmer (2002) developed a system to predict semantic roles (as defined in PropBank) from sentences and their parse trees as determined by the statistical parser of Collins (1999).
J02-3001 P02-1031
The impact of our head-word based scoring is analyzed in Table 3, which compares results when only the head word must be correctly identified (as in Table 2) and to results when both the beginning and end of the argument must be correctly identified in the sentence (as in Gildea and Palmer (2002)).
J02-3001 P02-1031
w h c h iw a denied (S[dcl]nNP 1 )=NP 2 1 London denied (S[dcl]nNP 1 )=NP 2 2 plans on ((SnNP 1 )n(SnNP) 2 )=NP 3 2 denied on ((SnNP 1 )n(SnNP) 2 )=NP 3 3 Monday Table 1: CCG predicate-argument relations for the sentence “London denied plans on Monday” The CCG parser has been trained and tested on CCGbank (Hockenmaier and Steedman, 2002a), a treebank of CCG derivations obtained from the Penn Treebank, from which we also obtain our training data.
P02-1043
The PropBank (Kingsbury and Palmer, 2002) and the FrameNet (Baker et al., 1998) projects both document the variation in syntactic realization of the arguments of predicates in general English text.
P98-1013
model of Gildea and Palmer (2002) For the Treebank-based system, we use the probability model of Gildea and Palmer (2002).
J02-3001 P02-1031
The probabilities P(r i jF i ;p) are combined with the probabilities P(fr 1::n gjp) for a set of roles appearing in a sentence given a predicate, using the following formula: P(r 1::n jF 1::n ;p) P(fr 1::n gjp) Y i P(r i jF i ;p) P(r i jp) This approach, described in more detail in Gildea and Jurafsky (2002), allows interaction between the role assignments for individual constituents while making certain independence assumptions necessary for efficient probability estimation.
J02-3001 P02-1031
An interesting experiment would be the application of our role-labeling system to the output of the trace recovery system of Johnson (2002).
P02-1018
Experiments In previous work using the PropBank corpus, Gildea and Palmer (2002) developed a system to predict semantic roles from sentences and their parse trees as determined by the statistical parser of Collins (1999).
J02-3001 P02-1031
