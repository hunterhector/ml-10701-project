36 2 Related Work Conventional methods for RTE define measures for the similarity between T and H either by assuming an independence between words (Corley and Mihalcea, 2005) in a BoW fashion or by exploiting syntactic interpretations.
W05-1203
In a survey of the idiomatic phrases listed in the Collins Cobuild Dictionary of Idioms, Villavicencio and Copestake (2002) found this kind of idiom to account for more of the entries than any other.
P02-1034
Training The parsing problem is to find a mapping from a set of sentences x ??X to a set of parses y ??Y. We assume that the mapping F is represented through a feature vector (x,y) ??Rd and a parameter vector  ??Rd in the following way (Collins, 2002): F(x) = argmax y?GEN(x) (x,y) (1) where GEN(x) denotes the set of possible parses for sentence x and (x,y)   = summationtexti ii(x,y) is the inner product.
P02-1034
The cross-pair similarity model uses: (1) a tree similarity measure KT(?1,?2) (Collins and Duffy, 2002) that counts the subtrees that ?1 and ?2 have in common; (2) a substitution function t(,c) that changes names of the placeholders in a tree according to a set of correspondences between placeholders c.
P02-1034
One the best two teams in RTE-2 (Tatu et al., 2006) proposed a knowledge representation model which achieved about 10% better performance than the third (Zanzotto and Moschitti, 2006) based on their logic prover.
E06-1015 P06-1051
M. Collins. 2002. Discriminative Training Methods for Hidden Markov Models: Theory and Experiments with Perceptron Algorithms. In Proceedings of EMNLP, pages 18.
P02-1034
tron (Freund and Schapire, 1999; Collins, 2002),
P02-1034
Results 5.1 Experimental Setup We implemented the novel cross-similarity kernel in the SVM-light-TK (Moschitti, 2006) that encodes the basic syntactic kernel KT in SVM-light (Joachims, 1999).
E06-1015
The classifier uses as the only feature the lexical overlap similarity score described in (Corley and Mihalcea, 2005); -lex+tap: these configurations mix lexical overlap and our typed anchor approaches; -lex+tree: the comparison of this configuration with lex+tap should further support the validity of our intuition on typed anchors; Preliminary experiments have been performed using two datasets: RTE2 (the 1600 entailment pairs from the RTE-2 challenge) and RTE3d (the development dataset of this challenge).
W05-1203
In contrast, Zanzotto&Moschitti (2006) proposed a machine-learning based approach which reaches a high accuracy by only using the available RTE data.
E06-1015 P06-1051
In the tagging domain, Collins (2002) compared log-linear and perceptron training for HMM-style tagging based on dynamic programming.
P02-1034
Like Collins (2002), the decoder is the same for both the perceptron and the log-linear parsing models; the only change is the method for setting the weights.
P02-1034
Another group (Zanzotto and Moschitti, 2006) utilized a tree kernel method for cross-pair similarity, which showed an improvement, and this has motivated us to investigate kernel-based methods.
E06-1015 P06-1051
Collins (2002) introduced the averaged perceptron, as a way of reducing overfitting, and it has been shown to perform better than the non-averaged version on a number of tasks.
P02-1034
2 Cross-pair similarity and its limits 2.1 Learning entailment rules with syntactic cross-pair similarity The cross-pair similarity model (Zanzotto and Moschitti, 2006) proposes a similarity measure aiming at capturing rewrite rules from training examples, computing a cross-pair similarity KS((Tprime,Hprime),(Tprimeprime,Hprimeprime)).
E06-1015 P06-1051
We chose the perceptron for the training algorithm because it has shown good performance on other NLP tasks; in particular, Collins (2002) reported good performance for a perceptron tagger compared to a Maximum Entropy tagger.
P02-1034
KT(?prime,?primeprime), as defined in (Collins and Duffy, 2002), computes the number of common subtrees between ?prime and ?primeprime.
P02-1034
We have also begun to experiment with the tree kernels of Moschitti (2006), but are not yet in a position to report results.
E06-1015
The first backup strategy is a straightforward BoW method that we will not present in this paper (see more details in (Corley and Mihalcea, 2005)); Id Ta s k Te x t H y po th e s i s En ta i l s ? 1IE The sale was made to pay Yukos' US$ 27.5 billion tax bill, Yuganskneftegaz was originally sold for US$ 9.4 billion to a little known com pany Baikalfinansgroup which was later bought by the Russian state-owned oil Baikalfinansgroup was sold to Rosneft.
W05-1203
