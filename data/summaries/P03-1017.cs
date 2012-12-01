Each element of the resulting vector was replaced with its log-likelihood value (see Definition 10 in Section 2.3) which can be considered as an estimate of how surprising or distinctive a co-occurrence pair is (Dunning, 1993).
J93-1003
Our approach differs from Lin (1998) in three important ways: (a) by introducing dependency paths we can capture non-immediate relationships between words (i.e., between subjects and objects), whereas Lin considers only local context (dependency edges in our terminology); the semantic space is therefore constructed solely from isolated head/modifier pairs and their inter-dependencies are not taken into account; (b) Lin creates the semantic space from the set of dependency edges that are relevant for a given word; by introducing dependency labels and the path value function we can selectively weight the importance of different labels (e.g., subject, object, modifier) and parametrize the space accordingly for different tasks; (c) considerable flexibility is allowed in our formulation for selecting the dimensions of the semantic space; the latter can be words (see the leaves in Figure 1), parts of speech or dependency edges; in Lin’s approach, it is only dependency edges (features in his terminology) that form the dimensions of the semantic space.
P98-2127
Vector-based models of word co-occurrence have proved a useful representational framework for a variety of natural language processing (NLP) tasks such as word sense discrimination (Schütze, 1998), text segmentation (Choi et al., 2001), contextual spelling correction (Jones and Martin, 1997), automatic thesaurus extraction (Grefenstette, 1994), and notably information retrieval (Salton et al., 1975).
A97-1025 W01-0514
It extends prior work on syntax-based models (Grefenstette, 1994; Lin, 1998), by providing a general framework for defining context so that a large number of syntactic relations can be used in the construction of the semantic space.
P98-2127
We experimented with a variety of distance measures such as cosine, Euclidean distance, L1 norm, Jaccard’s coefficient, Kullback-Leibler divergence and the Skew divergence (see Lee 1999 for an overview).
P99-1004
The Skew divergence represents a generalisation of the Kullback-Leibler divergence and was proposed by Lee (1999) as a linguistically motivated distance measure.
P99-1004
We used Lin’s (1998) broad coverage dependency parser MINIPAR to obtain a parsed version of the corpus.
P98-2127
However, existing models either concentrate on specific relations for constructing the semantic space such as objects (e.g., Lee, 1999) or collapse all types of syntactic relations available for a given target word (Grefenstette, 1994; Lin, 1998).
P98-2127 P99-1004
Context is typically treated as a set of unordered words, although in some cases syntactic information is taken into account (Lin, 1998; Grefenstette, 1994; Lee, 1999).
P98-2127 P99-1004
