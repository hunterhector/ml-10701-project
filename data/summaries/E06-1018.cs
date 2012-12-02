As known from work on unsupervised part-of-speech tagging (Rohwer and Freitag, 2004; Rapp, 2005), the size of the window in which words will be found similar to the target word plays a decisive role.
P05-3020 W04-2602
This method has been successfully used by other authors as well (Purandare, 2004; Ferret, 2004) because it is straightforward and produces intuitive numbers that help to directly estimate whether the output of a WSI algorithm is meaningful.
C04-1194
Dunning. 1993.
J93-1003
The input to a WSI algorithm is a target word to be disambiguated, e.g. 1Sometimes called word sense discovery (Dorow and Widdows, 2003) or word sense discrimination (Purandare, 2004; Velldal, 2005) space, and the output is a number of word sets representing the various senses, e.g.
E03-1020
The significance values are obtained using the loglikelihood measure assuming a binomial distribution for the unrelatedness hypothesis (Dunning, 1993).
J93-1003
It is also possible to use graph-based clustering techniques to obtain sense representations based on sub-graph density measures (Dorow and Widdows, 2003; Bordag, 2003).
E03-1020
They are all based on co-occurrence statistics, albeit using different context representations such as co-occurrence of words within phrases (Pantel and Lin, 2002; Dorow and Widdows, 2003; Velldal, 2005), bigrams (Sch¨utze, 1998; Neill, 2002; Udani et al., 2005), small windows around a word (Gauch and Futrelle, 1993), or larger contexts such as sentences (Bordag, 2003; Rapp, 2004) or large windows of up to 20 words (Ferret, 2004).
C04-1194 E03-1020
This is not surprising, since with the low frequency words, each occuring only about50times in the BNC, the algorithm runs into the data sparseness problem that has already been pointed out as problematic for WSI (Ferret, 2004).
C04-1194
However, as also pointed out by Yarowsky (1995), this observation does not hold uniformly over all possible co-occurrences of two words.
P95-1026
These reasons have led some researchers to opt for a manual evaluation of their algorithms (Neill, 2002; Rapp, 2004; Udani et al., 2005).
P05-3020
