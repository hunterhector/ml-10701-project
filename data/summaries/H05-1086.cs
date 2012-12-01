We retrieved the top 1000 documents for each topic from the TREC and Aquaint collections, and sentence segmented the documents using MXTerminator (Reynar and Ratnaparkhi, 1997), which is a freely available sentence boundary detector.
A97-1004
In the estimation step, the probability that a term in the sentence “translates” to a term in the query is estimated using the implementation of IBM 1http://trec.nist.gov 2http://www.ldc.upenn.edu Model 1 (Brown et al., 1990) in GIZA++ (AlOnaizan et al., 1999) out-of-the-box without alteration.
J90-2002
They used IBM Model 1 (Brown et al., 1990), to rank documents according to their translation probability, given the query.
J90-2002
