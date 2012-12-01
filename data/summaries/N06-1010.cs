Collins and Singer (1999) proposed an unsupervised method for named entity classification based on the idea of cotraining.
W99-0613
Ando and Zhang (2005) proposed a semisupervised learning method to exploit unlabeled data for building more robust NER systems.
P05-1001
They can often achieve high accuracy provided that a large annotated training set similar to the test data is available (Borthwick, 1999; Zhou and Su, 2002; Florian et al., 2003; Klein et al., 2003; Finkel et al., 2005).
P02-1060 W03-0425 W03-0428
Most existing work has focused on supervised learning approaches, employing models such as HMMs (Zhou and Su, 2002), MEMMs (Bender et al., 2003; Finkel et al., 2005), and CRFs (McCallum and Li, 2003).
P02-1060 W03-0420 W03-0430
Recently there have been some studies on adapting NER systems to new domains employing techniques such as active learning and semi-supervised learning (Shen et al., 2004; Mohit and Hwa, 2005), 80 or incorporating external lexical knowledge (Ciaramita and Altun, 2005).
P04-1075 P05-3015
To avoid overfitting, a zero mean Gaussian prior on the weights is usually used (Chen and Rosenfeld, 1999; Bender et al., 2003), and a maximum a posterior (MAP) estimator is used to maximize the posterior probability: ˆ β = arg max β p(β) N productdisplay j=1 p(y j |x j,β), (4) where y j is the true class label for x j, N is the number of training examples, and p(β) = |F | productdisplay i=1 1 radicalBig 2piσ 2 i exp(− β 2 i 2σ 2 i ).
W03-0420
2 Generalizability-Based Feature Ranking We take a commonly used approach and treat NER as a sequential tagging problem (Borthwick, 1999; Zhou and Su, 2002; Finkel et al., 2005).
P02-1060
