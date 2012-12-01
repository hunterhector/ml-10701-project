Thus, table 4 shows labeled attachment scores, the main evaluation metric used in the shared task, in comparison to the two highest scoring systems from the original evaluation (McDonald et al., 2006; Nivre et al., 2006).
E06-1010 E06-1011 W06-2932 W06-2933
(Kromann, 2003), the Alpino Treebank of Dutch (van der Beek et al., 2002), the TIGER Treebank of German (Brants et al., 2002), the Floresta Sint´actica of Portuguese (Afonso et al., 2002), and the Slovene Dependency Treebank (Dˇzeroski et al., 2006).4 The data sets used are the training sets from the CoNLLX Shared Task on multilingual dependency parsing (Buchholz and Marsi, 2006), with 20% of the data reservedfortestingusingapseudo-randomsplit.
W06-2920
In order to compare the performance to the state of the art in dependency parsing, we have retrained the non-projective parser on the entire training data set for each language and evaluated it on the final test set from the CoNLL-X shared task (Buchholz and Marsi, 2006).
W06-2920
We have shown that, for languages with a 7McDonald et al.(2006) use post-processing for nonprojectivedependenciesandforlabeling.
E06-1011 W06-2932
And it is rare to find parsers that derive non-projective structures directly, the notable exception being the non-projective spanning tree parser proposed by McDonald et al.(2005). There are essentially two arguments that have been advanced against using parsing algorithms that derive non-projective dependency structures directly.
H05-1066
Nivre (2006) defines degrees ofnon-projectivityintermsofthemaximumnumber ofinterveningconstituentsintheprojectionofasyntactic head and shows that limited degrees of nonprojectivity give a much better fit with the linguistic datathanstrictprojectivity, butalsoenablesmoreefficient processing than unrestricted non-projectivity.
E06-1010 W06-2933
Nivreetal.(2006)use pre-processing of training data and post-processing of parser output to recover non-projective dependencies.
E06-1010 W06-2933
Nivre (2006) presents an empirical study, based on data from the Prague Dependency Treebank of Czech (B¨ohmov´a et al., 2003) and the Danish Dependency Treebank (Kromann, 2003), showing that more than 99.5% of all sentences occurring in the two treebanks have a dependency graph with a maximum degree of 2; about 98% have a maximum degreeof1; butonly77%intheCzechdataand85%in theDanishdatahavedegree0(whichisequivalentto assuming PROJECTIVITY).
E06-1010 W06-2933
This is typically the case in data-driven systems, where LINK(i,j) requires a call to a trained classifier, while PERMISSIBLE(i,j,d) only needs access to the partially built graph G.2 4 History-Based Parsing History-based parsing uses features of the parsing history to predict the next parser action (Black et al., 1992).
H92-1026
Again, however, the results of McDonald et al.(2005) suggest that the latter risk is minimized if inductive learning is used to guide the search.
H05-1066
The first is that the added expressivity compromises efficiency, since the parsing problem for a grammar that allows arbitrary non-projective dependencystructureshasbeenshowntobeNP complete (Neuhaus and Br¨oker, 1997).
P97-1043
Data-driven dependency parsing has been shown to give accurate and efficient parsing for a wide range of languages, such as Japanese (Kudo and Matsumoto, 2002), English (Yamada and Matsumoto, 2003), Swedish (Nivre et al., 2004), Chinese (Cheng et al., 2004), and Czech (McDonald et al., 2005).
H05-1066 P05-1013 W02-2016 W04-2407
The most popular strategy for capturing nonprojective structures in data-driven dependency parsing is to apply some kind of post-processing to the output of a strictly projective dependency parser, as in pseudo-projective parsing (Nivre and Nilsson, 2005), corrective modeling (Hall and Nov´ak, 2005), or approximate non-projective parsing (McDonald and Pereira, 2006).
E06-1011 P05-1013 W05-1505 W06-2932
399 Language Tok Sen T/S Lem CPoS PoS MSF Dep NPT NPS Danish 94 5.2 18.2 no 10 24 47 52 1.0 15.6 Dutch 195 13.3 14.6 yes 13 302 81 26 5.4 36.4 German 700 39.2 17.8 no 52 52 0 46 2.3 27.8 Portuguese 207 9.1 22.8 yes 15 21 146 55 1.3 18.9 Slovene 29 1.5 18.7 yes 11 28 51 25 1.9 22.2 Table 1: Data sets; Tok = number of tokens (*1000); Sen = number of sentences (*1000); T/S = tokens per sentence (mean); Lem = lemmatization present; CPoS = number of coarse-grained part-of-speech tags; PoS = number of (fine-grained) part-of-speech tags; MSF = number of morphosyntactic features (split into atoms); Dep = number of dependency types; NPT = proportion of non-projective dependencies/tokens (%); NPS = proportion of non-projective dependency graphs/sentences (%) The history-based classifier can be trained with any of the available supervised methods for functionapproximation, butintheexperimentsbelowwe will rely on SVM, which has previously shown good performance for this kind of task (Kudo and Matsumoto, 2002; Yamada and Matsumoto, 2003).
W02-2016
Nivre. 2006.
E06-1010 W06-2933
In order to distinguish classes of dependency graphs that fall in between arbitrary non-projective and projective, Nivre (2006) introduces a notion of degree of non-projectivity, such that projective graphs have degree 0 while arbitrary non-projective graphs have unbounded degree.
E06-1010 W06-2933
Moreover, it has better time complexity than the approximate second-order spanning tree parsing of McDonald et al.(2006), which has exponential complexity in the worst case (although this does not appear to be a problem in practice).
E06-1011 W06-2932
This suggests that limited degrees of non-projectivity may allow a parser to capture a larger class of naturally occurring syntactic structures, while still constraining the search to a proper subclass of all possible structures.1 1Alternative notions of mildly non-projective dependency structures are explored in Kuhlmann and Nivre (2006).
E06-1010 P06-2066 W06-2933
On the other hand, most data-driven approaches do not rely on grammars, and with a suitable factorization of dependency structures, it is possible to achieve parsing of unrestrictednon-projectivestructuresinO(n2)time, as shown by McDonald et al.(2005). The second argument against non-projective dependency parsing comes from the observation that, even in languages with free or flexible word order, 396 most dependency structures are either projective or very nearly projective.
H05-1066
This seems to corroborate the results obtained by McDonald et al.(2005) with a different parsing method, showing that the use of inductive learning to guide the search during parsing eliminates the potentially harmful effect of increasing the size of the search space.
H05-1066
However, the results presented by Nivre (2006) are all based on oracle parsing, which means that they only provide upper bounds on the accuracy that can be achieved.
E06-1010 W06-2933
But whereas the spanning tree parser of McDonald et al.(2006) and the pseudo-projective parser of Nivre et al.(2006) achieve this performance only with special preor post-processing,7 the approach presented here derivesalabelednon-projectivegraphinasingleincremental process and hence at least has the advantage of simplicity.
E06-1010 E06-1011 W06-2932 W06-2933
