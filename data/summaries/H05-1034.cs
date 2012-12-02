The average parameters are defined as )./()()( 11, MT T t M i it davgd ⋅= ∑∑ == λλ (9) 3.4 The minimum sample risk method The minimum sample risk (MSR, Gao et al., 2005) training algorithm is motivated by analogy with the feature selection procedure for the boosting algorithm (Freund et al., 1998).
H05-1027
See Gao et al.(2005) for a complete description of the MSR implementation and the empirical justification for its performance.
H05-1027
We used the N-best reranking approach with the same N-best list for both MAP estimation and discriminative training, while in Bacchiani et al.(2004), two different lattices were used: the perceptron model was applied to rerank the lattice created by the background model, while the MAP adaptation model was used to produce the lattice itself.
N04-4006
Our results differ from Bacchiani et al.(2004) in that in our system, the perceptron algorithm alone achieved better results than MAP estimation.
N04-4006
For a detailed description of each algorithm, readers are referred to Collins (2000) for the boosting algorithm, Collins (2002) for perceptron learning, and Gao et al.(2005) for the minimum sample risk method.
H05-1027 W02-1001
MSR thus adopts the method proposed by Och (2003).
P03-1021
We used the average perceptron algorithm of Collins (2002) in our experiments, a variation that has been proven to be more effective than the standard algorithm shown in Figure 2.
W02-1001
The task of automatic conversion has been the subject of language modeling research in the context of Pinyin-to-Character conversion in Chinese (Gao et al., 2002a) and Kana-Kanji conversion in Japanese (Gao et al., 2002b).
W02-1032
of LM adaptation The discriminative training procedure was carried out as follows: for each input phonetic string A in the adaptation training set, we produced a word lattice using the baseline trigram models described in Gao et al.(2002b). We kept the top 20 hypotheses from this lattice as the candidate conversion set GEN(A).
W02-1032
These techniques have been applied successfully to the task of language modeling in non-adaptation (Roark et al., 265 2004) as well as adaptation (Bacchiani et al., 2004) scenarios.
N04-4006
The following set-up, adapted from Collins (2002), was used for all three discriminative training methods: 266 • Training data is a set of input-output pairs.
W02-1001
The four models we compare are a maximum a posteriori (MAP) method and three discriminative training methods, namely the boosting algorithm (Collins, 2000), the average perceptron (Collins, 2002) and the minimum sample risk method (Gao et al., 2005).
H05-1027 W02-1001
