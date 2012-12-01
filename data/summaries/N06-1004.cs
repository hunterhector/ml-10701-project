Weights on the components were assigned using the (Och, 2003) method for max-BLEU training on the development set.
P03-1021
and Distortion Corpora 2.1 Defining Disperp The ultimate reason for choosing one SCM over another will be the performance of an MT system containing it, as measured by a metric like BLEU (Papineni et al., 2002).
P02-1040
Some interesting recent research focuses on reordering within a narrow window of phrases (Kumar and Byrne, 2005; Tillmann and Zhang, 2005; Tillmann, 2004).
H05-1021 N04-4026 P05-1069
The (Tillmann, 2004) paper introduced lexical features for distortion modeling.
N04-4026
Unlike some recent distortion models (Kumar and Byrne, 2005; Tillmann and Zhang, 2005; Tillmann, 2004) these Segment Choice Models (SCMs) allow phrases to be moved globally, between any positions in the sentence.
H05-1021 N04-4026 P05-1069
In experiments on other language pairs reported elsewhere (Johnson et al.2006), we applied a heuristic: DT training and decoding involved source sentences with 60 or fewer tokens, while longer sentences were handled with the distortion penalty.
W06-3118
1 Introduction: Defining SCMs The work presented here was done in the context of phrase-based MT (Koehn et al., 2003; Och and Ney, 2004).
J04-4002 N03-1017
A recent paper (Collins et al., 2005) shows that major gains can be obtained by constructing a parse tree for the source sentence and then applying handcrafted reordering rules to rewrite the source in target-language-like word order prior to MT.
P05-1066
Phrase tables were learned from the training corpus using the “diag-and” method (Koehn et al., 2003), and using IBM model 2 to produce initial word alignments (these authors found this worked as well as IBM4).
N03-1017
We plan to implement an alignment algorithm with smoothed phrase tables (Johnson et al.2006) to achieve segment alignment on 100% of the training data.
W06-3118
Another obvious system improvement would be to incorporate more advanced word-based features in the DTs, such as questions about word classes (Tillmann and Zhang 2005, Tillmann 2004).
N04-4026 P05-1069
A similar concept appears in (Collins et al., 2005) (this paper’s preoccupations strongly resemble 25 ours, though our method is completely different: we don’t parse the source, and use only automatically generated rules).
P05-1066
