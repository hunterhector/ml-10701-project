In this case, we use classifiers as features as described in Florian et al.(2004). Finally, we show in Section 7.3 that our SCL PoS 124 (a) 100 500 1k 5k 40k75 80 85 90 Results for 561 MEDLINE Test Sentences Number of WSJ Training Sentences Accuracy supervised semi−ASO SCL (b) Accuracy on 561-sentence test set Words Model All Unknown Ratnaparkhi (1996) 87.2 65.2 supervised 87.9 68.4 semi-ASO 88.4 70.9 SCL 88.9 72.0 (c) Statistical Significance (McNemar’s) for all words Null Hypothesis p-value semi-ASO vs.
N04-1001 W96-0213
In this case, we make use of the out-of-domain data by using features of the source domain tagger’s predictions in training and testing the target domain tagger (Florian et al., 2004).
N04-1001
We also showed how to combine an SCL tagger with target domain labeled data using the classifier combination techniques from Florian et al.(2004). Finally, we improved parsing performance in the target domain when using the SCL PoS tagger.
N04-1001
Ando and Zhang (2005a) describe several free paramters and extensions to ASO, and we briefly address our choices for these here.
P05-1001
Discriminative taggers and chunkers have been the state-of-the-art for more than a decade (Ratnaparkhi, 1996; Sha and Pereira, 2003).
N03-1028 W96-0213
In the case when some in-domain labeled training data is available, we show how to use SCL together with the classifier combination techniques of Florian et al.(2004) to achieve even greater performance.
N04-1001
We chose to compare with ASO because it consistently outperforms cotraining (Blum and Mitchell, 1998) and clustering methods (Miller et al., 2004).
N04-1043
For unknown words, SCL gives a relative reduction in error of 19.5% over Ratnaparkhi (1996), even with 40,000 sentences of source domain training data.
W96-0213
To avoid terminological confusion, we refer throughout the paper to a specific structural learning method, alternating structural optimization (ASO) (Ando and Zhang, 2005a).
P05-1001
MIRA has been used successfully for both sequence analysis (McDonald et al., 2005a) and dependency parsing (McDonald et al., 2005b).
H05-1124 P05-1012
Pivot features correspond to the auxiliary problems of Ando and Zhang (2005a).
P05-1001
Chelba and Acero (2004) first train a classifier on the source data.
W04-3237
For both computational and statistical reasons, though, we follow Ando and Zhang (2005a) and compute a low-dimensional linear approximation to the pivot predictor space.
P05-1001
In such cases, we must take steps to adapt a model trained on the source domain for use in the target domain (Roark and Bacchiani, 2003; Florian et al., 2004; Chelba and Acero, 2004; Ando, 2004; Lease and Charniak, 2005; Daum´e III and Marcu, 2006).
N03-1027 N04-1001 P04-1007 P04-3013 P05-1001 W04-3237
Structural correspondence learning is most similar to that of Ando (2004), who analyzed a situation with no target domain labeled data.
P04-3013
Furthermore, end-to-end systems like speech recognizers (Roark et al., 2004) and automatic translators (Och, 2003) use increasingly sophisticated discriminative models, which generalize well to new data that is drawn from the same distribution as the training data.
N03-1027 P03-1021 P04-1007
We are also focusing on other potential applications, including chunking (Sha and Pereira, 2003), named entity recognition (Florian et al., 2004; Ando and Zhang, 2005b; Daum´e III and Marcu, 2006), and speaker adaptation (Kuhn et al., 1998).
N03-1028 N04-1001 P05-1001
We did run experiments with the top-k version of ASO (Ando and Zhang, 2005a), which is inspired by cotraining but consistently outperforms it.
P05-1001
We follow Ando and Zhang (2005a) and use the modified Huber loss.
P05-1001
We used the same 58 feature types as Ratnaparkhi (1996).
W96-0213
We also implemented both of the extensions described in Ando and Zhang (2005a).
P05-1001
One important advantage that this work shares with Ando (2004) is that an SCL model can be easily combined with all other domain adaptation techniques (Section 7.2).
P04-3013
Though other methods for incorporating small amounts of training data in the target domain were available, such as those proposed by Chelba and Acero (2004) and by Daum´e III and Marcu (2006), we chose this method for its simplicity and consistently good performance.
W04-3237
Aside from Florian et al.(2004), several authors have also given techniques for adapting classification to new domains.
N04-1001
As in Ando and Zhang (2005a), we observed that setting h between 20 and 100 did not change results significantly, and a lower dimensionality translated to faster run-time.
P05-1001
Sets and Supervised Tagger 5.1 Source Domain: WSJ We used sections 02-21 of the Penn Treebank (Marcus et al., 1993) for training.
J93-2004
The ASO baseline is an implementation of Ando and Zhang (2005b).
P05-1001
Finding correspondences involves estimating the correlations between pivot and non-pivot feautres, and we adapt structural learning (ASO) (Ando and Zhang, 2005a; Ando and Zhang, 2005b) for this task.
P05-1001
We use the parser described by McDonald et al.(2005b). That parser assumes that a sentence has been PoStagged before parsing.
H05-1124 P05-1012
We found it necessary to make a change to the ASO algorithm as described in Ando and Zhang (2005a).
P05-1001
Roark and Bacchiani (2003) use a Dirichlet prior on the multinomial parameters of a generative parsing model to combine a large amount of training data from a source corpus (WSJ), and small amount of training data from a target corpus (Brown).
N03-1027
In this work we choose to use the technique of structural learning (Ando and Zhang, 2005a; Ando and Zhang, 2005b).
P05-1001
120 (a) Wall Street Journal DT JJ VBZ DT NN IN DT JJ NN The clash is a sign of a new toughness CC NN IN NNP POS JJ JJ NN. and divisiveness in Japan ’s once-cozy financial circles . (b) MEDLINE DT JJ VBN NNS IN DT NN NNS VBP The oncogenic mutated forms of the ras proteins are RB JJ CC VBP IN JJ NN NN . constitutively active and interfere with normal signal transduction . Figure 1: Part of speech-tagged sentences from both corpora we investigate its use in part of speech (PoS) tagging (Ratnaparkhi, 1996; Toutanova et al., 2003).
N03-1033 W96-0213
There are many choices for modeling co-occurrence data (Brown et al., 1992; Pereira et al., 1993; Blei et al., 2003).
J92-4003 P93-1024
