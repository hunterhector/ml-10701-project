In corpus linguistics, cognates have been used for bitext alignment (Simard et al., 1992; Church, 1993; McEnery and Oakes, 1996; Melamed, 1999), and for extracting lexicographically interesting wordpairs from multilingual corpora (Brew and McKelvie, 1996).
J99-1003 P93-1001
The “Reconstruction Engine” of Lowe and Mazaudon (1994) uses a similar strategy of generating proto-projections to establish cognate sets.
J94-3004
Nouns are identified by a part-of-speech tagger (Brill, 1995), which is applied to glosses after prepending them with the string “It is a”.
J95-4004
words that are unrelated.1 In this paper, I present COGIT, a cognate-identification system that combines ALINE (Kondrak, 2000), a feature-based algorithm for measuring phonetic similarity, with a novel procedure for estimating semantic similarity that employs keyword selection and WordNet.
A00-2038
The similarity score returned by ALINE is also normalized, so that it falls in the range a30 0a1 1a31. The implementation of ALINE is described in (Kondrak, 2000).
A00-2038
Church. 1993.
P93-1001
Trask (1996) lists several types of semantic change, including the following: a15 generalization (broadening): ‘partridge’ a16 ‘bird’; a15 specialization (narrowing): ‘berry’ a16 ‘raspberry’; a15 melioration (developing a more favourable sense): ‘woman’ a16 ‘queen’; a15 pejoration (developing a less favourable sense): ‘farm-worker’ a16 ‘villain’; a15 metaphor (extending the literal meaning): ‘steersman’ a16 ‘governor’; 3The idea of using WordNet for the detection of semantic relationships comes from Lowe and Mazaudon (1994) (footnote 13, page 406).
J94-3004
Melamed (1999) uses the Longest Common Subsequence Ratio (LCSR) defined as LCSRa0 xa1 ya2a4a3 a5 LCS a0 x a1 ya2a8a5 maxa0 a5 xa5a12a1a13a5 ya5a14a2 where LCS(x,y) is the longest common subsequence of x and y.
J99-1003
Adjectival modifiers: ‘small stone’ and ‘stone’; 2For a different “phonetic” approach, based on binary articulatory features, see (Nerbonne and Heeringa, 1997).
W97-1102
ALINE (Kondrak, 2000), is an example of the “phonetic” approach.
A00-2038
Church (1993) uses 4-grams at the level of character sequences.
P93-1001
The salience settings were the same as in (Kondrak, 2000), except that the salience of feature “Long” was set to 5.
A00-2038
