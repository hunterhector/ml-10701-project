In a combined chat and email summarization task, a technique (Zhou and Hovy, 2005) consisting of identifying APs and appending any relevant responses to topic initiating messages was instrumental in outperforming two competitive summarization baselines.
P05-1037
for extractive summarization We started our analyses with a large collection of features found to be good predictors in either speech (Inoue et al., 2004; Maskey and Hirschberg, 2005; Murray et al., 2005) or text summarization (Mani and Maybury, 1999).
W05-0905
Specifically, to account for skip-edges, we used a technique inspired by (Sha and Pereira, 2003), in which multiple state dependencies, such as an order-2 Markov model, are encoded using auxiliary tags.
N03-1028
In particular, we used the latent semantic analysis (LSA) feature discussed in (Murray et al., 2005), which attempts to determine sentence importance through singular value decomposition, and whose resulting singular values and singular vectors can be exploited toassociateeachutteranceadegreeofrelevanceto oneofthetop-nconceptsofthemeetings(wheren represents the number of dimensions in the LSA).
W05-0905
To find these pairs automatically, wetrainedanon-sequentiallog-linearmodel that achieves a .902 accuracy (Galley et al., 2004).
P04-1085
To train and evaluate our summarizer, we used a corpus of extractive summaries produced at the University of Edinburgh (Murray et al., 2005).
W05-0905
L.ZhouandE.Hovy. 2005.
P05-1037
We also used additional annotation that has been developed to support higher-level analyses of meeting structure, in particular the ICSI Meeting Recorder Dialog act (MRDA) corpus (Shriberg et al., 2004).
W04-2319
We follow (Murray et al., 2005) in using the same six meetings as test data, since each of these meetings has multiple reference summaries.
W05-0905
Once all SCUs have been identified, the Pyramid method is applied as in (Nenkova and Passonneau, 2004b): wecomputeascoreD byaddingfor each SCU present in the summary a score equal to the number of model summaries in which that SCU appears.
N04-1019
We used the same scoring mechanism as (Murray et al., 2005), though we extracted features for many different n values.
W05-0905
K.Zechner. 2002.
J02-4003
In email summarization (Rambow et al., 2004), ShresthaandMcKeown(2004)obtainedgoodperformance in automatic detection of questions and answers, which can help produce summaries that highlight or focus on the question and answer exchange.
C04-1128 N04-4027
Shriberg. 2004.
W04-2319
Two metrics have become quite popular in multi-document summarization, namely the Pyramid method (Nenkova and Passonneau, 2004b) and ROUGE (Lin, 2004).
N04-1019 W04-1013
Lexical features: · n-grams (n ≤ 3) · number of words · number of digits · number of consecutive repeats Information retrieval features: · max/sum/mean frequency of all terms in ut · max/sum/mean idf score · max/sum/mean tf·idf score · cosine similarity between word vector of ut with centroid of of the meeting · scores of LSA with 5, 10, 50, 100, 200, 300 concepts Acoustic features: · seconds of silence before/during/after the turn · speech rate · min/max/mean/median/stddev/onset/outset f0 of utterance t, and of first and last word · min/max/mean/stddev energy · .05, .25, .5, .75, .95 quantiles of f0 and energy · pitch range · f0 mean absolute slope Durational and structural features: · duration of the previous/current/next utterance · relative position within meeting (i.e., index t) · relative position within speaker turn · large number of structural predicates, i.e. “is the previous utterance of the same speaker?” · number of APs initiated in yt Discourse features: · lexical cohesion score (for topic shifts) (Hearst, 1994) · first and second word of utterance, if in cue word list · number of pronouns · numberoffillersandfluencydevices(e.g., “uh”, “um”) · number of backchannel and acknowledgment tokens (e.g., “uh-huh”, “ok”, “right”) Table 3: Features for extractive summarization.
P94-1002
We performed a last experiment to compare our bestsystemagainstMurrayetal.(2005), whoused the same test data, but constrained summary sizes in terms of number of DA units instead of words.
W05-0905
We performed feature selection by incrementally growing a log-linear model with order0 features f(x,yt) using a forward feature selection procedure similar to (Berger et al., 1996).
J96-1002
The best ROUGE-1 measure reported in (Murray et al., 2005) is .69 recall, which is significantly lower than ours according to confidence intervals.
W05-0905
F.ShaandF.Pereira. 2003.
N03-1028
We now assess the significance of our results by comparing our best system against: (1) a lead summarizer that always selects the first N utterances to match the predefined length; (2) human performance, which is obtained by leave-one-out comparisons among references (Table 7); (3) “optimal” summaries generated using the procedure explained in (Nenkova and Passonneau, 2004b) by ranking document utterances by the number of model summaries in which they appear.
N04-1019
In our own annotation of three meetings with SCUs defined as in (Nenkova and Passonneau, 2004a), we found that repetitions and reformulation of the same information are particularly infrequent, and that textual units that express the same content among model summaries are generally originating from the same document sentence (e.g., in the figure, the first sentence in model 1 and 2 emanate from the same document sentence).
N04-1019
Empirical evaluations using two standard summarization metrics—the Pyramid method (Nenkova and Passonneau, 2004b) and ROUGE (Lin, 2004)—show that the best performing system is a CRF incorporating both order-2 Markov dependencies and skip-chain dependencies, which achieves 91.3% of human performance in Pyramid score, and outperforms our best-performing non-sequential model by 3.9%. 2 Corpus The work presented here was applied to the ICSI Meeting Corpus (Janin et al., 2003), a corpus of “naturally-occurring” meetings, i.e. meetings that would have taken place anyway.
N04-1019 W04-1013
Most previous work with CRFs containing nonlocal dependencies used approximate probabilistic inference techniques, including TRP (Sutton and McCallum, 2004) and Gibbs sampling (Finkel et al., 2005).
P05-1045
In the case of summarization of conversational speech, Zechner (2002) found, for instance, that a simple technique consisting of linking together questions and answers in summaries—and thus preventing the selection of orphan questions or answers—significantly improved their readability according to various human summary evaluations.
J02-4003
