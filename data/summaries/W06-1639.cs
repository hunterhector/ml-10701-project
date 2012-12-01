Default parameters were used, although experimentation with different parameter settings is an important direction for future work (Daelemans and Hoste, 2002; Munson et al., 2005).
H05-1068
More sophisticated approaches have been proposed (Hillard et al., 2003), including an extension that, in an interesting reversal of our problem, makes use of sentimentpolarity indicators within speech segments (Galley et al., 2004).
N03-2012 P04-1085
Task properties Determining whether or not a speaker supports a proposal falls within the realm of sentiment analysis, an extremely active research area devoted to the computational treatment of subjective or opinion-oriented language (early work includes Wiebe and Rapaport (1988), Hearst (1992), Sack (1994), and Wiebe (1994); see Esuli (2006) for an active bibliography).
J94-2004 P88-1016
A few others incorporate various measures of inter-document similarity between the texts to be labeled (Agarwal and Bhattacharyya, 2005; Pang and Lee, 2005; Goldberg and Zhu, 2006).
P05-1015 W06-3808
As has been previously observed and exploited in the NLP literature (Pang and Lee, 2004; Agarwal and Bhattacharyya, 2005; Barzilay and Lapata, 2005), the above optimization function, unlike many others that have been proposed for graph or set partitioning, can be solved exactly in an provably efficient manner via methods for finding minimum cuts in graphs.
H05-1042 P04-1035 P05-1015
Also relevant is work on the general problems of dialog-act tagging (Stolcke et al., 2000), citation analysis (Lehnert et al., 1990), and computational rhetorical analysis (Marcu, 2000; Teufel and Moens, 2002).
J00-3003 J02-4002
Wiebe. 1994.
J94-2004
In particular, since we treat each individual speech within a debate as a single “document”, we are considering a version of document-level sentiment-polarity classification, namely, automatically distinguishing between positive and negative documents (Das and Chen, 2001; Pang et al., 2002; Turney, 2002; Dave et al., 2003).
P02-1053 W02-1011
Previous sentiment-analysis work in different domains has considered inter-document similarity (Agarwal and Bhattacharyya, 2005; Pang and Lee, 2005; Goldberg and Zhu, 2006) or explicit 333 inter-document references in the form of hyperlinks (Agrawal et al., 2003).
P05-1015 W06-3808
speech segments in isolation In our experiments, we employed the well-known classifier SVMlight to obtain individual-document classification scores, treating Y as the positive class and using plain unigrams as features.5 Following standard practice in sentiment analysis (Pang et al., 2002), the input to SVMlight consisted of normalized presence-of-feature (rather than frequency-of-feature) vectors.
W02-1011
