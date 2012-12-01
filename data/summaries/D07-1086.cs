In particular, we explored many of the sources of information used by Nakov and Hearst (2005a), as well as several novel features that aid segmentation performance and should also prove useful for NC analysis researchers.
H05-1105 W05-0603
For example, Zhai (1997) pointed out that indexing on single-word symbols is not able to distinguish a search for bank terminology from one for terminology bank.
A97-1046
The log of the pointwise mutual information (Church and Hanks, 1989) between the decision-boundary tokens xL0, xR0 is: MI(xL0, xR0) = log Pr(xL0xR0)Pr(x L0)Pr(xR0) This is equivalent to the sum: log C(xL0xR0) + log K log C(xL0) log C(xR0).
P89-1010
Lapata and Keller (2004) rst used web-based co-occurrence counts for the bracketing of NCs.
N04-1016
We also extensively investigated other corpusbased features, such as the number of times the phrase occurred hyphenated or capitalized, and the 4We exclude counts from the training, development, and testing queries discussed in Section 4.1. 822 corpus-based distributional similarity (Lin, 1998) between a pair of tokens.
P98-2127
NC analysis has bene ted from the recent trend of using web-derived features rather than corpusbased counts (Keller and Lapata, 2003).
J03-3005
We then tagged the search queries using a maximum entropy part-of-speech tagger (Ratnaparkhi, 1996).
W96-0213
Collins (2002) for a popular training algorithm.
W02-1001
Recent innovations have been to use statistics beyond the Ngram, such as counting the number of web pages where a pair of words w, x participate in a genitive relationship ( w’s x ), occur collapsed as a single 820 phrase ( wx ) (Nakov and Hearst, 2005a) or have a de nite article as a left-boundary marker ( the w x ) (Nicholson and Baldwin, 2006).
H05-1105 W05-0603 W06-1208
NC bracketing determines the syntactic structure of an NC as expressed by a binary tree, or, equivalently, a binary bracketing (Nakov and Hearst, 2005a).
H05-1105 W05-0603
The computational problem is thus deciding whether the three-word NC has a left or right-bracketing structure (Lauer, 1995).
P95-1007
Web-based statistics have also had an impact on these wider analysis tasks, including work on interpretation of verb nominalisations (Nicholson and Baldwin, 2006) and NC coordination (Nakov and Hearst, 2005b).
H05-1105 W05-0603 W06-1208
Exactly such an evaluation was recently used by Kumaran and Allan (2007) for the related task of query contraction.
N07-1028
Zhai (1997) rst identi ed the importance of syntactic query/corpus parsing for information retrieval, but did not consider query segmentation itself.
A97-1046
As there is growing interest in making maximal use of annotation resources within discriminative learning techniques (Zaidan et al., 2007), developing a general empirical approach to learning from ambiguously-labelled examples would be both an important contribution to this trend and a potentially helpful technique in a number of NLP domains.
N07-1033
