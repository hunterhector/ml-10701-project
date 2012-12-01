Unsupervised WSD algorithms fall into two general classes: those that perform token-based WSD by exploiting the similarity or relatedness between an ambiguous word and its context (e.g., Lesk 1986); and those that perform type-based WSD, simply by assigning all instances of an ambiguous word its most frequent (i.e., predominant) sense (e.g., McCarthy et al.2004; Galley and McKeown 2003).
P04-1036
Our rst set of experiments was conducted on the SemCor corpus, on the same 2,595 polysemous nouns (53,674 tokens) used as a test set by McCarthy et al.(2004). These nouns were attested in SemCor with a frequency > 2 and occurred in the British National Corpus (BNC) more than 10 times.
P04-1036
Then, we present a detailed comparison of their performance on SemCor (Miller et al., 1993).
H93-1061
Distributional and WordNet Similarity McCarthy et al.(2004) propose a method for automatically ranking the senses of ambiguous words from raw text.
P04-1036
These include not only domain driven disambiguation algorithms (Strapparava et al., 2004) but also graph theoretic ones (Mihalcea, 2005) as well as algorithms that quantify the degree of association between senses and their co-occurring contexts (Mohammad and Hirst, 2006).
E06-1016 H05-1052
This simple idea has been applied to a variety of classication problems ranging from optical character recognition to medical diagnosis, part-of-speech tagging (see Dietterich 1997 and van Halteren et al.2001 for overviews), and notably supervised 101 WSD (Florian et al., 2002).
J01-2002
Recent studies have also shown that WSD can bene t machine translation (Vickrey et al., 2005) and information retrieval (Stokoe, 2005).
H05-1051 H05-1097
The results for the Similarity method are slightly better than those reported by McCarthy et al.(2004) due to minor improvements in implementation.
P04-1036
We examine several existing and novel combination methods and demonstrate that our combined systems consistently outperform the 97 state-of-the-art (e.g., McCarthy et al.2004). Importantly, our WSD algorithms and combination methods do not make use of training material in any way, nor do they use the rst sense information available in WordNet.
P04-1036
Ng (1997) estimates that a high accuracy domain independent system for WSD would probably need a corpus of about 3.2 million sense tagged words.
W97-0201
Because the SemCor corpus is relatively small (less than 700,00 words), it is not ideal for constructing a neighbor thesaurus appropriate for McCarthy et al.’s (2004) method.
P04-1036
Lexical Chains Lexical cohesion is often represented via lexical chains, i.e., sequences of related words spanning a topical text unit (Morris and Hirst, 1991).
J91-1002
SSI and Extended Gloss Overlap (Overlap) rely on sentencelevel information for disambiguation whereas McCarthy et al.(2004) (Similarity) and Galley and McKeown (2003) (LexChains) utilize the entire document or corpus.
P04-1036
