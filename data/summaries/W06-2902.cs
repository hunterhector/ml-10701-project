For this reason we do not run experiments on the task considered in (Gildea, 2001) and (Roark and Bacchiani, 2003), where they are porting from the restricted domain of the WSJ corpus to the more varied domain of the Brown corpus as a whole.
N03-1027 W01-0521
The probabilistic model (Henderson, 2003) allows us to distinguish between those parameters responsible for the distributions of individual vocabulary items, and those parameters responsible for the distributions of structural decisions, as described in more details in section 4.2.
N03-1014
(Roark and Bacchiani, 2003) performed experiments on supervised and unsupervised PCFG adaptation to the target domain.
N03-1027
They achieved very good improvement over their baseline and over (Gildea, 2001), but the absolute accuracies were still relatively low (as discussed above).
W01-0521
Probabilistic Model of Parsing The probabilistic model of parsing in (Henderson, 2003) has two levels of parameterization.
N03-1014
In this paper, we focus on the TOP reranking kernel defined in (Henderson and Titov, 2005), which are closely related to Fisher kernels.
P05-1023
The best statistical parsers have shown good results on this benchmark, but these statistical parsers demonstrate far worse results when they are applied to data from a different domain (Roark and Bacchiani, 2003; Gildea, 2001; Ratnaparkhi, 1999).
N03-1027 W01-0521
This research has focused mostly on the development of statistical parsers trained on large annotated corpora, in particular the Penn Treebank WSJ corpus (Marcus et al., 1993).
J93-2004
(Collins and Duffy, 2002)), which are chosen on the basis of domain knowledge.
P02-1034
We use the Penn Treebank Wall Street Journal corpus as the large corpus and individual sections of the Brown corpus as the target corpora (Marcus et al., 1993).
J93-2004
As in other lexicalized statistical parsers, the probabilistic model we use treats words which are not frequent enough in the training set as ‘unknown’ words (Henderson, 2003).
N03-1014
(Matsuzaki et al., 2005; Koo and Collins, 2005)).
H05-1064 P05-1010
These results represent a 2.2% and 1.3% increase in F1 over the best previous results, respectively (see the discussion of (Roark and Bacchiani, 2003) below).
N03-1027
The motivation for the TOP reranking kernel is given in (Henderson and Titov, 2005), but for completeness we note that the its feature extractor is given by: φˆθ(x, yk) = (v(x, yk, ˆθ), ∂v(x,yk,ˆθ)∂θ1, . . ., ∂v(x,yk,ˆθ)∂θl ), (1) where v(x, yk, ˆθ) = log P(x, yk|ˆθ) − logsummationtexttnegationslash=k P(x, yt|ˆθ).
P05-1023
As suggested in (Henderson and Titov, 2005) use of the complete set of weights doesn’t lead to any improvement of the resulting reranker and makes the reranker training more computationally expensive.
P05-1023
This parsing model is also a good candidate for our experiments because it achieves state-of-the-art results on the standard Wall Street Journal (WSJ) parsing problem (Henderson, 2003), and data-defined kernels derived from this parsing model have recently been used with the Voted Perceptron algorithm on the WSJ parsing task, achieving a significant improvement in accuracy over the neural network parser alone (Henderson and Titov, 2005).
N03-1014 P05-1023
2 Data-Defined Kernels for Parsing Previous work has shown how data-defined kernels can be applied to the parsing task (Henderson and Titov, 2005).
P05-1023
There was improvement for each of the Brown sections, and this improvement was significant for two 6We measured significance in F1 measure at the 5% level with the randomized significance test of (Yeh, 2000).
C00-2137
Previous work (Roark and Bacchiani, 2003) has shown that better accuracy can be achieved by finding the optimal re-weighting between these two datasets, but this issue is orthogonal to our method, so we only consider equal weighting.
N03-1027
Gildea (2001) only reports results on sentences of 40 or less words on all the Brown corpus sections combined, for which he reports 80.3%/81.0% recall/precision when training only on data from the WSJ corpus, and 83.9%/84.8% when training on data from the WSJ corpus and all sections of the Brown corpus.
W01-0521
The probabilistic model is a neural network statistical parser (Henderson, 2003), and the data-defined kernel is a TOP reranking kernel (Henderson and Titov, 2005).
N03-1014 P05-1023
To address this problem, we propose constructing the kernel from a probabilistic model which has been reparameterized to better suit 1In (Shen and Joshi, 2003) it was proposed to use an ensemble of SVMs trained the Wall Street Journal corpus, but we believe that the generalization performance of the resulting classifier is compromised in this approach.
W03-0402
In (Henderson and Titov, 2005) it was proposed to apply a class of kernels derived from probabilistic models to the natural language parsing problem.
P05-1023
In addition to portability experiments with the parsing model of (Collins, 1997), (Gildea, 2001) provided a comprehensive analysis of parser portability.
P97-1003 W01-0521
We trained and tested the SSN parser in their “de-focusing” scenario using the same datasets as (Roark and Bacchiani, 2003).
N03-1027
In (Henderson and Titov, 2005), the kernel is constructed using the parameters of a trained probabilistic model.
P05-1023
derivations). Henderson (2003) uses a form of left-corner parsing strategy, and the decisions include generating the words of the sentence (i.e.
N03-1014
We choose to use an earlier neural network based probabilistic model of parsing (Henderson, 2003), whose hidden units can be viewed as approximations to latent variables.
N03-1014
