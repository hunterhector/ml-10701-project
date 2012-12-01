As we mentioned, there are some algorithms similar to ours (Collins and Roark, 2004; Daum´e III and Marcu, 2005; McDonald and Pereira, 2006; Liang et al., 2006).
E06-1011 P04-1015
For example, Finkel et al.(2005) enabled the use of non-local features by using Gibbs sampling.
P05-1045
Collins and Roark (2004) used the averaged perceptron (Collins, 2002a).
P02-1034 P04-1015 W02-1001
In this paper, we follow this line of research and try to solve the problem by extending Collins’ perceptron algorithm (Collins, 2002a).
P02-1034 W02-1001
However, by examining the Algorithm 4.2: Perceptron with local and non-local features (parameters: n, Ca, Cl) α ← 0 until no more updates do for i ← 1 to L do8 >> >> >> >> >> < >> >> >> >> >> : {yn} = n-bestyΦl(xi,y)·α y′ = argmaxy∈{yn}Φa(xi,y)·α y′′ = 2nd-besty∈{yn}Φa(xi,y)·α if y′ ̸= y∗i & Φa(xi,y∗i)·α−Φa(xi,y′)·α ≤ Ca then α = α+ Φa(xi,y∗i)−Φa(xi,y′) (A) else if Φa(xi,y∗i)·α−Φa(xi,y′′)·α ≤ Ca then α = α+ Φa(xi,y∗i)−Φa(xi,y′′) (A) else (B) 8> < >: if y1 ̸= yi∗ then (y1 represents the best in {yn}) α = α+ Φl(xi,y∗i)−Φl(xi,y1) else if Φl(xi,y∗i)·α−Φl(xi,y2)·α ≤ Cl then α = α+ Φl(xi,y∗i)−Φl(xi,y2) proofs in Collins (2002a), we can see that the essential condition for convergence is that the weights are always updated using some y (̸= y∗) that satisﬁes: Φ(xi,y∗i)·α−Φ(xi,y)·α ≤ 0 (≤ C in the case of a perceptron with a margin).
P02-1034 W02-1001
Nakagawa and Matsumoto (2006) used a Bolzmann distribution to model the correlation of the POS of words having the same lexical form in a document.
P06-1089
Based on the proofs in Collins (2002a) and Li et al.(2002), we can prove that the algorithm converges within (2C + R2)/δ2 updates and that γ(α) ≥ δC/(2C + R2) = (δ/2)(1 − (R2/(2C + R2))) after training.
P02-1034 W02-1001
2(Daum´e III and Marcu, 2005) also presents the method using the averaged perceptron (Collins, 2002a) 3For re-ranking problems, Shen and Joshi (2004) proposed a perceptron algorithm that also uses margins.
P02-1034 P04-1015 W02-1001
with re-ranking approach Finally, we compared our algorithm with the reranking approach (Collins and Duffy, 2002; Collins, 2002b), where we ﬁrst generate the n-best candidates using a model with only local features (the ﬁrst model) and then re-rank the candidates using a model with non-local features (the second model).
P02-1034 W02-1001
This algorithm is proved to converge (i.e., there are no more updates) in the separable case (Collins, 2002a).1 Thatis,ifthereexistweightvectorU (with ||U|| = 1), δ (> 0), and R (> 0) that satisfy: ∀i,∀y ∈ Y|xi| Φ(xi,yi∗)·U −Φ(xi,y)·U ≥ δ, ∀i,∀y ∈ Y|xi| ||Φ(xi,yi∗)−Φ(xi,y)|| ≤ R, the number of updates is at most R2/δ2.
P02-1034 W02-1001
Although several methods have already been proposed to incorporate non-local features (Sutton and McCallum, 2004; Bunescu and Mooney, 2004; Finkel et al., 2005; Roth and Yih, 2005; Krishnan and Manning, 2006; Nakagawa and Matsumoto, 2006), these present a problem that the types of non-local features are somewhat constrained.
P04-1056 P05-1045 P06-1089 P06-1141
The performance of the related work (Finkel et al., 2005; Krishnan and Manning, 2006) is listed in Table4.
P05-1045 P06-1141
We adopted IOB (IOB2) labeling (Ramshaw and Marcus, 1995), where the ﬁrst word of an entity of class “C” is labeled “B-C”, the words in the entity are labeled “I-C”, and other words are labeled “O”.
W95-0107
However, the achieved accuracy was not better than that of related work (Finkel et al., 2005; Krishnan and Manning, 2006) based on CRFs.
P05-1045 P06-1141
The resulting performance of the proposed algorithm with non-local features is higher than that of Finkel et al.(2005) and comparable with that of Krishnan and Manning (2006).
P05-1045 P06-1141
Discriminative methods such as Conditional Random Fields (CRFs) (Lafferty et al., 2001), Semi-Markov Random Fields (Sarawagi and Cohen, 2004), and perceptrons (Collins, 2002a) have been popular approaches for sequence labeling because of their excellent performance, which is mainly due to their ability to incorporate many kinds of overlapping and non-independent features.
P02-1034 W02-1001
M.Collins and B.Roark. 2004.
P04-1015
With non-local features, we cannot use efﬁcient procedures such as forward-backward procedures and the Viterbi algorithm that are required in training CRFs (Lafferty et al., 2001) and perceptrons (Collins, 2002a).
P02-1034 W02-1001
We also implemented the “majority” version of these features as used in Krishnan and Manning (2006).
P06-1141
To achieve robust training, Daum´e III and Marcu (2005) employed the averaged perceptron (Collins, 2002a) and ALMA (Gentile, 2001).
P02-1034 W02-1001
Algorithm for Sequence Labeling Collins (2002a) proposed an extension of the perceptron algorithm (Rosenblatt, 1958) to sequence labeling.
P02-1034 W02-1001
With regard to the local update, (B), in Algorithm 4.2, “early updates” (Collins and Roark, 2004) and “y-good” requirement in (Daum´e III and Marcu, 2005) resemble our local update in that they tried to avoid the situation where the correct answer cannot be output.
P04-1015
We used non-local features based on Finkel et al.(2005). These features are based on observations such as “same phrases in a document tend to have the same entity class” (phrase consistency) and “a sub-phrase of a phrase tends to have the same entity class as the phrase” (sub-phrase consistency).
P05-1045
Krishnan and Manning (2006) divided the model into two CRFs, where the second model uses the output of the ﬁrst as a kind of non-local information.
P06-1141
“re-ranking 1” uses the score of the ﬁrst model as a feature in addition to the non-local features as in Collins (2002b).
P02-1034 W02-1001
Such methods include ALMA (Gentile, 2001) used in (Daum´e III and Marcu, 2005)2, MIRA (Crammer et al., 2006) used in (McDonald et al., 2005), and Max-Margin Markov Networks (Taskar et al., 2003).
P05-1012
To avoid this problem, we adopt cross-validation training as used in Collins (2002b).
P02-1034 W02-1001
Thus, Collins (2002a) also proposed an averaged perceptron, where the ﬁnal weight vector is 1Collins(2002a)alsoprovidedproofthatguaranteed“good” learning for the non-separable case.
P02-1034 W02-1001
Thistype of non-local feature was not used by Finkel et al.(2005) or Krishnan and Manning (2006).
P05-1045 P06-1141
Method dev test Finkel et al., 2005 (Finkel et al., 2005) baseline CRF 85.51 + non-local features 86.86 Krishnan and Manning, 2006 (Krishnan and Manning, 2006) baseline CRF 85.29 + non-local features 87.24 Table 5: Summary of performance with POS/chunk tags by TagChunk.
P05-1045 P06-1141
CollinsandRoark(2004)proposedanapproximate incremental method for parsing.
P04-1015
This resembles the re-ranking approach (Collins and Duffy, 2002; Collins, 2002b).
P02-1034 W02-1001
Perceptron Algorithm for Sequence Labeling Weextendedaperceptronwithamargin(Krauthand M´ezard, 1987) to sequence labeling in this study, as Collins (2002a) extended the perceptron algorithm to sequence labeling.
P02-1034 W02-1001
For example, non-local features such as “same phrases in a document do not have different entity classes” were shown to be useful in named entity recognition (Sutton and McCallum, 2004; Bunescu and Mooney, 2004; Finkel et al., 2005; Krishnan and Manning, 2006).
P04-1056 P05-1045 P06-1141
The learning algorithm, which is illustrated in Collins (2002a), proceeds as follows.
P02-1034 W02-1001
Recently, severalmethods(Collins and Roark, 2004; Daum´e III and Marcu, 2005; McDonald and Pereira, 2006) have been proposed with similar motivation to ours.
E06-1011 P04-1015
McDonald and Pereira (2006) used MIRA (Crammer et al., 2006).
E06-1011
The algorithm proposed by McDonald and Pereira (2006) is also similar to ours.
E06-1011
