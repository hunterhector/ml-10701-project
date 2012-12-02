Applying such a filter in the 20K experiment, has a similar impact on performance as the transform filter of the previous paragraph, with F1 rising to 0.84.4 Several researchers have established the utility of a filter in which the broader context distributions surrounding two terms are compared, in an effort to insure that they are semantically compatible (Schone and Jurafsky, 2001; Yarowsky and Wicentowski, 2001).
N01-1024
A somewhat tighter definition of co-occurrence, which nevertheless yields a semantic distance measure, serves as the basis of a method that captures irregular inflectional transformations in Yarowsky and Wicentowski (2001).1 Schone and Jurafsky (2001) employ distributions over adjacent words (yielding a syntactic distance metric) to improve the precision of their conflation sets.
N01-1024
2. In the form of transformation rules, it can help us classify unknown words, thereby enhancing the utility of cluster-based features for applications such as information extraction (Miller et al., 2004; Freitag, 2004).
N04-1043 W04-3234
The search for such rules has previously been conducted in the context of supervised part-of-speech tagging (Mikheev, 1997), but not to our knowledge using word clusters.
J97-3003
Combined with heuristics such as string edit distance, it can be used to find reliable conflation sets (Xu and Croft, 1998; Baroni et al., 2002).
W02-0606
Nevertheless, these metrics give us a point of comparison with Schone and Jurafsky (2001) who, using a vocabulary of English words occurring at least 10 times in a 6.7 millionword newswire corpus, report F1 of 88.1 for con133 flation sets based only on suffixation, and 84.5 for circumfixation.
N01-1024
This approach to term clustering is closely related to others from the literature (Brown et al., 1992; Clark, 2000).2 Recall that the mutual information between random variables a0 and a1 can be written: a2a4a3a6a5a8a7a10a9a11a13a12a15a14a17a16a19a18a21a20a23a22a25a24a27a26a29a28 a14a17a16a19a18a21a20a23a22a25a24 a14a17a16a19a18a30a24a31a14a17a16a19a22a32a24 (1) Here, a0 and a1 correspond to term and context clusters, respectively, each event a18 and a22 the observation of some term and contextual term in the corpus.
J92-4003 W00-0717
MDL has information theoretic underpinnings, and an information theoretic objective function achieves similar success (Snover et al., 2002).
W02-0602
Several researchers propose algorithms based on the minimum description length (MDL) principle, achieving reasonable success in discovering regular morphological patterns (Brent et al., 1995; Goldsmith, 2000; Creutz and Lagus, 2002; Argamon et al., 2004).
C04-1152 W02-0603
In addition, we measure precision, recall, and F1 as in Schone and Jurafsky (2001).
N01-1024
It is well known that clustering terms from a corpus in English or a related language, using a distance measure based on local co-occurrence, yields clusters that correspond roughly to part of speech categories (Sch¨utze, 1995; Clark, 2000).
W00-0717
