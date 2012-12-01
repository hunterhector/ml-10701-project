In addition to four types of TMI methods, we include an alternative posterior-lattice indexing method in our comparison called PSPL (position-specific posterior lattices) (Chelba, 2005).
P05-1055
First, following (Chelba, 2005), we use a posterior-probability representation, as posteriors are resilient to approximations and can be quantized with only a few bits.
P05-1055
(Chelba, 2005) proposed a posterior-probability based approximate representation in which word hypotheses are merged w.r.t. word position, which is treated as a hidden variable.
P05-1055
3.2 Time-based Merging for Indexing First, (Yu, HLT2005) has shown that node posteriors can be replaced by a constant, with no negative effect on 417 search accuracy.
H05-1119
For the iCampus lecture corpus, the same set of queries was used as in (Chelba, 2005), which was collected from a group of users.
P05-1055
4.1 Setup We have evaluated our system on three different corpora, in an attempt to represent popular types of audio currently found on the Internet: • podcasts: short clips ranging from mainstream media like ABC and CNN to non-professionally produced edge content; • video clips, acquired from MSN Video; • online lectures: a subset of the MIT iCampus lecture collection (Glass, 2004).
W04-2902
A successful way for dealing with high word error rates is the use of recognition alternates (lattices) (Saraclar, 2004; Yu, 2004; Chelba, 2005).
H05-1119 P05-1055
E.g., this forbids the use of a two-stage method as in (Yu, HLT2005).
H05-1119
For example, (Yu, 2004) reports a 50% improvement of FOM (Figure Of Merit) for a word-spotting task in voice-mails, and (Yu, HLT2005) adopted the approach for searching personal audio collections, using a hybrid word/phoneme lattice search.
H05-1119
3 Time-based Merging for Indexing Our previous work (Yu, IEEE2005) has shown that in a word spotting task, ranking by phrase posteriors is in theory optimal if (1) a search hit is considered relevant if the query phrase was indeed said there, and (2) the user expects a ranked list of results such that the accumulative relevance of the top-n entries of the list, averaged over a range of n, is maximized.
H05-1119
We chose a simple document ranking method as described in (Chelba, 2005): Given query Q = (q1,···,qL), for each document D, expected term frequencies (ETF) of all sub-strings Q[i,j] = (qi,···,qj) are calculated: ETF(Q[i,j]|D)= summationdisplay ts,te P(∗,ts,Q[i,j],te,∗|O,D) (3) A document is returned if all query words are present.
P05-1055
