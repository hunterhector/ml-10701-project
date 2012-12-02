2° TnT is a trigram tagger (Brants 2000), which means that it considers the previous two tags as features for deciding on the current tag.
A00-1031
Probabilistic Voting One of the best methods for tagger combination in (van Halteren, Zavrel, and Daelemans 1998) is the TagPair method.
P98-1081
WPDV has since evolved, using more parameters and more involved weighting schemes, and also been tested on tasks other than tagger combination (van Halteren 2000a, 2000b).
W00-0724 W00-0734
As we now apply the methods of van Halteren, Zavrel, and Daelemans (1998) to WSJ as well, it is easier to make a comparison.
P98-1081
Ratnaparkhi 1996).
W96-0213
Furthermore, the Wotan tagset is a very detailed one, so that the error rate of the individual taggers 9 Compare this to the "tune" set in van Halteren, Zavrel, and Daelemans (1998).
P98-1081
The first is the LOB corpus (Johansson 1986), which we used in the earlier experiments as well (van Halteren, Zavrel, and Daelemans 1998) and which has proved to be a good testing ground.
P98-1081
The material is tagged with the Penn Treebank tagset (Marcus, Santorini, and Marcinkiewicz 1993), which is much smaller than the LOB one.
J93-2004
Tagging can also be done using maximum entropy modeling (see Section 2.4): a maximum entropy tagger, called MXPOST, was developed by Ratnaparkhi (1996) (we will refer to this tagger as MXP below).
W96-0213
For example, Rigau, Atserias, and Agirre (1997) combine different heuristics for word sense disambiguation by voting, and Agirre et al.(1998) do the same for spelling correction evaluation heuristics.
P97-1007 P98-1003
In Chen, Bangalore, and Vijay-Shanker (1999), classifier combination is used to overcome the sparse data problem when using more contextual information in supertagging, an approach in which parsing is reduced to tagging with a complex tagset (consisting of partial parse trees associated with lexical items).
E99-1025
In van Halteren, Zavrel, and Daelemans (1998) we used a straightforward implementation of HMM's, which turned out to have the worst accuracy of the four competing methods.
P98-1081
We then switch to Wall Street Journal material (WSJ), tagged with the Penn Treebank II tagset (Marcus, Santorini, and Marcinkiewicz 1993).
J93-2004
Parsing is also the task to which Henderson and Brill (1999) apply combination methods with reductions of up to 30% precision error and 6% recall error compared to the best previously published results of single statistical parsers.
W99-0623
The lexical probabilities depend on the identity of the current word for known words and on a suffix tree smoothed with successive abstraction (Samuelsson 1996) for guessing the tags of unknown words.
C96-2151
For part-of-speech tagging, a significant increase in accuracy through combining the output of different taggers was first demonstrated in van Halteren, Zavrel, and Daelemans (1998) and Brill and Wu (1998).
P98-1029 P98-1081
224 van Halteren, Zavrel, and Daelemans Combination of Machine Learning Systems Table 13 A comparison of our results for WSJ with those by Brill and Wu (1998).
P98-1029
The experiments with WSJ will also let us compare our results with those reported by Brill and Wu (1998), which show a much less pronounced accuracy increase than ours with LOB.
P98-1029
28 5.4 Size of the Training Set The most important result that has undergone a change between van Halteren, Zavrel, and Daelemans (1998) and our current experiments is the relative accuracy of TagPair and stacked systems such as MBL.
P98-1081
High accuracy on the same task is claimed by Alegre, Sopena, and Lloberas (1999) for combining ensembles of neural networks.
W99-0628
With LOB and a single 114K tune set (van Halteren, Zavrel, and Daelemans 1998), both MBL and Decision Trees degraded significantly when adding context, and MBL degraded when adding the word.
P98-1081
A tagger generator using this learning method is described in Brill (1992, 1994).
A92-1021
a more detailed discussion, see Berger, Della Pietra, and Della Pietra (1996) and Ratnaparkhi (1996).
J96-1002 W96-0213
The HMM approach to tagging is by far the most studied and applied (Church 1988; DeRose 1988; Charniak 1993).
A88-1019 J88-1003
This led us to perform further, more extensive, 1 In previous work (van Halteren, Zavrel, and Daelemans 1998), we were unable to confirm the latter half of the hypothesis unequivocally.
P98-1081
A tagger using this learning method, MBT, was proposed by Daelemans et al.(1996). TM During the training phase, the training corpus is transformed into two case bases, one which is to be used for known words and one for unknown words.
W96-0102
In Abney, Schapire, and Singer (1999), ADABOOST variants are used for tagging WSJ material.
W99-0606
First experiments (van Halteren, Zavrel, and Daelemans 1998; Brill and Wu 1998) demonstrated the basic validity of the approach for tagging, with the error rate of the best combiner being 19.1% lower than that of the best individual tagger (van Halteren, Zavrel, and Daelemans 1998).
P98-1029 P98-1081
