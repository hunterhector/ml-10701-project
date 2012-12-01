Florian et al.(2004) first train a NE tagger on the source domain, and then use the tagger’s predictions as features for training and testing on the target domain.
N04-1001
Recently there have been some studies addressing domain adaptation from different perspectives (Roark and Bacchiani, 2003; Chelba and Acero, 2004; Florian et al., 2004; Daum´e III and Marcu, 2006; Blitzer et al., 2006).
N03-1027 N04-1001 W04-3237 W06-1615
Chelba and Acero (2004) use the parameters of the maximum entropy model learned from the source domain as the means of a Gaussian prior when training a new model on the target data.
W04-3237
The POS data set and the CTS data set have previously been used for testing other adaptation methods (Daum´e III and Marcu, 2006; Blitzer et al., 2006), though the setup there is different from ours.
W06-1615
For generative syntactic parsing, Roark and Bacchiani (2003) have used the source domain data to construct a Dirichlet prior for MAP estimation of the PCFG for the target domain.
N03-1027
Blitzer et al.(2006) propose a domain adaptation method that uses the unlabeled target instances to infer a good feature representation, which can be regarded as weighting the features.
W06-1615
Following (Blitzer et al., 2006), we call the first the source domain, and the second the target domain.
W06-1615
