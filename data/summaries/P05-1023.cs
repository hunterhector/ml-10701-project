History-Based Probability Model As with many other statistical parsers (Ratnaparkhi, 1999; Collins, 1999; Charniak, 2000), Henderson (2003) uses a history-based model of parsing.
A00-2018 N03-1014
For comparison to previous results, table 2 lists the results on the testing set for our best model (TOP-Efficient-Freq≥20) and several other statistical parsers (Collins, 1999; Collins and Duffy, 2002; Collins and Roark, 2004; Henderson, 2003; Charniak, 2000; Collins, 2000; Shen and Joshi, 2004; Shen et al., 2003; Henderson, 2004; Bod, 2003).
A00-2018 E03-1005 N03-1014 P02-1034 P04-1013 P04-1015 W03-0402 W03-1012
First note that the parser based on the TOP efficient kernel has better accuracy than (Henderson, 2003), which used the same parsing method as our baseline model, although the trained network parameters were not the same.
N03-1014
In particular, most of the work on parsing with kernel methods has focussed on kernels over parse trees (Collins and Duffy, 2002; Shen and Joshi, 2003; Shen et al., 2003; Collins and Roark, 2004).
P02-1034 P04-1015 W03-0402 W03-1012
For this we use a statistical parser which has previously been shown to achieve state-of-the-art performance, namely that proposed in (Henderson, 2003).
N03-1014
For the probabilistic model, we use a state-of-the-art neural network based statistical parser (Henderson, 2003).
N03-1014
He defines the mapping from phrase structure trees to parse sequences using a form of left-corner parsing strategy (see (Henderson, 2003) for more details).
N03-1014
Instead, Henderson (2003) uses a neural network to induce a finite representation of this unbounded history, which we will denote h(d1,...,di−1).
N03-1014
The most sophisticated of these techniques (such as Support Vector Machines) are unfortunately too computationally expensive to be used on large datasets like the Penn Treebank (Marcus et al., 1993).
J93-2004
4We measured significance with the randomized significance test of (Yeh, 2000).
C00-2137
In each case the input to the network is a sequence of tag-word pairs.2 We report results for two different vocabulary sizes, varying in the frequency with which tag-word pairs must 2We used a publicly available tagger (Ratnaparkhi, 1996) to provide the tags.
W96-0213
Shen and Joshi (2003) applied an SVM based voting algorithm with the Preference kernel defined over pairs for reranking.
W03-0402 W03-1012
The VP algorithm was originally applied to parse reranking in (Collins and Duffy, 2002) with the Tree kernel.
P02-1034
In (Shen et al., 2003) it was pointed out that most of the arbitrary tree fragments allowed by the Tree kernel are linguistically meaningless.
W03-0402 W03-1012
1For example, see (Henderson, 2004) for a discussion of why generative models are better than models parameterized to estimate the a posteriori probability directly.
P04-1013
When compared to other kernel methods, our approach performs better than those based on the Tree kernel (Collins and Duffy, 2002; Collins and Roark, 2004), and is only 0.2% worse than the best results achieved by a kernel method for parsing (Shen et al., 2003; Shen and Joshi, 2004).
P02-1034 P04-1015 W03-0402 W03-1012
Work The first application of kernel methods to parsing was proposed by Collins and Duffy (2002).
P02-1034
(Taskar et al., 2004) suggested a method for maximal margin parsing which employs the dynamic programming approach to decoding and parameter estimation problems.
W04-3201
This provides the neural network with a linguistically appropriate inductive bias when it learns the history representations, as explained in more detail in (Henderson, 2003).
N03-1014
Experimental Results We used the Penn Treebank WSJ corpus (Marcus et al., 1993) to perform empirical experiments on the proposed parsing models.
J93-2004
