Also, as with any generative model, it may be easy to improve the parser’s accuracy by using discriminative retraining techniques (Henderson, 2004) or data-defined kernels (Henderson and Titov, 2005), with or even without introduction of any additional linguistic features.
P04-1013 P05-1023
We expect that the mean field approximation should demonstrate better results than feed-forward approximation on this task as it is theoretically expected and confirmed on the constituent parsing task (Titov and Henderson, 2007).
P07-1080
Instead we use a pruning strategy similar to that described in (Henderson, 2003), where it was applied to a considerably harder search problem: constituent parsing with a left-corner parsing order.
N03-1014
We thank Joakim Nivre and Sandra K¨ubler for an excellent tutorial on dependency parsing given at COLINGACL 2006.
W06-2933
146 2.3 Approximating ISBNs (Titov and Henderson, 2007) proposes two approximations for inference in ISBNs, both based on variational methods.
P07-1080
The second approximation proposed in (Titov and Henderson, 2007) takes into consideration the fact that, after each decision is made, all the preceding latent variables should have their means µi updated.
P07-1080
Recently several latent variable models for constituent parsing have been proposed (Koo and Collins, 2005; Matsuzaki et al., 2005; Prescher, 2005; Riezler et al., 2002).
H05-1064 P02-1035 P05-1010 W05-1512
We compare our generative models with the best parsers from the CoNLLX task, including the SVM-based parser of (Nivre et al., 2006) (the MALT parser), which uses the same parsing algorithm.
W06-2933
The labeled attachment scores for the ISBN with tuned features (TF) and local features (LF) and ISBN with tuned features and no edges connecting latent variable vectors (TF-NA) are presented in table 1, along with results for the MALT parser both with tuned and local feature, the MST parser (McDonald et al., 2006), and the average score (Aver) across all systems in the CoNLL-X shared task.
W06-2932
To test the feature induction abilities of our model we compare results with two feature sets, the feature set tuned individually for each language by (Nivre et al., 2006), and another feature set which includes only obvious local features.
W06-2933
Unlike the original definition in (Nivre et al., 2004) the Right-Arcr decision does not shift wj to the stack.
W04-2407
For the MALT parser we replicated the parameters from (Nivre et al., 2006) as described in detail on their web site.
W06-2933
Now it is easy to see why the original decision Right-Arcr (Nivre et al., 2004) had to be decomposed into two distinct decisions: the decision to construct a labeled arc and the decision to shift the word.
W04-2407
(Titov and Henderson, 2007) proposes two approximate models based on the variational approach.
P07-1080
Unlike (Nivre et al., 2006), we can not use a lookahead in our generative model, as was discussed in section 3, so a greedy method is unlikely to lead to a good approximation.
W06-2933
These results suggest that our generative model is quite competitive with respect to the best models, which are both discriminative.5 We would expect further improvement of ISBN results if we applied discriminative retraining (Henderson, 2004) or reranking with data-defined kernels (Henderson and Titov, 2005), even without introduction of any additional features.
P04-1013 P05-1023
In (Koo and Collins, 2005), an undirected graphical model for constituent parse reranking uses dependency relations to define the edges.
H05-1064
We build an ISBN model of dependency parsing using the parsing order proposed in (Nivre et al., 2004).
W04-2407
First, they show that the neural network of (Henderson, 2003) can be viewed as a coarse mean field approximation of ISBNs, which they call the feedforward approximation.
N03-1014
A similar model of (Prescher, 2005) uses a head-driven PCFG with latent heads, thus restricting the flexibility of the latent-variable model by using explicit linguistic constraints.
W05-1512
Incremental Sigmoid Belief Networks (Titov and Henderson, 2007) differ from simple dynamic SBNs in that they allow the model structure to depend on the output variable values.
P07-1080
Then we will define the generative parsing model, based on the algorithm of (Nivre et al., 2004), and propose an ISBN for this model.
W04-2407
In order to test the model’s feature induction abilities, we train models with two different sets of explicit conditioning features: the feature set individually tuned by (Nivre et al., 2006) for each considered language, and a minimal set of local features.
W06-2933
The CoNLL-X shared task (Buchholz and Marsi, 2006) made a wide selection of standardized treebanks for different languages available for the research community and allowed for easy comparison between various statistical methods on a standardized benchmark.
W06-2920
However, the success of the deterministic parsing strategy which uses the same parsing order (Nivre et al., 2006), suggests that it should be relatively easy to find an accurate approximation to the best parse with heuristic search methods.
W06-2933
They are latent variable models which are not tractable to compute exactly, but two approximations exist which have been shown to be effective for constituent parsing (Titov and Henderson, 2007).
P07-1080
As discussed in (Titov and Henderson, 2007), computing the conditional probabilities which we need for parsing is in general intractable with ISBNs, but they can be approximated efficiently in several ways.
P07-1080
The fact that our model defines a probability model over parse trees, unlike the previous state-ofthe-art methods (Nivre et al., 2006; McDonald et al., 2006), makes it easier to use this model in applications which require probability estimates, e.g. in language processing pipelines.
W06-2932 W06-2933
Undirected graphical models, in particular Conditional Random Fields, are the standard tools for shallow parsing (Sha and Pereira, 2003).
N03-1028
As discussed in (Titov and Henderson, 2007), undirected graphical models do not seem to be suitable for history-based parsing models.
P07-1080
(Charniak, 2000; Collins, 1999; Nivre et al., 2004)).
A00-2018 W04-2407
Incremental Sigmoid Belief Networks, used in this paper) was proposed and applied to constituent parsing in (Titov and Henderson, 2007).
P07-1080
However, instead of performing deterministic parsing as in (Nivre et al., 2004), we use this ordering to define a generative history-based model, by integrating word prediction operations into the set of parser actions.
W04-2407
In (Matsuzaki et al., 2005) non-terminals in a standard PCFG model are augmented with latent variables.
P05-1010
Our model achieves state-of-the-art performance on the languages we test, significantly outperforming the model of (Nivre et al., 2006) on two languages out of three and demonstrating about the same results on the third.
W06-2933
For this we use the parsing strategy for projective dependency parsing introduced in (Nivre et al., 2004), which is similar to a standard shift-reduce algorithm for context-free grammars (Aho et al., 1986).
W04-2407
These models achieve comparable accuracy, unlike with the discriminative SVM-based approach of (Nivre et al., 2006), where careful feature selection appears to be crucial.
W06-2933
While the model of (Matsuzaki et al., 2005) significantly outperforms the constrained model of (Prescher, 2005), they both are well below the state-of-the-art in constituent parsing.
P05-1010 W05-1512
In particular, the neural network constituent parsers in (Henderson, 2003) and (Henderson, 2004) can be regarded as coarse approximations to their corresponding ISBN model.
N03-1014 P04-1013
145 2 The Latent Variable Architecture In this section we will begin by briefly introducing the class of graphical models we will be using, Incremental Sigmoid Belief Networks (Titov and Henderson, 2007).
P07-1080
All the most accurate dependency parsing models are fully discriminative, unlike constituent parsing where all the state of the art methods have a generative component (Charniak and Johnson, 2005; Henderson, 2004; Collins, 2000).
A00-2018 P04-1013 P05-1022
It is based on Incremental Sigmoid Belief Networks (ISBNs), a class of directed graphical model for structure prediction problems recently proposed in (Titov and Henderson, 2007), where they were demonstrated to achieve competitive results on the constituent parsing task.
P07-1080
Following (Nivre et al., 2006), we used pseudo-projective transformation they proposed to cast non-projective parsing tasks as projective.
W06-2933
Another advantage of generative models is that they do not suffer from the label bias problems (Bottou, 1991), which is a potential problem for conditional or deterministic history-based models, such as (Nivre et al., 2004).
W04-2407
We also conduct a controlled experiment where we used the tuned features of (Nivre et al., 2006) but disable the feature induction abilities of our model by elimination of the edges connecting latent state vectors.
W06-2933
For the mean field approximation, propagating the error all the way back through the structure of the graphical model requires a more complicated calculation, but it can still be done efficiently (see (Titov and Henderson, 2007) for details).
P07-1080
For details we refer the reader to (Nivre et al., 2004).
W04-2407
We analyze how the relation accuracy changes with the length of the head-dependent relation, demonstrating that our model very significantly outperforms the state-of-the-art baseline of (Nivre et al., 2006) on long dependencies.
W06-2933
One of the surprising things discovered by this evaluation is that the best results are achieved by methods which are quite different from state-of-the-art models for constituent parsing, e.g. the deterministic parsing method of (Nivre et al., 2006) and the minimum spanning tree parser of (McDonald et al., 2006).
W06-2932 W06-2933
