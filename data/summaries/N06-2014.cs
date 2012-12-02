First, we performed the same experiment as in (Hillard et al., 2003) and (Galley et al., 2004), using the contrast classi er (CC) method . Among the four meetings, the data from one meeting was set aside for testing.
N03-2012 P04-1085
Yarowsky. 1995.
P95-1026
We observed the same pattern in co-training; its accuracy peaked after two iterations (85.1%) and then performance degraded drastically (68% after ve iterations) due in part to an increase in mislabeled data in the training set (as previously observed in (Pierce and Cardie, 2001)) and in part because the data skew is not controlled for.
W01-0501
In addition, it is important to assess the impact of semi-supervised training with recognizer output, where gains from using unlabeled data may be greater than with reference transcripts as in (Hillard et al., 2003).
N03-2012
The experiments here kept the feature set xed, but results of (Galley et al., 2004) suggest that further gains can be achieved by augmenting the feature set.
P04-1085
When only lexical features are used (the rst three entries), the SVMbased contrast classi er using meta-classi ers gives the best performance, outperforming the decision tree in (Hillard et al., 2003) and the maximum enTable 1: Comparison of 3-way classi cation accuracy on lexical (lex) vs.
N03-2012
Accuracy Hillard-lex 82 Galley-lex 85.0 SVM-lex 86.3 CC-lex 86.7 Galley-exp 86.9 Table 2: Comparison of the classi cation performance Method 3-way A/D A/D Acc confusion recovery unsupervised 79 8 83 cc 81.4 4 82.4 cc-threshold 76.7 6 85.2 cc-meta 86.7 5 81.3 cc-meta-thres 87.1 5 82.4 tropy model in (Galley et al., 2004).
P04-1085
To alleviate this effort, various semi-supervised learning algorithms such as self-training (Yarowsky, 1995), cotraining (Blum and Mitchell, 1998; Goldman and Zhou, 2000), transductive SVM (Joachims, 1999) and many others have been proposed and successfully applied under different assumptions and settings.
P95-1026
This problem was previously studied (Hillard et al., 2003; Galley et al., 2004), using a subset of ICSI meeting recording corpus (Janin et al., 2003).
N03-2012 P04-1085
We use only word-based features similar to those used in (Hillard et al., 2003), which include the number of words in a spurt, the number of keywords associated with the positive and negative classes, and classi cation based on keywords.
N03-2012
The contrast classi er is also competitive with the best case result in (Galley et al., 2004) (last entry), which adds speaker change, segment duration, and adjacency pair sequence dependency features using a dynamic Bayesian network.
P04-1085
