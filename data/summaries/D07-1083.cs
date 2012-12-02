The design of these feature sets was derived from a suggestion in (Smith et al., 2005), which exhibited the best performance in the several feature division.
P05-1003
In fact, many attempts have recently been made to develop semi-supervised SOL methods (Zhu et al., 2003; Li and McCallum, 2005; Altun et al., 2005; Jiao et al., 2006; Brefeld and Scheffer, 2006).
P06-1027
For the baseline method, we performed a conditional random field (CRF), which is exactly the same training procedure described in (Sha and Pereira, 2003) with L-BFGS.
N03-1028
Moreover, the experimental results shown in Tables 3 and Fβ=1 additional resources ASO-semi 89.31 unlabeled data (27M words) (Ando and Zhang, 2005) (Florian et al., 2003) 88.76 their own large gazetteers, 2M-word labeled data (Chieu and Ng, 2003) 88.31 their own large gazetteers, very elaborated features HySOL 88.14 unlabeled data (17M words) supplied gazetters HySOL 87.20 unlabeled data (17M words) Table 5: Previous top systems in NER (CoNLL2003) experiments Fβ=1 additional resources ASO-semi 94.39 unlabeled data (Ando and Zhang, 2005) (15M words: WSJ) HySOL 94.30 unlabeled data (17M words: Reuters) (Zhang et al., 2002) 94.17 full parser output (Kudo and Matsumoto, 2001) 93.91 – Table 6: Previous top systems in Chunking (CoNLL-2000) experiments 4 indicate that HySOL is rather robust with respect to the hyper-parameter since we can obtain fairly good performance without a prior distribution.
N01-1025 P05-1001 W03-0423 W03-0425
We used the same Chunking and ‘English’ NER data as those used for the shared tasks of CoNLL-2000 (Tjong Kim Sang and Buchholz, 2000) and CoNLL-2003 (Tjong Kim Sang and Meulder, 2003), respectively.
W00-0726 W03-0419
In fact, if we simply add the gazetteers included in CoNLL-2003 supplied data as features, HySOL achieves 88.14. 5.5 Applying F-score Optimization Technique In addition, we can simply apply the F-score optimization technique for the sequence labeling tasks proposed in (Suzuki et al., 2006) to boost the HySOL performance since the base discriminative models pD(y|x) and discriminative combination, namely Equation (3), in our hybrid model basically uses the same optimization procedure as CRFs.
P06-1028
(Suzuki et al., 2006) 88.02 (+0.82) + unlabeled data (17M → 27M words) 88.41 (+0.39) + supplied gazetters 88.90 (+0.49) + add dev.
P06-1028
with Previous Top Systems With respect to the performance of NER and Chunking tasks, the current best performance is reported in (Ando and Zhang, 2005), which we refer to as ‘ASO-semi’, as shown in Figures 5 and 6.
P05-1001
Semi-supervised conditional random fields (CRFs) based on a minimum entropy regularizer (SS-CRF-MER) have been proposed in (Jiao et al., 2006).
P06-1027
Examples of ‘word type’ include whether the word is capitalized, contains digit or contains punctuation, which basically follows the baseline features of (Sutton et al., 2006) without regular expressions.
N06-1012
(Suzuki et al., 2006) 94.36 (+0.06) Table 8: The HySOL performance with the F-score optimization technique on Chunking (CoNLL-2000) experiments from unlabeled data appear different from each other.
P06-1028
In fact, we still have a question as to whether SS-CRF-MER is really scalable in practical time for such a large amount of unlabeled data as used in our experiments, which is about 680 times larger than that of (Jiao et al., 2006).
P06-1027
with SS-CRF-MER When we consider semi-supervised SOL methods, SS-CRF-MER (Jiao et al., 2006) is the most competitive with HySOL, since both methods are defined based on CRFs.
P06-1027
First, (Ando and Zhang, 2005) does not describe the unlabeled data used in their NER experiments in detail, and second, we are not licensed to use the TREC corpus including WSJ unlabeled data that they used for their Chunking experiments (training and test data for Chunking is derived from WSJ).
P05-1001
It can be seen that the formalization in the loglinear combination of our hybrid model is very similar to that of LOP-CRFs (Smith et al., 2005).
P05-1003
Moreover, LOP-CRF (Smith et al., 2005) is also compared with our hybrid model, since the formalism of our hybrid model can be seen as an extension of LOP-CRFs as described in Section 3.
P05-1003
