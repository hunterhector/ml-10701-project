For example, a part-of-speech taggercouldconstraina“basephrase”chunker(Ratnaparkhi, 1999), or the n-best output of a parser could constrain a reranker (Charniak and Johnson, 2005).
P05-1022
Finkel et al.(2006)). This paper presents one such general technique, here applied to stochastic parsing, whereby output from later stages of a pipeline is used to constrain earlier stages of the same pipeline.
W06-1673
Second, base phrases can be extracted from the full-parse output of the Charniak and Johnson (2005) reranker, via a simple script to extract nodes with only preterminal children.
P05-1022
Following Charniak and Johnson (2005), we set the parser to output 50-best parses for all experiments described here.
P05-1022
The well-known Charniak (2000) coarse-to-fine parser is a two-stage parsing pipeline, in which the first stage uses a vanilla PCFG to populate a chart of parse constituents.
A00-2018
Charniak and Johnson (2005) extended this pipeline with a discriminative maximum entropy model to rerank the n-best parse candidates, deriving a significant benefit from the richer model employed by the reranker.
P05-1022
Table 5 shows a 0.4 percent F-score improvement over the baseline for that section, which is statistically significant at p < 0.001, using the stratified shuffling test (Yeh, 2000).
C00-2137
3.1. Unconstrained For our baseline system, we run the Charniak and Johnson (2005) parser and reranker with default parameters.
P05-1022
Pipeline systems are ubiquitous in natural language processing, used not only in parsing (Ratnaparkhi, 1999; Charniak, 2000), but also machine translation(OchandNey, 2003)andspeechrecognition (Fiscus, 1997; Goel et al., 2000), among others.
A00-2018 J03-1002
Charniak. 1998.
W98-1115
4, with the Charniak and Johnson (2005) reranker providing P1, effectively giving the reranker twice the weight of the shallow parser in determining the posteriors.
P05-1022
4. At the core of the pipeline is the Charniak and Johnson (2005) coarse-to-fine parser and MaxEnt reranker, described in Sec.
P05-1022
In this paper, we investigate pipeline iteration within the context of the Charniak and Johnson (2005) parsing pipeline, by constraining parses to be consistent with a base-phrase tree.
P05-1022
Journal (WSJ) Treebank (Marcus et al., 1993).
J93-2004
Figure3showstheresultsofperformingthiscombined precision/recall optimization on three separate n-best lists: the 50-best list of base-phrase trees extracted from the full-parse output of the Charniak and Johnson (2005) reranker; the 50-best list output by the Hollingshead et al.(2005) finite-state shallow parser; andtheweightedcombinationofthetwolists at various values of λ in Eq.
H05-1099 P05-1022
F.J.OchandH.Ney. 2003.
J03-1002
The shallow parser is trained using the perceptron algorithm, with a feature set nearly identical to that from Sha and Pereira (2003), and achieves comparable performance to that paper.
N03-1028
Goodman (1996; 1998) presents a method for using the posterior probability of constituents to maximize the expected labeled recall of binary branching trees, as follows: hatwideT = argmax T∈T summationdisplay X∈T γ(X) (2) Essentially, find the tree with the maximum sum of the posterior probabilities of its constituents.
P96-1024
The Charniak parsing pipeline has been extensively studied over the past decade, with a number of papers focused on improving early stages of the pipeline (Charniak et al., 1998; Caraballo and Charniak, 1998; Blaheta and Charniak, 1999; Hall and Johnson, 2004; Charniak et al., 2006) as well as many focused on optimizing final parse accuracy (Charniak, 2000; Charniak and Johnson, 2005; McClosky et al., 2006).
A00-2018 J98-2004 N06-1022 P04-1006 P05-1022 P06-1043 P99-1066 W98-1115
See Hollingshead et al.(2005) for more details.
H05-1099
Unlike the shallow phrases defined for the CoNLL-2000 Shared Task (Tjong Kim Sang and Buchholz, 2000), base phrases correspond directly to constituents that appear in full parses, and hence can provide a straightforward constraint on edges within a chart parser.
W00-0726
We derive thesebase-phraseconstraintsfromthreesources: the reranking stage of the parsing pipeline; a finite-state shallow parser (Hollingshead et al., 2005); and a combination of the output from these two sources.
H05-1099
