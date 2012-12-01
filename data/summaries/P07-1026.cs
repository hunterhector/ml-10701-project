In the context of it, more and more kernels for restricted syntaxes or specific domains (Collins and Duffy, 2001; Lodhi et al., 2002; Zelenko et al., 2003; Zhang et al., 2006) are proposed and explored in the NLP domain.
P06-1104
We use Che et al.(2006)’s hybrid convolution tree kernel (the best-reported method for kernel-based SRL) as our baseline kernel.
P06-2010
Kernel Setup: We use the Constituent, Predicate, and Predicate-Constituent related features, which are reported to get the best-reported performance (Pradhan et al., 2005a), as the baseline features.
P05-1072 W05-0634
Most of the following work focused on feature engineering (Xue and Palmer, 2004; Jiang et al., 2005) and machine learning models (Nielsen and Pradhan, 2004; Pradhan et al., 2005a).
J05-1004 P05-1072 W04-3211 W04-3212 W05-0634
(6) using a dynamic programming algorithm (Moschitti, 2006).
N06-2025
The data consists of sections of the Wall Street Journal part of the Penn TreeBank (Marcus et al., 1993), with information on predicate-argument structures extracted from the PropBank corpus (Palmer et al., 2005).
J05-1004 J93-2004
Work Feature-based Methods for SRL: most features used in prior SRL research are generally extended from Gildea and Jurafsky (2002), who used a linear interpolation method and extracted basic flat features from a parse tree to identify and classify the constituents in the FrameNet (Baker et al., 1998).
J02-3001 P98-1013
Some other work paid much attention to the robust SRL (Pradhan et al., 2005b) and post inference (Punyakanok et al., 2004).
C04-1197 P05-1072 W05-0634
It is defined as (1 ) (0 1) hybrid path cs KK Kθθθ=+− ≤≤(for the detailed definitions of path K and cs K, please refer to Che et al.(2006)). Here, we use our grammardriven tree kernel to compute path K and cs K, and we call it grammar-driven hybrid tree kernel while Che et al.(2006)’s is non-grammar-driven hybrid convolution tree kernel.
P06-2010
Moschitti (2004) and Che et al.(2006) used a convolution tree kernel (Collins and Duffy, 2001) for semantic role classification.
N06-2025 P04-1043 P06-2010
Method Accuracy (%) Ours (Composite Kernel) 91.97 Moschitti (2006): PAF kernel only 87.7 Jiang et al.(2005): feature based 90.50 Pradhan et al.(2005a): feature based 91.0 Table 3: Performance comparison between our method and previous work Training Time Method 4 Sections 19 Sections Ours: grammardriven tree kernel ~8.1 hours ~7.9 days Moschitti (2006): non-grammar-driven tree kernel ~7.9 hours ~7.1 days Table 4: Training time comparison Table 4 reports the training times of the two kernels.
N06-2025 P05-1072 W05-0634
Under the same framework, Che et al.(2006) proposed a hybrid convolution tree kernel, which consists of two individual convolution kernels: a Path kernel and a Constituent Structure kernel.
P06-2010
Moschitti (2006) proposes a partial tree (PT) kernel which can carry out partial matching between sub-trees.
N06-2025
In our implementation, we use the binary SVMLight (Joachims, 1998) and modify the Tree Kernel Tools (Moschitti, 2004) to a grammardriven one.
P04-1043
In addition, a more interesting research topic is to study how to integrate linguistic knowledge and tree kernel methods to do feature selection for tree kernelbased NLP applications (Suzuki et al., 2004).
P04-1016
Che et al.(2006) showed that their method outperformed PAF on the CoNLL-2005 SRL dataset.
P06-2010
Of special interest here, Moschitti (2004) proposed Predicate Argument Feature (PAF) kernel for SRL under the framework of convolution tree kernel.
P04-1043
