A pair of sentences is rst fed to a syntactic parser (Charniak, 2000) and then passed to a semantic role labeler (ASSERT; (Pradhan et al., 2004)), to label predicate argument tuples.
A00-2018 N04-1030
A thesaurus constructed from corpus statistics (Lin, 1998) is utilized for the content similarity.
P98-2127
It models the syntactic connection between the constituents on both ends of the path (Gildea and Palmer, 2002; Pradhan et al., 2004).
N04-1030 P02-1031
PR systems that can be broadly categorized as IR-based include (Corley and Mihalcea, 2005; Brockett and Dolan, 2005).
I05-5001 W05-1203
The system performance reported in (CM05; (Corley and Mihalcea, 2005)), which is among the best we are aware of, is also included for comparison.
W05-1203
The Microsoft Research Paraphrase coupus (Dolan et al., 2004) consists of 5801 newswire sentence pairs, 3900 of which are annotated as semantically equivalent by human annotators.
C04-1051
Barzilay and Lee (2003) proposed to apply multiple-sequence alignment (MSA) for traditional, sentence-level PR.
N03-1003
Brockett and Dolan (2005) represented sentence pairs as a feature vector, including features (among others) for sentence length, edit distance, number of shared words, morphologically similar word pairs, synonym pairs (as suggested by WordNet and a semi-automatically constructed thesaurus).
I05-5001
Weeds et al.(2005) addressed this problem by utilizing parses for PR.
W05-1202
One weakness of our system is that we rely on a thesaurus (Lin, 1998) for word similarity information for predicate argument tuple pairing.
P98-2127
Experiments on the widely-used MSR corpus (Dolan et al., 2004) show favorable results.
C04-1051
Wu (2005)’s approach relies on the generative framework of Inversion Transduction Grammar (ITG) to measure how similar two sentences arrange their words based on edit distance.
W05-1205
