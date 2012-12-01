Recently, some new statistical techniques, such as CRF (Lafferty et al.2001) and structural learning methods (Ando and Zhang, 2005) have been applied on the base NP chunking.
P05-1001
There are some other methods to deal with Chinese phrase (no only base NP) chunking, such as HMM (Heng Li et al., 2003), Maximum Entropy (Zhou Yaqian et al., 2003), Memory-Based Learning (Zhang and Zhou, 2002) etc.
W02-1818
Description 2.1 Data Representation Ramshaw and Marcus (1995) gave mainly two kinds of base NPs representation － the open/close bracketing and IOB tagging.
W95-0107
an 2.3 Conditional Random Fields Lafferty et al.( 2001) present the Conditional Random Fields for building probabilistic models to segment and label sequence data, which was used effectively for base NP chunking (Sha & Pereira, 2003).
N03-1028
Zhang and Ando (2005) produce the best English base NP accuracy with F-score of 94.39+ (0.79), which is superior to our best results.
P05-1001
(Cardie and Pierce, 1998, 1999) applied a scoring method to select new rules and a naive heuristic for matching rules to evaluate the results' accuracy.
P98-1034
(Kudo and Matsumoto 2001) designed a voting arrangement by applying cross validation and VC-bound and Leave-One-Out bound for the voting weights.
N01-1025
The results of CRF are better than that of SVM, which is the same as the outcome of the English base NP chunking in (Sha & Pereira, 2003).
N03-1028
In our experiments, we choose TinySVM 1 together with YamCha 2 (Kudo and Matsumoto, 2001) as the one of the baseline systems for our chunker.
N01-1025
We define a transition matrix as following: '' (, | ) exp( (,,, )) ijj j M yyx f yyxiλ= ∑ Then, 1 1 1 1 (|,) (, |) () n ii i i py x M y y x Zx λ + − = = ∏ and let * denote component-wise matrix product, (|,) 1 (, ) ( |,) (, ) () () () 1 k pYx k k k y T ii ii i T n EFYx pYyxFyx fM Zx Zx a λ λ αβ − == ∗ = =⋅ ∑ ∑ Where ii α β, as the forward and backward state-cost vectors defined by 1 11 1, 101 T ii T ii Min M in i in α β αβ − ++ 0< ≤ ⎧ ≤< ⎧ = = ⎨⎨ = = ⎩ ⎩ Sha & Pereira (2003) provided a thorough discussion of CRF training methods including preconditioned Conjugate Gradient, limitedMemory Quasi-Newton and voted perceptron.
N03-1028
Ramshaw and Marcus (1995) introduced a transformationbased learning method which considered chunking as a kind of tagging problem.
W95-0107
(Ando and Zhang, 2005) presented a novel semisupervised learning method on chunking and produced performances higher than the previous best results.
P05-1001
