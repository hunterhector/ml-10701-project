Recently, there has been much interest in finding words which are distributionally similar e.g., Lin (1998), Lee (1999), Curran and Moens (2002), Weeds (2003) and Geffet and Dagan (2004).
P98-2127 P99-1004 W02-0908 W03-1011
We first looked at the MSR paraphrase corpus (Dolan et al., 2004) since it contains a large number of sentences close enough in meaning to be considered paraphrases.
C04-1051
We then computed the distributional similarity between each co-occurrence vector using the α-skew divergence measure (Lee, 1999).
P99-1004
Co-occurrence vectors for paths are then built up using evidence from multiple occurrences of the paths in corpus data, for which similarity can then be calculated using a standard metric (e.g., Lin (1998)).
P98-2127
However, the α-skew divergence measure has been shown (Weeds, 2003) to perform comparably with measures which use MI, particularly for lower frequency target words.
W03-1011
As noted by Barzilay and Elhadad (2003), even a lexical function that simply computes word overlap can accurately select paraphrases.
W03-1004
This is in contrast to many other measures, e.g., Lin (1998), which use the co-occurrences of features with other words to compute a weighting function such as mutual information (MI) (Church and Hanks, 1989).
P89-1010 P98-2127
Szpektor et al.(2004) automatically identify anchors in web corpus data.
W04-3206
Methods to find the semantic similarity of two words can be broadly split into those which use lexical resources, e.g., WordNet (Fellbaum, 1998), and those which use a distributional similarity measure (see Weeds (2003) for a review of distributional similarity measures).
W03-1011
The Distributional Hypothesis (Harris, 1968) proposes a connection between distributional similarity and semantic similarity, which is the basis for a large body of work on automatic thesaurus construction using distributional similarity methods (Curran and Moens, 2002; Weeds, 2003; Geffet and Dagan, 2004).
W02-0908 W03-1011
This shows that we have extracted a reasonable number of features for each phrase, since distributional similarity techniques have been shown to work well for words which occur more than 100 times in a given corpus (Lin, 1998; Weeds and Weir, 2003).
P98-2127 W03-1011
The similarity between two such vectors or descriptions can then be found using a standard distributional similarity measure (see Weeds (2003)).
W03-1011
