Lauer (1995) has demonstrated superior performance of the dependency model using a test set of 244 (216 unique) noun compounds drawn from Grolier’s encyclopedia.
P95-1007
The Penn Treebank (Marcus et al., 1993) is perhaps the most in uential resource in Natural Language Processing (NLP).
J93-2004
Bracketing Results With our new data set, we began running experiments similar to those carried out in the literature (Nakov and Hearst, 2005).
W05-0603
Nakov and Hearst (2005) also use web counts, but incorporate additional counts from several variations on simple bigram queries, including queries for the pairs of words concatenated or joined by a hyphen.
W05-0603
We use the Briscoe and Carroll (2006) version of DepBank, a 560 sentence subset used to evaluate the RASP parser.
P06-2006
RECALL F-SCORE Brackets 89.17 87.50 88.33 Dependencies 96.40 96.40 96.40 Brackets, revised 97.56 98.03 97.79 Dependencies, revised 99.27 99.27 99.27 Table 1: Agreement between annotators few weeks, and increased to about 1000 words per hour after gaining more experience (Marcus et al., 1993).
J93-2004
Our initial experiments are presented in Section 6.1. 4 Corpus Creation According to Marcus et al.(1993), asking annotators to markup base-NP structure signi cantly reduced annotation speed, and for this reason baseNPs were left at.
J93-2004
We implement a similar system to 244 CORPUS # ITEMS LEFT RIGHT Penn Treebank 5582 58.99% 41.01% Lauer’s 244 66.80% 33.20% Table 4: Comparison of NP bracketing corpora N-GRAM MATCH Unigrams 51.20% Adjacency bigrams 6.35% Dependency bigrams 3.85% All bigrams 5.83% Trigrams 1.40% Table 5: Lexical overlap Lauer (1995), described in Section 3, and report on results from our own data and Lauer’s original set.
P95-1007
240 2 Motivation Many approaches to identifying base noun phrases have been explored as part of chunking (Ramshaw and Marcus, 1995), but determining sub-NP structure is rarely addressed.
W95-0107
Finally, we test the utility of the extended Treebank for training statistical models on two tasks: NP bracketing (Lauer, 1995; Nakov and Hearst, 2005) and full parsing (Collins, 1999).
P95-1007 W05-0603
Lapata and Keller (2004) derive estimates from web counts, and only compare at a lexical level, achieving 78.7% accuracy.
N04-1016
Process Our annotation guidelines1 are based on those developed for annotating full sub-NP structure in the biomedical domain (Kulick et al., 2004).
W04-3111
