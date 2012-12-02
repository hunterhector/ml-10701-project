Furthermore, the top K BFS search heuristic appears to be much simpler than the stack decoder algorithm outlined in (Magerman, 1995).
P95-1037
Table 5 shows results using the PARSEVAL measures, as well as results using the slightly more forgiving measures of (Collins, 1996) and (Magerman, 1995).
P95-1037 P96-1025
The PARSEVAL (Black and others, 1991) measures compare a proposed parse P with the corresponding correct treebank parse T as follows: # correct constituents in P Recall = # constituents in T # correct constituents in P Precision = # constituents in P A constituent in P is "correct" if there exists a constituent in T of the same label that spans the same words.
H91-1060
The search also uses a Tag Dictionary constructed from training data, described in (Ratnaparkhi, 1996), that reduces the number of actions explored by the tagging model.
W96-0213
Journal are the bigram parser described in (Collins, 1996) and the SPATTER parser described in (Jelinek et al., 1994; Magerman, 1995).
H94-1052 P95-1037 P96-1025
Black, Ezra et al.1991. A Procedure for Quantitatively Comparing the Syntactic Coverage of English Grammars.
H91-1060
Figure 10 shows that the "Exact Match", which counts the percentage of times 2Results for SPATTER on section 23 are reported in (Collins, 1996) Parser Precision Maximum Entropy ° 86.8% Maximum Entropy* 87.5% (Collins, 1996)* 85.7% (Magerman, 1995)* 84.3% Recall 85.6% 86.3% 85.3% 84.0% Table 5: Results on 2416 sentences of section 23 (0 to 100 words in length) of the WSJ Treebank.
P95-1037 P96-1025
The training samples are respectively used to create the models PT^G, PCHUNK, PBUILD, and PCMECK, all of which have the form: k p(a, b) = II _ij(o,b ~j (1) j----1 where a is some action, b is some context, ~" is a nor4 Model Categories Description Templates Used TAG See (Ratnaparkhi, 1996) CHUNK chunkandpostag(n)* BUILD CHECK chunkandpostag(m, n)* cons(n) cons(re, n)* cons(m, n,p) T punctuation checkcons(n)* checkcons(m,n)* production surround(n)* The word, POS tag, and chunk tag of nth leaf.
W96-0213
The maximum entropy models used here are similar in form to those in (Ratnaparkhi, 1996; Berger, Della Pietra, and Della Pietra, 1996; Lau, Rosenfeld, and Roukos, 1993).
H93-1021 J96-1002 W96-0213
Table 5 shows that the maximum entropy parser performs better than the parsers presented in (Collins, 1996) and (Magerman, 1995) ~, which have the best previously published parsing accuracies on the Wall St.
P95-1037 P96-1025
Model This paper takes a "history-based" approach (Black et al., 1993) where each tree-building procedure uses a probability model p(alb), derived from p(a, b), to weight any action a based on the available context, or history, b.
P93-1005
Constituent head words are found, when necessary, with the algorithm in (Magerman, 1995).
P95-1037
