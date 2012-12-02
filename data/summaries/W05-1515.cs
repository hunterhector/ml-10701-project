These features perform binary tests on the state directly, unlike Henderson (2003) which works with an intermediate representation of the history.
N03-1014
Bikel (2004) is a “clean room” reimplementation of the Collins parser (Collins, 1999) with comparable accuracy.
J04-4004
Set Results Table 9 shows the results of our best parser on the 15 words test set, as well as the accuracy reported for a recent discriminative parser (Taskar et al., 2004) and scores we obtained by training and testing the parsers of Charniak (2000) and Bikel (2004) on the same data.
A00-2018 J04-4004 W04-3201
(Bikel, 2004) 4.
J04-4004
Like Yamada and Matsumoto (2003) and Sagae and Lavie (2005), our parser is driven by classifiers.
W05-1513
Although some of our feature types are based on prior work (Collins, 1999; Klein & Manning, 2003; Bikel, 2004), we note that our scoring function uses more history information than typical parsers.
J03-4003 J04-4004 P03-1054 P04-1015
7. POS tag the text using Ratnaparkhi (1996).
W96-0213
It’s also worth noting that Collins and Roark (2004) saw a LFMS improvement of 0.8% over their baseline discriminative parser after adding punctuation features, one of which encoded the sentence-final punctuation.
P04-1015
Width To determine the effect of the beam width on the accuracy, we evaluated the baseline on the development set using a beam width of 1, i.e. parsing entirely greedily (Wong & Wu, 1999; Kalt, 2004; Sagae & Lavie, 2005).
W04-3203 W05-1513
Although training time is still a concern in our setup, the situation is ameliorated by generating training examples in advance and inducing one-vs-all classifiers in parallel, a technique similar in spirit to the POS-tag parallelization in Yamada and Matsumoto (2003) and Sagae and Lavie (2005).
W05-1513
Test Test Test Dev Dev Dev LFMS LRCL LPRC LFMS LRCL LPRC Full vocab 87.13 86.47 87.80 87.50 86.85 88.15 Bikel (2004) 88.85 88.31 89.39 86.82 86.43 87.22 Taskar et al.(2004) 89.12 89.10 89.14 89.98 90.22 89.74 Charniak (2000) 90.09 90.01 90.17 89.50 89.69 89.32 bias is to cope with the noise by favoring negative confidences predictions for ambiguous ADJP and ADVP decisions, hence their abysmal labelled recall.
A00-2018 J04-4004 W04-3201
Our implementation is freely available at: http://cs.nyu.edu/~turian/ software/parser/ 1 Introduction Discriminative machine learning methods have improved accuracy on many NLP tasks, such as POStagging (Toutanova et al., 2003), machine translation (Och & Ney, 2002), and relation extraction (Zhao & Grishman, 2005).
N03-1033 P02-1038 P05-1052
(This convention was established by Magerman (1995).) 3.
P95-1037
Training discriminative parsers is notoriously slow, especially if it requires generating examples by repeatedly parsing the treebank (Collins & Roark, 2004; Taskar et al., 2004).
P04-1015 W04-3201
a As pointed out by an anonymous reviewer of Collins (2003), removing outermost punctuation may discard useful information.
J03-4003
It is similar to the method used in the literature by deterministic parsers (Yamada & Matsumoto, 2003; Sagae & Lavie, 2005) with one exception: Depending upon the order constituents are inferred, there may be multiple bottom-up paths that lead to the same final parse, so to generate training examples we choose a single random path that leads to the gold-standard parse tree.1 The training examples correspond to all candidate inferences considered in every state along this path, nearly all of which are incorrect inferences (with y = 1).
W05-1513
(Bikel, 2004) 5.
J04-4004
Taskar et al.(2004)’s output was unavailable for significance testing, but presumably its differences from the full vocab parser are also significant.
W04-3201
Following Taskar, Klein, Collins, Koller, and Manning (2004), we trained and tested on 15 word sentences in the English Penn Treebank (Taylor et al., 2003), 10% of the entire treebank by word count.3 We used sections 02–21 (9753 sentences) for training, section 24 (321 sentences) for development, and section 23 (603 sentences) for testing, preprocessed as per Table 3.
P04-1015 W04-3201
Although our example weights are unnormalized, so far we’ve found no benefit from scalingepsilon1 as Collins and Koo (2005) suggest.
J05-1003
This approach differs from that of Yamada and Matsumoto (2003) and Sagae and Lavie (2005), who parallelize according to the POS tag of one of the child items.
W05-1513
Both Charniak (2000) and Bikel (2004) were trained using the goldstandard tags, as this produced higher accuracy on the development set than using Ratnaparkhi (1996)’s tags.
A00-2018 J04-4004 W96-0213
By giving the parser access to the same features used by taggers, especially rich lexical features (Toutanova et al., 2003), the parser might learn to compensate for tagging errors.
N03-1033
