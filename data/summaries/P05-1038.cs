(This is true for Collins’ Model 1; note that Dubey and Keller (2003) do report a small improvement for the lexicalized sister-head model.) 8 Related Work We are not aware of any previous attempts to build a probabilistic, treebank-trained parser for French.
P03-1013
Compared to the Penn Treebank (PTB; Marcus et al.1993), the POS tagset of the French Treebank is smaller (13 tags vs.
J93-2004
Following Dubey and Keller (2003), we use a standard unlexicalized PCFG as our baseline.
P03-1013
For example, the compound in Figure 2 results in: (4) (P d’ entre) This approach is similar to the treatment of compounds in the German Negra treebank (used by Dubey and Keller 2003), where compounds are not given any internal structure (compounds are mostly spelled without spaces or apostrophes in German).
P03-1013
A further small improvement was achieved using Dubey and Keller’s (2003) sister-head model; however, again the difference did not reach statistical significance.
P03-1013
The conventional wisdom since Magerman (1995) has been that lexicalization substantially improves performance compared to an unlexicalized baseline model (e.g., a probabilistic context-free grammar, PCFG).
P95-1037
Probabilistic parsing for German has also been explored by a range of authors (Dubey and Keller, 2003; Schiehlen, 2004).
C04-1056 P03-1013
For comparison with Negra, we also include the results of Dubey and Keller (2003): they report the performance of Collins’ Model 1 on a data set of 9,301 sentences and a test set of 1,000 sentences, which are comparable in size to our FTB data sets.4 The results of the crosslinguistic comparison are shown in Table 6.5 We conclude that the effect of 4Dubey and Keller (2003) report only F-scores for the reduced data set (see their Figure 1); the other scores were provided by Amit Dubey.
P03-1013
The only previous authors that have directly addressed the role of lexicalization in crosslinguistic parsing are Dubey and Keller (2003).
P03-1013
The lexicalized parsing experiments were run using Dan Bikel’s probabilistic parsing engine (Bikel, 2002) which in addition to replicating the models described by Collins (1997) also provides a convenient interface to develop corresponding parsing models for other languages.
P97-1003
In general, these authors have found that existing lexicalized parsing models for English (e.g., Collins 1997) do not straightforwardly generalize to new languages; this typically manifests itself in a severe reduction in parsing performance compared to the results for English.
P97-1003
This can be quantified by computing the average number of daughters for each syntactic category in the FTB, and comparing them with the figures available for PTB and Negra (Dubey and Keller, 2003).
P03-1013
Research on German (Dubey and Keller, 2003) showed that lexicalization leads to no sizable improvement in parsing performance for this language.
P03-1013
This means that the probability function Pr in equation (2) is no longer conditioned on the head but instead on its previous sister, yielding the following definition for Pr (and by analogy Pl): Pr(Ri(ri)|P,Ri 1(ri 1),d(i))(4) Dubey and Keller (2003) argue that this implicitly adds binary branching to the grammar, and therefore provides a way of dealing with flat annotation (in Negra and in the FTB, see Table 2).
P03-1013
We conclude that Dubey and Keller’s (2003) results for German can be attributed to a language-specific factor (viz., flexible word order) rather than to an annotation-specific factor (viz., flat annotation).
P03-1013
This is consistent with the findings of Collins et al.(1999) for Czech, where the bigram model upped dependency accuracy by about 0.9%, as well as for English where Charniak (2000) reports an increase in F-score of approximately 0.3%.
A00-2018 P99-1065
Moreover, as Collins (1997) mentions, some of the benefits of Model 2 are already captured by inclusion of the distance measure.
P97-1003
As it stands, Dubey and Keller’s (2003) work does not tell us whether treebank flatness or word order flexibility is responsible for their results: for English, the annotation scheme is non-flat, and the word order is non-flexible; lexicalization improves performance.
P03-1013
This is because the treebanks available for different languages typically vary considerably in size: our FTB training set was about 8,500 sentences large, while the standard training set for the PTB is about 40,000 sentences in size, and the Negra training set used by Dubey and Keller (2003) comprises about 18,600 sentences.
P03-1013
They show that standard lexicalized models fail to outperform an unlexicalized baseline (a vanilla PCFG) on Negra, a German treebank (Skut et al., 1997).
A97-1014
We used BitPar (Schmid, 2004) for our unlexicalized experiments.
C04-1024
Bigram Model This model, inspired by the approach of Collins et al.(1999) for parsing the Prague Dependency Treebank, builds on Collins’ Model 2 by implementing a 1st order Markov assumption for the generation of sister non-terminals.
P99-1065
Interest in parsing models for languages other than English has been growing, starting with work on Czech (Collins et al., 1999) and Chinese (Bikel and Chiang, 2000; Levy and Manning, 2003).
P03-1056 P99-1065 W00-1201
However, this has been challenged by Klein and Manning (2003), who demonstrate that an unlexicalized model can achieve a performance close to the state of the art for lexicalized models.
P03-1054
First, we implemented Dubey and Keller’s (2003) sister-head model, which extends Collins’ base NP model to all syntactic categories.
P03-1013
Furthermore, Bikel (2004) provides evidence that lexical information (in the form of bi-lexical dependencies) only makes a small contribution to the performance of parsing models such as Collins’s (1997).
P97-1003 W04-3224
Previous work for English (e.g., Magerman, 1995; Collins, 1997) has shown that lexicalization leads to a sizable improvement in parsing performance.
P95-1037 P97-1003
No significant improvement could be achieved by switching to Dubey and Keller’s (2003) sister-head model, which has been claimed to be particularly suitable for treebanks with flat annotation, such as the FTB.
P03-1013
