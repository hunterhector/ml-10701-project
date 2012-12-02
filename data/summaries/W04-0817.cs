We used the estimate software for estimation, which implements the LMVM algorithm (Malouf, 2002) and was kindly provided by Rob Malouf.
W02-2018
Maximum Entropy (Maxent) models have been successfully applied to semantic role labelling (Fleischman et al., 2003).
W03-1007
We recently studied semantic role labelling in the context of the CoNLL shared task (Baldewein et al., 2004).
W04-2413
For the head lemma clustering model, we define the appropriatenessa60 a31 a1a10a61a63a62a49a5 of a target:role pair a61a64a62 for a cluster a19 as follows: a60 a31 a1a4a61a64a62a49a5a36a7 a65 a66a68a67a70a69a72a71 a50a73a52 a65 a54a74a76a75 a56a10a77a73a78 a57 a1a4a79a80a5a10a0a2a1 a19 a38a79a16a5 where a60 a31 a1a10a61a63a62a49a5 is the total frequency of all head lemmas a79 that have been seen with a61a64a62, weighted by the class-membership probability of a79 in a19 . This appropriateness measure a60 a31 a1a4a61a64a62a49a5 is built on top of the class-based frequencies a57 a1a10a79a16a5a10a0a2a1 a19 a38a79a16a5 rather than on the frequencies a57 a1a10a79a16a5 or the class-membership probabilitiesa0a2a1 a19 a38a79a80a5 in isolation: For some tasks the combination of lexical and semantic information has been shown to outperform each of the single information sources (Prescher et al., 2000).
C00-2094
Generalisation. Gildea and Jurafsky (2002) report an improvement of 1.6% through generalisation, which is roughly comparable to our figures.
J02-3001
The key idea is that a3 a11 and a3 a15 are mutually independent, but conditioned on an unobserved class a19a21a20a23a22. In this manner, we define the probability of a3a24a7a25a1a10a3 a11 a12a14a3 a15 a5 a20 a26 a11a28a27 a26 a15 as: a0a2a1a10a3a29a5a30a7 a31a33a32a35a34 a0a2a1 a19 a12a14a3a6a5a36a7 a31a33a32a37a34 a0a2a1 a19 a5a10a0a2a1a10a3a39a38 a19 a5 a7 a31a33a32a35a34 a0a2a1 a19 a5a4a0a18a1a4a3 a11 a38 a19 a5a4a0a2a1a10a3 a15 a38 a19 a5 Estimation was performed using a variant of the expectation-maximisation algorithm (Prescher et al., 2000).
C00-2094
