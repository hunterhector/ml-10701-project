Work Jing (2000) was perhaps the rst to tackle the sentence compression problem.
A00-1043
Examples include text summarisation (Jing 2000), subtitle generation from spoken transcripts (Vandeghinste and Pan 2004) and information retrieval (Olivers and Dolan 1999).
A00-1043 W04-1015
In a discriminative setting (Knight and Marcu 2002; Riezler et al.2003; McDonald 2006), sentences are represented by a rich feature space (typically induced from parse trees) and the goal is to learn rewrite rules indicating which words should be deleted in a given context.
E06-1038 N03-1026
Integer programming has been recently applied to several classi cation tasks, including relation extraction (Roth and Yih 2004), semantic role labelling (Punyakanok et al.2004), and the generation of route directions (Marciniak and Strube 2005).
C04-1197 W04-2401 W05-0618
The decoding process used in Turner and Charniak’s (2005) model rst searches for the best combination of rules to apply.
P05-1036
Approaches based on the noisy-channel model (Knight and Marcu 2002; Turner and Charniak 2005) consist of a source model P(s) (whose role is to guarantee that the generated compression is grammatical), a channel model P(l|s) (capturing the probability that the long sentence l is an expansion of the compressed sentence s), and a decoder (which searches for the compression s that maximises P(s)P(l|s)).
P05-1036
Discriminative formulations of the compression task include decision-tree learning (Knight and Marcu 2002), maximum entropy (Riezler et al.2003), support vector machines (Nguyen et al.2004), and large-margin learning (McDonald 2006).
C04-1107 E06-1038 N03-1026
Unsupervised approaches to the compression problem are few and far between (see Hori and Furui 2004 and Turner and Charniak 2005 for exceptions).
P05-1036
In contrast to Jing (2000), the bulk of the research on sentence compression relies exclusively on corpus data for modelling the compression process without recourse to extensive knowledge sources (e.g., WordNet).
A00-1043
Finally, the model that includes the signi cance score was optimised against a loss function similar to McDonald (2006) to bring the language model and the score into harmony.
E06-1038
Recent years have witnessed increased interest on a simpler instantiation of the compression problem, namely word deletion (Knight and Marcu 2002; Riezler et al.2003; Turner and Charniak 2005).
N03-1026 P05-1036
To counteract this, human judgements are often collected on compression output; however the evaluations are limited to small subject pools (often four judges; Knight and Marcu 2002; Turner and Charniak 2005; McDonald 2006) which makes dif cult to apply inferential statistics on the data.
E06-1038 P05-1036
Both variants employed the constraints described in Section 3.2 but differed in that one variant included the signi cance 2Turner and Charniak (2005) argue that the noisy-channel model is not an appropriate compression model since it uses a source model trained on uncompressed sentences and as a result tends to consider compressed sentences less likely than uncompressed ones.
P05-1036
In other models (Hori and Furui 2004; McDonald 2006) the compression score is maximised 145 using dynamic programming.
E06-1038
Generative approaches (Knight and Marcu 2002; Turner and Charniak 2005) are instantiations of the noisy-channel model: given a long sentence l, the aim is to nd the corresponding short sentence s which maximises the conditional probability P(s|l).
P05-1036
The channel model is typically estimated using a parallel corpus, although Turner and Charniak (2005) also present semi-supervised and unsupervised variants of the channel model that estimate P(l|s) without parallel data.
P05-1036
Our constraints are linguistically and semantically motivated in a similar fashion to the grammar checking component of Jing (2000).
A00-1043
