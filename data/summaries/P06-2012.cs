Many methods have been proposed to deal with this task, including supervised learning algorithms (Miller et al., 2000; Zelenko et al., 2002; Culotta and Soresen, 2004; Kambhatla, 2004; Zhou et al., 2005), semi-supervised learning algorithms (Brin, 1998; Agichtein and Gravano, 2000; Zhang, 2004), and unsupervised learning algorithm (Hasegawa et al., 2004).
A00-2030 P04-1053 P04-1054 P04-3022 P05-1053 W02-1010
Experiment results on the ACE corpus show that our method achieves better performance than other unsupervised methods, i.e.Hasegawa et al.(2004)’s method and Kmeans-based method.
P04-1053
Especially, although we did not concern the dependency tree and full parse tree information as other supervised methods (Miller et al., 2000; Culotta and Soresen, 2004; Kambhatla, 2004; Zhou et al., 2005), the incorporation of simple features, such as words and chunking information, still can provide complement information for capturing the characteristics of entity pairs.
A00-2030 P04-1054 P04-3022 P05-1053
Compared with supervised and semi-supervised methods, Hasegawa et al.(2004)’s unsupervised approach for relation extraction can overcome the difficulties on requirement of a large amount of labeled data and enumeration of all class labels.
P04-1053
with other Unsupervised methods In (Hasegawa et al., 2004), they preformed unsupervised relation extraction based on hierarchical clustering and they only used word features between entity mention pairs to construct context vectors.
P04-1053
Moreover, the incorporation of various lexical and syntactic features into Hasegawa et al.(2004)’s method2 makes it outperform Hasegawa et al.(2004)’s method1 which only uses word feature.
P04-1053
For comparison of the effect of the outer context of entity mention pairs, we conducted three different Table 5: Performance of our proposed method (Spectralbased clustering) compared with other unsupervised methods: ((Hasegawa et al., 2004))’s clustering method and K-means clustering.
P04-1053
Hasegawa et al.(2004)’s method is to use a hierarchical clustering method to cluster pairs of named entities according to the similarity of context words intervening between the named entities.
P04-1053
It also does not need to pre-define the number of the context clusters or pre-specify the similarity threshold for the clusters as Hasegawa et al.(2004)’s method.
P04-1053
We reported the clustering results using the same clustering strategy as Hasegawa et al.(2004) proposed.
P04-1053
In Table 5, Hasegawa’s Method1 means the test used the word feature as Hasegawa et al.(2004) while Hasegawa’s Method2 means the test used the same feature set as our method.
P04-1053
