Prior work on automatic relation extraction come in three kinds: supervised learning algorithms (Miller et al., 2000; Zelenko et al., 2002; Culotta and Soresen, 2004; Kambhatla, 2004; Zhou et al., 2005), semi-supervised learning algorithms (Brin, 1998; Agichtein and Gravano, 2000; Zhang, 2004), and unsupervised learning algorithm (Hasegawa et al., 2004).
A00-2030 P04-1053 P04-1054 P04-3022 P05-1053 W02-1010
Experiment results on ACE corpora show that this spectral clustering based approach outperforms Hasegawa et al.(2004)’s hierarchical clustering method and a plain k-means clustering method.
P04-1053
This method can address two difficulties encoutered in Hasegawa et al.(2004)’s hierarchical clustering: no consideration of manifold structure in data, and requirement to provide cluster number by users.
P04-1053
In (Hasegawa et al., 2004), they preformed unsupervised relation extraction based on hierarchical clustering and they only used word features between entity mention pairs to construct context vectors.
P04-1053
Especially, although we did not concern the dependency tree and full parse tree information as other supervised methods (Miller et al., 2000; Culotta and Soresen, 2004; Kambhatla, 2004; Zhou et al., 2005), the incorporation of simple features, such as words and chunking information, still can provide complement information for capturing the characteristics of entity pairs.
A00-2030 P04-1054 P04-3022 P05-1053
With the context window size setting, 5, the performance becomes worse Table 5: Performance of our proposed method (Spectralbased clustering) compared with supervised method (SVM) and unsupervised methods((Hasegawa et al., 2004))’s method and K-means clustering.
P04-1053
Compared with supervised and semi-supervised methods, Hasegawa et al.(2004)’s unsupervised approach for relation extraction can overcome the difficulties on requirement of a large amount of labeled data and enumeration of all class labels.
P04-1053
Relation Dectection Relation Classification on Types on Subtypes Method P R F P R F P R F Culotta and Soresen (2004) Tree kernel based 81.2 51.8 63.2 67.1 35.0 45.8 Kambhatla (2004) Feature based, Maximum Entropy 63.5 45.2 52.8 Zhou et al.(2005) Feature based,SVM 84.8 66.7 74.7 77.2 60.7 68.0 63.1 49.5 55.5 the cluster number as the number of ground truth classes.
P04-1054 P04-3022 P05-1053
Moreover, the incorporation of various lexical and syntactic features into Hasegawa et al.(2004)’s method2 makes it outperform Hasegawa et al.(2004)’s method1 which only uses word feature.
P04-1053
Zhou et al.(2005) reported the best result as 63.1%/49.5%/55.5% in Precision/Recall/F-measure on the extraction of ACE relation subtypes using feature based method, which outperforms tree kernel based method by Culotta and Soresen (2004).
P04-1054 P05-1053
Hasegawa et al.(2004)’s method is to use a hierarchical clustering method to cluster pairs of named entities according to the similarity of context words intervening between the named entities.
P04-1053
We reported the clustering results using the same clustering strategy as Hasegawa et al.(2004) proposed.
P04-1053
It also does not need to pre-define the number of the context clusters or pre-specify the similarity threshold for the clusters as Hasegawa et al.568 (2004)’s method.
P04-1053
In Table 5, Hasegawa’s Method1 means the test used the word feature as Hasegawa et al.(2004) while Hasegawa’s Method2 means the test used the same feature set as our method.
P04-1053
