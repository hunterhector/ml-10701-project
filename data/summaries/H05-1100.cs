In our work, we included all features described in (Collins and Koo, 2005).
J05-1003
The bestreported F1 constituency scores from this work for each language are 79.9% (Chinese (Chiang and Bikel, 2002)), 81.0% (French (Arun and Keller, 2005), 76.2% (German (Dubey, 2005)), and 73.8% (Spanish (Moreno et al., 2000)).
C02-1126 P05-1038
Morphological Information The mechanism we employ for incorporating morphological information is the modification of the POS tagset of a lexicalized PCFG2 — the Model 1 parser described in (Collins, 1999) (hereafter Model 1).
P99-1065
with Reranking In the reranking experiments, we follow the procedure described in (Collins and Koo, 2005) for creation of a training set with n-best parses for each sentence.
J05-1003
The mechanism we employ for incorporating morphology into the PCFG model (the Model 1 parser in (Collins, 1999)) is the modification of its part-ofspeech (POS) tagset; in this paper, we explain how this mechanism allows the parser to better capture morphological constraints.
P99-1065
It is well-known that tree representation influences parsing performance (Johnson, 1998).
J98-4004
For instance, work has been done in Chinese using the Penn Chinese Treebank (Levy and Manning, 2003; Chiang and Bikel, 2002), in Czech using the Prague Dependency Treebank (Collins et al., 1999), in French using the French Treebank (Arun and Keller, 2005), in German using the Negra Treebank (Dubey, 2005; Dubey and Keller, 2003), and in Spanish using the UAM Spanish Treebank (Moreno et al., 2000).
C02-1126 J05-1003 P03-1013 P03-1056 P05-1038 P99-1065
The authors in (Collins et al., 1999) describe an approach that gives 80% accuracy in recovering unlabeled dependencies in Czech.1 The project that is arguably most akin to the work presented in this paper is that on Spanish parsing (Moreno et al., 2000).
P99-1065
We used the optimal morphological model (n(A,D,N,V,P)+m(V)) to generate the n-best lists, and we used the feature set described in (Collins and Koo, 2005).
J05-1003
Previous approaches (e.g., (Collins and Koo, 2005)) have used a linear model to combine the log probability under a base parser with arbitrary features derived from parse trees.
J05-1003
Our baseline model, which we used to evaluate the effects of using morphology, was Model 1 (Collins, 1999) with a simple POS tagset containing almost no morphological information.
P99-1065
Work The statistical parsing of English has surpassed 90% accuracy in the precision and recall of labeled constituents (e.g., (Collins, 1999; Charniak and Johnson, 2005)).
J05-1003 P05-1022 P99-1065
Previous work in statistical parsing (Collins and Koo, 2005) has shown that applying reranking techniques to the n-best output of a base parser can improve parsing performance.
J05-1003
We have found that features in (Collins and Koo, 2005), initially developed for English parsing, also give appreciable gains in accuracy when applied to Spanish.
J05-1003
Prior to running the parsers, we trained the POS tagger described in (Collins, 2002).
W02-1001
