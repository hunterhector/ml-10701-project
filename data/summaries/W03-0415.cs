In Section 4, we show how correctly extracted relationships can be used as “seed-cases” to extract several more relationships, thus improving recall; this work shares some similarities with that of Caraballo (1999).
P99-1016
We used the algorithm of (Widdows and Dorow, 2002) on the British National Corpus to see if many more hyponymy relations would be extracted in this way.
C02-1114
Another definition is given by Caraballo (1999): “.
P99-1016
The goal of extracting semantic information from text is well-established, and has encouraged work on lexical acquisition (Roark and Charniak, 1998), information extraction (Cardie, 1997), and ontology engineering (Hahn and Schnattinger, 1998).
P98-2182
In this paper, we use the hyponymy relationship to describe subset relationships, so we regard y a60 x to be true if the set of y’s can reasonably be said to be a subset of the set of x’s.1 Because hyponymy relationships are so central to knowledge engineering, there have been numerous attempts to learn them from text, beginning with those of Hearst (1992).
C92-2082
This problem has been addressed by Caraballo (1999), who describes a system that first builds an unlabelled hierarchy of noun clusters using agglomerative bottom-up clustering of vectors of noun coordination information.
P99-1016
2 Pattern-Based Hyponymy Extraction The first major attempt to extract hyponyms from text was that of Hearst (1992), described in more detail in (Hearst, 1998), who extracted relationships from the text of Grolier’s Encyclopedia.
C92-2082
First of all, it would be interesting to apply LSA to a system for building an entire hypernym-labelled ontology in roughly the way described in (Caraballo, 1999), perhaps by using an LSA-weighted voting method to determine which hypernym would be used to label each node.
P99-1016
This kind of information from coordination patterns has been used for work in automatic lexical acquisition (Riloff and Shepherd, 1997; Roark and Charniak, 1998; Widdows and Dorow, 2002).
C02-1114 P98-2182 W97-0313
The idea that certain patterns can be identified using finite-state techniques and used as evidence for semantic relationships is the same as Hearst’s (1992), but appears to be more effective for finding just similar words rather than hypernyms because there are many more instances of simple coordination patterns than of hypernymy patterns—in the lists we used to extract these relationships, we see much more cooccurence of words on the same ontological level than between words from different ontological levels.
C92-2082
Using the graph model described above, Widdows and Dorow (2002) developed a combinatoric algorithm for growing clusters from a single seed-word, and used these methods to find correct new members for chosen categories with an accuracy of over 80%.
C02-1114
We believe this is because the classes in (Widdows and Dorow, 2002) are built from carefully selected seedexamples: ours are built from an uncontrolled sample of seed-examples extracted automatically from a corpus.
C02-1114
However, our accuracy falls way short of the figure of 82% reported by Widdows and Dorow (2002).
C02-1114
Hearst. 1992.
C92-2082
