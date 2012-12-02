Results of other supertaggers for automatically extest data accuracy (%) HPSG supertagger 22 87.51 (this paper) CCG supertagger 00/23 91.70 / 91.45 (Curran and Clark, 2003) LTAG supertagger 22/23 86.01 / 86.27 (Shen and Joshi, 2003) Table 5: Accuracy of single-tag supertaggers.
E03-1071 P03-1064
We used beam thresholding, global thresholding (Goodman, 1997), preserved iterative parsing (Ninomiya et al., 2005) and other tech1An HPSG treebank is automatically generated from the Penn Treebank.
W05-1511 W97-0302
The concept of supertagging is simple and interesting, and the effects of this were recently demonstrated in the case of a CCG parser (Clark and Curran, 2004a) with the result of a drastic improvement in the parsing speed.
C04-1041 P04-1014
The model parameters, λu, are estimated using numerical optimization methods (Malouf, 2002) to maximize the log-likelihood of the training data.
W02-2018
The hybrid model can also be regarded as a variant of the statistical CDG parser (Wang, 2003; Wang and Harper, 2004), in which the parse tree probabilities are defined as the product of the supertagging probabilities and the dependency probabilities.
W04-0307
For example, probabilities were defined over grammar rules in probabilistic CFG (Collins, 1999; Klein and Manning, 2003; Charniak and Johnson, 2005) or over complex phrase structures of head-driven phrase structure grammar (HPSG) or combinatory categorial grammar (CCG) (Clark and Curran, 2004b; Malouf and van Noord, 2004; Miyao and Tsujii, 2005).
C04-1041 P03-1054 P04-1014 P05-1011 P05-1022
Wang and Harper (2004) also demonstrated the effects of supertagging with a statistical constraint dependency grammar (CDG) parser.
W04-0307
Abney. 1997.
J97-4005
The upper half of the table shows the performance using the correct POSs in the Penn Treebank, and the lower half shows the performance using the POSs given by a POS tagger (Tsuruoka and Tsujii, 2005).
H05-1059
To make the model estimation tractable, Geman and Johnson (Geman and Johnson, 2002) and Miyao and Tsujii (Miyao and Tsujii, 2002) proposed a dynamic programming algorithm for estimating p(T|w).
P02-1036
Bangalore and Joshi (1999) claimed that if words can be assigned correct supertags, syntactic parsing is almost trivial.
J99-2004
When compared with other supertag sets of automatically extracted lexicalized grammars, the (effective) size of our supertag set, 1,361 lexical entries, is between the CCG supertag set (398 categories) used by Curran and Clark (2003) and the LTAG supertag set (2920 elementary trees) used by Shen and Joshi (2003).
E03-1071 P03-1064
5.1 Supertagging Our probabilistic model of lexical entry selection can be used as an independent classifier for selecting lexical entries, which is called the supertagger (Bangalore and Joshi, 1999; Clark and Curran, 2004b).
C04-1041 J99-2004 P04-1014
Yusuke Miyao, Takashi Ninomiya, and Jun’ichi Tsujii, 2005.
P05-1011 W05-1511
Another interesting approach to this problem was using supertagging (Clark and Curran, 2004b; Clark and Curran, 2004a; Wang and Harper, 2004; Nasr and Rambow, 2004), which was originally developed for lexicalized tree adjoining grammars (LTAG) (Bangalore and Joshi, 1999).
C04-1041 J99-2004 P04-1014 W04-0307
The model is simply defined as the product of the supertagging probabilities, which are provided by the discriminative method with machine learning features of word trigrams and part-of-speech (POS) 5-grams as defined in the CCG supertagging (Clark and Curran, 2004a).
C04-1041 P04-1014
The terms α and β are the thresholds of the number and the beam width of lexical entries, and θ is the beam width for global thresholding (Goodman, 1997).
W97-0302
The CCG supertagging demonstrated fast and accurate parsing for the probabilistic CCG (Clark and Curran, 2004a).
C04-1041 P04-1014
Previous studies (Abney, 1997; Johnson et al., 1999; Riezler et al., 2000; Malouf and van Noord, 2004; Kaplan et al., 2004; Miyao and Tsujii, 2005) defined a probabilistic model of unification-based grammars including HPSG as a log-linear model or maximum entropy model (Berger et al., 1996).
J96-1002 J97-4005 N04-1013 P00-1061 P05-1011 P99-1069
4.1 Implementation We implemented the iterative parsing algorithm (Ninomiya et al., 2005) for the probabilistic HPSG models.
W05-1511
We evaluated the speed and accuracy of parsing with extremely lexicalized models by using Enju 2.1, the HPSG grammar for English (Miyao et al., 2005; Miyao and Tsujii, 2005).
P05-1011
ran, 2004b; Miyao and Tsujii, 2005).
P05-1011
This evaluation scheme was the same as used in previous evaluations of lexicalized grammars (Hockenmaier, 2003; Clark and Cur2Deep parsing techniques include quick check (Malouf et al., 2000) and large constituent inhibition (Kaplan et al., 2004) as described by Ninomiya et al.(2005), but hybrid parsing with a CFG chunk parser was not used.
N04-1013 P03-1046 W05-1511
In the hybrid model, the probabilities of the previous model are multiplied by the supertagging probabilities instead of a preliminary probabilistic model, which is introduced to help the process of estimation by filtering unlikely lexical entries (Miyao and Tsujii, 2005).
P05-1011
In the experiments, we compared our model with the probabilistic HPSG model of Miyao and Tsujii (2005).
P05-1011
