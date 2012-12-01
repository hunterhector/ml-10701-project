Clustering of Text We used the automatic agglomerative mutualinformation-based clustering method of (Ushioda, 1996) to form hierarchical clusters from approximately 50 million words of tokenized, unannotated text drawn from similar domains as the treebank used to train the tagger.
C96-2212
We develop this method starting from a state-of-the-art maximum entropy POS tagger which itself outperforms previous attempts to tag this data (Black et al., 1996b).
C96-1020
The basic engine used to perform the tagging in these experiments is a direct descendent of the maximum entropy (ME) tagger of (Ratnaparkhi, 1996) which in turn is related to the taggers of (Kupiec, 1992) and (Merialdo, 1994).
J94-2001 W96-0213
Typically, the local context around the 215 word to be sense-tagged is used to disambiguate the sense (Yarowsky, 1993), and it is common for linguistic resources such as WordNet (Li et al., 1995; Mihalcea and Moldovan, 1998; Ramakrishnan and Prithviraj, 2004), or bilingual data (Li and Li, 2002) to be employed as well as more longrange context.
H93-1052 P02-1044 W98-0703
In these experiments we used the MXPOST tagger (Ratnaparkhi, 1996) combined withCollins’parser(Collins,1996)toassignparse trees to the corpus.
P96-1025 W96-0213
Li. 2002.
P02-1044
(Black et al., 1996b) adopted a two-stage approach to prediction, first predicting syntax, then semantics given the syntax, whereas in (Black et al., 1998) both syntax and semantics were predicted together in one step.
C96-1020 P98-1020
A.K.Lamjiri, O.ElDemerdash, andL.Kosseim. 2004.
W04-0833
(Lamjiri et al., 2004) also developed an ME-based system that used a very simple set of features: the article before; the POS before and after; the preposition before and after, and the syntactic category before and after the word being labeled.
W04-0833
For detailed presentations, see (Black et al., 1996b; Black et al., 1996a; Black and Finch, 2001).
C96-1020
Knowledge Sources 5.1 Lexical Dependencies Features derived from n-grams of words and tags in the immediate vicinity of the word being tagged have underpinned the world of POS tagging for many years (Kupiec, 1992; Merialdo, 1994; Ratnaparkhi, 1996), and have proven to be useful features in WSD (Yarowsky, 1993).
H93-1052 J94-2001 W96-0213
The semantic tags we use can be seen as a form of semantic categorization acting in a similar manner to the semantic class of a word in the system of (Lamjiri et al., 2004).
W04-0833
Lower-order n-grams which are closer to word being tagged offer the greatest predictive power (Black et al., 1998).
P98-1020
The procedure is explained in detail in (Collins, 1996).
P96-1025
