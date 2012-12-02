The Satz tokenizer is implemented using the UNIX tool LEX (Lesk and Schmidt 1975) and is modeled on the tokenizer used by the PARTS part-of-speech tagger (Church 1988).
A88-1019
Improving Performance on the Difficult Cases To demonstrate the performance of our system within a large-scale NLP application, we integrated the Satz system into an existing information extraction system, the Alembic system (Aberdeen et al.1995) described in Section 2.2.
M95-1012
example, the sentence alignment algorithm in Gale and Church (1993) allows a distinction between hard and soft boundaries, where soft boundaries are movable by the alignment program.
J93-1004
The systems of Riley (1989) and Wasson report what seem to be slightly better error rates, but these results are not directly comparable since they were evaluated on other collections.
H89-2048
In initial experiments we used the extensive lexicon from the PARTS part-of-speech tagger (Church 1988), which contains 30,000 words.
A88-1019
Artificial neural networks have been successfully applied for many years in speech recognition applications (Bourland and Morgan 1994; Lippmann 1989), and more recently in NLP tasks such as word category prediction (Nakamura et al.1990) and part-of-speech tagging (Schmid 1994).
C90-3038 C94-1027
Riley (1989) describes an approach that uses regression trees (Breiman et al.1984) to classify periods according to the following features: • Probability\[word preceding "".
H89-2048
The success of most natural language processing (NLP) algorithms, including multilingual sentence alignment algorithms (Kay and R6scheisen 1993; Gale and Church 1993), 1 part-of-speech taggers (Cutting et al.1991), and parsers, depends on prior knowledge of the location of sentence boundaries.
J93-1004 J93-1006
E-marl: hearst@parc.xerox.com 1 There is some recent research in aligning bilingual corpora without relying on sentence boundaries (Fung and Church 1994; Fung and McKeown 1994).
C94-2178
Algorithms for decision tree induction (Quinlan 1986; Bahl et al.1989) have been successfully applied to NLP problems such as parsing (Resnik 1993; Magerman 1995) and discourse analysis (Siegel and McKeown 1994; Soderland and Lehnert 1994).
H93-1054 P95-1037
The Alembic information extraction system (Aberdeen et al.1995) contains a very extensive regular-expression-based sentence boundary disambiguation module, created using the lexical scanner generator Flex (Nicol 1993).
M95-1012
Liberman and Church also report that 47% of the periods in the WSJ corpus denote abbreviations (thus a lower bound of 53%), compared to only 10% in the Brown corpus (lower bound 90%) (Riley 1989).
H89-2048
For example, combining our system with a fast sentence alignment program such as that of Gale and Church (1993), which performs alignment at a rate of up to 1,000 sentences/minute, would make it possible to rapidly and accurately create a bilingual aligned corpus from raw parallel texts.
J93-1004
