Second, 1000 instances may simply not be sufficient for co-training to be effective for this task: in related work (Ng and Cardie, 2003), we find that starting with 3500–3700 labeled instances instead of 1000 allows co-training to improve the baseline by 4.6% and 9.5% in F-measure using naive Bayes classifiers for the MUC-6 and MUC-7 data sets, respectively.
N03-1023
Lists Our decision list (DL) algorithm is based on that described in Collins and Singer (1999).
W99-0613
This paper instead focuses on developing a single-view algorithm that combines aspects of each of the Goldman and Zhou and Steedman et al.algorithms. Second, we investigate a new method that, inspired by Steedman et al.(2003a), ranks unlabeled instances to be added to the labeled data in an attempt to alleviate a problem commonly observed in bootstrapping experiments — performance deterioration due to the degradation in the quality of the labeled data as bootstrapping progresses (Pierce and Cardie, 2001; Riloff and Jones, 1999).
E03-1008 N03-1031 W01-0501
The drop in F-measure is potentially due to the pollution of the labeled data by mislabeled instances (Pierce and Cardie, 2001).
W01-0501
On the other hand, Steedman et al.use two learning algorithms that correspond to coarsely different features, thus retaining in spirit the advantages 1 Steedman et al.(2003b) bootstrap two parsers that use different statistical models via co-training.
E03-1008 N03-1031
See Yarowsky (1995) for details.
P95-1026
Goldman and Zhou (2000) and Steedman et al.(2003b) use two different learning algorithms in lieu of the multiple views required by standard co-training.
E03-1008 N03-1031
5 Single-View Bootstrapping In this section, we describe and evaluate our singleview, multi-learner bootstrapping algorithm, which combines ideas from Goldman and Zhou (2000) and Steedman et al.(2003b). We will start by giving an overview of these two co-training algorithms.
E03-1008 N03-1031
Steedman et al.(2003a) also investigate instance selection methods for co-training, but their goal is primarily to use selection methods as a means to explore the trade-off between maximizing coverage and maximizing accuracy.
E03-1008 N03-1031
Our hypothesis is that selection methods that are based solely on the confidence assigned to an instance by a single classifier 5 Note that this is self-training without bagging, unlike the self-training algorithm discussed in Ng and Cardie (2003).
N03-1023
Unlike Ng and Cardie (2003) where we choose one of the dryrun texts (contributing approximately 3500–3700 instances) form the labeled data set, however, here we randomly select 1000 instances.
N03-1023
In related work (Ng and Cardie, 2003), we compare the performance of the Blum and Mitchell cotraining algorithm with that of two existing singleview bootstrapping algorithms — self-training with bagging (Banko and Brill, 2001) and EM (Nigam et al., 2000) — on coreference resolution, and show that single-view weakly supervised learners are a viable alternative to co-training for the task.
N03-1023 P01-1005
web page classification (Blum and Mitchell, 1998) and named entity classification (Collins and Singer, 1999)), there has been little success, and a number of reported problems, when applying cotraining to NLP data sets for which no natural feature split has been found (e.g.
W99-0613
ters such as the pool size and the growth size (Pierce and Cardie, 2001), we evaluate the algorithm under different parameter settings, as described below.
W01-0501
See Ng and Cardie (2003) for details.
N03-1023
using the model-theoretic MUC scoring program (Vilain et al., 1995).
M95-1005
The framework underlying the coreference system is a standard combination of classification and clustering (see Ng and Cardie (2002) for details).
W02-1008
