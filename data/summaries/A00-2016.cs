Training on about 40,000 sentences (Collins, 1997) achieves a crossing brackets rate of 1.07, a better value than our 1.63 value for regular parsing or the 1.13 value assuming perfect segmentation/tagging, but even for similar text types, comparisons across languages are of course problematic.
P97-1003
to Parse We base our training on the machine learning based approach of (Hermjakob k: Mooney, 1997), allowing however unrestricted text and deriving the parse action sequences required for training from a treebank.
P97-1062
In the Penn Treebank (Marcus, 1993) for example, the word ago as in 'two years ago', is tagged 122 414 times as an adverb and 150 times as a preposition.
J93-2004
Then, for every step in the parse action sequence, typically several dozens per sentence, we automatically compute the value for every feature in the feature set, add on the parse action as the proper classification of the parse action example, and then feed these examples into a machine learning program, for which we use an extension of decision trees (Quinlan, 1986; Hermjakob & Mooney, 1997).
P97-1062
