We used Minipar (Lin 1994), a broad coverage parser, to analyze text.
C94-1079
For example, in VERBOCEAN (Chklovski and Pantel 2004), we find the verb relation “to surpass is-stronger-than to hit”, but it is not specified that it is the achieving sense of hit where this relation applies.
W04-3205
Ontologizing semantic resources Recently, researchers have applied textand web-mining algorithms for automatically creating lexical semantic resources like similarity lists (Lin 1998), semantic lexicons (Riloff and Shepherd 1997), hyponymy lists (Shinzato and Torisawa 2004; Pantel and Ravichandran 2004), partwhole lists (Girgu et al.2003), and verb relation graphs (Chklovski and Pantel 2004).
N04-1010 P98-2127 W04-3205 W97-0313
For example, in eXtended WordNet (Harabagiu et al.1999), the rich glosses in WordNet are enriched by disambiguating the nouns, verbs, adverbs, and adjectives with synsets.
W99-0501
Recognizing this, some recent work on wide coverage term banks, like WordNet (Miller 1990) and CYC (Lenat 1995), and annotated corpora, like FrameNet (Baker et al.1998), Propbank (Kingsbury et al.2002) and Nombank (Meyers et al.2004), seeks to address the problem.
P98-1013
Setup We used Minipar (Lin 1994), a broad coverage parser, to parse two 3GB corpora (TREC-9 and TREC-2002).
C94-1079
Following Lin (1998), we measure each feature f for a word e not by its frequency but by its pointwise mutual information, mi ef : 126 ( ) () ()fPeP feP mi ef × =, log 4 Inducing ontological features The resource described in the previous section yields lexical feature vectors for each word in a corpus.
P98-2127
Researchers have mostly looked at representing words by their surrounding words (Lund and Burgess 1996) and by their syntactical contexts (Hindle 1990; Lin 1998).
P90-1034 P98-2127
