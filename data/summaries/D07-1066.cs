Results from Dubey and Keller (2003) suggest that state-of-the-art parsing scores for German are generally lower than those obtained for English, while recent results from K?ubler et al.(2006) raise the possibility that this might be an artefact of particular encoding schemes and data structures of treebanks, which serve as training resources for probabilistic parsers.
P03-1013
K?ubler (2005) and Maier (2006) show that treebank annotation schemes have considerable in uence on parsing results.
P06-3004
A comparison of unlexicalised PCFG parsing (K?ubler, 2005) trained and evaluated on the German NEGRA (Skut et al., 1997) and the T?uBaD/Z (Telljohann et al., 2004) treebanks using LoPar (Schmid, 2000) shows a difference in parsing results of about 16%, using the PARSEVAL metric (Black et al., 1991).
A97-1014 H91-1060
In our second experiment we crucially change the order of events in the K?ubler (2005), Maier (2006) and K?ubler et al.(2006) experiments: We rst extract an unlexicalised PCFG from each of the original treebanks.
P06-3004
In contrast to K?ubler (2005) and Maier (2006), who converted the 634 treebank before extracting the grammars in order to measure the impact of single features like topological elds or unary nodes on PCFG parsing, we convert the trees in the parser output of a parser trained on the original unconverted treebank resources.
P06-3004
Setup For Experiment II we trained BitPar (Schmid, 2004), a parser for highly ambiguous PCFG grammars, on the two treebanks.
C04-1024
II K?ubler (2005) and Maier (2006) assess the impact of the different treebank annotation schemes on PCFG parsing by conducting a number of modi cations converting the T?uBa-D/Z into a format more similar to the NEGRA (and hence TIGER) treebank.
P06-3004
