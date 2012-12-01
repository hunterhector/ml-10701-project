However, our implementation uses a quasi-Newton gradient-climber BFGS for optimization, which has been shown to converge much faster (Malouf, 2002; Sha and Pereira, 2003).
N03-1028 W02-2018
In addition, compared to simple models like n-gram language models (Teahan et al., 2000), another shortcoming of CRF-based segmenters is that it requires significantly longer training time.
J00-3004
Closed Precision Recall F1 Roov CTB 0.828 0.870 0.849 0.550 PK 0.935 0.947 0.941 0.660 HK 0.917 0.940 0.928 0.531 AS 0.950 0.962 0.956 0.292 Open Precision Recall F1 Roov CTB 0.889 0.898 0.894 0.619 PK 0.941 0.952 0.946 0.676 HK 0.944 0.948 0.946 0.629 AS 0.953 0.961 0.957 0.403 Table 3: Overall results of CRF segmentation on closed and open tests To compare our results against other systems, we summarize the competition results reported in (Sproat and Emerson, 2003) in Table 4.
W03-1719
A recent Chinese word segmentation competition (Sproat and Emerson, 2003) has made comparisons easier.
W03-1719
One solution to this problem could use a named entity extractor to recognize proper names; this was found to be very helpful in Wu (2003).
W03-1727
Zhang et al (2003) use a hierarchical hidden Markov Model to incorporate lexical knowledge.
W03-1709
Machine learning approaches are more desirable and have been successful in both unsupervised learning (Peng and Schuurmans, 2001) and supervised learning (Teahan et al., 2000).
J00-3004
See Peng and McCallum (2004) for more details and further experiments.
N04-1042
For example, the N-gram generative language modeling based approach of Teahan et al (2000) does not use domain knowledge.
J00-3004
Gao et al (2003) uses class-based language for word segmentation where some word category information can be incorporated.
P03-1035
S01 is one of the best segmentation systems in mainland China (Zhang et al., 2003).
W03-1709
Segment confidence is estimated using constrained forward-backward (Culotta and McCallum, 2004).
N04-4028
Many machine learning approaches have been proposed (Chen and Bai, 1998; Wu and Jiang, 2000; Nie et al., 1995).
W00-1207
This is due to significant inconsistent segmentation in training and testing (Sproat and Emerson, 2003).
W03-1719
and Analysis To make a comprehensive evaluation, we use all four of the datasets from a recent Chinese word segmentation bake-off competition (Sproat and Emerson, 2003).
W03-1719
