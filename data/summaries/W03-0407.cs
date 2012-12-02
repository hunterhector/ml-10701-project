The opposite behaviour has been observed in other applications of co-training (Pierce and Cardie, 2001).
W01-0501
Abney also presents a greedy algorithm that maximises agreement on unlabelled data, which produces comparable results to Collins and Singer (1999) on their named entity classification task.
W99-0613
There has been some previous work on boostrapping POS taggers (e.g., Zavrel and Daelemans (2000) and Cucerzan and Yarowsky (2002)), but to our knowledge no previous work on co-training POS taggers.
W02-2006
Abney (2002) argues that the Blum and Mitchell independence assumption is very restrictive and typically violated in the data, and so proposes a weaker independence assumption, for which the Dasgupta et al.(2002) results still hold.
P02-1046
We investigate whether co-training based upon directly maximising agreement can be successfully applied to a pair of part-of-speech (POS) taggers: the Markov model TNT tagger (Brants, 2000) and the maximum entropy C&C tagger (Curran and Clark, 2003).
A00-1031 E03-1071
Our agreement-based co-training results support the theoretical arguments of Abney (2002) and Dasgupta et al.(2002), that directly maximising the agreement rates between the two taggers reduces generalisation error.
P02-1046
Collins and Singer (1999) present a variant of the Blum and Mitchell algorithm, which directly maximises an objective function that is based on the level of agreement between the classifiers on unlabelled data.
W99-0613
In this paper we take a different approach, based on theoretical work by Dasgupta et al.(2002) and Abney (2002), in which newly labelled training examples are selected using a greedy algorithm which explicitly maximises the POS taggers’ agreement on unlabelled data.
P02-1046
For naive co-training, new samples will always be added, and so there is a possibility that the noise accumulated at later stages will start to degrade performance (see Pierce and Cardie (2001)).
W01-0501
Co-training (Blum and Mitchell, 1998), and several variants of co-training, have been applied to a number of NLP problems, including word sense disambiguation (Yarowsky, 1995), named entity recognition (Collins and Singer, 1999), noun phrase bracketing (Pierce and Cardie, 2001) and statistical parsing (Sarkar, 2001; Steedman et al., 2003).
E03-1008 N01-1023 P95-1026 W01-0501 W99-0613
This finding is in accord with earlier work on bootstrapping taggers using EM (Elworthy, 1994; Merialdo, 1994).
A94-1009 J94-2001
A disadvantage is that the training times for ME models are usually relatively slow, especially with iterative scaling methods (see Malouf (2002) for alternative methods).
W02-2018
3ThePOS taggers The two POS taggers used in the experiments are TNT, a publicly available Markov model tagger (Brants, 2000), and a reimplementation of the maximum entropy (ME) tagger MXPOST (Ratnaparkhi, 1996).
A00-1031 W96-0213
The ME tagger, which we refer to as C&C, uses the same features as MXPOST, but is much faster for training and tagging (Curran and Clark, 2003).
E03-1071
