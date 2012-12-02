This discriminative property is shared by the methods of (Johnson et al.1999; Collins 2000), and also the Conditional Random Field methods of (Lafferty et al.2001). In a previous paper (Collins 2000), a boosting algorithm was used to rerank the output from an existing statistical parser, giving significant improvements in parsing accuracy on Wall Street Journal data.
P99-1069
The tagger was applied and trained in the same way as described in (Ratnaparkhi 1996).
W96-0213
As a baseline model we used a maximum entropy tagger, very similar to the ones described in (Ratnaparkhi 1996; Borthwick et.
W96-0213
al 1998; McCallum et al.2000). Max-ent taggers have been shown to be highly competitive on a number of tagging tasks, such as part-of-speech tagging (Ratnaparkhi 1996), named-entity recognition (Borthwick et.
W96-0213
Similar boosting algorithms have been applied to natural language generation, with good results, in (Walker et al.2001). In this paper we apply reranking methods to named-entity extraction.
N01-1003
See (Collins 2002) for additional work using perceptron algorithms to train tagging models, and a more thorough description of the theory underlying the perceptron algorithm applied to ranking problems.
P02-1034 W02-1001
(Collins and Duffy 2002) describe the voted perceptron applied to the named-entity data in this paper, but using kernel-based features rather than the explicit features described in this paper.
P02-1034 W02-1001
The framework is derived by the transformation from ranking problems to a margin-based classification problem in (Freund et al.1998). It is also related to the Markov Random Field methods for parsing suggested in (Johnson et al.1999), and the boosting methods for parsing in (Collins 2000).
P99-1069
Examples of such techniques are Markov Random Fields (Abney 1997; Della Pietra et al.1997; Johnson et al.1999), and boosting algorithms (Freund et al.1998; Collins 2000; Walker et al.2001). One appeal of these methods is their flexibility in incorporating features into a model: essentially any features which might be useful in discriminating good from bad structures can be included.
J97-4005 N01-1003 P99-1069
Another attractive property of the voted perceptron is that it can be used with kernels, for example the kernels over parse trees described in (Collins and Duffy 2001; Collins and Duffy 2002).
P02-1034 W02-1001
Following (Ratnaparkhi 1996), we only include features which occur 5 times or more in training data.
W96-0213
