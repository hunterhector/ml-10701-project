Previous results (Henderson, 2003a) indicate that this vocabulary size performs better than the smaller ones, as would be expected.
N03-1014
Our best performing model is more accurate than all these previous models except (Bod, 2003).
E03-1005
This paper outlines each of these components, but more details can be found in (Henderson, 2003b), and, for the discriminative model, in (Henderson, 2003a).
N03-1014
However, the fact that the DGSSN uses a large-vocabulary tagger (Ratnaparkhi, 1996) as a preprocessing stage may compensate for its smaller vocabulary.
W96-0213
In this form, the distinction between our two models is sometimes referred to as \joint versus conditional" (Johnson, 2001; Klein and Manning, 2002) rather than \generative versus discriminative" (Ng and Jordan, 2002).
P01-1042 W02-1002
In each case the input to the network is a sequence of tag-word pairs.5 5We used a publicly available tagger (Ratnaparkhi, 1996) to provide the tags.
W96-0213
Experiments We used the Penn Treebank (Marcus et al., 1993) to perform empirical experiments on the proposed parsing models.
J93-2004
The input features for these loglinear models are the real-valued vectors computed by h(d1;:::; di 1) and l(yield(di;:::; dm)), as explained in more detail in (Henderson, 2003b).
N03-1014
While both (Johnson, 2001) and (Klein and Manning, 2002) propose models which use the parameters of the generative model but train to optimize a discriminative criteria, neither proposes training algorithms which are computationally tractable enough to be used for broad coverage parsing.
P01-1042 W02-1002
This joint probability is simply P(d1;:::; dm), since the 1More details on the mapping to parses can be found in (Henderson, 2003b).
N03-1014
This provides the neural network with a linguistically appropriate inductive bias when it learns the history representations, as explained in more detail in (Henderson, 2003b).
N03-1014
Collins (2000) and Collins and Du y (2002) also succeed in nding algorithms for training discriminative models which balance tractability with e ectiveness, showing improvements over a generative model.
P02-1034
In the context of part-of-speech tagging, Klein and Manning (2002) argue for the same distinctions made here between discriminative models and discriminative training criteria, and come to the same conclusions.
W02-1002
Therefore we compute l(yield(di;:::; dm)) by running a recurrent neural network backward over the string, so that the most recent input is the rst word in the lookahead string, as discussed in more detail in (Henderson, 2003a).
N03-1014
History-Based Probability Models As with many previous statistical parsers (Ratnaparkhi, 1999; Collins, 1999; Charniak, 2000), we use a history-based model of parsing.
A00-2018
Klein and Manning (2002) argue that these results show a pattern where discriminative probability models are inferior to generative probability models, but that improvements can be achieved by keeping a generative probability model and training according to a discriminative optimization criteria.
W02-1002
Performance of the latter model on the standard test set achieves 90.1% F-measure on constituents, which is the second best current accuracy level, and only 0.6% below the current best (Bod, 2003).
E03-1005
For comparison to previous results, table 2 lists the results for our best model (DGSSNFreq 20, rerank)9 and several other statistical parsers (Ratnaparkhi, 1999; Collins, 1999; Collins and Du y, 2002; Charniak, 2000; Collins, 2000; Bod, 2003) on the entire testing set.
A00-2018 E03-1005 P02-1034
Work Johnson (2001) investigated similar issues for parsing and tagging.
P01-1042
