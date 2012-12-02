The table shows that by using the base line subtree set, our parser outperforms most previous parsers but it performs worse than the parser in Charniak (2000).
A00-2018
The only other model that uses frontier lexicalization and that was tested on the standard WSJ split is Chiang (2000) who extracts a stochastic tree-insertion grammar or STIG (Schabes & Waters 1996) from the WSJ, obtaining 86.6% LP and 86.9% LR for sentences ≤ 40 words.
P00-1058
J. Goodman, 1996.
W96-0214
A major difference between our approach and most other models tested on the WSJ is that the DOP model uses frontier lexicalization while most other models use constituent lexicalization (in that they associate each constituent non terminal with its lexical head -see Collins 1996, 1999; Charniak 1997; Eisner 1997).
P96-1025 P97-1003
Head-lexicalized stochastic grammars have recently become increasingly popular (see Collins 1997, 1999; Charniak 1997, 2000).
A00-2018 P97-1003
Collins 1997, 1999; Charniak 2000), and the current paper has shown the importance of including two and more nonheadwords.
A00-2018 P97-1003
Our highest scores of 90.8% LP and 90.5% LR outperform the scores of the best previously published parser by Charniak (2000) who obtains 90.1% for both LP and LR.
A00-2018
R. Bod, 2000c.
C00-1011 P00-1009
We should note, however, that most other stochastic parsers do include counts of single nonheadwords: they appear in the backed-off statistics of these parsers (see Collins 1997, 1999; Charniak 1997; Goodman 1998).
P97-1003
Schematic overview of the increase of statistical dependencies by stochastic parsers Thus there seems to be a convergence towards a maximalist model which "takes all fragments [...] and lets the statistics decide" (Bod 1998: 5).
P98-1022
While this technique has been successfully applied to parsing the ATIS portion in the Penn Treebank (Marcus et al.1993), it is extremely time consuming.
J93-2004
R. Bod, 2000a.
C00-1011 P00-1009
subtrees) seen in that corpus, regardless of size and lexicalization, are in principle taken to form a grammar (see Bod 1993, 1998; Goodman 1998; Sima'an 1999).
P98-1022
D. Chiang, 2000.
P00-1058
is the Minimal Subtree Set that Achieves Maximal Parse Accuracy? 4.1 The base line For our base line parse accuracy, we used the now standard division of the WSJ (see Collins 1997, 1999; Charniak 1997, 2000; Ratnaparkhi 1999) with sections 2 through 21 for training (approx.
A00-2018 P97-1003
Many stochastic parsing models use linguistic intuitions to find this minimal set, for example by restricting the statistical dependencies to the locality of headwords of constituents (Collins 1997, 1999; Eisner 1997), leaving it as an open question whether there exist important statistical dependencies that go beyond linguistically motivated dependencies.
P97-1003
The importance of structural context is consonant with Johnson (1998) who showed that structural context from higher nodes in the tree (i.e.
J98-4004
The guessed category for each unknown word was converted into a depth-1 subtree and assigned a probability by means of simple Good-Turing estimation (see Bod 1998).
P98-1022
Bonnema et al 1999), including maximum likelihood estimation (Bod 2000b).
C00-1011 P00-1009
J. Goodman, 1997.
W97-0302
Goodman (1996, 1998) showed how DOP1 can be reduced to a compact stochastic contextfree grammar (SCFG) which contains exactly eight SCFG rules for each node in the training set trees.
W96-0214
K. Sima'an, 2000.
P00-1008
These grammars are based on Magerman's headpercolation scheme to determine the headword of each nonterminal (Magerman 1995).
P95-1037
M. Collins, 1997.
P97-1003
Bod, 1992.
C92-3126
These rules are used to create a derivation forest for a sentence (using a CKY parser), and the most probable parse is computed by sampling a sufficiently large number of random derivations from the forest ("Monte Carlo disambiguation", see Bod 1998).
P98-1022
Then we may write: P(t) = | t | Σ t': r(t')= r(t) | t' | In most applications of DOP1, the subtree probabilities are smoothed by the technique described in Bod (1996) which is based on Good-Turing.
W96-0111
D. Magerman, 1995.
P95-1037
As in most other statistical parsing systems we therefore use the pruning technique described in Goodman (1997) and Collins (1999: 263-264) which assigns a score to each item in the chart equal to the product of the inside probability of the item and its prior probability.
W97-0302
This resulted in a base line subtree set of 5,217,529 subtrees which were smoothed by the technique described in Bod (1996) based on Good-Turing.
W96-0111
M. Collins 1996.
P96-1025
While most subtree restrictions diminish the accuracy scores, we will see that there are restrictions that improve our scores, even beyond those of Charniak (2000).
A00-2018
E. Charniak, 2000.
A00-2018
M. Johnson, 1998.
J98-4004
context-free rules Charniak (1996) Collins (1996), Eisner (1996) context-free rules, headwords Charniak (1997) context-free rules, headwords, grandparent nodes Collins (2000) context-free rules, headwords, grandparent nodes/rules, bigrams, two-level rules, two-level bigrams, nonheadwords Bod (1992) all fragments within parse trees Scope of Statistical Dependencies Model Figure 4.
A00-2018 C92-3126 C96-1058 P96-1025 P97-1003
Table 1 shows the LP and LR scores obtained with our base line subtree set, and compares these scores with those of previous stochastic parsers tested on the WSJ (respectively Charniak 1997, Collins 1999, Ratnaparkhi 1999, and Charniak 2000).
A00-2018
Collins 1999; Charniak 2000).
A00-2018
R. Bod, 2000b.
C00-1011 P00-1009
These scores slightly outperform the best previously published parser by Charniak (2000), who obtained 89.5% LP and 89.6% LR for test sentences ≤ 100 words.
A00-2018
J. Eisner, 1996.
C96-1058
Collins 1996; Eisner 1996), later models showed the importance of including context from higher nodes in the tree (Charniak 1997; Johnson 1998).
C96-1058 J98-4004 P96-1025
One may object that this example is somewhat far-fetched, but Chiang (2000) notes that head-lexicalized stochastic grammars fall short in encoding even simple dependency relations such as between left and John in the sentence John should have left . This is because Magerman's head-percolation scheme makes should and have the heads of their respective VPs so that there is no dependency relation between the verb left and its subject John.
P00-1058
The highest scores are obtained if the full base line subtree set is used, but they remain behind the results of Charniak (2000).
A00-2018
R. Bod, 1996.
W96-0111
For words that were unknown in our subtree set, we guessed their categories by means of the method described in Weischedel et al.(1993) which uses statistics on word-endings, hyphenation and capitalization.
J93-2006
In previous experiments with DOP1 on smaller and more restricted domains we found that the parse accuracy decreases also after a certain maximum subtree depth (see Bod 1998; Sima'an 1999).
P98-1022
DOP1 Model To-date, the Data Oriented Parsing model has mainly been applied to corpora of trees whose labels consist of primitive symbols (but see Bod & Kaplan 1998; Bod 2000c, 2001).
C00-1011 P00-1009 P98-1022
Research in this direction is already ongoing, though it has been tested for rather limited subtree depths only (see Sima'an 2000).
P00-1008
Although this heuristic does not guarantee that the most probable parse is actually found, it is shown in Bod (2000a) to perform at least as well as the estimation of the most probable parse with Monte Carlo techniques.
C00-1011 P00-1009
R. Bod, 1998.
P98-1022
