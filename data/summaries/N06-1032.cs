2A comparison of the approaches of Quirk et al.(2005) and Menezes and Richardson (2001) with respect to ordering models is difficult because they differ from each other in their statistical and dependency-tree alignment models.
P05-1034 W01-1406
Minimum-error-rate training was done using Koehn’s implementation of Och’s (2003) minimum-error-rate model.
N03-1017 P03-1021
number of words in target string These statistics are combined into a log-linear model whose parameters are adjusted by minimum error rate training (Och, 2003).
P03-1021
The statistical components of our system are modeled on the phrase-based system of Koehn et al.(2003), and component weights are adjusted by minimum error rate training (Och, 2003).
N03-1017 P03-1021
In an experimental evaluation on the test-set that was used in Koehn et al.(2003) we show that for examples that are in coverage of the grammar-based system, we can achieve stateof-the-art quality on n-gram based evaluation measures.
N03-1017
3 Parsing-Transfer-Generation We use LFG grammars, producing c(onstituent)structures (trees) and f(unctional)-structures (attribute value matrices) as output, for parsing source and target text (Riezler et al., 2002; Butt et al., 2002).
P02-1035 W02-1503
Models and Training The statistical components of our system are modeled on the statistical components of the phrasebased system Pharaoh, described in Koehn et al.(2003) and Koehn (2004).
N03-1017
1A notable exception to this kind of approach is Chiang (2005) who introduces syntactic information into phrase-based SMT via hierarchical phrases rather than by external parsing.
P05-1033
Similar to phrase-based SMT, our approach starts with an improved word-alignment that is created by intersecting alignment matrices for both translation directions, and refining the intersection alignment by adding directly adjacent alignment points, and alignment points that align previously unaligned words (see Och et al.(1999)). Next, source and target sentences are parsed using source and target LFG grammars to produce a set of possible f(unctional) dependency structures for each side (see Riezler et al.(2002) for the English grammar and parser; Butt et al.(2002) for German).
P02-1035 W02-1503 W99-0604
The advantage of such models over grammar-based generation seems to be supported, for example, by Quirk et al.’s (2005) improvements over phrase-based SMT as well as over an SMT system that deploys a grammar-based generator (Menezes and Richardson, 2001) on ngram based automatic evaluation scores (Papineni et al., 2001; Doddington, 2002).
P05-1034 W01-1406
Under the NIST measure, we achieve results in the range of the state-of-the-art phrase-based system of Koehn et al.(2003) for in-coverage examples of the LFGbased system.
N03-1017
Recent approaches to statistical machine translation (SMT) piggyback on the central concepts of phrasebased SMT (Och et al., 1999; Koehn et al., 2003) and at the same time attempt to improve some of its shortcomings by incorporating syntactic knowledge in the translation process.
N03-1017 P03-1021 W99-0604
Final results are reported on the test set of 1,755 sentences of length 5-15 that was used in Koehn et al.(2003). To extract transfer rules, an improved bidirectional word alignment was created for the training data from the word alignment of IBM model 4 as 3http://people.csail.mit.edu/koehn/publications/europarl/ implemented by GIZA++ (Och et al., 1999).
N03-1017 W99-0604
We compared our system to IBM model 4 as produced by GIZA++ (Och et al., 1999) and a phrasebased SMT model as provided by Pharaoh (2004).
W99-0604
This information source is deployed in recent work either for pre-ordering source sentences before they are input to to a phrase-based system (Xia and McCord, 2004; Collins et al., 2005), or for re-ordering the output of translation models by statistical ordering models that access linguistic information on dependencies and part-of-speech (Lin, 2004; Ding and Palmer, 2005; Quirk et al., 2005)1.
C04-1073 C04-1090 P05-1034 P05-1066 P05-1067
Training sentences were parsed using German and English LFG grammars (Riezler et al., 2002; Butt et al., 2002).
P02-1035 W02-1503
