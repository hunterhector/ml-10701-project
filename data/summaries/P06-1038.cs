(Widdows and Dorow, 2002; Dorow et al, 2005) discover categories using two hard-coded symmetric patterns, and are thus the closest to us.
C02-1114
Hang Li, Naoki Abe, 1996.
C96-1003
This is the same general observation exploited by (Widdows and Dorow, 2002), who try to find graph regions that are more connected internally than externally.
C02-1114
Patrick Pantel, Deepak Ravichandran, Eduard Hovy, 2004.
C04-1111
Named Entity Recognition can be viewed as an instance of our problem where the desired categories contain words that are names of entities of a particular kind, as done in (Freitag, 2004) using coclustering.
W04-3234
This was not needed in (Widdows and Dorow, 2002) because they had directly accessed the word graph, which may be an advantage in some applications.
C02-1114
Hearst (1992) uses a manually prepared set of initial lexical patterns in order to discover hierarchical categories, and utilizes those categories in order to automatically discover additional patterns.
C92-2082
A first major algorithmic approach is to represent word contexts as vectors in some space and use similarity measures and automatic clustering in that space (Curran and Moens, 2002).
W02-0908
(Berland and Charniak, 1999) use hand crafted patterns to discover part-of (meronymy) relationships, and (Chklovski and Pantel, 2004) discover various interesting relations between verbs.
C04-1111 P99-1008 W04-3205
We took the exact 10 WN subsets referred to as ‘subjects’ in (Widdows and Dorow, 2002), and removed all multi-word items.
C02-1114
Caraballo (1999) uses conjunction and appositive annotations in the vector representation.
P99-1016
Timothy Chklovski, Patrick Pantel, 2004.
C04-1111 W04-3205
Fortunately, the subject list is such that WordNet words 5(Widdows and Dorow, 2002) also reports results for an LSA-based clustering algorithm that are vastly inferior to the pattern-based ones.
C02-1114
Note how small they are, when compared to (Pantel et al, 2004), which took 4 days for a smaller corpus using the same CPU.
C04-1111
The (uncorrected) precision is the only metric given in (Widdows and Dorow, 2002), who reported 82% (for the BNC).
C02-1114
References Matthew Berland and Eugene Charniak, 1999.
P99-1008
Dekang Lin, 1998.
P98-2127
Dayne Freitag, 2004.
W04-3234
5.4 WordNet-Based Evaluation The major guideline in this part of the evaluation was to compare our results with previous work having a similar goal (Widdows and Dorow, 2002).
C02-1114
(Pantel et al, 2004) reduce the depth of the linguistic data used but still requires POS tagging.
C04-1111
Agglomerative clustering (e.g., (Brown et al, 1992; Li, 1996)) can produce hierarchical word categories from an unannotated corpus.
C96-1003 J92-4003
Peter Brown, Vincent Della Pietra, Peter deSouza, Jenifer Lai, Robert Mercer, 1992.
J92-4003
Patterns have been shown to produce more accurate results than feature vectors, at a lower computational cost on large corpora (Pantel et al, 2004).
C04-1111
This metric was reported to be 82% in (Widdows and Dorow, 2002).
C02-1114
Dominic Widdows, Beate Dorow, 2002.
C02-1114
Pereira (1993) and Lin (1998) use syntactic features in the vector definition.
P93-1024 P98-2127
Marti Hearst, 1992.
C92-2082
The only difference from the (Widdows and Dorow, 2002) experiment is the usage of pairs rather than single words.
C02-1114
Fernando Pereira, Naftali Tishby, Lillian Lee, 1993.
P93-1024
James Curran, Marc Moens, 2002.
W02-0908
We will eventually combine data from several patterns and from different corpus windows (Section 4.) For identifying symmetric patterns, we use a version of the graph representation of (Widdows and Dorow, 2002).
C02-1114
Sharon Caraballo, 1999.
P99-1016
